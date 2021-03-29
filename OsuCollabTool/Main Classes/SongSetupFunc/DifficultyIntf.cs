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
        private string dir = string.Empty;
        private double hpDrainRate;
        private double circleSize;
        private double overallDifficulty;
        private double approachRate;
        private decimal sliderMultiplier;
        private double sliderTickRate;
        private string[,] diffData;

        public DifficultyIntf()
        {
            InitializeComponent();
            ext = new UIDataExtractor();
            Color[] Theme = ext.GetTheme();
            dir = $@"{ext.GetSongFol()}{ext.GetCurrFol()}{ext.GetCurrOsu()}";

            MapDataExtractor mExt = new MapDataExtractor(dir);
            diffData = mExt.GetDiff();

            // Sets the init position for  the track bars
            for (int i = 0; i <= diffData.GetUpperBound(1); i = i + 1)
            {
                switch (i)
                {
                    case 0:
                        hpDrainRate = Convert.ToDouble(diffData[1, i]);
                        HPTrackBar.Value = (int)(hpDrainRate * 10);
                        break;

                    case 1:
                        circleSize = Convert.ToDouble(diffData[1, i]);
                        CSTrackBar.Value = (int)(circleSize * 10);
                        break;

                    case 2:
                        overallDifficulty = Convert.ToDouble(diffData[1, i]);
                        ODTrackBar.Value = (int)(overallDifficulty * 10);
                        break;

                    case 3:
                        approachRate = Convert.ToDouble(diffData[1, i]);
                        ARTrackBar.Value = (int)(approachRate * 10);
                        break;

                    case 4:
                        sliderMultiplier = Convert.ToDecimal(diffData[1, i]);
                        SMTextBox.Text = sliderMultiplier.ToString();
                        SMTrackBar.Value = (int)(sliderMultiplier * 10);
                        break;

                    case 5:
                        sliderTickRate = Convert.ToDouble(diffData[1, i]);
                        STRTrackBar.Value = (int)(sliderTickRate * 10);
                        break;
                }
            }

            //Interface Theme Set
            Common.SetBGCol(Theme[2], BGPanel);
            Common.SetBtnCol(Theme[1], SaveBtn);
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
            STRTrackBar.MouseEnter += new EventHandler((sender, e) => TrackBar_TrackVal(sender, e, STRTrackBar));
        }

        // Tracks the track bar
        private void TrackBar_TrackVal(object sender, EventArgs e, TrackBar track)
        {
            trackNum.SetToolTip(track, ((double)track.Value / 10).ToString());

            if (sender == SMTrackBar)
            {
                SMTextBox.Text = trackNum.GetToolTip(track);
            }
        }

        // Saves the new difficulty settings, overwrites it to the .osu file
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(SMTextBox.Text) <= 8)
            {
                hpDrainRate = ((double)HPTrackBar.Value / 10);
                circleSize = ((double)CSTrackBar.Value / 10);
                overallDifficulty = ((double)ODTrackBar.Value / 10);
                approachRate = ((double)ARTrackBar.Value / 10);
                sliderMultiplier = (Convert.ToDecimal(SMTextBox.Text));
                sliderTickRate = ((double)STRTrackBar.Value / 10);

                List<string> newInput = new List<string>();

                newInput.Add("[Difficulty]");

                for (int i = 0; i < diffData.GetUpperBound(1) + 1; i = i + 1)
                {
                    switch (i)
                    {
                        case 0:
                            newInput.Add($"{diffData[0, i]}:{hpDrainRate}");
                            break;

                        case 1:
                            newInput.Add($"{diffData[0, i]}:{circleSize}");
                            break;

                        case 2:
                            newInput.Add($"{diffData[0, i]}:{overallDifficulty}");
                            break;

                        case 3:
                            newInput.Add($"{diffData[0, i]}:{approachRate}");
                            break;

                        case 4:
                            newInput.Add($"{diffData[0, i]}:{sliderMultiplier}");
                            break;

                        case 5:
                            newInput.Add($"{diffData[0, i]}:{sliderTickRate}");
                            break;
                    }
                }

                newInput.Add(string.Empty);

                Common.ReplaceFileWithNewData(dir, 4, newInput);
            }
            else
            {
                MessageBox.Show("Please keep the value of slider multiplier to less than 8!");
            }
        }
    }
}