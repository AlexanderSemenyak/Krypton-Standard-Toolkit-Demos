﻿namespace DockingPersistence
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
            this.kryptonDockingManager = new Krypton.Docking.KryptonDockingManager();
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.kryptonRibbon = new Krypton.Ribbon.KryptonRibbon();
            this.kryptonContextMenuItem1 = new Krypton.Toolkit.KryptonContextMenuItem();
            this.tabPersistence = new Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup1 = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple1 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.buttonSaveArray1 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.buttonSaveArray2 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.buttonSaveArray3 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator1 = new Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple3 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.buttonLoadArray1 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.buttonLoadArray2 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.buttonLoadArray3 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup2 = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple2 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.buttonSaveFile = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator2 = new Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple4 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.buttonLoadFile = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup3 = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple5 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.buttonHideAll = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.buttonShowAll = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonPanel = new Krypton.Toolkit.KryptonPanel();
            this.kryptonDockableWorkspace = new Krypton.Docking.KryptonDockableWorkspace();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.kryptonManager = new Krypton.Toolkit.KryptonManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonDockingManager
            // 
            this.kryptonDockingManager.DefaultCloseRequest = Krypton.Docking.DockingCloseRequest.HidePage;
            this.kryptonDockingManager.GlobalSaving += new System.EventHandler<Krypton.Docking.DockGlobalSavingEventArgs>(this.kryptonDockingManager_GlobalSaving);
            this.kryptonDockingManager.GlobalLoading += new System.EventHandler<Krypton.Docking.DockGlobalLoadingEventArgs>(this.kryptonDockingManager_GlobalLoading);
            this.kryptonDockingManager.PageSaving += new System.EventHandler<Krypton.Docking.DockPageSavingEventArgs>(this.kryptonDockingManager_PageSaving);
            this.kryptonDockingManager.PageLoading += new System.EventHandler<Krypton.Docking.DockPageLoadingEventArgs>(this.kryptonDockingManager_PageLoading);
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "document_plain.png");
            this.imageListSmall.Images.SetKeyName(1, "preferences.png");
            this.imageListSmall.Images.SetKeyName(2, "information2.png");
            // 
            // kryptonRibbon
            // 
            this.kryptonRibbon.AllowFormIntegrate = true;
            this.kryptonRibbon.HideRibbonSize = new System.Drawing.Size(300, 250);
            this.kryptonRibbon.InDesignHelperMode = true;
            this.kryptonRibbon.Name = "kryptonRibbon";
            this.kryptonRibbon.QATLocation = Krypton.Ribbon.QATLocation.Above;
            this.kryptonRibbon.RibbonAppButton.AppButtonImage = ((System.Drawing.Image)(resources.GetObject("kryptonRibbon.RibbonAppButton.AppButtonImage")));
            this.kryptonRibbon.RibbonAppButton.AppButtonMaxRecentSize = new System.Drawing.Size(350, 350);
            this.kryptonRibbon.RibbonAppButton.AppButtonMenuItems.AddRange(new Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItem1});
            this.kryptonRibbon.RibbonAppButton.AppButtonMinRecentSize = new System.Drawing.Size(250, 250);
            this.kryptonRibbon.RibbonAppButton.AppButtonToolTipStyle = Krypton.Toolkit.LabelStyle.SuperTip;
            this.kryptonRibbon.RibbonTabs.AddRange(new Krypton.Ribbon.KryptonRibbonTab[] {
            this.tabPersistence});
            this.kryptonRibbon.SelectedContext = null;
            this.kryptonRibbon.SelectedTab = this.tabPersistence;
            this.kryptonRibbon.Size = new System.Drawing.Size(784, 115);
            this.kryptonRibbon.TabIndex = 0;
            // 
            // kryptonContextMenuItem1
            // 
            this.kryptonContextMenuItem1.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.kryptonContextMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("kryptonContextMenuItem1.Image")));
            this.kryptonContextMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.None;
            this.kryptonContextMenuItem1.Text = "E&xit";
            this.kryptonContextMenuItem1.Click += new System.EventHandler(this.kryptonContextMenuItem1_Click);
            // 
            // tabPersistence
            // 
            this.tabPersistence.Groups.AddRange(new Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup1,
            this.kryptonRibbonGroup2,
            this.kryptonRibbonGroup3});
            this.tabPersistence.Text = "Persistence";
            // 
            // kryptonRibbonGroup1
            // 
            this.kryptonRibbonGroup1.DialogBoxLauncher = false;
            this.kryptonRibbonGroup1.Image = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroup1.Image")));
            this.kryptonRibbonGroup1.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple1,
            this.kryptonRibbonGroupSeparator1,
            this.kryptonRibbonGroupTriple3});
            this.kryptonRibbonGroup1.KeyTipGroup = "A";
            this.kryptonRibbonGroup1.TextLine1 = "Array Persist";
            // 
            // kryptonRibbonGroupTriple1
            // 
            this.kryptonRibbonGroupTriple1.ItemAlignment = Krypton.Ribbon.RibbonItemAlignment.Near;
            this.kryptonRibbonGroupTriple1.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.buttonSaveArray1,
            this.buttonSaveArray2,
            this.buttonSaveArray3});
            this.kryptonRibbonGroupTriple1.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium;
            this.kryptonRibbonGroupTriple1.MinimumSize = Krypton.Ribbon.GroupItemSize.Medium;
            // 
            // buttonSaveArray1
            // 
            this.buttonSaveArray1.ButtonType = Krypton.Ribbon.GroupButtonType.Push;
            this.buttonSaveArray1.ImageLarge = ((System.Drawing.Image)(resources.GetObject("buttonSaveArray1.ImageLarge")));
            this.buttonSaveArray1.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonSaveArray1.ImageSmall")));
            this.buttonSaveArray1.KeyTip = "SA1";
            this.buttonSaveArray1.TextLine1 = "Save Array 1";
            this.buttonSaveArray1.ToolTipStyle = Krypton.Toolkit.LabelStyle.SuperTip;
            this.buttonSaveArray1.Click += new System.EventHandler(this.buttonSaveArray1_Click);
            // 
            // buttonSaveArray2
            // 
            this.buttonSaveArray2.ButtonType = Krypton.Ribbon.GroupButtonType.Push;
            this.buttonSaveArray2.ImageLarge = ((System.Drawing.Image)(resources.GetObject("buttonSaveArray2.ImageLarge")));
            this.buttonSaveArray2.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonSaveArray2.ImageSmall")));
            this.buttonSaveArray2.KeyTip = "SA2";
            this.buttonSaveArray2.TextLine1 = "Save Array 2";
            this.buttonSaveArray2.ToolTipStyle = Krypton.Toolkit.LabelStyle.SuperTip;
            this.buttonSaveArray2.Click += new System.EventHandler(this.buttonSaveArray2_Click);
            // 
            // buttonSaveArray3
            // 
            this.buttonSaveArray3.ButtonType = Krypton.Ribbon.GroupButtonType.Push;
            this.buttonSaveArray3.ImageLarge = ((System.Drawing.Image)(resources.GetObject("buttonSaveArray3.ImageLarge")));
            this.buttonSaveArray3.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonSaveArray3.ImageSmall")));
            this.buttonSaveArray3.KeyTip = "SA3";
            this.buttonSaveArray3.TextLine1 = "Save Array 3";
            this.buttonSaveArray3.ToolTipStyle = Krypton.Toolkit.LabelStyle.SuperTip;
            this.buttonSaveArray3.Click += new System.EventHandler(this.buttonSaveArray3_Click);
            // 
            // kryptonRibbonGroupTriple3
            // 
            this.kryptonRibbonGroupTriple3.ItemAlignment = Krypton.Ribbon.RibbonItemAlignment.Near;
            this.kryptonRibbonGroupTriple3.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.buttonLoadArray1,
            this.buttonLoadArray2,
            this.buttonLoadArray3});
            this.kryptonRibbonGroupTriple3.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium;
            this.kryptonRibbonGroupTriple3.MinimumSize = Krypton.Ribbon.GroupItemSize.Medium;
            // 
            // buttonLoadArray1
            // 
            this.buttonLoadArray1.ButtonType = Krypton.Ribbon.GroupButtonType.Push;
            this.buttonLoadArray1.Enabled = false;
            this.buttonLoadArray1.ImageLarge = ((System.Drawing.Image)(resources.GetObject("buttonLoadArray1.ImageLarge")));
            this.buttonLoadArray1.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonLoadArray1.ImageSmall")));
            this.buttonLoadArray1.KeyTip = "LA1";
            this.buttonLoadArray1.TextLine1 = "Load Array 1";
            this.buttonLoadArray1.ToolTipStyle = Krypton.Toolkit.LabelStyle.SuperTip;
            this.buttonLoadArray1.Click += new System.EventHandler(this.buttonLoadArray1_Click);
            // 
            // buttonLoadArray2
            // 
            this.buttonLoadArray2.ButtonType = Krypton.Ribbon.GroupButtonType.Push;
            this.buttonLoadArray2.Enabled = false;
            this.buttonLoadArray2.ImageLarge = ((System.Drawing.Image)(resources.GetObject("buttonLoadArray2.ImageLarge")));
            this.buttonLoadArray2.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonLoadArray2.ImageSmall")));
            this.buttonLoadArray2.KeyTip = "LA2";
            this.buttonLoadArray2.TextLine1 = "Load Array 2";
            this.buttonLoadArray2.ToolTipStyle = Krypton.Toolkit.LabelStyle.SuperTip;
            this.buttonLoadArray2.Click += new System.EventHandler(this.buttonLoadArray2_Click);
            // 
            // buttonLoadArray3
            // 
            this.buttonLoadArray3.ButtonType = Krypton.Ribbon.GroupButtonType.Push;
            this.buttonLoadArray3.Enabled = false;
            this.buttonLoadArray3.ImageLarge = ((System.Drawing.Image)(resources.GetObject("buttonLoadArray3.ImageLarge")));
            this.buttonLoadArray3.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonLoadArray3.ImageSmall")));
            this.buttonLoadArray3.KeyTip = "LA3";
            this.buttonLoadArray3.TextLine1 = "Load Array 3";
            this.buttonLoadArray3.ToolTipStyle = Krypton.Toolkit.LabelStyle.SuperTip;
            this.buttonLoadArray3.Click += new System.EventHandler(this.buttonLoadArray3_Click);
            // 
            // kryptonRibbonGroup2
            // 
            this.kryptonRibbonGroup2.DialogBoxLauncher = false;
            this.kryptonRibbonGroup2.Image = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroup2.Image")));
            this.kryptonRibbonGroup2.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple2,
            this.kryptonRibbonGroupSeparator2,
            this.kryptonRibbonGroupTriple4});
            this.kryptonRibbonGroup2.TextLine1 = "File Persist";
            // 
            // kryptonRibbonGroupTriple2
            // 
            this.kryptonRibbonGroupTriple2.ItemAlignment = Krypton.Ribbon.RibbonItemAlignment.Near;
            this.kryptonRibbonGroupTriple2.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.buttonSaveFile});
            this.kryptonRibbonGroupTriple2.MaximumSize = Krypton.Ribbon.GroupItemSize.Large;
            this.kryptonRibbonGroupTriple2.MinimumSize = Krypton.Ribbon.GroupItemSize.Large;
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.ButtonType = Krypton.Ribbon.GroupButtonType.Push;
            this.buttonSaveFile.ImageLarge = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile.ImageLarge")));
            this.buttonSaveFile.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile.ImageSmall")));
            this.buttonSaveFile.KeyTip = "SF";
            this.buttonSaveFile.TextLine1 = "Save";
            this.buttonSaveFile.TextLine2 = "File";
            this.buttonSaveFile.ToolTipStyle = Krypton.Toolkit.LabelStyle.SuperTip;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // kryptonRibbonGroupTriple4
            // 
            this.kryptonRibbonGroupTriple4.ItemAlignment = Krypton.Ribbon.RibbonItemAlignment.Near;
            this.kryptonRibbonGroupTriple4.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.buttonLoadFile});
            this.kryptonRibbonGroupTriple4.MaximumSize = Krypton.Ribbon.GroupItemSize.Large;
            this.kryptonRibbonGroupTriple4.MinimumSize = Krypton.Ribbon.GroupItemSize.Large;
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.ButtonType = Krypton.Ribbon.GroupButtonType.Push;
            this.buttonLoadFile.ImageLarge = ((System.Drawing.Image)(resources.GetObject("buttonLoadFile.ImageLarge")));
            this.buttonLoadFile.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonLoadFile.ImageSmall")));
            this.buttonLoadFile.KeyTip = "LF";
            this.buttonLoadFile.TextLine1 = "Load";
            this.buttonLoadFile.TextLine2 = "File";
            this.buttonLoadFile.ToolTipStyle = Krypton.Toolkit.LabelStyle.SuperTip;
            this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
            // 
            // kryptonRibbonGroup3
            // 
            this.kryptonRibbonGroup3.DialogBoxLauncher = false;
            this.kryptonRibbonGroup3.Image = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroup3.Image")));
            this.kryptonRibbonGroup3.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple5});
            this.kryptonRibbonGroup3.TextLine1 = "Visibility";
            // 
            // kryptonRibbonGroupTriple5
            // 
            this.kryptonRibbonGroupTriple5.ItemAlignment = Krypton.Ribbon.RibbonItemAlignment.Near;
            this.kryptonRibbonGroupTriple5.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.buttonHideAll,
            this.buttonShowAll});
            this.kryptonRibbonGroupTriple5.MaximumSize = Krypton.Ribbon.GroupItemSize.Large;
            this.kryptonRibbonGroupTriple5.MinimumSize = Krypton.Ribbon.GroupItemSize.Small;
            // 
            // buttonHideAll
            // 
            this.buttonHideAll.ButtonType = Krypton.Ribbon.GroupButtonType.Push;
            this.buttonHideAll.ImageLarge = ((System.Drawing.Image)(resources.GetObject("buttonHideAll.ImageLarge")));
            this.buttonHideAll.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonHideAll.ImageSmall")));
            this.buttonHideAll.KeyTip = "VH";
            this.buttonHideAll.TextLine1 = "Hide";
            this.buttonHideAll.TextLine2 = "All";
            this.buttonHideAll.ToolTipStyle = Krypton.Toolkit.LabelStyle.SuperTip;
            this.buttonHideAll.Click += new System.EventHandler(this.buttonHideAll_Click);
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.ButtonType = Krypton.Ribbon.GroupButtonType.Push;
            this.buttonShowAll.ImageLarge = ((System.Drawing.Image)(resources.GetObject("buttonShowAll.ImageLarge")));
            this.buttonShowAll.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonShowAll.ImageSmall")));
            this.buttonShowAll.KeyTip = "VS";
            this.buttonShowAll.TextLine1 = "Show";
            this.buttonShowAll.TextLine2 = "All";
            this.buttonShowAll.ToolTipStyle = Krypton.Toolkit.LabelStyle.SuperTip;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonDockableWorkspace);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 115);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Padding = new System.Windows.Forms.Padding(3);
            this.kryptonPanel.Size = new System.Drawing.Size(784, 449);
            this.kryptonPanel.TabIndex = 1;
            // 
            // kryptonDockableWorkspace
            // 
            this.kryptonDockableWorkspace.ActivePage = null;
            this.kryptonDockableWorkspace.AutoHiddenHost = false;
            this.kryptonDockableWorkspace.CompactFlags = ((Krypton.Workspace.CompactFlags)(((Krypton.Workspace.CompactFlags.RemoveEmptyCells | Krypton.Workspace.CompactFlags.RemoveEmptySequences) 
            | Krypton.Workspace.CompactFlags.PromoteLeafs)));
            this.kryptonDockableWorkspace.ContainerBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.kryptonDockableWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDockableWorkspace.Location = new System.Drawing.Point(3, 3);
            this.kryptonDockableWorkspace.Name = "kryptonDockableWorkspace";
            // 
            // 
            // 
            this.kryptonDockableWorkspace.Root.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.kryptonDockableWorkspace.Root.UniqueName = "5462F66039D342065462F66039D34206";
            this.kryptonDockableWorkspace.Root.WorkspaceControl = this.kryptonDockableWorkspace;
            this.kryptonDockableWorkspace.SeparatorStyle = Krypton.Toolkit.SeparatorStyle.LowProfile;
            this.kryptonDockableWorkspace.ShowMaximizeButton = false;
            this.kryptonDockableWorkspace.Size = new System.Drawing.Size(778, 443);
            this.kryptonDockableWorkspace.SplitterWidth = 5;
            this.kryptonDockableWorkspace.TabIndex = 0;
            this.kryptonDockableWorkspace.TabStop = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "xml";
            this.openFileDialog.FileName = "Config.xml";
            this.openFileDialog.Filter = "Xml Files|*.xml|All Files|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "xml";
            this.saveFileDialog.FileName = "Config.xml";
            this.saveFileDialog.Filter = "Xml Files|*.xml|All Files|*.*";
            this.saveFileDialog.InitialDirectory = "c:\\";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 564);
            this.Controls.Add(this.kryptonPanel);
            this.Controls.Add(this.kryptonRibbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Docking Persistence";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Docking.KryptonDockingManager kryptonDockingManager;
        private System.Windows.Forms.ImageList imageListSmall;
        private Krypton.Ribbon.KryptonRibbon kryptonRibbon;
        private Krypton.Ribbon.KryptonRibbonTab tabPersistence;
        private Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup1;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple1;
        private Krypton.Ribbon.KryptonRibbonGroupButton buttonSaveArray1;
        private Krypton.Ribbon.KryptonRibbonGroupButton buttonSaveArray2;
        private Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator1;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel;
        private Krypton.Ribbon.KryptonRibbonGroupButton buttonSaveArray3;
        private Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup2;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple3;
        private Krypton.Ribbon.KryptonRibbonGroupButton buttonLoadArray1;
        private Krypton.Ribbon.KryptonRibbonGroupButton buttonLoadArray2;
        private Krypton.Ribbon.KryptonRibbonGroupButton buttonLoadArray3;
        private Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator2;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple4;
        private Krypton.Ribbon.KryptonRibbonGroupButton buttonLoadFile;
        private Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup3;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple5;
        private Krypton.Ribbon.KryptonRibbonGroupButton buttonHideAll;
        private Krypton.Ribbon.KryptonRibbonGroupButton buttonShowAll;
        private Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem1;
        private Krypton.Docking.KryptonDockableWorkspace kryptonDockableWorkspace;
        private Krypton.Ribbon.KryptonRibbonGroupButton buttonSaveFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private Krypton.Toolkit.KryptonManager kryptonManager;
    }
}

