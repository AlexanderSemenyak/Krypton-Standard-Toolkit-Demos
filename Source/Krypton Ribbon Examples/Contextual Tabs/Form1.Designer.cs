namespace ContextualTabs
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
            this.kryptonRibbon = new Krypton.Ribbon.KryptonRibbon();
            this.kryptonContextMenuItem1 = new Krypton.Toolkit.KryptonContextMenuItem();
            this.contextDefRed = new Krypton.Ribbon.KryptonRibbonContext();
            this.contextDefGreen = new Krypton.Ribbon.KryptonRibbonContext();
            this.tabHome = new Krypton.Ribbon.KryptonRibbonTab();
            this.contextRed = new Krypton.Ribbon.KryptonRibbonTab();
            this.contextGreen1 = new Krypton.Ribbon.KryptonRibbonTab();
            this.contextGreen2 = new Krypton.Ribbon.KryptonRibbonTab();
            this.labelOffice2007Styles = new Krypton.Toolkit.KryptonPanel();
            this.groupOffice2007Styles = new Krypton.Toolkit.KryptonGroup();
            this.radioOffice2010Black = new Krypton.Toolkit.KryptonRadioButton();
            this.radioOffice2010Silver = new Krypton.Toolkit.KryptonRadioButton();
            this.radioOffice2010Blue = new Krypton.Toolkit.KryptonRadioButton();
            this.radioSparkleOrange = new Krypton.Toolkit.KryptonRadioButton();
            this.radioSparklePurple = new Krypton.Toolkit.KryptonRadioButton();
            this.radioSparkleBlue = new Krypton.Toolkit.KryptonRadioButton();
            this.radioSystem = new Krypton.Toolkit.KryptonRadioButton();
            this.radioOffice2003 = new Krypton.Toolkit.KryptonRadioButton();
            this.radioOffice2007Black = new Krypton.Toolkit.KryptonRadioButton();
            this.radioOffice2007Silver = new Krypton.Toolkit.KryptonRadioButton();
            this.radioOffice2007Blue = new Krypton.Toolkit.KryptonRadioButton();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.groupAddContext = new Krypton.Toolkit.KryptonGroup();
            this.buttonAddContext = new Krypton.Toolkit.KryptonButton();
            this.panelContextColor = new Krypton.Toolkit.KryptonPanel();
            this.buttonEditColor = new Krypton.Toolkit.KryptonButton();
            this.labelContextColor = new Krypton.Toolkit.KryptonLabel();
            this.textBoxContextTitle = new Krypton.Toolkit.KryptonTextBox();
            this.labelContextTitle = new Krypton.Toolkit.KryptonLabel();
            this.labelContextName = new Krypton.Toolkit.KryptonLabel();
            this.textBoxContextName = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.groupSelectedContexts = new Krypton.Toolkit.KryptonGroup();
            this.labelSelectedContexts = new Krypton.Toolkit.KryptonLabel();
            this.buttonSelectedApply = new Krypton.Toolkit.KryptonButton();
            this.textBoxSelectedContexts = new Krypton.Toolkit.KryptonTextBox();
            this.labelContextsInstructions = new Krypton.Toolkit.KryptonLabel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.kryptonManager = new Krypton.Toolkit.KryptonManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelOffice2007Styles)).BeginInit();
            this.labelOffice2007Styles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupOffice2007Styles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupOffice2007Styles.Panel)).BeginInit();
            this.groupOffice2007Styles.Panel.SuspendLayout();
            this.groupOffice2007Styles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupAddContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupAddContext.Panel)).BeginInit();
            this.groupAddContext.Panel.SuspendLayout();
            this.groupAddContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelContextColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupSelectedContexts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupSelectedContexts.Panel)).BeginInit();
            this.groupSelectedContexts.Panel.SuspendLayout();
            this.groupSelectedContexts.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonRibbon
            // 
            this.kryptonRibbon.AllowFormIntegrate = true;
            this.kryptonRibbon.HideRibbonSize = new System.Drawing.Size(300, 250);
            this.kryptonRibbon.InDesignHelperMode = true;
            this.kryptonRibbon.Name = "kryptonRibbon";
            this.kryptonRibbon.QATLocation = Krypton.Ribbon.QATLocation.Above;
            this.kryptonRibbon.RibbonAppButton.AppButtonMaxRecentSize = new System.Drawing.Size(350, 350);
            this.kryptonRibbon.RibbonAppButton.AppButtonMenuItems.AddRange(new Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItem1});
            this.kryptonRibbon.RibbonAppButton.AppButtonMinRecentSize = new System.Drawing.Size(250, 250);
            this.kryptonRibbon.RibbonAppButton.AppButtonShowRecentDocs = false;
            this.kryptonRibbon.RibbonAppButton.AppButtonToolTipStyle = Krypton.Toolkit.LabelStyle.SuperTip;
            this.kryptonRibbon.RibbonContexts.AddRange(new Krypton.Ribbon.KryptonRibbonContext[] {
            this.contextDefRed,
            this.contextDefGreen});
            this.kryptonRibbon.RibbonTabs.AddRange(new Krypton.Ribbon.KryptonRibbonTab[] {
            this.tabHome,
            this.contextRed,
            this.contextGreen1,
            this.contextGreen2});
            this.kryptonRibbon.SelectedContext = "Red,Green";
            this.kryptonRibbon.SelectedTab = this.contextGreen1;
            this.kryptonRibbon.Size = new System.Drawing.Size(594, 115);
            this.kryptonRibbon.TabIndex = 0;
            // 
            // kryptonContextMenuItem1
            // 
            this.kryptonContextMenuItem1.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.kryptonContextMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("kryptonContextMenuItem1.Image")));
            this.kryptonContextMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.None;
            this.kryptonContextMenuItem1.Text = "E&xit";
            this.kryptonContextMenuItem1.Click += new System.EventHandler(this.appMenu_Click);
            // 
            // contextDefRed
            // 
            this.contextDefRed.ContextColor = System.Drawing.Color.Red;
            this.contextDefRed.ContextName = "Red";
            this.contextDefRed.ContextTitle = "Red";
            // 
            // contextDefGreen
            // 
            this.contextDefGreen.ContextColor = System.Drawing.Color.LimeGreen;
            this.contextDefGreen.ContextName = "Green";
            this.contextDefGreen.ContextTitle = "Green";
            // 
            // tabHome
            // 
            this.tabHome.Text = "Home";
            // 
            // contextRed
            // 
            this.contextRed.ContextName = "Red";
            this.contextRed.Text = "Red";
            // 
            // contextGreen1
            // 
            this.contextGreen1.ContextName = "Green";
            this.contextGreen1.Text = "Green1";
            // 
            // contextGreen2
            // 
            this.contextGreen2.ContextName = "Green";
            this.contextGreen2.Text = "Green2";
            // 
            // labelOffice2007Styles
            // 
            this.labelOffice2007Styles.Controls.Add(this.groupOffice2007Styles);
            this.labelOffice2007Styles.Controls.Add(this.groupAddContext);
            this.labelOffice2007Styles.Controls.Add(this.groupSelectedContexts);
            this.labelOffice2007Styles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOffice2007Styles.Location = new System.Drawing.Point(0, 115);
            this.labelOffice2007Styles.Name = "labelOffice2007Styles";
            this.labelOffice2007Styles.Size = new System.Drawing.Size(594, 373);
            this.labelOffice2007Styles.TabIndex = 1;
            // 
            // groupOffice2007Styles
            // 
            this.groupOffice2007Styles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupOffice2007Styles.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate;
            this.groupOffice2007Styles.Location = new System.Drawing.Point(401, 16);
            this.groupOffice2007Styles.Name = "groupOffice2007Styles";
            // 
            // groupOffice2007Styles.Panel
            // 
            this.groupOffice2007Styles.Panel.Controls.Add(this.radioOffice2010Black);
            this.groupOffice2007Styles.Panel.Controls.Add(this.radioOffice2010Silver);
            this.groupOffice2007Styles.Panel.Controls.Add(this.radioOffice2010Blue);
            this.groupOffice2007Styles.Panel.Controls.Add(this.radioSparkleOrange);
            this.groupOffice2007Styles.Panel.Controls.Add(this.radioSparklePurple);
            this.groupOffice2007Styles.Panel.Controls.Add(this.radioSparkleBlue);
            this.groupOffice2007Styles.Panel.Controls.Add(this.radioSystem);
            this.groupOffice2007Styles.Panel.Controls.Add(this.radioOffice2003);
            this.groupOffice2007Styles.Panel.Controls.Add(this.radioOffice2007Black);
            this.groupOffice2007Styles.Panel.Controls.Add(this.radioOffice2007Silver);
            this.groupOffice2007Styles.Panel.Controls.Add(this.radioOffice2007Blue);
            this.groupOffice2007Styles.Panel.Controls.Add(this.kryptonLabel2);
            this.groupOffice2007Styles.Size = new System.Drawing.Size(180, 305);
            this.groupOffice2007Styles.TabIndex = 0;
            // 
            // radioOffice2010Black
            // 
            this.radioOffice2010Black.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.radioOffice2010Black.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.radioOffice2010Black.Location = new System.Drawing.Point(20, 84);
            this.radioOffice2010Black.Name = "radioOffice2010Black";
            this.radioOffice2010Black.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.radioOffice2010Black.Size = new System.Drawing.Size(125, 20);
            this.radioOffice2010Black.TabIndex = 3;
            this.radioOffice2010Black.Values.Text = "Office 2010 - Black";
            this.radioOffice2010Black.CheckedChanged += new System.EventHandler(this.radioOffice2010Black_CheckedChanged);
            // 
            // radioOffice2010Silver
            // 
            this.radioOffice2010Silver.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.radioOffice2010Silver.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.radioOffice2010Silver.Location = new System.Drawing.Point(20, 61);
            this.radioOffice2010Silver.Name = "radioOffice2010Silver";
            this.radioOffice2010Silver.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.radioOffice2010Silver.Size = new System.Drawing.Size(126, 20);
            this.radioOffice2010Silver.TabIndex = 2;
            this.radioOffice2010Silver.Values.Text = "Office 2010 - Silver";
            this.radioOffice2010Silver.CheckedChanged += new System.EventHandler(this.radioOffice2010Silver_CheckedChanged);
            // 
            // radioOffice2010Blue
            // 
            this.radioOffice2010Blue.Checked = true;
            this.radioOffice2010Blue.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.radioOffice2010Blue.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.radioOffice2010Blue.Location = new System.Drawing.Point(20, 38);
            this.radioOffice2010Blue.Name = "radioOffice2010Blue";
            this.radioOffice2010Blue.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.radioOffice2010Blue.Size = new System.Drawing.Size(120, 20);
            this.radioOffice2010Blue.TabIndex = 1;
            this.radioOffice2010Blue.Values.Text = "Office 2010 - Blue";
            this.radioOffice2010Blue.CheckedChanged += new System.EventHandler(this.radioOffice2010Blue_CheckedChanged);
            // 
            // radioSparkleOrange
            // 
            this.radioSparkleOrange.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.radioSparkleOrange.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.radioSparkleOrange.Location = new System.Drawing.Point(20, 222);
            this.radioSparkleOrange.Name = "radioSparkleOrange";
            this.radioSparkleOrange.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.radioSparkleOrange.Size = new System.Drawing.Size(115, 20);
            this.radioSparkleOrange.TabIndex = 9;
            this.radioSparkleOrange.Values.Text = "Sparkle - Orange";
            this.radioSparkleOrange.CheckedChanged += new System.EventHandler(this.radioSparkleOrange_CheckedChanged);
            // 
            // radioSparklePurple
            // 
            this.radioSparklePurple.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.radioSparklePurple.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.radioSparklePurple.Location = new System.Drawing.Point(20, 245);
            this.radioSparklePurple.Name = "radioSparklePurple";
            this.radioSparklePurple.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.radioSparklePurple.Size = new System.Drawing.Size(109, 20);
            this.radioSparklePurple.TabIndex = 10;
            this.radioSparklePurple.Values.Text = "Sparkle - Purple";
            this.radioSparklePurple.CheckedChanged += new System.EventHandler(this.radioSparklePurple_CheckedChanged);
            // 
            // radioSparkleBlue
            // 
            this.radioSparkleBlue.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.radioSparkleBlue.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.radioSparkleBlue.Location = new System.Drawing.Point(20, 199);
            this.radioSparkleBlue.Name = "radioSparkleBlue";
            this.radioSparkleBlue.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.radioSparkleBlue.Size = new System.Drawing.Size(98, 20);
            this.radioSparkleBlue.TabIndex = 8;
            this.radioSparkleBlue.Values.Text = "Sparkle - Blue";
            this.radioSparkleBlue.CheckedChanged += new System.EventHandler(this.radioSparkleBlue_CheckedChanged);
            // 
            // radioSystem
            // 
            this.radioSystem.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.radioSystem.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.radioSystem.Location = new System.Drawing.Point(21, 268);
            this.radioSystem.Name = "radioSystem";
            this.radioSystem.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.radioSystem.Size = new System.Drawing.Size(62, 20);
            this.radioSystem.TabIndex = 11;
            this.radioSystem.Values.Text = "System";
            this.radioSystem.CheckedChanged += new System.EventHandler(this.radioSystem_CheckedChanged);
            // 
            // radioOffice2003
            // 
            this.radioOffice2003.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.radioOffice2003.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.radioOffice2003.Location = new System.Drawing.Point(20, 176);
            this.radioOffice2003.Name = "radioOffice2003";
            this.radioOffice2003.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.radioOffice2003.Size = new System.Drawing.Size(85, 20);
            this.radioOffice2003.TabIndex = 7;
            this.radioOffice2003.Values.Text = "Office 2003";
            this.radioOffice2003.CheckedChanged += new System.EventHandler(this.radioOffice2003_CheckedChanged);
            // 
            // radioOffice2007Black
            // 
            this.radioOffice2007Black.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.radioOffice2007Black.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.radioOffice2007Black.Location = new System.Drawing.Point(20, 153);
            this.radioOffice2007Black.Name = "radioOffice2007Black";
            this.radioOffice2007Black.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.radioOffice2007Black.Size = new System.Drawing.Size(125, 20);
            this.radioOffice2007Black.TabIndex = 6;
            this.radioOffice2007Black.Values.Text = "Office 2007 - Black";
            this.radioOffice2007Black.CheckedChanged += new System.EventHandler(this.radioOffice2007Black_CheckedChanged);
            // 
            // radioOffice2007Silver
            // 
            this.radioOffice2007Silver.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.radioOffice2007Silver.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.radioOffice2007Silver.Location = new System.Drawing.Point(20, 130);
            this.radioOffice2007Silver.Name = "radioOffice2007Silver";
            this.radioOffice2007Silver.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.radioOffice2007Silver.Size = new System.Drawing.Size(126, 20);
            this.radioOffice2007Silver.TabIndex = 5;
            this.radioOffice2007Silver.Values.Text = "Office 2007 - Silver";
            this.radioOffice2007Silver.CheckedChanged += new System.EventHandler(this.radioOffice2007Silver_CheckedChanged);
            // 
            // radioOffice2007Blue
            // 
            this.radioOffice2007Blue.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.radioOffice2007Blue.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.radioOffice2007Blue.Location = new System.Drawing.Point(20, 107);
            this.radioOffice2007Blue.Name = "radioOffice2007Blue";
            this.radioOffice2007Blue.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.radioOffice2007Blue.Size = new System.Drawing.Size(120, 20);
            this.radioOffice2007Blue.TabIndex = 4;
            this.radioOffice2007Blue.Values.Text = "Office 2007 - Blue";
            this.radioOffice2007Blue.CheckedChanged += new System.EventHandler(this.radioOffice2007Blue_CheckedChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(4, 4);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(135, 29);
            this.kryptonLabel2.TabIndex = 0;
            this.kryptonLabel2.Values.Text = "Global Palette";
            // 
            // groupAddContext
            // 
            this.groupAddContext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupAddContext.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate;
            this.groupAddContext.Location = new System.Drawing.Point(16, 160);
            this.groupAddContext.Name = "groupAddContext";
            // 
            // groupAddContext.Panel
            // 
            this.groupAddContext.Panel.Controls.Add(this.buttonAddContext);
            this.groupAddContext.Panel.Controls.Add(this.panelContextColor);
            this.groupAddContext.Panel.Controls.Add(this.buttonEditColor);
            this.groupAddContext.Panel.Controls.Add(this.labelContextColor);
            this.groupAddContext.Panel.Controls.Add(this.textBoxContextTitle);
            this.groupAddContext.Panel.Controls.Add(this.labelContextTitle);
            this.groupAddContext.Panel.Controls.Add(this.labelContextName);
            this.groupAddContext.Panel.Controls.Add(this.textBoxContextName);
            this.groupAddContext.Panel.Controls.Add(this.kryptonLabel1);
            this.groupAddContext.Size = new System.Drawing.Size(371, 161);
            this.groupAddContext.TabIndex = 5;
            // 
            // buttonAddContext
            // 
            this.buttonAddContext.AutoSize = true;
            this.buttonAddContext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.buttonAddContext.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonAddContext.Location = new System.Drawing.Point(97, 123);
            this.buttonAddContext.Name = "buttonAddContext";
            this.buttonAddContext.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.buttonAddContext.Size = new System.Drawing.Size(94, 24);
            this.buttonAddContext.TabIndex = 10;
            this.buttonAddContext.Values.Text = "Add Context";
            this.buttonAddContext.Click += new System.EventHandler(this.buttonAddContext_Click);
            // 
            // panelContextColor
            // 
            this.panelContextColor.Location = new System.Drawing.Point(97, 88);
            this.panelContextColor.Name = "panelContextColor";
            this.panelContextColor.Size = new System.Drawing.Size(94, 23);
            this.panelContextColor.StateCommon.Color1 = System.Drawing.Color.DodgerBlue;
            this.panelContextColor.StateCommon.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.panelContextColor.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.panelContextColor.StateCommon.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.panelContextColor.StateCommon.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.panelContextColor.StateCommon.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.panelContextColor.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.panelContextColor.TabIndex = 9;
            // 
            // buttonEditColor
            // 
            this.buttonEditColor.AutoSize = true;
            this.buttonEditColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEditColor.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonEditColor.Location = new System.Drawing.Point(197, 88);
            this.buttonEditColor.Name = "buttonEditColor";
            this.buttonEditColor.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.buttonEditColor.Size = new System.Drawing.Size(79, 24);
            this.buttonEditColor.TabIndex = 8;
            this.buttonEditColor.Values.Text = "Define Color";
            this.buttonEditColor.Click += new System.EventHandler(this.buttonEditColor_Click);
            // 
            // labelContextColor
            // 
            this.labelContextColor.AutoSize = false;
            this.labelContextColor.Location = new System.Drawing.Point(9, 88);
            this.labelContextColor.Name = "labelContextColor";
            this.labelContextColor.Size = new System.Drawing.Size(82, 22);
            this.labelContextColor.StateCommon.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.labelContextColor.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.labelContextColor.StateCommon.Padding = new System.Windows.Forms.Padding(-1);
            this.labelContextColor.StateCommon.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.labelContextColor.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.labelContextColor.StateCommon.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.labelContextColor.StateCommon.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.labelContextColor.StateCommon.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.labelContextColor.StateCommon.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.labelContextColor.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.labelContextColor.StateCommon.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.labelContextColor.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.labelContextColor.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.labelContextColor.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.labelContextColor.TabIndex = 7;
            this.labelContextColor.Values.Text = "Context Color";
            // 
            // textBoxContextTitle
            // 
            this.textBoxContextTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxContextTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxContextTitle.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxContextTitle.Location = new System.Drawing.Point(97, 62);
            this.textBoxContextTitle.Name = "textBoxContextTitle";
            this.textBoxContextTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxContextTitle.Size = new System.Drawing.Size(95, 23);
            this.textBoxContextTitle.TabIndex = 6;
            this.textBoxContextTitle.Text = "Tools";
            this.textBoxContextTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelContextTitle
            // 
            this.labelContextTitle.AutoSize = false;
            this.labelContextTitle.Location = new System.Drawing.Point(9, 63);
            this.labelContextTitle.Name = "labelContextTitle";
            this.labelContextTitle.Size = new System.Drawing.Size(82, 22);
            this.labelContextTitle.StateCommon.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.labelContextTitle.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.labelContextTitle.StateCommon.Padding = new System.Windows.Forms.Padding(-1);
            this.labelContextTitle.StateCommon.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.labelContextTitle.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.labelContextTitle.StateCommon.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.labelContextTitle.StateCommon.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.labelContextTitle.StateCommon.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.labelContextTitle.StateCommon.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.labelContextTitle.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.labelContextTitle.StateCommon.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.labelContextTitle.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.labelContextTitle.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.labelContextTitle.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.labelContextTitle.TabIndex = 5;
            this.labelContextTitle.Values.Text = "Context Title";
            // 
            // labelContextName
            // 
            this.labelContextName.AutoSize = false;
            this.labelContextName.Location = new System.Drawing.Point(9, 38);
            this.labelContextName.Name = "labelContextName";
            this.labelContextName.Size = new System.Drawing.Size(82, 22);
            this.labelContextName.StateCommon.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.labelContextName.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.labelContextName.StateCommon.Padding = new System.Windows.Forms.Padding(-1);
            this.labelContextName.StateCommon.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.labelContextName.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.labelContextName.StateCommon.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.labelContextName.StateCommon.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.labelContextName.StateCommon.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.labelContextName.StateCommon.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.labelContextName.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.labelContextName.StateCommon.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.labelContextName.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.labelContextName.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.labelContextName.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.labelContextName.TabIndex = 4;
            this.labelContextName.Values.Text = "Context Name";
            // 
            // textBoxContextName
            // 
            this.textBoxContextName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxContextName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxContextName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxContextName.Location = new System.Drawing.Point(97, 37);
            this.textBoxContextName.Name = "textBoxContextName";
            this.textBoxContextName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxContextName.Size = new System.Drawing.Size(95, 23);
            this.textBoxContextName.TabIndex = 3;
            this.textBoxContextName.Text = "Blue";
            this.textBoxContextName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(4, 4);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(122, 29);
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "Add Context";
            // 
            // groupSelectedContexts
            // 
            this.groupSelectedContexts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupSelectedContexts.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate;
            this.groupSelectedContexts.Location = new System.Drawing.Point(16, 16);
            this.groupSelectedContexts.Name = "groupSelectedContexts";
            // 
            // groupSelectedContexts.Panel
            // 
            this.groupSelectedContexts.Panel.Controls.Add(this.labelSelectedContexts);
            this.groupSelectedContexts.Panel.Controls.Add(this.buttonSelectedApply);
            this.groupSelectedContexts.Panel.Controls.Add(this.textBoxSelectedContexts);
            this.groupSelectedContexts.Panel.Controls.Add(this.labelContextsInstructions);
            this.groupSelectedContexts.Size = new System.Drawing.Size(371, 129);
            this.groupSelectedContexts.TabIndex = 4;
            // 
            // labelSelectedContexts
            // 
            this.labelSelectedContexts.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            this.labelSelectedContexts.Location = new System.Drawing.Point(4, 4);
            this.labelSelectedContexts.Name = "labelSelectedContexts";
            this.labelSelectedContexts.Size = new System.Drawing.Size(168, 29);
            this.labelSelectedContexts.TabIndex = 1;
            this.labelSelectedContexts.Values.Text = "Selected Contexts";
            // 
            // buttonSelectedApply
            // 
            this.buttonSelectedApply.AutoSize = true;
            this.buttonSelectedApply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSelectedApply.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonSelectedApply.Location = new System.Drawing.Point(311, 35);
            this.buttonSelectedApply.Name = "buttonSelectedApply";
            this.buttonSelectedApply.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.buttonSelectedApply.Size = new System.Drawing.Size(42, 24);
            this.buttonSelectedApply.TabIndex = 3;
            this.buttonSelectedApply.Values.Text = "Apply";
            this.buttonSelectedApply.Click += new System.EventHandler(this.buttonSelectedApply_Click);
            // 
            // textBoxSelectedContexts
            // 
            this.textBoxSelectedContexts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxSelectedContexts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxSelectedContexts.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxSelectedContexts.Location = new System.Drawing.Point(9, 36);
            this.textBoxSelectedContexts.Name = "textBoxSelectedContexts";
            this.textBoxSelectedContexts.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxSelectedContexts.Size = new System.Drawing.Size(296, 23);
            this.textBoxSelectedContexts.TabIndex = 0;
            this.textBoxSelectedContexts.Text = "Red,Green";
            this.textBoxSelectedContexts.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxSelectedContexts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSelectedContexts_KeyDown);
            // 
            // labelContextsInstructions
            // 
            this.labelContextsInstructions.Location = new System.Drawing.Point(5, 64);
            this.labelContextsInstructions.Name = "labelContextsInstructions";
            this.labelContextsInstructions.Size = new System.Drawing.Size(318, 52);
            this.labelContextsInstructions.TabIndex = 2;
            this.labelContextsInstructions.Values.Text = "Use a common separated list of context names and then\r\npress the \'Apply\' button. " +
    "To remove all contextual tabs\r\njust remove all the text and press \'Apply\'.";
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.Color = System.Drawing.Color.DodgerBlue;
            this.colorDialog.FullOpen = true;
            this.colorDialog.SolidColorOnly = true;
            // 
            // kryptonManager
            // 
            this.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteModeManager.Office2007Black;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 488);
            this.Controls.Add(this.labelOffice2007Styles);
            this.Controls.Add(this.kryptonRibbon);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(602, 511);
            this.Name = "Form1";
            this.StateCommon.Header.ButtonPadding = new System.Windows.Forms.Padding(-1);
            this.StateCommon.Header.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.StateCommon.Header.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.StateCommon.Header.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.StateCommon.Header.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.StateCommon.Header.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.StateCommon.Header.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.StateCommon.Header.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.StateCommon.Header.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.StateCommon.Header.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.StateCommon.Header.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.StateCommon.Header.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.StateCommon.Header.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.StateCommon.Header.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.StateCommon.Header.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.StateCommon.Header.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.StateCommon.Header.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.StateCommon.Header.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.StateCommon.Header.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.StateCommon.Header.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.StateCommon.Header.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.StateCommon.Header.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.StateCommon.Header.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.StateCommon.Header.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.StateCommon.Header.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.StateCommon.Header.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.StateCommon.OverlayHeaders = Krypton.Toolkit.InheritBool.Inherit;
            this.Text = "Contextual Tabs";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelOffice2007Styles)).EndInit();
            this.labelOffice2007Styles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupOffice2007Styles.Panel)).EndInit();
            this.groupOffice2007Styles.Panel.ResumeLayout(false);
            this.groupOffice2007Styles.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupOffice2007Styles)).EndInit();
            this.groupOffice2007Styles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupAddContext.Panel)).EndInit();
            this.groupAddContext.Panel.ResumeLayout(false);
            this.groupAddContext.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupAddContext)).EndInit();
            this.groupAddContext.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelContextColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupSelectedContexts.Panel)).EndInit();
            this.groupSelectedContexts.Panel.ResumeLayout(false);
            this.groupSelectedContexts.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupSelectedContexts)).EndInit();
            this.groupSelectedContexts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox textBoxSelectedContexts;
        private Krypton.Toolkit.KryptonTextBox textBoxContextTitle;
        private Krypton.Toolkit.KryptonTextBox textBoxContextName;
        private Krypton.Ribbon.KryptonRibbon kryptonRibbon;
        private Krypton.Ribbon.KryptonRibbonContext contextDefRed;
        private Krypton.Ribbon.KryptonRibbonContext contextDefGreen;
        private Krypton.Ribbon.KryptonRibbonTab tabHome;
        private Krypton.Ribbon.KryptonRibbonTab contextRed;
        private Krypton.Ribbon.KryptonRibbonTab contextGreen1;
        private Krypton.Toolkit.KryptonPanel labelOffice2007Styles;
        private Krypton.Toolkit.KryptonLabel labelSelectedContexts;
        private Krypton.Toolkit.KryptonButton buttonSelectedApply;
        private Krypton.Toolkit.KryptonLabel labelContextsInstructions;
        private Krypton.Toolkit.KryptonGroup groupAddContext;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonGroup groupSelectedContexts;
        private Krypton.Toolkit.KryptonLabel labelContextColor;
        private Krypton.Toolkit.KryptonLabel labelContextTitle;
        private Krypton.Toolkit.KryptonLabel labelContextName;
        private Krypton.Toolkit.KryptonPanel panelContextColor;
        private Krypton.Toolkit.KryptonButton buttonEditColor;
        private Krypton.Toolkit.KryptonButton buttonAddContext;
        private Krypton.Ribbon.KryptonRibbonTab contextGreen2;
        private Krypton.Toolkit.KryptonGroup groupOffice2007Styles;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonManager kryptonManager;
        private System.Windows.Forms.ColorDialog colorDialog;
        private Krypton.Toolkit.KryptonRadioButton radioSystem;
        private Krypton.Toolkit.KryptonRadioButton radioOffice2003;
        private Krypton.Toolkit.KryptonRadioButton radioOffice2007Black;
        private Krypton.Toolkit.KryptonRadioButton radioOffice2007Silver;
        private Krypton.Toolkit.KryptonRadioButton radioOffice2007Blue;
        private Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem1;
        private Krypton.Toolkit.KryptonRadioButton radioSparkleBlue;
        private Krypton.Toolkit.KryptonRadioButton radioSparkleOrange;
        private Krypton.Toolkit.KryptonRadioButton radioSparklePurple;
        private Krypton.Toolkit.KryptonRadioButton radioOffice2010Black;
        private Krypton.Toolkit.KryptonRadioButton radioOffice2010Silver;
        private Krypton.Toolkit.KryptonRadioButton radioOffice2010Blue;
    }
}

