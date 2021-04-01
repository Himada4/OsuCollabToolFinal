using OsuCollabTool.CoreClasses;
using OsuCollabTool.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace OsuCollabTool.Main_Classes.SongSetupFunc
{
    public partial class MetaDataIntf : Form
    {
        private UIDataExtractor ext = new UIDataExtractor();
        private string dir = string.Empty;

        private string beatmapID = string.Empty;
        private string beatmapSetID = string.Empty;

        private string[,] metaData;

        public MetaDataIntf()
        {
            InitializeComponent();
            try
            {
                ext = new UIDataExtractor();
                Color[] theme = ext.GetTheme();

                dir = $@"{ext.GetSongFol()}{ext.GetCurrFol()}{ext.GetCurrOsu()}";

                // Interface Theme Set
                Common.SetBGCol(theme[2], SecMainBG, MainBG);
                Common.SetBtnCol(theme[1], SaveBtn);
                Common.ContrastColor(theme[1], SaveBtn);
                Common.ContrastColor(theme[2], TitleGroupBox, ArtistGroupBox, CreatorGroupBox, VersionName, SourceGroupBox, TagsGroupBox, RTlabel, UTLabel, RALabel, UALabel, ApplyChangesMapset);

                // Fill in field
                MapDataExtractor data = new MapDataExtractor(dir);

                metaData = data.GetMetadata();

                for (int i = 0; i <= metaData.GetUpperBound(1); i = i + 1)
                {
                    switch (i)
                    {
                        case 0:
                            RTTextBox.Text = metaData[1, i];

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
                            beatmapID = metaData[1, i];
                            break;

                        case 9:
                            beatmapSetID = metaData[1, i];
                            break;
                    }
                }
            }
            catch
            {
                this.Close();
            }
        }

        // Saves the metadata, overwrites it on to the .osu file
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> newInput = new List<string>();

                newInput.Add("[Metadata]");

                for (int i = 0; i <= metaData.GetUpperBound(1); i = i + 1)
                {
                    switch (i)
                    {
                        case 0:
                            newInput.Add($"{metaData[0, i]}:{RTTextBox.Text}");

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

                            newInput.Add($"{metaData[0, i]}:{beatmapID}");
                            break;

                        case 9:

                            newInput.Add($"{metaData[0, i]}:{beatmapSetID}");
                            break;
                    }
                }

                newInput.Add(string.Empty);

                if (ApplyChangesMapset.Checked == true)
                {
                    string[] files = Directory.GetFiles($@"{ext.GetSongFol()}{ext.GetCurrFol()}");

                    List<string> mapset = new List<string>();

                    foreach (string file in files)
                    {
                        if (file.Contains(".osu"))
                        {
                            mapset.Add($@"{ext.GetSongFol()}{ext.GetCurrFol()}\{Path.GetFileName(file)}");
                        }
                    }

                    foreach (var map in mapset)
                    {
                        MapDataExtractor data = new MapDataExtractor(map);
                        string[,] tempData = data.GetMetadata();

                        string SeperateVersionName = ($"{tempData[0, 5]}:{tempData[1, 5]}");
                        string MapID = ($"{tempData[0, 8]}:{tempData[1, 8]}");

                        newInput[6] = SeperateVersionName;
                        newInput[9] = MapID;

                        Common.ReplaceFileWithNewData(map, 3, newInput);
                    }
                }
                else
                {
                    Common.ReplaceFileWithNewData(dir, 3, newInput);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}