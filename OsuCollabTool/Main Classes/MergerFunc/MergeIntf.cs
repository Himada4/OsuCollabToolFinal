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
    public partial class MergeIntf : Form
    {
        private string dir = string.Empty;
        private bool directlyDropped = false;

        public MergeIntf()
        {
            InitializeComponent();

            FromFolder.Items.Clear();

            UIDataExtractor ext = new UIDataExtractor();
            Color[] theme = ext.GetTheme();
            Common.SetBtnCol(theme[1], MergeButton);
            Common.SetBGCol(theme[2], t1, t2, t3, t4);
            Common.ContrastColor(theme[1], MergeButton);
            Common.ContrastColor(theme[2], l1, l2);
            string[] files = Directory.GetFiles($@"{ext.GetSongFol()}{ext.GetCurrFol()}");
            dir = $@"{ext.GetSongFol()}{ext.GetCurrFol()}";

            foreach (string file in files)
            {
                if (file.Contains(".osu"))
                {
                    FromFolder.Items.Add(Path.GetFileName(file));
                }
            }
        }

        // This region is used for selecting items via drag drop
        #region Drag Drop
        private void FromFolder_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                FromFolder.DoDragDrop(FromFolder.SelectedItem.ToString(), DragDropEffects.Copy);
            }
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
        #endregion

        // Trigger before the proccess starts, invokes a thread
        private async void MergeButton_Click(object sender, EventArgs e)
        {
            MergeButton.Text = "Processing...";
            Exception exc = await Task.Run(CheckBeforeMerge);

            if (exc == null)
            {
                MergeButton.Text = "Complete!";
                MessageBox.Show("Merging has been completed successfully!");

                MergeButton.Text = "Merge!";
            }
            else
            {
                MergeButton.Text = "Error";
                MessageBox.Show(exc.Message);
                MergeButton.Text = "Merge!";
            }
        }

        // Checks for errors before triggering the actual process
        private Exception CheckBeforeMerge()
        {
            try
            {
                Exception exc = null;
                int noFiles = 0;
                List<string> fileDirs = new List<string>();

                // Get the file Dirs
                foreach (var file in ToMerge.Items)
                {
                    fileDirs.Add($@"{dir}\{file}");
                    noFiles = noFiles + 1;
                }

                if (noFiles < 2)
                {
                    throw ExceptionsHandling.noFilesFound;
                }
                else
                {
                    List<List<string>> allTimingPoints = new List<List<string>>();
                    List<List<string>> allHitObjects = new List<List<string>>();

                    foreach (var fileDir in fileDirs)
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
                        allHitObjects.Add(tempHit);
                    }

                    List<List<string>> allUTimingPoints = GetUP(allTimingPoints);

                    using (uTimingPointsManager eBox = new uTimingPointsManager(allTimingPoints, allUTimingPoints, fileDirs))
                    {
                        Invoke((Action)(() => { eBox.ShowDialog(); }));
                        if (eBox.DialogResult == DialogResult.Ignore)
                        {
                            allTimingPoints = eBox.NewTimingPoint;

                            StartMerge(allHitObjects, allTimingPoints);
                        }
                        else if (eBox.DialogResult == DialogResult.OK)
                        {
                            allTimingPoints = eBox.NewTimingPoint;

                            StartMerge(allHitObjects, allTimingPoints);
                        }
                        else
                        {
                            exc = ExceptionsHandling.operationCancelled;
                        }
                    }

                    return exc;
                }
            }
            catch(Exception exc)
            {
                return exc;
            }
        }

        // Gets the uninherited points of timing points from multiple files
        private List<List<string>> GetUP(List<List<string>> timingPoints)
        {
            List<List<string>> uninheritedPoints = new List<List<string>>();

            for (int y = 0; y < timingPoints.Count; y = y + 1)
            {
                for (int i = 0; i < timingPoints[y].Count; i = i + 1)
                {
                    string[] split = timingPoints[y][i].Split(',');

                    List<string> temp = new List<string>();

                    if (!split[1].Contains("-"))
                    {
                        temp.Add(split[0]);
                        temp.Add(split[1]);
                        temp.Add(y.ToString());
                        uninheritedPoints.Add(temp);
                    }
                }
            }

            return uninheritedPoints;
        }

        // The actual process of the merging
        private void StartMerge(List<List<string>> hitObjects, List<List<string>> himingPoints)
        {
            List<string> finalHitObjects = MergeLists(hitObjects, false);
            List<string> finalTimingPoints = MergeLists(himingPoints, true);

            StreamReader sr = new StreamReader($@"{dir}\{ToMerge.Items[0]}");

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

            foreach (var lines in finalTimingPoints)
            {
                template.Add(lines);
            }

            while (line != string.Empty)
            {
                line = sr.ReadLine();
            }

            while (line != "[HitObjects]")
            {
                template.Add(line);
                line = sr.ReadLine();
            }

            template.Add("[HitObjects]");

            foreach (var lines in finalHitObjects)
            {
                template.Add(lines);
            }

            // close the file
            sr.Close();

            string templateOsuName = $"{ToMerge.Items[0]}";
            string[] splitTemp = templateOsuName.Split('[');

            string fileName = $"{splitTemp[0]}[Merged File]";
            string baseFileName = $"{fileName}";
            int i = 1;

            // https://stackoverflow.com/questions/5270919/always-create-new-file-if-file-already-exists-with-same-location-in-c-sharp
            while (File.Exists($"{dir}/{fileName}.osu")) 
            {
                i = i + 1;
                fileName = $"{baseFileName}({i})";
            }

            TextWriter writer = new StreamWriter($@"{dir}/{fileName}.osu", true);

            foreach (var lines in template)
            {
                writer.WriteLine(lines);
            }

            writer.Close();
        }

        // Merges two list into one
        public static List<string> MergeLists(List<List<string>> input, bool isItTimingPoint)
        {
            List<string> merged = new List<string>();

            foreach (var file in input)
            {
                merged.AddRange(file);
            }

            Sort(merged, isItTimingPoint, 0, merged.Count - 1);

            return merged;
        }

        // Uses a quick sort to sort the merged list on the offset
        #region quick sort
        private static void Sort(List<string> input, bool isItTimingPoint, int lo, int hi) // https://en.wikipedia.org/wiki/Quicksort
        {
            if (lo < hi)
            {
                int pi = Partition(input, lo, hi, isItTimingPoint);
                Sort(input, isItTimingPoint, lo, pi - 1);
                Sort(input, isItTimingPoint, pi + 1, hi);
            }
        }

        private static int Partition(List<string> input, int lo, int hi, bool isItTimingPoint)
        {
            int pivot = ConvertLineToOffset(input[hi], isItTimingPoint);
            int i = lo - 1;

            for (int j = lo; j < hi; j = j + 1)
            {
                if (ConvertLineToOffset(input[j], isItTimingPoint) < pivot)
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

        private static int ConvertLineToOffset(string input, bool isItTimingPoint)
        {
            int offset = 0;
            string[] tempArray = input.Split(',');
            if (isItTimingPoint)
            {
                offset = Convert.ToInt32(tempArray[0]);
            }
            else
            {
                offset = Convert.ToInt32(tempArray[2]);
            }

            return offset;
        }
        #endregion
    }
}