namespace OsuCollabTool.Main_Classes.HitsoundingFunc
{
    partial class VolumeToolIntf
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
            this.BG1 = new System.Windows.Forms.TableLayoutPanel();
            this.ChangeVol = new System.Windows.Forms.Button();
            this.BG2 = new System.Windows.Forms.TableLayoutPanel();
            this.Selector = new System.Windows.Forms.GroupBox();
            this.Option3 = new System.Windows.Forms.RadioButton();
            this.Option2 = new System.Windows.Forms.RadioButton();
            this.Option1 = new System.Windows.Forms.RadioButton();
            this.ChangesBox = new System.Windows.Forms.GroupBox();
            this.ChangeValLabel = new System.Windows.Forms.Label();
            this.TrackBarChanges = new System.Windows.Forms.TrackBar();
            this.ChangeVal = new System.Windows.Forms.RadioButton();
            this.SetVal = new System.Windows.Forms.RadioButton();
            this.SelectVolBox = new System.Windows.Forms.GroupBox();
            this.l1 = new System.Windows.Forms.Label();
            this.SelectVol = new System.Windows.Forms.NumericUpDown();
            this.SelectTimestampBox = new System.Windows.Forms.GroupBox();
            this.l5 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.MaxDurUntil = new System.Windows.Forms.Label();
            this.MaxDurStart = new System.Windows.Forms.Label();
            this.l8 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.GroupBox();
            this.l7 = new System.Windows.Forms.Label();
            this.l6 = new System.Windows.Forms.Label();
            this.UntilTb = new System.Windows.Forms.TextBox();
            this.SelectFromTb = new System.Windows.Forms.TextBox();
            this.UntilTrackBar = new System.Windows.Forms.TrackBar();
            this.StartTrackBar = new System.Windows.Forms.TrackBar();
            this.trackNum = new System.Windows.Forms.ToolTip(this.components);
            this.BG1.SuspendLayout();
            this.BG2.SuspendLayout();
            this.Selector.SuspendLayout();
            this.ChangesBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarChanges)).BeginInit();
            this.SelectVolBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectVol)).BeginInit();
            this.SelectTimestampBox.SuspendLayout();
            this.l2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UntilTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // BG1
            // 
            this.BG1.ColumnCount = 1;
            this.BG1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BG1.Controls.Add(this.ChangeVol, 0, 2);
            this.BG1.Controls.Add(this.BG2, 0, 0);
            this.BG1.Controls.Add(this.SelectTimestampBox, 0, 1);
            this.BG1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BG1.Location = new System.Drawing.Point(0, 0);
            this.BG1.Margin = new System.Windows.Forms.Padding(0);
            this.BG1.Name = "BG1";
            this.BG1.RowCount = 3;
            this.BG1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BG1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.74713F));
            this.BG1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.14943F));
            this.BG1.Size = new System.Drawing.Size(748, 474);
            this.BG1.TabIndex = 0;
            // 
            // ChangeVol
            // 
            this.ChangeVol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangeVol.FlatAppearance.BorderSize = 0;
            this.ChangeVol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeVol.Location = new System.Drawing.Point(3, 376);
            this.ChangeVol.Name = "ChangeVol";
            this.ChangeVol.Size = new System.Drawing.Size(742, 95);
            this.ChangeVol.TabIndex = 3;
            this.ChangeVol.Text = "Make Changes!";
            this.ChangeVol.UseVisualStyleBackColor = true;
            this.ChangeVol.Click += new System.EventHandler(this.ChangeVol_Click);
            // 
            // BG2
            // 
            this.BG2.ColumnCount = 3;
            this.BG2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.0929F));
            this.BG2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.94535F));
            this.BG2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.09836F));
            this.BG2.Controls.Add(this.Selector, 0, 0);
            this.BG2.Controls.Add(this.ChangesBox, 1, 0);
            this.BG2.Controls.Add(this.SelectVolBox, 2, 0);
            this.BG2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BG2.Location = new System.Drawing.Point(0, 0);
            this.BG2.Margin = new System.Windows.Forms.Padding(0);
            this.BG2.Name = "BG2";
            this.BG2.RowCount = 1;
            this.BG2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BG2.Size = new System.Drawing.Size(748, 157);
            this.BG2.TabIndex = 0;
            // 
            // Selector
            // 
            this.Selector.Controls.Add(this.Option3);
            this.Selector.Controls.Add(this.Option2);
            this.Selector.Controls.Add(this.Option1);
            this.Selector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Selector.Location = new System.Drawing.Point(3, 3);
            this.Selector.Name = "Selector";
            this.Selector.Size = new System.Drawing.Size(188, 151);
            this.Selector.TabIndex = 0;
            this.Selector.TabStop = false;
            this.Selector.Text = "Select Based On...";
            // 
            // Option3
            // 
            this.Option3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Option3.AutoSize = true;
            this.Option3.Location = new System.Drawing.Point(9, 110);
            this.Option3.Name = "Option3";
            this.Option3.Size = new System.Drawing.Size(152, 17);
            this.Option3.TabIndex = 2;
            this.Option3.Text = "Select based on timestamp";
            this.Option3.UseVisualStyleBackColor = true;
            this.Option3.CheckedChanged += new System.EventHandler(this.InputChanged);
            // 
            // Option2
            // 
            this.Option2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Option2.AutoSize = true;
            this.Option2.Location = new System.Drawing.Point(9, 72);
            this.Option2.Name = "Option2";
            this.Option2.Size = new System.Drawing.Size(139, 17);
            this.Option2.TabIndex = 1;
            this.Option2.Text = "Select based on volume";
            this.Option2.UseVisualStyleBackColor = true;
            this.Option2.CheckedChanged += new System.EventHandler(this.InputChanged);
            // 
            // Option1
            // 
            this.Option1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Option1.AutoSize = true;
            this.Option1.Checked = true;
            this.Option1.Location = new System.Drawing.Point(9, 36);
            this.Option1.Name = "Option1";
            this.Option1.Size = new System.Drawing.Size(99, 17);
            this.Option1.TabIndex = 0;
            this.Option1.TabStop = true;
            this.Option1.Text = "Select all points";
            this.Option1.UseVisualStyleBackColor = true;
            this.Option1.CheckedChanged += new System.EventHandler(this.InputChanged);
            // 
            // ChangesBox
            // 
            this.ChangesBox.Controls.Add(this.ChangeValLabel);
            this.ChangesBox.Controls.Add(this.TrackBarChanges);
            this.ChangesBox.Controls.Add(this.ChangeVal);
            this.ChangesBox.Controls.Add(this.SetVal);
            this.ChangesBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangesBox.Location = new System.Drawing.Point(197, 3);
            this.ChangesBox.Name = "ChangesBox";
            this.ChangesBox.Size = new System.Drawing.Size(329, 151);
            this.ChangesBox.TabIndex = 1;
            this.ChangesBox.TabStop = false;
            this.ChangesBox.Text = "Make Changes By...";
            // 
            // ChangeValLabel
            // 
            this.ChangeValLabel.AutoSize = true;
            this.ChangeValLabel.Location = new System.Drawing.Point(6, 103);
            this.ChangeValLabel.Name = "ChangeValLabel";
            this.ChangeValLabel.Size = new System.Drawing.Size(313, 13);
            this.ChangeValLabel.TabIndex = 3;
            this.ChangeValLabel.Text = "Note: When value exceeds 0 or 100, it will be set at its threshold.";
            // 
            // TrackBarChanges
            // 
            this.TrackBarChanges.Location = new System.Drawing.Point(6, 65);
            this.TrackBarChanges.Name = "TrackBarChanges";
            this.TrackBarChanges.Size = new System.Drawing.Size(310, 45);
            this.TrackBarChanges.TabIndex = 2;
            this.TrackBarChanges.TickFrequency = 10;
            // 
            // ChangeVal
            // 
            this.ChangeVal.AutoSize = true;
            this.ChangeVal.Checked = true;
            this.ChangeVal.Location = new System.Drawing.Point(184, 19);
            this.ChangeVal.Name = "ChangeVal";
            this.ChangeVal.Size = new System.Drawing.Size(132, 17);
            this.ChangeVal.TabIndex = 1;
            this.ChangeVal.TabStop = true;
            this.ChangeVal.Text = "Add/Subtract by value";
            this.ChangeVal.UseVisualStyleBackColor = true;
            this.ChangeVal.CheckedChanged += new System.EventHandler(this.ChangeTypeChanged);
            // 
            // SetVal
            // 
            this.SetVal.AutoSize = true;
            this.SetVal.Location = new System.Drawing.Point(6, 19);
            this.SetVal.Name = "SetVal";
            this.SetVal.Size = new System.Drawing.Size(91, 17);
            this.SetVal.TabIndex = 0;
            this.SetVal.Text = "Set to a value";
            this.SetVal.UseVisualStyleBackColor = true;
            this.SetVal.CheckedChanged += new System.EventHandler(this.ChangeTypeChanged);
            // 
            // SelectVolBox
            // 
            this.SelectVolBox.Controls.Add(this.l1);
            this.SelectVolBox.Controls.Add(this.SelectVol);
            this.SelectVolBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectVolBox.Location = new System.Drawing.Point(532, 3);
            this.SelectVolBox.Name = "SelectVolBox";
            this.SelectVolBox.Size = new System.Drawing.Size(213, 151);
            this.SelectVolBox.TabIndex = 2;
            this.SelectVolBox.TabStop = false;
            this.SelectVolBox.Text = "Select Based On Volume";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(16, 67);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(109, 13);
            this.l1.TabIndex = 1;
            this.l1.Text = "Select all points with  ";
            // 
            // SelectVol
            // 
            this.SelectVol.Location = new System.Drawing.Point(131, 65);
            this.SelectVol.Name = "SelectVol";
            this.SelectVol.Size = new System.Drawing.Size(68, 20);
            this.SelectVol.TabIndex = 0;
            // 
            // SelectTimestampBox
            // 
            this.SelectTimestampBox.Controls.Add(this.l5);
            this.SelectTimestampBox.Controls.Add(this.l3);
            this.SelectTimestampBox.Controls.Add(this.MaxDurUntil);
            this.SelectTimestampBox.Controls.Add(this.MaxDurStart);
            this.SelectTimestampBox.Controls.Add(this.l8);
            this.SelectTimestampBox.Controls.Add(this.l4);
            this.SelectTimestampBox.Controls.Add(this.l2);
            this.SelectTimestampBox.Controls.Add(this.UntilTrackBar);
            this.SelectTimestampBox.Controls.Add(this.StartTrackBar);
            this.SelectTimestampBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectTimestampBox.Location = new System.Drawing.Point(3, 160);
            this.SelectTimestampBox.Name = "SelectTimestampBox";
            this.SelectTimestampBox.Size = new System.Drawing.Size(742, 210);
            this.SelectTimestampBox.TabIndex = 1;
            this.SelectTimestampBox.TabStop = false;
            this.SelectTimestampBox.Text = "Select Based On Timestamp";
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.Location = new System.Drawing.Point(9, 106);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(37, 13);
            this.l5.TabIndex = 9;
            this.l5.Text = "Until...";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(9, 26);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(60, 13);
            this.l3.TabIndex = 8;
            this.l3.Text = "Select from";
            // 
            // MaxDurUntil
            // 
            this.MaxDurUntil.AutoSize = true;
            this.MaxDurUntil.Location = new System.Drawing.Point(519, 170);
            this.MaxDurUntil.Name = "MaxDurUntil";
            this.MaxDurUntil.Size = new System.Drawing.Size(34, 13);
            this.MaxDurUntil.TabIndex = 7;
            this.MaxDurUntil.Text = "00:00";
            // 
            // MaxDurStart
            // 
            this.MaxDurStart.AutoSize = true;
            this.MaxDurStart.Location = new System.Drawing.Point(519, 83);
            this.MaxDurStart.Name = "MaxDurStart";
            this.MaxDurStart.Size = new System.Drawing.Size(34, 13);
            this.MaxDurStart.TabIndex = 6;
            this.MaxDurStart.Text = "00:00";
            // 
            // l8
            // 
            this.l8.AutoSize = true;
            this.l8.Location = new System.Drawing.Point(9, 170);
            this.l8.Name = "l8";
            this.l8.Size = new System.Drawing.Size(34, 13);
            this.l8.TabIndex = 5;
            this.l8.Text = "00:00";
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Location = new System.Drawing.Point(6, 83);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(34, 13);
            this.l4.TabIndex = 4;
            this.l4.Text = "00:00";
            // 
            // l2
            // 
            this.l2.Controls.Add(this.l7);
            this.l2.Controls.Add(this.l6);
            this.l2.Controls.Add(this.UntilTb);
            this.l2.Controls.Add(this.SelectFromTb);
            this.l2.Location = new System.Drawing.Point(584, 19);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(152, 185);
            this.l2.TabIndex = 3;
            this.l2.TabStop = false;
            this.l2.Text = "Custom Input:";
            // 
            // l7
            // 
            this.l7.AutoSize = true;
            this.l7.Location = new System.Drawing.Point(6, 103);
            this.l7.Name = "l7";
            this.l7.Size = new System.Drawing.Size(31, 13);
            this.l7.TabIndex = 7;
            this.l7.Text = "Until:";
            // 
            // l6
            // 
            this.l6.AutoSize = true;
            this.l6.Location = new System.Drawing.Point(6, 23);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(66, 13);
            this.l6.TabIndex = 6;
            this.l6.Text = "Select From:";
            // 
            // UntilTb
            // 
            this.UntilTb.Location = new System.Drawing.Point(46, 128);
            this.UntilTb.Name = "UntilTb";
            this.UntilTb.Size = new System.Drawing.Size(100, 20);
            this.UntilTb.TabIndex = 5;
            this.UntilTb.TextChanged += new System.EventHandler(this.ContentChanged);
            // 
            // SelectFromTb
            // 
            this.SelectFromTb.Location = new System.Drawing.Point(46, 52);
            this.SelectFromTb.Name = "SelectFromTb";
            this.SelectFromTb.Size = new System.Drawing.Size(100, 20);
            this.SelectFromTb.TabIndex = 4;
            this.SelectFromTb.TextChanged += new System.EventHandler(this.ContentChanged);
            // 
            // UntilTrackBar
            // 
            this.UntilTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.UntilTrackBar.Location = new System.Drawing.Point(6, 131);
            this.UntilTrackBar.Name = "UntilTrackBar";
            this.UntilTrackBar.Size = new System.Drawing.Size(547, 45);
            this.UntilTrackBar.TabIndex = 2;
            this.UntilTrackBar.TickFrequency = 60;
            // 
            // StartTrackBar
            // 
            this.StartTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StartTrackBar.Location = new System.Drawing.Point(6, 51);
            this.StartTrackBar.Name = "StartTrackBar";
            this.StartTrackBar.Size = new System.Drawing.Size(547, 45);
            this.StartTrackBar.TabIndex = 1;
            this.StartTrackBar.TickFrequency = 60;
            // 
            // VolumeToolIntf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 474);
            this.Controls.Add(this.BG1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VolumeToolIntf";
            this.Text = "VolumeToolIntf";
            this.BG1.ResumeLayout(false);
            this.BG2.ResumeLayout(false);
            this.Selector.ResumeLayout(false);
            this.Selector.PerformLayout();
            this.ChangesBox.ResumeLayout(false);
            this.ChangesBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarChanges)).EndInit();
            this.SelectVolBox.ResumeLayout(false);
            this.SelectVolBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectVol)).EndInit();
            this.SelectTimestampBox.ResumeLayout(false);
            this.SelectTimestampBox.PerformLayout();
            this.l2.ResumeLayout(false);
            this.l2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UntilTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BG1;
        private System.Windows.Forms.TableLayoutPanel BG2;
        private System.Windows.Forms.GroupBox Selector;
        private System.Windows.Forms.RadioButton Option3;
        private System.Windows.Forms.RadioButton Option2;
        private System.Windows.Forms.RadioButton Option1;
        private System.Windows.Forms.GroupBox ChangesBox;
        private System.Windows.Forms.Label ChangeValLabel;
        private System.Windows.Forms.TrackBar TrackBarChanges;
        private System.Windows.Forms.RadioButton ChangeVal;
        private System.Windows.Forms.RadioButton SetVal;
        private System.Windows.Forms.GroupBox SelectVolBox;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.NumericUpDown SelectVol;
        private System.Windows.Forms.GroupBox SelectTimestampBox;
        private System.Windows.Forms.GroupBox l2;
        private System.Windows.Forms.TrackBar UntilTrackBar;
        private System.Windows.Forms.TrackBar StartTrackBar;
        private System.Windows.Forms.Label l7;
        private System.Windows.Forms.Label l6;
        private System.Windows.Forms.TextBox UntilTb;
        private System.Windows.Forms.TextBox SelectFromTb;
        private System.Windows.Forms.Button ChangeVol;
        private System.Windows.Forms.Label MaxDurUntil;
        private System.Windows.Forms.Label MaxDurStart;
        private System.Windows.Forms.Label l8;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.ToolTip trackNum;
    }
}