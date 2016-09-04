namespace Idojos2
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.DataTabPage = new System.Windows.Forms.TabPage();
            this.DateGridView = new System.Windows.Forms.DataGridView();
            this.dat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PreviewPictureBox = new System.Windows.Forms.PictureBox();
            this.SecondRadioButton = new System.Windows.Forms.RadioButton();
            this.FirstRadioButton = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.SaveFolderBrowseButton = new System.Windows.Forms.Button();
            this.SaveFolderTextBox = new System.Windows.Forms.TextBox();
            this.SaveFolderLabel = new System.Windows.Forms.Label();
            this.BackgroundBrowseButton = new System.Windows.Forms.Button();
            this.BackgroundTextBox = new System.Windows.Forms.TextBox();
            this.Backgroundlabel = new System.Windows.Forms.Label();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.AddressToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.AddressToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.AddressToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.WebBrowser = new System.Windows.Forms.WebBrowser();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.BrowserToolStrip = new System.Windows.Forms.ToolStrip();
            this.BrowserToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MakeImageToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveToFileToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.TabControl.SuspendLayout();
            this.DataTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DateGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPictureBox)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            this.BrowserToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.DataTabPage);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Location = new System.Drawing.Point(3, 3);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(362, 449);
            this.TabControl.TabIndex = 1;
            // 
            // DataTabPage
            // 
            this.DataTabPage.Controls.Add(this.DateGridView);
            this.DataTabPage.Location = new System.Drawing.Point(4, 22);
            this.DataTabPage.Name = "DataTabPage";
            this.DataTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DataTabPage.Size = new System.Drawing.Size(354, 423);
            this.DataTabPage.TabIndex = 0;
            this.DataTabPage.Text = "Adatok";
            this.DataTabPage.UseVisualStyleBackColor = true;
            // 
            // DateGridView
            // 
            this.DateGridView.AllowUserToAddRows = false;
            this.DateGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DateGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dat,
            this.min,
            this.max,
            this.dataGridViewImageColumn});
            this.DateGridView.Location = new System.Drawing.Point(6, 6);
            this.DateGridView.Name = "DateGridView";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DateGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DateGridView.Size = new System.Drawing.Size(342, 411);
            this.DateGridView.TabIndex = 1;
            this.DateGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.idk_CellContentClick);
            this.DateGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.idk_CellEndEdit);
            // 
            // dat
            // 
            this.dat.HeaderText = "Dátum";
            this.dat.Name = "dat";
            // 
            // min
            // 
            this.min.HeaderText = "Minimum";
            this.min.Name = "min";
            // 
            // max
            // 
            this.max.HeaderText = "Maximum";
            this.max.Name = "max";
            // 
            // dataGridViewImageColumn
            // 
            this.dataGridViewImageColumn.HeaderText = "Típus";
            this.dataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn.Name = "dataGridViewImageColumn";
            this.dataGridViewImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PreviewPictureBox);
            this.tabPage2.Controls.Add(this.SecondRadioButton);
            this.tabPage2.Controls.Add(this.FirstRadioButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(354, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Előnézet";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PreviewPictureBox
            // 
            this.PreviewPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewPictureBox.Location = new System.Drawing.Point(6, 6);
            this.PreviewPictureBox.Name = "PreviewPictureBox";
            this.PreviewPictureBox.Size = new System.Drawing.Size(486, 400);
            this.PreviewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PreviewPictureBox.TabIndex = 4;
            this.PreviewPictureBox.TabStop = false;
            // 
            // SecondRadioButton
            // 
            this.SecondRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SecondRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.SecondRadioButton.AutoSize = true;
            this.SecondRadioButton.Location = new System.Drawing.Point(44, 412);
            this.SecondRadioButton.Name = "SecondRadioButton";
            this.SecondRadioButton.Size = new System.Drawing.Size(23, 23);
            this.SecondRadioButton.TabIndex = 3;
            this.SecondRadioButton.Text = "2";
            this.SecondRadioButton.UseVisualStyleBackColor = true;
            this.SecondRadioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // FirstRadioButton
            // 
            this.FirstRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FirstRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.FirstRadioButton.AutoSize = true;
            this.FirstRadioButton.Checked = true;
            this.FirstRadioButton.Location = new System.Drawing.Point(15, 412);
            this.FirstRadioButton.Name = "FirstRadioButton";
            this.FirstRadioButton.Size = new System.Drawing.Size(23, 23);
            this.FirstRadioButton.TabIndex = 2;
            this.FirstRadioButton.TabStop = true;
            this.FirstRadioButton.Text = "1";
            this.FirstRadioButton.UseVisualStyleBackColor = true;
            this.FirstRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.SaveFolderBrowseButton);
            this.tabPage3.Controls.Add(this.SaveFolderTextBox);
            this.tabPage3.Controls.Add(this.SaveFolderLabel);
            this.tabPage3.Controls.Add(this.BackgroundBrowseButton);
            this.tabPage3.Controls.Add(this.BackgroundTextBox);
            this.tabPage3.Controls.Add(this.Backgroundlabel);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(354, 423);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Beállítás és mentés";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // SaveFolderBrowseButton
            // 
            this.SaveFolderBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveFolderBrowseButton.Location = new System.Drawing.Point(172, 125);
            this.SaveFolderBrowseButton.Name = "SaveFolderBrowseButton";
            this.SaveFolderBrowseButton.Size = new System.Drawing.Size(101, 20);
            this.SaveFolderBrowseButton.TabIndex = 10;
            this.SaveFolderBrowseButton.Text = "Tallózás...";
            this.SaveFolderBrowseButton.UseVisualStyleBackColor = true;
            this.SaveFolderBrowseButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // SaveFolderTextBox
            // 
            this.SaveFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveFolderTextBox.Location = new System.Drawing.Point(15, 123);
            this.SaveFolderTextBox.Name = "SaveFolderTextBox";
            this.SaveFolderTextBox.Size = new System.Drawing.Size(151, 22);
            this.SaveFolderTextBox.TabIndex = 9;
            this.SaveFolderTextBox.TextChanged += new System.EventHandler(this.fdr_TextChanged);
            // 
            // SaveFolderLabel
            // 
            this.SaveFolderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveFolderLabel.AutoSize = true;
            this.SaveFolderLabel.Location = new System.Drawing.Point(12, 107);
            this.SaveFolderLabel.Name = "SaveFolderLabel";
            this.SaveFolderLabel.Size = new System.Drawing.Size(159, 13);
            this.SaveFolderLabel.TabIndex = 8;
            this.SaveFolderLabel.Text = "Időjárás-képek mentési helye:";
            // 
            // BackgroundBrowseButton
            // 
            this.BackgroundBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BackgroundBrowseButton.Location = new System.Drawing.Point(172, 78);
            this.BackgroundBrowseButton.Name = "BackgroundBrowseButton";
            this.BackgroundBrowseButton.Size = new System.Drawing.Size(101, 20);
            this.BackgroundBrowseButton.TabIndex = 7;
            this.BackgroundBrowseButton.Text = "Tallózás...";
            this.BackgroundBrowseButton.UseVisualStyleBackColor = true;
            this.BackgroundBrowseButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // BackgroundTextBox
            // 
            this.BackgroundTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackgroundTextBox.Location = new System.Drawing.Point(15, 78);
            this.BackgroundTextBox.Name = "BackgroundTextBox";
            this.BackgroundTextBox.Size = new System.Drawing.Size(151, 22);
            this.BackgroundTextBox.TabIndex = 6;
            this.BackgroundTextBox.TextChanged += new System.EventHandler(this.hk_TextChanged_1);
            // 
            // Backgroundlabel
            // 
            this.Backgroundlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Backgroundlabel.AutoSize = true;
            this.Backgroundlabel.Location = new System.Drawing.Point(12, 62);
            this.Backgroundlabel.Name = "Backgroundlabel";
            this.Backgroundlabel.Size = new System.Drawing.Size(61, 13);
            this.Backgroundlabel.TabIndex = 5;
            this.Backgroundlabel.Text = "Háttérkép:";
            // 
            // SplitContainer
            // 
            this.SplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SplitContainer.Location = new System.Drawing.Point(0, 28);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.TabControl);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.ToolStrip);
            this.SplitContainer.Panel2.Controls.Add(this.WebBrowser);
            this.SplitContainer.Size = new System.Drawing.Size(748, 464);
            this.SplitContainer.SplitterDistance = 368;
            this.SplitContainer.TabIndex = 2;
            // 
            // ToolStrip
            // 
            this.ToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToolStrip.AutoSize = false;
            this.ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddressToolStripLabel,
            this.AddressToolStripTextBox,
            this.AddressToolStripButton});
            this.ToolStrip.Location = new System.Drawing.Point(0, 3);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolStrip.Size = new System.Drawing.Size(715, 25);
            this.ToolStrip.TabIndex = 2;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // AddressToolStripLabel
            // 
            this.AddressToolStripLabel.Name = "AddressToolStripLabel";
            this.AddressToolStripLabel.Size = new System.Drawing.Size(32, 22);
            this.AddressToolStripLabel.Text = "Cím:";
            // 
            // AddressToolStripTextBox
            // 
            this.AddressToolStripTextBox.AutoSize = false;
            this.AddressToolStripTextBox.Name = "AddressToolStripTextBox";
            this.AddressToolStripTextBox.Size = new System.Drawing.Size(300, 25);
            this.AddressToolStripTextBox.Click += new System.EventHandler(this.laun_Click);
            // 
            // AddressToolStripButton
            // 
            this.AddressToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddressToolStripButton.Image = global::InfraWeatherMaker.Properties.Resources.run;
            this.AddressToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddressToolStripButton.Name = "AddressToolStripButton";
            this.AddressToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.AddressToolStripButton.Text = "Indítás";
            this.AddressToolStripButton.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // WebBrowser
            // 
            this.WebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebBrowser.Location = new System.Drawing.Point(0, 31);
            this.WebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowser.Name = "WebBrowser";
            this.WebBrowser.Size = new System.Drawing.Size(373, 430);
            this.WebBrowser.TabIndex = 0;
            this.WebBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.wb1_Navigated);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(54, 22);
            this.toolStripLabel1.Text = "Böngésző";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabel2.Text = "Cím:";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(300, 25);
            // 
            // BrowserToolStrip
            // 
            this.BrowserToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            this.BrowserToolStrip.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BrowserToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.BrowserToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BrowserToolStripButton,
            this.toolStripSeparator3,
            this.MakeImageToolStripButton,
            this.toolStripSeparator4,
            this.SaveToFileToolStripButton,
            this.toolStripSeparator5,
            this.AboutToolStripButton});
            this.BrowserToolStrip.Location = new System.Drawing.Point(0, 0);
            this.BrowserToolStrip.Name = "BrowserToolStrip";
            this.BrowserToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.BrowserToolStrip.Size = new System.Drawing.Size(748, 31);
            this.BrowserToolStrip.TabIndex = 3;
            this.BrowserToolStrip.Text = "BrowserToolStrip";
            // 
            // BrowserToolStripButton
            // 
            this.BrowserToolStripButton.Image = global::InfraWeatherMaker.Properties.Resources.net;
            this.BrowserToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BrowserToolStripButton.Name = "BrowserToolStripButton";
            this.BrowserToolStripButton.Size = new System.Drawing.Size(81, 28);
            this.BrowserToolStripButton.Text = "Böngésző";
            this.BrowserToolStripButton.Visible = false;
            this.BrowserToolStripButton.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // MakeImageToolStripButton
            // 
            this.MakeImageToolStripButton.Image = global::InfraWeatherMaker.Properties.Resources.modify;
            this.MakeImageToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MakeImageToolStripButton.Name = "MakeImageToolStripButton";
            this.MakeImageToolStripButton.Size = new System.Drawing.Size(87, 28);
            this.MakeImageToolStripButton.Text = "Képalkotás";
            this.MakeImageToolStripButton.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // SaveToFileToolStripButton
            // 
            this.SaveToFileToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveToFileToolStripButton.Image")));
            this.SaveToFileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToFileToolStripButton.Name = "SaveToFileToolStripButton";
            this.SaveToFileToolStripButton.Size = new System.Drawing.Size(102, 28);
            this.SaveToFileToolStripButton.Text = "Fájlba mentés";
            this.SaveToFileToolStripButton.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // AboutToolStripButton
            // 
            this.AboutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AboutToolStripButton.Image = global::InfraWeatherMaker.Properties.Resources.help32;
            this.AboutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutToolStripButton.Name = "AboutToolStripButton";
            this.AboutToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.AboutToolStripButton.Text = "Súgó";
            this.AboutToolStripButton.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::InfraWeatherMaker.Properties.Resources.run;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 492);
            this.Controls.Add(this.BrowserToolStrip);
            this.Controls.Add(this.SplitContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "MainForm";
            this.Text = "Infra WeatherMaker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl.ResumeLayout(false);
            this.DataTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DateGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPictureBox)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel2.ResumeLayout(false);
            this.SplitContainer.ResumeLayout(false);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.BrowserToolStrip.ResumeLayout(false);
            this.BrowserToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage DataTabPage;
        private System.Windows.Forms.DataGridView DateGridView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.WebBrowser WebBrowser;
        private System.Windows.Forms.RadioButton SecondRadioButton;
        private System.Windows.Forms.RadioButton FirstRadioButton;
        private System.Windows.Forms.PictureBox PreviewPictureBox;
        private System.Windows.Forms.ToolStrip BrowserToolStrip;
        private System.Windows.Forms.ToolStripButton BrowserToolStripButton;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripLabel AddressToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox AddressToolStripTextBox;
        private System.Windows.Forms.ToolStripButton AddressToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton MakeImageToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dat;
        private System.Windows.Forms.DataGridViewTextBoxColumn min;
        private System.Windows.Forms.DataGridViewTextBoxColumn max;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button SaveFolderBrowseButton;
        private System.Windows.Forms.TextBox SaveFolderTextBox;
        private System.Windows.Forms.Label SaveFolderLabel;
        private System.Windows.Forms.Button BackgroundBrowseButton;
        private System.Windows.Forms.TextBox BackgroundTextBox;
        private System.Windows.Forms.Label Backgroundlabel;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton SaveToFileToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton AboutToolStripButton;

    }
}

