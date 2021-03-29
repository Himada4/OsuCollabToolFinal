using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using OsuCollabTool.CoreClasses;
using System.IO;

namespace OsuCollabTool.Main_Classes
{
    class Common
    {
        public static void SetBtnCol(Color color, params Button[] buttons)
        {
            foreach (var button in buttons)
            {
                button.BackColor = color;
            }
        }

        public static void SetBGCol(Color color, params Control[] BG)
        {
            foreach (var bg in BG)
            {
                bg.BackColor = color;
            }
        }

        public static void ContrastColor(Color color, params Control[] controls) //https://stackoverflow.com/questions/1855884/determine-font-color-based-on-background-color
        {
            int d = 0;

            // Counting the perceptive luminance - human eye favors green color... 
            double luminance = (0.299 * color.R + 0.587 * color.G + 0.114 * color.B) / 255;

            if (luminance > 0.5)
                d = 0; // bright colors - black font
            else
                d = 255; // dark colors - white font

            foreach (var control in controls)
            {
                control.ForeColor = Color.FromArgb(d, d, d);
            } 
        }

        public static Form ReloadChildform(Form childForm, Form newChildForm, Control parentContainer)
        {

            childForm.Close();
            newChildForm.TopLevel = false;
            newChildForm.FormBorderStyle = FormBorderStyle.None;
            newChildForm.Dock = DockStyle.Fill;
            parentContainer.Controls.Add(newChildForm);
            parentContainer.Tag = newChildForm;
            
            newChildForm.Show();

            return newChildForm;
        }

        public static void ReplaceFileWithNewData(string Dir, int SectionToReplace, List<string> newInput)
        {
            

            MapDataExtractor Data = new MapDataExtractor(Dir);

            List<string> General = Data.GetGeneralString();
            List<string> Editor = Data.GetEditorString();
            List<string> Metadata = Data.GetMetadataString();
            List<string> Difficulty = Data.GetDiffString();
            List<string> Events = Data.GetEventsString();
            List<string> TimingPoints = Data.GetTimingPString();
            List<string> Colours = Data.GetColourString();
            List<string> HitObjects = Data.GetHitObjString();

            switch (SectionToReplace)
            {
                case 1:
                    General = newInput;
                    break;
                case 2:
                    Editor = newInput;
                    break;
                case 3:
                    Metadata = newInput;
                    break;
                case 4:
                    Difficulty = newInput;
                    break;
                case 5:
                    Events = newInput;
                    break;
                case 6:
                    TimingPoints = newInput;
                    break;
                case 7:
                    Colours = newInput;
                    break;
                case 8:
                    HitObjects = newInput;
                    break;
            }

            using (StreamWriter sw = new StreamWriter(Dir, false))
            {
                foreach (var line in General)
                {
                    sw.WriteLine(line);
                }
                foreach (var line in Editor)
                {
                    sw.WriteLine(line);
                }
                foreach (var line in Metadata)
                {
                    sw.WriteLine(line);
                }
                foreach (var line in Difficulty)
                {
                    sw.WriteLine(line);
                }
                foreach (var line in Events)
                {
                    sw.WriteLine(line);
                }
                foreach (var line in TimingPoints)
                {
                    sw.WriteLine(line);
                }
                foreach (var line in Colours)
                {
                    sw.WriteLine(line);
                }
                foreach (var line in HitObjects)
                {
                    sw.WriteLine(line);
                }

                sw.Close();
            }

        } 


    }
}
