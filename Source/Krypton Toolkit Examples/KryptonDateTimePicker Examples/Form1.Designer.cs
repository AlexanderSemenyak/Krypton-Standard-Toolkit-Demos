﻿namespace KryptonDateTimePickerExamples
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
            this.groupBoxPalette = new System.Windows.Forms.GroupBox();
            this.rbOffice2010Black = new System.Windows.Forms.RadioButton();
            this.rbOffice2010Silver = new System.Windows.Forms.RadioButton();
            this.rbOffice2010Blue = new System.Windows.Forms.RadioButton();
            this.rbSparklePurple = new System.Windows.Forms.RadioButton();
            this.rbSparkleOrange = new System.Windows.Forms.RadioButton();
            this.rbSparkleBlue = new System.Windows.Forms.RadioButton();
            this.rbSystem = new System.Windows.Forms.RadioButton();
            this.rbOffice2003 = new System.Windows.Forms.RadioButton();
            this.rbOffice2007Black = new System.Windows.Forms.RadioButton();
            this.rbOffice2007Silver = new System.Windows.Forms.RadioButton();
            this.rbOffice2007Blue = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.buttonClose = new System.Windows.Forms.Button();
            this.kryptonPalette = new Krypton.Toolkit.KryptonPalette();
            this.groupBoxRibbon = new System.Windows.Forms.GroupBox();
            this.dtpRibbonTime = new Krypton.Toolkit.KryptonDateTimePicker();
            this.buttonSpecAny2 = new Krypton.Toolkit.ButtonSpecAny();
            this.dtpRibbonShort = new Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpRibbonLong = new Krypton.Toolkit.KryptonDateTimePicker();
            this.groupBoxNormal = new System.Windows.Forms.GroupBox();
            this.dtpNormalTime = new Krypton.Toolkit.KryptonDateTimePicker();
            this.buttonSpecAny1 = new Krypton.Toolkit.ButtonSpecAny();
            this.dtpNormalShort = new Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpNormalLong = new Krypton.Toolkit.KryptonDateTimePicker();
            this.groupBoxPalette.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBoxRibbon.SuspendLayout();
            this.groupBoxNormal.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPalette
            // 
            this.groupBoxPalette.Controls.Add(this.rbOffice2010Black);
            this.groupBoxPalette.Controls.Add(this.rbOffice2010Silver);
            this.groupBoxPalette.Controls.Add(this.rbOffice2010Blue);
            this.groupBoxPalette.Controls.Add(this.rbSparklePurple);
            this.groupBoxPalette.Controls.Add(this.rbSparkleOrange);
            this.groupBoxPalette.Controls.Add(this.rbSparkleBlue);
            this.groupBoxPalette.Controls.Add(this.rbSystem);
            this.groupBoxPalette.Controls.Add(this.rbOffice2003);
            this.groupBoxPalette.Controls.Add(this.rbOffice2007Black);
            this.groupBoxPalette.Controls.Add(this.rbOffice2007Silver);
            this.groupBoxPalette.Controls.Add(this.rbOffice2007Blue);
            this.groupBoxPalette.Location = new System.Drawing.Point(12, 309);
            this.groupBoxPalette.Name = "groupBoxPalette";
            this.groupBoxPalette.Size = new System.Drawing.Size(382, 181);
            this.groupBoxPalette.TabIndex = 3;
            this.groupBoxPalette.TabStop = false;
            this.groupBoxPalette.Text = "Palette";
            // 
            // rbOffice2010Black
            // 
            this.rbOffice2010Black.AutoSize = true;
            this.rbOffice2010Black.Location = new System.Drawing.Point(24, 72);
            this.rbOffice2010Black.Name = "rbOffice2010Black";
            this.rbOffice2010Black.Size = new System.Drawing.Size(115, 17);
            this.rbOffice2010Black.TabIndex = 2;
            this.rbOffice2010Black.Text = "Office 2010 - Black";
            this.rbOffice2010Black.UseVisualStyleBackColor = true;
            this.rbOffice2010Black.CheckedChanged += new System.EventHandler(this.rbOffice2010Black_CheckedChanged);
            // 
            // rbOffice2010Silver
            // 
            this.rbOffice2010Silver.AutoSize = true;
            this.rbOffice2010Silver.Location = new System.Drawing.Point(24, 49);
            this.rbOffice2010Silver.Name = "rbOffice2010Silver";
            this.rbOffice2010Silver.Size = new System.Drawing.Size(117, 17);
            this.rbOffice2010Silver.TabIndex = 1;
            this.rbOffice2010Silver.Text = "Office 2010 - Silver";
            this.rbOffice2010Silver.UseVisualStyleBackColor = true;
            this.rbOffice2010Silver.CheckedChanged += new System.EventHandler(this.rbOffice2010Silver_CheckedChanged);
            // 
            // rbOffice2010Blue
            // 
            this.rbOffice2010Blue.AutoSize = true;
            this.rbOffice2010Blue.Checked = true;
            this.rbOffice2010Blue.Location = new System.Drawing.Point(24, 26);
            this.rbOffice2010Blue.Name = "rbOffice2010Blue";
            this.rbOffice2010Blue.Size = new System.Drawing.Size(111, 17);
            this.rbOffice2010Blue.TabIndex = 0;
            this.rbOffice2010Blue.TabStop = true;
            this.rbOffice2010Blue.Text = "Office 2010 - Blue";
            this.rbOffice2010Blue.UseVisualStyleBackColor = true;
            this.rbOffice2010Blue.CheckedChanged += new System.EventHandler(this.rbOffice2010Blue_CheckedChanged);
            // 
            // rbSparklePurple
            // 
            this.rbSparklePurple.AutoSize = true;
            this.rbSparklePurple.Location = new System.Drawing.Point(163, 72);
            this.rbSparklePurple.Name = "rbSparklePurple";
            this.rbSparklePurple.Size = new System.Drawing.Size(100, 17);
            this.rbSparklePurple.TabIndex = 8;
            this.rbSparklePurple.Text = "Sparkle - Purple";
            this.rbSparklePurple.UseVisualStyleBackColor = true;
            this.rbSparklePurple.CheckedChanged += new System.EventHandler(this.rbSparklePurple_CheckedChanged);
            // 
            // rbSparkleOrange
            // 
            this.rbSparkleOrange.AutoSize = true;
            this.rbSparkleOrange.Location = new System.Drawing.Point(163, 49);
            this.rbSparkleOrange.Name = "rbSparkleOrange";
            this.rbSparkleOrange.Size = new System.Drawing.Size(106, 17);
            this.rbSparkleOrange.TabIndex = 7;
            this.rbSparkleOrange.Text = "Sparkle - Orange";
            this.rbSparkleOrange.UseVisualStyleBackColor = true;
            this.rbSparkleOrange.CheckedChanged += new System.EventHandler(this.rbSparkleOrange_CheckedChanged);
            // 
            // rbSparkleBlue
            // 
            this.rbSparkleBlue.AutoSize = true;
            this.rbSparkleBlue.Location = new System.Drawing.Point(163, 26);
            this.rbSparkleBlue.Name = "rbSparkleBlue";
            this.rbSparkleBlue.Size = new System.Drawing.Size(90, 17);
            this.rbSparkleBlue.TabIndex = 6;
            this.rbSparkleBlue.Text = "Sparkle - Blue";
            this.rbSparkleBlue.UseVisualStyleBackColor = true;
            this.rbSparkleBlue.CheckedChanged += new System.EventHandler(this.rbSparkleBlue_CheckedChanged);
            // 
            // rbSystem
            // 
            this.rbSystem.AutoSize = true;
            this.rbSystem.Location = new System.Drawing.Point(163, 127);
            this.rbSystem.Name = "rbSystem";
            this.rbSystem.Size = new System.Drawing.Size(60, 17);
            this.rbSystem.TabIndex = 10;
            this.rbSystem.Text = "System";
            this.rbSystem.UseVisualStyleBackColor = true;
            this.rbSystem.CheckedChanged += new System.EventHandler(this.rbSystem_CheckedChanged);
            // 
            // rbOffice2003
            // 
            this.rbOffice2003.AutoSize = true;
            this.rbOffice2003.Location = new System.Drawing.Point(163, 104);
            this.rbOffice2003.Name = "rbOffice2003";
            this.rbOffice2003.Size = new System.Drawing.Size(81, 17);
            this.rbOffice2003.TabIndex = 9;
            this.rbOffice2003.Text = "Office 2003";
            this.rbOffice2003.UseVisualStyleBackColor = true;
            this.rbOffice2003.CheckedChanged += new System.EventHandler(this.rbOffice2003_CheckedChanged);
            // 
            // rbOffice2007Black
            // 
            this.rbOffice2007Black.AutoSize = true;
            this.rbOffice2007Black.Location = new System.Drawing.Point(24, 150);
            this.rbOffice2007Black.Name = "rbOffice2007Black";
            this.rbOffice2007Black.Size = new System.Drawing.Size(115, 17);
            this.rbOffice2007Black.TabIndex = 5;
            this.rbOffice2007Black.Text = "Office 2007 - Black";
            this.rbOffice2007Black.UseVisualStyleBackColor = true;
            this.rbOffice2007Black.CheckedChanged += new System.EventHandler(this.rbOffice2007Black_CheckedChanged);
            // 
            // rbOffice2007Silver
            // 
            this.rbOffice2007Silver.AutoSize = true;
            this.rbOffice2007Silver.Location = new System.Drawing.Point(24, 127);
            this.rbOffice2007Silver.Name = "rbOffice2007Silver";
            this.rbOffice2007Silver.Size = new System.Drawing.Size(117, 17);
            this.rbOffice2007Silver.TabIndex = 4;
            this.rbOffice2007Silver.Text = "Office 2007 - Silver";
            this.rbOffice2007Silver.UseVisualStyleBackColor = true;
            this.rbOffice2007Silver.CheckedChanged += new System.EventHandler(this.rbOffice2007Silver_CheckedChanged);
            // 
            // rbOffice2007Blue
            // 
            this.rbOffice2007Blue.AutoSize = true;
            this.rbOffice2007Blue.Location = new System.Drawing.Point(24, 104);
            this.rbOffice2007Blue.Name = "rbOffice2007Blue";
            this.rbOffice2007Blue.Size = new System.Drawing.Size(111, 17);
            this.rbOffice2007Blue.TabIndex = 3;
            this.rbOffice2007Blue.Text = "Office 2007 - Blue";
            this.rbOffice2007Blue.UseVisualStyleBackColor = true;
            this.rbOffice2007Blue.CheckedChanged += new System.EventHandler(this.rbOffice2007Blue_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.propertyGrid);
            this.groupBox4.Location = new System.Drawing.Point(400, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(319, 478);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Properties for KryptonDateTimePicker";
            // 
            // propertyGrid
            // 
            this.propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid.Location = new System.Drawing.Point(6, 19);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(307, 453);
            this.propertyGrid.TabIndex = 0;
            this.propertyGrid.ToolbarVisible = false;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(644, 500);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // kryptonPalette
            // 
            this.kryptonPalette.BaseRenderMode = Krypton.Toolkit.RendererMode.Inherit;
            // 
            // groupBoxRibbon
            // 
            this.groupBoxRibbon.Controls.Add(this.dtpRibbonTime);
            this.groupBoxRibbon.Controls.Add(this.dtpRibbonShort);
            this.groupBoxRibbon.Controls.Add(this.dtpRibbonLong);
            this.groupBoxRibbon.Location = new System.Drawing.Point(12, 162);
            this.groupBoxRibbon.Name = "groupBoxRibbon";
            this.groupBoxRibbon.Size = new System.Drawing.Size(382, 140);
            this.groupBoxRibbon.TabIndex = 1;
            this.groupBoxRibbon.TabStop = false;
            this.groupBoxRibbon.Text = "Ribbon Style";
            // 
            // dtpRibbonTime
            // 
            this.dtpRibbonTime.AlwaysActive = false;
            this.dtpRibbonTime.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny2});
            this.dtpRibbonTime.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtpRibbonTime.CalendarFirstDayOfWeek = System.Windows.Forms.Day.Default;
            this.dtpRibbonTime.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.dtpRibbonTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpRibbonTime.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.dtpRibbonTime.Location = new System.Drawing.Point(24, 92);
            this.dtpRibbonTime.Name = "dtpRibbonTime";
            this.dtpRibbonTime.Palette = this.kryptonPalette;
            this.dtpRibbonTime.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dtpRibbonTime.ShowUpDown = true;
            this.dtpRibbonTime.Size = new System.Drawing.Size(204, 21);
            this.dtpRibbonTime.TabIndex = 2;
            this.dtpRibbonTime.Enter += new System.EventHandler(this.dtp_Enter);
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.Style = Krypton.Toolkit.PaletteButtonStyle.Standalone;
            this.buttonSpecAny2.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny2.UniqueName = "711F5E5D57D243B7711F5E5D57D243B7";
            this.buttonSpecAny2.Click += new System.EventHandler(this.buttonSpecAny2_Click);
            // 
            // dtpRibbonShort
            // 
            this.dtpRibbonShort.AlwaysActive = false;
            this.dtpRibbonShort.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtpRibbonShort.CalendarFirstDayOfWeek = System.Windows.Forms.Day.Default;
            this.dtpRibbonShort.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.dtpRibbonShort.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRibbonShort.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.dtpRibbonShort.Location = new System.Drawing.Point(24, 63);
            this.dtpRibbonShort.Name = "dtpRibbonShort";
            this.dtpRibbonShort.Palette = this.kryptonPalette;
            this.dtpRibbonShort.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dtpRibbonShort.Size = new System.Drawing.Size(204, 21);
            this.dtpRibbonShort.TabIndex = 1;
            this.dtpRibbonShort.Enter += new System.EventHandler(this.dtp_Enter);
            // 
            // dtpRibbonLong
            // 
            this.dtpRibbonLong.AlwaysActive = false;
            this.dtpRibbonLong.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtpRibbonLong.CalendarFirstDayOfWeek = System.Windows.Forms.Day.Default;
            this.dtpRibbonLong.CustomNullText = "<Custom Text When Null>";
            this.dtpRibbonLong.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.dtpRibbonLong.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpRibbonLong.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.dtpRibbonLong.Location = new System.Drawing.Point(24, 34);
            this.dtpRibbonLong.Name = "dtpRibbonLong";
            this.dtpRibbonLong.Palette = this.kryptonPalette;
            this.dtpRibbonLong.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dtpRibbonLong.ShowCheckBox = true;
            this.dtpRibbonLong.Size = new System.Drawing.Size(204, 21);
            this.dtpRibbonLong.TabIndex = 0;
            this.dtpRibbonLong.Enter += new System.EventHandler(this.dtp_Enter);
            // 
            // groupBoxNormal
            // 
            this.groupBoxNormal.Controls.Add(this.dtpNormalTime);
            this.groupBoxNormal.Controls.Add(this.dtpNormalShort);
            this.groupBoxNormal.Controls.Add(this.dtpNormalLong);
            this.groupBoxNormal.Location = new System.Drawing.Point(12, 12);
            this.groupBoxNormal.Name = "groupBoxNormal";
            this.groupBoxNormal.Size = new System.Drawing.Size(382, 140);
            this.groupBoxNormal.TabIndex = 0;
            this.groupBoxNormal.TabStop = false;
            this.groupBoxNormal.Text = "Normal Style";
            // 
            // dtpNormalTime
            // 
            this.dtpNormalTime.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.dtpNormalTime.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtpNormalTime.CalendarFirstDayOfWeek = System.Windows.Forms.Day.Default;
            this.dtpNormalTime.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.dtpNormalTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpNormalTime.Location = new System.Drawing.Point(24, 93);
            this.dtpNormalTime.Name = "dtpNormalTime";
            this.dtpNormalTime.Palette = this.kryptonPalette;
            this.dtpNormalTime.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dtpNormalTime.ShowUpDown = true;
            this.dtpNormalTime.Size = new System.Drawing.Size(204, 21);
            this.dtpNormalTime.TabIndex = 2;
            this.dtpNormalTime.Enter += new System.EventHandler(this.dtp_Enter);
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Style = Krypton.Toolkit.PaletteButtonStyle.Standalone;
            this.buttonSpecAny1.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny1.UniqueName = "529C8C7BCFA94ED8529C8C7BCFA94ED8";
            this.buttonSpecAny1.Click += new System.EventHandler(this.buttonSpecAny1_Click);
            // 
            // dtpNormalShort
            // 
            this.dtpNormalShort.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtpNormalShort.CalendarFirstDayOfWeek = System.Windows.Forms.Day.Default;
            this.dtpNormalShort.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.dtpNormalShort.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNormalShort.Location = new System.Drawing.Point(24, 64);
            this.dtpNormalShort.Name = "dtpNormalShort";
            this.dtpNormalShort.Palette = this.kryptonPalette;
            this.dtpNormalShort.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dtpNormalShort.Size = new System.Drawing.Size(204, 21);
            this.dtpNormalShort.TabIndex = 1;
            this.dtpNormalShort.Enter += new System.EventHandler(this.dtp_Enter);
            // 
            // dtpNormalLong
            // 
            this.dtpNormalLong.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtpNormalLong.CalendarFirstDayOfWeek = System.Windows.Forms.Day.Default;
            this.dtpNormalLong.CustomNullText = "<Custom Text When Null>";
            this.dtpNormalLong.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.dtpNormalLong.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNormalLong.Location = new System.Drawing.Point(24, 35);
            this.dtpNormalLong.Name = "dtpNormalLong";
            this.dtpNormalLong.Palette = this.kryptonPalette;
            this.dtpNormalLong.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dtpNormalLong.ShowCheckBox = true;
            this.dtpNormalLong.Size = new System.Drawing.Size(204, 21);
            this.dtpNormalLong.TabIndex = 0;
            this.dtpNormalLong.Enter += new System.EventHandler(this.dtp_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 535);
            this.Controls.Add(this.groupBoxRibbon);
            this.Controls.Add(this.groupBoxNormal);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBoxPalette);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(745, 573);
            this.Name = "Form1";
            this.Text = "KryptonDateTimePicker Examples";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxPalette.ResumeLayout(false);
            this.groupBoxPalette.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBoxRibbon.ResumeLayout(false);
            this.groupBoxNormal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPalette;
        private System.Windows.Forms.RadioButton rbSparklePurple;
        private System.Windows.Forms.RadioButton rbSparkleOrange;
        private System.Windows.Forms.RadioButton rbSparkleBlue;
        private System.Windows.Forms.RadioButton rbSystem;
        private System.Windows.Forms.RadioButton rbOffice2003;
        private System.Windows.Forms.RadioButton rbOffice2007Black;
        private System.Windows.Forms.RadioButton rbOffice2007Silver;
        private System.Windows.Forms.RadioButton rbOffice2007Blue;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.Button buttonClose;
        private Krypton.Toolkit.KryptonPalette kryptonPalette;
        private System.Windows.Forms.GroupBox groupBoxRibbon;
        private System.Windows.Forms.GroupBox groupBoxNormal;
        private Krypton.Toolkit.KryptonDateTimePicker dtpRibbonTime;
        private Krypton.Toolkit.KryptonDateTimePicker dtpRibbonShort;
        private Krypton.Toolkit.KryptonDateTimePicker dtpRibbonLong;
        private Krypton.Toolkit.KryptonDateTimePicker dtpNormalTime;
        private Krypton.Toolkit.KryptonDateTimePicker dtpNormalShort;
        private Krypton.Toolkit.KryptonDateTimePicker dtpNormalLong;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private System.Windows.Forms.RadioButton rbOffice2010Black;
        private System.Windows.Forms.RadioButton rbOffice2010Silver;
        private System.Windows.Forms.RadioButton rbOffice2010Blue;
    }
}

