using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OsuCollabTool.CoreClasses
{
    class TimingPoints
    {
        string mapDir = string.Empty;

        public TimingPoints(string mapDirIn)
        {
            mapDir = mapDirIn;
        }

        public List<string> GetRawData()
        {
            StreamReader sr = new StreamReader($@"{mapDir}");
            var line = sr.ReadLine();

            List<string> data = new List<string>();

            while (!line.Contains("[TimingPoints]"))
            {
                line = sr.ReadLine();
            }
            
            while (!line.Contains("[Colours]")  && !line.Contains("[HitObjects]") )
            {
                data.Add(line);
                line = sr.ReadLine();
            }

            sr.Close();
            return data;
        }
    }
}
