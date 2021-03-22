using OsuMemoryDataProvider;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Editor_Reader;

namespace OsuCollabTool.UI
{
    public partial class Preferences : Form
    {
        public Preferences()
        {
            InitializeComponent();
        }

        private string SongFolder;
        private Color[] Theme;
        private int[] ButtonOrder;
        private string CurrentFolder;
        private string CurrentOsu;
        

        private void Preferences_Load(object sender, EventArgs e)
        {
            UIDataExtractor ext = new UIDataExtractor();

            ext.refresh();

            SongFolder = ext.getSongFol();
            Theme = ext.getTheme();
            ButtonOrder = ext.getButOrd();
            CurrentFolder = ext.getCurrFol();
            CurrentOsu = ext.getCurrOsu();
            

            #region field setup

            SongFolTxb.Text = SongFolder;
            CurrFolTxb.Text = CurrentFolder;
            CurrOsuTxb.Text = CurrentOsu;

            BorderCol.BackColor = Theme[0];
            BtnCol.BackColor = Theme[1];
            BGCol.BackColor = Theme[2];

            #region button order

            List<Button> CurrBtnOrder = DetectButtonOrder();
            List<Button> buttons = new List<Button>();

            foreach (var b in CurrBtnOrder)
            {
                for (int i = 0; i < ButtonOrder.Length; i = i + 1)
                {
                    if (ButtonOrder[i] == b.TabIndex)
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

            #endregion button order

            

            #endregion field setup

            #region event

            FirstPanel.AllowDrop = true;
            SecondPanel.AllowDrop = true;
            ThirdPanel.AllowDrop = true;
            FourthPanel.AllowDrop = true;

            FirstPanel.DragEnter += panel_DragEnter;
            SecondPanel.DragEnter += panel_DragEnter;
            ThirdPanel.DragEnter += panel_DragEnter;
            FourthPanel.DragEnter += panel_DragEnter;

            FirstPanel.DragDrop += panel_DragDrop;
            SecondPanel.DragDrop += panel_DragDrop;
            ThirdPanel.DragDrop += panel_DragDrop;
            FourthPanel.DragDrop += panel_DragDrop;

            FirstBtn.MouseDown += Buttons_MouseDown;
            SecondBtn.MouseDown += Buttons_MouseDown;
            ThirdBtn.MouseDown += Buttons_MouseDown;
            FourthBtn.MouseDown += Buttons_MouseDown;

            FirstBtn.Enter += Btn_Enter;
            SecondBtn.Enter += Btn_Enter;
            ThirdBtn.Enter += Btn_Enter;
            FourthBtn.Enter += Btn_Enter;

            #endregion event
        }

        #region song setup category

        private Button btn = new Button();
        private Control parent = new Panel();

        private void Btn_Enter(object sender, EventArgs e)
        {
            parent = ((Button)sender).Parent;
        }

        private void Buttons_MouseDown(object sender, MouseEventArgs e) //https://stackoverflow.com/questions/11407068/how-to-drag-and-drop-a-button-from-one-panel-to-another-panel
        {
            ((Button)sender).DoDragDrop(((Button)sender), DragDropEffects.Move);
            btn = ((Button)sender);
        }

        private void panel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void panel_DragDrop(object sender, DragEventArgs e)
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

        private List<Button> DetectButtonOrder()
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

        private string songPath = "";
        private string currFolPath = "";
        private string currOsuPath = "";

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
            if (SongFolTxb.Text != "")
            {
                folderBrowserDialog1.SelectedPath = SongFolTxb.Text;
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    currFolPath = folderBrowserDialog1.SelectedPath;

                    currFolPath = currFolPath.Replace(SongFolTxb.Text, "");

                    CurrFolTxb.Text = currFolPath;
                }
            }
            else { MessageBox.Show("Please select Song Folder path first!"); }
        }

        private void CurrOsubtn_Click(object sender, EventArgs e)
        {
            if (CurrFolTxb.Text != "")
            {
                openFileDialog1.InitialDirectory = $@"{SongFolTxb.Text}{CurrFolTxb.Text}";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    CurrOsuTxb.Text = $@"\{openFileDialog1.SafeFileName}";
                    currOsuPath = $@"\{openFileDialog1.SafeFileName}";
                }
            }
            else { MessageBox.Show("Please select Mapset path first!"); }
        }

        private void LiveScanFol_Click(object sender, EventArgs e)
        {
            IOsuMemoryReader PioReader = OsuMemoryReader.Instance;
            currFolPath = $@"\{PioReader.GetMapFolderName()}";

            if(currFolPath == @"\")
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
            IOsuMemoryReader PioReader = OsuMemoryReader.Instance;
            currOsuPath = $@"\{PioReader.GetOsuFileName()}";
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
            selectCol(BorderCol);
        }

        private void BtnColSlecBtn_Click(object sender, EventArgs e)
        {
            selectCol(BtnCol);
        }

        private void BGColSlecBtn_Click(object sender, EventArgs e)
        {
            selectCol(BGCol);
        }

        private void selectCol(Control control)
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
            UIDataOverwriter ow = new UIDataOverwriter();

            //Folder setting
            ow.setCurrFol(CurrFolTxb.Text);
            ow.setSongFol(SongFolTxb.Text);
            ow.setCurrOsu(CurrOsuTxb.Text);

            //Theme
            ow.setTheme(new Color[] {
                Color.FromArgb(BorderCol.BackColor.R,BorderCol.BackColor.G,BorderCol.BackColor.B),
                Color.FromArgb(BtnCol.BackColor.R,BtnCol.BackColor.G,BtnCol.BackColor.B),
                Color.FromArgb(BGCol.BackColor.R,BGCol.BackColor.G,BGCol.BackColor.B)});

            //Button Order
            List<Button> buttons = DetectButtonOrder();
            List<int> newOrder = new List<int>();
            foreach (var item in buttons)
            {
                newOrder.Add(item.TabIndex);
            }
            ow.setButOrd(newOrder.ToArray());

            
            
            ow.UpdateUIData();

            
            
        }

        

        
    }
}