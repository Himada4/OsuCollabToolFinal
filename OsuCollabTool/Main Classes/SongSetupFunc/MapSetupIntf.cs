using OsuCollabTool.UI;
using System.Drawing;
using System.Windows.Forms;

namespace OsuCollabTool.Main_Classes.SongSetupFunc
{
    public partial class MapSetupIntf : Form
    {
        public MapSetupIntf()
        {
            InitializeComponent();
            UIDataExtractor ext = new UIDataExtractor();
            Color[] theme = ext.GetTheme();

            // Interface Theme Set
            Common.SetBGCol(theme[2], MainIntfBG);
            Common.SetBtnCol(theme[1], GeneralTabBtn, MetadataTabBtn, DifficultyTabBtn);
            Common.ContrastColor(theme[1], GeneralTabBtn, MetadataTabBtn, DifficultyTabBtn);
        }

        private Form activeForm = new Form();

        // Opens the form, "General Tab"
        private void GeneralTabBtn_Click(object sender, System.EventArgs e)
        {
            GeneralTabIntf childForm = new GeneralTabIntf();
            activeForm = Common.ReloadChildform(activeForm, childForm, MainIntfBG);
        }

        // Opens the form, "Metadata Tab"
        private void MetadataTabBtn_Click(object sender, System.EventArgs e)
        {
            MetaDataIntf childForm = new MetaDataIntf();
            activeForm = Common.ReloadChildform(activeForm, childForm, MainIntfBG);
        }

        // Opens the form, "Difficulty Tab"
        private void DifficultyTabBtn_Click(object sender, System.EventArgs e)
        {
            DifficultyIntf childForm = new DifficultyIntf();
            activeForm = Common.ReloadChildform(activeForm, childForm, MainIntfBG);
        }
    }
}