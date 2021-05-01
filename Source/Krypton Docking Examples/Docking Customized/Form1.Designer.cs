﻿namespace DockingCustomized
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kryptonRibbon1 = new .Ribbon.KryptonRibbon();
            this.kryptonRibbonTab1 = new .Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup2 = new .Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple5 = new .Ribbon.KryptonRibbonGroupTriple();
            this.modeStackGroup = new .Ribbon.KryptonRibbonGroupButton();
            this.modeStackHeaderGroup = new .Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup3 = new .Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple3 = new .Ribbon.KryptonRibbonGroupTriple();
            this.modeBarGroupOutside = new .Ribbon.KryptonRibbonGroupButton();
            this.modeBarGroupInside = new .Ribbon.KryptonRibbonGroupButton();
            this.modeTabGroup = new .Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup5 = new .Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple4 = new .Ribbon.KryptonRibbonGroupTriple();
            this.modeBarRibbonTabGroup = new .Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup4 = new .Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple2 = new .Ribbon.KryptonRibbonGroupTriple();
            this.modeHeaderBarGroup = new .Ribbon.KryptonRibbonGroupButton();
            this.modeHeaderBarHeaderGroup = new .Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup7 = new .Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple7 = new .Ribbon.KryptonRibbonGroupTriple();
            this.modeHeaderGroupTab = new .Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonTab2 = new .Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup1 = new .Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple1 = new .Ribbon.KryptonRibbonGroupTriple();
            this.colorsRandom = new .Ribbon.KryptonRibbonGroupButton();
            this.colorsReset = new .Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup6 = new .Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple6 = new .Ribbon.KryptonRibbonGroupTriple();
            this.buttonSpecsAdd = new .Ribbon.KryptonRibbonGroupButton();
            this.buttonSpecsClear = new .Ribbon.KryptonRibbonGroupButton();
            this.kryptonPanel = new Krypton.Toolkit.KryptonPanel();
            this.kryptonDockableWorkspace = new .Docking.KryptonDockableWorkspace();
            this.kryptonDockingManager = new .Docking.KryptonDockingManager();
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.kryptonManager = new Krypton.Toolkit.KryptonManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonRibbon1
            // 
            this.kryptonRibbon1.AllowFormIntegrate = true;
            this.kryptonRibbon1.InDesignHelperMode = true;
            this.kryptonRibbon1.Name = "kryptonRibbon1";
            this.kryptonRibbon1.RibbonAppButton.AppButtonImage = ((System.Drawing.Image)(resources.GetObject("kryptonRibbon1.RibbonAppButton.AppButtonImage")));
            this.kryptonRibbon1.RibbonTabs.AddRange(new .Ribbon.KryptonRibbonTab[] {
            this.kryptonRibbonTab1,
            this.kryptonRibbonTab2});
            this.kryptonRibbon1.SelectedTab = this.kryptonRibbonTab1;
            this.kryptonRibbon1.Size = new System.Drawing.Size(812, 115);
            this.kryptonRibbon1.TabIndex = 0;
            // 
            // kryptonRibbonTab1
            // 
            this.kryptonRibbonTab1.Groups.AddRange(new .Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup2,
            this.kryptonRibbonGroup3,
            this.kryptonRibbonGroup5,
            this.kryptonRibbonGroup4,
            this.kryptonRibbonGroup7});
            this.kryptonRibbonTab1.KeyTip = "C";
            this.kryptonRibbonTab1.Text = "Cell Modes";
            // 
            // kryptonRibbonGroup2
            // 
            this.kryptonRibbonGroup2.DialogBoxLauncher = false;
            this.kryptonRibbonGroup2.Image = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroup2.Image")));
            this.kryptonRibbonGroup2.Items.AddRange(new .Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple5});
            this.kryptonRibbonGroup2.KeyTipGroup = "S";
            this.kryptonRibbonGroup2.TextLine1 = "Stack Modes";
            // 
            // kryptonRibbonGroupTriple5
            // 
            this.kryptonRibbonGroupTriple5.Items.AddRange(new .Ribbon.KryptonRibbonGroupItem[] {
            this.modeStackGroup,
            this.modeStackHeaderGroup});
            this.kryptonRibbonGroupTriple5.MaximumSize = .Ribbon.GroupItemSize.Medium;
            this.kryptonRibbonGroupTriple5.MinimumSize = .Ribbon.GroupItemSize.Medium;
            // 
            // modeStackGroup
            // 
            this.modeStackGroup.ButtonType = .Ribbon.GroupButtonType.Check;
            this.modeStackGroup.ImageLarge = ((System.Drawing.Image)(resources.GetObject("modeStackGroup.ImageLarge")));
            this.modeStackGroup.ImageSmall = ((System.Drawing.Image)(resources.GetObject("modeStackGroup.ImageSmall")));
            this.modeStackGroup.KeyTip = "SG";
            this.modeStackGroup.Tag = "StackCheckButtonGroup";
            this.modeStackGroup.TextLine1 = "Stack - Group";
            this.modeStackGroup.Click += new System.EventHandler(this.kryptonRibbonModeButton_Click);
            // 
            // modeStackHeaderGroup
            // 
            this.modeStackHeaderGroup.ButtonType = .Ribbon.GroupButtonType.Check;
            this.modeStackHeaderGroup.ImageLarge = ((System.Drawing.Image)(resources.GetObject("modeStackHeaderGroup.ImageLarge")));
            this.modeStackHeaderGroup.ImageSmall = ((System.Drawing.Image)(resources.GetObject("modeStackHeaderGroup.ImageSmall")));
            this.modeStackHeaderGroup.KeyTip = "SH";
            this.modeStackHeaderGroup.Tag = "StackCheckButtonHeaderGroup";
            this.modeStackHeaderGroup.TextLine1 = "Stack - HeaderGroup";
            this.modeStackHeaderGroup.Click += new System.EventHandler(this.kryptonRibbonModeButton_Click);
            // 
            // kryptonRibbonGroup3
            // 
            this.kryptonRibbonGroup3.DialogBoxLauncher = false;
            this.kryptonRibbonGroup3.Image = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroup3.Image")));
            this.kryptonRibbonGroup3.Items.AddRange(new .Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple3});
            this.kryptonRibbonGroup3.KeyTipGroup = "B";
            this.kryptonRibbonGroup3.TextLine1 = "Bar Modes";
            // 
            // kryptonRibbonGroupTriple3
            // 
            this.kryptonRibbonGroupTriple3.Items.AddRange(new .Ribbon.KryptonRibbonGroupItem[] {
            this.modeBarGroupOutside,
            this.modeBarGroupInside,
            this.modeTabGroup});
            this.kryptonRibbonGroupTriple3.MaximumSize = .Ribbon.GroupItemSize.Medium;
            this.kryptonRibbonGroupTriple3.MinimumSize = .Ribbon.GroupItemSize.Medium;
            // 
            // modeBarGroupOutside
            // 
            this.modeBarGroupOutside.ButtonType = .Ribbon.GroupButtonType.Check;
            this.modeBarGroupOutside.ImageLarge = ((System.Drawing.Image)(resources.GetObject("modeBarGroupOutside.ImageLarge")));
            this.modeBarGroupOutside.ImageSmall = ((System.Drawing.Image)(resources.GetObject("modeBarGroupOutside.ImageSmall")));
            this.modeBarGroupOutside.KeyTip = "BO";
            this.modeBarGroupOutside.Tag = "BarCheckButtonGroupOutside";
            this.modeBarGroupOutside.TextLine1 = "Bar - GroupOutside";
            this.modeBarGroupOutside.Click += new System.EventHandler(this.kryptonRibbonModeButton_Click);
            // 
            // modeBarGroupInside
            // 
            this.modeBarGroupInside.ButtonType = .Ribbon.GroupButtonType.Check;
            this.modeBarGroupInside.ImageLarge = ((System.Drawing.Image)(resources.GetObject("modeBarGroupInside.ImageLarge")));
            this.modeBarGroupInside.ImageSmall = ((System.Drawing.Image)(resources.GetObject("modeBarGroupInside.ImageSmall")));
            this.modeBarGroupInside.KeyTip = "BI";
            this.modeBarGroupInside.Tag = "BarCheckButtonGroupInside";
            this.modeBarGroupInside.TextLine1 = "Bar - GroupInside";
            this.modeBarGroupInside.Click += new System.EventHandler(this.kryptonRibbonModeButton_Click);
            // 
            // modeTabGroup
            // 
            this.modeTabGroup.ButtonType = .Ribbon.GroupButtonType.Check;
            this.modeTabGroup.ImageLarge = ((System.Drawing.Image)(resources.GetObject("modeTabGroup.ImageLarge")));
            this.modeTabGroup.ImageSmall = ((System.Drawing.Image)(resources.GetObject("modeTabGroup.ImageSmall")));
            this.modeTabGroup.KeyTip = "BT";
            this.modeTabGroup.Tag = "BarTabGroup";
            this.modeTabGroup.TextLine1 = "Bar - TabGroup";
            this.modeTabGroup.Click += new System.EventHandler(this.kryptonRibbonModeButton_Click);
            // 
            // kryptonRibbonGroup5
            // 
            this.kryptonRibbonGroup5.DialogBoxLauncher = false;
            this.kryptonRibbonGroup5.Image = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroup5.Image")));
            this.kryptonRibbonGroup5.Items.AddRange(new .Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple4});
            this.kryptonRibbonGroup5.KeyTipGroup = "R";
            this.kryptonRibbonGroup5.TextLine1 = "BarRibbon Modes";
            // 
            // kryptonRibbonGroupTriple4
            // 
            this.kryptonRibbonGroupTriple4.Items.AddRange(new .Ribbon.KryptonRibbonGroupItem[] {
            this.modeBarRibbonTabGroup});
            this.kryptonRibbonGroupTriple4.MaximumSize = .Ribbon.GroupItemSize.Medium;
            this.kryptonRibbonGroupTriple4.MinimumSize = .Ribbon.GroupItemSize.Medium;
            // 
            // modeBarRibbonTabGroup
            // 
            this.modeBarRibbonTabGroup.ButtonType = .Ribbon.GroupButtonType.Check;
            this.modeBarRibbonTabGroup.ImageLarge = ((System.Drawing.Image)(resources.GetObject("modeBarRibbonTabGroup.ImageLarge")));
            this.modeBarRibbonTabGroup.ImageSmall = ((System.Drawing.Image)(resources.GetObject("modeBarRibbonTabGroup.ImageSmall")));
            this.modeBarRibbonTabGroup.KeyTip = "BR";
            this.modeBarRibbonTabGroup.Tag = "BarRibbonTabGroup";
            this.modeBarRibbonTabGroup.TextLine1 = "BarRibbon - TabGroup";
            this.modeBarRibbonTabGroup.Click += new System.EventHandler(this.kryptonRibbonModeButton_Click);
            // 
            // kryptonRibbonGroup4
            // 
            this.kryptonRibbonGroup4.DialogBoxLauncher = false;
            this.kryptonRibbonGroup4.Image = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroup4.Image")));
            this.kryptonRibbonGroup4.Items.AddRange(new .Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple2});
            this.kryptonRibbonGroup4.KeyTipGroup = "H";
            this.kryptonRibbonGroup4.TextLine1 = "HeaderBar Modes";
            // 
            // kryptonRibbonGroupTriple2
            // 
            this.kryptonRibbonGroupTriple2.Items.AddRange(new .Ribbon.KryptonRibbonGroupItem[] {
            this.modeHeaderBarGroup,
            this.modeHeaderBarHeaderGroup});
            this.kryptonRibbonGroupTriple2.MaximumSize = .Ribbon.GroupItemSize.Medium;
            this.kryptonRibbonGroupTriple2.MinimumSize = .Ribbon.GroupItemSize.Medium;
            // 
            // modeHeaderBarGroup
            // 
            this.modeHeaderBarGroup.ButtonType = .Ribbon.GroupButtonType.Check;
            this.modeHeaderBarGroup.ImageLarge = ((System.Drawing.Image)(resources.GetObject("modeHeaderBarGroup.ImageLarge")));
            this.modeHeaderBarGroup.ImageSmall = ((System.Drawing.Image)(resources.GetObject("modeHeaderBarGroup.ImageSmall")));
            this.modeHeaderBarGroup.KeyTip = "HG";
            this.modeHeaderBarGroup.Tag = "HeaderBarCheckButtonGroup";
            this.modeHeaderBarGroup.TextLine1 = "HeaderBar - Group";
            this.modeHeaderBarGroup.Click += new System.EventHandler(this.kryptonRibbonModeButton_Click);
            // 
            // modeHeaderBarHeaderGroup
            // 
            this.modeHeaderBarHeaderGroup.ButtonType = .Ribbon.GroupButtonType.Check;
            this.modeHeaderBarHeaderGroup.ImageLarge = ((System.Drawing.Image)(resources.GetObject("modeHeaderBarHeaderGroup.ImageLarge")));
            this.modeHeaderBarHeaderGroup.ImageSmall = ((System.Drawing.Image)(resources.GetObject("modeHeaderBarHeaderGroup.ImageSmall")));
            this.modeHeaderBarHeaderGroup.KeyTip = "HH";
            this.modeHeaderBarHeaderGroup.Tag = "HeaderBarCheckButtonHeaderGroup";
            this.modeHeaderBarHeaderGroup.TextLine1 = "HeaderBar - HeaderGroup";
            this.modeHeaderBarHeaderGroup.Click += new System.EventHandler(this.kryptonRibbonModeButton_Click);
            // 
            // kryptonRibbonGroup7
            // 
            this.kryptonRibbonGroup7.DialogBoxLauncher = false;
            this.kryptonRibbonGroup7.Items.AddRange(new .Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple7});
            this.kryptonRibbonGroup7.TextLine1 = "HeaderGroup Modes";
            // 
            // kryptonRibbonGroupTriple7
            // 
            this.kryptonRibbonGroupTriple7.Items.AddRange(new .Ribbon.KryptonRibbonGroupItem[] {
            this.modeHeaderGroupTab});
            this.kryptonRibbonGroupTriple7.MaximumSize = .Ribbon.GroupItemSize.Medium;
            // 
            // modeHeaderGroupTab
            // 
            this.modeHeaderGroupTab.ImageSmall = ((System.Drawing.Image)(resources.GetObject("modeHeaderGroupTab.ImageSmall")));
            this.modeHeaderGroupTab.KeyTip = "GT";
            this.modeHeaderGroupTab.Tag = "HeaderGroupTab";
            this.modeHeaderGroupTab.TextLine1 = "HeaderGroup - Tab";
            this.modeHeaderGroupTab.Click += new System.EventHandler(this.kryptonRibbonModeButton_Click);
            // 
            // kryptonRibbonTab2
            // 
            this.kryptonRibbonTab2.Groups.AddRange(new .Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup1,
            this.kryptonRibbonGroup6});
            this.kryptonRibbonTab2.KeyTip = "A";
            this.kryptonRibbonTab2.Text = "Actions";
            // 
            // kryptonRibbonGroup1
            // 
            this.kryptonRibbonGroup1.AllowCollapsed = false;
            this.kryptonRibbonGroup1.DialogBoxLauncher = false;
            this.kryptonRibbonGroup1.Items.AddRange(new .Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple1});
            this.kryptonRibbonGroup1.KeyTipGroup = "C";
            this.kryptonRibbonGroup1.TextLine1 = "Colors";
            // 
            // kryptonRibbonGroupTriple1
            // 
            this.kryptonRibbonGroupTriple1.Items.AddRange(new .Ribbon.KryptonRibbonGroupItem[] {
            this.colorsRandom,
            this.colorsReset});
            this.kryptonRibbonGroupTriple1.MinimumSize = .Ribbon.GroupItemSize.Large;
            // 
            // colorsRandom
            // 
            this.colorsRandom.ImageLarge = ((System.Drawing.Image)(resources.GetObject("colorsRandom.ImageLarge")));
            this.colorsRandom.KeyTip = "R";
            this.colorsRandom.TextLine1 = "Random";
            this.colorsRandom.TextLine2 = "Page Colors";
            this.colorsRandom.Click += new System.EventHandler(this.colorsRandom_Click);
            // 
            // colorsReset
            // 
            this.colorsReset.ImageLarge = ((System.Drawing.Image)(resources.GetObject("colorsReset.ImageLarge")));
            this.colorsReset.KeyTip = "S";
            this.colorsReset.TextLine1 = "Reset";
            this.colorsReset.TextLine2 = "Page Colors";
            this.colorsReset.Click += new System.EventHandler(this.colorsReset_Click);
            // 
            // kryptonRibbonGroup6
            // 
            this.kryptonRibbonGroup6.AllowCollapsed = false;
            this.kryptonRibbonGroup6.DialogBoxLauncher = false;
            this.kryptonRibbonGroup6.Items.AddRange(new .Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple6});
            this.kryptonRibbonGroup6.TextLine1 = "ButtonSpecs";
            // 
            // kryptonRibbonGroupTriple6
            // 
            this.kryptonRibbonGroupTriple6.Items.AddRange(new .Ribbon.KryptonRibbonGroupItem[] {
            this.buttonSpecsAdd,
            this.buttonSpecsClear});
            this.kryptonRibbonGroupTriple6.MinimumSize = .Ribbon.GroupItemSize.Large;
            // 
            // buttonSpecsAdd
            // 
            this.buttonSpecsAdd.ImageLarge = ((System.Drawing.Image)(resources.GetObject("buttonSpecsAdd.ImageLarge")));
            this.buttonSpecsAdd.TextLine1 = "Add Page";
            this.buttonSpecsAdd.TextLine2 = "ButtonSpecs";
            this.buttonSpecsAdd.Click += new System.EventHandler(this.buttonSpecsAdd_Click);
            // 
            // buttonSpecsClear
            // 
            this.buttonSpecsClear.ImageLarge = ((System.Drawing.Image)(resources.GetObject("buttonSpecsClear.ImageLarge")));
            this.buttonSpecsClear.KeyTip = "C";
            this.buttonSpecsClear.TextLine1 = "Clear Page";
            this.buttonSpecsClear.TextLine2 = "ButtonSpecs";
            this.buttonSpecsClear.Click += new System.EventHandler(this.buttonSpecsClear_Click);
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonDockableWorkspace);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 115);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Padding = new System.Windows.Forms.Padding(3);
            this.kryptonPanel.Size = new System.Drawing.Size(812, 499);
            this.kryptonPanel.TabIndex = 1;
            // 
            // kryptonDockableWorkspace
            // 
            this.kryptonDockableWorkspace.AutoHiddenHost = false;
            this.kryptonDockableWorkspace.CompactFlags = ((.Workspace.CompactFlags)(((.Workspace.CompactFlags.RemoveEmptyCells | .Workspace.CompactFlags.RemoveEmptySequences) 
            | .Workspace.CompactFlags.PromoteLeafs)));
            this.kryptonDockableWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDockableWorkspace.Location = new System.Drawing.Point(3, 3);
            this.kryptonDockableWorkspace.Name = "kryptonDockableWorkspace";
            // 
            // 
            // 
            this.kryptonDockableWorkspace.Root.UniqueName = "5594893E2F2E42885594893E2F2E4288";
            this.kryptonDockableWorkspace.Root.WorkspaceControl = this.kryptonDockableWorkspace;
            this.kryptonDockableWorkspace.ShowMaximizeButton = false;
            this.kryptonDockableWorkspace.Size = new System.Drawing.Size(806, 493);
            this.kryptonDockableWorkspace.TabIndex = 0;
            this.kryptonDockableWorkspace.TabStop = true;
            // 
            // kryptonDockingManager
            // 
            this.kryptonDockingManager.ShowPageContextMenu += new System.EventHandler<.Docking.ContextPageEventArgs>(this.kryptonDockingManager_ShowPageContextMenu);
            this.kryptonDockingManager.ShowWorkspacePageContextMenu += new System.EventHandler<.Docking.ContextPageEventArgs>(this.kryptonDockingManager_ShowWorkspacePageContextMenu);
            this.kryptonDockingManager.DockspaceAdding += new System.EventHandler<.Docking.DockspaceEventArgs>(this.kryptonDockingManager_DockspaceAdding);
            this.kryptonDockingManager.DockspaceCellAdding += new System.EventHandler<.Docking.DockspaceCellEventArgs>(this.kryptonDockingManager_DockspaceCellAdding);
            this.kryptonDockingManager.FloatspaceCellAdding += new System.EventHandler<.Docking.FloatspaceCellEventArgs>(this.kryptonDockingManager_FloatspaceCellAdding);
            this.kryptonDockingManager.FloatingWindowAdding += new System.EventHandler<.Docking.FloatingWindowEventArgs>(this.kryptonDockingManager_FloatingWindowAdding);
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "document_plain.png");
            this.imageListSmall.Images.SetKeyName(1, "preferences.png");
            this.imageListSmall.Images.SetKeyName(2, "information2.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 614);
            this.Controls.Add(this.kryptonPanel);
            this.Controls.Add(this.kryptonRibbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Docking Customized";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel;
        private .Docking.KryptonDockableWorkspace kryptonDockableWorkspace;
        private .Docking.KryptonDockingManager kryptonDockingManager;
        private System.Windows.Forms.ImageList imageListSmall;
        private Krypton.Toolkit.KryptonManager kryptonManager;
        private .Ribbon.KryptonRibbon kryptonRibbon1;
        private .Ribbon.KryptonRibbonTab kryptonRibbonTab1;
        private .Ribbon.KryptonRibbonGroup kryptonRibbonGroup2;
        private .Ribbon.KryptonRibbonGroup kryptonRibbonGroup3;
        private .Ribbon.KryptonRibbonGroup kryptonRibbonGroup4;
        private .Ribbon.KryptonRibbonGroup kryptonRibbonGroup5;
        private .Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple2;
        private .Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple3;
        private .Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple4;
        private .Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple5;
        private .Ribbon.KryptonRibbonGroupButton modeHeaderBarHeaderGroup;
        private .Ribbon.KryptonRibbonGroupButton modeHeaderBarGroup;
        private .Ribbon.KryptonRibbonGroupButton modeTabGroup;
        private .Ribbon.KryptonRibbonGroupButton modeBarGroupInside;
        private .Ribbon.KryptonRibbonGroupButton modeBarGroupOutside;
        private .Ribbon.KryptonRibbonGroupButton modeBarRibbonTabGroup;
        private .Ribbon.KryptonRibbonGroupButton modeStackGroup;
        private .Ribbon.KryptonRibbonGroupButton modeStackHeaderGroup;
        private .Ribbon.KryptonRibbonTab kryptonRibbonTab2;
        private .Ribbon.KryptonRibbonGroup kryptonRibbonGroup1;
        private .Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple1;
        private .Ribbon.KryptonRibbonGroupButton colorsRandom;
        private .Ribbon.KryptonRibbonGroupButton colorsReset;
        private .Ribbon.KryptonRibbonGroup kryptonRibbonGroup6;
        private .Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple6;
        private .Ribbon.KryptonRibbonGroupButton buttonSpecsAdd;
        private .Ribbon.KryptonRibbonGroupButton buttonSpecsClear;
        private .Ribbon.KryptonRibbonGroup kryptonRibbonGroup7;
        private .Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple7;
        private .Ribbon.KryptonRibbonGroupButton modeHeaderGroupTab;
    }
}

