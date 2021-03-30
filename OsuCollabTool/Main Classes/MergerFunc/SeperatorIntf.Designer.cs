namespace OsuCollabTool.Main_Classes.MergerFunc
{
    partial class SeperatorIntf
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
            this.trackNum = new System.Windows.Forms.ToolTip(this.components);
            this.MaxDurStart = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.MaxDurUntil = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.UntilTrackBar = new System.Windows.Forms.TrackBar();
            this.StartTrackBar = new System.Windows.Forms.TrackBar();
            this.l2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainBG = new System.Windows.Forms.TableLayoutPanel();
            this.l1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtmBG = new System.Windows.Forms.TableLayoutPanel();
            this.l5 = new System.Windows.Forms.GroupBox();
            this.l7 = new System.Windows.Forms.Label();
            this.l6 = new System.Windows.Forms.Label();
            this.UntilTb = new System.Windows.Forms.TextBox();
            this.SeperateFromTb = new System.Windows.Forms.TextBox();
            this.SeperateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UntilTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartTrackBar)).BeginInit();
            this.l2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MainBG.SuspendLayout();
            this.l1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.BtmBG.SuspendLayout();
            this.l5.SuspendLayout();
            this.SuspendLayout();
            // 
            // MaxDurStart
            // 
            this.MaxDurStart.AutoSize = true;
            this.MaxDurStart.Location = new System.Drawing.Point(686, 106);
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
            // MaxDurUntil
            // 
            this.MaxDurUntil.AutoSize = true;
            this.MaxDurUntil.Location = new System.Drawing.Point(686, 99);
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
            this.UntilTrackBar.Size = new System.Drawing.Size(706, 45);
            this.UntilTrackBar.TabIndex = 1;
            this.UntilTrackBar.TickFrequency = 60000;
            // 
            // StartTrackBar
            // 
            this.StartTrackBar.Location = new System.Drawing.Point(9, 58);
            this.StartTrackBar.Name = "StartTrackBar";
            this.StartTrackBar.Size = new System.Drawing.Size(706, 45);
            this.StartTrackBar.TabIndex = 0;
            this.StartTrackBar.TickFrequency = 60000;
            // 
            // l2
            // 
            this.l2.Controls.Add(this.MaxDurUntil);
            this.l2.Controls.Add(this.l4);
            this.l2.Controls.Add(this.UntilTrackBar);
            this.l2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l2.Location = new System.Drawing.Point(3, 175);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(726, 166);
            this.l2.TabIndex = 1;
            this.l2.TabStop = false;
            this.l2.Text = "Until...";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MainBG);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 344);
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
            this.MainBG.Size = new System.Drawing.Size(732, 344);
            this.MainBG.TabIndex = 0;
            // 
            // l1
            // 
            this.l1.Controls.Add(this.MaxDurStart);
            this.l1.Controls.Add(this.l3);
            this.l1.Controls.Add(this.StartTrackBar);
            this.l1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l1.Location = new System.Drawing.Point(3, 3);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(726, 166);
            this.l1.TabIndex = 0;
            this.l1.TabStop = false;
            this.l1.Text = "Seperate Section from...";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtmBG, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(732, 435);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // BtmBG
            // 
            this.BtmBG.ColumnCount = 2;
            this.BtmBG.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BtmBG.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 237F));
            this.BtmBG.Controls.Add(this.l5, 1, 0);
            this.BtmBG.Controls.Add(this.SeperateBtn, 0, 0);
            this.BtmBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtmBG.Location = new System.Drawing.Point(0, 344);
            this.BtmBG.Margin = new System.Windows.Forms.Padding(0);
            this.BtmBG.Name = "BtmBG";
            this.BtmBG.RowCount = 1;
            this.BtmBG.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BtmBG.Size = new System.Drawing.Size(732, 91);
            this.BtmBG.TabIndex = 2;
            // 
            // l5
            // 
            this.l5.Controls.Add(this.l7);
            this.l5.Controls.Add(this.l6);
            this.l5.Controls.Add(this.UntilTb);
            this.l5.Controls.Add(this.SeperateFromTb);
            this.l5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l5.Location = new System.Drawing.Point(498, 3);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(231, 85);
            this.l5.TabIndex = 0;
            this.l5.TabStop = false;
            this.l5.Text = "Custom Input:";
            // 
            // l7
            // 
            this.l7.AutoSize = true;
            this.l7.Location = new System.Drawing.Point(24, 59);
            this.l7.Name = "l7";
            this.l7.Size = new System.Drawing.Size(31, 13);
            this.l7.TabIndex = 3;
            this.l7.Text = "Until:";
            // 
            // l6
            // 
            this.l6.AutoSize = true;
            this.l6.Location = new System.Drawing.Point(24, 22);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(79, 13);
            this.l6.TabIndex = 2;
            this.l6.Text = "Seperate From:";
            // 
            // UntilTb
            // 
            this.UntilTb.Location = new System.Drawing.Point(120, 56);
            this.UntilTb.Name = "UntilTb";
            this.UntilTb.Size = new System.Drawing.Size(100, 20);
            this.UntilTb.TabIndex = 1;
            this.UntilTb.TextChanged += new System.EventHandler(this.ContentChanged);
            // 
            // SeperateFromTb
            // 
            this.SeperateFromTb.Location = new System.Drawing.Point(120, 19);
            this.SeperateFromTb.Name = "SeperateFromTb";
            this.SeperateFromTb.Size = new System.Drawing.Size(100, 20);
            this.SeperateFromTb.TabIndex = 0;
            this.SeperateFromTb.TextChanged += new System.EventHandler(this.ContentChanged);
            // 
            // SeperateBtn
            // 
            this.SeperateBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeperateBtn.FlatAppearance.BorderSize = 0;
            this.SeperateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeperateBtn.Location = new System.Drawing.Point(0, 0);
            this.SeperateBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SeperateBtn.Name = "SeperateBtn";
            this.SeperateBtn.Size = new System.Drawing.Size(495, 91);
            this.SeperateBtn.TabIndex = 1;
            this.SeperateBtn.Text = "Seperate Part";
            this.SeperateBtn.UseVisualStyleBackColor = true;
            this.SeperateBtn.Click += new System.EventHandler(this.SeperateBtn_Click);
            // 
            // SeperatorIntf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 435);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeperatorIntf";
            this.Text = "SeperatorIntf";
            ((System.ComponentModel.ISupportInitialize)(this.UntilTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartTrackBar)).EndInit();
            this.l2.ResumeLayout(false);
            this.l2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.MainBG.ResumeLayout(false);
            this.l1.ResumeLayout(false);
            this.l1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.BtmBG.ResumeLayout(false);
            this.l5.ResumeLayout(false);
            this.l5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip trackNum;
        private System.Windows.Forms.Label MaxDurStart;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label MaxDurUntil;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.TrackBar UntilTrackBar;
        private System.Windows.Forms.TrackBar StartTrackBar;
        private System.Windows.Forms.GroupBox l2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel MainBG;
        private System.Windows.Forms.GroupBox l1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel BtmBG;
        private System.Windows.Forms.GroupBox l5;
        private System.Windows.Forms.Label l7;
        private System.Windows.Forms.Label l6;
        private System.Windows.Forms.TextBox UntilTb;
        private System.Windows.Forms.TextBox SeperateFromTb;
        private System.Windows.Forms.Button SeperateBtn;
    }
}