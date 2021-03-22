using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OsuCollabTool.CoreClasses
{
    class Difficulty
    {
        string MapDir = "";
        public Difficulty(string MapDirIn)
        {
            MapDir = MapDirIn;
        }
        public List<string> GetRawData()
        {
            StreamReader sr = new StreamReader($@"{MapDir}");
            var line = sr.ReadLine();

            List<string> Data = new List<string>();

            while (line.Contains("[Difficulty]") == false)
            {
                line = sr.ReadLine();
            }

            while (line.Contains("[Events]") == false)
            {
                Data.Add(line);
                line = sr.ReadLine();
            }
            sr.Close();
            return Data;
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
