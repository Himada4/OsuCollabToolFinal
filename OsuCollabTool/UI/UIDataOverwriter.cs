using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace OsuCollabTool.UI
{
    internal class UIDataOverwriter
    {
        private string SongFolder;
        private Color[] Theme;
        private int[] ButtonOrder;
        private string CurrentFolder;
        private string CurrentOsu;
        

        public UIDataOverwriter()
        {
        }

        public void setSongFol(string inp)
        {
            SongFolder = inp;
        }

        public void setTheme(Color[] inp)
        {
            Theme = inp;
        }

        public void setButOrd(int[] inp)
        {
            ButtonOrder = inp;
        }

        public void setCurrFol(string inp)
        {
            CurrentFolder = inp;
        }

        public void setCurrOsu(string inp)
        {
            CurrentOsu = inp;
        }

        

        public void UpdateUIData() //https://www.youtube.com/watch?v=hs74fKPJpFw
        {

            //Theme
            string ThemeFinal = "";
            List<int> Red = new List<int>();
            List<int> Green = new List<int>();
            List<int> Blue = new List<int>();
            

            foreach (var item in Theme)
            {
                Red.Add(item.R);
                Green.Add(item.G);
                Blue.Add(item.B);
            }

            string Col1 = $"{Red[0]},{Green[0]},{Blue[0]}";
            string Col2 = $"{Red[1]},{Green[1]},{Blue[1]}";
            string Col3 = $"{Red[2]},{Green[2]},{Blue[2]}";

            ThemeFinal = $"{Col1};{Col2};{Col3}";


            //ButtonOrder


            List<string> btnList = new List<string>();
            for (int i = 0; i < ButtonOrder.Length; i = i + 1) 
            {
                 
                btnList.Add(ButtonOrder[i].ToString());
                
            } 

            string btnOrdFinal = string.Join(",", btnList);



            /*
            StreamWriter sw = new StreamWriter("UIData.txt");
            sw.WriteLine($"SongsFolder:{SongFolder}");
            sw.WriteLine($"Theme:{ThemeFinal}");
            sw.WriteLine($"ButtonOrder:{btnOrdFinal}");
            sw.WriteLine($"CurrentFolder:{CurrentFolder}");
            sw.WriteLine($"CurrentOsu:{CurrentOsu}");
            sw.WriteLine($"Orientation:{Orientation}");
            */

            
            using (StreamWriter sw = new StreamWriter("UIData.txt",false))
            {
                sw.WriteLine($"SongsFolder={SongFolder}");
                sw.WriteLine($"Theme={ThemeFinal}");
                sw.WriteLine($"ButtonOrder={btnOrdFinal}");
                sw.WriteLine($"CurrentFolder={CurrentFolder}");
                sw.WriteLine($"CurrentOsu={CurrentOsu}");
                
                sw.Close();
            }




        }

    }
}




