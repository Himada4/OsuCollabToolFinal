using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using OsuCollabTool.CoreClasses;
using OsuCollabTool.UI;

namespace OsuCollabTool.Main_Classes.MergerFunc
{
    public partial class CompareIntf : Form
    {
        private string dir = string.Empty;
        private bool directlyDropped = false;

        public CompareIntf()
        {
            InitializeComponent();
            try
            {
                FromFolder.Items.Clear();

                UIDataExtractor ext = new UIDataExtractor();
                Color[] theme = ext.GetTheme();
                Common.SetBtnCol(theme[1], CompareButton);
                Common.SetBGCol(theme[2], t1, t2, t3, t4);
                Common.ContrastColor(theme[1], CompareButton);
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
            catch
            {
                this.Close();
            }
        }

        // This region is for the drag drop of the items
        #region drag drop
        private void FromFolder_MouseDown(object sender, MouseEventArgs e)
        {
            try
            { 
                FromFolder.DoDragDrop(FromFolder.SelectedItem.ToString(), DragDropEffects.Copy); 
            }
            catch 
            { }
        }

        private void ToCompare_DragEnter(object sender, DragEventArgs e)
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

        private void ToCompare_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                ToCompare.Items.Add(e.Data.GetData(DataFormats.Text));
                FromFolder.Items.Remove(e.Data.GetData(DataFormats.Text));
            }
            else
            {
                string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in droppedFiles)
                {
                    string filename = Path.GetFileName(file);
                    if (filename.Contains(".osu"))
                    {
                        ToCompare.Items.Add(filename);
                    }
                }

                if (!directlyDropped)
                {
                    MessageBox.Show("Please be aware that the directory of the directly dropped files requires to have the same directory as the one set in preferences. If not, please set it via preferences.");
                    directlyDropped = true;
                }
            }
        }
        #endregion

        // Triggers the proccess for the comparison, but first only checks for errors
        private async void CompareButton_Click(object sender, EventArgs e)
        {
            try
            {
                CompareButton.Text = "Processing...";
                Exception exc = await Task.Run(StartCompare);

                if (exc != null)
                {
                    CompareButton.Text = "Error";
                    MessageBox.Show(exc.Message);
                    CompareButton.Text = "Compare!";
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        // Actual Process for the comparison
        private Exception StartCompare()
        {
            Exception exc = null;

            try
            {
                if (ToCompare.Items.Count == 2)
                {
                    List<string> fileDirs = new List<string>();
                    List<string> fileNames = new List<string>();

                    // Get the file Dirs
                    foreach (var file in ToCompare.Items)
                    {
                        fileNames.Add($"{file}");
                        fileDirs.Add($@"{dir}\{file}");
                    }

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

                    List<string> file1Timing = CompareTimingPoints(allTimingPoints[0], allTimingPoints[1]);
                    List<string> file1HitObject = CompareHitObjects(allHitObjects[0], allHitObjects[1]);

                    List<string> file2Timing = CompareTimingPoints(allTimingPoints[1], allTimingPoints[0]);
                    List<string> file2HitObject = CompareHitObjects(allHitObjects[1], allHitObjects[0]);

                    string error1 = string.Empty;
                    string error2 = string.Empty;
                    bool empty1 = false;
                    bool empty2 = false;

                    if (file1Timing.Count == 0 && file2Timing.Count == 0)
                    {
                        error1 = "The Timing Points for both files are identical!";
                        empty1 = true;
                    }

                    if (file1HitObject.Count == 0 && file2HitObject.Count == 0)
                    {
                        error2 = "The Hit Objects for both files are identical!";
                        empty2 = true;
                    }

                    if (empty1 && empty2)
                    {
                        throw ExceptionsHandling.identicalFiles;
                    }

                    using (CompareLog eBox = new CompareLog(file1Timing, file2Timing, file1HitObject, file2HitObject, fileNames))
                    {
                        if (empty1)
                        {
                            MessageBox.Show(error1);
                        }
                        else if (empty2)
                        {
                            MessageBox.Show(error2);
                        }

                        Invoke((Action)(() => { eBox.ShowDialog(); }));
                    }
                }
                else
                {
                    exc = ExceptionsHandling.moreThan2Objects;
                }

                return exc;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

        // Compares only the timing points, returns a list with only unique objects
        private List<string> CompareTimingPoints(List<string> input1, List<string> input2)
        {
            List<string> results = new List<string>();

            foreach (var line in input1)
            {
                int found = 0;
                foreach (var toCompare in input2)
                {
                    if (line == toCompare)
                    {
                        found = found + 1;
                    }
                }

                if (found == 0)
                {
                    results.Add(line);
                }
            }

            return results;
        }

        // Compares only the hit objects, returns a list with only unique objects
        private List<string> CompareHitObjects(List<string> input1, List<string> input2)
        {
            List<string> results = new List<string>();

            foreach (var line in input1)
            {
                int found = 0;
                foreach (var toCompare in input2)
                {
                    if (line == toCompare)
                    {
                        found = found + 1;
                    }
                }

                if (found == 0)
                {
                    results.Add(line);
                }
            }

            return results;
        }
    }
}