using OsuCollabTool.CoreClasses;
using OsuCollabTool.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OsuCollabTool.Main_Classes.SongSetupFunc
{
    public partial class DifficultyIntf : Form
    {
        private UIDataExtractor ext = new UIDataExtractor();
        private string Dir = "";
        double HPDrainRate;
        double CircleSize;
        double OverallDifficulty;
        double ApproachRate;
        decimal SliderMultiplier;
        double SliderTickRate;
        string[,] diffData;

        public DifficultyIntf()
        {
            InitializeComponent();
            ext = new UIDataExtractor();
            Color[] Theme = ext.getTheme();
            Dir = $@"{ext.getSongFol()}{ext.getCurrFol()}{ext.getCurrOsu()}";

            MapDataExtractor mExt = new MapDataExtractor(Dir);
            diffData = mExt.GetDiff();
            //sets the init position for  the track bars
            for (int i = 0; i <= diffData.GetUpperBound(1); i = i + 1)
            {
                switch (i)
                {
                    case 0:
                        HPDrainRate = Convert.ToDouble(diffData[1, i]);
                        HPTrackBar.Value = (int)(HPDrainRate*10);
                        break;
                    case 1:
                        CircleSize = Convert.ToDouble(diffData[1, i]);
                        CSTrackBar.Value = (int)(CircleSize * 10);
                        break;
                    case 2:
                        OverallDifficulty = Convert.ToDouble(diffData[1, i]);
                        ODTrackBar.Value = (int)(OverallDifficulty * 10);
                        break;
                    case 3:
                        ApproachRate = Convert.ToDouble(diffData[1, i]);
                        ARTrackBar.Value = (int)(ApproachRate * 10);
                        break;
                    case 4:
                        SliderMultiplier = Convert.ToDecimal(diffData[1, i]);
                        SMTextBox.Text = SliderMultiplier.ToString();
                        SMTrackBar.Value = (int)(SliderMultiplier*10);
                        break;
                    case 5:
                        SliderTickRate = Convert.ToDouble(diffData[1, i]);
                        STRTrackBar.Value = (int)(SliderTickRate * 10);
                        break;
                } 
            }

            //Interface Theme Set
            Common.setBGCol(Theme[2], BGPanel);
            Common.setBtnCol(Theme[1], SaveBtn);
            Common.ContrastColor(Theme[1], SaveBtn);
            Common.ContrastColor(Theme[2], HPLabel, CSLabel, ODLabel, ARLabel, SMLabel, STRLabel);



            //Gives tooltip to the trackbar when dragging and when hovering
            HPTrackBar.Scroll += new EventHandler((sender, e) => TrackBar_TrackVal(sender, e, HPTrackBar)); //https://stackoverflow.com/questions/8644253/pass-parameter-to-eventhandler
            CSTrackBar.Scroll += new EventHandler((sender, e) => TrackBar_TrackVal(sender, e, CSTrackBar));
            ODTrackBar.Scroll += new EventHandler((sender, e) => TrackBar_TrackVal(sender, e, ODTrackBar));
            ARTrackBar.Scroll += new EventHandler((sender, e) => TrackBar_TrackVal(sender, e, ARTrackBar));
            SMTrackBar.Scroll += new EventHandler((sender, e) => TrackBar_TrackVal(sender, e, SMTrackBar));
            STRTrackBar.Scroll += new EventHandler((sender, e) => TrackBar_TrackVal(sender, e, STRTrackBar));

            HPTrackBar.MouseEnter += new EventHandler((sender, e) => TrackBar_TrackVal(sender, e, HPTrackBar)); //https://stackoverflow.com/questions/8644253/pass-parameter-to-eventhandler
            CSTrackBar.MouseEnter += new EventHandler((sender, e) => TrackBar_TrackVal(sender, e, CSTrackBar));
            ODTrackBar.MouseEnter += new EventHandler((sender, e) => TrackBar_TrackVal(sender, e, ODTrackBar));
            ARTrackBar.MouseEnter += new EventHandler((sender, e) => TrackBar_TrackVal(sender, e, ARTrackBar));
            //SMTrackBar.MouseEnter += new EventHandler((sender, e) => TrackBar_TrackVal(sender, e, SMTrackBar));
            STRTrackBar.MouseEnter += new EventHandler((sender, e) => TrackBar_TrackVal(sender, e, STRTrackBar));
        }

        private void TrackBar_TrackVal(object sender, EventArgs e, TrackBar track)
        {
            trackNum.SetToolTip(track, ((double)track.Value / 10).ToString());

            if(sender == SMTrackBar)
            {
                SMTextBox.Text = trackNum.GetToolTip(track);
            } 
        }

        

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(SMTextBox.Text) <= 8)
            { 
                HPDrainRate = ((double)HPTrackBar.Value / 10);
                CircleSize = ((double)CSTrackBar.Value / 10);
                OverallDifficulty = ((double)ODTrackBar.Value / 10);
                ApproachRate = ((double)ARTrackBar.Value / 10);
                SliderMultiplier = (Convert.ToDecimal(SMTextBox.Text));
                SliderTickRate = ((double)STRTrackBar.Value / 10);

                List<string> newInput = new List<string>();

                newInput.Add("[Difficulty]");

                for (int i = 0; i < diffData.GetUpperBound(1) + 1; i = i + 1)
                {
                    switch (i)
                    {
                        case 0:
                            newInput.Add($"{diffData[0, i]}:{HPDrainRate}");
                            break;
                        case 1:
                            newInput.Add($"{diffData[0, i]}:{CircleSize}");
                            break;
                        case 2:
                            newInput.Add($"{diffData[0, i]}:{OverallDifficulty}");
                            break;
                        case 3:
                            newInput.Add($"{diffData[0, i]}:{ApproachRate}");
                            break;
                        case 4:
                            newInput.Add($"{diffData[0, i]}:{SliderMultiplier}");
                            break;
                        case 5:
                            newInput.Add($"{diffData[0, i]}:{SliderTickRate}");
                            break;
                    }
                }

                newInput.Add("");

                Common.ReplaceFileWithNewData(Dir, 4, newInput);
            }
            else
            {
                MessageBox.Show("Please keep the value of slider multiplier to less than 8!");
            }
        }



    }
}