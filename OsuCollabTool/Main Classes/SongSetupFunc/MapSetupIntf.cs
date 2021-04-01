using OsuCollabTool.UI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OsuCollabTool.Main_Classes.SongSetupFunc
{
    public partial class MapSetupIntf : Form
    {
        public MapSetupIntf()
        {
            InitializeComponent();
            try
            {
                UIDataExtractor ext = new UIDataExtractor();
                Color[] theme = ext.GetTheme();

                // Interface Theme Set
                Common.SetBGCol(theme[2], MainIntfBG);
                Common.SetBtnCol(theme[1], GeneralTabBtn, MetadataTabBtn, DifficultyTabBtn);
                Common.ContrastColor(theme[1], GeneralTabBtn, MetadataTabBtn, DifficultyTabBtn);
            }
            catch
            {
                this.Close();
            }
        }

        private Form activeForm = new Form();

        // Opens the form, "General Tab"
        private void GeneralTabBtn_Click(object sender, System.EventArgs e)
        {
            try
            {
                GeneralTabIntf childForm = new GeneralTabIntf();
                activeForm = Common.ReloadChildform(activeForm, childForm, MainIntfBG);
            }
            catch 
            {
                MessageBox.Show("There was an error opening this tab, perhaps your directory isn't valid?");
            }
        }

        // Opens the form, "Metadata Tab"
        private void MetadataTabBtn_Click(object sender, System.EventArgs e)
        {
            try
            {
                MetaDataIntf childForm = new MetaDataIntf();
                activeForm = Common.ReloadChildform(activeForm, childForm, MainIntfBG);
            }
            catch
            {
                MessageBox.Show("There was an error opening this tab, perhaps your directory isn't valid?");
            }
        }

        // Opens the form, "Difficulty Tab"
        private void DifficultyTabBtn_Click(object sender, System.EventArgs e)
        {
            try
            {
                DifficultyIntf childForm = new DifficultyIntf();
                activeForm = Common.ReloadChildform(activeForm, childForm, MainIntfBG);
            }
            catch
            {
                MessageBox.Show("There was an error opening this tab, perhaps your directory isn't valid?");
            }
        }
    }
}