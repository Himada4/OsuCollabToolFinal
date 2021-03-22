using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Editor_Reader;
using OsuCollabTool.UI;
using System.IO;
using System.Reflection;
using OsuCollabTool.CoreClasses;

namespace OsuCollabTool.Main_Classes.MappingFunc
{
    public partial class PatternBank : Form
    {
        string[] SavedObj;
        int insertVal = 0;
        public PatternBank()
        {
            InitializeComponent();

            UIDataExtractor ext = new UIDataExtractor();

            //theme
            Color[] theme = ext.getTheme();

            Common.setBGCol(theme[2],MainBG1,MainBG2);
            Common.setBtnCol(theme[1],ObjSelected,ObjClip,OpenPatternBank,PasteBtn,OpenFolderLoc,SavePattern);
            Directory.CreateDirectory(@"Pattern Bank");


        }

        
        private void SavePattern_Click(object sender, EventArgs e)
        {
            
            List<string> SavedPattern = new List<string>();

            foreach (var stringObj in ObjList.Items)
            {
                SavedPattern.Add(stringObj.ToString());
            }

            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.FilterIndex = 1;
                sfd.InitialDirectory = $@"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\Pattern Bank";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllLines(sfd.FileName, SavedPattern);

                }
            }

        }

        private void ObjSelected_Click(object sender, EventArgs e)
        {
            ObjList.Items.Clear();
            EditorReader editor = new EditorReader();
            editor.FetchHOM();
            editor.FetchSelected();

            
            var SelectedObj = editor.selectedObjects;

            foreach (var obj in SelectedObj)
            {
                ObjList.Items.Add(obj);
            }
        }

        private void ObjClip_Click(object sender, EventArgs e)
        {
            ObjList.Items.Clear();
            EditorReader editor = new EditorReader();
            editor.FetchHOM();
            editor.FetchClipboard();
            

            var ClippedObj = editor.clipboardObjects;

            foreach (var obj in ClippedObj)
            {
                ObjList.Items.Add(obj);
            } 
            
        }

        private void OpenPatternBank_Click(object sender, EventArgs e)
        {
            
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                ofd.FilterIndex = 1;
                ofd.InitialDirectory = $@"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\Pattern Bank";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    SavedObj = File.ReadAllLines(ofd.FileName);
                    FileName.Text = ofd.FileName;
                }
            }

        }

        private void PasteBtn_Click(object sender, EventArgs e)
        {
            string offsetText = OffsetTextBox.Text;

            int offset = 0;

            if (offsetText.Contains(":"))
            {
                string[] arrOffset = offsetText.Split(':');

                int decimalNum = Convert.ToInt32(arrOffset[2]);

                int secondsNum = Convert.ToInt32(arrOffset[1])*1000;

                int minutesNum = (Convert.ToInt32(arrOffset[0]))*60*1000;

                offset = decimalNum + secondsNum + minutesNum;
            }
            else
            {
                offset = Convert.ToInt32(OffsetTextBox.Text);
            }

            if(SavedObj == null)
            {
                MessageBox.Show("Please select a pattern file!");
            }
            else
            {
                int[] diff = new int[SavedObj.Length];

                diff[0] = offset;

                int[] originalOffset = new int[SavedObj.Length];

                for (int i = 0; i < SavedObj.Length; i = i + 1)
                {
                    originalOffset[i] = Convert.ToInt32(SavedObj[i].Split(',')[2]);
                }

                if (diff.Length > 1)
                {
                    for (int i = 1; i < SavedObj.Length; i = i + 1)
                    {
                        diff[i] = originalOffset[i] - originalOffset[0];
                    }
                }

                string[] result = new string[SavedObj.Length];

                for (int i = 0; i < SavedObj.Length; i = i + 1)
                {
                    string[] splitArr = SavedObj[i].Split(',');
                    if (i == 0)
                    {
                        splitArr[2] = $"{diff[0]}";
                    }
                    else 
                    {
                        splitArr[2] = $"{diff[0] + diff[i]}"; 
                    }

                    result[i] = String.Join(",", splitArr);
                }

                insertVal = diff[0];

                UIDataExtractor ext = new UIDataExtractor();

                string Dir = $@"{ext.getSongFol()}{ext.getCurrFol()}{ext.getCurrOsu()}";

                MapDataExtractor map = new MapDataExtractor(Dir);

                List<string> HitObj = map.GetHitObjString();

                List<string> newHitObj = new List<string>();

                newHitObj.Add("[HitObjects]");

                int noRepeat = 0;
                HitObj.RemoveAt(0);
                HitObj.RemoveAt(HitObj.Count - 1);

                for (int i = 0; i < HitObj.Count; i = i + 1)
                {

                    string[] arr = HitObj[i].Split(',');

                    if(Convert.ToInt32(arr[2]) > insertVal && noRepeat == 0)
                    {
                        newHitObj.AddRange(result);
                        noRepeat = noRepeat + 1;
                        newHitObj.Add(HitObj[i]);
                    }
                    else
                    {
                        newHitObj.Add(HitObj[i]);
                    }
                }

                newHitObj.Add("");

                Common.ReplaceFileWithNewData(Dir, 8, newHitObj);
                MessageBox.Show("Completed");
            }

            
        }
    }
}
