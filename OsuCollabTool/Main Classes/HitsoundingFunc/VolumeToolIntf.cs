using System;
using System.Linq;
using System.Windows.Forms;
using OsuCollabTool.UI;
using System.IO;
using System.Drawing;
using NAudio.Wave;
using OsuCollabTool.CoreClasses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OsuCollabTool.Main_Classes.HitsoundingFunc
{
    public partial class VolumeToolIntf : Form
    {
        bool set = false;
        string dir = "";
        public VolumeToolIntf()
        {
            InitializeComponent();

            UIDataExtractor ext = new UIDataExtractor();
            string[] files = Directory.GetFiles($@"{ext.getSongFol()}{ext.getCurrFol()}");

            //theme
            Color[] Theme = ext.getTheme();
            Common.setBGCol(Theme[2], BG1, BG2);
            Common.setBtnCol(Theme[1], ChangeVol);
            Common.ContrastColor(Theme[1], ChangeVol);
            Common.ContrastColor(Theme[2], Option1, Option2, Option3, SetVal, ChangeVal, ChangeValLabel, l1, Selector, ChangesBox,SelectVolBox,SelectTimestampBox,l2,l3,l4,l5,l6,l7,l8, MaxDurStart, MaxDurUntil);
            dir = $@"{ext.getSongFol()}{ext.getCurrFol()}\{ext.getCurrOsu()}";
            string audioDir = "";

            foreach (string file in files)
            {
                if (file.Contains(".mp3"))
                {
                    audioDir = $@"{ext.getSongFol()}{ext.getCurrFol()}\{Path.GetFileName(file)}";
                }
            }

            AudioFileReader duration = new AudioFileReader(audioDir);
            TimeSpan durationInt = duration.TotalTime;
            int totalTime = (int)durationInt.TotalMilliseconds;

            int minutes = totalTime / 1000 / 60;
            int minMili = minutes * 1000 * 60;
            int seconds = (totalTime - minMili) / 1000;
            int secMili = seconds * 1000;
            int miliseconds = (totalTime - minMili - secMili);

            MaxDurStart.Text = $"{minutes}:{seconds}:{miliseconds}";
            MaxDurUntil.Text = $"{minutes}:{seconds}:{miliseconds}";

            StartTrackBar.Maximum = totalTime;
            UntilTrackBar.Maximum = totalTime;

            StartTrackBar.TickFrequency = 60 * 1000;
            UntilTrackBar.TickFrequency = 60 * 1000;

            StartTrackBar.Scroll += new EventHandler((sender, e) => TrackBar_TrackVal(sender, e, StartTrackBar));
            UntilTrackBar.Scroll += new EventHandler((sender, e) => TrackBar_TrackVal(sender, e, UntilTrackBar));



            //ChangesBox.Enabled = false;
            SelectVolBox.Enabled = false;
            SelectTimestampBox.Enabled = false;

            

            TrackBarChanged(TrackBarChanges, set);

           TrackBarChanges.Scroll += new EventHandler((sender, e) => Changes_TrackVal(sender, e, TrackBarChanges));
           TrackBarChanges.MouseEnter += new EventHandler((sender, e) => Changes_TrackVal(sender, e, TrackBarChanges));


        }


        private void TrackBar_TrackVal(object sender, EventArgs e, TrackBar track)
        {
            int[] currVal = getCurrTime(track.Value);
            trackNum.SetToolTip(track, $"{currVal[0]}:{currVal[1]}:{currVal[2]}");
            if (track == StartTrackBar)
            {
                SelectFromTb.Text = (track.Value).ToString();
            }
            else if (track == UntilTrackBar)
            {
                UntilTb.Text = (track.Value).ToString();
            }

            //SMTextBox.Text = trackNum.GetToolTip(track);
        }

        private void ContentChanged(object sender, EventArgs e)
        {
            try
            {
                if ((sender as TextBox).Name == "SelectFromTb")
                {
                    SelectFromTb.Text = (convertToFormattedOffset(SelectFromTb.Text)).ToString();

                    StartTrackBar.Value = Convert.ToInt32(SelectFromTb.Text);
                }
                else if ((sender as TextBox).Name == "UntilTb")
                {
                    SelectFromTb.Text = (convertToFormattedOffset(SelectFromTb.Text)).ToString();

                    UntilTrackBar.Value = Convert.ToInt32(UntilTb.Text);
                }
            }
            catch
            {
            }
        }

        private int convertToFormattedOffset(string input)
        {
            string offsetText = input;

            int offset = 0;

            if (offsetText.Contains(":"))
            {
                string[] arrOffset = offsetText.Split(':');

                int decimalNum = Convert.ToInt32(arrOffset[2]);

                int secondsNum = Convert.ToInt32(arrOffset[1]) * 1000;

                int minutesNum = (Convert.ToInt32(arrOffset[0])) * 60 * 1000;

                offset = decimalNum + secondsNum + minutesNum;
            }
            else
            {
                offset = Convert.ToInt32(input);
            }

            return offset;
        }

        private int[] getCurrTime(int currMiliseconds)
        {
            int[] arr = new int[3];

            arr[0] = currMiliseconds / 1000 / 60;
            int minMili = arr[0] * 1000 * 60;
            arr[1] = (currMiliseconds - minMili) / 1000;
            int secMili = arr[1] * 1000;
            arr[2] = (currMiliseconds - minMili - secMili);

            return arr;
        }

        private void Changes_TrackVal(object sender, EventArgs e, TrackBar track)
        {
            if (set)
            {
                trackNum.SetToolTip(track, $"{TrackBarChanges.Value}");
            }
            else
            {
                trackNum.SetToolTip(track, $"{TrackBarChanges.Value-100}");
            }
             
        }

        private void InputChanged(object sender, System.EventArgs e)
        {
            var rBtns = Selector.Controls.OfType<RadioButton>();

            foreach (var btn in rBtns)
            {
                if (btn.Checked == true)
                {
                    switch (btn.Name)
                    {
                        case "Option1":
                            SelectVolBox.Enabled = false;
                            SelectTimestampBox.Enabled = false;
                            break;
                        case "Option2":
                            SelectVolBox.Enabled = true;
                            SelectTimestampBox.Enabled = false;
                            break;
                        case "Option3":
                            SelectVolBox.Enabled = false;
                            SelectTimestampBox.Enabled = true;
                            break;
                    }
                }
            }
        }

        private void ChangeTypeChanged(object sender, System.EventArgs e)
        {
            var rBtns = ChangesBox.Controls.OfType<RadioButton>();

            foreach (var btn in rBtns)
            {
                if (btn.Checked == true)
                {
                    switch (btn.Name)
                    {
                        case "SetVal":
                            ChangeValLabel.Visible = false;
                            set = true;
                            TrackBarChanged(TrackBarChanges, set);
                            break;
                        case "ChangeVal":
                            ChangeValLabel.Visible = true;
                            set = false;
                            TrackBarChanged(TrackBarChanges, set);
                            break;
                        
                    }
                }
            }
        }

        private void TrackBarChanged(TrackBar track, bool set)
        {
            if (set)
            {
                track.Maximum = 100;
                track.Minimum = 5;
            }
            else
            {
                track.Maximum = 200;
                track.Minimum = 5;
            } 
        }

        private async void ChangeVol_Click(object sender, EventArgs e)
        {

            if (SelectTimestampBox.Enabled && (SelectFromTb.Text == "" || UntilTb.Text == ""))
            {
                MessageBox.Show(ExceptionsHandling.invalidInput.Message);
            }
            else if (SelectTimestampBox.Enabled && (Convert.ToInt32(SelectFromTb.Text) > Convert.ToInt32(UntilTb.Text)))
            {
                MessageBox.Show(ExceptionsHandling.invalidInput.Message);
            }
            else
            {
                ChangeVol.Text = "Processing...";
                trackbarVal = TrackBarChanges.Value;
                Exception exc = await Task.Run(StartChangeVol);

                if (exc == null)
                {
                    ChangeVol.Text = "Complete!";
                    MessageBox.Show("Volume edit has been completed successfully!");

                    ChangeVol.Text = "Make Changes!";
                }
                else
                {
                    ChangeVol.Text = "Error";
                    MessageBox.Show(exc.Message);
                    ChangeVol.Text = "Make Changes!";
                }
            }

            

        }

        int trackbarVal = 0;

        private Exception StartChangeVol()
        {
            Exception exc = null;

            var rBtns = Selector.Controls.OfType<RadioButton>();
            MapDataExtractor map = new MapDataExtractor(dir);

            List<string> timingPoints = map.GetTimingPString();
            timingPoints.RemoveAt(0);
            timingPoints.RemoveAt(timingPoints.Count - 1);
            timingPoints.RemoveAt(timingPoints.Count - 1);
            List<string> newTimingPoints = new List<string>();
            newTimingPoints.Add("[TimingPoints]");

            foreach (var btn in rBtns)
            {
                if (btn.Checked == true)
                {
                    switch (btn.Name)
                    {
                        case "Option1":
                            foreach (var timingPoint in timingPoints)
                            {
                                string[] split = timingPoint.Split(',');
                                
                                if (set)
                                {
                                    newTimingPoints.Add($"{split[0]},{split[1]},{split[2]},{split[3]},{split[4]},{trackbarVal},{split[6]},{split[7]},");
                                }
                                else
                                {
                                    int changeVal = Convert.ToInt32(split[5]) + trackbarVal - 100;
                                    if(changeVal > 100)
                                    {
                                        changeVal = 100;
                                    }
                                    else if(changeVal < 5)
                                    {
                                        changeVal = 5;
                                    }
                                    newTimingPoints.Add($"{split[0]},{split[1]},{split[2]},{split[3]},{split[4]},{changeVal},{split[6]},{split[7]},");
                                }
                            }
                            
                            break;
                        case "Option2":
                            foreach (var timingPoint in timingPoints)
                            {
                                string[] split = timingPoint.Split(',');

                                if (set)
                                {
                                    if(Convert.ToInt32(split[5]) == SelectVol.Value)
                                    {

                                        newTimingPoints.Add($"{split[0]},{split[1]},{split[2]},{split[3]},{split[4]},{trackbarVal},{split[6]},{split[7]},");
                                    }
                                    else
                                    {
                                        newTimingPoints.Add($"{split[0]},{split[1]},{split[2]},{split[3]},{split[4]},{split[5]},{split[6]},{split[7]},");
                                    }

                                }
                                else
                                {
                                    if (Convert.ToInt32(split[5]) == SelectVol.Value)
                                    {
                                        int changeVal = Convert.ToInt32(split[5]) + trackbarVal - 100;
                                        if (changeVal > 100)
                                        {
                                            changeVal = 100;
                                        }
                                        else if (changeVal < 5)
                                        {
                                            changeVal = 5;
                                        }
                                        newTimingPoints.Add($"{split[0]},{split[1]},{split[2]},{split[3]},{split[4]},{changeVal},{split[6]},{split[7]},");
                                    }
                                    else
                                    {
                                        newTimingPoints.Add($"{split[0]},{split[1]},{split[2]},{split[3]},{split[4]},{split[5]},{split[6]},{split[7]},");
                                    }

                                }
                            }
                            break;
                        case "Option3":
                            foreach (var timingPoint in timingPoints)
                            {
                                string[] split = timingPoint.Split(',');

                                if (set)
                                {
                                    if (Convert.ToInt32(split[0]) >= Convert.ToInt32(SelectFromTb.Text) && Convert.ToInt32(split[0]) <= Convert.ToInt32(UntilTb.Text))
                                    {
                                        newTimingPoints.Add($"{split[0]},{split[1]},{split[2]},{split[3]},{split[4]},{trackbarVal},{split[6]},{split[7]},");
                                    }
                                    else
                                    {
                                        newTimingPoints.Add($"{split[0]},{split[1]},{split[2]},{split[3]},{split[4]},{split[5]},{split[6]},{split[7]},");
                                    }

                                }
                                else
                                {
                                    if (Convert.ToInt32(split[0]) >= Convert.ToInt32(SelectFromTb.Text) && Convert.ToInt32(split[0]) <= Convert.ToInt32(UntilTb.Text))
                                    {

                                        int changeVal = Convert.ToInt32(split[5]) + trackbarVal - 100;
                                        if (changeVal > 100)
                                        {
                                            changeVal = 100;
                                        }
                                        else if (changeVal < 5)
                                        {
                                            changeVal = 5;
                                        }
                                        newTimingPoints.Add($"{split[0]},{split[1]},{split[2]},{split[3]},{split[4]},{changeVal},{split[6]},{split[7]},");
                                    }
                                    else
                                    {
                                        newTimingPoints.Add($"{split[0]},{split[1]},{split[2]},{split[3]},{split[4]},{split[5]},{split[6]},{split[7]},");
                                    }
                                    

                                }
                            }
                            break;
                    }
                }
            }
            newTimingPoints.Add("");
            newTimingPoints.Add("");
            Common.ReplaceFileWithNewData(dir, 6, newTimingPoints);


            return exc;
        }
    }
}