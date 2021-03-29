namespace OsuCollabTool
{
    partial class MainInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainInterface));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FormBorder = new System.Windows.Forms.TableLayoutPanel();
            this.ProjectLabel = new System.Windows.Forms.Label();
            this.CloseApp = new System.Windows.Forms.Button();
            this.Pref = new System.Windows.Forms.Button();
            this.Mini = new System.Windows.Forms.Button();
            this.MainIntPanel = new System.Windows.Forms.Panel();
            this.MainIntBG = new System.Windows.Forms.Panel();
            this.MainScrMenu = new System.Windows.Forms.MenuStrip();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Backup = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.FormBorder.SuspendLayout();
            this.MainIntPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.FormBorder, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MainIntPanel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.606526F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.39347F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(748, 521);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FormBorder
            // 
            this.FormBorder.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorder.ColumnCount = 6;
            this.FormBorder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.09898F));
            this.FormBorder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.54989F));
            this.FormBorder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.83778F));
            this.FormBorder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.83778F));
            this.FormBorder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.83778F));
            this.FormBorder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.83778F));
            this.FormBorder.Controls.Add(this.ProjectLabel, 0, 0);
            this.FormBorder.Controls.Add(this.CloseApp, 5, 0);
            this.FormBorder.Controls.Add(this.Mini, 4, 0);
            this.FormBorder.Controls.Add(this.Pref, 3, 0);
            this.FormBorder.Controls.Add(this.Backup, 2, 0);
            this.FormBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormBorder.Location = new System.Drawing.Point(0, 0);
            this.FormBorder.Margin = new System.Windows.Forms.Padding(0);
            this.FormBorder.Name = "FormBorder";
            this.FormBorder.RowCount = 1;
            this.FormBorder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FormBorder.Size = new System.Drawing.Size(748, 23);
            this.FormBorder.TabIndex = 0;
            // 
            // ProjectLabel
            // 
            this.ProjectLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectLabel.AutoSize = true;
            this.ProjectLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProjectLabel.Location = new System.Drawing.Point(3, 5);
            this.ProjectLabel.Name = "ProjectLabel";
            this.ProjectLabel.Size = new System.Drawing.Size(151, 13);
            this.ProjectLabel.TabIndex = 0;
            this.ProjectLabel.Text = "OsuCollabTool";
            // 
            // CloseApp
            // 
            this.CloseApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseApp.FlatAppearance.BorderSize = 0;
            this.CloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseApp.Image = ((System.Drawing.Image)(resources.GetObject("CloseApp.Image")));
            this.CloseApp.Location = new System.Drawing.Point(656, 0);
            this.CloseApp.Margin = new System.Windows.Forms.Padding(0);
            this.CloseApp.Name = "CloseApp";
            this.CloseApp.Size = new System.Drawing.Size(92, 23);
            this.CloseApp.TabIndex = 1;
            this.toolTip1.SetToolTip(this.CloseApp, "Close");
            this.CloseApp.UseVisualStyleBackColor = true;
            this.CloseApp.Click += new System.EventHandler(this.CloseApp_Click);
            this.CloseApp.MouseEnter += new System.EventHandler(this.CloseApp_MouseEnter);
            this.CloseApp.MouseLeave += new System.EventHandler(this.CloseApp_MouseLeave);
            // 
            // Pref
            // 
            this.Pref.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pref.FlatAppearance.BorderSize = 0;
            this.Pref.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pref.Image = ((System.Drawing.Image)(resources.GetObject("Pref.Image")));
            this.Pref.Location = new System.Drawing.Point(480, 0);
            this.Pref.Margin = new System.Windows.Forms.Padding(0);
            this.Pref.Name = "Pref";
            this.Pref.Size = new System.Drawing.Size(88, 23);
            this.Pref.TabIndex = 2;
            this.toolTip1.SetToolTip(this.Pref, "Preferences...");
            this.Pref.UseVisualStyleBackColor = true;
            this.Pref.Click += new System.EventHandler(this.Pref_Click);
            // 
            // Mini
            // 
            this.Mini.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mini.FlatAppearance.BorderSize = 0;
            this.Mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mini.Image = ((System.Drawing.Image)(resources.GetObject("Mini.Image")));
            this.Mini.Location = new System.Drawing.Point(568, 0);
            this.Mini.Margin = new System.Windows.Forms.Padding(0);
            this.Mini.Name = "Mini";
            this.Mini.Size = new System.Drawing.Size(88, 23);
            this.Mini.TabIndex = 3;
            this.toolTip1.SetToolTip(this.Mini, "Minimise");
            this.Mini.UseVisualStyleBackColor = true;
            this.Mini.Click += new System.EventHandler(this.Mini_Click);
            // 
            // MainIntPanel
            // 
            this.MainIntPanel.Controls.Add(this.MainIntBG);
            this.MainIntPanel.Controls.Add(this.MainScrMenu);
            this.MainIntPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainIntPanel.Location = new System.Drawing.Point(0, 23);
            this.MainIntPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainIntPanel.Name = "MainIntPanel";
            this.MainIntPanel.Size = new System.Drawing.Size(748, 498);
            this.MainIntPanel.TabIndex = 1;
            // 
            // MainIntBG
            // 
            this.MainIntBG.BackColor = System.Drawing.SystemColors.Control;
            this.MainIntBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainIntBG.Location = new System.Drawing.Point(0, 24);
            this.MainIntBG.Margin = new System.Windows.Forms.Padding(0);
            this.MainIntBG.Name = "MainIntBG";
            this.MainIntBG.Size = new System.Drawing.Size(748, 474);
            this.MainIntBG.TabIndex = 1;
            // 
            // MainScrMenu
            // 
            this.MainScrMenu.Location = new System.Drawing.Point(0, 0);
            this.MainScrMenu.Name = "MainScrMenu";
            this.MainScrMenu.Size = new System.Drawing.Size(748, 24);
            this.MainScrMenu.TabIndex = 0;
            this.MainScrMenu.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Backup
            // 
            this.Backup.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Backup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Backup.FlatAppearance.BorderSize = 0;
            this.Backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backup.Image = ((System.Drawing.Image)(resources.GetObject("Backup.Image")));
            this.Backup.Location = new System.Drawing.Point(392, 0);
            this.Backup.Margin = new System.Windows.Forms.Padding(0);
            this.Backup.Name = "Backup";
            this.Backup.Size = new System.Drawing.Size(88, 23);
            this.Backup.TabIndex = 4;
            this.toolTip1.SetToolTip(this.Backup, "Backup Mapset...");
            this.Backup.UseVisualStyleBackColor = false;
            this.Backup.Click += new System.EventHandler(this.Backup_Click);
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 521);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.MainScrMenu;
            this.Name = "MainInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.FormBorder.ResumeLayout(false);
            this.FormBorder.PerformLayout();
            this.MainIntPanel.ResumeLayout(false);
            this.MainIntPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel FormBorder;
        private System.Windows.Forms.Label ProjectLabel;
        private System.Windows.Forms.Button CloseApp;
        private System.Windows.Forms.Button Pref;
        private System.Windows.Forms.Button Mini;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel MainIntPanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip MainScrMenu;
        private System.Windows.Forms.Panel MainIntBG;
        private System.Windows.Forms.Button Backup;
    }
}

