namespace KryptonTextBoxExamples
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.kryptonTextBox9Custom = new Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny2 = new Krypton.Toolkit.ButtonSpecAny();
            this.kryptonContextMenu = new Krypton.Toolkit.KryptonContextMenu();
            this.kryptonContextMenuItems1 = new Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem1 = new Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItem2 = new Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuSeparator1 = new Krypton.Toolkit.KryptonContextMenuSeparator();
            this.kryptonContextMenuItem3 = new Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonTextBox8Custom = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox7Custom = new Krypton.Toolkit.KryptonTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kryptonTextBox6System = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox5System = new Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny3 = new Krypton.Toolkit.ButtonSpecAny();
            this.kryptonTextBox4System = new Krypton.Toolkit.KryptonTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kryptonTextBox3Blue = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox2Blue = new Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new Krypton.Toolkit.ButtonSpecAny();
            this.kryptonTextBox1Blue = new Krypton.Toolkit.KryptonTextBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(460, 550);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.propertyGrid);
            this.groupBox4.Location = new System.Drawing.Point(213, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(322, 532);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Properties for Selected KryptonTextBox";
            // 
            // propertyGrid
            // 
            this.propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid.Location = new System.Drawing.Point(6, 19);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(310, 507);
            this.propertyGrid.TabIndex = 0;
            this.propertyGrid.ToolbarVisible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.kryptonTextBox9Custom);
            this.groupBox3.Controls.Add(this.kryptonTextBox8Custom);
            this.groupBox3.Controls.Add(this.kryptonTextBox7Custom);
            this.groupBox3.Location = new System.Drawing.Point(12, 386);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(195, 158);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Custom Settings";
            // 
            // kryptonTextBox9Custom
            // 
            this.kryptonTextBox9Custom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.kryptonTextBox9Custom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.kryptonTextBox9Custom.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny2});
            this.kryptonTextBox9Custom.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.kryptonTextBox9Custom.Location = new System.Drawing.Point(16, 115);
            this.kryptonTextBox9Custom.Name = "kryptonTextBox9Custom";
            this.kryptonTextBox9Custom.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.kryptonTextBox9Custom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.kryptonTextBox9Custom.Size = new System.Drawing.Size(161, 25);
            this.kryptonTextBox9Custom.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.kryptonTextBox9Custom.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.kryptonTextBox9Custom.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonTextBox9Custom.StateCommon.Border.ColorAngle = 80F;
            this.kryptonTextBox9Custom.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded;
            this.kryptonTextBox9Custom.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonTextBox9Custom.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox9Custom.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonTextBox9Custom.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonTextBox9Custom.StateCommon.Border.Rounding = 3F;
            this.kryptonTextBox9Custom.StateCommon.Border.Width = 1;
            this.kryptonTextBox9Custom.TabIndex = 2;
            this.kryptonTextBox9Custom.Text = "Use Button";
            this.kryptonTextBox9Custom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.kryptonTextBox9Custom.Enter += new System.EventHandler(this.kryptonTextBox1Blue_Enter);
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.KryptonContextMenu = this.kryptonContextMenu;
            this.buttonSpecAny2.Style = Krypton.Toolkit.PaletteButtonStyle.Standalone;
            this.buttonSpecAny2.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny2.UniqueName = "AFADF6E71C27433DAFADF6E71C27433D";
            // 
            // kryptonContextMenu
            // 
            this.kryptonContextMenu.Items.AddRange(new Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItems1});
            // 
            // kryptonContextMenuItems1
            // 
            this.kryptonContextMenuItems1.Items.AddRange(new Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItem1,
            this.kryptonContextMenuItem2,
            this.kryptonContextMenuSeparator1,
            this.kryptonContextMenuItem3});
            // 
            // kryptonContextMenuItem1
            // 
            this.kryptonContextMenuItem1.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.kryptonContextMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.None;
            this.kryptonContextMenuItem1.Text = "Fixed Text 1";
            this.kryptonContextMenuItem1.Click += new System.EventHandler(this.fixedText1_Click);
            // 
            // kryptonContextMenuItem2
            // 
            this.kryptonContextMenuItem2.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.kryptonContextMenuItem2.ShortcutKeys = System.Windows.Forms.Keys.None;
            this.kryptonContextMenuItem2.Text = "Fixed Text 2";
            this.kryptonContextMenuItem2.Click += new System.EventHandler(this.fixedText2_Click);
            // 
            // kryptonContextMenuItem3
            // 
            this.kryptonContextMenuItem3.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.kryptonContextMenuItem3.ShortcutKeys = System.Windows.Forms.Keys.None;
            this.kryptonContextMenuItem3.Text = "Clear";
            this.kryptonContextMenuItem3.Click += new System.EventHandler(this.clear_Click);
            // 
            // kryptonTextBox8Custom
            // 
            this.kryptonTextBox8Custom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.kryptonTextBox8Custom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.kryptonTextBox8Custom.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.kryptonTextBox8Custom.Location = new System.Drawing.Point(16, 72);
            this.kryptonTextBox8Custom.Name = "kryptonTextBox8Custom";
            this.kryptonTextBox8Custom.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.kryptonTextBox8Custom.PasswordChar = '●';
            this.kryptonTextBox8Custom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.kryptonTextBox8Custom.Size = new System.Drawing.Size(161, 27);
            this.kryptonTextBox8Custom.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonTextBox8Custom.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonTextBox8Custom.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonTextBox8Custom.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox8Custom.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonTextBox8Custom.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonTextBox8Custom.StateCommon.Border.Rounding = 4F;
            this.kryptonTextBox8Custom.StateCommon.Border.Width = 2;
            this.kryptonTextBox8Custom.TabIndex = 1;
            this.kryptonTextBox8Custom.Text = "Password";
            this.kryptonTextBox8Custom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.kryptonTextBox8Custom.UseSystemPasswordChar = true;
            this.kryptonTextBox8Custom.Enter += new System.EventHandler(this.kryptonTextBox1Blue_Enter);
            // 
            // kryptonTextBox7Custom
            // 
            this.kryptonTextBox7Custom.AlwaysActive = false;
            this.kryptonTextBox7Custom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.kryptonTextBox7Custom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.kryptonTextBox7Custom.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.kryptonTextBox7Custom.Location = new System.Drawing.Point(16, 29);
            this.kryptonTextBox7Custom.Name = "kryptonTextBox7Custom";
            this.kryptonTextBox7Custom.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.kryptonTextBox7Custom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.kryptonTextBox7Custom.Size = new System.Drawing.Size(161, 26);
            this.kryptonTextBox7Custom.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kryptonTextBox7Custom.StateActive.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonTextBox7Custom.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonTextBox7Custom.StateActive.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonTextBox7Custom.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox7Custom.StateActive.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonTextBox7Custom.StateActive.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonTextBox7Custom.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonTextBox7Custom.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonTextBox7Custom.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonTextBox7Custom.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox7Custom.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonTextBox7Custom.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonTextBox7Custom.StateCommon.Border.Rounding = 4F;
            this.kryptonTextBox7Custom.StateCommon.Border.Width = 2;
            this.kryptonTextBox7Custom.TabIndex = 0;
            this.kryptonTextBox7Custom.Text = "Orange when Active";
            this.kryptonTextBox7Custom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.kryptonTextBox7Custom.Enter += new System.EventHandler(this.kryptonTextBox1Blue_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kryptonTextBox6System);
            this.groupBox1.Controls.Add(this.kryptonTextBox5System);
            this.groupBox1.Controls.Add(this.kryptonTextBox4System);
            this.groupBox1.Location = new System.Drawing.Point(12, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 181);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Professional - System";
            // 
            // kryptonTextBox6System
            // 
            this.kryptonTextBox6System.AlwaysActive = false;
            this.kryptonTextBox6System.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.kryptonTextBox6System.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.kryptonTextBox6System.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.kryptonTextBox6System.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.kryptonTextBox6System.Location = new System.Drawing.Point(16, 82);
            this.kryptonTextBox6System.Multiline = true;
            this.kryptonTextBox6System.Name = "kryptonTextBox6System";
            this.kryptonTextBox6System.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonTextBox6System.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.kryptonTextBox6System.Size = new System.Drawing.Size(161, 81);
            this.kryptonTextBox6System.TabIndex = 2;
            this.kryptonTextBox6System.Text = "Ribbon style for use inside the Ribbon control. Also has Multiline setting set to" +
    " True.";
            this.kryptonTextBox6System.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.kryptonTextBox6System.Enter += new System.EventHandler(this.kryptonTextBox1Blue_Enter);
            // 
            // kryptonTextBox5System
            // 
            this.kryptonTextBox5System.AllowButtonSpecToolTips = true;
            this.kryptonTextBox5System.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.kryptonTextBox5System.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.kryptonTextBox5System.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny3});
            this.kryptonTextBox5System.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.kryptonTextBox5System.Location = new System.Drawing.Point(16, 55);
            this.kryptonTextBox5System.Name = "kryptonTextBox5System";
            this.kryptonTextBox5System.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonTextBox5System.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.kryptonTextBox5System.Size = new System.Drawing.Size(161, 20);
            this.kryptonTextBox5System.TabIndex = 1;
            this.kryptonTextBox5System.Text = "Use Button To Clear";
            this.kryptonTextBox5System.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.kryptonTextBox5System.Enter += new System.EventHandler(this.kryptonTextBox1Blue_Enter);
            // 
            // buttonSpecAny3
            // 
            this.buttonSpecAny3.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny3.UniqueName = "0D0CBE484603438F0D0CBE484603438F";
            this.buttonSpecAny3.Click += new System.EventHandler(this.buttonSpecAny3_Click);
            // 
            // kryptonTextBox4System
            // 
            this.kryptonTextBox4System.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.kryptonTextBox4System.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.kryptonTextBox4System.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.kryptonTextBox4System.Location = new System.Drawing.Point(16, 29);
            this.kryptonTextBox4System.Name = "kryptonTextBox4System";
            this.kryptonTextBox4System.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonTextBox4System.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.kryptonTextBox4System.Size = new System.Drawing.Size(161, 21);
            this.kryptonTextBox4System.TabIndex = 0;
            this.kryptonTextBox4System.Text = "KryptonTextBox";
            this.kryptonTextBox4System.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.kryptonTextBox4System.Enter += new System.EventHandler(this.kryptonTextBox1Blue_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kryptonTextBox3Blue);
            this.groupBox2.Controls.Add(this.kryptonTextBox2Blue);
            this.groupBox2.Controls.Add(this.kryptonTextBox1Blue);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 181);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Office 2007 - Blue";
            // 
            // kryptonTextBox3Blue
            // 
            this.kryptonTextBox3Blue.AlwaysActive = false;
            this.kryptonTextBox3Blue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.kryptonTextBox3Blue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.kryptonTextBox3Blue.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.kryptonTextBox3Blue.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.kryptonTextBox3Blue.Location = new System.Drawing.Point(16, 87);
            this.kryptonTextBox3Blue.Multiline = true;
            this.kryptonTextBox3Blue.Name = "kryptonTextBox3Blue";
            this.kryptonTextBox3Blue.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonTextBox3Blue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.kryptonTextBox3Blue.Size = new System.Drawing.Size(161, 84);
            this.kryptonTextBox3Blue.TabIndex = 2;
            this.kryptonTextBox3Blue.Text = "Ribbon style for use inside the Ribbon control. Also has Multiline setting set to" +
    " True.";
            this.kryptonTextBox3Blue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.kryptonTextBox3Blue.Enter += new System.EventHandler(this.kryptonTextBox1Blue_Enter);
            // 
            // kryptonTextBox2Blue
            // 
            this.kryptonTextBox2Blue.AllowButtonSpecToolTips = true;
            this.kryptonTextBox2Blue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.kryptonTextBox2Blue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.kryptonTextBox2Blue.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.kryptonTextBox2Blue.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.kryptonTextBox2Blue.Location = new System.Drawing.Point(16, 56);
            this.kryptonTextBox2Blue.Name = "kryptonTextBox2Blue";
            this.kryptonTextBox2Blue.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonTextBox2Blue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.kryptonTextBox2Blue.Size = new System.Drawing.Size(161, 23);
            this.kryptonTextBox2Blue.TabIndex = 1;
            this.kryptonTextBox2Blue.Text = "Use Button To Clear";
            this.kryptonTextBox2Blue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.kryptonTextBox2Blue.Enter += new System.EventHandler(this.kryptonTextBox1Blue_Enter);
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny1.UniqueName = "2600D6A1691343B72600D6A1691343B7";
            this.buttonSpecAny1.Click += new System.EventHandler(this.buttonSpecAny1_Click);
            // 
            // kryptonTextBox1Blue
            // 
            this.kryptonTextBox1Blue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.kryptonTextBox1Blue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.kryptonTextBox1Blue.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.kryptonTextBox1Blue.CueHint.Color1 = System.Drawing.Color.Gray;
            this.kryptonTextBox1Blue.CueHint.CueHintText = "Cue Hint Text";
            this.kryptonTextBox1Blue.CueHint.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox1Blue.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonTextBox1Blue.Location = new System.Drawing.Point(16, 30);
            this.kryptonTextBox1Blue.Name = "kryptonTextBox1Blue";
            this.kryptonTextBox1Blue.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonTextBox1Blue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.kryptonTextBox1Blue.Size = new System.Drawing.Size(161, 18);
            this.kryptonTextBox1Blue.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.kryptonTextBox1Blue.TabIndex = 0;
            this.kryptonTextBox1Blue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.kryptonTextBox1Blue.Enter += new System.EventHandler(this.kryptonTextBox1Blue_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 580);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Krypton TextBox Examples";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox3Blue;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2Blue;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1Blue;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox6System;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox5System;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox4System;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox8Custom;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox7Custom;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox9Custom;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny3;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private Krypton.Toolkit.KryptonContextMenu kryptonContextMenu;
        private Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems1;
        private Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem1;
        private Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem2;
        private Krypton.Toolkit.KryptonContextMenuSeparator kryptonContextMenuSeparator1;
        private Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem3;
    }
}

