using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OsuCollabTool.CoreClasses
{
    class Colours
    {
        string MapDir = "";
        public Colours(string MapDirIn)
        {
            MapDir = MapDirIn;
        }
        public List<string> GetRawData()
        {
            StreamReader sr = new StreamReader($@"{MapDir}");
            var line = sr.ReadLine();

            List<string> Data = new List<string>();

            while (line.Contains("[Colours]") == false)
            {
                line = sr.ReadLine();
            }
            while (line.Contains("[HitObjects]") == false)
            {
                Data.Add(line);
                line = sr.ReadLine();
            }
            sr.Close();
            return Data;
        }
    }
}
