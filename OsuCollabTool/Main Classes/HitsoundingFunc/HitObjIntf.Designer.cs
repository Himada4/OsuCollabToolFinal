namespace OsuCollabTool.Main_Classes.HitsoundingFunc
{
    partial class HitObjIntf
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
            this.l7 = new System.Windows.Forms.Label();
            this.l6 = new System.Windows.Forms.Label();
            this.UntilTb = new System.Windows.Forms.TextBox();
            this.SelectFromTb = new System.Windows.Forms.TextBox();
            this.l5 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.MaxDurUntil = new System.Windows.Forms.Label();
            this.MaxDurStart = new System.Windows.Forms.Label();
            this.l8 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.GroupBox();
            this.SelectTimestampBox = new System.Windows.Forms.GroupBox();
            this.UntilTrackBar = new System.Windows.Forms.TrackBar();
            this.StartTrackBar = new System.Windows.Forms.TrackBar();
            this.l1 = new System.Windows.Forms.Label();
            this.ChangesBox = new System.Windows.Forms.GroupBox();
            this.l14 = new System.Windows.Forms.Label();
            this.l12 = new System.Windows.Forms.Label();
            this.additionalCombo = new System.Windows.Forms.ComboBox();
            this.l11 = new System.Windows.Forms.Label();
            this.sampleSetCombo = new System.Windows.Forms.ComboBox();
            this.l10 = new System.Windows.Forms.Label();
            this.l9 = new System.Windows.Forms.Label();
            this.changeSliderEnds = new System.Windows.Forms.CheckBox();
            this.changeSliderHeads = new System.Windows.Forms.CheckBox();
            this.changeSpinners = new System.Windows.Forms.CheckBox();
            this.changeHitCircles = new System.Windows.Forms.CheckBox();
            this.Selector = new System.Windows.Forms.GroupBox();
            this.Option1 = new System.Windows.Forms.CheckBox();
            this.Option3 = new System.Windows.Forms.CheckBox();
            this.Option2 = new System.Windows.Forms.CheckBox();
            this.ChangeHS = new System.Windows.Forms.Button();
            this.BG2 = new System.Windows.Forms.TableLayoutPanel();
            this.SelectSamplesetBox = new System.Windows.Forms.GroupBox();
            this.BG1 = new System.Windows.Forms.TableLayoutPanel();
            this.changeClap = new System.Windows.Forms.CheckBox();
            this.changeFinish = new System.Windows.Forms.CheckBox();
            this.changeWhistle = new System.Windows.Forms.CheckBox();
            this.selectClap = new System.Windows.Forms.CheckBox();
            this.selectFinish = new System.Windows.Forms.CheckBox();
            this.selectWhistle = new System.Windows.Forms.CheckBox();
            this.l15 = new System.Windows.Forms.Label();
            this.selectAdditional = new System.Windows.Forms.ComboBox();
            this.l13 = new System.Windows.Forms.Label();
            this.selectSampleset = new System.Windows.Forms.ComboBox();
            this.l2.SuspendLayout();
            this.SelectTimestampBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UntilTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartTrackBar)).BeginInit();
            this.ChangesBox.SuspendLayout();
            this.Selector.SuspendLayout();
            this.BG2.SuspendLayout();
            this.SelectSamplesetBox.SuspendLayout();
            this.BG1.SuspendLayout();
            this.SuspendLayout();
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
            this.l4.Location = new System.Drawing.Point(9, 83);
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
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(6, 16);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(99, 13);
            this.l1.TabIndex = 1;
            this.l1.Text = "Select objects with:";
            // 
            // ChangesBox
            // 
            this.ChangesBox.Controls.Add(this.changeClap);
            this.ChangesBox.Controls.Add(this.changeFinish);
            this.ChangesBox.Controls.Add(this.changeWhistle);
            this.ChangesBox.Controls.Add(this.l14);
            this.ChangesBox.Controls.Add(this.l12);
            this.ChangesBox.Controls.Add(this.additionalCombo);
            this.ChangesBox.Controls.Add(this.l11);
            this.ChangesBox.Controls.Add(this.sampleSetCombo);
            this.ChangesBox.Controls.Add(this.l10);
            this.ChangesBox.Controls.Add(this.l9);
            this.ChangesBox.Controls.Add(this.changeSliderEnds);
            this.ChangesBox.Controls.Add(this.changeSliderHeads);
            this.ChangesBox.Controls.Add(this.changeSpinners);
            this.ChangesBox.Controls.Add(this.changeHitCircles);
            this.ChangesBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangesBox.Location = new System.Drawing.Point(197, 3);
            this.ChangesBox.Name = "ChangesBox";
            this.ChangesBox.Size = new System.Drawing.Size(329, 151);
            this.ChangesBox.TabIndex = 1;
            this.ChangesBox.TabStop = false;
            this.ChangesBox.Text = "Make Changes By...";
            // 
            // l14
            // 
            this.l14.AutoSize = true;
            this.l14.Location = new System.Drawing.Point(234, 41);
            this.l14.Name = "l14";
            this.l14.Size = new System.Drawing.Size(52, 13);
            this.l14.TabIndex = 12;
            this.l14.Text = "Hitsound:";
            // 
            // l12
            // 
            this.l12.AutoSize = true;
            this.l12.Location = new System.Drawing.Point(137, 86);
            this.l12.Name = "l12";
            this.l12.Size = new System.Drawing.Size(56, 13);
            this.l12.TabIndex = 10;
            this.l12.Text = "Additional:";
            // 
            // additionalCombo
            // 
            this.additionalCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.additionalCombo.FormattingEnabled = true;
            this.additionalCombo.Location = new System.Drawing.Point(140, 104);
            this.additionalCombo.Name = "additionalCombo";
            this.additionalCombo.Size = new System.Drawing.Size(75, 21);
            this.additionalCombo.TabIndex = 9;
            // 
            // l11
            // 
            this.l11.AutoSize = true;
            this.l11.Location = new System.Drawing.Point(137, 41);
            this.l11.Name = "l11";
            this.l11.Size = new System.Drawing.Size(59, 13);
            this.l11.TabIndex = 8;
            this.l11.Text = "Sampleset:";
            // 
            // sampleSetCombo
            // 
            this.sampleSetCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sampleSetCombo.FormattingEnabled = true;
            this.sampleSetCombo.Location = new System.Drawing.Point(140, 58);
            this.sampleSetCombo.Name = "sampleSetCombo";
            this.sampleSetCombo.Size = new System.Drawing.Size(75, 21);
            this.sampleSetCombo.TabIndex = 7;
            // 
            // l10
            // 
            this.l10.AutoSize = true;
            this.l10.Location = new System.Drawing.Point(120, 20);
            this.l10.Name = "l10";
            this.l10.Size = new System.Drawing.Size(72, 13);
            this.l10.TabIndex = 6;
            this.l10.Text = "Replace with:";
            // 
            // l9
            // 
            this.l9.AutoSize = true;
            this.l9.Location = new System.Drawing.Point(6, 20);
            this.l9.Name = "l9";
            this.l9.Size = new System.Drawing.Size(47, 13);
            this.l9.TabIndex = 5;
            this.l9.Text = "Change:";
            // 
            // changeSliderEnds
            // 
            this.changeSliderEnds.AutoSize = true;
            this.changeSliderEnds.Location = new System.Drawing.Point(28, 104);
            this.changeSliderEnds.Name = "changeSliderEnds";
            this.changeSliderEnds.Size = new System.Drawing.Size(79, 17);
            this.changeSliderEnds.TabIndex = 4;
            this.changeSliderEnds.Text = "Slider Ends";
            this.changeSliderEnds.UseVisualStyleBackColor = true;
            // 
            // changeSliderHeads
            // 
            this.changeSliderHeads.AutoSize = true;
            this.changeSliderHeads.Location = new System.Drawing.Point(28, 82);
            this.changeSliderHeads.Name = "changeSliderHeads";
            this.changeSliderHeads.Size = new System.Drawing.Size(86, 17);
            this.changeSliderHeads.TabIndex = 3;
            this.changeSliderHeads.Text = "Slider Heads";
            this.changeSliderHeads.UseVisualStyleBackColor = true;
            // 
            // changeSpinners
            // 
            this.changeSpinners.AutoSize = true;
            this.changeSpinners.Location = new System.Drawing.Point(28, 59);
            this.changeSpinners.Name = "changeSpinners";
            this.changeSpinners.Size = new System.Drawing.Size(67, 17);
            this.changeSpinners.TabIndex = 2;
            this.changeSpinners.Text = "Spinners";
            this.changeSpinners.UseVisualStyleBackColor = true;
            // 
            // changeHitCircles
            // 
            this.changeHitCircles.AutoSize = true;
            this.changeHitCircles.Location = new System.Drawing.Point(28, 36);
            this.changeHitCircles.Name = "changeHitCircles";
            this.changeHitCircles.Size = new System.Drawing.Size(73, 17);
            this.changeHitCircles.TabIndex = 0;
            this.changeHitCircles.Text = "Hit Circles";
            this.changeHitCircles.UseVisualStyleBackColor = true;
            // 
            // Selector
            // 
            this.Selector.Controls.Add(this.Option1);
            this.Selector.Controls.Add(this.Option3);
            this.Selector.Controls.Add(this.Option2);
            this.Selector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Selector.Location = new System.Drawing.Point(3, 3);
            this.Selector.Name = "Selector";
            this.Selector.Size = new System.Drawing.Size(188, 151);
            this.Selector.TabIndex = 0;
            this.Selector.TabStop = false;
            this.Selector.Text = "Select Based On...";
            // 
            // Option1
            // 
            this.Option1.AutoSize = true;
            this.Option1.Location = new System.Drawing.Point(9, 36);
            this.Option1.Name = "Option1";
            this.Option1.Size = new System.Drawing.Size(106, 17);
            this.Option1.TabIndex = 5;
            this.Option1.Text = "Select all objects";
            this.Option1.UseVisualStyleBackColor = true;
            this.Option1.CheckedChanged += new System.EventHandler(this.BaseSelect);
            // 
            // Option3
            // 
            this.Option3.AutoSize = true;
            this.Option3.Location = new System.Drawing.Point(9, 108);
            this.Option3.Name = "Option3";
            this.Option3.Size = new System.Drawing.Size(153, 17);
            this.Option3.TabIndex = 4;
            this.Option3.Text = "Select based on timestamp";
            this.Option3.UseVisualStyleBackColor = true;
            this.Option3.CheckedChanged += new System.EventHandler(this.BaseSelect);
            // 
            // Option2
            // 
            this.Option2.AutoSize = true;
            this.Option2.Location = new System.Drawing.Point(9, 71);
            this.Option2.Name = "Option2";
            this.Option2.Size = new System.Drawing.Size(158, 17);
            this.Option2.TabIndex = 3;
            this.Option2.Text = "Select based on samplesets";
            this.Option2.UseVisualStyleBackColor = true;
            this.Option2.CheckedChanged += new System.EventHandler(this.BaseSelect);
            // 
            // ChangeHS
            // 
            this.ChangeHS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangeHS.FlatAppearance.BorderSize = 0;
            this.ChangeHS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeHS.Location = new System.Drawing.Point(3, 376);
            this.ChangeHS.Name = "ChangeHS";
            this.ChangeHS.Size = new System.Drawing.Size(742, 95);
            this.ChangeHS.TabIndex = 3;
            this.ChangeHS.Text = "Make Changes!";
            this.ChangeHS.UseVisualStyleBackColor = true;
            this.ChangeHS.Click += new System.EventHandler(this.ChangeHS_Click);
            // 
            // BG2
            // 
            this.BG2.ColumnCount = 3;
            this.BG2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.0929F));
            this.BG2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.94535F));
            this.BG2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.09836F));
            this.BG2.Controls.Add(this.Selector, 0, 0);
            this.BG2.Controls.Add(this.ChangesBox, 1, 0);
            this.BG2.Controls.Add(this.SelectSamplesetBox, 2, 0);
            this.BG2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BG2.Location = new System.Drawing.Point(0, 0);
            this.BG2.Margin = new System.Windows.Forms.Padding(0);
            this.BG2.Name = "BG2";
            this.BG2.RowCount = 1;
            this.BG2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BG2.Size = new System.Drawing.Size(748, 157);
            this.BG2.TabIndex = 0;
            // 
            // SelectSamplesetBox
            // 
            this.SelectSamplesetBox.Controls.Add(this.l15);
            this.SelectSamplesetBox.Controls.Add(this.selectAdditional);
            this.SelectSamplesetBox.Controls.Add(this.l13);
            this.SelectSamplesetBox.Controls.Add(this.selectSampleset);
            this.SelectSamplesetBox.Controls.Add(this.selectClap);
            this.SelectSamplesetBox.Controls.Add(this.selectFinish);
            this.SelectSamplesetBox.Controls.Add(this.selectWhistle);
            this.SelectSamplesetBox.Controls.Add(this.l1);
            this.SelectSamplesetBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectSamplesetBox.Location = new System.Drawing.Point(532, 3);
            this.SelectSamplesetBox.Name = "SelectSamplesetBox";
            this.SelectSamplesetBox.Size = new System.Drawing.Size(213, 151);
            this.SelectSamplesetBox.TabIndex = 2;
            this.SelectSamplesetBox.TabStop = false;
            this.SelectSamplesetBox.Text = "Select Based On Sampleset";
            // 
            // BG1
            // 
            this.BG1.ColumnCount = 1;
            this.BG1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BG1.Controls.Add(this.ChangeHS, 0, 2);
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
            this.BG1.TabIndex = 1;
            // 
            // changeClap
            // 
            this.changeClap.AutoSize = true;
            this.changeClap.Location = new System.Drawing.Point(237, 108);
            this.changeClap.Name = "changeClap";
            this.changeClap.Size = new System.Drawing.Size(47, 17);
            this.changeClap.TabIndex = 15;
            this.changeClap.Text = "Clap";
            this.changeClap.UseVisualStyleBackColor = true;
            // 
            // changeFinish
            // 
            this.changeFinish.AutoSize = true;
            this.changeFinish.Location = new System.Drawing.Point(237, 86);
            this.changeFinish.Name = "changeFinish";
            this.changeFinish.Size = new System.Drawing.Size(53, 17);
            this.changeFinish.TabIndex = 14;
            this.changeFinish.Text = "Finish";
            this.changeFinish.UseVisualStyleBackColor = true;
            // 
            // changeWhistle
            // 
            this.changeWhistle.AutoSize = true;
            this.changeWhistle.Location = new System.Drawing.Point(237, 63);
            this.changeWhistle.Name = "changeWhistle";
            this.changeWhistle.Size = new System.Drawing.Size(61, 17);
            this.changeWhistle.TabIndex = 13;
            this.changeWhistle.Text = "Whistle";
            this.changeWhistle.UseVisualStyleBackColor = true;
            // 
            // selectClap
            // 
            this.selectClap.AutoSize = true;
            this.selectClap.Location = new System.Drawing.Point(130, 101);
            this.selectClap.Name = "selectClap";
            this.selectClap.Size = new System.Drawing.Size(47, 17);
            this.selectClap.TabIndex = 18;
            this.selectClap.Text = "Clap";
            this.selectClap.UseVisualStyleBackColor = true;
            // 
            // selectFinish
            // 
            this.selectFinish.AutoSize = true;
            this.selectFinish.Location = new System.Drawing.Point(130, 79);
            this.selectFinish.Name = "selectFinish";
            this.selectFinish.Size = new System.Drawing.Size(53, 17);
            this.selectFinish.TabIndex = 17;
            this.selectFinish.Text = "Finish";
            this.selectFinish.UseVisualStyleBackColor = true;
            // 
            // selectWhistle
            // 
            this.selectWhistle.AutoSize = true;
            this.selectWhistle.Location = new System.Drawing.Point(130, 56);
            this.selectWhistle.Name = "selectWhistle";
            this.selectWhistle.Size = new System.Drawing.Size(61, 17);
            this.selectWhistle.TabIndex = 16;
            this.selectWhistle.Text = "Whistle";
            this.selectWhistle.UseVisualStyleBackColor = true;
            // 
            // l15
            // 
            this.l15.AutoSize = true;
            this.l15.Location = new System.Drawing.Point(14, 82);
            this.l15.Name = "l15";
            this.l15.Size = new System.Drawing.Size(56, 13);
            this.l15.TabIndex = 22;
            this.l15.Text = "Additional:";
            // 
            // selectAdditional
            // 
            this.selectAdditional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectAdditional.FormattingEnabled = true;
            this.selectAdditional.Location = new System.Drawing.Point(17, 100);
            this.selectAdditional.Name = "selectAdditional";
            this.selectAdditional.Size = new System.Drawing.Size(75, 21);
            this.selectAdditional.TabIndex = 21;
            // 
            // l13
            // 
            this.l13.AutoSize = true;
            this.l13.Location = new System.Drawing.Point(14, 37);
            this.l13.Name = "l13";
            this.l13.Size = new System.Drawing.Size(59, 13);
            this.l13.TabIndex = 20;
            this.l13.Text = "Sampleset:";
            // 
            // selectSampleset
            // 
            this.selectSampleset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectSampleset.FormattingEnabled = true;
            this.selectSampleset.Location = new System.Drawing.Point(17, 54);
            this.selectSampleset.Name = "selectSampleset";
            this.selectSampleset.Size = new System.Drawing.Size(75, 21);
            this.selectSampleset.TabIndex = 19;
            // 
            // HitObjIntf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 474);
            this.Controls.Add(this.BG1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HitObjIntf";
            this.Text = "HitObjIntf";
            this.l2.ResumeLayout(false);
            this.l2.PerformLayout();
            this.SelectTimestampBox.ResumeLayout(false);
            this.SelectTimestampBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UntilTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartTrackBar)).EndInit();
            this.ChangesBox.ResumeLayout(false);
            this.ChangesBox.PerformLayout();
            this.Selector.ResumeLayout(false);
            this.Selector.PerformLayout();
            this.BG2.ResumeLayout(false);
            this.SelectSamplesetBox.ResumeLayout(false);
            this.SelectSamplesetBox.PerformLayout();
            this.BG1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip trackNum;
        private System.Windows.Forms.Label l7;
        private System.Windows.Forms.Label l6;
        private System.Windows.Forms.TextBox UntilTb;
        private System.Windows.Forms.TextBox SelectFromTb;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label MaxDurUntil;
        private System.Windows.Forms.Label MaxDurStart;
        private System.Windows.Forms.Label l8;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.GroupBox l2;
        private System.Windows.Forms.GroupBox SelectTimestampBox;
        private System.Windows.Forms.TrackBar UntilTrackBar;
        private System.Windows.Forms.TrackBar StartTrackBar;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.GroupBox ChangesBox;
        private System.Windows.Forms.GroupBox Selector;
        private System.Windows.Forms.Button ChangeHS;
        private System.Windows.Forms.TableLayoutPanel BG2;
        private System.Windows.Forms.GroupBox SelectSamplesetBox;
        private System.Windows.Forms.TableLayoutPanel BG1;
        private System.Windows.Forms.CheckBox Option3;
        private System.Windows.Forms.CheckBox Option2;
        private System.Windows.Forms.Label l12;
        private System.Windows.Forms.ComboBox additionalCombo;
        private System.Windows.Forms.Label l11;
        private System.Windows.Forms.ComboBox sampleSetCombo;
        private System.Windows.Forms.Label l10;
        private System.Windows.Forms.Label l9;
        private System.Windows.Forms.CheckBox changeSliderEnds;
        private System.Windows.Forms.CheckBox changeSliderHeads;
        private System.Windows.Forms.CheckBox changeSpinners;
        private System.Windows.Forms.CheckBox changeHitCircles;
        private System.Windows.Forms.CheckBox Option1;
        private System.Windows.Forms.Label l14;
        private System.Windows.Forms.CheckBox changeClap;
        private System.Windows.Forms.CheckBox changeFinish;
        private System.Windows.Forms.CheckBox changeWhistle;
        private System.Windows.Forms.CheckBox selectClap;
        private System.Windows.Forms.CheckBox selectFinish;
        private System.Windows.Forms.CheckBox selectWhistle;
        private System.Windows.Forms.Label l15;
        private System.Windows.Forms.ComboBox selectAdditional;
        private System.Windows.Forms.Label l13;
        private System.Windows.Forms.ComboBox selectSampleset;
    }
}