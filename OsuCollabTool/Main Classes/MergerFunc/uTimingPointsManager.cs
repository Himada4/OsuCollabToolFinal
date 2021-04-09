using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using OsuCollabTool.Main_Classes;

namespace OsuCollabTool.Main_Classes.MergerFunc
{
    public partial class uTimingPointsManager : Form
    {
        public List<List<string>> NewTimingPoint { get; set; }

        private List<string> fileDirs = new List<string>();
        private List<List<string>> allTimingPoints;
        private List<List<string>> allUTimingPoints;
        private List<string> refrenceFiles = new List<string>();

        public uTimingPointsManager(List<List<string>> points, List<List<string>> uPoints, List<string> dirs)
        {
            InitializeComponent();

            fileDirs = dirs;

            allTimingPoints = points;

            allUTimingPoints = uPoints;

            foreach (var UP in allUTimingPoints)
            {
                uTimingPointsListBox.Items.Add($"Offset at:({UP[0]}) at {1 / Convert.ToDouble(UP[1]) * 1000 * 60} bpm from {Path.GetFileName(fileDirs[Convert.ToInt32(UP[2])])}", false);
                refrenceFiles.Add(Path.GetFileName(fileDirs[Convert.ToInt32(UP[2])]));
            }
        }

        // Allows user to copy the offset to refer it to the editor
        private void UTimingPointsListBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Control && e.KeyCode == Keys.C)
                {
                    string s = uTimingPointsListBox.SelectedItem.ToString();
                    string[] temp = s.Split('(');
                    string[] temp2 = temp[1].Split(')');
                    string copyText = temp2[0];

                    Clipboard.SetText(copyText);
                }
            }
            catch
            {
                MessageBox.Show("Please select an Item first.");
            }
        }

        // Continues the main operation without any edits to the timing points
        private void ContinueWithoutDelete_Click(object sender, EventArgs e)
        {
            NewTimingPoint = allTimingPoints;
        }

        // Continutes the main operation after adding edits to the timing points
        private void DeleteSelected_Click(object sender, EventArgs e)
        {
            int noneSelected = 0;
            List<List<string>> selectToDelete = new List<List<string>>();
            for (int i = 0; i < uTimingPointsListBox.Items.Count; i = i + 1)
            {
                List<string> temp = new List<string>();
                if (uTimingPointsListBox.GetItemCheckState(i) == CheckState.Checked)
                {
                    temp.Add(allUTimingPoints[i][0]);
                    temp.Add(allUTimingPoints[i][1]);
                    temp.Add(refrenceFiles[i]);

                    selectToDelete.Add(temp);
                    noneSelected = noneSelected + 1;
                }
            }
            if (noneSelected == 0)
            {
                throw ExceptionsHandling.selectedNone;
            } else if (noneSelected == uTimingPointsListBox.Items.Count)
            {
                throw ExceptionsHandling.deleteAll;
            }
            else
            {
                List<int> fileNum = new List<int>();

                string PreviousFile = selectToDelete[0][0];
                int count = 0;

                for (int i = 0; i < selectToDelete.Count; i = i + 1)
                {
                    if (PreviousFile == selectToDelete[i][2])
                    {
                        fileNum.Add(count);
                        PreviousFile = selectToDelete[i][2];
                    }
                    else
                    {
                        count = count + 1;
                        fileNum.Add(count);
                        PreviousFile = selectToDelete[i][2];
                    }
                }

                List<List<string>> newTimingPointsLists = allTimingPoints;

                foreach (int num in fileNum)
                {
                    for (int i = 0; i < newTimingPointsLists[num].Count; i = i + 1)
                    {
                        string[] split = newTimingPointsLists[num][i].Split(',');

                        string[] ValueToSearch = new string[2] { split[0], split[1] };

                        for (int y = 0; y < selectToDelete.Count; y = y + 1)
                        {
                            if (ValueToSearch[0] == selectToDelete[y][0] && ValueToSearch[1] == selectToDelete[y][1])
                            {
                                newTimingPointsLists[num].RemoveAt(i);
                                break;
                            }
                        }
                    }
                }

                NewTimingPoint = newTimingPointsLists;
            }
        }
    }
}