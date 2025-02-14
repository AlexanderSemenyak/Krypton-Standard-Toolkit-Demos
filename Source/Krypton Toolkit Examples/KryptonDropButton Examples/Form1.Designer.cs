namespace KryptonDropButtonExamples
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
            this.groupProperties = new System.Windows.Forms.GroupBox();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.groupSplitter = new System.Windows.Forms.GroupBox();
            this.splitterArrowLeft = new Krypton.Toolkit.KryptonDropButton();
            this.kcmDropDown = new Krypton.Toolkit.KryptonContextMenu();
            this.kryptonContextMenuHeading1 = new Krypton.Toolkit.KryptonContextMenuHeading();
            this.kryptonContextMenuItems1 = new Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem1 = new Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItem2 = new Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItem3 = new Krypton.Toolkit.KryptonContextMenuItem();
            this.splitterArrowRight = new Krypton.Toolkit.KryptonDropButton();
            this.splitterArrowUp = new Krypton.Toolkit.KryptonDropButton();
            this.splitterArrowDown = new Krypton.Toolkit.KryptonDropButton();
            this.splitterPosBottom = new Krypton.Toolkit.KryptonDropButton();
            this.splitterPosTop = new Krypton.Toolkit.KryptonDropButton();
            this.splitterPosLeft = new Krypton.Toolkit.KryptonDropButton();
            this.splitterPosRight = new Krypton.Toolkit.KryptonDropButton();
            this.groupDropDown = new System.Windows.Forms.GroupBox();
            this.dropArrowLeft = new Krypton.Toolkit.KryptonDropButton();
            this.dropArrowRight = new Krypton.Toolkit.KryptonDropButton();
            this.dropArrowUp = new Krypton.Toolkit.KryptonDropButton();
            this.dropArrowDown = new Krypton.Toolkit.KryptonDropButton();
            this.dropPosBottom = new Krypton.Toolkit.KryptonDropButton();
            this.dropPosTop = new Krypton.Toolkit.KryptonDropButton();
            this.dropPosLeft = new Krypton.Toolkit.KryptonDropButton();
            this.dropPosRight = new Krypton.Toolkit.KryptonDropButton();
            this.groupCustom = new System.Windows.Forms.GroupBox();
            this.dropCustom = new Krypton.Toolkit.KryptonDropButton();
            this.kcmCustom = new Krypton.Toolkit.KryptonContextMenu();
            this.kryptonContextMenuHeading5 = new Krypton.Toolkit.KryptonContextMenuHeading();
            this.kryptonContextMenuItems5 = new Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem13 = new Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItem14 = new Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItem15 = new Krypton.Toolkit.KryptonContextMenuItem();
            this.splitterCustom = new Krypton.Toolkit.KryptonDropButton();
            this.groupProperties.SuspendLayout();
            this.groupSplitter.SuspendLayout();
            this.groupDropDown.SuspendLayout();
            this.groupCustom.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(553, 526);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupProperties
            // 
            this.groupProperties.Controls.Add(this.propertyGrid);
            this.groupProperties.Location = new System.Drawing.Point(306, 12);
            this.groupProperties.Name = "groupProperties";
            this.groupProperties.Size = new System.Drawing.Size(322, 508);
            this.groupProperties.TabIndex = 3;
            this.groupProperties.TabStop = false;
            this.groupProperties.Text = "Properties for Selected KryptonDropButton";
            // 
            // propertyGrid
            // 
            this.propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid.Location = new System.Drawing.Point(6, 19);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(310, 483);
            this.propertyGrid.TabIndex = 0;
            this.propertyGrid.ToolbarVisible = false;
            // 
            // groupSplitter
            // 
            this.groupSplitter.Controls.Add(this.splitterArrowLeft);
            this.groupSplitter.Controls.Add(this.splitterArrowRight);
            this.groupSplitter.Controls.Add(this.splitterArrowUp);
            this.groupSplitter.Controls.Add(this.splitterArrowDown);
            this.groupSplitter.Controls.Add(this.splitterPosBottom);
            this.groupSplitter.Controls.Add(this.splitterPosTop);
            this.groupSplitter.Controls.Add(this.splitterPosLeft);
            this.groupSplitter.Controls.Add(this.splitterPosRight);
            this.groupSplitter.Location = new System.Drawing.Point(12, 12);
            this.groupSplitter.Name = "groupSplitter";
            this.groupSplitter.Size = new System.Drawing.Size(288, 191);
            this.groupSplitter.TabIndex = 0;
            this.groupSplitter.TabStop = false;
            this.groupSplitter.Text = "Splitter";
            // 
            // splitterArrowLeft
            // 
            this.splitterArrowLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.splitterArrowLeft.ButtonOrientation = Krypton.Toolkit.VisualOrientation.Top;
            this.splitterArrowLeft.DialogResult = System.Windows.Forms.DialogResult.None;
            this.splitterArrowLeft.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Left;
            this.splitterArrowLeft.DropDownPosition = Krypton.Toolkit.VisualOrientation.Right;
            this.splitterArrowLeft.KryptonContextMenu = this.kcmDropDown;
            this.splitterArrowLeft.Location = new System.Drawing.Point(154, 92);
            this.splitterArrowLeft.Name = "splitterArrowLeft";
            this.splitterArrowLeft.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.splitterArrowLeft.Size = new System.Drawing.Size(115, 25);
            this.splitterArrowLeft.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.splitterArrowLeft.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.splitterArrowLeft.StateCommon.Content.Image.Effect = Krypton.Toolkit.PaletteImageEffect.Inherit;
            this.splitterArrowLeft.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.splitterArrowLeft.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.splitterArrowLeft.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.splitterArrowLeft.StateCommon.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.splitterArrowLeft.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.splitterArrowLeft.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.splitterArrowLeft.StateCommon.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.splitterArrowLeft.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.splitterArrowLeft.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.splitterArrowLeft.StateCommon.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.splitterArrowLeft.StateCommon.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.splitterArrowLeft.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.splitterArrowLeft.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.splitterArrowLeft.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.splitterArrowLeft.TabIndex = 6;
            this.splitterArrowLeft.Values.Image = ((System.Drawing.Image)(resources.GetObject("splitterArrowLeft.Values.Image")));
            this.splitterArrowLeft.Values.Text = "Arrow Left";
            this.splitterArrowLeft.Enter += new System.EventHandler(this.dropButtonEnter);
            // 
            // kcmDropDown
            // 
            this.kcmDropDown.Items.AddRange(new Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuHeading1,
            this.kryptonContextMenuItems1});
            this.kcmDropDown.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            // 
            // kryptonContextMenuHeading1
            // 
            this.kryptonContextMenuHeading1.ExtraText = "";
            // 
            // kryptonContextMenuItems1
            // 
            this.kryptonContextMenuItems1.Items.AddRange(new Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItem1,
            this.kryptonContextMenuItem2,
            this.kryptonContextMenuItem3});
            // 
            // kryptonContextMenuItem1
            // 
            this.kryptonContextMenuItem1.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.kryptonContextMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.None;
            this.kryptonContextMenuItem1.Text = "Menu Item 1";
            // 
            // kryptonContextMenuItem2
            // 
            this.kryptonContextMenuItem2.Checked = true;
            this.kryptonContextMenuItem2.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.kryptonContextMenuItem2.ShortcutKeys = System.Windows.Forms.Keys.None;
            this.kryptonContextMenuItem2.Text = "Menu Item 2";
            // 
            // kryptonContextMenuItem3
            // 
            this.kryptonContextMenuItem3.Checked = true;
            this.kryptonContextMenuItem3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.kryptonContextMenuItem3.ShortcutKeys = System.Windows.Forms.Keys.None;
            this.kryptonContextMenuItem3.Text = "Menu Item 3";
            // 
            // splitterArrowRight
            // 
            this.splitterArrowRight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.splitterArrowRight.ButtonOrientation = Krypton.Toolkit.VisualOrientation.Top;
            this.splitterArrowRight.DialogResult = System.Windows.Forms.DialogResult.None;
            this.splitterArrowRight.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Right;
            this.splitterArrowRight.DropDownPosition = Krypton.Toolkit.VisualOrientation.Right;
            this.splitterArrowRight.KryptonContextMenu = this.kcmDropDown;
            this.splitterArrowRight.Location = new System.Drawing.Point(154, 30);
            this.splitterArrowRight.Name = "splitterArrowRight";
            this.splitterArrowRight.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.splitterArrowRight.Size = new System.Drawing.Size(115, 25);
            this.splitterArrowRight.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.splitterArrowRight.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.splitterArrowRight.StateCommon.Content.Image.Effect = Krypton.Toolkit.PaletteImageEffect.Inherit;
            this.splitterArrowRight.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.splitterArrowRight.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.splitterArrowRight.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.splitterArrowRight.StateCommon.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.splitterArrowRight.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.splitterArrowRight.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.splitterArrowRight.StateCommon.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.splitterArrowRight.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.splitterArrowRight.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.splitterArrowRight.StateCommon.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.splitterArrowRight.StateCommon.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.splitterArrowRight.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.splitterArrowRight.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.splitterArrowRight.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.splitterArrowRight.TabIndex = 4;
            this.splitterArrowRight.Values.Image = ((System.Drawing.Image)(resources.GetObject("splitterArrowRight.Values.Image")));
            this.splitterArrowRight.Values.Text = "Arrow Right";
            this.splitterArrowRight.Enter += new System.EventHandler(this.dropButtonEnter);
            // 
            // splitterArrowUp
            // 
            this.splitterArrowUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.splitterArrowUp.ButtonOrientation = Krypton.Toolkit.VisualOrientation.Top;
            this.splitterArrowUp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.splitterArrowUp.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Top;
            this.splitterArrowUp.DropDownPosition = Krypton.Toolkit.VisualOrientation.Right;
            this.splitterArrowUp.KryptonContextMenu = this.kcmDropDown;
            this.splitterArrowUp.Location = new System.Drawing.Point(154, 123);
            this.splitterArrowUp.Name = "splitterArrowUp";
            this.splitterArrowUp.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.splitterArrowUp.Size = new System.Drawing.Size(115, 25);
            this.splitterArrowUp.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.splitterArrowUp.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.splitterArrowUp.StateCommon.Content.Image.Effect = Krypton.Toolkit.PaletteImageEffect.Inherit;
            this.splitterArrowUp.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.splitterArrowUp.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.splitterArrowUp.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.splitterArrowUp.StateCommon.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.splitterArrowUp.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.splitterArrowUp.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.splitterArrowUp.StateCommon.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.splitterArrowUp.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.splitterArrowUp.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.splitterArrowUp.StateCommon.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.splitterArrowUp.StateCommon.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.splitterArrowUp.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.splitterArrowUp.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.splitterArrowUp.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.splitterArrowUp.TabIndex = 7;
            this.splitterArrowUp.Values.Image = ((System.Drawing.Image)(resources.GetObject("splitterArrowUp.Values.Image")));
            this.splitterArrowUp.Values.Text = "Arrow Up";
            this.splitterArrowUp.Enter += new System.EventHandler(this.dropButtonEnter);
            // 
            // splitterArrowDown
            // 
            this.splitterArrowDown.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.splitterArrowDown.ButtonOrientation = Krypton.Toolkit.VisualOrientation.Top;
            this.splitterArrowDown.DialogResult = System.Windows.Forms.DialogResult.None;
            this.splitterArrowDown.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Bottom;
            this.splitterArrowDown.DropDownPosition = Krypton.Toolkit.VisualOrientation.Right;
            this.splitterArrowDown.KryptonContextMenu = this.kcmDropDown;
            this.splitterArrowDown.Location = new System.Drawing.Point(154, 61);
            this.splitterArrowDown.Name = "splitterArrowDown";
            this.splitterArrowDown.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.splitterArrowDown.Size = new System.Drawing.Size(115, 25);
            this.splitterArrowDown.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.splitterArrowDown.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.splitterArrowDown.StateCommon.Content.Image.Effect = Krypton.Toolkit.PaletteImageEffect.Inherit;
            this.splitterArrowDown.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.splitterArrowDown.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.splitterArrowDown.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.splitterArrowDown.StateCommon.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.splitterArrowDown.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.splitterArrowDown.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.splitterArrowDown.StateCommon.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.splitterArrowDown.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.splitterArrowDown.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.splitterArrowDown.StateCommon.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.splitterArrowDown.StateCommon.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.splitterArrowDown.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.splitterArrowDown.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.splitterArrowDown.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.splitterArrowDown.TabIndex = 5;
            this.splitterArrowDown.Values.Image = ((System.Drawing.Image)(resources.GetObject("splitterArrowDown.Values.Image")));
            this.splitterArrowDown.Values.Text = "Arrow Down";
            this.splitterArrowDown.Enter += new System.EventHandler(this.dropButtonEnter);
            // 
            // splitterPosBottom
            // 
            this.splitterPosBottom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.splitterPosBottom.ButtonOrientation = Krypton.Toolkit.VisualOrientation.Top;
            this.splitterPosBottom.DialogResult = System.Windows.Forms.DialogResult.None;
            this.splitterPosBottom.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Bottom;
            this.splitterPosBottom.DropDownPosition = Krypton.Toolkit.VisualOrientation.Bottom;
            this.splitterPosBottom.KryptonContextMenu = this.kcmDropDown;
            this.splitterPosBottom.Location = new System.Drawing.Point(25, 136);
            this.splitterPosBottom.Name = "splitterPosBottom";
            this.splitterPosBottom.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.splitterPosBottom.Size = new System.Drawing.Size(104, 38);
            this.splitterPosBottom.TabIndex = 3;
            this.splitterPosBottom.Values.Text = "Position Bottom";
            this.splitterPosBottom.Enter += new System.EventHandler(this.dropButtonEnter);
            // 
            // splitterPosTop
            // 
            this.splitterPosTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.splitterPosTop.ButtonOrientation = Krypton.Toolkit.VisualOrientation.Top;
            this.splitterPosTop.DialogResult = System.Windows.Forms.DialogResult.None;
            this.splitterPosTop.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Bottom;
            this.splitterPosTop.DropDownPosition = Krypton.Toolkit.VisualOrientation.Top;
            this.splitterPosTop.KryptonContextMenu = this.kcmDropDown;
            this.splitterPosTop.Location = new System.Drawing.Point(25, 92);
            this.splitterPosTop.Name = "splitterPosTop";
            this.splitterPosTop.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.splitterPosTop.Size = new System.Drawing.Size(104, 38);
            this.splitterPosTop.TabIndex = 2;
            this.splitterPosTop.Values.Text = "Position Top";
            this.splitterPosTop.Enter += new System.EventHandler(this.dropButtonEnter);
            // 
            // splitterPosLeft
            // 
            this.splitterPosLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.splitterPosLeft.ButtonOrientation = Krypton.Toolkit.VisualOrientation.Top;
            this.splitterPosLeft.DialogResult = System.Windows.Forms.DialogResult.None;
            this.splitterPosLeft.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Bottom;
            this.splitterPosLeft.DropDownPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.splitterPosLeft.KryptonContextMenu = this.kcmDropDown;
            this.splitterPosLeft.Location = new System.Drawing.Point(25, 61);
            this.splitterPosLeft.Name = "splitterPosLeft";
            this.splitterPosLeft.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.splitterPosLeft.Size = new System.Drawing.Size(104, 25);
            this.splitterPosLeft.TabIndex = 1;
            this.splitterPosLeft.Values.Text = "Position Left";
            this.splitterPosLeft.Enter += new System.EventHandler(this.dropButtonEnter);
            // 
            // splitterPosRight
            // 
            this.splitterPosRight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.splitterPosRight.ButtonOrientation = Krypton.Toolkit.VisualOrientation.Top;
            this.splitterPosRight.DialogResult = System.Windows.Forms.DialogResult.None;
            this.splitterPosRight.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Bottom;
            this.splitterPosRight.DropDownPosition = Krypton.Toolkit.VisualOrientation.Right;
            this.splitterPosRight.KryptonContextMenu = this.kcmDropDown;
            this.splitterPosRight.Location = new System.Drawing.Point(25, 30);
            this.splitterPosRight.Name = "splitterPosRight";
            this.splitterPosRight.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.splitterPosRight.Size = new System.Drawing.Size(104, 25);
            this.splitterPosRight.TabIndex = 0;
            this.splitterPosRight.Values.Text = "Position Right";
            this.splitterPosRight.Enter += new System.EventHandler(this.dropButtonEnter);
            // 
            // groupDropDown
            // 
            this.groupDropDown.Controls.Add(this.dropArrowLeft);
            this.groupDropDown.Controls.Add(this.dropArrowRight);
            this.groupDropDown.Controls.Add(this.dropArrowUp);
            this.groupDropDown.Controls.Add(this.dropArrowDown);
            this.groupDropDown.Controls.Add(this.dropPosBottom);
            this.groupDropDown.Controls.Add(this.dropPosTop);
            this.groupDropDown.Controls.Add(this.dropPosLeft);
            this.groupDropDown.Controls.Add(this.dropPosRight);
            this.groupDropDown.Location = new System.Drawing.Point(12, 209);
            this.groupDropDown.Name = "groupDropDown";
            this.groupDropDown.Size = new System.Drawing.Size(288, 191);
            this.groupDropDown.TabIndex = 1;
            this.groupDropDown.TabStop = false;
            this.groupDropDown.Text = "DropDown";
            // 
            // dropArrowLeft
            // 
            this.dropArrowLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.dropArrowLeft.ButtonOrientation = Krypton.Toolkit.VisualOrientation.Top;
            this.dropArrowLeft.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dropArrowLeft.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Left;
            this.dropArrowLeft.DropDownPosition = Krypton.Toolkit.VisualOrientation.Right;
            this.dropArrowLeft.KryptonContextMenu = this.kcmDropDown;
            this.dropArrowLeft.Location = new System.Drawing.Point(154, 92);
            this.dropArrowLeft.Name = "dropArrowLeft";
            this.dropArrowLeft.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.dropArrowLeft.Size = new System.Drawing.Size(115, 25);
            this.dropArrowLeft.Splitter = false;
            this.dropArrowLeft.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.dropArrowLeft.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.dropArrowLeft.StateCommon.Content.Image.Effect = Krypton.Toolkit.PaletteImageEffect.Inherit;
            this.dropArrowLeft.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.dropArrowLeft.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.dropArrowLeft.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.dropArrowLeft.StateCommon.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.dropArrowLeft.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.dropArrowLeft.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.dropArrowLeft.StateCommon.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.dropArrowLeft.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.dropArrowLeft.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.dropArrowLeft.StateCommon.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.dropArrowLeft.StateCommon.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.dropArrowLeft.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.dropArrowLeft.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.dropArrowLeft.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.dropArrowLeft.TabIndex = 6;
            this.dropArrowLeft.Values.Image = ((System.Drawing.Image)(resources.GetObject("dropArrowLeft.Values.Image")));
            this.dropArrowLeft.Values.Text = "Arrow Left";
            this.dropArrowLeft.Enter += new System.EventHandler(this.dropButtonEnter);
            // 
            // dropArrowRight
            // 
            this.dropArrowRight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.dropArrowRight.ButtonOrientation = Krypton.Toolkit.VisualOrientation.Top;
            this.dropArrowRight.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dropArrowRight.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Right;
            this.dropArrowRight.DropDownPosition = Krypton.Toolkit.VisualOrientation.Right;
            this.dropArrowRight.KryptonContextMenu = this.kcmDropDown;
            this.dropArrowRight.Location = new System.Drawing.Point(154, 30);
            this.dropArrowRight.Name = "dropArrowRight";
            this.dropArrowRight.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.dropArrowRight.Size = new System.Drawing.Size(115, 25);
            this.dropArrowRight.Splitter = false;
            this.dropArrowRight.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.dropArrowRight.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.dropArrowRight.StateCommon.Content.Image.Effect = Krypton.Toolkit.PaletteImageEffect.Inherit;
            this.dropArrowRight.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.dropArrowRight.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.dropArrowRight.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.dropArrowRight.StateCommon.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.dropArrowRight.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.dropArrowRight.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.dropArrowRight.StateCommon.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.dropArrowRight.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.dropArrowRight.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.dropArrowRight.StateCommon.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.dropArrowRight.StateCommon.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.dropArrowRight.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.dropArrowRight.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.dropArrowRight.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.dropArrowRight.TabIndex = 4;
            this.dropArrowRight.Values.Image = ((System.Drawing.Image)(resources.GetObject("dropArrowRight.Values.Image")));
            this.dropArrowRight.Values.Text = "Arrow Right";
            this.dropArrowRight.Enter += new System.EventHandler(this.dropButtonEnter);
            // 
            // dropArrowUp
            // 
            this.dropArrowUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.dropArrowUp.ButtonOrientation = Krypton.Toolkit.VisualOrientation.Top;
            this.dropArrowUp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dropArrowUp.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Top;
            this.dropArrowUp.DropDownPosition = Krypton.Toolkit.VisualOrientation.Right;
            this.dropArrowUp.KryptonContextMenu = this.kcmDropDown;
            this.dropArrowUp.Location = new System.Drawing.Point(154, 123);
            this.dropArrowUp.Name = "dropArrowUp";
            this.dropArrowUp.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.dropArrowUp.Size = new System.Drawing.Size(115, 25);
            this.dropArrowUp.Splitter = false;
            this.dropArrowUp.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.dropArrowUp.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.dropArrowUp.StateCommon.Content.Image.Effect = Krypton.Toolkit.PaletteImageEffect.Inherit;
            this.dropArrowUp.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.dropArrowUp.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.dropArrowUp.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.dropArrowUp.StateCommon.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.dropArrowUp.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.dropArrowUp.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.dropArrowUp.StateCommon.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.dropArrowUp.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.dropArrowUp.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.dropArrowUp.StateCommon.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.dropArrowUp.StateCommon.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.dropArrowUp.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.dropArrowUp.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.dropArrowUp.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.dropArrowUp.TabIndex = 7;
            this.dropArrowUp.Values.Image = ((System.Drawing.Image)(resources.GetObject("dropArrowUp.Values.Image")));
            this.dropArrowUp.Values.Text = "Arrow Up";
            this.dropArrowUp.Enter += new System.EventHandler(this.dropButtonEnter);
            // 
            // dropArrowDown
            // 
            this.dropArrowDown.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.dropArrowDown.ButtonOrientation = Krypton.Toolkit.VisualOrientation.Top;
            this.dropArrowDown.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dropArrowDown.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Bottom;
            this.dropArrowDown.DropDownPosition = Krypton.Toolkit.VisualOrientation.Right;
            this.dropArrowDown.KryptonContextMenu = this.kcmDropDown;
            this.dropArrowDown.Location = new System.Drawing.Point(154, 61);
            this.dropArrowDown.Name = "dropArrowDown";
            this.dropArrowDown.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.dropArrowDown.Size = new System.Drawing.Size(115, 25);
            this.dropArrowDown.Splitter = false;
            this.dropArrowDown.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.dropArrowDown.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.dropArrowDown.StateCommon.Content.Image.Effect = Krypton.Toolkit.PaletteImageEffect.Inherit;
            this.dropArrowDown.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.dropArrowDown.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.dropArrowDown.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.dropArrowDown.StateCommon.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.dropArrowDown.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.dropArrowDown.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.dropArrowDown.StateCommon.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.dropArrowDown.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.dropArrowDown.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.dropArrowDown.StateCommon.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.dropArrowDown.StateCommon.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.dropArrowDown.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.dropArrowDown.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.dropArrowDown.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.dropArrowDown.TabIndex = 5;
            this.dropArrowDown.Values.Image = ((System.Drawing.Image)(resources.GetObject("dropArrowDown.Values.Image")));
            this.dropArrowDown.Values.Text = "Arrow Down";
            this.dropArrowDown.Enter += new System.EventHandler(this.dropButtonEnter);
            // 
            // dropPosBottom
            // 
            this.dropPosBottom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.dropPosBottom.ButtonOrientation = Krypton.Toolkit.VisualOrientation.Top;
            this.dropPosBottom.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dropPosBottom.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Bottom;
            this.dropPosBottom.DropDownPosition = Krypton.Toolkit.VisualOrientation.Bottom;
            this.dropPosBottom.KryptonContextMenu = this.kcmDropDown;
            this.dropPosBottom.Location = new System.Drawing.Point(25, 136);
            this.dropPosBottom.Name = "dropPosBottom";
            this.dropPosBottom.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.dropPosBottom.Size = new System.Drawing.Size(104, 38);
            this.dropPosBottom.Splitter = false;
            this.dropPosBottom.TabIndex = 3;
            this.dropPosBottom.Values.Text = "Position Bottom";
            this.dropPosBottom.Enter += new System.EventHandler(this.dropButtonEnter);
            // 
            // dropPosTop
            // 
            this.dropPosTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.dropPosTop.ButtonOrientation = Krypton.Toolkit.VisualOrientation.Top;
            this.dropPosTop.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dropPosTop.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Bottom;
            this.dropPosTop.DropDownPosition = Krypton.Toolkit.VisualOrientation.Top;
            this.dropPosTop.KryptonContextMenu = this.kcmDropDown;
            this.dropPosTop.Location = new System.Drawing.Point(25, 92);
            this.dropPosTop.Name = "dropPosTop";
            this.dropPosTop.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.dropPosTop.Size = new System.Drawing.Size(104, 38);
            this.dropPosTop.Splitter = false;
            this.dropPosTop.TabIndex = 2;
            this.dropPosTop.Values.Text = "Position Top";
            this.dropPosTop.Enter += new System.EventHandler(this.dropButtonEnter);
            // 
            // dropPosLeft
            // 
            this.dropPosLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.dropPosLeft.ButtonOrientation = Krypton.Toolkit.VisualOrientation.Top;
            this.dropPosLeft.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dropPosLeft.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Bottom;
            this.dropPosLeft.DropDownPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.dropPosLeft.KryptonContextMenu = this.kcmDropDown;
            this.dropPosLeft.Location = new System.Drawing.Point(25, 61);
            this.dropPosLeft.Name = "dropPosLeft";
            this.dropPosLeft.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.dropPosLeft.Size = new System.Drawing.Size(104, 25);
            this.dropPosLeft.Splitter = false;
            this.dropPosLeft.TabIndex = 1;
            this.dropPosLeft.Values.Text = "Position Left";
            this.dropPosLeft.Enter += new System.EventHandler(this.dropButtonEnter);
            // 
            // dropPosRight
            // 
            this.dropPosRight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.dropPosRight.ButtonOrientation = Krypton.Toolkit.VisualOrientation.Top;
            this.dropPosRight.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dropPosRight.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Bottom;
            this.dropPosRight.DropDownPosition = Krypton.Toolkit.VisualOrientation.Right;
            this.dropPosRight.KryptonContextMenu = this.kcmDropDown;
            this.dropPosRight.Location = new System.Drawing.Point(25, 30);
            this.dropPosRight.Name = "dropPosRight";
            this.dropPosRight.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.dropPosRight.Size = new System.Drawing.Size(104, 25);
            this.dropPosRight.Splitter = false;
            this.dropPosRight.TabIndex = 0;
            this.dropPosRight.Values.Text = "Position Right";
            this.dropPosRight.Enter += new System.EventHandler(this.dropButtonEnter);
            // 
            // groupCustom
            // 
            this.groupCustom.Controls.Add(this.dropCustom);
            this.groupCustom.Controls.Add(this.splitterCustom);
            this.groupCustom.Location = new System.Drawing.Point(12, 407);
            this.groupCustom.Name = "groupCustom";
            this.groupCustom.Size = new System.Drawing.Size(288, 113);
            this.groupCustom.TabIndex = 2;
            this.groupCustom.TabStop = false;
            this.groupCustom.Text = "Custom";
            // 
            // dropCustom
            // 
            this.dropCustom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.dropCustom.ButtonOrientation = Krypton.Toolkit.VisualOrientation.Top;
            this.dropCustom.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dropCustom.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Bottom;
            this.dropCustom.DropDownPosition = Krypton.Toolkit.VisualOrientation.Bottom;
            this.dropCustom.Images.Normal = ((System.Drawing.Image)(resources.GetObject("dropCustom.Images.Normal")));
            this.dropCustom.Images.Pressed = ((System.Drawing.Image)(resources.GetObject("dropCustom.Images.Pressed")));
            this.dropCustom.Images.Tracking = ((System.Drawing.Image)(resources.GetObject("dropCustom.Images.Tracking")));
            this.dropCustom.KryptonContextMenu = this.kcmCustom;
            this.dropCustom.Location = new System.Drawing.Point(158, 30);
            this.dropCustom.Name = "dropCustom";
            this.dropCustom.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dropCustom.OverrideDefault.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.dropCustom.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.dropCustom.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.dropCustom.OverrideDefault.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.dropCustom.OverrideDefault.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.dropCustom.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.dropCustom.OverrideDefault.Border.Color1 = System.Drawing.Color.Green;
            this.dropCustom.OverrideDefault.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.dropCustom.OverrideDefault.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.dropCustom.OverrideDefault.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.dropCustom.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dropCustom.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.dropCustom.OverrideDefault.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.dropCustom.OverrideDefault.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.dropCustom.OverrideDefault.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.dropCustom.OverrideDefault.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.dropCustom.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dropCustom.OverrideDefault.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.dropCustom.OverrideDefault.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.dropCustom.OverrideDefault.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.dropCustom.OverrideDefault.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.dropCustom.OverrideDefault.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.dropCustom.OverrideDefault.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.dropCustom.OverrideDefault.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.dropCustom.OverrideDefault.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.dropCustom.OverrideDefault.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.dropCustom.OverrideDefault.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.dropCustom.OverrideDefault.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.dropCustom.Size = new System.Drawing.Size(115, 52);
            this.dropCustom.Splitter = false;
            this.dropCustom.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.dropCustom.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dropCustom.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.dropCustom.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.dropCustom.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.dropCustom.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.dropCustom.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.dropCustom.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dropCustom.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.dropCustom.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dropCustom.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.dropCustom.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.dropCustom.StateCommon.Border.Rounding = 4F;
            this.dropCustom.StateCommon.Border.Width = 2;
            this.dropCustom.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dropCustom.StateNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.dropCustom.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dropCustom.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.dropCustom.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.dropCustom.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.dropCustom.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.dropCustom.StateNormal.Border.Color1 = System.Drawing.Color.Green;
            this.dropCustom.StateNormal.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.dropCustom.StateNormal.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.dropCustom.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.dropCustom.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dropCustom.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.dropCustom.StateNormal.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.dropCustom.StateNormal.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.dropCustom.StateNormal.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.dropCustom.StateNormal.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.dropCustom.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dropCustom.StateNormal.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.dropCustom.StateNormal.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.dropCustom.StateNormal.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.dropCustom.StateNormal.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.dropCustom.StateNormal.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.dropCustom.StateNormal.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.dropCustom.StateNormal.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.dropCustom.StateNormal.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.dropCustom.StateNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.dropCustom.StateNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.dropCustom.StateNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.dropCustom.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dropCustom.StatePressed.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.dropCustom.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.dropCustom.StatePressed.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.dropCustom.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.dropCustom.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.dropCustom.StatePressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.dropCustom.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dropCustom.StatePressed.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.dropCustom.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.dropCustom.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.dropCustom.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dropCustom.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.dropCustom.StatePressed.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.dropCustom.StatePressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.dropCustom.StatePressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.dropCustom.StatePressed.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.dropCustom.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dropCustom.StatePressed.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.dropCustom.StatePressed.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.dropCustom.StatePressed.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.dropCustom.StatePressed.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.dropCustom.StatePressed.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.dropCustom.StatePressed.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.dropCustom.StatePressed.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.dropCustom.StatePressed.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.dropCustom.StatePressed.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.dropCustom.StatePressed.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.dropCustom.StatePressed.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.dropCustom.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dropCustom.StateTracking.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.dropCustom.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.dropCustom.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.dropCustom.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.dropCustom.StateTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.dropCustom.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.dropCustom.StateTracking.Border.Color1 = System.Drawing.Color.Navy;
            this.dropCustom.StateTracking.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.dropCustom.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.dropCustom.StateTracking.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.dropCustom.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dropCustom.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.dropCustom.StateTracking.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.dropCustom.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.dropCustom.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.dropCustom.StateTracking.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.dropCustom.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dropCustom.StateTracking.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.dropCustom.StateTracking.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.dropCustom.StateTracking.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.dropCustom.StateTracking.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.dropCustom.StateTracking.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.dropCustom.StateTracking.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.dropCustom.StateTracking.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.dropCustom.StateTracking.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.dropCustom.StateTracking.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.dropCustom.StateTracking.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.dropCustom.StateTracking.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.dropCustom.TabIndex = 1;
            this.dropCustom.Values.Text = "Custom DropDown";
            this.dropCustom.Enter += new System.EventHandler(this.dropButtonEnter);
            // 
            // kcmCustom
            // 
            this.kcmCustom.Items.AddRange(new Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuHeading5,
            this.kryptonContextMenuItems5});
            this.kcmCustom.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kcmCustom.StateCommon.ControlInner.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kcmCustom.StateCommon.ControlInner.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kcmCustom.StateCommon.ControlInner.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kcmCustom.StateCommon.ControlInner.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kcmCustom.StateCommon.ControlInner.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kcmCustom.StateCommon.ControlInner.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kcmCustom.StateCommon.ControlInner.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcmCustom.StateCommon.ControlInner.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.kcmCustom.StateCommon.ControlInner.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kcmCustom.StateCommon.ControlInner.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kcmCustom.StateCommon.ControlInner.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kcmCustom.StateCommon.ControlInner.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kcmCustom.StateCommon.ControlInner.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kcmCustom.StateCommon.ControlInner.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kcmCustom.StateCommon.ControlInner.Border.Rounding = 4F;
            this.kcmCustom.StateCommon.ControlInner.Border.Width = 2;
            this.kcmCustom.StateCommon.ControlOuter.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kcmCustom.StateCommon.ControlOuter.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kcmCustom.StateCommon.ControlOuter.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kcmCustom.StateCommon.ControlOuter.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kcmCustom.StateCommon.ControlOuter.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kcmCustom.StateCommon.ControlOuter.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kcmCustom.StateCommon.ControlOuter.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcmCustom.StateCommon.ControlOuter.Border.Color1 = System.Drawing.Color.Green;
            this.kcmCustom.StateCommon.ControlOuter.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kcmCustom.StateCommon.ControlOuter.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kcmCustom.StateCommon.ControlOuter.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kcmCustom.StateCommon.ControlOuter.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kcmCustom.StateCommon.ControlOuter.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kcmCustom.StateCommon.ControlOuter.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kcmCustom.StateCommon.ControlOuter.Border.Rounding = 4F;
            this.kcmCustom.StateCommon.ControlOuter.Border.Width = 2;
            this.kcmCustom.StateCommon.Heading.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kcmCustom.StateCommon.Heading.Back.Color2 = System.Drawing.Color.Lime;
            this.kcmCustom.StateCommon.Heading.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kcmCustom.StateCommon.Heading.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kcmCustom.StateCommon.Heading.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kcmCustom.StateCommon.Heading.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kcmCustom.StateCommon.Heading.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kcmCustom.StateCommon.Heading.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcmCustom.StateCommon.Heading.Border.Color1 = System.Drawing.Color.Green;
            this.kcmCustom.StateCommon.Heading.Border.Color2 = System.Drawing.Color.Green;
            this.kcmCustom.StateCommon.Heading.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kcmCustom.StateCommon.Heading.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kcmCustom.StateCommon.Heading.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kcmCustom.StateCommon.Heading.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kcmCustom.StateCommon.Heading.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kcmCustom.StateCommon.Heading.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kcmCustom.StateCommon.Heading.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kcmCustom.StateCommon.Heading.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kcmCustom.StateCommon.Heading.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.kcmCustom.StateCommon.Heading.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kcmCustom.StateCommon.Heading.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kcmCustom.StateCommon.Heading.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kcmCustom.StateCommon.Heading.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kcmCustom.StateCommon.Heading.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kcmCustom.StateCommon.Heading.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcmCustom.StateCommon.Heading.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kcmCustom.StateCommon.Heading.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kcmCustom.StateCommon.Heading.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kcmCustom.StateCommon.Heading.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kcmCustom.StateCommon.Heading.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kcmCustom.StateCommon.Heading.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcmCustom.StateCommon.ItemImageColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(254)))), ((int)(((byte)(188)))));
            this.kcmCustom.StateCommon.ItemImageColumn.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kcmCustom.StateCommon.ItemImageColumn.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kcmCustom.StateCommon.ItemImageColumn.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kcmCustom.StateCommon.ItemImageColumn.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kcmCustom.StateCommon.ItemImageColumn.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kcmCustom.StateCommon.ItemImageColumn.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcmCustom.StateCommon.ItemImageColumn.Border.Color1 = System.Drawing.Color.Teal;
            this.kcmCustom.StateCommon.ItemImageColumn.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kcmCustom.StateCommon.ItemImageColumn.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kcmCustom.StateCommon.ItemImageColumn.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kcmCustom.StateCommon.ItemImageColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.kcmCustom.StateCommon.ItemImageColumn.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kcmCustom.StateCommon.ItemImageColumn.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kcmCustom.StateCommon.ItemTextStandard.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kcmCustom.StateCommon.ItemTextStandard.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kcmCustom.StateCommon.ItemTextStandard.Image.Effect = Krypton.Toolkit.PaletteImageEffect.Inherit;
            this.kcmCustom.StateCommon.ItemTextStandard.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kcmCustom.StateCommon.ItemTextStandard.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kcmCustom.StateCommon.ItemTextStandard.Padding = new System.Windows.Forms.Padding(-1);
            this.kcmCustom.StateCommon.ItemTextStandard.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kcmCustom.StateCommon.ItemTextStandard.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kcmCustom.StateCommon.ItemTextStandard.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kcmCustom.StateCommon.ItemTextStandard.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kcmCustom.StateCommon.ItemTextStandard.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kcmCustom.StateCommon.ItemTextStandard.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcmCustom.StateCommon.ItemTextStandard.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kcmCustom.StateCommon.ItemTextStandard.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kcmCustom.StateCommon.ItemTextStandard.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kcmCustom.StateCommon.ItemTextStandard.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kcmCustom.StateCommon.ItemTextStandard.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kcmCustom.StateCommon.ItemTextStandard.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            // 
            // kryptonContextMenuHeading5
            // 
            this.kryptonContextMenuHeading5.ExtraText = "";
            // 
            // kryptonContextMenuItems5
            // 
            this.kryptonContextMenuItems5.Items.AddRange(new Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItem13,
            this.kryptonContextMenuItem14,
            this.kryptonContextMenuItem15});
            // 
            // kryptonContextMenuItem13
            // 
            this.kryptonContextMenuItem13.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.kryptonContextMenuItem13.ShortcutKeys = System.Windows.Forms.Keys.None;
            this.kryptonContextMenuItem13.Text = "Menu Item 1";
            // 
            // kryptonContextMenuItem14
            // 
            this.kryptonContextMenuItem14.Checked = true;
            this.kryptonContextMenuItem14.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.kryptonContextMenuItem14.ShortcutKeys = System.Windows.Forms.Keys.None;
            this.kryptonContextMenuItem14.Text = "Menu Item 2";
            // 
            // kryptonContextMenuItem15
            // 
            this.kryptonContextMenuItem15.Checked = true;
            this.kryptonContextMenuItem15.CheckState = System.Windows.Forms.CheckState.Checked;
            this.kryptonContextMenuItem15.ShortcutKeys = System.Windows.Forms.Keys.None;
            this.kryptonContextMenuItem15.Text = "Menu Item 3";
            // 
            // splitterCustom
            // 
            this.splitterCustom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.splitterCustom.ButtonOrientation = Krypton.Toolkit.VisualOrientation.Top;
            this.splitterCustom.DialogResult = System.Windows.Forms.DialogResult.None;
            this.splitterCustom.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Bottom;
            this.splitterCustom.DropDownPosition = Krypton.Toolkit.VisualOrientation.Right;
            this.splitterCustom.Images.Normal = ((System.Drawing.Image)(resources.GetObject("splitterCustom.Images.Normal")));
            this.splitterCustom.Images.Pressed = ((System.Drawing.Image)(resources.GetObject("splitterCustom.Images.Pressed")));
            this.splitterCustom.Images.Tracking = ((System.Drawing.Image)(resources.GetObject("splitterCustom.Images.Tracking")));
            this.splitterCustom.KryptonContextMenu = this.kcmCustom;
            this.splitterCustom.Location = new System.Drawing.Point(16, 40);
            this.splitterCustom.Name = "splitterCustom";
            this.splitterCustom.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.splitterCustom.OverrideDefault.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.splitterCustom.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.splitterCustom.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.splitterCustom.OverrideDefault.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.splitterCustom.OverrideDefault.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.splitterCustom.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.splitterCustom.OverrideDefault.Border.Color1 = System.Drawing.Color.Green;
            this.splitterCustom.OverrideDefault.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.splitterCustom.OverrideDefault.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.splitterCustom.OverrideDefault.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.splitterCustom.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.splitterCustom.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.splitterCustom.OverrideDefault.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.splitterCustom.OverrideDefault.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.splitterCustom.OverrideDefault.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.splitterCustom.OverrideDefault.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.splitterCustom.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.splitterCustom.OverrideDefault.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.splitterCustom.OverrideDefault.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.splitterCustom.OverrideDefault.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.splitterCustom.OverrideDefault.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.splitterCustom.OverrideDefault.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.splitterCustom.OverrideDefault.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.splitterCustom.OverrideDefault.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.splitterCustom.OverrideDefault.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.splitterCustom.OverrideDefault.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.splitterCustom.OverrideDefault.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.splitterCustom.OverrideDefault.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.splitterCustom.Size = new System.Drawing.Size(122, 30);
            this.splitterCustom.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.splitterCustom.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.splitterCustom.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.splitterCustom.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.splitterCustom.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.splitterCustom.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.splitterCustom.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.splitterCustom.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.splitterCustom.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.splitterCustom.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.splitterCustom.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.splitterCustom.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.splitterCustom.StateCommon.Border.Rounding = 4F;
            this.splitterCustom.StateCommon.Border.Width = 2;
            this.splitterCustom.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.splitterCustom.StateNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.splitterCustom.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.splitterCustom.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.splitterCustom.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.splitterCustom.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.splitterCustom.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.splitterCustom.StateNormal.Border.Color1 = System.Drawing.Color.Green;
            this.splitterCustom.StateNormal.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.splitterCustom.StateNormal.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.splitterCustom.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.splitterCustom.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.splitterCustom.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.splitterCustom.StateNormal.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.splitterCustom.StateNormal.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.splitterCustom.StateNormal.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.splitterCustom.StateNormal.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.splitterCustom.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.splitterCustom.StateNormal.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.splitterCustom.StateNormal.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.splitterCustom.StateNormal.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.splitterCustom.StateNormal.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.splitterCustom.StateNormal.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.splitterCustom.StateNormal.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.splitterCustom.StateNormal.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.splitterCustom.StateNormal.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.splitterCustom.StateNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.splitterCustom.StateNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.splitterCustom.StateNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.splitterCustom.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.splitterCustom.StatePressed.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.splitterCustom.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.splitterCustom.StatePressed.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.splitterCustom.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.splitterCustom.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.splitterCustom.StatePressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.splitterCustom.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.splitterCustom.StatePressed.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.splitterCustom.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.splitterCustom.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.splitterCustom.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.splitterCustom.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.splitterCustom.StatePressed.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.splitterCustom.StatePressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.splitterCustom.StatePressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.splitterCustom.StatePressed.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.splitterCustom.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.splitterCustom.StatePressed.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.splitterCustom.StatePressed.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.splitterCustom.StatePressed.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.splitterCustom.StatePressed.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.splitterCustom.StatePressed.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.splitterCustom.StatePressed.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.splitterCustom.StatePressed.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.splitterCustom.StatePressed.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.splitterCustom.StatePressed.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.splitterCustom.StatePressed.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.splitterCustom.StatePressed.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.splitterCustom.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.splitterCustom.StateTracking.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.splitterCustom.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.splitterCustom.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.splitterCustom.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.splitterCustom.StateTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.splitterCustom.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.splitterCustom.StateTracking.Border.Color1 = System.Drawing.Color.Navy;
            this.splitterCustom.StateTracking.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.splitterCustom.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.splitterCustom.StateTracking.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.splitterCustom.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.splitterCustom.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.splitterCustom.StateTracking.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.splitterCustom.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.splitterCustom.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.splitterCustom.StateTracking.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.splitterCustom.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.splitterCustom.StateTracking.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.splitterCustom.StateTracking.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.splitterCustom.StateTracking.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.splitterCustom.StateTracking.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.splitterCustom.StateTracking.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.splitterCustom.StateTracking.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.splitterCustom.StateTracking.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.splitterCustom.StateTracking.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.splitterCustom.StateTracking.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.splitterCustom.StateTracking.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.splitterCustom.StateTracking.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.splitterCustom.TabIndex = 0;
            this.splitterCustom.Values.Text = "Custom Splitter";
            this.splitterCustom.Enter += new System.EventHandler(this.dropButtonEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 561);
            this.Controls.Add(this.groupCustom);
            this.Controls.Add(this.groupDropDown);
            this.Controls.Add(this.groupSplitter);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupProperties);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "KryptonDropButton Examples";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupProperties.ResumeLayout(false);
            this.groupSplitter.ResumeLayout(false);
            this.groupDropDown.ResumeLayout(false);
            this.groupCustom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupProperties;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.GroupBox groupSplitter;
        private Krypton.Toolkit.KryptonDropButton splitterPosBottom;
        private Krypton.Toolkit.KryptonDropButton splitterPosTop;
        private Krypton.Toolkit.KryptonDropButton splitterPosLeft;
        private Krypton.Toolkit.KryptonDropButton splitterPosRight;
        private Krypton.Toolkit.KryptonContextMenu kcmDropDown;
        private Krypton.Toolkit.KryptonContextMenuHeading kryptonContextMenuHeading1;
        private Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems1;
        private Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem1;
        private Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem2;
        private Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem3;
        private Krypton.Toolkit.KryptonDropButton splitterArrowLeft;
        private Krypton.Toolkit.KryptonDropButton splitterArrowRight;
        private Krypton.Toolkit.KryptonDropButton splitterArrowUp;
        private Krypton.Toolkit.KryptonDropButton splitterArrowDown;
        private System.Windows.Forms.GroupBox groupDropDown;
        private Krypton.Toolkit.KryptonDropButton dropArrowLeft;
        private Krypton.Toolkit.KryptonDropButton dropArrowRight;
        private Krypton.Toolkit.KryptonDropButton dropArrowUp;
        private Krypton.Toolkit.KryptonDropButton dropArrowDown;
        private Krypton.Toolkit.KryptonDropButton dropPosBottom;
        private Krypton.Toolkit.KryptonDropButton dropPosTop;
        private Krypton.Toolkit.KryptonDropButton dropPosLeft;
        private Krypton.Toolkit.KryptonDropButton dropPosRight;
        private System.Windows.Forms.GroupBox groupCustom;
        private Krypton.Toolkit.KryptonDropButton splitterCustom;
        private Krypton.Toolkit.KryptonDropButton dropCustom;
        private Krypton.Toolkit.KryptonContextMenu kcmCustom;
        private Krypton.Toolkit.KryptonContextMenuHeading kryptonContextMenuHeading5;
        private Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems5;
        private Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem13;
        private Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem14;
        private Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem15;
    }
}

