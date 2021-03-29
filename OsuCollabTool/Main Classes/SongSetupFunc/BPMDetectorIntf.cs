using NAudio.Wave;
using OsuCollabTool.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsuCollabTool.Main_Classes.SongSetupFunc
{
    public partial class BPMDetectorIntf : Form
    {
        private string audioDir = string.Empty;
        private int totalTime = 0;

        public BPMDetectorIntf()
        {
            InitializeComponent();

            UIDataExtractor ext = new UIDataExtractor();
            string[] files = Directory.GetFiles($@"{ext.GetSongFol()}{ext.GetCurrFol()}");

            // Theme
            Color[] theme = ext.GetTheme();
            Common.SetBGCol(theme[2], BtmBG, MainBG);
            Common.SetBtnCol(theme[1], DetectBPM, QuickScan);
            Common.ContrastColor(theme[1], DetectBPM, QuickScan);
            Common.ContrastColor(theme[2], l1, l2, l3, l4, l5, l6, l7, l8, MaxDurStart, MaxDurUntil, ResultBPMPanel, ResultBPM);

            foreach (string file in files)
            {
                if (file.Contains(".mp3"))
                {
                    audioDir = $@"{ext.GetSongFol()}{ext.GetCurrFol()}\{Path.GetFileName(file)}";
                }
            }

            AudioFileReader duration = new AudioFileReader(audioDir);
            TimeSpan durationInt = duration.TotalTime;
            totalTime = (int)durationInt.TotalSeconds;

            MaxDurStart.Text = $"{totalTime / 60}:{totalTime - (totalTime / 60) * 60}";
            MaxDurUntil.Text = $"{totalTime / 60}:{totalTime - (totalTime / 60) * 60}";

            StartTrackBar.Maximum = totalTime;
            UntilTrackBar.Maximum = totalTime;

            StartTrackBar.Scroll += new EventHandler((sender, e) => TrackBar_TrackVal(sender, e, StartTrackBar));
            UntilTrackBar.Scroll += new EventHandler((sender, e) => TrackBar_TrackVal(sender, e, UntilTrackBar));

            StartTrackBar.MouseEnter += new EventHandler((sender, e) => TrackBar_TrackVal(sender, e, StartTrackBar));
            UntilTrackBar.MouseEnter += new EventHandler((sender, e) => TrackBar_TrackVal(sender, e, UntilTrackBar));
        }

        // Tracks the trackbar
        private void TrackBar_TrackVal(object sender, EventArgs e, TrackBar track)
        {
            trackNum.SetToolTip(track, $"{track.Value / 60}:{track.Value - (track.Value / 60) * 60}");
        }

        private int defaultStart = 0;
        private int defaultUntil = 0;

        // Triggers the thread to the main process
        private async void DetectBPM_Click(object sender, EventArgs e)
        {
            if (StartTrackBar.Value < UntilTrackBar.Value)
            {
                defaultStart = StartTrackBar.Value;
                defaultUntil = UntilTrackBar.Value;
                ResultBPM.Text = "Loading...";
                ResultBPM.Text = $"{await Task.Run(BPMDetection)}";
            }
            else
            {
                MessageBox.Show("Please make sure to set the trackbars in viable positions!");
            }
        }

        // Triggers the BPM detection using FFT
        private int BPMDetection()
        {
            int bpm = FourierTest(audioDir, defaultStart, defaultUntil);

            return bpm;
        }

        // Triggers the thread to the main process, with the difference that it is scanning a preset proportion of the audio
        private async void QuickScan_Click(object sender, EventArgs e)
        {
            ResultBPM.Text = "Loading...";
            ResultBPM.Text = $"{await Task.Run(QuickDetection)}";
        }


        // The preset val if the user chooses to quick scan
        private int QuickDetection()
        {
            int start = (int)(totalTime * 0.27);
            int end = (int)(totalTime * 0.38);
            int bpm = FourierTest(audioDir, start, end);

            return bpm;
        }

        // The FFT
        public int FourierTest(string audioDir, int skipTo, int playUntil)
        {
            var reader = new MediaFoundationReader(audioDir);
            var sampleProvider = reader.ToSampleProvider().ToMono();
            var sampleRate = sampleProvider.WaveFormat.SampleRate;

            // Select time to scan
            var allSamples = new float[sampleRate * (playUntil - skipTo)];
            sampleProvider.Skip(TimeSpan.FromSeconds(skipTo));
            int samplesRead = sampleProvider.Read(allSamples, 0, allSamples.Length);

            // Now the entire audio stored in the list
            var tasks = new List<Task<Tuple<int, double>>>();
            for (int bpm = 60; bpm < 300; bpm++)
            {
                int bpm2 = bpm;
                tasks.Add(Task.Run(() =>
                {
                    double hz = bpm2 / 60d;
                    double x = 0;
                    double y = 0;
                    int i = 0;
                    foreach (var sample in allSamples)
                    {
                        var rot = 2 * Math.PI * hz / sampleRate * i++;
                        var amp = Math.Abs(sample);
                        x += amp * Math.Cos(rot);
                        y += amp * Math.Sin(rot);
                    }
                    Console.WriteLine($"{bpm2};{Math.Sqrt(x * x + y * y)}");
                    return new Tuple<int, double>(bpm2, Math.Sqrt(x * x + y * y));
                }));
            }

            Task t = Task.WhenAll(tasks);
            t.Wait();

            int bestBPM = 0;
            double bestResonance = 0;
            foreach (var task in tasks)
            {
                if (task.Result.Item2 > bestResonance)
                {
                    bestResonance = task.Result.Item2;
                    bestBPM = task.Result.Item1;
                }
            }

            return bestBPM;
        }
    }
}