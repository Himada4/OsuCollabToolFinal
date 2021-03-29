using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace OsuCollabTool.UI
{
    internal class UIDataOverwriter
    {
        private string songFolder;
        private Color[] theme;
        private int[] buttonOrder;
        private string currentFolder;
        private string currentOsu;

        public UIDataOverwriter()
        {
        }

        public void SetSongFol(string inp)
        {
            songFolder = inp;
        }

        public void SetTheme(Color[] inp)
        {
            theme = inp;
        }

        public void SetButOrd(int[] inp)
        {
            buttonOrder = inp;
        }

        public void SetCurrFol(string inp)
        {
            currentFolder = inp;
        }

        public void SetCurrOsu(string inp)
        {
            currentOsu = inp;
        }

        public void UpdateUIData() // https://www.youtube.com/watch?v=hs74fKPJpFw
        {
            // theme colors
            List<int> red = new List<int>();
            List<int> green = new List<int>();
            List<int> blue = new List<int>();

            foreach (var item in theme)
            {
                red.Add(item.R);
                green.Add(item.G);
                blue.Add(item.B);
            }

            string col1 = $"{red[0]},{green[0]},{blue[0]}";
            string col2 = $"{red[1]},{green[1]},{blue[1]}";
            string col3 = $"{red[2]},{green[2]},{blue[2]}";

            string themeFinal = $"{col1};{col2};{col3}";

            // buttonOrder
            List<string> btnList = new List<string>();
            for (int i = 0; i < buttonOrder.Length; i = i + 1)
            {
                btnList.Add(buttonOrder[i].ToString());
            }

            string btnOrdFinal = string.Join(",", btnList);

            // Overwriting of UIData.txt
            using (StreamWriter sw = new StreamWriter("UIData.txt", false))
            {
                sw.WriteLine($"SongsFolder={songFolder}");
                sw.WriteLine($"Theme={themeFinal}");
                sw.WriteLine($"ButtonOrder={btnOrdFinal}");
                sw.WriteLine($"CurrentFolder={currentFolder}");
                sw.WriteLine($"CurrentOsu={currentOsu}");

                sw.Close();
            }
        }
    }
}