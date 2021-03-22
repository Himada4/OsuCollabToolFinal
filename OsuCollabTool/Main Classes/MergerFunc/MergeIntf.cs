using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OsuCollabTool.UI;
using OsuCollabTool.CoreClasses;
using Editor_Reader;

namespace OsuCollabTool.Main_Classes.MergerFunc
{
    public partial class MergeIntf : Form
    {
        string Dir = "";
        bool directlyDropped = false;
        public MergeIntf()
        {
            InitializeComponent();

            FromFolder.Items.Clear();

            UIDataExtractor ext = new UIDataExtractor();
            Color[] theme = ext.getTheme();
            Common.setBtnCol(theme[1], MergeButton);
            Common.setBGCol(theme[2], t1, t2, t3, t4);
            Common.ContrastColor(theme[1], MergeButton);
            Common.ContrastColor(theme[2], l1, l2);
            string[] files = Directory.GetFiles($@"{ext.getSongFol()}{ext.getCurrFol()}");
            Dir = $@"{ext.getSongFol()}{ext.getCurrFol()}";

            foreach (string file in files)
            {
                if (file.Contains(".osu"))
                {
                    FromFolder.Items.Add(Path.GetFileName(file));
                }
            }

            
        }

        private void FromFolder_MouseDown(object sender, MouseEventArgs e)
        {
            try
            { FromFolder.DoDragDrop(FromFolder.SelectedItem.ToString(), DragDropEffects.Copy); }
            catch { }
        }

        private void ToMerge_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void ToMerge_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                ToMerge.Items.Add(e.Data.GetData(DataFormats.Text));
                FromFolder.Items.Remove(e.Data.GetData(DataFormats.Text));
            }
            else
            {
                string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in droppedFiles)
                {
                    string filename = Path.GetFileName(file);
                    if (filename.Contains(".osu"))
                    { ToMerge.Items.Add(filename); }
                }

