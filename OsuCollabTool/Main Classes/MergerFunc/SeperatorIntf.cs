using NAudio.Wave;
using OsuCollabTool.CoreClasses;
using OsuCollabTool.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsuCollabTool.Main_Classes.MergerFunc
{
    public partial class SeperatorIntf : Form
    {
        private string audioDir = "";
        private int totalTime = 0;
        private string dir = "";

        public SeperatorIntf()
        {
            InitializeComponent();

            UIDataExtractor ext = new UIDataExtractor();
            string[] files = Directory.GetFiles($@"{ext.getSongFol()}{ext.getCurrFol()}");

            //theme
            Color[] Theme = ext.getTheme();
            Common.setBGCol(Theme[2], BtmBG, MainBG);
            Common.setBtnCol(Theme[1], SeperateBtn);
            Common.ContrastColor(Theme[1], SeperateBtn);
            Common.ContrastColor(Theme[2], l1, l2, l3, l4, l5, l6, l7, MaxDurStart, MaxDurUntil);
            dir = $@"{ext.getSongFol()}{ext.getCurrFol()}\{ext.getCurrOsu()}";

            foreach (string file in files)
            {
                if (file.Contains(".mp3"))
                {
                    audioDir = $@"{ext.getSongFol()}{ext.getCurrFol()}\{Path.GetFileName(file)}";
                }
            }

            AudioFileReader duration = new AudioFileReader(audioDir);
            TimeSpan durationInt = duration.TotalTime;
            totalTime = (int)durationInt.TotalMilliseconds;

            int minutes = totalTime / 1000 / 60;
            int minMili = minutes * 1000 * 60;
            int seconds = (totalTime - minMili) / 1000;
            int secMili = seconds * 1000;
            int miliseconds = (totalTime - minMili - secMili);

            MaxDurStart.Text = $"{minutes}:{seconds}:{miliseconds}";
            MaxDurUntil.Text = $"{minutes}:{seconds}:{miliseconds}";

            StartTrackBar.Maximum = totalTime;
            UntilTrackBar.Maximum = totalTime;

            StartTrackBar.Scroll += new EventHandler((sender, e) => TrackBar_TrackVal(sender, e, StartTrackBar));
            UntilTrackBar.Scroll += new EventHandler((sender, e) => TrackBar_TrackVal(sender, e, UntilTrackBar));

            //StartTrackBar.MouseEnter += new EventHandler((sender, e) => TrackBar_TrackVal(sender, e, StartTrackBar));
            //UntilTrackBar.MouseEnter += new EventHandler((sender, e) => TrackBar_TrackVal(sender, e, UntilTrackBar));
        }

        private void TrackBar_TrackVal(object sender, EventArgs e, TrackBar track)
        {
            int[] currVal = getCurrTime(track.Value);
            trackNum.SetToolTip(track, $"{currVal[0]}:{currVal[1]}:{currVal[2]}");
            if (track == StartTrackBar)
            {
                SeperateFromTb.Text = (track.Value).ToString();
            }
            else if (track == UntilTrackBar)
            {
                UntilTb.Text = (track.Value).ToString();
            }

            //SMTextBox.Text = trackNum.GetToolTip(track);
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

        private async void SeperateBtn_Click(object sender, EventArgs e)
        {
            if (SeperateFromTb.Text == "" || UntilTb.Text == "")
            {
                MessageBox.Show(ExceptionsHandling.invalidInput.Message);
            }
            else if (Convert.ToInt32(SeperateFromTb.Text) > Convert.ToInt32(UntilTb.Text))
            {
                MessageBox.Show(ExceptionsHandling.invalidInput.Message);
            }
            else
            {
                SeperateBtn.Text = "Processing...";
                Exception exc = await Task.Run(StartSeperation);

                if (exc == null)
                {
                    SeperateBtn.Text = "Complete!";
                    MessageBox.Show("Seperation has been completed successfully, a new file has been created!");

                    SeperateBtn.Text = "Seperate Part";
                }
                else
                {
                    SeperateBtn.Text = "Error";
                    MessageBox.Show(exc.Message);
                    SeperateBtn.Text = "Seperate Part";
                }
            }
        }

        private Exception StartSeperation()
        {
            Exception exc = null;

            int start = Convert.ToInt32(SeperateFromTb.Text);
            int end = Convert.ToInt32(UntilTb.Text);

            MapDataExtractor map = new MapDataExtractor(dir);

            List<string> timingPoints = map.GetTimingPString();
            List<string> hitObjects = map.GetHitObjString();
            timingPoints.RemoveAt(0);
            timingPoints.RemoveAt(timingPoints.Count - 1);
            timingPoints.RemoveAt(timingPoints.Count - 1);

            hitObjects.RemoveAt(0);
            hitObjects.RemoveAt(hitObjects.Count - 1);
            Queue<string> uninheritedPoints = GetUP(timingPoints);

            List<string> seperatedTimingPoints = new List<string>();
            List<string> seperatedHitObjects = new List<string>();

            foreach (var timingPoint in timingPoints)
            {
                string[] split = timingPoint.Split(',');
                string uPLine = uninheritedPoints.Peek();
                if ((Convert.ToInt32(split[0]) >= start && Convert.ToInt32(split[0]) <= end && Convert.ToDecimal(split[1]) < 0) || timingPoint == uPLine)
                {
                    seperatedTimingPoints.Add(timingPoint);
                    if (timingPoint == uPLine)
                    {
                        uninheritedPoints.Dequeue();
                    }
                }
            }

            foreach (var hitObject in hitObjects)
            {
                string[] split = hitObject.Split(',');
                if (Convert.ToInt32(split[2]) >= start && Convert.ToInt32(split[2]) <= end)
                {
                    seperatedHitObjects.Add(hitObject);
                }
            }

            StreamReader sr = new StreamReader(dir);

            var line = sr.ReadLine();

            List<string> template = new List<string>();

            while (line.Contains("Version:") == false)
            {
                template.Add(line);
                line = sr.ReadLine();
            }

            line = "Version: Seperated File";

            while (line != "[TimingPoints]")
            {
                template.Add(line);
                line = sr.ReadLine();
            }

            template.Add("[TimingPoints]");

            foreach (var lines in seperatedTimingPoints)
            {
                template.Add(lines);
            }

            while (line != "")
            {
                line = sr.ReadLine();
            }

            while (line != "[HitObjects]")
            {
                template.Add(line);
                line = sr.ReadLine();
            }

            template.Add("[HitObjects]");

            foreach (var lines in seperatedHitObjects)
            {
                template.Add(lines);
            }

            //close the file
            sr.Close();


            string templateOsuName = $"{Path.GetFileName(dir)}";
            string[] splitTemp = templateOsuName.Split('[');

            string FileName = $"{splitTemp[0]}[Seperated File]";
            string BaseFileName = $"{FileName}";
            int i = 1;

            while (File.Exists($"{Path.GetDirectoryName(dir)}/{FileName}.osu")) // https://stackoverflow.com/questions/5270919/always-create-new-file-if-file-already-exists-with-same-location-in-c-sharp
            {
                i = i + 1;
                FileName = $"{BaseFileName}({i})";
            }

            TextWriter writer = new StreamWriter($@"{Path.GetDirectoryName(dir)}/{FileName}.osu", true);

            foreach (var lines in template)
            {
                writer.WriteLine(lines);
            }
            writer.Close();

            return exc;
        }

        private Queue<string> GetUP(List<string> TimingPoints)
        {
            Queue<string> UninheritedPoints = new Queue<string>();

            for (int i = 0; i < TimingPoints.Count; i = i + 1)
            {
                string[] split = TimingPoints[i].Split(',');

                if (!split[1].Contains("-"))
                {
                    UninheritedPoints.Enqueue(TimingPoints[i]);
                }
            }

            return UninheritedPoints;
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

        private void ContentChanged(object sender, EventArgs e)
        {
            try
            {
                if ((sender as TextBox).Name == "SeperateFromTb")
                {
                    SeperateFromTb.Text = (convertToFormattedOffset(SeperateFromTb.Text)).ToString();

                    StartTrackBar.Value = Convert.ToInt32(SeperateFromTb.Text);
                }
                else if ((sender as TextBox).Name == "UntilTb")
                {
                    SeperateFromTb.Text = (convertToFormattedOffset(SeperateFromTb.Text)).ToString();

                    UntilTrackBar.Value = Convert.ToInt32(UntilTb.Text);
                }
            }
            catch
            {
            }
        }
    }
}