using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OsuCollabTool.CoreClasses
{
    internal class Difficulty
    {
        private string mapDir = string.Empty;

        public Difficulty(string mapDirIn)
        {
            mapDir = mapDirIn;
        }

        public List<string> GetRawData()
        {
            StreamReader sr = new StreamReader($@"{mapDir}");
            var line = sr.ReadLine();

            List<string> data = new List<string>();

            while (line.Contains("[Difficulty]") == false)
            {
                line = sr.ReadLine();
            }

            while (line.Contains("[Events]") == false)
            {
                data.Add(line);
                line = sr.ReadLine();
            }

            sr.Close();
            return data;
        }

        public string[,] ReadDataFormatted(List<string> inpt)
        {
            inpt.RemoveAt(0);
            inpt.RemoveAt(inpt.Count - 1);
            string[,] result = new string[MapDataExtractor.DataRows, inpt.Count()];
            int uBound0 = result.GetUpperBound(0);
            int uBound1 = result.GetUpperBound(1);

            for (int i = 0; i <= uBound0; i = i + 1)
            {
                for (int j = 0; j <= uBound1; j = j + 1)
                {
                    string[] arr = inpt[j].Split(':');
                    result[i, j] = arr[i];
                }
            }

            return result;
        }
    }
}