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

        public bool IsCorrupted = false;
        public Wallpaper(string name, string pathToVideo, string pathToLogo)
        {
            Name = name;
            PathToVideo = pathToVideo;
            PathToLogo = pathToLogo;
        }
    }
}
