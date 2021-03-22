using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OsuCollabTool.UI;
using OsuCollabTool.CoreClasses;
using System.IO;

namespace OsuCollabTool.Main_Classes.SongSetupFunc
{
    public partial class MetaDataIntf : Form
    {
        private UIDataExtractor ext = new UIDataExtractor();
        private string Dir = "";
        

        
           
        private string BeatmapID = "";
        private string BeatmapSetID = "";
        
        string[,] metaData;


        public MetaDataIntf()
        {
            InitializeComponent();

            ext = new UIDataExtractor();
            Color[] Theme = ext.getTheme();
            
            Dir = $@"{ext.getSongFol()}{ext.getCurrFol()}{ext.getCurrOsu()}";

            //Interface Theme Set
            Common.setBGCol(Theme[2], SecMainBG, MainBG);
            Common.setBtnCol(Theme[1], SaveBtn);
            Common.ContrastColor(Theme[1], SaveBtn);
            Common.ContrastColor(Theme[2],  TitleGroupBox,ArtistGroupBox,CreatorGroupBox,VersionName,SourceGroupBox,TagsGroupBox,RTlabel,UTLabel,RALabel,UALabel, ApplyChangesMapset);


            // fill in field

            MapDataExtractor data = new MapDataExtractor(Dir);

            metaData = data.GetMetadata();

            for (int i = 0; i <= metaData.GetUpperBound(1); i = i + 1)
            {
                switch (i)
                {
                    case 0:
                         RTTextBox.Text = metaData[1,i];
                        
                        break;
                    case 1:
                        UTTextBox.Text = metaData[1, i];

                        break;
                    case 2:
                        RATextBox.Text = metaData[1, i];

                        break;
                    case 3:
                        UATextBox.Text = metaData[1, i];

                        break;
                    case 4:
                        MapperNameTextBox.Text = metaData[1, i];

                        break;
                    case 5:
                        DiffNameTextBox.Text = metaData[1, i];

                        break;
                    case 6:
                        SourceTextBox.Text = metaData[1, i];
                        break;

                    case 7:
                        TagsTextBox.Text = metaData[1, i];
                        break;
                    case 8:
                        BeatmapID = metaData[1, i];
                        break;
                    case 9:
                        BeatmapSetID = metaData[1, i];
                        break;
                }
            }

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            List<string> newInput = new List<string>();



            newInput.Add("[Metadata]");

            for (int i = 0; i <= metaData.GetUpperBound(1); i = i + 1)
            {
                switch (i)
                {
                    case 0:
                        newInput.Add($"{metaData[0,i]}:{RTTextBox.Text}");

                        break;
                    case 1: 
                        newInput.Add($"{metaData[0, i]}:{UTTextBox.Text}");
                        break;
                    case 2:
                        
                        newInput.Add($"{metaData[0, i]}:{RATextBox.Text}");
                        break;
                    case 3:
                        
                        newInput.Add($"{metaData[0, i]}:{UATextBox.Text}");
                        break;
                    case 4:
                        
                        newInput.Add($"{metaData[0, i]}:{MapperNameTextBox.Text}");
                        break;
                    case 5:
                        
                        newInput.Add($"{metaData[0, i]}:{DiffNameTextBox.Text}");
                        break;
                    case 6:
                        
                        newInput.Add($"{metaData[0, i]}:{SourceTextBox.Text}");
                        break;

                    case 7:
                        
                        newInput.Add($"{metaData[0, i]}:{TagsTextBox.Text}");
                        break;
                    case 8:
                        
                        newInput.Add($"{metaData[0, i]}:{BeatmapID}");
                        break;
                    case 9:
                        
                        newInput.Add($"{metaData[0, i]}:{BeatmapSetID}");
                        break;
                }
            }

            newInput.Add("");

            if(ApplyChangesMapset.Checked == true)
            {
                string[] files = Directory.GetFiles($@"{ext.getSongFol()}{ext.getCurrFol()}");

                List<string> mapset = new List<string>();

                foreach (string file in files)
                {
                    if (file.Contains(".osu"))
                    {
                        mapset.Add($@"{ext.getSongFol()}{ext.getCurrFol()}\{Path.GetFileName(file)}");
                    }
                }

                

                foreach(var map in mapset)
                {
                    MapDataExtractor data = new MapDataExtractor(map);
                    string[,] tempData = data.GetMetadata();

                    string SeperateVersionName = ($"{tempData[0, 5]}:{tempData[1, 5]}");
                    string MapID = ($"{tempData[0,8]}:{tempData[1,8]}");

                    newInput[6] = SeperateVersionName;
                    newInput[9] = MapID;

                    Common.ReplaceFileWithNewData(map, 3, newInput);
                } 
            }
            else
            {
                Common.ReplaceFileWithNewData(Dir, 3, newInput);
            }

            

        }
    }
}
