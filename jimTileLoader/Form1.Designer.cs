using System;

namespace jimTileLoader
{
    partial class jimTileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(jimTileForm));
            this.lblAttributeText = new System.Windows.Forms.Label();
            this.lbTileSelect = new System.Windows.Forms.ListBox();
            this.lblNameTitle = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblImgWidthText = new System.Windows.Forms.Label();
            this.nudImgWidth = new System.Windows.Forms.NumericUpDown();
            this.lblImageHeightText = new System.Windows.Forms.Label();
            this.nudImgHeight = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.nudImgCoordY = new System.Windows.Forms.NumericUpDown();
            this.lblImgCoordYTitle = new System.Windows.Forms.Label();
            this.nudImgCoordX = new System.Windows.Forms.NumericUpDown();
            this.lblImgCoordXTitle = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.gbImageSettings = new System.Windows.Forms.GroupBox();
            this.gbBasic = new System.Windows.Forms.GroupBox();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.lblWidth = new System.Windows.Forms.Label();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.lblHeight = new System.Windows.Forms.Label();
            this.nudID = new System.Windows.Forms.NumericUpDown();
            this.lblIDText = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutJimTileLoaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.gbNebAware = new System.Windows.Forms.GroupBox();
            this.rbMeta = new System.Windows.Forms.RadioButton();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.rbAnimated = new System.Windows.Forms.RadioButton();
            this.rbDynamic = new System.Windows.Forms.RadioButton();
            this.lblTilesWide = new System.Windows.Forms.Label();
            this.nudTilesWide = new System.Windows.Forms.NumericUpDown();
            this.lblTilesHigh = new System.Windows.Forms.Label();
            this.nudTilesHigh = new System.Windows.Forms.NumericUpDown();
            this.lblValue = new System.Windows.Forms.Label();
            this.nudValue = new System.Windows.Forms.NumericUpDown();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudImgWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImgHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImgCoordY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImgCoordX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.gbImageSettings.SuspendLayout();
            this.gbBasic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gbNebAware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilesWide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilesHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAttributeText
            // 
            this.lblAttributeText.AutoSize = true;
            this.lblAttributeText.Location = new System.Drawing.Point(9, 48);
            this.lblAttributeText.Name = "lblAttributeText";
            this.lblAttributeText.Size = new System.Drawing.Size(34, 13);
            this.lblAttributeText.TabIndex = 1;
            this.lblAttributeText.Text = "Type:";
            // 
            // lbTileSelect
            // 
            this.lbTileSelect.FormattingEnabled = true;
            this.lbTileSelect.Location = new System.Drawing.Point(248, 27);
            this.lbTileSelect.Name = "lbTileSelect";
            this.lbTileSelect.Size = new System.Drawing.Size(132, 212);
            this.lbTileSelect.TabIndex = 2;
            this.lbTileSelect.SelectedIndexChanged += new System.EventHandler(this.lbTileSelect_SelectedIndexChanged);
            // 
            // lblNameTitle
            // 
            this.lblNameTitle.AutoSize = true;
            this.lblNameTitle.Location = new System.Drawing.Point(9, 22);
            this.lblNameTitle.Name = "lblNameTitle";
            this.lblNameTitle.Size = new System.Drawing.Size(38, 13);
            this.lblNameTitle.TabIndex = 3;
            this.lblNameTitle.Text = "Name:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(53, 19);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(80, 20);
            this.tbName.TabIndex = 4;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "NON_SOLID",
            "SOLID"});
            this.cbType.Location = new System.Drawing.Point(53, 45);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(58, 21);
            this.cbType.TabIndex = 5;
            this.cbType.Text = "Select one";
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // lblImgWidthText
            // 
            this.lblImgWidthText.AutoSize = true;
            this.lblImgWidthText.Location = new System.Drawing.Point(73, 18);
            this.lblImgWidthText.Name = "lblImgWidthText";
            this.lblImgWidthText.Size = new System.Drawing.Size(38, 13);
            this.lblImgWidthText.TabIndex = 6;
            this.lblImgWidthText.Text = "Width:";
            // 
            // nudImgWidth
            // 
            this.nudImgWidth.Location = new System.Drawing.Point(117, 16);
            this.nudImgWidth.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.nudImgWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudImgWidth.Name = "nudImgWidth";
            this.nudImgWidth.Size = new System.Drawing.Size(34, 20);
            this.nudImgWidth.TabIndex = 7;
            this.nudImgWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudImgWidth.ValueChanged += new System.EventHandler(this.nudImgWidth_ValueChanged);
            // 
            // lblImageHeightText
            // 
            this.lblImageHeightText.AutoSize = true;
            this.lblImageHeightText.Location = new System.Drawing.Point(73, 45);
            this.lblImageHeightText.Name = "lblImageHeightText";
            this.lblImageHeightText.Size = new System.Drawing.Size(41, 13);
            this.lblImageHeightText.TabIndex = 8;
            this.lblImageHeightText.Text = "Height:";
            // 
            // nudImgHeight
            // 
            this.nudImgHeight.Location = new System.Drawing.Point(117, 43);
            this.nudImgHeight.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.nudImgHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudImgHeight.Name = "nudImgHeight";
            this.nudImgHeight.Size = new System.Drawing.Size(34, 20);
            this.nudImgHeight.TabIndex = 9;
            this.nudImgHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudImgHeight.ValueChanged += new System.EventHandler(this.nudImgHeight_ValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(248, 249);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(61, 27);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(319, 249);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(61, 27);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // nudImgCoordY
            // 
            this.nudImgCoordY.Location = new System.Drawing.Point(33, 42);
            this.nudImgCoordY.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.nudImgCoordY.Name = "nudImgCoordY";
            this.nudImgCoordY.Size = new System.Drawing.Size(34, 20);
            this.nudImgCoordY.TabIndex = 15;
            this.nudImgCoordY.ValueChanged += new System.EventHandler(this.nudImgCoordY_ValueChanged);
            // 
            // lblImgCoordYTitle
            // 
            this.lblImgCoordYTitle.AutoSize = true;
            this.lblImgCoordYTitle.Location = new System.Drawing.Point(10, 44);
            this.lblImgCoordYTitle.Name = "lblImgCoordYTitle";
            this.lblImgCoordYTitle.Size = new System.Drawing.Size(17, 13);
            this.lblImgCoordYTitle.TabIndex = 14;
            this.lblImgCoordYTitle.Text = "Y:";
            // 
            // nudImgCoordX
            // 
            this.nudImgCoordX.Location = new System.Drawing.Point(33, 16);
            this.nudImgCoordX.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.nudImgCoordX.Name = "nudImgCoordX";
            this.nudImgCoordX.Size = new System.Drawing.Size(34, 20);
            this.nudImgCoordX.TabIndex = 13;
            this.nudImgCoordX.ValueChanged += new System.EventHandler(this.nudImgCoordX_ValueChanged);
            // 
            // lblImgCoordXTitle
            // 
            this.lblImgCoordXTitle.AutoSize = true;
            this.lblImgCoordXTitle.Location = new System.Drawing.Point(10, 18);
            this.lblImgCoordXTitle.Name = "lblImgCoordXTitle";
            this.lblImgCoordXTitle.Size = new System.Drawing.Size(17, 13);
            this.lblImgCoordXTitle.TabIndex = 12;
            this.lblImgCoordXTitle.Text = "X:";
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.White;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(11, 134);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(64, 64);
            this.pbImage.TabIndex = 16;
            this.pbImage.TabStop = false;
            this.pbImage.Visible = false;
            // 
            // gbImageSettings
            // 
            this.gbImageSettings.Controls.Add(this.lblImgWidthText);
            this.gbImageSettings.Controls.Add(this.nudImgWidth);
            this.gbImageSettings.Controls.Add(this.nudImgCoordY);
            this.gbImageSettings.Controls.Add(this.lblImageHeightText);
            this.gbImageSettings.Controls.Add(this.lblImgCoordXTitle);
            this.gbImageSettings.Controls.Add(this.nudImgHeight);
            this.gbImageSettings.Controls.Add(this.lblImgCoordYTitle);
            this.gbImageSettings.Controls.Add(this.nudImgCoordX);
            this.gbImageSettings.Location = new System.Drawing.Point(81, 127);
            this.gbImageSettings.Name = "gbImageSettings";
            this.gbImageSettings.Size = new System.Drawing.Size(161, 71);
            this.gbImageSettings.TabIndex = 17;
            this.gbImageSettings.TabStop = false;
            this.gbImageSettings.Text = "Image Settings";
            // 
            // gbBasic
            // 
            this.gbBasic.Controls.Add(this.nudValue);
            this.gbBasic.Controls.Add(this.lblValue);
            this.gbBasic.Controls.Add(this.nudWidth);
            this.gbBasic.Controls.Add(this.lblWidth);
            this.gbBasic.Controls.Add(this.nudHeight);
            this.gbBasic.Controls.Add(this.lblHeight);
            this.gbBasic.Controls.Add(this.nudID);
            this.gbBasic.Controls.Add(this.lblIDText);
            this.gbBasic.Controls.Add(this.tbName);
            this.gbBasic.Controls.Add(this.lblAttributeText);
            this.gbBasic.Controls.Add(this.lblNameTitle);
            this.gbBasic.Controls.Add(this.cbType);
            this.gbBasic.Location = new System.Drawing.Point(12, 27);
            this.gbBasic.Name = "gbBasic";
            this.gbBasic.Size = new System.Drawing.Size(230, 101);
            this.gbBasic.TabIndex = 18;
            this.gbBasic.TabStop = false;
            this.gbBasic.Text = "Basic";
            // 
            // nudWidth
            // 
            this.nudWidth.BackColor = System.Drawing.SystemColors.Window;
            this.nudWidth.Location = new System.Drawing.Point(53, 71);
            this.nudWidth.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.nudWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(58, 20);
            this.nudWidth.TabIndex = 11;
            this.nudWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWidth.ValueChanged += new System.EventHandler(this.nudHeight_ValueChanged);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(9, 73);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(38, 13);
            this.lblWidth.TabIndex = 10;
            this.lblWidth.Text = "Width:";
            // 
            // nudHeight
            // 
            this.nudHeight.BackColor = System.Drawing.SystemColors.Window;
            this.nudHeight.Location = new System.Drawing.Point(166, 71);
            this.nudHeight.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.nudHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(58, 20);
            this.nudHeight.TabIndex = 9;
            this.nudHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(119, 73);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(41, 13);
            this.lblHeight.TabIndex = 8;
            this.lblHeight.Text = "Height:";
            // 
            // nudID
            // 
            this.nudID.BackColor = System.Drawing.SystemColors.Window;
            this.nudID.Location = new System.Drawing.Point(166, 19);
            this.nudID.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudID.Name = "nudID";
            this.nudID.Size = new System.Drawing.Size(58, 20);
            this.nudID.TabIndex = 7;
            this.nudID.ValueChanged += new System.EventHandler(this.nudID_ValueChanged);
            // 
            // lblIDText
            // 
            this.lblIDText.AutoSize = true;
            this.lblIDText.Location = new System.Drawing.Point(139, 22);
            this.lblIDText.Name = "lblIDText";
            this.lblIDText.Size = new System.Drawing.Size(21, 13);
            this.lblIDText.TabIndex = 6;
            this.lblIDText.Text = "ID:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(390, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadXMLToolStripMenuItem,
            this.saveXMLToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadXMLToolStripMenuItem
            // 
            this.loadXMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tilesToolStripMenuItem,
            this.itemsToolStripMenuItem});
            this.loadXMLToolStripMenuItem.Name = "loadXMLToolStripMenuItem";
            this.loadXMLToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadXMLToolStripMenuItem.Text = "Load XML";
            // 
            // tilesToolStripMenuItem
            // 
            this.tilesToolStripMenuItem.Name = "tilesToolStripMenuItem";
            this.tilesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tilesToolStripMenuItem.Text = "Tiles";
            this.tilesToolStripMenuItem.Click += new System.EventHandler(this.tilesToolStripMenuItem_Click);
            // 
            // saveXMLToolStripMenuItem
            // 
            this.saveXMLToolStripMenuItem.Name = "saveXMLToolStripMenuItem";
            this.saveXMLToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveXMLToolStripMenuItem.Text = "Save XML";
            this.saveXMLToolStripMenuItem.Click += new System.EventHandler(this.saveXMLToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutJimTileLoaderToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutJimTileLoaderToolStripMenuItem
            // 
            this.aboutJimTileLoaderToolStripMenuItem.Name = "aboutJimTileLoaderToolStripMenuItem";
            this.aboutJimTileLoaderToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.aboutJimTileLoaderToolStripMenuItem.Text = "About JimTileLoader";
            this.aboutJimTileLoaderToolStripMenuItem.Click += new System.EventHandler(this.aboutJimTileLoaderToolStripMenuItem_Click);
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "tiles.xml";
            // 
            // gbNebAware
            // 
            this.gbNebAware.Controls.Add(this.rbMeta);
            this.gbNebAware.Controls.Add(this.rbNone);
            this.gbNebAware.Controls.Add(this.rbAnimated);
            this.gbNebAware.Controls.Add(this.rbDynamic);
            this.gbNebAware.Controls.Add(this.lblTilesWide);
            this.gbNebAware.Controls.Add(this.nudTilesWide);
            this.gbNebAware.Controls.Add(this.lblTilesHigh);
            this.gbNebAware.Controls.Add(this.nudTilesHigh);
            this.gbNebAware.Location = new System.Drawing.Point(12, 204);
            this.gbNebAware.Name = "gbNebAware";
            this.gbNebAware.Size = new System.Drawing.Size(230, 72);
            this.gbNebAware.TabIndex = 20;
            this.gbNebAware.TabStop = false;
            this.gbNebAware.Text = "Special Images";
            // 
            // rbMeta
            // 
            this.rbMeta.AutoSize = true;
            this.rbMeta.Location = new System.Drawing.Point(6, 41);
            this.rbMeta.Name = "rbMeta";
            this.rbMeta.Size = new System.Drawing.Size(49, 17);
            this.rbMeta.TabIndex = 23;
            this.rbMeta.Text = "Meta";
            this.rbMeta.UseVisualStyleBackColor = true;
            this.rbMeta.CheckedChanged += new System.EventHandler(this.rbMeta_CheckedChanged);
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Checked = true;
            this.rbNone.Location = new System.Drawing.Point(6, 18);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(51, 17);
            this.rbNone.TabIndex = 22;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            this.rbNone.CheckedChanged += new System.EventHandler(this.rbNone_CheckedChanged);
            // 
            // rbAnimated
            // 
            this.rbAnimated.AutoSize = true;
            this.rbAnimated.Location = new System.Drawing.Point(67, 18);
            this.rbAnimated.Name = "rbAnimated";
            this.rbAnimated.Size = new System.Drawing.Size(69, 17);
            this.rbAnimated.TabIndex = 21;
            this.rbAnimated.Text = "Animated";
            this.rbAnimated.UseVisualStyleBackColor = true;
            this.rbAnimated.CheckedChanged += new System.EventHandler(this.rbAnimated_CheckedChanged);
            // 
            // rbDynamic
            // 
            this.rbDynamic.AutoSize = true;
            this.rbDynamic.Location = new System.Drawing.Point(67, 41);
            this.rbDynamic.Name = "rbDynamic";
            this.rbDynamic.Size = new System.Drawing.Size(66, 17);
            this.rbDynamic.TabIndex = 20;
            this.rbDynamic.Text = "Dynamic";
            this.rbDynamic.UseVisualStyleBackColor = true;
            this.rbDynamic.CheckedChanged += new System.EventHandler(this.rbDynamic_CheckedChanged);
            // 
            // lblTilesWide
            // 
            this.lblTilesWide.AutoSize = true;
            this.lblTilesWide.Location = new System.Drawing.Point(146, 20);
            this.lblTilesWide.Name = "lblTilesWide";
            this.lblTilesWide.Size = new System.Drawing.Size(38, 13);
            this.lblTilesWide.TabIndex = 16;
            this.lblTilesWide.Text = "Width:";
            // 
            // nudTilesWide
            // 
            this.nudTilesWide.Location = new System.Drawing.Point(187, 16);
            this.nudTilesWide.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.nudTilesWide.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTilesWide.Name = "nudTilesWide";
            this.nudTilesWide.Size = new System.Drawing.Size(34, 20);
            this.nudTilesWide.TabIndex = 17;
            this.nudTilesWide.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTilesWide.ValueChanged += new System.EventHandler(this.nudTilesWide_ValueChanged);
            // 
            // lblTilesHigh
            // 
            this.lblTilesHigh.AutoSize = true;
            this.lblTilesHigh.Location = new System.Drawing.Point(143, 45);
            this.lblTilesHigh.Name = "lblTilesHigh";
            this.lblTilesHigh.Size = new System.Drawing.Size(41, 13);
            this.lblTilesHigh.TabIndex = 18;
            this.lblTilesHigh.Text = "Height:";
            // 
            // nudTilesHigh
            // 
            this.nudTilesHigh.Location = new System.Drawing.Point(187, 43);
            this.nudTilesHigh.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.nudTilesHigh.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTilesHigh.Name = "nudTilesHigh";
            this.nudTilesHigh.Size = new System.Drawing.Size(34, 20);
            this.nudTilesHigh.TabIndex = 19;
            this.nudTilesHigh.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTilesHigh.ValueChanged += new System.EventHandler(this.nudTilesHigh_ValueChanged);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(119, 48);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(37, 13);
            this.lblValue.TabIndex = 12;
            this.lblValue.Text = "Value:";
            // 
            // nudValue
            // 
            this.nudValue.BackColor = System.Drawing.SystemColors.Window;
            this.nudValue.Location = new System.Drawing.Point(166, 45);
            this.nudValue.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nudValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(58, 20);
            this.nudValue.TabIndex = 13;
            this.nudValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.itemsToolStripMenuItem.Text = "Items";
            this.itemsToolStripMenuItem.Click += new System.EventHandler(this.itemsToolStripMenuItem_Click);
            // 
            // jimTileForm
            // 
            this.ClientSize = new System.Drawing.Size(390, 286);
            this.Controls.Add(this.gbNebAware);
            this.Controls.Add(this.gbBasic);
            this.Controls.Add(this.gbImageSettings);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbTileSelect);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "jimTileForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Jim Tile Loader";
            ((System.ComponentModel.ISupportInitialize)(this.nudImgWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImgHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImgCoordY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImgCoordX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.gbImageSettings.ResumeLayout(false);
            this.gbImageSettings.PerformLayout();
            this.gbBasic.ResumeLayout(false);
            this.gbBasic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbNebAware.ResumeLayout(false);
            this.gbNebAware.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilesWide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilesHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAttributeText;
        private System.Windows.Forms.ListBox lbTileSelect;
        private System.Windows.Forms.Label lblNameTitle;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblImgWidthText;
        private System.Windows.Forms.NumericUpDown nudImgWidth;
        private System.Windows.Forms.Label lblImageHeightText;
        private System.Windows.Forms.NumericUpDown nudImgHeight;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.NumericUpDown nudImgCoordY;
        private System.Windows.Forms.Label lblImgCoordYTitle;
        private System.Windows.Forms.NumericUpDown nudImgCoordX;
        private System.Windows.Forms.Label lblImgCoordXTitle;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.GroupBox gbImageSettings;
        private System.Windows.Forms.GroupBox gbBasic;
        private System.Windows.Forms.Label lblIDText;
        private System.Windows.Forms.NumericUpDown nudID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutJimTileLoaderToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.GroupBox gbNebAware;
        private System.Windows.Forms.Label lblTilesWide;
        private System.Windows.Forms.NumericUpDown nudTilesWide;
        private System.Windows.Forms.Label lblTilesHigh;
        private System.Windows.Forms.NumericUpDown nudTilesHigh;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.RadioButton rbAnimated;
        private System.Windows.Forms.RadioButton rbDynamic;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.RadioButton rbMeta;
        private System.Windows.Forms.ToolStripMenuItem tilesToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown nudValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
    }
}

