namespace OsuCollabTool.Main_Classes.SongSetupFunc
{
    partial class MapSetupIntf
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.MetadataTabBtn = new System.Windows.Forms.Button();
            this.DifficultyTabBtn = new System.Windows.Forms.Button();
            this.GeneralTabBtn = new System.Windows.Forms.Button();
            this.MainIntfBG = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MainIntfBG, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(748, 474);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.MetadataTabBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.DifficultyTabBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.GeneralTabBtn, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(748, 99);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // MetadataTabBtn
            // 
            this.MetadataTabBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MetadataTabBtn.FlatAppearance.BorderSize = 0;
            this.MetadataTabBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MetadataTabBtn.Location = new System.Drawing.Point(249, 0);
            this.MetadataTabBtn.Margin = new System.Windows.Forms.Padding(0);
            this.MetadataTabBtn.Name = "MetadataTabBtn";
            this.MetadataTabBtn.Size = new System.Drawing.Size(249, 99);
            this.MetadataTabBtn.TabIndex = 2;
            this.MetadataTabBtn.Text = "Metadata";
            this.MetadataTabBtn.UseVisualStyleBackColor = true;
            this.MetadataTabBtn.Click += new System.EventHandler(this.MetadataTabBtn_Click);
            // 
            // DifficultyTabBtn
            // 
            this.DifficultyTabBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DifficultyTabBtn.FlatAppearance.BorderSize = 0;
            this.DifficultyTabBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DifficultyTabBtn.Location = new System.Drawing.Point(498, 0);
            this.DifficultyTabBtn.Margin = new System.Windows.Forms.Padding(0);
            this.DifficultyTabBtn.Name = "DifficultyTabBtn";
            this.DifficultyTabBtn.Size = new System.Drawing.Size(250, 99);
            this.DifficultyTabBtn.TabIndex = 1;
            this.DifficultyTabBtn.Text = "Difficulty";
            this.DifficultyTabBtn.UseVisualStyleBackColor = true;
            this.DifficultyTabBtn.Click += new System.EventHandler(this.DifficultyTabBtn_Click);
            // 
            // GeneralTabBtn
            // 
            this.GeneralTabBtn.BackColor = System.Drawing.SystemColors.Control;
            this.GeneralTabBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeneralTabBtn.FlatAppearance.BorderSize = 0;
            this.GeneralTabBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GeneralTabBtn.Location = new System.Drawing.Point(0, 0);
            this.GeneralTabBtn.Margin = new System.Windows.Forms.Padding(0);
            this.GeneralTabBtn.Name = "GeneralTabBtn";
            this.GeneralTabBtn.Size = new System.Drawing.Size(249, 99);
            this.GeneralTabBtn.TabIndex = 0;
            this.GeneralTabBtn.Text = "General";
            this.GeneralTabBtn.UseVisualStyleBackColor = false;
            this.GeneralTabBtn.Click += new System.EventHandler(this.GeneralTabBtn_Click);
            // 
            // MainIntfBG
            // 
            this.MainIntfBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainIntfBG.Location = new System.Drawing.Point(0, 99);
            this.MainIntfBG.Margin = new System.Windows.Forms.Padding(0);
            this.MainIntfBG.Name = "MainIntfBG";
            this.MainIntfBG.Size = new System.Drawing.Size(748, 375);
            this.MainIntfBG.TabIndex = 1;
            // 
            // MapSetupIntf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(748, 474);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MapSetupIntf";
            this.Text = "MapSetupIntf";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button DifficultyTabBtn;
        private System.Windows.Forms.Button GeneralTabBtn;
        private System.Windows.Forms.Button MetadataTabBtn;
        private System.Windows.Forms.Panel MainIntfBG;
    }
}