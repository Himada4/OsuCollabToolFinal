using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsuCollabTool.Main_Classes.MergerFunc
{
    public partial class CompareLog : Form
    {
        List<string> file1T = new List<string>();
        List<string> file2T = new List<string>();
        List<string> file1H = new List<string>();
        List<string> file2H = new List<string>();
        public CompareLog(List<string> file1TIn, List<string> file2TIn, List<string> file1HIn, List<string> file2HIn, List<string> songNames)
        {
            InitializeComponent();

            file1T = file1TIn;
            file2T = file2TIn;
            file1H = file1HIn;
            file2H = file2HIn;

            populateListBoxes(file1T,TPFile1);
            populateListBoxes(file2T, TPFile2);
            populateListBoxes(file1H, HOFile1);
            populateListBoxes(file2H, HOFile2);

            File1NameT.Text = songNames[0];
            File1NameH.Text = songNames[0];
            File2NameT.Text = songNames[1];
            File2NameH.Text = songNames[1];
        }

        private void populateListBoxes(List<string> list, ListBox control)
        {
            foreach (var line in list)
            {
                control.Items.Add(line);
                
            }
        }

        private void TP_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Control && e.KeyCode == Keys.C)
                {
                    string s = (sender as ListBox).SelectedItem.ToString();
                    string[] temp = s.Split(',');
                    
                    string copyText = temp[0];

                    Clipboard.SetText(copyText);
                }
            }
            catch
            {
                MessageBox.Show("Please select an Item first.");
            }
        }

        private void HO_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Control && e.KeyCode == Keys.C)
                {
                    string s = (sender as ListBox).SelectedItem.ToString();
                    string[] temp = s.Split(',');

                    string copyText = temp[2];

                    Clipboard.SetText(copyText);
                }
            }
            catch
            {
                MessageBox.Show("Please select an Item first.");
            }
        }

        

        private void ClickedTP(object sender, EventArgs e)
        {
            ListBox control = sender as ListBox;

            string tagNum = control.Tag.ToString();

            if(tagNum == "1")
            {
                TPFile2.ClearSelected();
            }
            else
            {
                TPFile1.ClearSelected();
            }
        }
    }
}
