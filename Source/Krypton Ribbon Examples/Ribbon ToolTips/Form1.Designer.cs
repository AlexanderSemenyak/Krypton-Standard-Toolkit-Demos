namespace RibbonToolTips
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
            this.kryptonRibbon1 = new Krypton.Ribbon.KryptonRibbon();
            this.qatSave = new Krypton.Ribbon.KryptonRibbonQATButton();
            this.qatUndo = new Krypton.Ribbon.KryptonRibbonQATButton();
            this.qatRedo = new Krypton.Ribbon.KryptonRibbonQATButton();
            this.kryptonContextMenuItem1 = new Krypton.Toolkit.KryptonContextMenuItem();
            this.tabHome = new Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup1 = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple1 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.kryptonRibbonGroupButton1 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.cmsPaste = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteSpecialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonRibbonGroupTriple2 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.kryptonRibbonGroupButton2 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupButton3 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupButton4 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup2 = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple3 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.kryptonRibbonGroupButton5 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupButton7 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupTriple4 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.kryptonRibbonGroupButton6 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.cmsBusinessCards = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.otherBusinessCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonRibbonGroupButton8 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupButton9 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.cmsSignatures = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.signaturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonPanel = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel = new Krypton.Toolkit.KryptonLabel();
            this.kryptonManager = new Krypton.Toolkit.KryptonManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).BeginInit();
            this.cmsPaste.SuspendLayout();
            this.cmsBusinessCards.SuspendLayout();
            this.cmsSignatures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonRibbon1
            // 
            this.kryptonRibbon1.AllowFormIntegrate = true;
            this.kryptonRibbon1.HideRibbonSize = new System.Drawing.Size(300, 150);
            this.kryptonRibbon1.InDesignHelperMode = true;
            this.kryptonRibbon1.Name = "kryptonRibbon1";
            this.kryptonRibbon1.QATButtons.AddRange(new System.ComponentModel.Component[] {
            this.qatSave,
            this.qatUndo,
            this.qatRedo});
            this.kryptonRibbon1.QATLocation = Krypton.Ribbon.QATLocation.Above;
            this.kryptonRibbon1.RibbonAppButton.AppButtonMaxRecentSize = new System.Drawing.Size(350, 350);
            this.kryptonRibbon1.RibbonAppButton.AppButtonMenuItems.AddRange(new Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItem1});
            this.kryptonRibbon1.RibbonAppButton.AppButtonMinRecentSize = new System.Drawing.Size(250, 250);
            this.kryptonRibbon1.RibbonAppButton.AppButtonShowRecentDocs = false;
            this.kryptonRibbon1.RibbonAppButton.AppButtonToolTipBody = "  Click here to open, save, or print,\r\n  and to see everything else you can\r\n  do" +
    " with your document.";
            this.kryptonRibbon1.RibbonAppButton.AppButtonToolTipStyle = Krypton.Toolkit.LabelStyle.SuperTip;
            this.kryptonRibbon1.RibbonAppButton.AppButtonToolTipTitle = "Office Button";
            this.kryptonRibbon1.RibbonTabs.AddRange(new Krypton.Ribbon.KryptonRibbonTab[] {
            this.tabHome});
            this.kryptonRibbon1.SelectedContext = null;
            this.kryptonRibbon1.SelectedTab = this.tabHome;
            this.kryptonRibbon1.Size = new System.Drawing.Size(590, 115);
            this.kryptonRibbon1.TabIndex = 0;
            // 
            // qatSave
            // 
            this.qatSave.Image = ((System.Drawing.Image)(resources.GetObject("qatSave.Image")));
            this.qatSave.Text = "Save";
            this.qatSave.ToolTipBody = "Save (Ctrl + S)";
            this.qatSave.ToolTipStyle = Krypton.Toolkit.LabelStyle.ToolTip;
            // 
            // qatUndo
            // 
            this.qatUndo.Image = ((System.Drawing.Image)(resources.GetObject("qatUndo.Image")));
            this.qatUndo.Text = "Undo";
            this.qatUndo.ToolTipBody = "Undo (Ctrl + Z)";
            this.qatUndo.ToolTipStyle = Krypton.Toolkit.LabelStyle.ToolTip;
            // 
            // qatRedo
            // 
            this.qatRedo.Image = ((System.Drawing.Image)(resources.GetObject("qatRedo.Image")));
            this.qatRedo.Text = "Redo";
            this.qatRedo.ToolTipBody = "Redo (Ctrl + Y)";
            this.qatRedo.ToolTipStyle = Krypton.Toolkit.LabelStyle.ToolTip;
            // 
            // kryptonContextMenuItem1
            // 
            this.kryptonContextMenuItem1.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.kryptonContextMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("kryptonContextMenuItem1.Image")));
            this.kryptonContextMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.None;
            this.kryptonContextMenuItem1.Text = "E&xit";
            this.kryptonContextMenuItem1.Click += new System.EventHandler(this.appMenu_Click);
            // 
            // tabHome
            // 
            this.tabHome.Groups.AddRange(new Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup1,
            this.kryptonRibbonGroup2});
            this.tabHome.KeyTip = "H";
            this.tabHome.Text = "Home";
            // 
            // kryptonRibbonGroup1
            // 
            this.kryptonRibbonGroup1.AllowCollapsed = false;
            this.kryptonRibbonGroup1.DialogBoxLauncher = false;
            this.kryptonRibbonGroup1.Image = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroup1.Image")));
            this.kryptonRibbonGroup1.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple1,
            this.kryptonRibbonGroupTriple2});
            this.kryptonRibbonGroup1.KeyTipDialogLauncher = "FO";
            this.kryptonRibbonGroup1.TextLine1 = "Clipboard";
            // 
            // kryptonRibbonGroupTriple1
            // 
            this.kryptonRibbonGroupTriple1.ItemAlignment = Krypton.Ribbon.RibbonItemAlignment.Near;
            this.kryptonRibbonGroupTriple1.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.kryptonRibbonGroupButton1});
            this.kryptonRibbonGroupTriple1.MaximumSize = Krypton.Ribbon.GroupItemSize.Large;
            this.kryptonRibbonGroupTriple1.MinimumSize = Krypton.Ribbon.GroupItemSize.Small;
            // 
            // kryptonRibbonGroupButton1
            // 
            this.kryptonRibbonGroupButton1.ButtonType = Krypton.Ribbon.GroupButtonType.Split;
            this.kryptonRibbonGroupButton1.ContextMenuStrip = this.cmsPaste;
            this.kryptonRibbonGroupButton1.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroupButton1.ImageLarge")));
            this.kryptonRibbonGroupButton1.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroupButton1.ImageSmall")));
            this.kryptonRibbonGroupButton1.KeyTip = "V";
            this.kryptonRibbonGroupButton1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.kryptonRibbonGroupButton1.TextLine1 = "Paste";
            this.kryptonRibbonGroupButton1.ToolTipBody = "  Paste the contents of the\r\n  Clipboard.";
            this.kryptonRibbonGroupButton1.ToolTipStyle = Krypton.Toolkit.LabelStyle.SuperTip;
            this.kryptonRibbonGroupButton1.ToolTipTitle = "Paste (Ctrl + V)";
            // 
            // cmsPaste
            // 
            this.cmsPaste.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cmsPaste.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPaste.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasteToolStripMenuItem,
            this.pasteSpecialToolStripMenuItem});
            this.cmsPaste.Name = "cmsPaste";
            this.cmsPaste.Size = new System.Drawing.Size(141, 48);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // pasteSpecialToolStripMenuItem
            // 
            this.pasteSpecialToolStripMenuItem.Name = "pasteSpecialToolStripMenuItem";
            this.pasteSpecialToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.pasteSpecialToolStripMenuItem.Text = "Paste Special";
            // 
            // kryptonRibbonGroupTriple2
            // 
            this.kryptonRibbonGroupTriple2.ItemAlignment = Krypton.Ribbon.RibbonItemAlignment.Near;
            this.kryptonRibbonGroupTriple2.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.kryptonRibbonGroupButton2,
            this.kryptonRibbonGroupButton3,
            this.kryptonRibbonGroupButton4});
            this.kryptonRibbonGroupTriple2.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium;
            this.kryptonRibbonGroupTriple2.MinimumSize = Krypton.Ribbon.GroupItemSize.Small;
            // 
            // kryptonRibbonGroupButton2
            // 
            this.kryptonRibbonGroupButton2.ButtonType = Krypton.Ribbon.GroupButtonType.Push;
            this.kryptonRibbonGroupButton2.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroupButton2.ImageLarge")));
            this.kryptonRibbonGroupButton2.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroupButton2.ImageSmall")));
            this.kryptonRibbonGroupButton2.KeyTip = "X";
            this.kryptonRibbonGroupButton2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.kryptonRibbonGroupButton2.TextLine1 = "Cut";
            this.kryptonRibbonGroupButton2.ToolTipBody = "  Cut the selection from the\r\n  document and put it on the\r\n  Clipboard.";
            this.kryptonRibbonGroupButton2.ToolTipStyle = Krypton.Toolkit.LabelStyle.SuperTip;
            this.kryptonRibbonGroupButton2.ToolTipTitle = "Cut  (Ctrl + X)";
            // 
            // kryptonRibbonGroupButton3
            // 
            this.kryptonRibbonGroupButton3.ButtonType = Krypton.Ribbon.GroupButtonType.Push;
            this.kryptonRibbonGroupButton3.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroupButton3.ImageLarge")));
            this.kryptonRibbonGroupButton3.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroupButton3.ImageSmall")));
            this.kryptonRibbonGroupButton3.KeyTip = "C";
            this.kryptonRibbonGroupButton3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kryptonRibbonGroupButton3.TextLine1 = "Copy";
            this.kryptonRibbonGroupButton3.ToolTipBody = "  Copy the selection and put it on\r\n  the Clipboard.";
            this.kryptonRibbonGroupButton3.ToolTipStyle = Krypton.Toolkit.LabelStyle.SuperTip;
            this.kryptonRibbonGroupButton3.ToolTipTitle = "Copy (Ctrl + C)";
            // 
            // kryptonRibbonGroupButton4
            // 
            this.kryptonRibbonGroupButton4.ButtonType = Krypton.Ribbon.GroupButtonType.Push;
            this.kryptonRibbonGroupButton4.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroupButton4.ImageLarge")));
            this.kryptonRibbonGroupButton4.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroupButton4.ImageSmall")));
            this.kryptonRibbonGroupButton4.KeyTip = "FP";
            this.kryptonRibbonGroupButton4.TextLine1 = "Format";
            this.kryptonRibbonGroupButton4.TextLine2 = "Painter";
            this.kryptonRibbonGroupButton4.ToolTipBody = "  Copy formatting from one place\r\n  and apply it to another.\r\n\r\n  Double-click th" +
    "is button to apply\r\n  the same formatting to multiple\r\n  places in the document." +
    "";
            this.kryptonRibbonGroupButton4.ToolTipStyle = Krypton.Toolkit.LabelStyle.SuperTip;
            this.kryptonRibbonGroupButton4.ToolTipTitle = "Format Painter";
            // 
            // kryptonRibbonGroup2
            // 
            this.kryptonRibbonGroup2.AllowCollapsed = false;
            this.kryptonRibbonGroup2.DialogBoxLauncher = false;
            this.kryptonRibbonGroup2.Image = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroup2.Image")));
            this.kryptonRibbonGroup2.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple3,
            this.kryptonRibbonGroupTriple4});
            this.kryptonRibbonGroup2.KeyTipDialogLauncher = "AP";
            this.kryptonRibbonGroup2.KeyTipGroup = "ZC";
            this.kryptonRibbonGroup2.TextLine1 = "Include";
            // 
            // kryptonRibbonGroupTriple3
            // 
            this.kryptonRibbonGroupTriple3.ItemAlignment = Krypton.Ribbon.RibbonItemAlignment.Near;
            this.kryptonRibbonGroupTriple3.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.kryptonRibbonGroupButton5,
            this.kryptonRibbonGroupButton7});
            this.kryptonRibbonGroupTriple3.MaximumSize = Krypton.Ribbon.GroupItemSize.Large;
            this.kryptonRibbonGroupTriple3.MinimumSize = Krypton.Ribbon.GroupItemSize.Small;
            // 
            // kryptonRibbonGroupButton5
            // 
            this.kryptonRibbonGroupButton5.ButtonType = Krypton.Ribbon.GroupButtonType.Push;
            this.kryptonRibbonGroupButton5.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroupButton5.ImageLarge")));
            this.kryptonRibbonGroupButton5.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroupButton5.ImageSmall")));
            this.kryptonRibbonGroupButton5.KeyTip = "AF";
            this.kryptonRibbonGroupButton5.TextLine1 = "Attach";
            this.kryptonRibbonGroupButton5.TextLine2 = "File";
            this.kryptonRibbonGroupButton5.ToolTipBody = "Attach a file to this item.";
            this.kryptonRibbonGroupButton5.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroupButton5.ToolTipImage")));
            this.kryptonRibbonGroupButton5.ToolTipStyle = Krypton.Toolkit.LabelStyle.SuperTip;
            this.kryptonRibbonGroupButton5.ToolTipTitle = "Attach File";
            // 
            // kryptonRibbonGroupButton7
            // 
            this.kryptonRibbonGroupButton7.ButtonType = Krypton.Ribbon.GroupButtonType.Push;
            this.kryptonRibbonGroupButton7.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroupButton7.ImageLarge")));
            this.kryptonRibbonGroupButton7.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroupButton7.ImageSmall")));
            this.kryptonRibbonGroupButton7.KeyTip = "AM";
            this.kryptonRibbonGroupButton7.TextLine1 = "Attach";
            this.kryptonRibbonGroupButton7.TextLine2 = "Item";
            this.kryptonRibbonGroupButton7.ToolTipBody = " Attach another Outlook item to\r\n this item.";
            this.kryptonRibbonGroupButton7.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroupButton7.ToolTipImage")));
            this.kryptonRibbonGroupButton7.ToolTipStyle = Krypton.Toolkit.LabelStyle.SuperTip;
            this.kryptonRibbonGroupButton7.ToolTipTitle = "Attach Item";
            // 
            // kryptonRibbonGroupTriple4
            // 
            this.kryptonRibbonGroupTriple4.ItemAlignment = Krypton.Ribbon.RibbonItemAlignment.Near;
            this.kryptonRibbonGroupTriple4.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.kryptonRibbonGroupButton6,
            this.kryptonRibbonGroupButton8,
            this.kryptonRibbonGroupButton9});
            this.kryptonRibbonGroupTriple4.MaximumSize = Krypton.Ribbon.GroupItemSize.Large;
            this.kryptonRibbonGroupTriple4.MinimumSize = Krypton.Ribbon.GroupItemSize.Small;
            // 
            // kryptonRibbonGroupButton6
            // 
            this.kryptonRibbonGroupButton6.ButtonType = Krypton.Ribbon.GroupButtonType.DropDown;
            this.kryptonRibbonGroupButton6.ContextMenuStrip = this.cmsBusinessCards;
            this.kryptonRibbonGroupButton6.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroupButton6.ImageLarge")));
            this.kryptonRibbonGroupButton6.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroupButton6.ImageSmall")));
            this.kryptonRibbonGroupButton6.KeyTip = "AA";
            this.kryptonRibbonGroupButton6.TextLine1 = "Business";
            this.kryptonRibbonGroupButton6.TextLine2 = "Card";
            this.kryptonRibbonGroupButton6.ToolTipBody = " Attach an electronic business card\r\n to this message.";
            this.kryptonRibbonGroupButton6.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroupButton6.ToolTipImage")));
            this.kryptonRibbonGroupButton6.ToolTipStyle = Krypton.Toolkit.LabelStyle.SuperTip;
            this.kryptonRibbonGroupButton6.ToolTipTitle = "Insert Business Card";
            // 
            // cmsBusinessCards
            // 
            this.cmsBusinessCards.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cmsBusinessCards.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsBusinessCards.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otherBusinessCardsToolStripMenuItem});
            this.cmsBusinessCards.Name = "cmsBusinessCards";
            this.cmsBusinessCards.Size = new System.Drawing.Size(193, 26);
            // 
            // otherBusinessCardsToolStripMenuItem
            // 
            this.otherBusinessCardsToolStripMenuItem.Name = "otherBusinessCardsToolStripMenuItem";
            this.otherBusinessCardsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.otherBusinessCardsToolStripMenuItem.Text = "Other Business Cards...";
            // 
            // kryptonRibbonGroupButton8
            // 
            this.kryptonRibbonGroupButton8.ButtonType = Krypton.Ribbon.GroupButtonType.Push;
            this.kryptonRibbonGroupButton8.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroupButton8.ImageLarge")));
            this.kryptonRibbonGroupButton8.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroupButton8.ImageSmall")));
            this.kryptonRibbonGroupButton8.KeyTip = "OC";
            this.kryptonRibbonGroupButton8.TextLine1 = "Calendar";
            this.kryptonRibbonGroupButton8.ToolTipBody = " Attach your calendar information\r\n to this message.";
            this.kryptonRibbonGroupButton8.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroupButton8.ToolTipImage")));
            this.kryptonRibbonGroupButton8.ToolTipStyle = Krypton.Toolkit.LabelStyle.SuperTip;
            this.kryptonRibbonGroupButton8.ToolTipTitle = "Insert Calendar";
            // 
            // kryptonRibbonGroupButton9
            // 
            this.kryptonRibbonGroupButton9.ButtonType = Krypton.Ribbon.GroupButtonType.DropDown;
            this.kryptonRibbonGroupButton9.ContextMenuStrip = this.cmsSignatures;
            this.kryptonRibbonGroupButton9.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroupButton9.ImageLarge")));
            this.kryptonRibbonGroupButton9.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroupButton9.ImageSmall")));
            this.kryptonRibbonGroupButton9.KeyTip = "G";
            this.kryptonRibbonGroupButton9.TextLine1 = "Signature";
            this.kryptonRibbonGroupButton9.ToolTipBody = " Attach one of your e-mail\r\n signatures to this message.";
            this.kryptonRibbonGroupButton9.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroupButton9.ToolTipImage")));
            this.kryptonRibbonGroupButton9.ToolTipStyle = Krypton.Toolkit.LabelStyle.SuperTip;
            this.kryptonRibbonGroupButton9.ToolTipTitle = "Signature";
            // 
            // cmsSignatures
            // 
            this.cmsSignatures.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cmsSignatures.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsSignatures.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signaturesToolStripMenuItem});
            this.cmsSignatures.Name = "cmsSignatures";
            this.cmsSignatures.Size = new System.Drawing.Size(139, 26);
            // 
            // signaturesToolStripMenuItem
            // 
            this.signaturesToolStripMenuItem.Name = "signaturesToolStripMenuItem";
            this.signaturesToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.signaturesToolStripMenuItem.Text = "Signatures...";
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonLabel);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 115);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(590, 179);
            this.kryptonPanel.TabIndex = 1;
            // 
            // kryptonLabel
            // 
            this.kryptonLabel.Location = new System.Drawing.Point(12, 14);
            this.kryptonLabel.Name = "kryptonLabel";
            this.kryptonLabel.Size = new System.Drawing.Size(390, 132);
            this.kryptonLabel.TabIndex = 0;
            this.kryptonLabel.Values.Text = resources.GetString("kryptonLabel.Values.Text");
            // 
            // kryptonManager
            // 
            this.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteModeManager.Office2007Blue;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 294);
            this.Controls.Add(this.kryptonPanel);
            this.Controls.Add(this.kryptonRibbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ribbon ToolTips";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).EndInit();
            this.cmsPaste.ResumeLayout(false);
            this.cmsBusinessCards.ResumeLayout(false);
            this.cmsSignatures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Ribbon.KryptonRibbon kryptonRibbon1;
        private Krypton.Ribbon.KryptonRibbonTab tabHome;
        private Krypton.Toolkit.KryptonPanel kryptonPanel;
        private Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup1;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple1;
        private Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton1;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple2;
        private Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton2;
        private Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton3;
        private Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton4;
        private Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup2;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple3;
        private Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton5;
        private Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton7;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple4;
        private Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton6;
        private Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton8;
        private Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton9;
        private System.Windows.Forms.ContextMenuStrip cmsPaste;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteSpecialToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsBusinessCards;
        private System.Windows.Forms.ToolStripMenuItem otherBusinessCardsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsSignatures;
        private System.Windows.Forms.ToolStripMenuItem signaturesToolStripMenuItem;
        private Krypton.Ribbon.KryptonRibbonQATButton qatSave;
        private Krypton.Ribbon.KryptonRibbonQATButton qatUndo;
        private Krypton.Ribbon.KryptonRibbonQATButton qatRedo;
        private Krypton.Toolkit.KryptonLabel kryptonLabel;
        private Krypton.Toolkit.KryptonManager kryptonManager;
        private Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem1;
    }
}

