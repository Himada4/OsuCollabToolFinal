namespace OsuCollabTool.Main_Classes.MergerFunc
{
    partial class CompareLog
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.File1NameH = new System.Windows.Forms.Label();
            this.File2NameH = new System.Windows.Forms.Label();
            this.HOFile2 = new System.Windows.Forms.ListBox();
            this.HOFile1 = new System.Windows.Forms.ListBox();
            this.TimingPoint = new System.Windows.Forms.GroupBox();
            this.tip = new System.Windows.Forms.Label();
            this.File2NameT = new System.Windows.Forms.Label();
            this.File1NameT = new System.Windows.Forms.Label();
            this.TPFile2 = new System.Windows.Forms.ListBox();
            this.TPFile1 = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.TimingPoint.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TimingPoint, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(615, 382);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.File1NameH);
            this.groupBox2.Controls.Add(this.File2NameH);
            this.groupBox2.Controls.Add(this.HOFile2);
            this.groupBox2.Controls.Add(this.HOFile1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(609, 185);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unique Hit Objects Found In:";
            // 
            // File1NameH
            // 
            this.File1NameH.AutoSize = true;
            this.File1NameH.Location = new System.Drawing.Point(10, 21);
            this.File1NameH.Name = "File1NameH";
            this.File1NameH.Size = new System.Drawing.Size(32, 13);
            this.File1NameH.TabIndex = 5;
            this.File1NameH.Text = "File 1";
            // 
            // File2NameH
            // 
            this.File2NameH.AutoSize = true;
            this.File2NameH.Location = new System.Drawing.Point(307, 21);
            this.File2NameH.Name = "File2NameH";
            this.File2NameH.Size = new System.Drawing.Size(32, 13);
            this.File2NameH.TabIndex = 4;
            this.File2NameH.Text = "File 2";
            // 
            // HOFile2
            // 
            this.HOFile2.FormattingEnabled = true;
            this.HOFile2.Location = new System.Drawing.Point(310, 45);
            this.HOFile2.Name = "HOFile2";
            this.HOFile2.Size = new System.Drawing.Size(290, 121);
            this.HOFile2.TabIndex = 3;
            this.HOFile2.Tag = "2";
            this.HOFile2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HO_KeyDown);
            // 
            // HOFile1
            // 
            this.HOFile1.FormattingEnabled = true;
            this.HOFile1.Location = new System.Drawing.Point(9, 45);
            this.HOFile1.Name = "HOFile1";
            this.HOFile1.Size = new System.Drawing.Size(290, 121);
            this.HOFile1.TabIndex = 2;
            this.HOFile1.Tag = "1";
            this.HOFile1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HO_KeyDown);
            // 
            // TimingPoint
            // 
            this.TimingPoint.Controls.Add(this.tip);
            this.TimingPoint.Controls.Add(this.File2NameT);
            this.TimingPoint.Controls.Add(this.File1NameT);
            this.TimingPoint.Controls.Add(this.TPFile2);
            this.TimingPoint.Controls.Add(this.TPFile1);
            this.TimingPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimingPoint.Location = new System.Drawing.Point(3, 3);
            this.TimingPoint.Name = "TimingPoint";
            this.TimingPoint.Size = new System.Drawing.Size(609, 185);
            this.TimingPoint.TabIndex = 0;
            this.TimingPoint.TabStop = false;
            this.TimingPoint.Text = "Unique Timing Points Found In:";
            // 
            // tip
            // 
            this.tip.AutoSize = true;
            this.tip.Location = new System.Drawing.Point(314, 169);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(286, 13);
            this.tip.TabIndex = 6;
            this.tip.Text = "Tip: You can ctrl + c after selecting to copy the offset value";
            // 
            // File2NameT
            // 
            this.File2NameT.AutoSize = true;
            this.File2NameT.Location = new System.Drawing.Point(307, 20);
            this.File2NameT.Name = "File2NameT";
            this.File2NameT.Size = new System.Drawing.Size(32, 13);
            this.File2NameT.TabIndex = 3;
            this.File2NameT.Text = "File 2";
            // 
            // File1NameT
            // 
            this.File1NameT.AutoSize = true;
            this.File1NameT.Location = new System.Drawing.Point(10, 20);
            this.File1NameT.Name = "File1NameT";
            this.File1NameT.Size = new System.Drawing.Size(32, 13);
            this.File1NameT.TabIndex = 2;
            this.File1NameT.Text = "File 1";
            // 
            // TPFile2
            // 
            this.TPFile2.FormattingEnabled = true;
            this.TPFile2.Location = new System.Drawing.Point(310, 45);
            this.TPFile2.Name = "TPFile2";
            this.TPFile2.Size = new System.Drawing.Size(290, 121);
            this.TPFile2.TabIndex = 1;
            this.TPFile2.Tag = "2";
            this.TPFile2.Click += new System.EventHandler(this.ClickedTP);
            this.TPFile2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TP_KeyDown);
            // 
            // TPFile1
            // 
            this.TPFile1.FormattingEnabled = true;
            this.TPFile1.Location = new System.Drawing.Point(9, 45);
            this.TPFile1.Name = "TPFile1";
            this.TPFile1.Size = new System.Drawing.Size(290, 121);
            this.TPFile1.TabIndex = 0;
            this.TPFile1.Tag = "1";
            this.TPFile1.Click += new System.EventHandler(this.ClickedTP);
            this.TPFile1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TP_KeyDown);
            // 
            // CompareLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 382);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CompareLog";
            this.Text = "CompareLog";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.TimingPoint.ResumeLayout(false);
            this.TimingPoint.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox TimingPoint;
        private System.Windows.Forms.Label File1NameH;
        private System.Windows.Forms.Label File2NameH;
        private System.Windows.Forms.ListBox HOFile2;
        private System.Windows.Forms.ListBox HOFile1;
        private System.Windows.Forms.Label File2NameT;
        private System.Windows.Forms.Label File1NameT;
        private System.Windows.Forms.ListBox TPFile2;
        private System.Windows.Forms.ListBox TPFile1;
        private System.Windows.Forms.Label tip;
    }
}