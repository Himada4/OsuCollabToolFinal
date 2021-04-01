using OsuCollabTool.Main_Classes;
using OsuCollabTool.Main_Classes.HitsoundingFunc;
using OsuCollabTool.Main_Classes.MappingFunc;
using OsuCollabTool.Main_Classes.MergerFunc;
using OsuCollabTool.Main_Classes.SongSetupFunc;
using OsuCollabTool.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace OsuCollabTool
{
    public partial class MainInterface : Form
    {
        private Draggable move; // Variable used for enabling draggable form

        private string songFolder; // The "Songs" folder
        private Color[] theme; // The Colors of the three UI elements; Form border, buttons and the background
        private int[] buttonOrder; // The order of the menu category
        private string currentFolder; // The current mapset
        private string currentOsu; // The specific .osu file

        private int dirNullCount = 0; // Variable used for first time uses, when the preferences are all empty

        public MainInterface()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            move = new Draggable(this, FormBorder.Size.Height); // enables form to be draggable
            move.SetMovable(FormBorder, ProjectLabel);
            RefreshUI(); // Updates the UI to the current settings of preferences
        }

        #region UIRelated Operations

        private void CloseApp_MouseEnter(object sender, EventArgs e)
        {
            CloseApp.BackColor = Color.Red;
        }

        private void CloseApp_MouseLeave(object sender, EventArgs e)
        {
            CloseApp.BackColor = theme[0];
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); // Helps to kill all threads if running one
        }

        private void Mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Pref_Click(object sender, EventArgs e) // https://www.codeproject.com/Questions/557261/HowplustoplusrefreshplusMainplusFormplusinplusC-23
        {
            MainScrMenu.Enabled = false;
            MainIntBG.Controls.Clear();
            Form form = new Preferences();
            form.FormClosed += new FormClosedEventHandler(PrefFormClosed);
            form.Show(); // Shows the user the preferences settings
        }

        private void PrefFormClosed(object sender, FormClosedEventArgs e) // Executes when preferences settings have been closed, allows a live update without the need to close the application
        {
            RefreshUI();
            dirNullCount = 0;
            MainScrMenu.Enabled = true;
        }

        private void Backup_Click(object sender, EventArgs e)
        {
            // Makes sure directory is viable
            if (string.IsNullOrEmpty(songFolder) ||
                string.IsNullOrEmpty(currentFolder) ||
                string.IsNullOrEmpty(currentOsu))
            {
                MessageBox.Show("Please make sure to input the directories in Preferences!");
            }
            else
            {
                string[] files = Directory.GetFiles($@"{songFolder}{currentFolder}");

                List<string> mapset = new List<string>();

                // Looks for every .osu files in the folder used to backup
                foreach (string file in files)
                {
                    if (file.Contains(".osu"))
                    {
                        mapset.Add($@"{songFolder}{currentFolder}\{Path.GetFileName(file)}");
                    }
                }

                Directory.CreateDirectory(@"Backup");

                foreach (var map in mapset)
                {
                    File.Copy(map, Path.Combine(@"Backup\", Path.GetFileName(map)), true);
                }
            }
        }

        public static List<ToolStripMenuItem> category;
        public static List<ToolStripMenuItem> audioFeatures;

        private void RefreshUI() // Updates the UI to the preferences.txt
        {
            // Checks if any libraries are missing
            string[] libraries = Directory.GetFiles($@"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}");
            List<string> check = new List<string>() { "EditorReader.dll", "Microsoft.Win32.Registry.dll", "Microsoft.Win32.Registry.xml", "NAudio.Asio.dll", "NAudio.Core.dll", "NAudio.dll", "NAudio.Midi.dll", "NAudio.Wasapi.dll", "NAudio.WinForms.dll", "NAudio.WinMM.dll", "NAudio.xml", "OsuCollabTool.exe.config", "OsuCollabTool.pdb", "OsuMemoryDataProvider.dll", "ProcessMemoryDataFinder.dll", "System.Security.AccessControl.dll", "System.Security.AccessControl.xml", "System.Security.Principal.Windows.dll", "System.Security.Principal.Windows.xml" };

            List<int> ind = new List<int>();
            foreach (var library in libraries)
            {
                for (int i = 0; i < check.Count; i = i + 1)
                {
                    if (check[i] == Path.GetFileName(library))
                    {
                        ind.Add(i);
                        break;
                    }
                }
            }

            for (int i = ind.Count - 1; i >= 0; i = i - 1)
            {
                check.RemoveAt(i);
            }

            string missingFiles = string.Empty;

            foreach (var fileMissing in check)
            {
                missingFiles = $"{missingFiles}{Environment.NewLine}{fileMissing}";
            }
            if (check.Count != 0)
            {
                MessageBox.Show($"An error has occured, one or several libraries are missing, please re-install this program. {Environment.NewLine} Missing file(s): {missingFiles}");
                Environment.Exit(0);
            }

            // Makes sure all directories and settings are viable
            // Gets map directory and UI information
            UIDataExtractor ext = new UIDataExtractor();
            ext.Refresh();
            songFolder = ext.GetSongFol();
            theme = ext.GetTheme();
            buttonOrder = ext.GetButOrd();
            currentFolder = ext.GetCurrFol();
            currentOsu = ext.GetCurrOsu();

            // Border of the Form
            FormBorder.BackColor = theme[0];
            Pref.BackColor = theme[0];
            Mini.BackColor = theme[0];
            CloseApp.BackColor = theme[0];
            Backup.BackColor = theme[0];
            Common.ContrastColor(theme[0], ProjectLabel);

            // BG
            MainIntBG.BackColor = theme[2];
            MainScrMenu.Items.Clear();

            // Song Stetup
            ToolStripMenuItem songSetup = new ToolStripMenuItem();
            songSetup.Click += (s, e) => { CheckAudioMenuEnablility($"{songFolder}{currentFolder}{currentOsu}"); };
            songSetup.Text = "SongSetup";

            // Map Setup
            ToolStripMenuItem mapSetup = new ToolStripMenuItem();
            mapSetup.Text = "Map Setup";
            mapSetup.Click += (s, e) => { MapSetupIntf childForm = new MapSetupIntf(); OpenChildForm(childForm); };
            songSetup.DropDownItems.Add(mapSetup);

            // BPM Detector
            ToolStripMenuItem bpmDetector = new ToolStripMenuItem();
            bpmDetector.Text = "BPM Detector";
            bpmDetector.Click += (s, e) => { BPMDetectorIntf childForm = new BPMDetectorIntf(); OpenChildForm(childForm); };
            songSetup.DropDownItems.Add(bpmDetector);
            //// -----

            // Merger https://stackoverflow.com/questions/6187944/how-can-i-create-a-dynamic-button-click-event-on-a-dynamic-button
            ToolStripMenuItem merger = new ToolStripMenuItem();
            merger.Click += (s, e) => { CheckAudioMenuEnablility($"{songFolder}{currentFolder}{currentOsu}"); };
            merger.Text = "Merger";

            // Merge
            ToolStripMenuItem merge = new ToolStripMenuItem();
            merge.Text = "Merge";
            merge.Click += (s, e) => { MergeIntf childForm = new MergeIntf(); OpenChildForm(childForm); };
            merger.DropDownItems.Add(merge);

            // Compare
            ToolStripMenuItem compare = new ToolStripMenuItem();
            compare.Text = "Compare";
            compare.Click += (s, e) => { CompareIntf childForm = new CompareIntf(); OpenChildForm(childForm); };
            merger.DropDownItems.Add(compare);

            // Seperate
            ToolStripMenuItem seperate = new ToolStripMenuItem();
            seperate.Text = "Seperate";
            seperate.Click += (s, e) => { SeperatorIntf childForm = new SeperatorIntf(); OpenChildForm(childForm); };
            merger.DropDownItems.Add(seperate);
            ////-----

            // Hitsounding
            ToolStripMenuItem hitsounding = new ToolStripMenuItem();
            hitsounding.Click += (s, e) => { CheckAudioMenuEnablility($"{songFolder}{currentFolder}{currentOsu}"); };
            hitsounding.Text = "Hitsounding";

            // Volume Tool
            ToolStripMenuItem volumeTool = new ToolStripMenuItem();
            volumeTool.Text = "Volume Tool";
            volumeTool.Click += (s, e) => { VolumeToolIntf childForm = new VolumeToolIntf(); OpenChildForm(childForm); };
            hitsounding.DropDownItems.Add(volumeTool);

            // HitObject Tool
            ToolStripMenuItem hitObjectTool = new ToolStripMenuItem();
            hitObjectTool.Text = "HitObject Tool";
            hitObjectTool.Click += (s, e) => { HitObjIntf childForm = new HitObjIntf(); OpenChildForm(childForm); };
            hitsounding.DropDownItems.Add(hitObjectTool);
            //// -----

            // Mapping
            ToolStripMenuItem mapping = new ToolStripMenuItem();
            mapping.Click += (s, e) => { CheckAudioMenuEnablility($"{songFolder}{currentFolder}{currentOsu}"); };
            mapping.Text = "Mapping";

            // Slider Bank
            ToolStripMenuItem sliderBank = new ToolStripMenuItem();
            sliderBank.Text = "Pattern Bank";
            sliderBank.Click += (s, e) => { PatternBank childForm = new PatternBank(); OpenChildForm(childForm); };
            mapping.DropDownItems.Add(sliderBank);
            //// -----

            category = new List<ToolStripMenuItem>() { songSetup, merger, hitsounding, mapping };
            audioFeatures = new List<ToolStripMenuItem>() { hitObjectTool, volumeTool, seperate, bpmDetector };

            // Disables the toolstripmenu if the directories are null
            if (string.IsNullOrEmpty(songFolder) || string.IsNullOrEmpty(currentFolder) || string.IsNullOrEmpty(currentOsu))
            {
                foreach (var control in category)
                {
                    control.Enabled = false;
                }
            }

            CheckAudioMenuEnablility($"{songFolder}{currentFolder}{currentOsu}");

            // Shows err dialogue when using the program for the first time
            MainScrMenu.MouseEnter += (s, e) =>
            {
                if (dirNullCount == 0 && (string.IsNullOrEmpty(songFolder) || string.IsNullOrEmpty(currentFolder) || string.IsNullOrEmpty(currentOsu)))
                {
                    MessageBox.Show(ExceptionsHandling.dirNull.Message);
                    dirNullCount = dirNullCount + 1;
                }
            };

            // Button Sorting
            foreach (var item in buttonOrder)
            {
                switch (item)
                {
                    case 1:
                        MainScrMenu.Items.Add(songSetup);
                        break;

                    case 2:
                        MainScrMenu.Items.Add(merger);
                        break;

                    case 3:
                        MainScrMenu.Items.Add(hitsounding);
                        break;

                    case 4:
                        MainScrMenu.Items.Add(mapping);
                        break;
                }
            }
        }

        private Form activeForm = null;

        private void OpenChildForm(Form childForm) // Used for opening the child forms
        {
            try
            {
                if (activeForm != null)
                {
                    activeForm.Close();
                }
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                MainIntBG.Controls.Add(childForm);
                MainIntBG.Tag = childForm;
                childForm.Show();
            }
            catch (Exception exc)
            {
                MessageBox.Show("There was a problem opening the file, reason: " + exc.Message);
                RefreshUI();
            }
        }

        private void CheckAudioMenuEnablility(string fullPathDir)
        {
            // Checks if the mapset has a audio
            string[] files = Directory.GetFiles($@"{Path.GetDirectoryName(fullPathDir)}");
            bool hasAudio = false;

            foreach (string file in files)
            {
                if (file.Contains(".mp3") || file.Contains(".ogg") || file.Contains(".wav"))
                {
                    hasAudio = true;
                }
            }

            if (!hasAudio)
            {
                MessageBox.Show("No audio file detected, disabling features that involves audio analysis");

                foreach (var control in audioFeatures)
                {
                    control.Enabled = false;
                }
            }
        }

        #endregion UIRelated Operations
    }
}