using OsuCollabTool.UI;
using System;
using System.Drawing;
using System.Windows.Forms;
using OsuCollabTool.Main_Classes.HitsoundingFunc;
using OsuCollabTool.Main_Classes.MappingFunc;
using OsuCollabTool.Main_Classes.MergerFunc;
using OsuCollabTool.Main_Classes.SongSetupFunc;
using OsuCollabTool.Main_Classes;
using System.IO;
using System.Collections.Generic;

namespace OsuCollabTool
{
    public partial class MainInterface : Form
    {
        private Draggable _move;

        private string SongFolder;
        private Color[] Theme;
        private int[] ButtonOrder;
        private string CurrentFolder;
        private string CurrentOsu;
        
        private int DirNullCount = 0;

        public MainInterface()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _move = new Draggable(this, FormBorder.Size.Height); // enables screen to be draggable
            _move.SetMovable(FormBorder, ProjectLabel);
            RefreshUI();
        }

        #region UIRelated Operations

        private void CloseApp_MouseEnter(object sender, EventArgs e)
        {
            CloseApp.BackColor = Color.Red;
            
        }

        private void CloseApp_MouseLeave(object sender, EventArgs e)
        {
            CloseApp.BackColor = Theme[0];
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Pref_Click(object sender, EventArgs e) //https://www.codeproject.com/Questions/557261/HowplustoplusrefreshplusMainplusFormplusinplusC-23
        {
            MainScrMenu.Enabled = false;
            MainIntBG.Controls.Clear();
            Form form = new Preferences();
            form.FormClosed += new FormClosedEventHandler(prefFormClosed);
            form.Show();
        }

        private void prefFormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshUI();
            DirNullCount = 0;
            MainScrMenu.Enabled = true;
        }

