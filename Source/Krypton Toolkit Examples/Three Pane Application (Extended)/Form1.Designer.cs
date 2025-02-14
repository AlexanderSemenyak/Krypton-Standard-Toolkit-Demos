namespace ThreePaneApplication
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Staff reviews", 1, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Job interviews", 1, 1);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Project meetings", 1, 1);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Appointments", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Administration", 2, 2);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Programmers", 3, 3);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Managers", 4, 4);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Employees", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPaletteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.office2010BlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.office2010SilverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.office2010BlackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.office2007BlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.office2007SilverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.office2007BlackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.sparkleBlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparkleOrangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparklePurpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readingPaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panePositonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripGeneral = new System.Windows.Forms.ToolStrip();
            this.toolStripLoadPalette = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripReadingPane = new System.Windows.Forms.ToolStripButton();
            this.toolStripPosition = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.kryptonPanelMain = new Krypton.Toolkit.KryptonPanel();
            this.kryptonSplitContainerMain = new Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonHeaderGroupNavigation = new Krypton.Toolkit.KryptonHeaderGroup();
            this.treeView = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList();
            this.kryptonSplitContainerDetails = new Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonHeaderGroupDetails = new Krypton.Toolkit.KryptonHeaderGroup();
            this.buttonSpecPrevious = new Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.buttonSpecNext = new Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.kryptonDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.dgValid = new Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn();
            this.dgName = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.dgDescription = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.dgDetails = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.dgDepartment = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.dgCategory = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.kryptonReadingGroupOuter = new Krypton.Toolkit.KryptonGroup();
            this.kryptonReadingLabel = new Krypton.Toolkit.KryptonLabel();
            this.toolStripSparkle = new System.Windows.Forms.ToolStrip();
            this.toolStripSparkleBlue = new System.Windows.Forms.ToolStripButton();
            this.toolStripSparkleOrange = new System.Windows.Forms.ToolStripButton();
            this.toolStripSparklePurple = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2010 = new System.Windows.Forms.ToolStrip();
            this.toolStripOffice2010Blue = new System.Windows.Forms.ToolStripButton();
            this.toolStripOffice2010Silver = new System.Windows.Forms.ToolStripButton();
            this.toolStripOffice2010Black = new System.Windows.Forms.ToolStripButton();
            this.toolStripOther = new System.Windows.Forms.ToolStrip();
            this.toolStripSystem = new System.Windows.Forms.ToolStripButton();
            this.toolStripCustom = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2007 = new System.Windows.Forms.ToolStrip();
            this.toolStripOffice2007Blue = new System.Windows.Forms.ToolStripButton();
            this.toolStripOffice2007Silver = new System.Windows.Forms.ToolStripButton();
            this.toolStripOffice2007Black = new System.Windows.Forms.ToolStripButton();
            this.dataSet = new System.Data.DataSet();
            this.dataTable = new System.Data.DataTable();
            this.colName = new System.Data.DataColumn();
            this.colDescription = new System.Data.DataColumn();
            this.colDetails = new System.Data.DataColumn();
            this.colDepartment = new System.Data.DataColumn();
            this.colCategory = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.kryptonManager = new Krypton.Toolkit.KryptonManager();
            this.kryptonPaletteCustom = new Krypton.Toolkit.KryptonPalette();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menuStrip.SuspendLayout();
            this.toolStripGeneral.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelMain)).BeginInit();
            this.kryptonPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainerMain.Panel1)).BeginInit();
            this.kryptonSplitContainerMain.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainerMain.Panel2)).BeginInit();
            this.kryptonSplitContainerMain.Panel2.SuspendLayout();
            this.kryptonSplitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroupNavigation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroupNavigation.Panel)).BeginInit();
            this.kryptonHeaderGroupNavigation.Panel.SuspendLayout();
            this.kryptonHeaderGroupNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainerDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainerDetails.Panel1)).BeginInit();
            this.kryptonSplitContainerDetails.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainerDetails.Panel2)).BeginInit();
            this.kryptonSplitContainerDetails.Panel2.SuspendLayout();
            this.kryptonSplitContainerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroupDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroupDetails.Panel)).BeginInit();
            this.kryptonHeaderGroupDetails.Panel.SuspendLayout();
            this.kryptonHeaderGroupDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonReadingGroupOuter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonReadingGroupOuter.Panel)).BeginInit();
            this.kryptonReadingGroupOuter.Panel.SuspendLayout();
            this.kryptonReadingGroupOuter.SuspendLayout();
            this.toolStripSparkle.SuspendLayout();
            this.toolStrip2010.SuspendLayout();
            this.toolStripOther.SuspendLayout();
            this.toolStrip2007.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(626, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadPaletteToolStripMenuItem,
            this.toolStripSeparator2,
            this.office2010BlueToolStripMenuItem,
            this.office2010SilverToolStripMenuItem,
            this.office2010BlackToolStripMenuItem,
            this.toolStripSeparator3,
            this.office2007BlueToolStripMenuItem,
            this.office2007SilverToolStripMenuItem,
            this.office2007BlackToolStripMenuItem,
            this.toolStripSeparator4,
            this.sparkleBlueToolStripMenuItem,
            this.sparkleOrangeToolStripMenuItem,
            this.sparklePurpleToolStripMenuItem,
            this.toolStripSeparator5,
            this.systemToolStripMenuItem,
            this.customToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadPaletteToolStripMenuItem
            // 
            this.loadPaletteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loadPaletteToolStripMenuItem.Image")));
            this.loadPaletteToolStripMenuItem.Name = "loadPaletteToolStripMenuItem";
            this.loadPaletteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.loadPaletteToolStripMenuItem.Text = "Load Palette";
            this.loadPaletteToolStripMenuItem.Click += new System.EventHandler(this.loadPaletteToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(161, 6);
            // 
            // office2010BlueToolStripMenuItem
            // 
            this.office2010BlueToolStripMenuItem.Checked = true;
            this.office2010BlueToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.office2010BlueToolStripMenuItem.Name = "office2010BlueToolStripMenuItem";
            this.office2010BlueToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.office2010BlueToolStripMenuItem.Text = "Office 2010 Blue";
            this.office2010BlueToolStripMenuItem.Click += new System.EventHandler(this.toolStripOffice2010Blue_Click);
            // 
            // office2010SilverToolStripMenuItem
            // 
            this.office2010SilverToolStripMenuItem.Name = "office2010SilverToolStripMenuItem";
            this.office2010SilverToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.office2010SilverToolStripMenuItem.Text = "Office 2010 Silver";
            this.office2010SilverToolStripMenuItem.Click += new System.EventHandler(this.toolStripOffice2010Silver_Click);
            // 
            // office2010BlackToolStripMenuItem
            // 
            this.office2010BlackToolStripMenuItem.Name = "office2010BlackToolStripMenuItem";
            this.office2010BlackToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.office2010BlackToolStripMenuItem.Text = "Office 2010 Black";
            this.office2010BlackToolStripMenuItem.Click += new System.EventHandler(this.toolStripOffice2010Black_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
            // 
            // office2007BlueToolStripMenuItem
            // 
            this.office2007BlueToolStripMenuItem.Name = "office2007BlueToolStripMenuItem";
            this.office2007BlueToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.office2007BlueToolStripMenuItem.Text = "Office 2007 Blue";
            this.office2007BlueToolStripMenuItem.Click += new System.EventHandler(this.toolStripOffice2007Blue_Click);
            // 
            // office2007SilverToolStripMenuItem
            // 
            this.office2007SilverToolStripMenuItem.Name = "office2007SilverToolStripMenuItem";
            this.office2007SilverToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.office2007SilverToolStripMenuItem.Text = "Office 2007 Silver";
            this.office2007SilverToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.office2007SilverToolStripMenuItem.Click += new System.EventHandler(this.toolStripOffice2007Silver_Click);
            // 
            // office2007BlackToolStripMenuItem
            // 
            this.office2007BlackToolStripMenuItem.Name = "office2007BlackToolStripMenuItem";
            this.office2007BlackToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.office2007BlackToolStripMenuItem.Text = "Office 2007 Black";
            this.office2007BlackToolStripMenuItem.Click += new System.EventHandler(this.toolStripOffice2007Black_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(161, 6);
            // 
            // sparkleBlueToolStripMenuItem
            // 
            this.sparkleBlueToolStripMenuItem.Name = "sparkleBlueToolStripMenuItem";
            this.sparkleBlueToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.sparkleBlueToolStripMenuItem.Text = "Sparkle Blue";
            this.sparkleBlueToolStripMenuItem.Click += new System.EventHandler(this.toolStripSparkleBlue_Click);
            // 
            // sparkleOrangeToolStripMenuItem
            // 
            this.sparkleOrangeToolStripMenuItem.Name = "sparkleOrangeToolStripMenuItem";
            this.sparkleOrangeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.sparkleOrangeToolStripMenuItem.Text = "Sparkle Orange";
            this.sparkleOrangeToolStripMenuItem.Click += new System.EventHandler(this.toolStripSparkleOrange_Click);
            // 
            // sparklePurpleToolStripMenuItem
            // 
            this.sparklePurpleToolStripMenuItem.Name = "sparklePurpleToolStripMenuItem";
            this.sparklePurpleToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.sparklePurpleToolStripMenuItem.Text = "Sparkle Purple";
            this.sparklePurpleToolStripMenuItem.Click += new System.EventHandler(this.toolStripSparklePurple_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(161, 6);
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.systemToolStripMenuItem.Text = "System";
            this.systemToolStripMenuItem.Click += new System.EventHandler(this.toolStripSystem_Click);
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.customToolStripMenuItem.Text = "Custom";
            this.customToolStripMenuItem.Click += new System.EventHandler(this.toolStripCustom_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(161, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readingPaneToolStripMenuItem,
            this.panePositonToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.toolsToolStripMenuItem.Text = "&Options";
            // 
            // readingPaneToolStripMenuItem
            // 
            this.readingPaneToolStripMenuItem.Name = "readingPaneToolStripMenuItem";
            this.readingPaneToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.readingPaneToolStripMenuItem.Text = "Hide &Reading Pane";
            this.readingPaneToolStripMenuItem.Click += new System.EventHandler(this.readingPaneToolStripMenuItem_Click);
            // 
            // panePositonToolStripMenuItem
            // 
            this.panePositonToolStripMenuItem.Name = "panePositonToolStripMenuItem";
            this.panePositonToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.panePositonToolStripMenuItem.Text = "Reading Pane &Position";
            this.panePositonToolStripMenuItem.Click += new System.EventHandler(this.panePositonToolStripMenuItem_Click);
            // 
            // toolStripGeneral
            // 
            this.toolStripGeneral.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripGeneral.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLoadPalette,
            this.toolStripSeparator1,
            this.toolStripReadingPane,
            this.toolStripPosition});
            this.toolStripGeneral.Location = new System.Drawing.Point(3, 24);
            this.toolStripGeneral.Name = "toolStripGeneral";
            this.toolStripGeneral.Size = new System.Drawing.Size(117, 25);
            this.toolStripGeneral.TabIndex = 1;
            this.toolStripGeneral.Text = "toolStrip1";
            // 
            // toolStripLoadPalette
            // 
            this.toolStripLoadPalette.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLoadPalette.Image")));
            this.toolStripLoadPalette.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLoadPalette.Name = "toolStripLoadPalette";
            this.toolStripLoadPalette.Size = new System.Drawing.Size(53, 22);
            this.toolStripLoadPalette.Text = "Load";
            this.toolStripLoadPalette.ToolTipText = "Load a palette definition";
            this.toolStripLoadPalette.Click += new System.EventHandler(this.toolStripLoadPalette_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripReadingPane
            // 
            this.toolStripReadingPane.CheckOnClick = true;
            this.toolStripReadingPane.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripReadingPane.Image = ((System.Drawing.Image)(resources.GetObject("toolStripReadingPane.Image")));
            this.toolStripReadingPane.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripReadingPane.Name = "toolStripReadingPane";
            this.toolStripReadingPane.Size = new System.Drawing.Size(23, 22);
            this.toolStripReadingPane.ToolTipText = "Show/Hide the reading pane";
            this.toolStripReadingPane.Click += new System.EventHandler(this.toolStripReadingPane_CheckedChanged);
            // 
            // toolStripPosition
            // 
            this.toolStripPosition.CheckOnClick = true;
            this.toolStripPosition.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPosition.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPosition.Image")));
            this.toolStripPosition.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPosition.Name = "toolStripPosition";
            this.toolStripPosition.Size = new System.Drawing.Size(23, 22);
            this.toolStripPosition.ToolTipText = "Show reading pane on right or bottom";
            this.toolStripPosition.Click += new System.EventHandler(this.toolStripPosition_CheckedChanged);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.kryptonPanelMain);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(626, 386);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(626, 485);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripGeneral);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip2010);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripSparkle);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripOther);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip2007);
            // 
            // kryptonPanelMain
            // 
            this.kryptonPanelMain.Controls.Add(this.kryptonSplitContainerMain);
            this.kryptonPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanelMain.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanelMain.Name = "kryptonPanelMain";
            this.kryptonPanelMain.Padding = new System.Windows.Forms.Padding(4);
            this.kryptonPanelMain.Size = new System.Drawing.Size(626, 386);
            this.kryptonPanelMain.TabIndex = 0;
            // 
            // kryptonSplitContainerMain
            // 
            this.kryptonSplitContainerMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.kryptonSplitContainerMain.Location = new System.Drawing.Point(4, 4);
            this.kryptonSplitContainerMain.Name = "kryptonSplitContainerMain";
            this.kryptonSplitContainerMain.Orientation = System.Windows.Forms.Orientation.Vertical;
            // 
            // kryptonSplitContainerMain.Panel1
            // 
            this.kryptonSplitContainerMain.Panel1.Controls.Add(this.kryptonHeaderGroupNavigation);
            this.kryptonSplitContainerMain.Panel1MinSize = 25;
            // 
            // kryptonSplitContainerMain.Panel2
            // 
            this.kryptonSplitContainerMain.Panel2.Controls.Add(this.kryptonSplitContainerDetails);
            this.kryptonSplitContainerMain.Panel2MinSize = 25;
            this.kryptonSplitContainerMain.Size = new System.Drawing.Size(618, 378);
            this.kryptonSplitContainerMain.SplitterDistance = 176;
            this.kryptonSplitContainerMain.SplitterIncrement = 1;
            this.kryptonSplitContainerMain.SplitterWidth = 5;
            this.kryptonSplitContainerMain.TabIndex = 0;
            // 
            // kryptonHeaderGroupNavigation
            // 
            this.kryptonHeaderGroupNavigation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kryptonHeaderGroupNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroupNavigation.HeaderPositionPrimary = Krypton.Toolkit.VisualOrientation.Top;
            this.kryptonHeaderGroupNavigation.HeaderPositionSecondary = Krypton.Toolkit.VisualOrientation.Bottom;
            this.kryptonHeaderGroupNavigation.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroupNavigation.Name = "kryptonHeaderGroupNavigation";
            // 
            // kryptonHeaderGroupNavigation.Panel
            // 
            this.kryptonHeaderGroupNavigation.Panel.Controls.Add(this.treeView);
            this.kryptonHeaderGroupNavigation.Size = new System.Drawing.Size(176, 378);
            this.kryptonHeaderGroupNavigation.TabIndex = 0;
            this.kryptonHeaderGroupNavigation.ValuesPrimary.Heading = "Navigation";
            this.kryptonHeaderGroupNavigation.ValuesPrimary.Image = null;
            this.kryptonHeaderGroupNavigation.ValuesSecondary.Heading = "Select option";
            // 
            // treeView
            // 
            this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.HideSelection = false;
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imageList;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "NodeYearlyReview";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "Staff reviews";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "NodeCandidateInterview";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Text = "Job interviews";
            treeNode3.ImageIndex = 1;
            treeNode3.Name = "NodeProjectMilestone";
            treeNode3.SelectedImageIndex = 1;
            treeNode3.Text = "Project meetings";
            treeNode4.ImageIndex = 0;
            treeNode4.Name = "NodeAppointments";
            treeNode4.SelectedImageIndex = 0;
            treeNode4.Text = "Appointments";
            treeNode5.ImageIndex = 2;
            treeNode5.Name = "NodeAdministration";
            treeNode5.SelectedImageIndex = 2;
            treeNode5.Text = "Administration";
            treeNode6.ImageIndex = 3;
            treeNode6.Name = "Programmers";
            treeNode6.SelectedImageIndex = 3;
            treeNode6.Text = "Programmers";
            treeNode7.ImageIndex = 4;
            treeNode7.Name = "NodeManagers";
            treeNode7.SelectedImageIndex = 4;
            treeNode7.Text = "Managers";
            treeNode8.ImageIndex = 0;
            treeNode8.Name = "NodeEmployees";
            treeNode8.SelectedImageIndex = 0;
            treeNode8.Text = "Employees";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8});
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new System.Drawing.Size(174, 325);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Folder.ico");
            this.imageList.Images.SetKeyName(1, "calendar.png");
            this.imageList.Images.SetKeyName(2, "user2.png");
            this.imageList.Images.SetKeyName(3, "dude1.png");
            this.imageList.Images.SetKeyName(4, "businessman2.png");
            // 
            // kryptonSplitContainerDetails
            // 
            this.kryptonSplitContainerDetails.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainerDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainerDetails.FixedPanel = System.Windows.Forms.FixedPanel.None;
            this.kryptonSplitContainerDetails.Location = new System.Drawing.Point(0, 0);
            this.kryptonSplitContainerDetails.Name = "kryptonSplitContainerDetails";
            this.kryptonSplitContainerDetails.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // kryptonSplitContainerDetails.Panel1
            // 
            this.kryptonSplitContainerDetails.Panel1.Controls.Add(this.kryptonHeaderGroupDetails);
            this.kryptonSplitContainerDetails.Panel1MinSize = 50;
            // 
            // kryptonSplitContainerDetails.Panel2
            // 
            this.kryptonSplitContainerDetails.Panel2.Controls.Add(this.kryptonReadingGroupOuter);
            this.kryptonSplitContainerDetails.Panel2MinSize = 50;
            this.kryptonSplitContainerDetails.Size = new System.Drawing.Size(437, 378);
            this.kryptonSplitContainerDetails.SplitterDistance = 216;
            this.kryptonSplitContainerDetails.SplitterIncrement = 1;
            this.kryptonSplitContainerDetails.SplitterWidth = 5;
            this.kryptonSplitContainerDetails.TabIndex = 0;
            // 
            // kryptonHeaderGroupDetails
            // 
            this.kryptonHeaderGroupDetails.AllowButtonSpecToolTips = true;
            this.kryptonHeaderGroupDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kryptonHeaderGroupDetails.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecHeaderGroup[] {
            this.buttonSpecPrevious,
            this.buttonSpecNext});
            this.kryptonHeaderGroupDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroupDetails.HeaderPositionPrimary = Krypton.Toolkit.VisualOrientation.Top;
            this.kryptonHeaderGroupDetails.HeaderPositionSecondary = Krypton.Toolkit.VisualOrientation.Bottom;
            this.kryptonHeaderGroupDetails.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroupDetails.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroupDetails.Name = "kryptonHeaderGroupDetails";
            // 
            // kryptonHeaderGroupDetails.Panel
            // 
            this.kryptonHeaderGroupDetails.Panel.Controls.Add(this.kryptonDataGridView);
            this.kryptonHeaderGroupDetails.Size = new System.Drawing.Size(437, 216);
            this.kryptonHeaderGroupDetails.TabIndex = 0;
            this.kryptonHeaderGroupDetails.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeaderGroupDetails.ValuesPrimary.Image")));
            // 
            // buttonSpecPrevious
            // 
            this.buttonSpecPrevious.Image = ((System.Drawing.Image)(resources.GetObject("buttonSpecPrevious.Image")));
            this.buttonSpecPrevious.ToolTipTitle = "Move to previous selection";
            this.buttonSpecPrevious.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Previous;
            this.buttonSpecPrevious.UniqueName = "5D8BDAFE5D4E48755D8BDAFE5D4E4875";
            // 
            // buttonSpecNext
            // 
            this.buttonSpecNext.Image = ((System.Drawing.Image)(resources.GetObject("buttonSpecNext.Image")));
            this.buttonSpecNext.ToolTipTitle = "Move to next selection";
            this.buttonSpecNext.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Next;
            this.buttonSpecNext.UniqueName = "8C33B0A305634EC58C33B0A305634EC5";
            // 
            // kryptonDataGridView
            // 
            this.kryptonDataGridView.AllowUserToAddRows = false;
            this.kryptonDataGridView.AllowUserToDeleteRows = false;
            this.kryptonDataGridView.AllowUserToResizeRows = false;
            this.kryptonDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgValid,
            this.dgName,
            this.dgDescription,
            this.dgDetails,
            this.dgDepartment,
            this.dgCategory});
            this.kryptonDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDataGridView.GridStyles.Style = Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.kryptonDataGridView.GridStyles.StyleBackground = Krypton.Toolkit.PaletteBackStyle.ControlClient;
            this.kryptonDataGridView.HideOuterBorders = true;
            this.kryptonDataGridView.Location = new System.Drawing.Point(0, 0);
            this.kryptonDataGridView.MultiSelect = false;
            this.kryptonDataGridView.Name = "kryptonDataGridView";
            this.kryptonDataGridView.ReadOnly = true;
            this.kryptonDataGridView.RowHeadersVisible = false;
            this.kryptonDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kryptonDataGridView.Size = new System.Drawing.Size(435, 184);
            this.kryptonDataGridView.TabIndex = 0;
            this.kryptonDataGridView.SelectionChanged += new System.EventHandler(this.kryptonDataGridView_SelectionChanged);
            // 
            // dgValid
            // 
            this.dgValid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgValid.DataPropertyName = "Valid";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = false;
            this.dgValid.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgValid.FalseValue = null;
            this.dgValid.HeaderText = "Valid";
            this.dgValid.IndeterminateValue = null;
            this.dgValid.Name = "dgValid";
            this.dgValid.ReadOnly = true;
            this.dgValid.TrueValue = null;
            this.dgValid.Width = 42;
            // 
            // dgName
            // 
            this.dgName.DataPropertyName = "Name";
            this.dgName.HeaderText = "Name";
            this.dgName.MaxInputLength = 32767;
            this.dgName.MinimumWidth = 60;
            this.dgName.Name = "dgName";
            this.dgName.ReadOnly = true;
            this.dgName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgName.Width = 120;
            // 
            // dgDescription
            // 
            this.dgDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgDescription.DataPropertyName = "Description";
            this.dgDescription.HeaderText = "Description";
            this.dgDescription.MaxInputLength = 32767;
            this.dgDescription.MinimumWidth = 100;
            this.dgDescription.Name = "dgDescription";
            this.dgDescription.ReadOnly = true;
            this.dgDescription.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgDescription.Width = 272;
            // 
            // dgDetails
            // 
            this.dgDetails.DataPropertyName = "Details";
            this.dgDetails.HeaderText = "Details";
            this.dgDetails.MaxInputLength = 32767;
            this.dgDetails.Name = "dgDetails";
            this.dgDetails.ReadOnly = true;
            this.dgDetails.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDetails.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgDetails.Visible = false;
            this.dgDetails.Width = 100;
            // 
            // dgDepartment
            // 
            this.dgDepartment.DataPropertyName = "Department";
            this.dgDepartment.HeaderText = "Department";
            this.dgDepartment.MaxInputLength = 32767;
            this.dgDepartment.Name = "dgDepartment";
            this.dgDepartment.ReadOnly = true;
            this.dgDepartment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDepartment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgDepartment.Visible = false;
            this.dgDepartment.Width = 100;
            // 
            // dgCategory
            // 
            this.dgCategory.DataPropertyName = "Category";
            this.dgCategory.HeaderText = "Category";
            this.dgCategory.MaxInputLength = 32767;
            this.dgCategory.Name = "dgCategory";
            this.dgCategory.ReadOnly = true;
            this.dgCategory.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgCategory.Visible = false;
            this.dgCategory.Width = 100;
            // 
            // kryptonReadingGroupOuter
            // 
            this.kryptonReadingGroupOuter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kryptonReadingGroupOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonReadingGroupOuter.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate;
            this.kryptonReadingGroupOuter.Location = new System.Drawing.Point(0, 0);
            this.kryptonReadingGroupOuter.Name = "kryptonReadingGroupOuter";
            // 
            // kryptonReadingGroupOuter.Panel
            // 
            this.kryptonReadingGroupOuter.Panel.Controls.Add(this.kryptonReadingLabel);
            this.kryptonReadingGroupOuter.Panel.Padding = new System.Windows.Forms.Padding(5);
            this.kryptonReadingGroupOuter.Size = new System.Drawing.Size(437, 157);
            this.kryptonReadingGroupOuter.TabIndex = 0;
            // 
            // kryptonReadingLabel
            // 
            this.kryptonReadingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonReadingLabel.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonReadingLabel.Location = new System.Drawing.Point(5, 5);
            this.kryptonReadingLabel.Name = "kryptonReadingLabel";
            this.kryptonReadingLabel.Size = new System.Drawing.Size(425, 145);
            this.kryptonReadingLabel.StateCommon.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonReadingLabel.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonReadingLabel.StateCommon.Padding = new System.Windows.Forms.Padding(-1);
            this.kryptonReadingLabel.StateCommon.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonReadingLabel.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonReadingLabel.StateCommon.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonReadingLabel.StateCommon.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonReadingLabel.StateCommon.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonReadingLabel.StateCommon.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True;
            this.kryptonReadingLabel.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonReadingLabel.StateCommon.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonReadingLabel.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonReadingLabel.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonReadingLabel.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonReadingLabel.TabIndex = 0;
            this.kryptonReadingLabel.Values.Text = "";
            // 
            // toolStripSparkle
            // 
            this.toolStripSparkle.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripSparkle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripSparkle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSparkleBlue,
            this.toolStripSparkleOrange,
            this.toolStripSparklePurple});
            this.toolStripSparkle.Location = new System.Drawing.Point(117, 74);
            this.toolStripSparkle.Name = "toolStripSparkle";
            this.toolStripSparkle.Size = new System.Drawing.Size(264, 25);
            this.toolStripSparkle.TabIndex = 5;
            // 
            // toolStripSparkleBlue
            // 
            this.toolStripSparkleBlue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSparkleBlue.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSparkleBlue.Image")));
            this.toolStripSparkleBlue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSparkleBlue.Name = "toolStripSparkleBlue";
            this.toolStripSparkleBlue.Size = new System.Drawing.Size(75, 22);
            this.toolStripSparkleBlue.Text = "Sparkle Blue";
            this.toolStripSparkleBlue.Click += new System.EventHandler(this.toolStripSparkleBlue_Click);
            // 
            // toolStripSparkleOrange
            // 
            this.toolStripSparkleOrange.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSparkleOrange.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSparkleOrange.Image")));
            this.toolStripSparkleOrange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSparkleOrange.Name = "toolStripSparkleOrange";
            this.toolStripSparkleOrange.Size = new System.Drawing.Size(91, 22);
            this.toolStripSparkleOrange.Text = "Sparkle Orange";
            this.toolStripSparkleOrange.Click += new System.EventHandler(this.toolStripSparkleOrange_Click);
            // 
            // toolStripSparklePurple
            // 
            this.toolStripSparklePurple.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSparklePurple.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSparklePurple.Image")));
            this.toolStripSparklePurple.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSparklePurple.Name = "toolStripSparklePurple";
            this.toolStripSparklePurple.Size = new System.Drawing.Size(86, 22);
            this.toolStripSparklePurple.Text = "Sparkle Purple";
            this.toolStripSparklePurple.Click += new System.EventHandler(this.toolStripSparklePurple_Click);
            // 
            // toolStrip2010
            // 
            this.toolStrip2010.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2010.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip2010.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripOffice2010Blue,
            this.toolStripOffice2010Silver,
            this.toolStripOffice2010Black});
            this.toolStrip2010.Location = new System.Drawing.Point(120, 24);
            this.toolStrip2010.Name = "toolStrip2010";
            this.toolStrip2010.Size = new System.Drawing.Size(205, 25);
            this.toolStrip2010.TabIndex = 4;
            // 
            // toolStripOffice2010Blue
            // 
            this.toolStripOffice2010Blue.Checked = true;
            this.toolStripOffice2010Blue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripOffice2010Blue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripOffice2010Blue.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOffice2010Blue.Image")));
            this.toolStripOffice2010Blue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOffice2010Blue.Name = "toolStripOffice2010Blue";
            this.toolStripOffice2010Blue.Size = new System.Drawing.Size(61, 22);
            this.toolStripOffice2010Blue.Text = "2010 Blue";
            this.toolStripOffice2010Blue.ToolTipText = "Use the built in preofessional office palette";
            this.toolStripOffice2010Blue.Click += new System.EventHandler(this.toolStripOffice2010Blue_Click);
            // 
            // toolStripOffice2010Silver
            // 
            this.toolStripOffice2010Silver.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripOffice2010Silver.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOffice2010Silver.Image")));
            this.toolStripOffice2010Silver.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOffice2010Silver.Name = "toolStripOffice2010Silver";
            this.toolStripOffice2010Silver.Size = new System.Drawing.Size(66, 22);
            this.toolStripOffice2010Silver.Text = "2010 Silver";
            this.toolStripOffice2010Silver.ToolTipText = "Use the built in preofessional office palette";
            this.toolStripOffice2010Silver.Click += new System.EventHandler(this.toolStripOffice2010Silver_Click);
            // 
            // toolStripOffice2010Black
            // 
            this.toolStripOffice2010Black.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripOffice2010Black.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOffice2010Black.Image")));
            this.toolStripOffice2010Black.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOffice2010Black.Name = "toolStripOffice2010Black";
            this.toolStripOffice2010Black.Size = new System.Drawing.Size(66, 22);
            this.toolStripOffice2010Black.Text = "2010 Black";
            this.toolStripOffice2010Black.ToolTipText = "Use the built in preofessional office palette";
            this.toolStripOffice2010Black.Click += new System.EventHandler(this.toolStripOffice2010Black_Click);
            // 
            // toolStripOther
            // 
            this.toolStripOther.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripOther.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripOther.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSystem,
            this.toolStripCustom});
            this.toolStripOther.Location = new System.Drawing.Point(3, 74);
            this.toolStripOther.Name = "toolStripOther";
            this.toolStripOther.Size = new System.Drawing.Size(114, 25);
            this.toolStripOther.TabIndex = 3;
            // 
            // toolStripSystem
            // 
            this.toolStripSystem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSystem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSystem.Image")));
            this.toolStripSystem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSystem.Name = "toolStripSystem";
            this.toolStripSystem.Size = new System.Drawing.Size(49, 22);
            this.toolStripSystem.Text = "System";
            this.toolStripSystem.ToolTipText = "Use the built in professional system palette";
            this.toolStripSystem.Click += new System.EventHandler(this.toolStripSystem_Click);
            // 
            // toolStripCustom
            // 
            this.toolStripCustom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripCustom.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCustom.Image")));
            this.toolStripCustom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCustom.Name = "toolStripCustom";
            this.toolStripCustom.Size = new System.Drawing.Size(53, 22);
            this.toolStripCustom.Text = "Custom";
            this.toolStripCustom.ToolTipText = "Use a custom palette";
            this.toolStripCustom.Click += new System.EventHandler(this.toolStripCustom_Click);
            // 
            // toolStrip2007
            // 
            this.toolStrip2007.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2007.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip2007.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripOffice2007Blue,
            this.toolStripOffice2007Silver,
            this.toolStripOffice2007Black});
            this.toolStrip2007.Location = new System.Drawing.Point(3, 49);
            this.toolStrip2007.Name = "toolStrip2007";
            this.toolStrip2007.Size = new System.Drawing.Size(205, 25);
            this.toolStrip2007.TabIndex = 2;
            // 
            // toolStripOffice2007Blue
            // 
            this.toolStripOffice2007Blue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripOffice2007Blue.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOffice2007Blue.Image")));
            this.toolStripOffice2007Blue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOffice2007Blue.Name = "toolStripOffice2007Blue";
            this.toolStripOffice2007Blue.Size = new System.Drawing.Size(61, 22);
            this.toolStripOffice2007Blue.Text = "2007 Blue";
            this.toolStripOffice2007Blue.ToolTipText = "Use the built in preofessional office palette";
            this.toolStripOffice2007Blue.Click += new System.EventHandler(this.toolStripOffice2007Blue_Click);
            // 
            // toolStripOffice2007Silver
            // 
            this.toolStripOffice2007Silver.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripOffice2007Silver.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOffice2007Silver.Image")));
            this.toolStripOffice2007Silver.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOffice2007Silver.Name = "toolStripOffice2007Silver";
            this.toolStripOffice2007Silver.Size = new System.Drawing.Size(66, 22);
            this.toolStripOffice2007Silver.Text = "2007 Silver";
            this.toolStripOffice2007Silver.ToolTipText = "Use the built in preofessional office palette";
            this.toolStripOffice2007Silver.Click += new System.EventHandler(this.toolStripOffice2007Silver_Click);
            // 
            // toolStripOffice2007Black
            // 
            this.toolStripOffice2007Black.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripOffice2007Black.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOffice2007Black.Image")));
            this.toolStripOffice2007Black.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOffice2007Black.Name = "toolStripOffice2007Black";
            this.toolStripOffice2007Black.Size = new System.Drawing.Size(66, 22);
            this.toolStripOffice2007Black.Text = "2007 Black";
            this.toolStripOffice2007Black.ToolTipText = "Use the built in preofessional office palette";
            this.toolStripOffice2007Black.Click += new System.EventHandler(this.toolStripOffice2007Black_Click);
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "NewDataSet";
            this.dataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable});
            // 
            // dataTable
            // 
            this.dataTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.colName,
            this.colDescription,
            this.colDetails,
            this.colDepartment,
            this.colCategory,
            this.dataColumn1});
            this.dataTable.TableName = "TestTable";
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.ColumnName = "Name";
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.ColumnName = "Description";
            this.colDescription.DefaultValue = "";
            // 
            // colDetails
            // 
            this.colDetails.ColumnName = "Details";
            // 
            // colDepartment
            // 
            this.colDepartment.ColumnName = "Department";
            // 
            // colCategory
            // 
            this.colCategory.ColumnName = "Category";
            // 
            // dataColumn1
            // 
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.ColumnName = "Valid";
            this.dataColumn1.DataType = typeof(bool);
            this.dataColumn1.DefaultValue = true;
            // 
            // kryptonManager
            // 
            this.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteModeManager.Office2007Blue;
            // 
            // kryptonPaletteCustom
            // 
            this.kryptonPaletteCustom.AllowFormChrome = Krypton.Toolkit.InheritBool.False;
            this.kryptonPaletteCustom.BasePaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.kryptonPaletteCustom.BaseRenderMode = Krypton.Toolkit.RendererMode.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateDisabled.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateDisabled.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateDisabled.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateDisabled.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateDisabled.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.False;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.Padding = new System.Windows.Forms.Padding(3);
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedPressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedPressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedPressed.Content.Padding = new System.Windows.Forms.Padding(5, 5, 1, 1);
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.Rounding = 3F;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.Width = 2;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.Padding = new System.Windows.Forms.Padding(3);
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Border.Color1 = System.Drawing.Color.Silver;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.Color1 = System.Drawing.Color.Silver;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Silver;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StatePressed.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StatePressed.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StatePressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StatePressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StatePressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StatePressed.Content.Padding = new System.Windows.Forms.Padding(5, 5, 1, 1);
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateTracking.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateDisabled.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateDisabled.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateDisabled.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateDisabled.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateDisabled.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.False;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.Padding = new System.Windows.Forms.Padding(3);
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.OverrideDefault.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.OverrideDefault.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.OverrideDefault.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(227)))));
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.ControlStyles.ControlCommon.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ControlStyles.ControlCommon.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteCustom.ControlStyles.ControlCommon.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ControlStyles.ControlCommon.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteCustom.ControlStyles.ControlCommon.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPaletteCustom.ControlStyles.ControlCommon.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ControlStyles.ControlCommon.StateCommon.Border.Rounding = 9F;
            this.kryptonPaletteCustom.ControlStyles.ControlCommon.StateCommon.Border.Width = 3;
            this.kryptonPaletteCustom.ControlStyles.ControlCommon.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonPaletteCustom.ControlStyles.ControlCommon.StateDisabled.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ControlStyles.ControlCommon.StateDisabled.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ControlStyles.ControlCommon.StateDisabled.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ControlStyles.ControlCommon.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteCustom.ControlStyles.ControlCommon.StateDisabled.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.ControlStyles.ControlCommon.StateDisabled.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ControlStyles.ControlCommon.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(212)))), ((int)(((byte)(192)))));
            this.kryptonPaletteCustom.ControlStyles.ControlCommon.StateNormal.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ControlStyles.ControlCommon.StateNormal.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ControlStyles.ControlCommon.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ControlStyles.ControlCommon.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteCustom.ControlStyles.ControlCommon.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.ControlStyles.ControlCommon.StateNormal.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ControlStyles.ControlToolTip.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteCustom.ControlStyles.ControlToolTip.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ControlStyles.ControlToolTip.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteCustom.ControlStyles.ControlToolTip.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ControlStyles.ControlToolTip.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.ControlStyles.ControlToolTip.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ControlStyles.ControlToolTip.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.ControlStyles.ControlToolTip.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteCustom.ControlStyles.ControlToolTip.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ControlStyles.ControlToolTip.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteCustom.ControlStyles.ControlToolTip.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ControlStyles.ControlToolTip.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteCustom.ControlStyles.ControlToolTip.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.ControlStyles.ControlToolTip.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.Red;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.DataCell.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.DataCell.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.DataCell.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.DataCell.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.DataCell.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.DataCell.Border.Rounding = 0F;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.DataCell.Border.Width = 0;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(213)))), ((int)(((byte)(194)))));
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Red;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.Rounding = 0F;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.Width = 0;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateSelected.DataCell.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateSelected.DataCell.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateSelected.DataCell.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateSelected.DataCell.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateSelected.DataCell.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateSelected.DataCell.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.White;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateSelected.DataCell.Content.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateSelected.DataCell.Content.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateSelected.DataCell.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateSelected.DataCell.Content.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateSelected.DataCell.Content.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateSelected.DataCell.Content.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateSelected.DataCell.Content.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateSelected.DataCell.Content.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.GridStyles.GridCommon.StateSelected.DataCell.Content.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteCustom.HeaderGroup.StateCommon.DockActiveHeaderPadding = new System.Windows.Forms.Padding(-1);
            this.kryptonPaletteCustom.HeaderGroup.StateCommon.DockInactiveHeaderPadding = new System.Windows.Forms.Padding(-1);
            this.kryptonPaletteCustom.HeaderGroup.StateCommon.OverlayHeaders = Krypton.Toolkit.InheritBool.False;
            this.kryptonPaletteCustom.HeaderGroup.StateCommon.PrimaryHeaderPadding = new System.Windows.Forms.Padding(3);
            this.kryptonPaletteCustom.HeaderGroup.StateCommon.SecondaryHeaderPadding = new System.Windows.Forms.Padding(3);
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Border.Rounding = 7F;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Border.Width = 3;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(-1);
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.AdjacentGap = 2;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 1, 10, 1);
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.Color1 = System.Drawing.Color.Silver;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Silver;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateDisabled.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateDisabled.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateDisabled.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateDisabled.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateDisabled.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(213)))), ((int)(((byte)(194)))));
            this.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateDisabled.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateDisabled.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateDisabled.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateDisabled.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateDisabled.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(213)))), ((int)(((byte)(194)))));
            this.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.LabelStyles.LabelToolTip.StateCommon.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.LabelStyles.LabelToolTip.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.LabelStyles.LabelToolTip.StateCommon.LongText.Color1 = System.Drawing.Color.White;
            this.kryptonPaletteCustom.LabelStyles.LabelToolTip.StateCommon.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.LabelStyles.LabelToolTip.StateCommon.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.LabelStyles.LabelToolTip.StateCommon.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteCustom.LabelStyles.LabelToolTip.StateCommon.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.LabelStyles.LabelToolTip.StateCommon.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.LabelStyles.LabelToolTip.StateCommon.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.LabelStyles.LabelToolTip.StateCommon.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.LabelStyles.LabelToolTip.StateCommon.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteCustom.LabelStyles.LabelToolTip.StateCommon.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.LabelStyles.LabelToolTip.StateCommon.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.LabelStyles.LabelToolTip.StateCommon.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteCustom.LabelStyles.LabelToolTip.StateCommon.Padding = new System.Windows.Forms.Padding(-1);
            this.kryptonPaletteCustom.LabelStyles.LabelToolTip.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonPaletteCustom.LabelStyles.LabelToolTip.StateCommon.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.LabelStyles.LabelToolTip.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.LabelStyles.LabelToolTip.StateCommon.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteCustom.LabelStyles.LabelToolTip.StateCommon.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.LabelStyles.LabelToolTip.StateCommon.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.LabelStyles.LabelToolTip.StateCommon.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.LabelStyles.LabelToolTip.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.LabelStyles.LabelToolTip.StateCommon.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteCustom.LabelStyles.LabelToolTip.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.LabelStyles.LabelToolTip.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.LabelStyles.LabelToolTip.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(212)))), ((int)(((byte)(192)))));
            this.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateCommon.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateCommon.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateCommon.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateCommon.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.PanelStyles.PanelClient.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(227)))));
            this.kryptonPaletteCustom.PanelStyles.PanelClient.StateCommon.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.PanelStyles.PanelClient.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.PanelStyles.PanelClient.StateCommon.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.PanelStyles.PanelClient.StateCommon.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.PanelStyles.PanelClient.StateCommon.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.PanelStyles.PanelClient.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.PanelStyles.PanelCommon.StateCommon.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.PanelStyles.PanelCommon.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteCustom.PanelStyles.PanelCommon.StateCommon.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.PanelStyles.PanelCommon.StateCommon.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.PanelStyles.PanelCommon.StateCommon.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.PanelStyles.PanelCommon.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonCheckedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonCheckedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonCheckedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonCheckedHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonCheckedHighlightBorder = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonPressedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonPressedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonPressedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonPressedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonPressedHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonPressedHighlightBorder = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonSelectedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonSelectedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonSelectedHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonSelectedHighlightBorder = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.CheckBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.CheckPressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.CheckSelectedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.OverflowButtonGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.OverflowButtonGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(144)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.OverflowButtonGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Grip.GripDark = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(133)))), ((int)(((byte)(215)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Grip.GripLight = System.Drawing.Color.Transparent;
            this.kryptonPaletteCustom.ToolMenuStatus.Menu.ImageMarginGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Menu.ImageMarginGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Menu.ImageMarginGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Menu.ImageMarginRevealedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Menu.ImageMarginRevealedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Menu.ImageMarginRevealedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Menu.MenuBorder = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Menu.MenuItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Menu.MenuItemPressedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Menu.MenuItemPressedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Menu.MenuItemPressedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Menu.MenuItemSelected = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Menu.MenuItemSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Menu.MenuItemSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Menu.MenuItemText = System.Drawing.Color.White;
            this.kryptonPaletteCustom.ToolMenuStatus.MenuStrip.MenuStripGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteCustom.ToolMenuStatus.MenuStrip.MenuStripGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteCustom.ToolMenuStatus.MenuStrip.MenuStripText = System.Drawing.Color.WhiteSmoke;
            this.kryptonPaletteCustom.ToolMenuStatus.Rafting.RaftingContainerGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Rafting.RaftingContainerGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Separator.SeparatorDark = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Separator.SeparatorLight = System.Drawing.Color.Transparent;
            this.kryptonPaletteCustom.ToolMenuStatus.StatusStrip.StatusStripGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteCustom.ToolMenuStatus.StatusStrip.StatusStripGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteCustom.ToolMenuStatus.StatusStrip.StatusStripText = System.Drawing.Color.WhiteSmoke;
            this.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripBorder = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(144)))));
            this.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripContentPanelGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(227)))));
            this.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripContentPanelGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(227)))));
            this.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripDropDownBackground = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(144)))));
            this.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(144)))));
            this.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(144)))));
            this.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripPanelGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripPanelGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripText = System.Drawing.Color.WhiteSmoke;
            this.kryptonPaletteCustom.ToolMenuStatus.UseRoundedEdges = Krypton.Toolkit.InheritBool.False;
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip.Location = new System.Drawing.Point(0, 485);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip.Size = new System.Drawing.Size(626, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 507);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(320, 286);
            this.Name = "Form1";
            this.Text = "Three Pane Application (Extended)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SystemColorsChanged += new System.EventHandler(this.Form1_SystemColorsChanged);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStripGeneral.ResumeLayout(false);
            this.toolStripGeneral.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelMain)).EndInit();
            this.kryptonPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainerMain.Panel1)).EndInit();
            this.kryptonSplitContainerMain.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainerMain.Panel2)).EndInit();
            this.kryptonSplitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainerMain)).EndInit();
            this.kryptonSplitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroupNavigation.Panel)).EndInit();
            this.kryptonHeaderGroupNavigation.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroupNavigation)).EndInit();
            this.kryptonHeaderGroupNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainerDetails.Panel1)).EndInit();
            this.kryptonSplitContainerDetails.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainerDetails.Panel2)).EndInit();
            this.kryptonSplitContainerDetails.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainerDetails)).EndInit();
            this.kryptonSplitContainerDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroupDetails.Panel)).EndInit();
            this.kryptonHeaderGroupDetails.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroupDetails)).EndInit();
            this.kryptonHeaderGroupDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonReadingGroupOuter.Panel)).EndInit();
            this.kryptonReadingGroupOuter.Panel.ResumeLayout(false);
            this.kryptonReadingGroupOuter.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonReadingGroupOuter)).EndInit();
            this.kryptonReadingGroupOuter.ResumeLayout(false);
            this.toolStripSparkle.ResumeLayout(false);
            this.toolStripSparkle.PerformLayout();
            this.toolStrip2010.ResumeLayout(false);
            this.toolStrip2010.PerformLayout();
            this.toolStripOther.ResumeLayout(false);
            this.toolStripOther.PerformLayout();
            this.toolStrip2007.ResumeLayout(false);
            this.toolStrip2007.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readingPaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panePositonToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripGeneral;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private Krypton.Toolkit.KryptonPanel kryptonPanelMain;
        private Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainerMain;
        private Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroupNavigation;
        private Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainerDetails;
        private Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroupDetails;
        private Krypton.Toolkit.KryptonGroup kryptonReadingGroupOuter;
        private Krypton.Toolkit.KryptonManager kryptonManager;
        private Krypton.Toolkit.KryptonPalette kryptonPaletteCustom;
        private System.Windows.Forms.ImageList imageList;
        private Krypton.Toolkit.KryptonLabel kryptonReadingLabel;
        private System.Windows.Forms.ToolStripMenuItem loadPaletteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ToolStripButton toolStripLoadPalette;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private Krypton.Toolkit.ButtonSpecHeaderGroup buttonSpecPrevious;
        private Krypton.Toolkit.ButtonSpecHeaderGroup buttonSpecNext;
        private System.Windows.Forms.ToolStripMenuItem office2007BlueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem office2007SilverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem office2007BlackToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView;
        private System.Data.DataSet dataSet;
        private System.Data.DataTable dataTable;
        private System.Data.DataColumn colName;
        private System.Data.DataColumn colDescription;
        private System.Data.DataColumn colDetails;
        private System.Data.DataColumn colDepartment;
        private System.Data.DataColumn colCategory;
        private System.Data.DataColumn dataColumn1;
        private Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn dgValid;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn dgName;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn dgDescription;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn dgDetails;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn dgDepartment;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn dgCategory;
        private System.Windows.Forms.ToolStripMenuItem sparklePurpleToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip2007;
        private System.Windows.Forms.ToolStripMenuItem office2010BlueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem office2010SilverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem office2010BlackToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem sparkleBlueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparkleOrangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripReadingPane;
        private System.Windows.Forms.ToolStripButton toolStripPosition;
        private System.Windows.Forms.ToolStripButton toolStripOffice2007Blue;
        private System.Windows.Forms.ToolStripButton toolStripOffice2007Silver;
        private System.Windows.Forms.ToolStripButton toolStripOffice2007Black;
        private System.Windows.Forms.ToolStrip toolStripOther;
        private System.Windows.Forms.ToolStripButton toolStripSystem;
        private System.Windows.Forms.ToolStripButton toolStripCustom;
        private System.Windows.Forms.ToolStrip toolStrip2010;
        private System.Windows.Forms.ToolStripButton toolStripOffice2010Blue;
        private System.Windows.Forms.ToolStripButton toolStripOffice2010Silver;
        private System.Windows.Forms.ToolStripButton toolStripOffice2010Black;
        private System.Windows.Forms.ToolStrip toolStripSparkle;
        private System.Windows.Forms.ToolStripButton toolStripSparkleBlue;
        private System.Windows.Forms.ToolStripButton toolStripSparkleOrange;
        private System.Windows.Forms.ToolStripButton toolStripSparklePurple;
    }
}

