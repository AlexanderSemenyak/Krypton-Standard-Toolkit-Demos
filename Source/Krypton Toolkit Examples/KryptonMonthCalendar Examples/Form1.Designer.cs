﻿namespace KryptonMonthCalendarExamples
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.kryptonMonthCalendar1 = new Krypton.Toolkit.KryptonMonthCalendar();
            this.kryptonPalette = new Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonManager1 = new Krypton.Toolkit.KryptonManager(this.components);
            this.groupBoxPalette.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.groupBoxPalette.Location = new System.Drawing.Point(12, 426);
            this.groupBoxPalette.Name = "groupBoxPalette";
            this.groupBoxPalette.Size = new System.Drawing.Size(517, 107);
            this.groupBoxPalette.TabIndex = 1;
            this.groupBoxPalette.TabStop = false;
            this.groupBoxPalette.Text = "Palette";
            // 
            // rbOffice2010Black
            // 
            this.rbOffice2010Black.AutoSize = true;
            this.rbOffice2010Black.Location = new System.Drawing.Point(16, 74);
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
            this.rbOffice2010Silver.Location = new System.Drawing.Point(16, 51);
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
            this.rbOffice2010Blue.Location = new System.Drawing.Point(16, 28);
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
            this.rbSparklePurple.Location = new System.Drawing.Point(295, 74);
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
            this.rbSparkleOrange.Location = new System.Drawing.Point(295, 51);
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
            this.rbSparkleBlue.Location = new System.Drawing.Point(295, 28);
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
            this.rbSystem.Location = new System.Drawing.Point(419, 51);
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
            this.rbOffice2003.Location = new System.Drawing.Point(419, 28);
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
            this.rbOffice2007Black.Location = new System.Drawing.Point(156, 74);
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
            this.rbOffice2007Silver.Location = new System.Drawing.Point(156, 51);
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
            this.rbOffice2007Blue.Location = new System.Drawing.Point(156, 28);
            this.rbOffice2007Blue.Name = "rbOffice2007Blue";
            this.rbOffice2007Blue.Size = new System.Drawing.Size(111, 17);
            this.rbOffice2007Blue.TabIndex = 3;
            this.rbOffice2007Blue.Text = "Office 2007 - Blue";
            this.rbOffice2007Blue.UseVisualStyleBackColor = true;
            this.rbOffice2007Blue.CheckedChanged += new System.EventHandler(this.rbOffice2007Blue_CheckedChanged);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(779, 541);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.propertyGrid);
            this.groupBox4.Location = new System.Drawing.Point(535, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(319, 521);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Properties for KryptonMonthCalendar";
            // 
            // propertyGrid
            // 
            this.propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid.Location = new System.Drawing.Point(6, 19);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.SelectedObject = this.kryptonMonthCalendar1;
            this.propertyGrid.Size = new System.Drawing.Size(307, 496);
            this.propertyGrid.TabIndex = 0;
            this.propertyGrid.ToolbarVisible = false;
            // 
            // kryptonMonthCalendar1
            // 
            this.kryptonMonthCalendar1.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.kryptonMonthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Default;
            this.kryptonMonthCalendar1.Location = new System.Drawing.Point(15, 18);
            this.kryptonMonthCalendar1.Name = "kryptonMonthCalendar1";
            this.kryptonMonthCalendar1.Palette = this.kryptonPalette;
            this.kryptonMonthCalendar1.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonMonthCalendar1.Size = new System.Drawing.Size(230, 338);
            this.kryptonMonthCalendar1.TabIndex = 0;
            // 
            // kryptonPalette
            // 
            this.kryptonPalette.BasePaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonPalette.BaseRenderMode = Krypton.Toolkit.RendererMode.Inherit;
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPalette = this.kryptonPalette;
            this.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteModeManager.Custom;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 574);
            this.Controls.Add(this.kryptonMonthCalendar1);
            this.Controls.Add(this.groupBoxPalette);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(882, 610);
            this.Name = "Form1";
            this.Text = "KryptonMonthCalendar Examples";
            this.groupBoxPalette.ResumeLayout(false);
            this.groupBoxPalette.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPalette;
        private System.Windows.Forms.RadioButton rbSparkleBlue;
        private System.Windows.Forms.RadioButton rbSystem;
        private System.Windows.Forms.RadioButton rbOffice2003;
        private System.Windows.Forms.RadioButton rbOffice2007Black;
        private System.Windows.Forms.RadioButton rbOffice2007Silver;
        private System.Windows.Forms.RadioButton rbOffice2007Blue;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.RadioButton rbSparklePurple;
        private System.Windows.Forms.RadioButton rbSparkleOrange;
        private Krypton.Toolkit.KryptonMonthCalendar kryptonMonthCalendar1;
        private Krypton.Toolkit.KryptonPalette kryptonPalette;
        private System.Windows.Forms.RadioButton rbOffice2010Black;
        private System.Windows.Forms.RadioButton rbOffice2010Silver;
        private System.Windows.Forms.RadioButton rbOffice2010Blue;
        private Krypton.Toolkit.KryptonManager kryptonManager1;
    }
}