        private void Backup_Click(object sender, EventArgs e)
        {
            if(SongFolder == null ||
                CurrentFolder == null||
                CurrentOsu == null||
                SongFolder == "" ||
                CurrentFolder == "" ||
                CurrentOsu == "" )
            {
                MessageBox.Show("Please make sure to input the directories in Preferences!");
            }
            else
            {
                
                string[] files = Directory.GetFiles($@"{SongFolder}{CurrentFolder}");

                List<string> mapset = new List<string>();

                foreach (string file in files)
                {
                    if (file.Contains(".osu"))
                    {
                        mapset.Add($@"{SongFolder}{CurrentFolder}\{Path.GetFileName(file)}");
                    }
                }
                Directory.CreateDirectory(@"Backup");

                foreach (var map in mapset)
                {
                    File.Copy(map, Path.Combine(@"Backup\", Path.GetFileName(map)),true);
                }
            }
        }

        private void RefreshUI()
        {

            string DirNull = "Please make sure to input the directories in Preferences!";
            UIDataExtractor ext = new UIDataExtractor();
            ext.refresh();
            SongFolder = ext.getSongFol();
            Theme = ext.getTheme();
            ButtonOrder = ext.getButOrd();
            CurrentFolder = ext.getCurrFol();
            CurrentOsu = ext.getCurrOsu();
            

            //Border of the Form
            FormBorder.BackColor = Theme[0];
            Pref.BackColor = Theme[0];
            Mini.BackColor = Theme[0];
            CloseApp.BackColor = Theme[0];
            Backup.BackColor = Theme[0];
            Common.ContrastColor(Theme[0], ProjectLabel);

            //BG
            MainIntBG.BackColor = Theme[2];

            //MainMenu(Button Order) https://www.youtube.com/watch?v=PaWExQHEL30

            MainScrMenu.Items.Clear();


                //Song Stetup
            ToolStripMenuItem SongSetup = new ToolStripMenuItem();
            SongSetup.Text = "SongSetup";
            
            
                    //Map Setup
            ToolStripMenuItem MapSetup = new ToolStripMenuItem();
            MapSetup.Text = "Map Setup";
            MapSetup.Click += (s, e) => { MapSetupIntf childForm = new MapSetupIntf(); openChildForm(childForm); };
            SongSetup.DropDownItems.Add(MapSetup);
                    //BPM Detector
            ToolStripMenuItem BPMDetector = new ToolStripMenuItem();
            BPMDetector.Text = "BPM Detector";
            BPMDetector.Click += (s, e) => { BPMDetectorIntf childForm = new BPMDetectorIntf(); openChildForm(childForm); };
            SongSetup.DropDownItems.Add(BPMDetector);
            // -----

                //Merger https://stackoverflow.com/questions/6187944/how-can-i-create-a-dynamic-button-click-event-on-a-dynamic-button
            ToolStripMenuItem Merger = new ToolStripMenuItem();
            Merger.Text = "Merger";
            
                    //Merge
            ToolStripMenuItem Merge = new ToolStripMenuItem();
            Merge.Text = "Merge";
            Merge.Click += (s, e) => { MergeIntf childForm = new MergeIntf(); openChildForm(childForm); };
            Merger.DropDownItems.Add(Merge);
                    //Compare
            ToolStripMenuItem Compare = new ToolStripMenuItem();
            Compare.Text = "Compare";
            Compare.Click += (s, e) => { CompareIntf childForm = new CompareIntf(); openChildForm(childForm); };
            Merger.DropDownItems.Add(Compare);
                    //Seperate
            ToolStripMenuItem Seperate = new ToolStripMenuItem();
            Seperate.Text = "Seperate";
            Seperate.Click += (s, e) => { SeperatorIntf childForm = new SeperatorIntf(); openChildForm(childForm); };
            Merger.DropDownItems.Add(Seperate);
            // ----- 

                //Hitsounding
            ToolStripMenuItem Hitsounding = new ToolStripMenuItem();
            Hitsounding.Text = "Hitsounding";
            
                    //Volume Tool
            ToolStripMenuItem VolumeTool = new ToolStripMenuItem();
            VolumeTool.Text = "Volume Tool";
            VolumeTool.Click += (s, e) => { VolumeToolIntf childForm = new VolumeToolIntf(); openChildForm(childForm); };
            Hitsounding.DropDownItems.Add(VolumeTool);
                    //HitObject Tool
            ToolStripMenuItem HitObjectTool = new ToolStripMenuItem();
            HitObjectTool.Text = "HitObject Tool";
            HitObjectTool.Click += (s, e) => { HitObjIntf childForm = new HitObjIntf(); openChildForm(childForm); };
            Hitsounding.DropDownItems.Add(HitObjectTool);
            // -----
            
                //Mapping
            ToolStripMenuItem Mapping = new ToolStripMenuItem();
            Mapping.Text = "Mapping";
            
                    //Slider Bank
            ToolStripMenuItem SliderBank = new ToolStripMenuItem();
            SliderBank.Text = "Pattern Bank";
            SliderBank.Click += (s, e) => { PatternBank childForm = new PatternBank(); openChildForm(childForm); }; 
            Mapping.DropDownItems.Add(SliderBank);
            // -----

            

            //disables the toolstripmenu if the directories are null
            if (SongFolder == "" || CurrentFolder == "" || CurrentOsu == "")
            {
                SongSetup.Enabled = false;
                Merger.Enabled = false;
                Hitsounding.Enabled = false;
                Mapping.Enabled = false;
                
                
            }

            //Shows err dialogue when doing first time
            MainScrMenu.MouseEnter += (s, e) => 
            {
                if (DirNullCount == 0 && (SongFolder == "" || CurrentFolder == "" || CurrentOsu == ""))
                { 
                    MessageBox.Show(DirNull);
                    DirNullCount = DirNullCount + 1; 
                }
            };

            //Button Sorting
            foreach (var item in ButtonOrder)
            {
                switch (item)
                {
                    case 1:
                        MainScrMenu.Items.Add(SongSetup);
                        break;
                    case 2:
                        MainScrMenu.Items.Add(Merger);
                        break;
                    case 3:
                        MainScrMenu.Items.Add(Hitsounding);
                        break;
                    case 4:
                        MainScrMenu.Items.Add(Mapping);
                        break;
                } 
            }

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            MainIntBG.Controls.Add(childForm); 
            MainIntBG.Tag = childForm;
            childForm.Show();
        }



        #endregion UIRelated Operations

        
    }
}