using System.Collections.Generic;
using System.IO;

namespace OsuCollabTool.CoreClasses
{
    internal class Colours
    {
        private string mapDir = string.Empty;

        public Colours(string mapDirIn)
        {
            mapDir = mapDirIn;
        }

        private StreamReader sr;

        public List<string> GetRawData()
        {
            try
            {
                sr = new StreamReader($@"{mapDir}");
                var line = sr.ReadLine();

                List<string> data = new List<string>();

                while (!line.Contains("[Colours]"))
                {
                    line = sr.ReadLine();
                }

                while (!line.Contains("[HitObjects]"))
                {
                    data.Add(line);
                    line = sr.ReadLine();
                }

                sr.Close();
                return data;
            }
            catch
            {
                sr.Close();
                return new List<string>() { string.Empty };
            }
        }
    }
}