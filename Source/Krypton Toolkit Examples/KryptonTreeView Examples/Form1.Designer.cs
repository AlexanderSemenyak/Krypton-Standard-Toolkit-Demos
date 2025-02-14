﻿namespace KryptonTreeViewExamples
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.kryptonTreeView = new Krypton.Toolkit.KryptonTreeView();
            this.imageList = new System.Windows.Forms.ImageList();
            this.kryptonContextMenu1 = new Krypton.Toolkit.KryptonContextMenu();
            this.kryptonContextMenuHeading1 = new Krypton.Toolkit.KryptonContextMenuHeading();
            this.kryptonContextMenuMonthCalendar1 = new Krypton.Toolkit.KryptonContextMenuMonthCalendar();
            this.kryptonContextMenuItems1 = new Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem1 = new Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItems2 = new Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuHeading2 = new Krypton.Toolkit.KryptonContextMenuHeading();
            this.kryptonContextMenuCheckBox1 = new Krypton.Toolkit.KryptonContextMenuCheckBox();
            this.kryptonContextMenuCheckButton1 = new Krypton.Toolkit.KryptonContextMenuCheckButton();
            this.kryptonContextMenuRadioButton1 = new Krypton.Toolkit.KryptonContextMenuRadioButton();
            this.kryptonContextMenuLinkLabel1 = new Krypton.Toolkit.KryptonContextMenuLinkLabel();
            this.kryptonContextMenuColorColumns1 = new Krypton.Toolkit.KryptonContextMenuColorColumns();
            this.kryptonContextMenuImageSelect1 = new Krypton.Toolkit.KryptonContextMenuImageSelect();
            this.kryptonContextMenuSeparator1 = new Krypton.Toolkit.KryptonContextMenuSeparator();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxA = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkSystem = new Krypton.Toolkit.KryptonCheckButton();
            this.checkSparkle = new Krypton.Toolkit.KryptonCheckButton();
            this.check2010Blue = new Krypton.Toolkit.KryptonCheckButton();
            this.check2007Blue = new Krypton.Toolkit.KryptonCheckButton();
            this.buttonAppend = new Krypton.Toolkit.KryptonButton();
            this.buttonInsert = new Krypton.Toolkit.KryptonButton();
            this.buttonClear = new Krypton.Toolkit.KryptonButton();
            this.buttonRemove = new Krypton.Toolkit.KryptonButton();
            this.kryptonManager1 = new Krypton.Toolkit.KryptonManager();
            this.kryptonCheckSet = new Krypton.Toolkit.KryptonCheckSet();
            this.kryptonContextMenuItem2 = new Krypton.Toolkit.KryptonContextMenuItem();
            this.btnToggleNodeCheckBox = new Krypton.Toolkit.KryptonButton();
            this.groupBox.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonCheckSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(500, 513);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.propertyGrid);
            this.groupBox.Location = new System.Drawing.Point(285, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(290, 495);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Properties for Selected KryptonTreeView";
            // 
            // propertyGrid
            // 
            this.propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid.Location = new System.Drawing.Point(6, 19);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.SelectedObject = this.kryptonTreeView;
            this.propertyGrid.Size = new System.Drawing.Size(278, 472);
            this.propertyGrid.TabIndex = 0;
            this.propertyGrid.ToolbarVisible = false;
            // 
            // kryptonTreeView
            // 
            this.kryptonTreeView.CheckBoxes = true;
            this.kryptonTreeView.HideSelection = false;
            this.kryptonTreeView.HotTracking = true;
            this.kryptonTreeView.ImageIndex = 3;
            this.kryptonTreeView.ImageList = this.imageList;
            this.kryptonTreeView.KryptonContextMenu = this.kryptonContextMenu1;
            this.kryptonTreeView.Location = new System.Drawing.Point(13, 31);
            this.kryptonTreeView.Name = "kryptonTreeView";
            this.kryptonTreeView.Padding = new System.Windows.Forms.Padding(1);
            this.kryptonTreeView.SelectedImageIndex = 3;
            this.kryptonTreeView.Size = new System.Drawing.Size(255, 259);
            this.kryptonTreeView.TabIndex = 6;
            this.kryptonTreeView.BeforeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.KryptonTreeView_BeforeCheck);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "flag_bahamas.png");
            this.imageList.Images.SetKeyName(1, "flag_china.png");
            this.imageList.Images.SetKeyName(2, "flag_ecuador.png");
            this.imageList.Images.SetKeyName(3, "flag_england.png");
            this.imageList.Images.SetKeyName(4, "flag_france.png");
            this.imageList.Images.SetKeyName(5, "flag_greece.png");
            this.imageList.Images.SetKeyName(6, "flag_netherlands.png");
            this.imageList.Images.SetKeyName(7, "flag_poland.png");
            // 
            // kryptonContextMenu1
            // 
            this.kryptonContextMenu1.Items.AddRange(new Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuHeading1,
            this.kryptonContextMenuMonthCalendar1,
            this.kryptonContextMenuItems1,
            this.kryptonContextMenuCheckBox1,
            this.kryptonContextMenuCheckButton1,
            this.kryptonContextMenuRadioButton1,
            this.kryptonContextMenuLinkLabel1,
            this.kryptonContextMenuColorColumns1,
            this.kryptonContextMenuImageSelect1,
            this.kryptonContextMenuSeparator1});
            // 
            // kryptonContextMenuHeading1
            // 
            this.kryptonContextMenuHeading1.ExtraText = "";
            // 
            // kryptonContextMenuMonthCalendar1
            // 
            this.kryptonContextMenuMonthCalendar1.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // kryptonContextMenuItems1
            // 
            this.kryptonContextMenuItems1.Items.AddRange(new Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItem1});
            // 
            // kryptonContextMenuItem1
            // 
            this.kryptonContextMenuItem1.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.kryptonContextMenuItem1.Items.AddRange(new Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItems2,
            this.kryptonContextMenuHeading2});
            this.kryptonContextMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.None;
            this.kryptonContextMenuItem1.Text = "Menu Item";
            // 
            // kryptonContextMenuHeading2
            // 
            this.kryptonContextMenuHeading2.ExtraText = "";
            // 
            // kryptonContextMenuCheckBox1
            // 
            this.kryptonContextMenuCheckBox1.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.kryptonContextMenuCheckBox1.ExtraText = "extra";
            this.kryptonContextMenuCheckBox1.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl;
            // 
            // kryptonContextMenuCheckButton1
            // 
            this.kryptonContextMenuCheckButton1.ButtonStyle = Krypton.Toolkit.ButtonStyle.Standalone;
            this.kryptonContextMenuCheckButton1.ExtraText = "extra";
            this.kryptonContextMenuCheckButton1.Text = "CheckButton";
            // 
            // kryptonContextMenuRadioButton1
            // 
            this.kryptonContextMenuRadioButton1.ExtraText = "extra";
            this.kryptonContextMenuRadioButton1.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl;
            // 
            // kryptonContextMenuLinkLabel1
            // 
            this.kryptonContextMenuLinkLabel1.ExtraText = "extra";
            this.kryptonContextMenuLinkLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl;
            this.kryptonContextMenuLinkLabel1.LinkBehavior = Krypton.Toolkit.KryptonLinkBehavior.AlwaysUnderline;
            // 
            // kryptonContextMenuColorColumns1
            // 
            this.kryptonContextMenuColorColumns1.BlockSize = new System.Drawing.Size(13, 13);
            this.kryptonContextMenuColorColumns1.ColorScheme = Krypton.Toolkit.ColorScheme.OfficeThemes;
            this.kryptonContextMenuColorColumns1.SelectedColor = System.Drawing.Color.Empty;
            // 
            // kryptonContextMenuImageSelect1
            // 
            this.kryptonContextMenuImageSelect1.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            this.kryptonContextMenuImageSelect1.ImageIndexEnd = 0;
            this.kryptonContextMenuImageSelect1.ImageIndexStart = 5;
            this.kryptonContextMenuImageSelect1.ImageList = this.imageList;
            this.kryptonContextMenuImageSelect1.Padding = new System.Windows.Forms.Padding(2);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripComboBoxA,
            this.toolStripSeparator1,
            this.toolStripSeparator2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 65);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripComboBoxA
            // 
            this.toolStripComboBoxA.Items.AddRange(new object[] {
            "rew"});
            this.toolStripComboBoxA.Name = "toolStripComboBoxA";
            this.toolStripComboBoxA.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkSystem);
            this.groupBox1.Controls.Add(this.checkSparkle);
            this.groupBox1.Controls.Add(this.check2010Blue);
            this.groupBox1.Controls.Add(this.check2007Blue);
            this.groupBox1.Controls.Add(this.buttonAppend);
            this.groupBox1.Controls.Add(this.buttonInsert);
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.buttonRemove);
            this.groupBox1.Location = new System.Drawing.Point(13, 339);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 168);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // checkSystem
            // 
            this.checkSystem.AutoSize = true;
            this.checkSystem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.checkSystem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.checkSystem.Location = new System.Drawing.Point(125, 126);
            this.checkSystem.Name = "checkSystem";
            this.checkSystem.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.checkSystem.Size = new System.Drawing.Size(113, 28);
            this.checkSystem.TabIndex = 7;
            this.checkSystem.Values.Text = "System";
            // 
            // checkSparkle
            // 
            this.checkSparkle.AutoSize = true;
            this.checkSparkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.checkSparkle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.checkSparkle.Location = new System.Drawing.Point(125, 93);
            this.checkSparkle.Name = "checkSparkle";
            this.checkSparkle.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.checkSparkle.Size = new System.Drawing.Size(113, 28);
            this.checkSparkle.TabIndex = 6;
            this.checkSparkle.Values.Text = "Sparkle - Blue";
            // 
            // check2010Blue
            // 
            this.check2010Blue.AutoSize = true;
            this.check2010Blue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.check2010Blue.Checked = true;
            this.check2010Blue.DialogResult = System.Windows.Forms.DialogResult.None;
            this.check2010Blue.Location = new System.Drawing.Point(125, 31);
            this.check2010Blue.Name = "check2010Blue";
            this.check2010Blue.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.check2010Blue.Size = new System.Drawing.Size(133, 28);
            this.check2010Blue.TabIndex = 5;
            this.check2010Blue.Values.Text = "Office 2010 - Blue";
            // 
            // check2007Blue
            // 
            this.check2007Blue.AutoSize = true;
            this.check2007Blue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.check2007Blue.DialogResult = System.Windows.Forms.DialogResult.None;
            this.check2007Blue.Location = new System.Drawing.Point(125, 62);
            this.check2007Blue.Name = "check2007Blue";
            this.check2007Blue.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.check2007Blue.Size = new System.Drawing.Size(133, 28);
            this.check2007Blue.TabIndex = 4;
            this.check2007Blue.Values.Text = "Office 2007 - Blue";
            // 
            // buttonAppend
            // 
            this.buttonAppend.AutoSize = true;
            this.buttonAppend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.buttonAppend.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonAppend.Location = new System.Drawing.Point(19, 30);
            this.buttonAppend.Name = "buttonAppend";
            this.buttonAppend.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.buttonAppend.Size = new System.Drawing.Size(90, 28);
            this.buttonAppend.TabIndex = 0;
            this.buttonAppend.Values.Text = "Append";
            this.buttonAppend.Click += new System.EventHandler(this.buttonAppend_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.AutoSize = true;
            this.buttonInsert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.buttonInsert.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonInsert.Location = new System.Drawing.Point(19, 62);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.buttonInsert.Size = new System.Drawing.Size(90, 28);
            this.buttonInsert.TabIndex = 1;
            this.buttonInsert.Values.Text = "Insert";
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.AutoSize = true;
            this.buttonClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.buttonClear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonClear.Location = new System.Drawing.Point(19, 126);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.buttonClear.Size = new System.Drawing.Size(90, 28);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Values.Text = "Clear";
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.AutoSize = true;
            this.buttonRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.buttonRemove.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonRemove.Location = new System.Drawing.Point(19, 94);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.buttonRemove.Size = new System.Drawing.Size(90, 28);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Values.Text = "Remove";
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteModeManager.Office2010Blue;
            // 
            // kryptonCheckSet
            // 
            this.kryptonCheckSet.CheckButtons.Add(this.checkSystem);
            this.kryptonCheckSet.CheckButtons.Add(this.checkSparkle);
            this.kryptonCheckSet.CheckButtons.Add(this.check2010Blue);
            this.kryptonCheckSet.CheckButtons.Add(this.check2007Blue);
            this.kryptonCheckSet.CheckedButton = this.check2010Blue;
            this.kryptonCheckSet.CheckedButtonChanged += new System.EventHandler(this.kryptonCheckSet_CheckedButtonChanged);
            // 
            // kryptonContextMenuItem2
            // 
            this.kryptonContextMenuItem2.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.kryptonContextMenuItem2.ShortcutKeys = System.Windows.Forms.Keys.None;
            this.kryptonContextMenuItem2.Text = "Menu Item";
            // 
            // btnToggleNodeCheckBox
            // 
            this.btnToggleNodeCheckBox.AutoSize = true;
            this.btnToggleNodeCheckBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.btnToggleNodeCheckBox.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnToggleNodeCheckBox.Location = new System.Drawing.Point(13, 308);
            this.btnToggleNodeCheckBox.Name = "btnToggleNodeCheckBox";
            this.btnToggleNodeCheckBox.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.btnToggleNodeCheckBox.Size = new System.Drawing.Size(138, 25);
            this.btnToggleNodeCheckBox.TabIndex = 8;
            this.btnToggleNodeCheckBox.Values.Text = "Toggle Node CheckBox";
            this.btnToggleNodeCheckBox.Click += new System.EventHandler(this.BtnToggleNodeCheckBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 548);
            this.Controls.Add(this.btnToggleNodeCheckBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kryptonTreeView);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "KryptonTreeView Examples";
            this.groupBox.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonCheckSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private Krypton.Toolkit.KryptonTreeView kryptonTreeView;
        private System.Windows.Forms.GroupBox groupBox1;
        private Krypton.Toolkit.KryptonCheckButton checkSystem;
        private Krypton.Toolkit.KryptonCheckButton checkSparkle;
        private Krypton.Toolkit.KryptonCheckButton check2010Blue;
        private Krypton.Toolkit.KryptonCheckButton check2007Blue;
        private Krypton.Toolkit.KryptonButton buttonAppend;
        private Krypton.Toolkit.KryptonButton buttonInsert;
        private Krypton.Toolkit.KryptonButton buttonClear;
        private Krypton.Toolkit.KryptonButton buttonRemove;
        private Krypton.Toolkit.KryptonManager kryptonManager1;
        private Krypton.Toolkit.KryptonCheckSet kryptonCheckSet;
        private System.Windows.Forms.ImageList imageList;
        private Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private Krypton.Toolkit.KryptonContextMenuHeading kryptonContextMenuHeading1;
        private Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems1;
        private Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem1;
        private Krypton.Toolkit.KryptonContextMenuCheckBox kryptonContextMenuCheckBox1;
        private Krypton.Toolkit.KryptonContextMenuCheckButton kryptonContextMenuCheckButton1;
        private Krypton.Toolkit.KryptonContextMenuRadioButton kryptonContextMenuRadioButton1;
        private Krypton.Toolkit.KryptonContextMenuLinkLabel kryptonContextMenuLinkLabel1;
        private Krypton.Toolkit.KryptonContextMenuColorColumns kryptonContextMenuColorColumns1;
        private Krypton.Toolkit.KryptonContextMenuImageSelect kryptonContextMenuImageSelect1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxA;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private Krypton.Toolkit.KryptonContextMenuSeparator kryptonContextMenuSeparator1;
        private Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems2;
        private Krypton.Toolkit.KryptonContextMenuHeading kryptonContextMenuHeading2;
        private Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem2;
        private Krypton.Toolkit.KryptonContextMenuMonthCalendar kryptonContextMenuMonthCalendar1;
        private Krypton.Toolkit.KryptonButton btnToggleNodeCheckBox;
    }
}

