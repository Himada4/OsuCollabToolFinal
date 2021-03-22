using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OsuCollabTool.Main_Classes.MergerFunc
{
    public partial class uTimingPointsManager : Form
    {
        public List<List<string>> newTimingPoint { get; set; }
        private List<string> FileDirs = new List<string>();
        private List<List<string>> allTimingPoints;
        private List<List<string>> allUTimingPoints;
        private List<string> RefrenceFiles = new List<string>();
        public uTimingPointsManager(List<List<string>> Points, List<List<string>> uPoints, List<string> Dirs)
        {
            InitializeComponent();

            FileDirs = Dirs;

            allTimingPoints = Points; 

            allUTimingPoints = uPoints;

            
            foreach (var UP in allUTimingPoints)
            {
                uTimingPointsListBox.Items.Add($"Offset at:({UP[0]}) at {1 / Convert.ToDouble(UP[1]) * 1000 * 60} bpm from {Path.GetFileName(FileDirs[Convert.ToInt32(UP[2])])}", false);
                RefrenceFiles.Add(Path.GetFileName(FileDirs[Convert.ToInt32(UP[2])]));
            }
        }

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

        private void ContinueWithoutDelete_Click(object sender, EventArgs e)
        {
            newTimingPoint = allTimingPoints;
        }

        private void DeleteSelected_Click(object sender, EventArgs e)
        {
            List<List<string>> SelectToDelete = new List<List<string>>();
            for (int i = 0; i < uTimingPointsListBox.Items.Count; i = i + 1)
            {
                List<string> temp = new List<string>();
                if (uTimingPointsListBox.GetItemCheckState(i) == CheckState.Checked)
                {
                    temp.Add(allUTimingPoints[i][0]);
                    temp.Add(allUTimingPoints[i][1]);
                    temp.Add(RefrenceFiles[i]);

                    SelectToDelete.Add(temp);
                }
            }
            List<int> FileNum = new List<int>();

            string PreviousFile = SelectToDelete[0][0];
            int count = 0;

            for (int i = 0; i < SelectToDelete.Count; i = i + 1)
            {
                if (PreviousFile == SelectToDelete[i][2])
                {
                    FileNum.Add(count);
                    PreviousFile = SelectToDelete[i][2];
                }
                else
                {
                    count = count + 1;
                    FileNum.Add(count);
                    PreviousFile = SelectToDelete[i][2];
                }
            }

            List<List<string>> newTimingPointsLists = allTimingPoints;

            foreach (int Num in FileNum)
            {
                for (int i = 0; i < newTimingPointsLists[Num].Count; i = i + 1)
                {
                    string[] split = newTimingPointsLists[Num][i].Split(',');

                    string[] ValueToSearch = new string[2] { split[0], split[1] };

                    for (int y = 0; y < SelectToDelete.Count; y = y + 1)
                    {
                        if (ValueToSearch[0] == SelectToDelete[y][0] && ValueToSearch[1] == SelectToDelete[y][1])
                        {
                            newTimingPointsLists[Num].RemoveAt(i);
                            break;
                        }
                    }
                }
            }

            newTimingPoint = newTimingPointsLists;
        }
    }
}
