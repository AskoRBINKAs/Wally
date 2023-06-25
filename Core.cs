using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Wally
{
    public class Core
    {
        public string Version = "v1.2";
        public string WPPath;
        public string WebViewPath;
        public string JSONSavePath;
        public string ConfigFile;
        public string ExecutionPath = "";
        public string PlaylistSavePath = "";
        public string Language = "en";
        public string LastWallpaperName = "";
        public string AdditionalMPVArgs = "";
        public string DefaultMPVArgs = " run mpv --force-window=yes --loop=inf --hwdec=auto --vo=gpu --no-correct-pts --player-operation-mode=pseudo-gui ";
        public StringBuilder logs;
        public int WeebPID = -1;
        public int Framerate = 15;
        public int Volume = 0;
        public List<Wallpaper> Walls;
        public List<Wallpaper> Playlist;
        public bool logging = false;

        private Configuration _configuration;
        public Core(string wpath,string jsonpath, string cfgpath, string webviewpath, string executionPath)
        {
            logs = new StringBuilder();
            WPPath = wpath;
            JSONSavePath = jsonpath;
            ConfigFile = cfgpath;
            WebViewPath = webviewpath;
            LoadConfig();
            GetMPVPID();
            LoadWallpapers();
            ExecutionPath = executionPath;
        }



        public void SaveConfig()
        {
            _configuration.isLogging = logging;
            _configuration.FPS = Framerate;
            _configuration.Language = Language;
            _configuration.AdditionalArguments = AdditionalMPVArgs;
            _configuration.LastPlayedWallpaper = LastWallpaperName;
            _configuration.Volume = Volume;
            using(StreamWriter sw = new StreamWriter(ConfigFile, append: false))
            {
                sw.WriteLine(JsonSerializer.Serialize(_configuration));
            }
            
        }
        public void LoadConfig()
        {
            if (File.Exists(ConfigFile))
            {
                _configuration = JsonSerializer.Deserialize<Configuration>(File.ReadAllText(ConfigFile));
                if (_configuration != null)
                {
                    Language = _configuration.Language;
                    LastWallpaperName = _configuration.LastPlayedWallpaper;
                    AdditionalMPVArgs = _configuration.AdditionalArguments;
                    logging = _configuration.isLogging;
                    Framerate = _configuration.FPS;
                    Volume = _configuration.Volume;
                }
                else
                {
                    _configuration = new Configuration();
                    Log("Configuration file corrupted");
                }
            }
            else
            {
                Log("Configuration file does not exist. It will be created for next time");
                Language = "en";
                LastWallpaperName = "";
                _configuration = new Configuration();
            }
        }
        public void Log(string info)
        {
            if (logging)
            {
                logs.AppendLine("[" + DateTime.Now.ToString() + "] : " + info);
            }
        }
        public void LoadWallpapers()
        {
            if (File.Exists(JSONSavePath))
            {
                Walls = JsonSerializer.Deserialize<List<Wallpaper>>(File.ReadAllText(JSONSavePath));
                int counter = 0;
                foreach(var wall in Walls)
                {
                    wall.Index = counter;
                    if (!File.Exists(wall.PathToVideo))
                    {
                        Log(wall.Name + " was corrupted, removed or replaced. Check it please");
                        wall.IsCorrupted = true;
                    }
                    counter++;
                }
                Log("Wallpapers was loaded from save.json");
            }
            else
            {
                Walls = new List<Wallpaper>();
                Log("save.json does not exist. Created empty list");
            }
            
        }
        public void AddWallpaper(ref string PathToProjectFile)
        {
            try
            {
                Wallpaper wallpaper;
                string fullpath = PathToProjectFile.Replace("project.json", "");
                using (StreamReader sr = new StreamReader(PathToProjectFile))
                {
                    string data = sr.ReadToEnd();
                    if (data == null) return;
                    else wallpaper = JsonSerializer.Deserialize<Wallpaper>(data);
                    wallpaper.PathToVideo = fullpath + wallpaper.PathToVideo;
                    wallpaper.PathToLogo = fullpath + wallpaper.PathToLogo;
                    Walls.Add(wallpaper);
                }
                using (StreamWriter sw = new StreamWriter(JSONSavePath, append: false))
                {
                    sw.WriteLine(JsonSerializer.Serialize(Walls));
                }
                Log("Wallpaper was added successfully from file " + PathToProjectFile);
            }
            catch (Exception e)
            {
                Log("Caused error while adding new wallpaper. If you think it's bug - report it.");
                Log(e.ToString());
            }
        }
        public void AddWallpaper(Wallpaper wallpaper)
        {
            Walls.Add(wallpaper);
            using (StreamWriter sw = new StreamWriter(JSONSavePath, append: false))
            {
                sw.WriteLine(JsonSerializer.Serialize(Walls));
            }
            Log("Wallpaper was added successfully from redactor");

        }
        public void SaveWallpapers()
        {
            using (StreamWriter sw = new StreamWriter(JSONSavePath, append: false))
            {
                sw.WriteLine(JsonSerializer.Serialize(Walls));
            }
            Log("Wallpapers saved successfuly");
        }

        public void KillPreviousMPV()
        {
            int counter = 0;
            Log("Trying to kill MPV processes");
            foreach (var procces in Process.GetProcessesByName("mpv"))
            {
                procces.Kill();
                counter++;
            }
            Log(counter.ToString() + " MPV processes was killed");
            foreach(var process in Process.GetProcessesByName("wp"))
            {
                process.Kill();
            }
            foreach(var process in Process.GetProcessesByName("webView"))
            {
                process.Kill();
            }
            try
            {
                Process killer = new Process();
                killer.StartInfo.FileName = WPPath;
                killer.StartInfo.Arguments = " killall";
                killer.Start();
            }
            catch (Exception e){
                Log(e.ToString());
            }

        }
        public void GetMPVPID()
        {
            try
            {
                Process proc1 = new Process();
                proc1.StartInfo.FileName = WPPath;
                proc1.StartInfo.Arguments = " run";
                proc1.Start();
                Process process = new Process();
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.FileName = WPPath;
                process.StartInfo.Arguments = "id";
                process.Start();
                string result = process.StandardOutput.ReadToEnd();
                WeebPID = int.Parse(result);
                Log("Current Weebp PID: " + WeebPID.ToString());
            }
            catch (Exception ex)
            {
                Log("Caused error while getting Weebp PID");
                Log(ex.ToString());
            }
        }
        public void SetWallpaper(ref string PathToVideo)
        {
            KillPreviousMPV();
            GetMPVPID();
            Process process = new Process();
            process.StartInfo.FileName = WPPath;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.Arguments = DefaultMPVArgs+AdditionalMPVArgs+ " --volume="+Volume.ToString()+" --fps=" + Framerate+" --wid=" + WeebPID.ToString() + " \"" +PathToVideo + "\"";
            process.Start();
            Log("Setting wallpaper from " + PathToVideo);
        }

        public void SetWebWallpaper(ref string URL)
        {
            KillPreviousMPV();
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = @"/C" + ExecutionPath + "web.bat \"" + URL+"\"";
            process.Start();
        }
    }
}
