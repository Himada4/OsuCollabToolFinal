using Editor_Reader;
using OsuMemoryDataProvider;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OsuCollabTool.UI
{
    public partial class Preferences : Form
    {
        public Preferences()
        {
            InitializeComponent();
        }

        private string songFolder;
        private Color[] theme;
        private int[] buttonOrder;
        private string currentFolder;
        private string currentOsu;

        private void Preferences_Load(object sender, EventArgs e)
        {
            UIDataExtractor ext = new UIDataExtractor();

            ext.Refresh();

            songFolder = ext.GetSongFol();
            theme = ext.GetTheme();
            buttonOrder = ext.GetButOrd();
            currentFolder = ext.GetCurrFol();
            currentOsu = ext.GetCurrOsu();

            SongFolTxb.Text = songFolder;
            CurrFolTxb.Text = currentFolder;
            CurrOsuTxb.Text = currentOsu;

            BorderCol.BackColor = theme[0];
            BtnCol.BackColor = theme[1];
            BGCol.BackColor = theme[2];

            // Deals with the button order

            #region button order

            List<Button> currBtnOrder = DetectbuttonOrder();
            List<Button> buttons = new List<Button>();

            foreach (var b in currBtnOrder)
            {
                for (int i = 0; i < buttonOrder.Length; i = i + 1)
                {
                    if (buttonOrder[i] == b.TabIndex)
                    {
                        b.Tag = i + 1;
                        buttons.Add(b);
                    }
                }
            }

            List<Button> listResult = new List<Button>();
            for (int j = 0; j < 4; j = j + 1)
            {
                int minInd = 5;
                int min = 5;

                for (int i = 0; i < buttons.Count; i = i + 1)
                {
                    if (min > (int)buttons[i].Tag)
                    {
                        min = (int)buttons[i].Tag;
                        minInd = i;
                    }
                }

                listResult.Add(buttons[minInd]);
                buttons.RemoveAt(minInd);
            }

            int[] tabindex = new int[] { listResult[0].TabIndex, listResult[1].TabIndex, listResult[2].TabIndex, listResult[3].TabIndex };
            object[] tag = new object[] { listResult[0].Tag, listResult[1].Tag, listResult[2].Tag, listResult[3].Tag, };

            foreach (Panel p in ButtonOrderTablePanel.Controls)
            {
                p.Controls.Clear();
            }

            FirstPanel.Controls.Add(listResult[0]);
            SecondPanel.Controls.Add(listResult[1]);
            ThirdPanel.Controls.Add(listResult[2]);
            FourthPanel.Controls.Add(listResult[3]);

            FirstPanel.AllowDrop = true;
            SecondPanel.AllowDrop = true;
            ThirdPanel.AllowDrop = true;
            FourthPanel.AllowDrop = true;

            FirstPanel.DragEnter += Panel_DragEnter;
            SecondPanel.DragEnter += Panel_DragEnter;
            ThirdPanel.DragEnter += Panel_DragEnter;
            FourthPanel.DragEnter += Panel_DragEnter;

            FirstPanel.DragDrop += Panel_DragDrop;
            SecondPanel.DragDrop += Panel_DragDrop;
            ThirdPanel.DragDrop += Panel_DragDrop;
            FourthPanel.DragDrop += Panel_DragDrop;

            FirstBtn.MouseDown += Buttons_MouseDown;
            SecondBtn.MouseDown += Buttons_MouseDown;
            ThirdBtn.MouseDown += Buttons_MouseDown;
            FourthBtn.MouseDown += Buttons_MouseDown;

            FirstBtn.Enter += Btn_Enter;
            SecondBtn.Enter += Btn_Enter;
            ThirdBtn.Enter += Btn_Enter;
            FourthBtn.Enter += Btn_Enter;

            #endregion button order
        }

        #region song setup category

        private Button btn = new Button();
        private Control parent = new Panel();

        private void Btn_Enter(object sender, EventArgs e)
        {
            parent = ((Button)sender).Parent;
        }

        private void Buttons_MouseDown(object sender, MouseEventArgs e) // https://stackoverflow.com/questions/11407068/how-to-drag-and-drop-a-button-from-one-panel-to-another-panel
        {
            ((Button)sender).DoDragDrop((Button)sender, DragDropEffects.Move);
            btn = (Button)sender;
        }

        private void Panel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void Panel_DragDrop(object sender, DragEventArgs e)
        {
            var child = ((Panel)sender).Controls.OfType<Button>();

            Button but = new Button();

            foreach (var item in child)
            {
                but = item;
            }

            ((Panel)sender).Controls.Clear();

            ((Button)e.Data.GetData(typeof(Button))).Tag = ((Panel)sender).Tag;
            ((Button)e.Data.GetData(typeof(Button))).Parent = (Panel)sender;

            but.Tag = parent.Tag;

            parent.Controls.Add(but);
            btn.BringToFront();
        }

        #endregion song setup category

        private List<Button> DetectbuttonOrder()
        {
            List<Button> butList = new List<Button>();
            foreach (Panel p in ButtonOrderTablePanel.Controls)
            {
                foreach (Button b in p.Controls)
                {
                    if (b.Size.Width == 79 && b.Size.Height == 71)
                    {
                        butList.Add(b);
                    }
                }
            }

            return butList;
        }

        #region when buttons are clicked

        #region folder searches

        private string songPath = string.Empty;
        private string currFolPath = string.Empty;
        private string currOsuPath = string.Empty;

        private void SongFolBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                SongFolTxb.Text = folderBrowserDialog1.SelectedPath;

                songPath = folderBrowserDialog1.SelectedPath;
            }
        }

        private void MapsetFolBtn_Click(object sender, EventArgs e)
        {
            if (SongFolTxb.Text != string.Empty)
            {
                folderBrowserDialog1.SelectedPath = SongFolTxb.Text;
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    currFolPath = folderBrowserDialog1.SelectedPath;

                    currFolPath = currFolPath.Replace(SongFolTxb.Text, string.Empty);

                    CurrFolTxb.Text = currFolPath;
                }
            }
            else
            {
                MessageBox.Show("Please select Song Folder path first!");
            }
        }

        private void CurrOsubtn_Click(object sender, EventArgs e)
        {
            if (CurrFolTxb.Text != string.Empty)
            {
                openFileDialog1.InitialDirectory = $@"{SongFolTxb.Text}{CurrFolTxb.Text}";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    CurrOsuTxb.Text = $@"\{openFileDialog1.SafeFileName}";
                    currOsuPath = $@"\{openFileDialog1.SafeFileName}";
                }
            }
            else
            {
                MessageBox.Show("Please select Mapset path first!");
            }
        }

        private void LiveScanFol_Click(object sender, EventArgs e)
        {
            IOsuMemoryReader pioReader = OsuMemoryReader.Instance;
            currFolPath = $@"\{pioReader.GetMapFolderName()}";

            if (currFolPath == @"\")
            {
                EditorReader editorReader = new EditorReader();
                editorReader.FetchHOM();
                editorReader.FetchBeatmap();
                currFolPath = $@"\{editorReader.ContainingFolder}";
            }

            CurrFolTxb.Text = currFolPath;
        }

        private void LiveScanOsu_Click(object sender, EventArgs e)
        {
            IOsuMemoryReader pioReader = OsuMemoryReader.Instance;
            currOsuPath = $@"\{pioReader.GetOsuFileName()}";
            if (currOsuPath == @"\")
            {
                EditorReader editorReader = new EditorReader();
                editorReader.FetchHOM();
                editorReader.FetchBeatmap();
                currOsuPath = $@"\{editorReader.Filename}";
            }

            CurrOsuTxb.Text = currOsuPath;
        }

        #endregion folder searches

        #region theme

        private void BorderColSlecBtn_Click(object sender, EventArgs e)
        {
            SelectCol(BorderCol);
        }

        private void BtnColSlecBtn_Click(object sender, EventArgs e)
        {
            SelectCol(BtnCol);
        }

        private void BGColSlecBtn_Click(object sender, EventArgs e)
        {
            SelectCol(BGCol);
        }

        private void SelectCol(Control control)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                control.BackColor = colorDialog1.Color;
            }
        }

        #endregion theme

        #endregion when buttons are clicked

        private void SaveChangeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string[] files = Directory.GetFiles($@"{SongFolTxb.Text}{CurrFolTxb.Text}");
                bool containsOsu = false;


                foreach (string file in files)
                {
                    if (file.Contains(".osu"))
                    {
                        containsOsu = true;
                    }
                }

                if (!containsOsu)
                {
                    throw new Exception("No .osu files were found, please input a viable directory.");
                }

                UIDataOverwriter ow = new UIDataOverwriter();

                // Folder setting
                ow.SetCurrFol(CurrFolTxb.Text);
                ow.SetSongFol(SongFolTxb.Text);
                ow.SetCurrOsu(CurrOsuTxb.Text);

                // Theme
                ow.SetTheme(new Color[]
                {
                Color.FromArgb(BorderCol.BackColor.R, BorderCol.BackColor.G, BorderCol.BackColor.B),
                Color.FromArgb(BtnCol.BackColor.R, BtnCol.BackColor.G, BtnCol.BackColor.B),
                Color.FromArgb(BGCol.BackColor.R, BGCol.BackColor.G, BGCol.BackColor.B)
                });

                // Button Order
                List<Button> buttons = DetectbuttonOrder();
                List<int> newOrder = new List<int>();
                foreach (var item in buttons)
                {
                    newOrder.Add(item.TabIndex);
                }

                ow.SetButOrd(newOrder.ToArray());

                ow.UpdateUIData();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            } 
        }
    }
}