                if (!directlyDropped)
                {
                    MessageBox.Show("Please be aware that the directory of the directly dropped files requires to have the same directory as the one set in preferences. If not, please set it via preferences.");
                    directlyDropped = true;
                }
            }
        }

        private async void MergeButton_Click(object sender, EventArgs e)
        {
            MergeButton.Text = "Processing..."; 
            Exception exc = await Task.Run(CheckBeforeMerge);

            if(exc == null)
            {
                MergeButton.Text = "Complete!";
                MessageBox.Show("Merging has been completed successfully!");

                MergeButton.Text = "Merge!";
            }

        }

        private Exception CheckBeforeMerge()
        {
            Exception exc = null;

            List<string> fileDirs = new List<string>();

            // Get the file Dirs
            foreach (var file in ToMerge.Items)
            {
                fileDirs.Add($@"{Dir}\{file}");
            }

            

            List<List<string>> allTimingPoints = new List<List<string>>();
            List<List<string>> HitObjects = new List<List<string>>();
            Exception operationCancelled = new Exception();

            foreach(var fileDir in fileDirs)
            {
                MapDataExtractor map = new MapDataExtractor(fileDir);

                List<string> tempTiming = map.GetTimingPString();
                tempTiming.RemoveAt(0);
                tempTiming.RemoveAt(tempTiming.Count - 1);
                tempTiming.RemoveAt(tempTiming.Count - 1);
                allTimingPoints.Add(tempTiming);

                List<string> tempHit = map.GetHitObjString();
                tempHit.RemoveAt(0);
                tempHit.RemoveAt(tempHit.Count - 1);
                HitObjects.Add(tempHit);
            }

            List<List<string>> allUTimingPoints = GetUP(allTimingPoints);

            using (uTimingPointsManager EBox = new uTimingPointsManager(allTimingPoints, allUTimingPoints, fileDirs))
            {
                Invoke((Action)(() => { EBox.ShowDialog(); }));
                if (EBox.DialogResult == DialogResult.Ignore)
                {
                    allTimingPoints = EBox.newTimingPoint;
                    
                    StartMerge(HitObjects, allTimingPoints);
                }
                else if (EBox.DialogResult == DialogResult.OK)
                {
                    allTimingPoints = EBox.newTimingPoint;
                    
                    StartMerge(HitObjects, allTimingPoints);
                }
                else
                {
                    operationCancelled = ExceptionsHandling.operationCancelled;
                }
            }



            return exc;
        }

        private List<List<string>> GetUP(List<List<string>> TimingPoints)
        {
            List<List<string>> UninheritedPoints = new List<List<string>>();

            for (int y = 0; y < TimingPoints.Count; y = y + 1)
            {
                for (int i = 0; i < TimingPoints[y].Count; i = i + 1)
                {
                    string[] split = TimingPoints[y][i].Split(',');

                    List<string> Temp = new List<string>();

                    if (!split[1].Contains("-"))
                    {
                        Temp.Add(split[0]);
                        Temp.Add(split[1]);
                        Temp.Add(y.ToString());
                        UninheritedPoints.Add(Temp);

                    }
                }
            }

            return UninheritedPoints;
        }


        private void StartMerge(List<List<string>> HitObjects, List<List<string>> TimingPoints)
        {
            List<string> FinalHitObjects = mergeLists(HitObjects, false);
            List<string> FinalTimingPoints = mergeLists(TimingPoints, true);

            StreamReader sr = new StreamReader($@"{Dir}\{ToMerge.Items[0]}");

            var line = sr.ReadLine();

            List<string> template = new List<string>();

            while (line.Contains("Version:") == false)
            {
                template.Add(line);
                line = sr.ReadLine();
            }

            line = "Version: Merged File";

            while (line != "[TimingPoints]")
            {
                template.Add(line);
                line = sr.ReadLine();
            }

            template.Add("[TimingPoints]");

            foreach (var lines in FinalTimingPoints)
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

            foreach (var lines in FinalHitObjects)
            {
                template.Add(lines);
            }

            //close the file
            sr.Close();

            
            string templateOsuName = $"{ToMerge.Items[0]}";
            string[] splitTemp = templateOsuName.Split('[');

            string FileName = $"{splitTemp[0]}[Merged File]";
            string BaseFileName = $"{FileName}";
            int i = 1;

            while (File.Exists($"{Dir}/{FileName}.osu")) // https://stackoverflow.com/questions/5270919/always-create-new-file-if-file-already-exists-with-same-location-in-c-sharp
            {
                i = i + 1;
                FileName = $"{BaseFileName}({i})";
            }

            TextWriter writer = new StreamWriter($@"{Dir}/{FileName}.osu", true);

            foreach (var lines in template)
            {
                writer.WriteLine(lines);
            }
            writer.Close();

            
        }

        public static List<string> mergeLists(List<List<string>> input, bool IsItTimingPoint)
        {
            List<string> Merged = new List<string>();

            foreach (var file in input)
            {
                Merged.AddRange(file);
            }

            sort(Merged, IsItTimingPoint, 0, Merged.Count - 1);

            return Merged;
        }

        private static void sort(List<string> input, bool IsItTimingPoint, int lo, int hi) // https://en.wikipedia.org/wiki/Quicksort
        {
            if (lo < hi)
            {
                int pi = Partition(input, lo, hi, IsItTimingPoint);
                sort(input, IsItTimingPoint, lo, pi - 1);
                sort(input, IsItTimingPoint, pi + 1, hi);
            }
        }

        private static int Partition(List<string> input, int lo, int hi, bool IsItTimingPoint)
        {
            int pivot = ConvertLineToOffset(input[hi], IsItTimingPoint);
            int i = lo - 1;

            for (int j = lo; j < hi; j = j + 1)
            {
                if (ConvertLineToOffset(input[j], IsItTimingPoint) < pivot)
                {
                    i = i + 1;

                    string temp = input[i];
                    input[i] = input[j];
                    input[j] = temp;
                }
            }

            string temp2 = input[i + 1];
            input[i + 1] = input[hi];
            input[hi] = temp2;

            return i + 1;
        }

        private static int ConvertLineToOffset(string input, bool IsItTimingPoint)
        {
            int offset = 0;
            string[] tempArray = input.Split(',');
            if (IsItTimingPoint)
            {
                offset = Convert.ToInt32(tempArray[0]);
            }
            else
            {
                offset = Convert.ToInt32(tempArray[2]);
            }
            return offset;
        }


    }
}
