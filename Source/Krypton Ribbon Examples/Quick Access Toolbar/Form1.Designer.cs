namespace QuickAccessToolbar
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
            this.tabHome = new Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonManager = new Krypton.Toolkit.KryptonManager(this.components);
            this.panelFill = new Krypton.Toolkit.KryptonPanel();
            this.kryptonGroup2 = new Krypton.Toolkit.KryptonGroup();
            this.buttonClear = new Krypton.Toolkit.KryptonButton();
            this.buttonRemove = new Krypton.Toolkit.KryptonButton();
            this.buttonAdd = new Krypton.Toolkit.KryptonButton();
            this.labelQATButtons = new Krypton.Toolkit.KryptonLabel();
            this.kryptonGroup1 = new Krypton.Toolkit.KryptonGroup();
            this.checkButtonDisallowUserChanges = new Krypton.Toolkit.KryptonCheckButton();
            this.checkButtonAllowUserChanges = new Krypton.Toolkit.KryptonCheckButton();
            this.labelQATUserChange = new Krypton.Toolkit.KryptonLabel();
            this.groupQATLocation = new Krypton.Toolkit.KryptonGroup();
            this.checkButtonHidden = new Krypton.Toolkit.KryptonCheckButton();
            this.checkButtonBelow = new Krypton.Toolkit.KryptonCheckButton();
            this.checkButtonAbove = new Krypton.Toolkit.KryptonCheckButton();
            this.labelQATLocation = new Krypton.Toolkit.KryptonLabel();
            this.checkSetQATPosition = new Krypton.Toolkit.KryptonCheckSet(this.components);
            this.checkSetQATUserChange = new Krypton.Toolkit.KryptonCheckSet(this.components);
            this.kryptonCheckButton1 = new Krypton.Toolkit.KryptonCheckButton();
            this.kryptonCheckButton2 = new Krypton.Toolkit.KryptonCheckButton();
            this.kryptonCheckButton3 = new Krypton.Toolkit.KryptonCheckButton();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelFill)).BeginInit();
            this.panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2.Panel)).BeginInit();
            this.kryptonGroup2.Panel.SuspendLayout();
            this.kryptonGroup2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupQATLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupQATLocation.Panel)).BeginInit();
            this.groupQATLocation.Panel.SuspendLayout();
            this.groupQATLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkSetQATPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkSetQATUserChange)).BeginInit();
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
            this.kryptonRibbon.RibbonTabs.AddRange(new Krypton.Ribbon.KryptonRibbonTab[] {
            this.tabHome});
            this.kryptonRibbon.SelectedContext = null;
            this.kryptonRibbon.SelectedTab = this.tabHome;
            this.kryptonRibbon.Size = new System.Drawing.Size(375, 115);
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
            // tabHome
            // 
            this.tabHome.Text = "Home";
            // 
            // kryptonManager
            // 
            this.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteModeManager.Office2007Blue;
            // 
            // panelFill
            // 
            this.panelFill.Controls.Add(this.kryptonGroup2);
            this.panelFill.Controls.Add(this.kryptonGroup1);
            this.panelFill.Controls.Add(this.groupQATLocation);
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill.Location = new System.Drawing.Point(0, 115);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(375, 296);
            this.panelFill.TabIndex = 1;
            // 
            // kryptonGroup2
            // 
            this.kryptonGroup2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kryptonGroup2.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate;
            this.kryptonGroup2.Location = new System.Drawing.Point(12, 174);
            this.kryptonGroup2.Name = "kryptonGroup2";
            // 
            // kryptonGroup2.Panel
            // 
            this.kryptonGroup2.Panel.Controls.Add(this.buttonClear);
            this.kryptonGroup2.Panel.Controls.Add(this.buttonRemove);
            this.kryptonGroup2.Panel.Controls.Add(this.buttonAdd);
            this.kryptonGroup2.Panel.Controls.Add(this.labelQATButtons);
            this.kryptonGroup2.Size = new System.Drawing.Size(323, 81);
            this.kryptonGroup2.TabIndex = 7;
            // 
            // buttonClear
            // 
            this.buttonClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.buttonClear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonClear.Location = new System.Drawing.Point(213, 40);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.buttonClear.Size = new System.Drawing.Size(90, 25);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Values.Text = "Clear";
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.buttonRemove.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonRemove.Location = new System.Drawing.Point(116, 40);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.buttonRemove.Size = new System.Drawing.Size(90, 25);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Values.Text = "Remove";
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.buttonAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonAdd.Location = new System.Drawing.Point(20, 40);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.buttonAdd.Size = new System.Drawing.Size(90, 25);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Values.Text = "Add";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelQATButtons
            // 
            this.labelQATButtons.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            this.labelQATButtons.Location = new System.Drawing.Point(4, 4);
            this.labelQATButtons.Name = "labelQATButtons";
            this.labelQATButtons.Size = new System.Drawing.Size(124, 29);
            this.labelQATButtons.TabIndex = 1;
            this.labelQATButtons.Values.Text = "QAT Buttons";
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kryptonGroup1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate;
            this.kryptonGroup1.Location = new System.Drawing.Point(159, 16);
            this.kryptonGroup1.Name = "kryptonGroup1";
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.checkButtonDisallowUserChanges);
            this.kryptonGroup1.Panel.Controls.Add(this.checkButtonAllowUserChanges);
            this.kryptonGroup1.Panel.Controls.Add(this.labelQATUserChange);
            this.kryptonGroup1.Size = new System.Drawing.Size(176, 142);
            this.kryptonGroup1.TabIndex = 6;
            // 
            // checkButtonDisallowUserChanges
            // 
            this.checkButtonDisallowUserChanges.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.checkButtonDisallowUserChanges.DialogResult = System.Windows.Forms.DialogResult.None;
            this.checkButtonDisallowUserChanges.Location = new System.Drawing.Point(16, 82);
            this.checkButtonDisallowUserChanges.Name = "checkButtonDisallowUserChanges";
            this.checkButtonDisallowUserChanges.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.checkButtonDisallowUserChanges.Size = new System.Drawing.Size(140, 25);
            this.checkButtonDisallowUserChanges.TabIndex = 3;
            this.checkButtonDisallowUserChanges.Values.Text = "Disallow User Changes";
            // 
            // checkButtonAllowUserChanges
            // 
            this.checkButtonAllowUserChanges.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.checkButtonAllowUserChanges.Checked = true;
            this.checkButtonAllowUserChanges.DialogResult = System.Windows.Forms.DialogResult.None;
            this.checkButtonAllowUserChanges.Location = new System.Drawing.Point(16, 51);
            this.checkButtonAllowUserChanges.Name = "checkButtonAllowUserChanges";
            this.checkButtonAllowUserChanges.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.checkButtonAllowUserChanges.Size = new System.Drawing.Size(140, 25);
            this.checkButtonAllowUserChanges.TabIndex = 2;
            this.checkButtonAllowUserChanges.Values.Text = "Allow User Changes";
            // 
            // labelQATUserChange
            // 
            this.labelQATUserChange.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            this.labelQATUserChange.Location = new System.Drawing.Point(4, 4);
            this.labelQATUserChange.Name = "labelQATUserChange";
            this.labelQATUserChange.Size = new System.Drawing.Size(165, 29);
            this.labelQATUserChange.TabIndex = 1;
            this.labelQATUserChange.Values.Text = "QAT User Change";
            // 
            // groupQATLocation
            // 
            this.groupQATLocation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupQATLocation.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate;
            this.groupQATLocation.Location = new System.Drawing.Point(12, 16);
            this.groupQATLocation.Name = "groupQATLocation";
            // 
            // groupQATLocation.Panel
            // 
            this.groupQATLocation.Panel.Controls.Add(this.checkButtonHidden);
            this.groupQATLocation.Panel.Controls.Add(this.checkButtonBelow);
            this.groupQATLocation.Panel.Controls.Add(this.checkButtonAbove);
            this.groupQATLocation.Panel.Controls.Add(this.labelQATLocation);
            this.groupQATLocation.Size = new System.Drawing.Size(132, 142);
            this.groupQATLocation.TabIndex = 5;
            // 
            // checkButtonHidden
            // 
            this.checkButtonHidden.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.checkButtonHidden.DialogResult = System.Windows.Forms.DialogResult.None;
            this.checkButtonHidden.Location = new System.Drawing.Point(20, 101);
            this.checkButtonHidden.Name = "checkButtonHidden";
            this.checkButtonHidden.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.checkButtonHidden.Size = new System.Drawing.Size(90, 25);
            this.checkButtonHidden.TabIndex = 4;
            this.checkButtonHidden.Values.Text = "Hidden";
            // 
            // checkButtonBelow
            // 
            this.checkButtonBelow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.checkButtonBelow.DialogResult = System.Windows.Forms.DialogResult.None;
            this.checkButtonBelow.Location = new System.Drawing.Point(20, 70);
            this.checkButtonBelow.Name = "checkButtonBelow";
            this.checkButtonBelow.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.checkButtonBelow.Size = new System.Drawing.Size(90, 25);
            this.checkButtonBelow.TabIndex = 3;
            this.checkButtonBelow.Values.Text = "Below";
            // 
            // checkButtonAbove
            // 
            this.checkButtonAbove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.checkButtonAbove.Checked = true;
            this.checkButtonAbove.DialogResult = System.Windows.Forms.DialogResult.None;
            this.checkButtonAbove.Location = new System.Drawing.Point(20, 39);
            this.checkButtonAbove.Name = "checkButtonAbove";
            this.checkButtonAbove.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.checkButtonAbove.Size = new System.Drawing.Size(90, 25);
            this.checkButtonAbove.TabIndex = 2;
            this.checkButtonAbove.Values.Text = "Above";
            // 
            // labelQATLocation
            // 
            this.labelQATLocation.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            this.labelQATLocation.Location = new System.Drawing.Point(4, 4);
            this.labelQATLocation.Name = "labelQATLocation";
            this.labelQATLocation.Size = new System.Drawing.Size(130, 29);
            this.labelQATLocation.TabIndex = 1;
            this.labelQATLocation.Values.Text = "QAT Location";
            // 
            // checkSetQATPosition
            // 
            this.checkSetQATPosition.CheckButtons.Add(this.checkButtonAbove);
            this.checkSetQATPosition.CheckButtons.Add(this.checkButtonBelow);
            this.checkSetQATPosition.CheckButtons.Add(this.checkButtonHidden);
            this.checkSetQATPosition.CheckedButton = this.checkButtonAbove;
            this.checkSetQATPosition.CheckedButtonChanged += new System.EventHandler(this.checkSetQATPosition_CheckedButtonChanged);
            // 
            // checkSetQATUserChange
            // 
            this.checkSetQATUserChange.CheckButtons.Add(this.checkButtonDisallowUserChanges);
            this.checkSetQATUserChange.CheckButtons.Add(this.checkButtonAllowUserChanges);
            this.checkSetQATUserChange.CheckedButton = this.checkButtonAllowUserChanges;
            this.checkSetQATUserChange.CheckedButtonChanged += new System.EventHandler(this.checkSetQATUserChange_CheckedButtonChanged);
            // 
            // kryptonCheckButton1
            // 
            this.kryptonCheckButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.kryptonCheckButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.kryptonCheckButton1.Location = new System.Drawing.Point(20, 101);
            this.kryptonCheckButton1.Name = "kryptonCheckButton1";
            this.kryptonCheckButton1.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.kryptonCheckButton1.Size = new System.Drawing.Size(90, 25);
            this.kryptonCheckButton1.TabIndex = 4;
            this.kryptonCheckButton1.Values.Text = "Hidden";
            // 
            // kryptonCheckButton2
            // 
            this.kryptonCheckButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.kryptonCheckButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.kryptonCheckButton2.Location = new System.Drawing.Point(20, 70);
            this.kryptonCheckButton2.Name = "kryptonCheckButton2";
            this.kryptonCheckButton2.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.kryptonCheckButton2.Size = new System.Drawing.Size(90, 25);
            this.kryptonCheckButton2.TabIndex = 3;
            this.kryptonCheckButton2.Values.Text = "Below";
            // 
            // kryptonCheckButton3
            // 
            this.kryptonCheckButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.kryptonCheckButton3.Checked = true;
            this.kryptonCheckButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.kryptonCheckButton3.Location = new System.Drawing.Point(20, 39);
            this.kryptonCheckButton3.Name = "kryptonCheckButton3";
            this.kryptonCheckButton3.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.kryptonCheckButton3.Size = new System.Drawing.Size(90, 25);
            this.kryptonCheckButton3.TabIndex = 2;
            this.kryptonCheckButton3.Values.Text = "Above";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(4, 4);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(123, 27);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "QAT Location";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 411);
            this.Controls.Add(this.panelFill);
            this.Controls.Add(this.kryptonRibbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(383, 445);
            this.Name = "Form1";
            this.Text = "Quick Access Toolbar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelFill)).EndInit();
            this.panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2.Panel)).EndInit();
            this.kryptonGroup2.Panel.ResumeLayout(false);
            this.kryptonGroup2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2)).EndInit();
            this.kryptonGroup2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            this.kryptonGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupQATLocation.Panel)).EndInit();
            this.groupQATLocation.Panel.ResumeLayout(false);
            this.groupQATLocation.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupQATLocation)).EndInit();
            this.groupQATLocation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkSetQATPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkSetQATUserChange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Ribbon.KryptonRibbon kryptonRibbon;
        private Krypton.Ribbon.KryptonRibbonTab tabHome;
        private Krypton.Toolkit.KryptonManager kryptonManager;
        private Krypton.Toolkit.KryptonPanel panelFill;
        private Krypton.Toolkit.KryptonCheckSet checkSetQATPosition;
        private Krypton.Toolkit.KryptonGroup groupQATLocation;
        private Krypton.Toolkit.KryptonLabel labelQATLocation;
        private Krypton.Toolkit.KryptonCheckButton checkButtonHidden;
        private Krypton.Toolkit.KryptonCheckButton checkButtonBelow;
        private Krypton.Toolkit.KryptonCheckButton checkButtonAbove;
        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private Krypton.Toolkit.KryptonCheckButton checkButtonDisallowUserChanges;
        private Krypton.Toolkit.KryptonCheckButton checkButtonAllowUserChanges;
        private Krypton.Toolkit.KryptonLabel labelQATUserChange;
        private Krypton.Toolkit.KryptonCheckSet checkSetQATUserChange;
        private Krypton.Toolkit.KryptonGroup kryptonGroup2;
        private Krypton.Toolkit.KryptonButton buttonClear;
        private Krypton.Toolkit.KryptonButton buttonRemove;
        private Krypton.Toolkit.KryptonButton buttonAdd;
        private Krypton.Toolkit.KryptonLabel labelQATButtons;
        private Krypton.Toolkit.KryptonCheckButton kryptonCheckButton1;
        private Krypton.Toolkit.KryptonCheckButton kryptonCheckButton2;
        private Krypton.Toolkit.KryptonCheckButton kryptonCheckButton3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem1;
    }
}

