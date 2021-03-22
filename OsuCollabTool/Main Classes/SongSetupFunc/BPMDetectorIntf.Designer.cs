namespace OsuCollabTool.Main_Classes.SongSetupFunc
{
    partial class BPMDetectorIntf
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
            this.DetectBPM = new System.Windows.Forms.Button();
            this.QuickScan = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtmBG = new System.Windows.Forms.TableLayoutPanel();
            this.l7 = new System.Windows.Forms.GroupBox();
            this.ResultBPM = new System.Windows.Forms.Label();
            this.l8 = new System.Windows.Forms.Label();
            this.ResultBPMPanel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainBG = new System.Windows.Forms.TableLayoutPanel();
            this.l2 = new System.Windows.Forms.GroupBox();
            this.MaxDurUntil = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.UntilTrackBar = new System.Windows.Forms.TrackBar();
            this.l1 = new System.Windows.Forms.GroupBox();
            this.MaxDurStart = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.StartTrackBar = new System.Windows.Forms.TrackBar();
            this.trackNum = new System.Windows.Forms.ToolTip(this.components);
            this.l5 = new System.Windows.Forms.Label();
            this.l6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.BtmBG.SuspendLayout();
            this.l7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MainBG.SuspendLayout();
            this.l2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UntilTrackBar)).BeginInit();
            this.l1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // DetectBPM
            // 
            this.DetectBPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetectBPM.FlatAppearance.BorderSize = 0;
            this.DetectBPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetectBPM.Location = new System.Drawing.Point(1, 0);
            this.DetectBPM.Margin = new System.Windows.Forms.Padding(1, 0, 0, 2);
            this.DetectBPM.Name = "DetectBPM";
            this.DetectBPM.Size = new System.Drawing.Size(313, 83);
            this.DetectBPM.TabIndex = 0;
            this.DetectBPM.Text = "Analyze specified section";
            this.DetectBPM.UseVisualStyleBackColor = true;
            this.DetectBPM.Click += new System.EventHandler(this.DetectBPM_Click);
            // 
            // QuickScan
            // 
            this.QuickScan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuickScan.FlatAppearance.BorderSize = 0;
            this.QuickScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuickScan.Location = new System.Drawing.Point(316, 0);
            this.QuickScan.Margin = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.QuickScan.Name = "QuickScan";
            this.QuickScan.Size = new System.Drawing.Size(150, 83);
            this.QuickScan.TabIndex = 1;
            this.QuickScan.Text = "Quick Scan";
            this.QuickScan.UseVisualStyleBackColor = true;
            this.QuickScan.Click += new System.EventHandler(this.QuickScan_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.BtmBG, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(748, 406);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // BtmBG
            // 
            this.BtmBG.BackColor = System.Drawing.SystemColors.Control;
            this.BtmBG.ColumnCount = 3;
            this.BtmBG.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.3774F));
            this.BtmBG.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.6226F));
            this.BtmBG.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 281F));
            this.BtmBG.Controls.Add(this.l7, 2, 0);
            this.BtmBG.Controls.Add(this.QuickScan, 1, 0);
            this.BtmBG.Controls.Add(this.DetectBPM, 0, 0);
            this.BtmBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtmBG.Location = new System.Drawing.Point(0, 321);
            this.BtmBG.Margin = new System.Windows.Forms.Padding(0);
            this.BtmBG.Name = "BtmBG";
            this.BtmBG.RowCount = 1;
            this.BtmBG.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BtmBG.Size = new System.Drawing.Size(748, 85);
            this.BtmBG.TabIndex = 0;
            // 
            // l7
            // 
            this.l7.Controls.Add(this.ResultBPM);
            this.l7.Controls.Add(this.l8);
            this.l7.Controls.Add(this.ResultBPMPanel);
            this.l7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l7.Location = new System.Drawing.Point(469, 3);
            this.l7.Name = "l7";
            this.l7.Size = new System.Drawing.Size(276, 79);
            this.l7.TabIndex = 2;
            this.l7.TabStop = false;
            this.l7.Text = "Results";
            // 
            // ResultBPM
            // 
            this.ResultBPM.AutoSize = true;
            this.ResultBPM.Location = new System.Drawing.Point(154, 23);
            this.ResultBPM.Name = "ResultBPM";
            this.ResultBPM.Size = new System.Drawing.Size(0, 13);
            this.ResultBPM.TabIndex = 2;
            // 
            // l8
            // 
            this.l8.AutoSize = true;
            this.l8.Location = new System.Drawing.Point(3, 54);
            this.l8.Name = "l8";
            this.l8.Size = new System.Drawing.Size(268, 13);
            this.l8.TabIndex = 1;
            this.l8.Text = "*Please note that the results may not be 100% accurate";
            // 
            // ResultBPMPanel
            // 
            this.ResultBPMPanel.AutoSize = true;
            this.ResultBPMPanel.Location = new System.Drawing.Point(26, 23);
            this.ResultBPMPanel.Name = "ResultBPMPanel";
            this.ResultBPMPanel.Size = new System.Drawing.Size(80, 13);
            this.ResultBPMPanel.TabIndex = 0;
            this.ResultBPMPanel.Text = "Detected BPM:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MainBG);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 321);
            this.panel1.TabIndex = 1;
            // 
            // MainBG
            // 
            this.MainBG.BackColor = System.Drawing.SystemColors.Control;
            this.MainBG.ColumnCount = 1;
            this.MainBG.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainBG.Controls.Add(this.l2, 0, 1);
            this.MainBG.Controls.Add(this.l1, 0, 0);
            this.MainBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainBG.Location = new System.Drawing.Point(0, 0);
            this.MainBG.Margin = new System.Windows.Forms.Padding(0);
            this.MainBG.Name = "MainBG";
            this.MainBG.RowCount = 2;
            this.MainBG.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainBG.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainBG.Size = new System.Drawing.Size(748, 321);
            this.MainBG.TabIndex = 0;
            // 
            // l2
            // 
            this.l2.Controls.Add(this.l6);
            this.l2.Controls.Add(this.l5);
            this.l2.Controls.Add(this.MaxDurUntil);
            this.l2.Controls.Add(this.l4);
            this.l2.Controls.Add(this.UntilTrackBar);
            this.l2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l2.Location = new System.Drawing.Point(3, 163);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(742, 155);
            this.l2.TabIndex = 1;
            this.l2.TabStop = false;
            this.l2.Text = "Until...";
            // 
            // MaxDurUntil
            // 
            this.MaxDurUntil.AutoSize = true;
            this.MaxDurUntil.Location = new System.Drawing.Point(702, 99);
            this.MaxDurUntil.Name = "MaxDurUntil";
            this.MaxDurUntil.Size = new System.Drawing.Size(34, 13);
            this.MaxDurUntil.TabIndex = 3;
            this.MaxDurUntil.Text = "00:00";
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Location = new System.Drawing.Point(9, 99);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(34, 13);
            this.l4.TabIndex = 2;
            this.l4.Text = "00:00";
            // 
            // UntilTrackBar
            // 
            this.UntilTrackBar.Location = new System.Drawing.Point(9, 55);
            this.UntilTrackBar.Name = "UntilTrackBar";
            this.UntilTrackBar.Size = new System.Drawing.Size(724, 45);
            this.UntilTrackBar.TabIndex = 1;
            // 
            // l1
            // 
            this.l1.Controls.Add(this.MaxDurStart);
            this.l1.Controls.Add(this.l3);
            this.l1.Controls.Add(this.StartTrackBar);
            this.l1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l1.Location = new System.Drawing.Point(3, 3);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(742, 154);
            this.l1.TabIndex = 0;
            this.l1.TabStop = false;
            this.l1.Text = "Start analysis from...";
            // 
            // MaxDurStart
            // 
            this.MaxDurStart.AutoSize = true;
            this.MaxDurStart.Location = new System.Drawing.Point(702, 106);
            this.MaxDurStart.Name = "MaxDurStart";
            this.MaxDurStart.Size = new System.Drawing.Size(34, 13);
            this.MaxDurStart.TabIndex = 4;
            this.MaxDurStart.Text = "00:00";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(9, 106);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(34, 13);
            this.l3.TabIndex = 3;
            this.l3.Text = "00:00";
            // 
            // StartTrackBar
            // 
            this.StartTrackBar.Location = new System.Drawing.Point(9, 58);
            this.StartTrackBar.Name = "StartTrackBar";
            this.StartTrackBar.Size = new System.Drawing.Size(724, 45);
            this.StartTrackBar.TabIndex = 0;
            // 
            // l5
            // 
            this.l5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.l5.AutoSize = true;
            this.l5.Location = new System.Drawing.Point(607, 135);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(111, 13);
            this.l5.TabIndex = 4;
            this.l5.Text = "Powered By OliBomby";
            // 
            // l6
            // 
            this.l6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.l6.AutoSize = true;
            this.l6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.l6.Location = new System.Drawing.Point(714, 128);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(17, 9);
            this.l6.TabIndex = 5;
            this.l6.Text = "TM";
            // 
            // BPMDetectorIntf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 406);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BPMDetectorIntf";
            this.Text = "BPMDetectorIntf";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.BtmBG.ResumeLayout(false);
            this.l7.ResumeLayout(false);
            this.l7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.MainBG.ResumeLayout(false);
            this.l2.ResumeLayout(false);
            this.l2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UntilTrackBar)).EndInit();
            this.l1.ResumeLayout(false);
            this.l1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DetectBPM;
        private System.Windows.Forms.Button QuickScan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel BtmBG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel MainBG;
        private System.Windows.Forms.GroupBox l2;
        private System.Windows.Forms.Label MaxDurUntil;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.TrackBar UntilTrackBar;
        private System.Windows.Forms.GroupBox l1;
        private System.Windows.Forms.Label MaxDurStart;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.TrackBar StartTrackBar;
        private System.Windows.Forms.ToolTip trackNum;
        private System.Windows.Forms.GroupBox l7;
        private System.Windows.Forms.Label l8;
        private System.Windows.Forms.Label ResultBPMPanel;
        private System.Windows.Forms.Label ResultBPM;
        private System.Windows.Forms.Label l6;
        private System.Windows.Forms.Label l5;
    }
}