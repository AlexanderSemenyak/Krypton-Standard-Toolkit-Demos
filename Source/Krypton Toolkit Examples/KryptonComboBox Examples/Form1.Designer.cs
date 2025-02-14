namespace KryptonComboBoxExamples
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kryptonComboBox3Blue = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonComboBox2Blue = new Krypton.Toolkit.KryptonComboBox();
            this.buttonSpecAny1 = new Krypton.Toolkit.ButtonSpecAny();
            this.kryptonComboBox1Blue = new Krypton.Toolkit.KryptonComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kryptonComboBox6System = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonComboBox5System = new Krypton.Toolkit.KryptonComboBox();
            this.buttonSpecAny2 = new Krypton.Toolkit.ButtonSpecAny();
            this.kryptonComboBox4System = new Krypton.Toolkit.KryptonComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.kryptonComboBox8Custom = new Krypton.Toolkit.KryptonComboBox();
            this.buttonSpecAny3 = new Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny4 = new Krypton.Toolkit.ButtonSpecAny();
            this.kryptonComboBox7Custom = new Krypton.Toolkit.KryptonComboBox();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox3Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox2Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1Blue)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox6System)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox5System)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox4System)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox8Custom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox7Custom)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(466, 408);
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
            this.groupBox4.Location = new System.Drawing.Point(219, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(322, 390);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Properties for Selected KryptonComboBox";
            // 
            // propertyGrid
            // 
            this.propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid.Location = new System.Drawing.Point(6, 19);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(310, 365);
            this.propertyGrid.TabIndex = 0;
            this.propertyGrid.ToolbarVisible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kryptonComboBox3Blue);
            this.groupBox2.Controls.Add(this.kryptonComboBox2Blue);
            this.groupBox2.Controls.Add(this.kryptonComboBox1Blue);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 126);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Office 2010 - Blue";
            // 
            // kryptonComboBox3Blue
            // 
            this.kryptonComboBox3Blue.AlwaysActive = false;
            this.kryptonComboBox3Blue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.kryptonComboBox3Blue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.kryptonComboBox3Blue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.kryptonComboBox3Blue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.kryptonComboBox3Blue.DropDownWidth = 121;
            this.kryptonComboBox3Blue.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.kryptonComboBox3Blue.IntegralHeight = false;
            this.kryptonComboBox3Blue.Items.AddRange(new object[] {
            "one",
            "two",
            "three",
            "four",
            "five",
            "six"});
            this.kryptonComboBox3Blue.Location = new System.Drawing.Point(16, 88);
            this.kryptonComboBox3Blue.Name = "kryptonComboBox3Blue";
            this.kryptonComboBox3Blue.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonComboBox3Blue.Size = new System.Drawing.Size(169, 21);
            this.kryptonComboBox3Blue.TabIndex = 0;
            this.kryptonComboBox3Blue.Text = "ribbon style";
            this.kryptonComboBox3Blue.Enter += new System.EventHandler(this.kryptonComboBox1Blue_Enter);
            // 
            // kryptonComboBox2Blue
            // 
            this.kryptonComboBox2Blue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.kryptonComboBox2Blue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.kryptonComboBox2Blue.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.kryptonComboBox2Blue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.kryptonComboBox2Blue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.kryptonComboBox2Blue.DropDownWidth = 121;
            this.kryptonComboBox2Blue.IntegralHeight = false;
            this.kryptonComboBox2Blue.Items.AddRange(new object[] {
            "one",
            "two",
            "three",
            "four",
            "five",
            "six"});
            this.kryptonComboBox2Blue.Location = new System.Drawing.Point(16, 57);
            this.kryptonComboBox2Blue.Name = "kryptonComboBox2Blue";
            this.kryptonComboBox2Blue.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonComboBox2Blue.Size = new System.Drawing.Size(169, 21);
            this.kryptonComboBox2Blue.TabIndex = 1;
            this.kryptonComboBox2Blue.Text = "clear with button";
            this.kryptonComboBox2Blue.Enter += new System.EventHandler(this.kryptonComboBox1Blue_Enter);
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.buttonSpecAny1.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny1.UniqueName = "37524C52AC4E48FE37524C52AC4E48FE";
            this.buttonSpecAny1.Click += new System.EventHandler(this.buttonSpecAny1_Click);
            // 
            // kryptonComboBox1Blue
            // 
            this.kryptonComboBox1Blue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.kryptonComboBox1Blue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.kryptonComboBox1Blue.CueHint.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kryptonComboBox1Blue.CueHint.CueHintText = "Cue Hint Text";
            this.kryptonComboBox1Blue.CueHint.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonComboBox1Blue.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonComboBox1Blue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.kryptonComboBox1Blue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.kryptonComboBox1Blue.DropDownWidth = 169;
            this.kryptonComboBox1Blue.IntegralHeight = false;
            this.kryptonComboBox1Blue.Items.AddRange(new object[] {
            "one",
            "two",
            "three",
            "four",
            "five",
            "six"});
            this.kryptonComboBox1Blue.Location = new System.Drawing.Point(16, 27);
            this.kryptonComboBox1Blue.Name = "kryptonComboBox1Blue";
            this.kryptonComboBox1Blue.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonComboBox1Blue.Size = new System.Drawing.Size(169, 21);
            this.kryptonComboBox1Blue.TabIndex = 0;
            this.kryptonComboBox1Blue.Enter += new System.EventHandler(this.kryptonComboBox1Blue_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kryptonComboBox6System);
            this.groupBox1.Controls.Add(this.kryptonComboBox5System);
            this.groupBox1.Controls.Add(this.kryptonComboBox4System);
            this.groupBox1.Location = new System.Drawing.Point(12, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 126);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Professional - System";
            // 
            // kryptonComboBox6System
            // 
            this.kryptonComboBox6System.AlwaysActive = false;
            this.kryptonComboBox6System.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.kryptonComboBox6System.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.kryptonComboBox6System.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.kryptonComboBox6System.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.kryptonComboBox6System.DropDownWidth = 121;
            this.kryptonComboBox6System.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.kryptonComboBox6System.IntegralHeight = false;
            this.kryptonComboBox6System.Items.AddRange(new object[] {
            "one",
            "two",
            "three",
            "four",
            "five",
            "six"});
            this.kryptonComboBox6System.Location = new System.Drawing.Point(16, 86);
            this.kryptonComboBox6System.Name = "kryptonComboBox6System";
            this.kryptonComboBox6System.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonComboBox6System.Size = new System.Drawing.Size(169, 18);
            this.kryptonComboBox6System.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonComboBox6System.TabIndex = 2;
            this.kryptonComboBox6System.Text = "ribbon style";
            this.kryptonComboBox6System.Enter += new System.EventHandler(this.kryptonComboBox1Blue_Enter);
            // 
            // kryptonComboBox5System
            // 
            this.kryptonComboBox5System.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.kryptonComboBox5System.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.kryptonComboBox5System.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny2});
            this.kryptonComboBox5System.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.kryptonComboBox5System.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.kryptonComboBox5System.DropDownWidth = 121;
            this.kryptonComboBox5System.IntegralHeight = false;
            this.kryptonComboBox5System.Items.AddRange(new object[] {
            "one",
            "two",
            "three",
            "four",
            "five",
            "six"});
            this.kryptonComboBox5System.Location = new System.Drawing.Point(16, 57);
            this.kryptonComboBox5System.Name = "kryptonComboBox5System";
            this.kryptonComboBox5System.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonComboBox5System.Size = new System.Drawing.Size(169, 19);
            this.kryptonComboBox5System.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonComboBox5System.TabIndex = 0;
            this.kryptonComboBox5System.Text = "clear with button";
            this.kryptonComboBox5System.Enter += new System.EventHandler(this.kryptonComboBox1Blue_Enter);
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.buttonSpecAny2.Style = Krypton.Toolkit.PaletteButtonStyle.ButtonSpec;
            this.buttonSpecAny2.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny2.UniqueName = "37524C52AC4E48FE37524C52AC4E48FE";
            this.buttonSpecAny2.Click += new System.EventHandler(this.buttonSpecAny2_Click);
            // 
            // kryptonComboBox4System
            // 
            this.kryptonComboBox4System.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.kryptonComboBox4System.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.kryptonComboBox4System.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.kryptonComboBox4System.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.kryptonComboBox4System.DropDownWidth = 169;
            this.kryptonComboBox4System.IntegralHeight = false;
            this.kryptonComboBox4System.Items.AddRange(new object[] {
            "one",
            "two",
            "three",
            "four",
            "five",
            "six"});
            this.kryptonComboBox4System.Location = new System.Drawing.Point(16, 30);
            this.kryptonComboBox4System.Name = "kryptonComboBox4System";
            this.kryptonComboBox4System.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonComboBox4System.Size = new System.Drawing.Size(169, 18);
            this.kryptonComboBox4System.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonComboBox4System.TabIndex = 0;
            this.kryptonComboBox4System.Text = "normal";
            this.kryptonComboBox4System.Enter += new System.EventHandler(this.kryptonComboBox1Blue_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.kryptonComboBox8Custom);
            this.groupBox3.Controls.Add(this.kryptonComboBox7Custom);
            this.groupBox3.Location = new System.Drawing.Point(12, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 126);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Custom Settings";
            // 
            // kryptonComboBox8Custom
            // 
            this.kryptonComboBox8Custom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.kryptonComboBox8Custom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.kryptonComboBox8Custom.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny3,
            this.buttonSpecAny4});
            this.kryptonComboBox8Custom.CueHint.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kryptonComboBox8Custom.CueHint.CueHintText = "Cue Hint Text";
            this.kryptonComboBox8Custom.CueHint.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonComboBox8Custom.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonComboBox8Custom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.kryptonComboBox8Custom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kryptonComboBox8Custom.DropDownWidth = 169;
            this.kryptonComboBox8Custom.IntegralHeight = false;
            this.kryptonComboBox8Custom.Items.AddRange(new object[] {
            "one",
            "two",
            "three",
            "four",
            "five",
            "six"});
            this.kryptonComboBox8Custom.Location = new System.Drawing.Point(16, 69);
            this.kryptonComboBox8Custom.Name = "kryptonComboBox8Custom";
            this.kryptonComboBox8Custom.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonComboBox8Custom.Size = new System.Drawing.Size(169, 23);
            this.kryptonComboBox8Custom.StateCommon.ComboBox.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonComboBox8Custom.StateCommon.ComboBox.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonComboBox8Custom.StateCommon.ComboBox.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonComboBox8Custom.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonComboBox8Custom.StateCommon.ComboBox.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonComboBox8Custom.StateCommon.ComboBox.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonComboBox8Custom.StateCommon.ComboBox.Border.Rounding = 2F;
            this.kryptonComboBox8Custom.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonComboBox8Custom.TabIndex = 0;
            this.kryptonComboBox8Custom.Enter += new System.EventHandler(this.kryptonComboBox1Blue_Enter);
            // 
            // buttonSpecAny3
            // 
            this.buttonSpecAny3.Style = Krypton.Toolkit.PaletteButtonStyle.Standalone;
            this.buttonSpecAny3.Type = Krypton.Toolkit.PaletteButtonSpecStyle.ArrowLeft;
            this.buttonSpecAny3.UniqueName = "43801810E6F9413243801810E6F94132";
            this.buttonSpecAny3.Click += new System.EventHandler(this.buttonSpecAny3_Click);
            // 
            // buttonSpecAny4
            // 
            this.buttonSpecAny4.Style = Krypton.Toolkit.PaletteButtonStyle.Standalone;
            this.buttonSpecAny4.Type = Krypton.Toolkit.PaletteButtonSpecStyle.ArrowRight;
            this.buttonSpecAny4.UniqueName = "0CDF070A67D6473D0CDF070A67D6473D";
            this.buttonSpecAny4.Click += new System.EventHandler(this.buttonSpecAny4_Click);
            // 
            // kryptonComboBox7Custom
            // 
            this.kryptonComboBox7Custom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.kryptonComboBox7Custom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.kryptonComboBox7Custom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.kryptonComboBox7Custom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.kryptonComboBox7Custom.DropDownWidth = 169;
            this.kryptonComboBox7Custom.IntegralHeight = false;
            this.kryptonComboBox7Custom.Items.AddRange(new object[] {
            "one",
            "two",
            "three",
            "four",
            "five",
            "six"});
            this.kryptonComboBox7Custom.Location = new System.Drawing.Point(16, 30);
            this.kryptonComboBox7Custom.Name = "kryptonComboBox7Custom";
            this.kryptonComboBox7Custom.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Black;
            this.kryptonComboBox7Custom.Size = new System.Drawing.Size(169, 23);
            this.kryptonComboBox7Custom.StateCommon.ComboBox.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonComboBox7Custom.StateCommon.ComboBox.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonComboBox7Custom.StateCommon.ComboBox.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonComboBox7Custom.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonComboBox7Custom.StateCommon.ComboBox.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonComboBox7Custom.StateCommon.ComboBox.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonComboBox7Custom.StateCommon.ComboBox.Border.Rounding = 2F;
            this.kryptonComboBox7Custom.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonComboBox7Custom.TabIndex = 0;
            this.kryptonComboBox7Custom.Text = "centered";
            this.kryptonComboBox7Custom.Enter += new System.EventHandler(this.kryptonComboBox1Blue_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 440);
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
            this.Text = "KryptonComboBox Examples";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox3Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox2Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1Blue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox6System)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox5System)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox4System)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox8Custom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox7Custom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox1Blue;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox3Blue;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox2Blue;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox6System;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox5System;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox4System;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox7Custom;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox8Custom;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny3;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny4;
    }
}

