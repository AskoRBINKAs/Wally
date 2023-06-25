using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wally
{
    public class Wallpaper
    {
        public string Name { get; set; }
        public string PathToVideo { get; set; }
        public string PathToLogo { get; set; }
        public int Index { get; set; }  

        public bool IsCorrupted = false;
        public bool IsWeb { get; set; }
        public Wallpaper(string name, string pathToVideo, string pathToLogo, bool isWeb)
        {
            Name = name;
            PathToVideo = pathToVideo;
            PathToLogo = pathToLogo;
            IsWeb = isWeb;
        }
    }
}
