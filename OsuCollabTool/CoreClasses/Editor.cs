using System.Collections.Generic;
using System.IO;

namespace OsuCollabTool.CoreClasses
{
    internal class Editor
    {
        private string mapDir = string.Empty;

        public Editor(string mapDirIn)
        {
            mapDir = mapDirIn;
        }

        public List<string> GetRawData()
        {
            StreamReader sr = new StreamReader($@"{mapDir}");
            var line = sr.ReadLine();

            List<string> data = new List<string>();

            while (line.Contains("[Editor]") == false)
            {
                line = sr.ReadLine();
            }

            while (line.Contains("[Metadata]") == false)
            {
                data.Add(line);
                line = sr.ReadLine();
            }

            sr.Close();
            return data;
        }
    }
}