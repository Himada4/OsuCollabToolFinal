using Editor_Reader;
using OsuCollabTool.CoreClasses;
using OsuCollabTool.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsuCollabTool.Main_Classes.MappingFunc
{
    public partial class PatternBank : Form
    {
        private string[] savedObj;
        private int insertVal = 0;
        private string dir = string.Empty;

        public PatternBank()
        {
            InitializeComponent();
            try
            {
                UIDataExtractor ext = new UIDataExtractor();

                // Theme
                Color[] theme = ext.GetTheme();

                Common.SetBGCol(theme[2], MainBG1, MainBG2);
                Common.SetBtnCol(theme[1], ObjSelected, ObjClip, OpenPatternBank, PasteBtn, OpenFolderLoc, SavePattern);
                Common.ContrastColor(theme[2], l1, l2, l3, l4, l5);
                Common.ContrastColor(theme[1], ObjSelected, ObjClip, OpenPatternBank, PasteBtn, OpenFolderLoc, SavePattern);
                Directory.CreateDirectory(@"Pattern Bank");
                dir = $@"{ext.GetSongFol()}{ext.GetCurrFol()}{ext.GetCurrOsu()}";
            }
            catch
            {
                this.Close();
            }
        }

        // Saves Pattern to Pattern Bank
        private void SavePattern_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> savedPattern = new List<string>();

                foreach (var stringObj in ObjList.Items)
                {
                    savedPattern.Add(stringObj.ToString());
                }

                using (var sfd = new SaveFileDialog())
                {
                    sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    sfd.FilterIndex = 1;
                    sfd.InitialDirectory = $@"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\Pattern Bank";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllLines(sfd.FileName, savedPattern);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        // Gets the selected objects within the Osu! editor
        private void ObjSelected_Click(object sender, EventArgs e)
        {
            try
            {
                ObjList.Items.Clear();
                EditorReader editor = new EditorReader();
                editor.FetchHOM();
                editor.FetchSelected();

                var selectedObj = editor.selectedObjects;

                foreach (var obj in selectedObj)
                {
                    ObjList.Items.Add(obj);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        // Gets the copied objects within the Osu! editor
        private void ObjClip_Click(object sender, EventArgs e)
        {
            try
            {
                ObjList.Items.Clear();
                EditorReader editor = new EditorReader();
                editor.FetchHOM();
                editor.FetchClipboard();

                var clippedObj = editor.clipboardObjects;

                foreach (var obj in clippedObj)
                {
                    ObjList.Items.Add(obj);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        // Opends the Pattern bank for the user to choose which to paste
        private void OpenPatternBank_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ofd = new OpenFileDialog())
                {
                    ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    ofd.FilterIndex = 1;
                    ofd.InitialDirectory = $@"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\Pattern Bank";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        savedObj = File.ReadAllLines(ofd.FileName);
                        FileName.Text = ofd.FileName;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        // Triggers process to paste the pattern, but first checks for errors
        private async void PasteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PasteBtn.Text = "Processing...";

                Exception exc = await Task.Run(StartPaste);

                if (exc == null)
                {
                    PasteBtn.Text = "Complete!";

                    MessageBox.Show("Pattern has been pasted successfully!");

                    PasteBtn.Text = "Make Changes!";
                }
                else
                {
                    PasteBtn.Text = "Error";
                    MessageBox.Show(exc.Message);
                    PasteBtn.Text = "Make Changes!";
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        // Actual process for pasting the pattern
        private Exception StartPaste()
        {
            try
            {
                Exception exc = null;

                string offsetText = OffsetTextBox.Text;

                int offset = 0;

                if (offsetText.Contains(":"))
                {
                    string[] arrOffset = offsetText.Split(':');

                    int decimalNum = Convert.ToInt32(arrOffset[2]);

                    int secondsNum = Convert.ToInt32(arrOffset[1]) * 1000;

                    int minutesNum = Convert.ToInt32(arrOffset[0]) * 60 * 1000;

                    offset = decimalNum + secondsNum + minutesNum;
                }
                else
                {
                    offset = Convert.ToInt32(OffsetTextBox.Text);
                }

                if (savedObj == null)
                {
                    throw ExceptionsHandling.patternFileNotSelected;
                }
                else
                {
                    int[] diff = new int[savedObj.Length];

                    diff[0] = offset;

                    int[] originalOffset = new int[savedObj.Length];

                    for (int i = 0; i < savedObj.Length; i = i + 1)
                    {
                        originalOffset[i] = Convert.ToInt32(savedObj[i].Split(',')[2]);
                    }

                    if (diff.Length > 1)
                    {
                        for (int i = 1; i < savedObj.Length; i = i + 1)
                        {
                            diff[i] = originalOffset[i] - originalOffset[0];
                        }
                    }

                    string[] result = new string[savedObj.Length];

                    for (int i = 0; i < savedObj.Length; i = i + 1)
                    {
                        string[] splitArr = savedObj[i].Split(',');
                        if (i == 0)
                        {
                            splitArr[2] = $"{diff[0]}";
                        }
                        else
                        {
                            splitArr[2] = $"{diff[0] + diff[i]}";
                        }

                        result[i] = string.Join(",", splitArr);
                    }

                    insertVal = diff[0];

                    UIDataExtractor ext = new UIDataExtractor();

                    MapDataExtractor map = new MapDataExtractor(dir);

                    List<string> hitObj = map.GetHitObjString();

                    List<string> newHitObj = new List<string>();

                    newHitObj.Add("[HitObjects]");

                    int noRepeat = 0;
                    hitObj.RemoveAt(0);

                    for (int i = 0; i < hitObj.Count; i = i + 1)
                    {
                        string[] arr = hitObj[i].Split(',');

                        if (Convert.ToInt32(arr[2]) > insertVal && noRepeat == 0)
                        {
                            newHitObj.AddRange(result);
                            noRepeat = noRepeat + 1;
                            newHitObj.Add(hitObj[i]);
                        }
                        else
                        {
                            newHitObj.Add(hitObj[i]);
                        }
                    }

                    //newHitObj.Add(string.Empty);

                    Common.ReplaceFileWithNewData(dir, 8, newHitObj);

                    return exc;
                }
            }
            catch (Exception exc)
            {
                return exc;
            }
        }

        // Opens the folder location of the Pattern Bank if needed
        private void OpenFolderLoc_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", $@"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\Pattern Bank");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}