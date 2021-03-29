using OsuCollabTool.CoreClasses;
using OsuCollabTool.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OsuCollabTool.Main_Classes.SongSetupFunc
{
    public partial class GeneralTabIntf : Form
    {
        private string dir = string.Empty;
        private string[] generalVar;

        public GeneralTabIntf()
        {
            InitializeComponent();

            generalVar = new string[] { "AudioFilename", "AudioLeadIn", "PreviewTime", "Countdown", "SampleSet", "StackLeniency", "Mode", "LetterboxInBreaks", "UseSkinSprites", "OverlayPosition", "SkinPreference", "EpilepsyWarning", "CountdownOffset", "SpecialStyle", "WidescreenStoryboard", "SamplesMatchPlaybackRate" };

            UIDataExtractor ext = new UIDataExtractor();
            Color[] theme = ext.GetTheme();

            //Interface Theme Set
            Common.SetBGCol(theme[2], MainBG, SubBG);
            Common.SetBtnCol(theme[1], SaveChangesBtn);
            Common.ContrastColor(theme[1], SaveChangesBtn);
            Common.ContrastColor(theme[2], StringInptGroupBox, IntInptGroupBox, BoolInptGroupBox, l1, l2, l3, l4, l5, l6, l7, l8, l9, l10, l11, l12, l13, l14, l15, l16, l17, l18, LinkToOsuFileFormat);

            Queue<Control> tB = new Queue<Control>();
            tB.Enqueue(AFTextbox);
            tB.Enqueue(ALTextbox);
            tB.Enqueue(PTTextbox);
            tB.Enqueue(CDTextbox);
            tB.Enqueue(SSTextbox);
            tB.Enqueue(SLTextbox);
            tB.Enqueue(MTextbox);
            tB.Enqueue(LIBPanel);
            tB.Enqueue(USSPanel);
            tB.Enqueue(OPTextbox);
            tB.Enqueue(SPTextbox);
            tB.Enqueue(EWPanel);
            tB.Enqueue(CDOTextbox);
            tB.Enqueue(SSPanel);
            tB.Enqueue(WSPanel);
            tB.Enqueue(SMPRPanel);

            //fill in blanks
            dir = $@"{ext.GetSongFol()}{ext.GetCurrFol()}{ext.GetCurrOsu()}";

            MapDataExtractor mapData = new MapDataExtractor(dir);

            string[,] mapArr = mapData.GetGeneral();
            List<int> existingVal = new List<int>();

            for (int j = 0; j < generalVar.Length; j = j + 1)
            {
                Control control = tB.Dequeue();
                for (int i = 0; i <= mapArr.GetUpperBound(1); i = i + 1)
                {
                    if (mapArr[0, i] == generalVar[j])
                    {
                        if (control is TextBox)
                        {
                            string TextToInput = mapArr[1, i];
                            control.Text = TextToInput.Replace(" ", string.Empty);
                        }
                        else
                        {
                            foreach (Control radio in control.Controls)
                            {
                                if (radio is RadioButton)
                                {
                                    string value = mapArr[1, i];
                                    if (Convert.ToInt32(value) == 0)
                                    {
                                        if ((string)radio.Tag == "0")
                                        {
                                            (radio as RadioButton).Checked = true;
                                        }
                                    }
                                    else
                                    {
                                        if (Convert.ToInt32(value) == 1)
                                        {
                                            if ((string)radio.Tag == "1")
                                            {
                                                (radio as RadioButton).Checked = true;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        existingVal.Add(j);
                        break;
                    }
                }
            }
        }

        // Gives user the link to know the defenitions of the parameters
        private void LinkToOsuFileFormat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://osu.ppy.sh/wiki/fi/osu!_File_Formats/Osu_(file_format)");
        }

        // Saves changes, overwrites it on the .osu file
        private void SaveChangesBtn_Click(object sender, EventArgs e)
        {
            Queue<Control> tB = new Queue<Control>();
            tB.Enqueue(AFTextbox);
            tB.Enqueue(ALTextbox);
            tB.Enqueue(PTTextbox);
            tB.Enqueue(CDTextbox);
            tB.Enqueue(SSTextbox);
            tB.Enqueue(SLTextbox);
            tB.Enqueue(MTextbox);
            tB.Enqueue(LIBPanel);
            tB.Enqueue(USSPanel);
            tB.Enqueue(OPTextbox);
            tB.Enqueue(SPTextbox);
            tB.Enqueue(EWPanel);
            tB.Enqueue(CDOTextbox);
            tB.Enqueue(SSPanel);
            tB.Enqueue(WSPanel);
            tB.Enqueue(SMPRPanel);

            List<string> newInput = new List<string>();

            int length = tB.Count;

            newInput.Add("osu file format v14");
            newInput.Add(string.Empty);
            newInput.Add("[General]");

            for (int i = 0; i < length; i = i + 1)
            {
                Control control = tB.Dequeue();
                if (control is TextBox)
                {
                    if (control.Text == string.Empty)
                    {
                    }
                    else
                    {
                        newInput.Add($"{generalVar[i]}:{control.Text}");
                    }
                }
                else
                {
                    foreach (var radio in control.Controls)
                    {
                        if (radio is RadioButton)
                        {
                            if ((radio as RadioButton).Checked == true && (string)(radio as RadioButton).Tag == "0")
                            {
                                newInput.Add($"{generalVar[i]}:0");
                                break;
                            }
                            else if ((radio as RadioButton).Checked == true && (string)(radio as RadioButton).Tag == "1")
                            {
                                newInput.Add($"{generalVar[i]}:1");
                                break;
                            }
                        }
                    }
                }
            }

            newInput.Add(string.Empty);

            Common.ReplaceFileWithNewData(dir, 1, newInput);
        }
    }
}