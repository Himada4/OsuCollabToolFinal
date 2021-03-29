using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace OsuCollabTool.UI
{
    internal class UIDataExtractor
    {
        private string songFolder;
        private Color[] theme;
        private int[] buttonOrder;
        private string currentFolder;
        private string currentOsu;

        public UIDataExtractor()
        {
            Refresh();
        }

        public string GetSongFol()
        {
            return songFolder;
        }

        public Color[] GetTheme()
        {
            return theme;
        }

        public int[] GetButOrd()
        {
            return buttonOrder;
        }

        public string GetCurrFol()
        {
            return currentFolder;
        }

        public string GetCurrOsu()
        {
            return currentOsu;
        }

        public void Refresh()
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
                        songFolder = son[itemData];
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

                        theme = sonRes;
                        break;

                    case 2:
                        string[] but = line.Split('=');
                        string split = but[itemData];
                        string[] butRes = split.Split(',');
                        buttonOrder = new int[] { Convert.ToInt32(butRes[0]), Convert.ToInt32(butRes[1]), Convert.ToInt32(butRes[2]), Convert.ToInt32(butRes[3]) };
                        break;

                    case 3:
                        string[] fold = line.Split('=');
                        currentFolder = fold[itemData];
                        break;

                    case 4:
                        string[] osu = line.Split('=');
                        currentOsu = osu[itemData];
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