namespace OsuCollabTool.Main_Classes.MergerFunc
{
    partial class MergeIntf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MergeIntf));
            this.l1 = new System.Windows.Forms.Label();
            this.MainIntf = new System.Windows.Forms.Panel();
            this.t1 = new System.Windows.Forms.TableLayoutPanel();
            this.t2 = new System.Windows.Forms.TableLayoutPanel();
            this.l2 = new System.Windows.Forms.Label();
            this.t3 = new System.Windows.Forms.TableLayoutPanel();
            this.t4 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FromFolder = new System.Windows.Forms.ListBox();
            this.ToMerge = new System.Windows.Forms.ListBox();
            this.MergeButton = new System.Windows.Forms.Button();
            this.MainIntf.SuspendLayout();
            this.t1.SuspendLayout();
            this.t2.SuspendLayout();
            this.t3.SuspendLayout();
            this.t4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l1.Location = new System.Drawing.Point(3, 0);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(368, 109);
            this.l1.TabIndex = 0;
            this.l1.Text = ".Osu from folder";
            this.l1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainIntf
            // 
            this.MainIntf.Controls.Add(this.t1);
            this.MainIntf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainIntf.Location = new System.Drawing.Point(0, 0);
            this.MainIntf.Name = "MainIntf";
            this.MainIntf.Size = new System.Drawing.Size(748, 474);
            this.MainIntf.TabIndex = 1;
            // 
            // t1
            // 
            this.t1.ColumnCount = 1;
            this.t1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.t1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.t1.Controls.Add(this.t2, 0, 0);
            this.t1.Controls.Add(this.t3, 0, 1);
            this.t1.Controls.Add(this.MergeButton, 0, 2);
            this.t1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t1.Location = new System.Drawing.Point(0, 0);
            this.t1.Margin = new System.Windows.Forms.Padding(0);
            this.t1.Name = "t1";
            this.t1.RowCount = 3;
            this.t1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.99578F));
            this.t1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.53165F));
            this.t1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.2616F));
            this.t1.Size = new System.Drawing.Size(748, 474);
            this.t1.TabIndex = 0;
            // 
            // t2
            // 
            this.t2.ColumnCount = 2;
            this.t2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.t2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.t2.Controls.Add(this.l2, 1, 0);
            this.t2.Controls.Add(this.l1, 0, 0);
            this.t2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t2.Location = new System.Drawing.Point(0, 0);
            this.t2.Margin = new System.Windows.Forms.Padding(0);
            this.t2.Name = "t2";
            this.t2.RowCount = 1;
            this.t2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.t2.Size = new System.Drawing.Size(748, 109);
            this.t2.TabIndex = 0;
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l2.Location = new System.Drawing.Point(377, 0);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(368, 109);
            this.l2.TabIndex = 1;
            this.l2.Text = "Files to merge";
            this.l2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t3
            // 
            this.t3.ColumnCount = 3;
            this.t3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.80287F));
            this.t3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.39427F));
            this.t3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.80287F));
            this.t3.Controls.Add(this.ToMerge, 2, 0);
            this.t3.Controls.Add(this.t4, 1, 0);
            this.t3.Controls.Add(this.FromFolder, 0, 0);
            this.t3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t3.Location = new System.Drawing.Point(0, 109);
            this.t3.Margin = new System.Windows.Forms.Padding(0);
            this.t3.Name = "t3";
            this.t3.RowCount = 1;
            this.t3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.t3.Size = new System.Drawing.Size(748, 249);
            this.t3.TabIndex = 1;
            // 
            // t4
            // 
            this.t4.ColumnCount = 1;
            this.t4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.t4.Controls.Add(this.pictureBox1, 0, 1);
            this.t4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t4.Location = new System.Drawing.Point(335, 0);
            this.t4.Margin = new System.Windows.Forms.Padding(0);
            this.t4.Name = "t4";
            this.t4.RowCount = 3;
            this.t4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.t4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.t4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.t4.Size = new System.Drawing.Size(77, 249);
            this.t4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(0, 83);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 83);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FromFolder
            // 
            this.FromFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FromFolder.FormattingEnabled = true;
            this.FromFolder.Location = new System.Drawing.Point(3, 3);
            this.FromFolder.Name = "FromFolder";
            this.FromFolder.Size = new System.Drawing.Size(329, 243);
            this.FromFolder.TabIndex = 1;
            this.FromFolder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FromFolder_MouseDown);
            // 
            // ToMerge
            // 
            this.ToMerge.AllowDrop = true;
            this.ToMerge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToMerge.FormattingEnabled = true;
            this.ToMerge.Location = new System.Drawing.Point(415, 3);
            this.ToMerge.Name = "ToMerge";
            this.ToMerge.Size = new System.Drawing.Size(330, 243);
            this.ToMerge.TabIndex = 2;
            this.ToMerge.DragDrop += new System.Windows.Forms.DragEventHandler(this.ToMerge_DragDrop);
            this.ToMerge.DragEnter += new System.Windows.Forms.DragEventHandler(this.ToMerge_DragEnter);
            // 
            // MergeButton
            // 
            this.MergeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MergeButton.FlatAppearance.BorderSize = 0;
            this.MergeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MergeButton.Location = new System.Drawing.Point(3, 361);
            this.MergeButton.Name = "MergeButton";
            this.MergeButton.Size = new System.Drawing.Size(742, 110);
            this.MergeButton.TabIndex = 2;
            this.MergeButton.Text = "Merge!";
            this.MergeButton.UseVisualStyleBackColor = true;
            this.MergeButton.Click += new System.EventHandler(this.MergeButton_Click);
            // 
            // MergeIntf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 474);
            this.Controls.Add(this.MainIntf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MergeIntf";
            this.Text = "MergeIntf";
            this.MainIntf.ResumeLayout(false);
            this.t1.ResumeLayout(false);
            this.t2.ResumeLayout(false);
            this.t2.PerformLayout();
            this.t3.ResumeLayout(false);
            this.t4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Panel MainIntf;
        private System.Windows.Forms.TableLayoutPanel t1;
        private System.Windows.Forms.TableLayoutPanel t2;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.TableLayoutPanel t3;
        private System.Windows.Forms.TableLayoutPanel t4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox ToMerge;
        private System.Windows.Forms.ListBox FromFolder;
        private System.Windows.Forms.Button MergeButton;
    }
}