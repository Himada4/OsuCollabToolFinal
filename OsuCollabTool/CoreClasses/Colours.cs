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
        StreamReader sr;
        public List<string> GetRawData()
        {
            try 
            {
                sr = new StreamReader($@"{MapDir}");
                var line = sr.ReadLine();

                List<string> Data = new List<string>();

                while (!line.Contains("[Colours]"))
                {
                    line = sr.ReadLine();
                }
                while (!line.Contains("[HitObjects]"))
                {
                    Data.Add(line);
                    line = sr.ReadLine();
                }

                sr.Close();
                return Data;
            }
            catch
            {
                sr.Close();
                return new List<string>() {""};
            }
        }
    }
} 
