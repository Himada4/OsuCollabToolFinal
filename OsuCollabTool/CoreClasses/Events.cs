using System.Collections.Generic;
using System.IO;

namespace OsuCollabTool.CoreClasses
{
    internal class Events
    {
        private string mapDir = string.Empty;

        public Events(string mapDirIn)
        {
            mapDir = mapDirIn;
        }

        public List<string> GetRawData()
        {
            StreamReader sr = new StreamReader($@"{mapDir}");
            var line = sr.ReadLine();

            List<string> data = new List<string>();

            while (line.Contains("[Events]") == false)
            {
                line = sr.ReadLine();
            }

            while (line.Contains("[TimingPoints]") == false)
            {
                data.Add(line);
                line = sr.ReadLine();
            }

            sr.Close();
            return data;
        }
    }
}