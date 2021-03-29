namespace OsuCollabTool.Main_Classes.MappingFunc
{
    partial class PatternBank
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
            this.SavePattern = new System.Windows.Forms.Button();
            this.OpenPatternBank = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ObjList = new System.Windows.Forms.ListBox();
            this.ObjClip = new System.Windows.Forms.Button();
            this.ObjSelected = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.FileName = new System.Windows.Forms.Label();
            this.OffsetTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PasteBtn = new System.Windows.Forms.Button();
            this.OpenFolderLoc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MainBG1 = new System.Windows.Forms.TableLayoutPanel();
            this.MainBG2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.MainBG1.SuspendLayout();
            this.MainBG2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SavePattern
            // 
            this.SavePattern.FlatAppearance.BorderSize = 0;
            this.SavePattern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SavePattern.Location = new System.Drawing.Point(597, 57);
            this.SavePattern.Name = "SavePattern";
            this.SavePattern.Size = new System.Drawing.Size(136, 95);
            this.SavePattern.TabIndex = 1;
            this.SavePattern.Text = "Save Pattern As...";
            this.SavePattern.UseVisualStyleBackColor = true;
            this.SavePattern.Click += new System.EventHandler(this.SavePattern_Click);
            // 
            // OpenPatternBank
            // 
            this.OpenPatternBank.FlatAppearance.BorderSize = 0;
            this.OpenPatternBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenPatternBank.Location = new System.Drawing.Point(597, 70);
            this.OpenPatternBank.Name = "OpenPatternBank";
            this.OpenPatternBank.Size = new System.Drawing.Size(136, 23);
            this.OpenPatternBank.TabIndex = 2;
            this.OpenPatternBank.Text = "Open Pattern Bank...";
            this.OpenPatternBank.UseVisualStyleBackColor = true;
            this.OpenPatternBank.Click += new System.EventHandler(this.OpenPatternBank_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ObjList);
            this.groupBox1.Controls.Add(this.ObjClip);
            this.groupBox1.Controls.Add(this.ObjSelected);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.SavePattern);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 198);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert Object To Pattern Bank";
            // 
            // ObjList
            // 
            this.ObjList.FormattingEnabled = true;
            this.ObjList.Location = new System.Drawing.Point(120, 57);
            this.ObjList.Name = "ObjList";
            this.ObjList.Size = new System.Drawing.Size(471, 95);
            this.ObjList.TabIndex = 15;
            // 
            // ObjClip
            // 
            this.ObjClip.FlatAppearance.BorderSize = 0;
            this.ObjClip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ObjClip.Location = new System.Drawing.Point(361, 19);
            this.ObjClip.Name = "ObjClip";
            this.ObjClip.Size = new System.Drawing.Size(230, 23);
            this.ObjClip.TabIndex = 14;
            this.ObjClip.Text = "Objects Are Copied";
            this.ObjClip.UseVisualStyleBackColor = true;
            this.ObjClip.Click += new System.EventHandler(this.ObjClip_Click);
            // 
            // ObjSelected
            // 
            this.ObjSelected.FlatAppearance.BorderSize = 0;
            this.ObjSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ObjSelected.Location = new System.Drawing.Point(120, 19);
            this.ObjSelected.Name = "ObjSelected";
            this.ObjSelected.Size = new System.Drawing.Size(230, 23);
            this.ObjSelected.TabIndex = 13;
            this.ObjSelected.Text = "Objects Are Selected";
            this.ObjSelected.UseVisualStyleBackColor = true;
            this.ObjSelected.Click += new System.EventHandler(this.ObjSelected_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Detect Objects By:";
            // 
            // FileName
            // 
            this.FileName.AutoSize = true;
            this.FileName.Location = new System.Drawing.Point(93, 75);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(0, 13);
            this.FileName.TabIndex = 6;
            // 
            // OffsetTextBox
            // 
            this.OffsetTextBox.Location = new System.Drawing.Point(96, 153);
            this.OffsetTextBox.Name = "OffsetTextBox";
            this.OffsetTextBox.Size = new System.Drawing.Size(495, 20);
            this.OffsetTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Offset To Paste:";
            // 
            // PasteBtn
            // 
            this.PasteBtn.FlatAppearance.BorderSize = 0;
            this.PasteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasteBtn.Location = new System.Drawing.Point(597, 151);
            this.PasteBtn.Name = "PasteBtn";
            this.PasteBtn.Size = new System.Drawing.Size(136, 23);
            this.PasteBtn.TabIndex = 9;
            this.PasteBtn.Text = "Paste Pattern";
            this.PasteBtn.UseVisualStyleBackColor = true;
            this.PasteBtn.Click += new System.EventHandler(this.PasteBtn_Click);
            // 
            // OpenFolderLoc
            // 
            this.OpenFolderLoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenFolderLoc.FlatAppearance.BorderSize = 0;
            this.OpenFolderLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFolderLoc.Location = new System.Drawing.Point(3, 411);
            this.OpenFolderLoc.Name = "OpenFolderLoc";
            this.OpenFolderLoc.Size = new System.Drawing.Size(742, 60);
            this.OpenFolderLoc.TabIndex = 10;
            this.OpenFolderLoc.Text = "Open Pattern Bank Folder";
            this.OpenFolderLoc.UseVisualStyleBackColor = true;
            this.OpenFolderLoc.Click += new System.EventHandler(this.OpenFolderLoc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "File Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.FileName);
            this.groupBox2.Controls.Add(this.PasteBtn);
            this.groupBox2.Controls.Add(this.OpenPatternBank);
            this.groupBox2.Controls.Add(this.OffsetTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(742, 198);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Insert Object To Map";
            // 
            // MainBG1
            // 
            this.MainBG1.ColumnCount = 1;
            this.MainBG1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainBG1.Controls.Add(this.MainBG2, 0, 0);
            this.MainBG1.Controls.Add(this.OpenFolderLoc, 0, 1);
            this.MainBG1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainBG1.Location = new System.Drawing.Point(0, 0);
            this.MainBG1.Name = "MainBG1";
            this.MainBG1.RowCount = 2;
            this.MainBG1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.13333F));
            this.MainBG1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.86667F));
            this.MainBG1.Size = new System.Drawing.Size(748, 474);
            this.MainBG1.TabIndex = 11;
            // 
            // MainBG2
            // 
            this.MainBG2.ColumnCount = 1;
            this.MainBG2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainBG2.Controls.Add(this.groupBox1, 0, 0);
            this.MainBG2.Controls.Add(this.groupBox2, 0, 1);
            this.MainBG2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainBG2.Location = new System.Drawing.Point(0, 0);
            this.MainBG2.Margin = new System.Windows.Forms.Padding(0);
            this.MainBG2.Name = "MainBG2";
            this.MainBG2.RowCount = 2;
            this.MainBG2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainBG2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainBG2.Size = new System.Drawing.Size(748, 408);
            this.MainBG2.TabIndex = 12;
            // 
            // PatternBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 474);
            this.Controls.Add(this.MainBG1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatternBank";
            this.Text = "SliderBankIntf";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.MainBG1.ResumeLayout(false);
            this.MainBG2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SavePattern;
        private System.Windows.Forms.Button OpenPatternBank;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label FileName;
        private System.Windows.Forms.TextBox OffsetTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PasteBtn;
        private System.Windows.Forms.Button OpenFolderLoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel MainBG1;
        private System.Windows.Forms.TableLayoutPanel MainBG2;
        private System.Windows.Forms.ListBox ObjList;
        private System.Windows.Forms.Button ObjClip;
        private System.Windows.Forms.Button ObjSelected;
    }
}