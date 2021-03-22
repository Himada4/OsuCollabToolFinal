namespace OsuCollabTool.Main_Classes.SongSetupFunc
{
    partial class DifficultyIntf
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
            this.components = new System.ComponentModel.Container();
            this.BGPanel = new System.Windows.Forms.TableLayoutPanel();
            this.STRLabel = new System.Windows.Forms.GroupBox();
            this.STRTrackBar = new System.Windows.Forms.TrackBar();
            this.SMLabel = new System.Windows.Forms.GroupBox();
            this.ARLabel = new System.Windows.Forms.GroupBox();
            this.ARTrackBar = new System.Windows.Forms.TrackBar();
            this.ODLabel = new System.Windows.Forms.GroupBox();
            this.ODTrackBar = new System.Windows.Forms.TrackBar();
            this.CSLabel = new System.Windows.Forms.GroupBox();
            this.CSTrackBar = new System.Windows.Forms.TrackBar();
            this.HPLabel = new System.Windows.Forms.GroupBox();
            this.HPTrackBar = new System.Windows.Forms.TrackBar();
            this.trackNum = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SMTextBox = new System.Windows.Forms.TextBox();
            this.SMTrackBar = new System.Windows.Forms.TrackBar();
            this.BGPanel.SuspendLayout();
            this.STRLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.STRTrackBar)).BeginInit();
            this.SMLabel.SuspendLayout();
            this.ARLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ARTrackBar)).BeginInit();
            this.ODLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ODTrackBar)).BeginInit();
            this.CSLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CSTrackBar)).BeginInit();
            this.HPLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HPTrackBar)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SMTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // BGPanel
            // 
            this.BGPanel.ColumnCount = 6;
            this.BGPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.BGPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.BGPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.BGPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.BGPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.BGPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.BGPanel.Controls.Add(this.STRLabel, 5, 0);
            this.BGPanel.Controls.Add(this.SMLabel, 4, 0);
            this.BGPanel.Controls.Add(this.ARLabel, 3, 0);
            this.BGPanel.Controls.Add(this.ODLabel, 2, 0);
            this.BGPanel.Controls.Add(this.CSLabel, 1, 0);
            this.BGPanel.Controls.Add(this.HPLabel, 0, 0);
            this.BGPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BGPanel.Location = new System.Drawing.Point(0, 0);
            this.BGPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BGPanel.Name = "BGPanel";
            this.BGPanel.RowCount = 1;
            this.BGPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BGPanel.Size = new System.Drawing.Size(748, 324);
            this.BGPanel.TabIndex = 0;
            // 
            // STRLabel
            // 
            this.STRLabel.Controls.Add(this.STRTrackBar);
            this.STRLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.STRLabel.Location = new System.Drawing.Point(623, 0);
            this.STRLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.STRLabel.Name = "STRLabel";
            this.STRLabel.Size = new System.Drawing.Size(122, 321);
            this.STRLabel.TabIndex = 5;
            this.STRLabel.TabStop = false;
            this.STRLabel.Text = "Slider Tick Rate";
            // 
            // STRTrackBar
            // 
            this.STRTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.STRTrackBar.Location = new System.Drawing.Point(39, 19);
            this.STRTrackBar.Maximum = 80;
            this.STRTrackBar.Minimum = 1;
            this.STRTrackBar.Name = "STRTrackBar";
            this.STRTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.STRTrackBar.Size = new System.Drawing.Size(45, 296);
            this.STRTrackBar.TabIndex = 1;
            this.STRTrackBar.TickFrequency = 10;
            this.STRTrackBar.Value = 1;
            // 
            // SMLabel
            // 
            this.SMLabel.Controls.Add(this.SMTrackBar);
            this.SMLabel.Controls.Add(this.SMTextBox);
            this.SMLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SMLabel.Location = new System.Drawing.Point(499, 0);
            this.SMLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.SMLabel.Name = "SMLabel";
            this.SMLabel.Size = new System.Drawing.Size(118, 321);
            this.SMLabel.TabIndex = 4;
            this.SMLabel.TabStop = false;
            this.SMLabel.Text = "Slider Multiplier";
            // 
            // ARLabel
            // 
            this.ARLabel.Controls.Add(this.ARTrackBar);
            this.ARLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ARLabel.Location = new System.Drawing.Point(375, 0);
            this.ARLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ARLabel.Name = "ARLabel";
            this.ARLabel.Size = new System.Drawing.Size(118, 321);
            this.ARLabel.TabIndex = 3;
            this.ARLabel.TabStop = false;
            this.ARLabel.Text = "Approach Rate";
            // 
            // ARTrackBar
            // 
            this.ARTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ARTrackBar.Location = new System.Drawing.Point(37, 19);
            this.ARTrackBar.Maximum = 100;
            this.ARTrackBar.Minimum = 10;
            this.ARTrackBar.Name = "ARTrackBar";
            this.ARTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ARTrackBar.Size = new System.Drawing.Size(45, 296);
            this.ARTrackBar.TabIndex = 1;
            this.ARTrackBar.TickFrequency = 10;
            this.ARTrackBar.Value = 10;
            // 
            // ODLabel
            // 
            this.ODLabel.Controls.Add(this.ODTrackBar);
            this.ODLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ODLabel.Location = new System.Drawing.Point(251, 0);
            this.ODLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ODLabel.Name = "ODLabel";
            this.ODLabel.Size = new System.Drawing.Size(118, 321);
            this.ODLabel.TabIndex = 2;
            this.ODLabel.TabStop = false;
            this.ODLabel.Text = "Overall Difficulty";
            // 
            // ODTrackBar
            // 
            this.ODTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ODTrackBar.Location = new System.Drawing.Point(37, 19);
            this.ODTrackBar.Maximum = 100;
            this.ODTrackBar.Minimum = 10;
            this.ODTrackBar.Name = "ODTrackBar";
            this.ODTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ODTrackBar.Size = new System.Drawing.Size(45, 296);
            this.ODTrackBar.TabIndex = 1;
            this.ODTrackBar.TickFrequency = 10;
            this.ODTrackBar.Value = 10;
            // 
            // CSLabel
            // 
            this.CSLabel.Controls.Add(this.CSTrackBar);
            this.CSLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CSLabel.Location = new System.Drawing.Point(127, 0);
            this.CSLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.CSLabel.Name = "CSLabel";
            this.CSLabel.Size = new System.Drawing.Size(118, 321);
            this.CSLabel.TabIndex = 1;
            this.CSLabel.TabStop = false;
            this.CSLabel.Text = "Circle Size";
            // 
            // CSTrackBar
            // 
            this.CSTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CSTrackBar.Location = new System.Drawing.Point(37, 19);
            this.CSTrackBar.Maximum = 100;
            this.CSTrackBar.Minimum = 10;
            this.CSTrackBar.Name = "CSTrackBar";
            this.CSTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.CSTrackBar.Size = new System.Drawing.Size(45, 296);
            this.CSTrackBar.TabIndex = 1;
            this.CSTrackBar.TickFrequency = 10;
            this.CSTrackBar.Value = 10;
            // 
            // HPLabel
            // 
            this.HPLabel.Controls.Add(this.HPTrackBar);
            this.HPLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HPLabel.Location = new System.Drawing.Point(3, 0);
            this.HPLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.HPLabel.Name = "HPLabel";
            this.HPLabel.Size = new System.Drawing.Size(118, 321);
            this.HPLabel.TabIndex = 0;
            this.HPLabel.TabStop = false;
            this.HPLabel.Text = "HP Drain Rate";
            // 
            // HPTrackBar
            // 
            this.HPTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HPTrackBar.Location = new System.Drawing.Point(33, 19);
            this.HPTrackBar.Maximum = 100;
            this.HPTrackBar.Minimum = 10;
            this.HPTrackBar.Name = "HPTrackBar";
            this.HPTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.HPTrackBar.Size = new System.Drawing.Size(45, 296);
            this.HPTrackBar.TabIndex = 0;
            this.HPTrackBar.TickFrequency = 10;
            this.HPTrackBar.Value = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BGPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SaveBtn, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.4F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.6F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(748, 375);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Location = new System.Drawing.Point(0, 324);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(748, 51);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.Text = "Save Changes";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // SMTextBox
            // 
            this.SMTextBox.Location = new System.Drawing.Point(6, 19);
            this.SMTextBox.Multiline = true;
            this.SMTextBox.Name = "SMTextBox";
            this.SMTextBox.Size = new System.Drawing.Size(106, 31);
            this.SMTextBox.TabIndex = 0;
            // 
            // SMTrackBar
            // 
            this.SMTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SMTrackBar.Location = new System.Drawing.Point(37, 56);
            this.SMTrackBar.Maximum = 80;
            this.SMTrackBar.Minimum = 1;
            this.SMTrackBar.Name = "SMTrackBar";
            this.SMTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.SMTrackBar.Size = new System.Drawing.Size(45, 259);
            this.SMTrackBar.TabIndex = 2;
            this.SMTrackBar.TickFrequency = 10;
            this.SMTrackBar.Value = 1;
            // 
            // DifficultyIntf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 375);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DifficultyIntf";
            this.Text = "DifficultyIntf";
            this.BGPanel.ResumeLayout(false);
            this.STRLabel.ResumeLayout(false);
            this.STRLabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.STRTrackBar)).EndInit();
            this.SMLabel.ResumeLayout(false);
            this.SMLabel.PerformLayout();
            this.ARLabel.ResumeLayout(false);
            this.ARLabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ARTrackBar)).EndInit();
            this.ODLabel.ResumeLayout(false);
            this.ODLabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ODTrackBar)).EndInit();
            this.CSLabel.ResumeLayout(false);
            this.CSLabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CSTrackBar)).EndInit();
            this.HPLabel.ResumeLayout(false);
            this.HPLabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HPTrackBar)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SMTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BGPanel;
        private System.Windows.Forms.GroupBox STRLabel;
        private System.Windows.Forms.GroupBox SMLabel;
        private System.Windows.Forms.GroupBox ARLabel;
        private System.Windows.Forms.GroupBox ODLabel;
        private System.Windows.Forms.GroupBox CSLabel;
        private System.Windows.Forms.GroupBox HPLabel;
        private System.Windows.Forms.TrackBar HPTrackBar;
        private System.Windows.Forms.ToolTip trackNum;
        private System.Windows.Forms.TrackBar STRTrackBar;
        private System.Windows.Forms.TrackBar ARTrackBar;
        private System.Windows.Forms.TrackBar ODTrackBar;
        private System.Windows.Forms.TrackBar CSTrackBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox SMTextBox;
        private System.Windows.Forms.TrackBar SMTrackBar;
    }
}