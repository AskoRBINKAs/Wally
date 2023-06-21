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
        /*
         * Methods and params for playlist now are empty, but in next updates will be created
         */
        public string Version = "v1.1";
        public string WPPath;
        public string JSONSavePath;
        public string ConfigFile;
        public string PlaylistSavePath = "";
        public string Language = "en";
        public string LastWallpaperName = "";
        public StringBuilder logs;
        public int WeebPID = -1;
        public int Framerate = 15;
        public List<Wallpaper> Walls;
        public List<Wallpaper> Playlist;

        public Core(string wpath,string jsonpath, string cfgpath)
        {
            logs = new StringBuilder();
            WPPath = wpath;
            JSONSavePath = jsonpath;
            ConfigFile = cfgpath;

            LoadConfig();
            GetMPVPID();
            LoadWallpapers();
            LoadPlaylist();
            
            
        }

        public void LoadPlaylist()
        {
            return;
        }

        public void SavePlaylist()
        {
            return;
        }
        public void SaveConfig()
        {
            return;
        }
        public void LoadConfig()
        {
            if (File.Exists(ConfigFile))
            {
                using (StreamReader streamReader = new StreamReader(ConfigFile))
                {
                    List<string> props = new List<string>();
                    while (!streamReader.EndOfStream)
                    {
                        props.Add(streamReader.ReadLine());
                    }
                    Language = props[0];
                    LastWallpaperName = props[1];
                } 
            }
            else
            {
                Log("Configuration file does not exist. It will be created for next time");
                Language = "en";
                LastWallpaperName = "";
            }
        }
        public void Log(string info)
        {
            logs.AppendLine("["+DateTime.Now.ToString()+"] : "+info);
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
            process.StartInfo.Arguments = " run mpv --force-window=yes --loop=inf --no-audio  --fps="+Framerate+" -no-correct-pts --player-operation-mode=pseudo-gui --wid=" + WeebPID.ToString() + " \"" +PathToVideo + "\"";
            
            process.Start();
            Log("Setting wallpaper from " + PathToVideo);
        }

        
        public void PlayPlaylist()
        {
            
        }


    }
}
