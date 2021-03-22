namespace OsuCollabTool.Main_Classes.SongSetupFunc
{
    partial class MetaDataIntf
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainBG = new System.Windows.Forms.TableLayoutPanel();
            this.TagsGroupBox = new System.Windows.Forms.GroupBox();
            this.TagsTextBox = new System.Windows.Forms.TextBox();
            this.SourceGroupBox = new System.Windows.Forms.GroupBox();
            this.SourceTextBox = new System.Windows.Forms.TextBox();
            this.VersionName = new System.Windows.Forms.GroupBox();
            this.DiffNameTextBox = new System.Windows.Forms.TextBox();
            this.CreatorGroupBox = new System.Windows.Forms.GroupBox();
            this.MapperNameTextBox = new System.Windows.Forms.TextBox();
            this.ArtistGroupBox = new System.Windows.Forms.GroupBox();
            this.UATextBox = new System.Windows.Forms.TextBox();
            this.UALabel = new System.Windows.Forms.Label();
            this.RATextBox = new System.Windows.Forms.TextBox();
            this.RALabel = new System.Windows.Forms.Label();
            this.TitleGroupBox = new System.Windows.Forms.GroupBox();
            this.UTTextBox = new System.Windows.Forms.TextBox();
            this.UTLabel = new System.Windows.Forms.Label();
            this.RTTextBox = new System.Windows.Forms.TextBox();
            this.RTlabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SecMainBG = new System.Windows.Forms.TableLayoutPanel();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ApplyChangesMapset = new System.Windows.Forms.CheckBox();
            this.MainBG.SuspendLayout();
            this.TagsGroupBox.SuspendLayout();
            this.SourceGroupBox.SuspendLayout();
            this.VersionName.SuspendLayout();
            this.CreatorGroupBox.SuspendLayout();
            this.ArtistGroupBox.SuspendLayout();
            this.TitleGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SecMainBG.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainBG
            // 
            this.MainBG.ColumnCount = 2;
            this.MainBG.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainBG.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainBG.Controls.Add(this.TagsGroupBox, 1, 2);
            this.MainBG.Controls.Add(this.SourceGroupBox, 0, 2);
            this.MainBG.Controls.Add(this.VersionName, 1, 1);
            this.MainBG.Controls.Add(this.CreatorGroupBox, 0, 1);
            this.MainBG.Controls.Add(this.ArtistGroupBox, 1, 0);
            this.MainBG.Controls.Add(this.TitleGroupBox, 0, 0);
            this.MainBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainBG.Location = new System.Drawing.Point(0, 0);
            this.MainBG.Margin = new System.Windows.Forms.Padding(0);
            this.MainBG.Name = "MainBG";
            this.MainBG.RowCount = 3;
            this.MainBG.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.MainBG.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.MainBG.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.MainBG.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainBG.Size = new System.Drawing.Size(748, 298);
            this.MainBG.TabIndex = 0;
            // 
            // TagsGroupBox
            // 
            this.TagsGroupBox.Controls.Add(this.TagsTextBox);
            this.TagsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TagsGroupBox.Location = new System.Drawing.Point(377, 201);
            this.TagsGroupBox.Name = "TagsGroupBox";
            this.TagsGroupBox.Size = new System.Drawing.Size(368, 94);
            this.TagsGroupBox.TabIndex = 5;
            this.TagsGroupBox.TabStop = false;
            this.TagsGroupBox.Text = "Tags *";
            // 
            // TagsTextBox
            // 
            this.TagsTextBox.Location = new System.Drawing.Point(9, 19);
            this.TagsTextBox.Multiline = true;
            this.TagsTextBox.Name = "TagsTextBox";
            this.TagsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TagsTextBox.Size = new System.Drawing.Size(350, 69);
            this.TagsTextBox.TabIndex = 2;
            // 
            // SourceGroupBox
            // 
            this.SourceGroupBox.Controls.Add(this.SourceTextBox);
            this.SourceGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SourceGroupBox.Location = new System.Drawing.Point(3, 201);
            this.SourceGroupBox.Name = "SourceGroupBox";
            this.SourceGroupBox.Size = new System.Drawing.Size(368, 94);
            this.SourceGroupBox.TabIndex = 4;
            this.SourceGroupBox.TabStop = false;
            this.SourceGroupBox.Text = "Source *";
            // 
            // SourceTextBox
            // 
            this.SourceTextBox.Location = new System.Drawing.Point(48, 37);
            this.SourceTextBox.Name = "SourceTextBox";
            this.SourceTextBox.Size = new System.Drawing.Size(250, 20);
            this.SourceTextBox.TabIndex = 2;
            // 
            // VersionName
            // 
            this.VersionName.Controls.Add(this.DiffNameTextBox);
            this.VersionName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VersionName.Location = new System.Drawing.Point(377, 102);
            this.VersionName.Name = "VersionName";
            this.VersionName.Size = new System.Drawing.Size(368, 93);
            this.VersionName.TabIndex = 3;
            this.VersionName.TabStop = false;
            this.VersionName.Text = "Difficulty Name";
            // 
            // DiffNameTextBox
            // 
            this.DiffNameTextBox.Location = new System.Drawing.Point(59, 40);
            this.DiffNameTextBox.Name = "DiffNameTextBox";
            this.DiffNameTextBox.Size = new System.Drawing.Size(250, 20);
            this.DiffNameTextBox.TabIndex = 3;
            // 
            // CreatorGroupBox
            // 
            this.CreatorGroupBox.Controls.Add(this.MapperNameTextBox);
            this.CreatorGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreatorGroupBox.Location = new System.Drawing.Point(3, 102);
            this.CreatorGroupBox.Name = "CreatorGroupBox";
            this.CreatorGroupBox.Size = new System.Drawing.Size(368, 93);
            this.CreatorGroupBox.TabIndex = 2;
            this.CreatorGroupBox.TabStop = false;
            this.CreatorGroupBox.Text = "Beatmap Creator *";
            // 
            // MapperNameTextBox
            // 
            this.MapperNameTextBox.Location = new System.Drawing.Point(48, 40);
            this.MapperNameTextBox.Name = "MapperNameTextBox";
            this.MapperNameTextBox.Size = new System.Drawing.Size(250, 20);
            this.MapperNameTextBox.TabIndex = 2;
            // 
            // ArtistGroupBox
            // 
            this.ArtistGroupBox.Controls.Add(this.UATextBox);
            this.ArtistGroupBox.Controls.Add(this.UALabel);
            this.ArtistGroupBox.Controls.Add(this.RATextBox);
            this.ArtistGroupBox.Controls.Add(this.RALabel);
            this.ArtistGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArtistGroupBox.Location = new System.Drawing.Point(377, 3);
            this.ArtistGroupBox.Name = "ArtistGroupBox";
            this.ArtistGroupBox.Size = new System.Drawing.Size(368, 93);
            this.ArtistGroupBox.TabIndex = 1;
            this.ArtistGroupBox.TabStop = false;
            this.ArtistGroupBox.Text = "Artist *";
            // 
            // UATextBox
            // 
            this.UATextBox.Location = new System.Drawing.Point(134, 59);
            this.UATextBox.Name = "UATextBox";
            this.UATextBox.Size = new System.Drawing.Size(225, 20);
            this.UATextBox.TabIndex = 4;
            // 
            // UALabel
            // 
            this.UALabel.AutoSize = true;
            this.UALabel.Location = new System.Drawing.Point(6, 62);
            this.UALabel.Name = "UALabel";
            this.UALabel.Size = new System.Drawing.Size(127, 13);
            this.UALabel.TabIndex = 3;
            this.UALabel.Text = "Untranslated Artist Name:";
            // 
            // RATextBox
            // 
            this.RATextBox.Location = new System.Drawing.Point(134, 17);
            this.RATextBox.Name = "RATextBox";
            this.RATextBox.Size = new System.Drawing.Size(225, 20);
            this.RATextBox.TabIndex = 2;
            // 
            // RALabel
            // 
            this.RALabel.AutoSize = true;
            this.RALabel.Location = new System.Drawing.Point(6, 20);
            this.RALabel.Name = "RALabel";
            this.RALabel.Size = new System.Drawing.Size(120, 13);
            this.RALabel.TabIndex = 1;
            this.RALabel.Text = "Romanized Artist Name:";
            // 
            // TitleGroupBox
            // 
            this.TitleGroupBox.Controls.Add(this.UTTextBox);
            this.TitleGroupBox.Controls.Add(this.UTLabel);
            this.TitleGroupBox.Controls.Add(this.RTTextBox);
            this.TitleGroupBox.Controls.Add(this.RTlabel);
            this.TitleGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleGroupBox.Location = new System.Drawing.Point(3, 3);
            this.TitleGroupBox.Name = "TitleGroupBox";
            this.TitleGroupBox.Size = new System.Drawing.Size(368, 93);
            this.TitleGroupBox.TabIndex = 0;
            this.TitleGroupBox.TabStop = false;
            this.TitleGroupBox.Text = "Title *";
            // 
            // UTTextBox
            // 
            this.UTTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.UTTextBox.Location = new System.Drawing.Point(101, 59);
            this.UTTextBox.Name = "UTTextBox";
            this.UTTextBox.Size = new System.Drawing.Size(250, 20);
            this.UTTextBox.TabIndex = 3;
            // 
            // UTLabel
            // 
            this.UTLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.UTLabel.AutoSize = true;
            this.UTLabel.Location = new System.Drawing.Point(9, 62);
            this.UTLabel.Name = "UTLabel";
            this.UTLabel.Size = new System.Drawing.Size(93, 13);
            this.UTLabel.TabIndex = 2;
            this.UTLabel.Text = "Untranslated Title:";
            // 
            // RTTextBox
            // 
            this.RTTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RTTextBox.Location = new System.Drawing.Point(101, 17);
            this.RTTextBox.Name = "RTTextBox";
            this.RTTextBox.Size = new System.Drawing.Size(250, 20);
            this.RTTextBox.TabIndex = 1;
            // 
            // RTlabel
            // 
            this.RTlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RTlabel.AutoSize = true;
            this.RTlabel.Location = new System.Drawing.Point(9, 20);
            this.RTlabel.Name = "RTlabel";
            this.RTlabel.Size = new System.Drawing.Size(86, 13);
            this.RTlabel.TabIndex = 0;
            this.RTlabel.Text = "Romanized Title:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.MainBG, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SecMainBG, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.46667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.53333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(748, 375);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // SecMainBG
            // 
            this.SecMainBG.ColumnCount = 2;
            this.SecMainBG.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SecMainBG.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 432F));
            this.SecMainBG.Controls.Add(this.SaveBtn, 1, 0);
            this.SecMainBG.Controls.Add(this.ApplyChangesMapset, 0, 0);
            this.SecMainBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecMainBG.Location = new System.Drawing.Point(0, 298);
            this.SecMainBG.Margin = new System.Windows.Forms.Padding(0);
            this.SecMainBG.Name = "SecMainBG";
            this.SecMainBG.RowCount = 1;
            this.SecMainBG.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SecMainBG.Size = new System.Drawing.Size(748, 77);
            this.SecMainBG.TabIndex = 2;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Location = new System.Drawing.Point(316, 0);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(432, 77);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.Text = "Save Changes";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ApplyChangesMapset
            // 
            this.ApplyChangesMapset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyChangesMapset.AutoSize = true;
            this.ApplyChangesMapset.Location = new System.Drawing.Point(3, 30);
            this.ApplyChangesMapset.Name = "ApplyChangesMapset";
            this.ApplyChangesMapset.Size = new System.Drawing.Size(310, 17);
            this.ApplyChangesMapset.TabIndex = 2;
            this.ApplyChangesMapset.Text = "Apply changes to entire mapset(Except Difficulty Name)";
            this.ApplyChangesMapset.UseVisualStyleBackColor = true;
            // 
            // MetaDataIntf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 375);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MetaDataIntf";
            this.Text = "MetaDataIntf";
            this.MainBG.ResumeLayout(false);
            this.TagsGroupBox.ResumeLayout(false);
            this.TagsGroupBox.PerformLayout();
            this.SourceGroupBox.ResumeLayout(false);
            this.SourceGroupBox.PerformLayout();
            this.VersionName.ResumeLayout(false);
            this.VersionName.PerformLayout();
            this.CreatorGroupBox.ResumeLayout(false);
            this.CreatorGroupBox.PerformLayout();
            this.ArtistGroupBox.ResumeLayout(false);
            this.ArtistGroupBox.PerformLayout();
            this.TitleGroupBox.ResumeLayout(false);
            this.TitleGroupBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.SecMainBG.ResumeLayout(false);
            this.SecMainBG.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainBG;
        private System.Windows.Forms.GroupBox TagsGroupBox;
        private System.Windows.Forms.GroupBox SourceGroupBox;
        private System.Windows.Forms.GroupBox VersionName;
        private System.Windows.Forms.GroupBox CreatorGroupBox;
        private System.Windows.Forms.GroupBox ArtistGroupBox;
        private System.Windows.Forms.GroupBox TitleGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox TagsTextBox;
        private System.Windows.Forms.TextBox SourceTextBox;
        private System.Windows.Forms.TextBox DiffNameTextBox;
        private System.Windows.Forms.TextBox MapperNameTextBox;
        private System.Windows.Forms.TextBox UATextBox;
        private System.Windows.Forms.Label UALabel;
        private System.Windows.Forms.TextBox RATextBox;
        private System.Windows.Forms.Label RALabel;
        private System.Windows.Forms.TextBox UTTextBox;
        private System.Windows.Forms.Label UTLabel;
        private System.Windows.Forms.TextBox RTTextBox;
        private System.Windows.Forms.Label RTlabel;
        private System.Windows.Forms.TableLayoutPanel SecMainBG;
        private System.Windows.Forms.CheckBox ApplyChangesMapset;
    }
}