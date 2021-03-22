using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace OsuCollabTool.UI
{
    class UIDataExtractor
    {
        string SongFolder;
        Color[] Theme;
        int[] ButtonOrder;
        string CurrentFolder;
        string CurrentOsu;
        

        public UIDataExtractor()
        {
            refresh();
        } 

        public string getSongFol()
        {
            return SongFolder;
        }

        public Color[] getTheme()
        {
            return Theme;
        }
        public int[] getButOrd()
        {
            return ButtonOrder;
        }
        public string getCurrFol()
        {
            return CurrentFolder;
        }
        public string getCurrOsu()
        {
            return CurrentOsu;
        }
        

        public void refresh()
        {
            StreamReader sr = new StreamReader("UIData.txt");
            var line = sr.ReadLine();
            List<string> list = new List<string>();
            int itemData = 1;
            int i = 0;
            while (line != null)
            {
                
                switch (i)
                {
                    case 0:
                        string[] son = line.Split('=');
                        SongFolder = son[itemData];
                        break;
                    case 1:
                        string[] the = line.Split('=');
                        string main = the[itemData];
                        string[] colData = main.Split(';');
                        Color[] sonRes = new Color[3];
                        for (int j = 0; j < colData.Length; j = j + 1)
                        {
                            string[] sepColor = colData[j].Split(',');

                            Color col = Color.FromArgb(Convert.ToInt32(sepColor[0]), Convert.ToInt32(sepColor[1]), Convert.ToInt32(sepColor[2]));
                            sonRes[j] = col;
                        }

                        Theme = sonRes;
                        break;
                    case 2:
                        string[] but = line.Split('=');
                        string split = but[itemData];
                        string[] butRes = split.Split(',');
                        ButtonOrder = new int[] { Convert.ToInt32(butRes[0]), Convert.ToInt32(butRes[1]), Convert.ToInt32(butRes[2]), Convert.ToInt32(butRes[3]) };
                        break;
                    case 3:
                        string[] fold = line.Split('=');
                        CurrentFolder = fold[itemData];
                        break;
                    case 4:
                        string[] osu = line.Split('=');
                        CurrentOsu = osu[itemData];
                        break;
                    
                }
                i = i + 1;
                list.Add(line);
                line = sr.ReadLine();
            }

            sr.Close();
        }

    }
}
