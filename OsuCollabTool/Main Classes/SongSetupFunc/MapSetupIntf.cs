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
            Color[] Theme = ext.getTheme();
            
            //Interface Theme Set
            Common.setBGCol(Theme[2], MainIntfBG);
            Common.setBtnCol(Theme[1], GeneralTabBtn, MetadataTabBtn, DifficultyTabBtn);
            Common.ContrastColor(Theme[1], GeneralTabBtn, MetadataTabBtn, DifficultyTabBtn);
        }

        
        private Form activeForm = new Form(); 
        private void GeneralTabBtn_Click(object sender, System.EventArgs e)
        {
            GeneralTabIntf childForm = new GeneralTabIntf();
            activeForm = Common.ReloadChildform(activeForm, childForm, MainIntfBG);
        }

        private void MetadataTabBtn_Click(object sender, System.EventArgs e)
        {
            MetaDataIntf childForm = new MetaDataIntf();
            activeForm = Common.ReloadChildform(activeForm, childForm, MainIntfBG);
        }

        private void DifficultyTabBtn_Click(object sender, System.EventArgs e)
        {
            DifficultyIntf childForm = new DifficultyIntf();
            activeForm = Common.ReloadChildform(activeForm, childForm, MainIntfBG);
        }
    }
}