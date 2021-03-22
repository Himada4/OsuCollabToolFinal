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
        private string Dir = "";
        private string[] GeneralVar;

        public GeneralTabIntf()
        {
            InitializeComponent();

            GeneralVar = new string[] { "AudioFilename", "AudioLeadIn", "PreviewTime", "Countdown", "SampleSet", "StackLeniency", "Mode", "LetterboxInBreaks", "UseSkinSprites", "OverlayPosition", "SkinPreference", "EpilepsyWarning", "CountdownOffset", "SpecialStyle", "WidescreenStoryboard", "SamplesMatchPlaybackRate" };

            UIDataExtractor ext = new UIDataExtractor();
            Color[] Theme = ext.getTheme();

            //Interface Theme Set
            Common.setBGCol(Theme[2], MainBG, SubBG);
            Common.setBtnCol(Theme[1], SaveChangesBtn);
            Common.ContrastColor(Theme[1], SaveChangesBtn);
            Common.ContrastColor(Theme[2], StringInptGroupBox, IntInptGroupBox, BoolInptGroupBox, l1, l2, l3, l4, l5, l6, l7, l8, l9, l10, l11, l12, l13, l14, l15, l16, l17, l18, LinkToOsuFileFormat);

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
            Dir = $@"{ext.getSongFol()}{ext.getCurrFol()}{ext.getCurrOsu()}";

            MapDataExtractor mapData = new MapDataExtractor(Dir);

            string[,] mapArr = mapData.GetGeneral();
            List<int> ExistingVal = new List<int>();

            for (int j = 0; j < GeneralVar.Length; j = j + 1)
            {
                Control control = tB.Dequeue();
                for (int i = 0; i <= mapArr.GetUpperBound(1); i = i + 1)
                {
                    if (mapArr[0, i] == GeneralVar[j])
                    {
                        if (control is TextBox)
                        {
                            string TextToInput = mapArr[1, i];
                            control.Text = TextToInput.Replace(" ", "");
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
                        ExistingVal.Add(j);
                        break;
                    }
                }
            }
        }

        private void LinkToOsuFileFormat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://osu.ppy.sh/wiki/fi/osu!_File_Formats/Osu_(file_format)");
        }

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
            newInput.Add("");
            newInput.Add("[General]");

            for (int i = 0; i < length; i = i + 1)
            {
                Control control = tB.Dequeue();
                if (control is TextBox)
                {
                    if (control.Text == "")
                    {
                    }
                    else
                    {
                        newInput.Add($"{GeneralVar[i]}:{control.Text}"); 
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
                                newInput.Add($"{GeneralVar[i]}:0");
                                break;
                            }
                            else if ((radio as RadioButton).Checked == true && (string)(radio as RadioButton).Tag == "1")
                            {
                                newInput.Add($"{GeneralVar[i]}:1");
                                break;
                            }
                        }
                    }
                }
            }

            newInput.Add("");

            Common.ReplaceFileWithNewData(Dir, 1, newInput);
        }
    }
}