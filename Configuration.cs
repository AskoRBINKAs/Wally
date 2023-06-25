using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wally
{
    internal class Configuration
    {
        public string LastPlayedWallpaper { get; set; }
        public string Language { get; set; }
        public int Volume { get; set; }
        public string AdditionalArguments { get; set; }
        public int FPS { get; set; }
        public bool isLogging { get; set; }

    }
}
