namespace KryptonListBoxExamples
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.kryptonListBox = new Krypton.Toolkit.KryptonListBox();
            this.buttonAppend = new Krypton.Toolkit.KryptonButton();
            this.buttonClear = new Krypton.Toolkit.KryptonButton();
            this.buttonRemove = new Krypton.Toolkit.KryptonButton();
            this.buttonInsert = new Krypton.Toolkit.KryptonButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkSystem = new Krypton.Toolkit.KryptonCheckButton();
            this.checkSparkle = new Krypton.Toolkit.KryptonCheckButton();
            this.check2010Blue = new Krypton.Toolkit.KryptonCheckButton();
            this.check2007Blue = new Krypton.Toolkit.KryptonCheckButton();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.kryptonCheckSet = new Krypton.Toolkit.KryptonCheckSet(this.components);
            this.kryptonManager1 = new Krypton.Toolkit.KryptonManager(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonCheckSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(493, 408);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.propertyGrid);
            this.groupBox3.Location = new System.Drawing.Point(273, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(295, 390);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Properties for KryptonListBox";
            // 
            // propertyGrid
            // 
            this.propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid.Location = new System.Drawing.Point(6, 19);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(283, 365);
            this.propertyGrid.TabIndex = 0;
            this.propertyGrid.ToolbarVisible = false;
            // 
            // kryptonListBox
            // 
            this.kryptonListBox.Location = new System.Drawing.Point(23, 24);
            this.kryptonListBox.Name = "kryptonListBox";
            this.kryptonListBox.Padding = new System.Windows.Forms.Padding(1);
            this.kryptonListBox.SelectionMode = System.Windows.Forms.SelectionMode.One;
            this.kryptonListBox.Size = new System.Drawing.Size(227, 192);
            this.kryptonListBox.TabIndex = 0;
            this.kryptonListBox.SelectedIndexChanged += new System.EventHandler(this.kryptonListBox_SelectedIndexChanged);
            // 
            // buttonAppend
            // 
            this.buttonAppend.AutoSize = true;
            this.buttonAppend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.buttonAppend.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonAppend.Location = new System.Drawing.Point(19, 30);
            this.buttonAppend.Name = "buttonAppend";
            this.buttonAppend.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.buttonAppend.Size = new System.Drawing.Size(90, 25);
            this.buttonAppend.TabIndex = 0;
            this.buttonAppend.Values.Text = "Append";
            this.buttonAppend.Click += new System.EventHandler(this.buttonAppend_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.AutoSize = true;
            this.buttonClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.buttonClear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonClear.Location = new System.Drawing.Point(19, 126);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.buttonClear.Size = new System.Drawing.Size(90, 25);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Values.Text = "Clear";
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.AutoSize = true;
            this.buttonRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.buttonRemove.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonRemove.Location = new System.Drawing.Point(19, 94);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.buttonRemove.Size = new System.Drawing.Size(90, 25);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Values.Text = "Remove";
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.AutoSize = true;
            this.buttonInsert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.buttonInsert.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonInsert.Location = new System.Drawing.Point(19, 62);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.buttonInsert.Size = new System.Drawing.Size(90, 25);
            this.buttonInsert.TabIndex = 1;
            this.buttonInsert.Values.Text = "Insert";
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkSystem);
            this.groupBox1.Controls.Add(this.checkSparkle);
            this.groupBox1.Controls.Add(this.check2010Blue);
            this.groupBox1.Controls.Add(this.check2007Blue);
            this.groupBox1.Controls.Add(this.buttonAppend);
            this.groupBox1.Controls.Add(this.buttonInsert);
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.buttonRemove);
            this.groupBox1.Location = new System.Drawing.Point(12, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 168);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // checkSystem
            // 
            this.checkSystem.AutoSize = true;
            this.checkSystem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.checkSystem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.checkSystem.Location = new System.Drawing.Point(125, 126);
            this.checkSystem.Name = "checkSystem";
            this.checkSystem.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.checkSystem.Size = new System.Drawing.Size(113, 25);
            this.checkSystem.TabIndex = 7;
            this.checkSystem.Values.Text = "System";
            // 
            // checkSparkle
            // 
            this.checkSparkle.AutoSize = true;
            this.checkSparkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.checkSparkle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.checkSparkle.Location = new System.Drawing.Point(125, 93);
            this.checkSparkle.Name = "checkSparkle";
            this.checkSparkle.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.checkSparkle.Size = new System.Drawing.Size(113, 25);
            this.checkSparkle.TabIndex = 6;
            this.checkSparkle.Values.Text = "Sparkle - Blue";
            // 
            // check2010Blue
            // 
            this.check2010Blue.AutoSize = true;
            this.check2010Blue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.check2010Blue.Checked = true;
            this.check2010Blue.DialogResult = System.Windows.Forms.DialogResult.None;
            this.check2010Blue.Location = new System.Drawing.Point(125, 31);
            this.check2010Blue.Name = "check2010Blue";
            this.check2010Blue.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.check2010Blue.Size = new System.Drawing.Size(113, 25);
            this.check2010Blue.TabIndex = 5;
            this.check2010Blue.Values.Text = "Office 2010 - Black";
            // 
            // check2007Blue
            // 
            this.check2007Blue.AutoSize = true;
            this.check2007Blue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.check2007Blue.DialogResult = System.Windows.Forms.DialogResult.None;
            this.check2007Blue.Location = new System.Drawing.Point(125, 62);
            this.check2007Blue.Name = "check2007Blue";
            this.check2007Blue.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.check2007Blue.Size = new System.Drawing.Size(113, 25);
            this.check2007Blue.TabIndex = 4;
            this.check2007Blue.Values.Text = "Office 2007 - Blue";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "document_plain.png");
            this.imageList.Images.SetKeyName(1, "document_plain_blue.png");
            this.imageList.Images.SetKeyName(2, "document_plain_green.png");
            this.imageList.Images.SetKeyName(3, "document_plain_red.png");
            this.imageList.Images.SetKeyName(4, "document_plain_yellow.png");
            this.imageList.Images.SetKeyName(5, "star_blue.png");
            this.imageList.Images.SetKeyName(6, "star_green.png");
            this.imageList.Images.SetKeyName(7, "star_grey.png");
            this.imageList.Images.SetKeyName(8, "star_red.png");
            this.imageList.Images.SetKeyName(9, "star_yellow.png");
            this.imageList.Images.SetKeyName(10, "telephone.png");
            this.imageList.Images.SetKeyName(11, "telephone2.png");
            this.imageList.Images.SetKeyName(12, "thought.png");
            this.imageList.Images.SetKeyName(13, "alarmclock.png");
            this.imageList.Images.SetKeyName(14, "apple.png");
            this.imageList.Images.SetKeyName(15, "banana.png");
            this.imageList.Images.SetKeyName(16, "basketball.png");
            this.imageList.Images.SetKeyName(17, "binocular.png");
            this.imageList.Images.SetKeyName(18, "clock2.png");
            // 
            // kryptonCheckSet
            // 
            this.kryptonCheckSet.CheckButtons.Add(this.check2007Blue);
            this.kryptonCheckSet.CheckButtons.Add(this.check2010Blue);
            this.kryptonCheckSet.CheckButtons.Add(this.checkSparkle);
            this.kryptonCheckSet.CheckButtons.Add(this.checkSystem);
            this.kryptonCheckSet.CheckedButton = this.check2010Blue;
            this.kryptonCheckSet.CheckedButtonChanged += new System.EventHandler(this.kryptonCheckSet_CheckedButtonChanged);
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteModeManager.Office2010Blue;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 438);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kryptonListBox);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "KryptonListBox Examples";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonCheckSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private Krypton.Toolkit.KryptonListBox kryptonListBox;
        private Krypton.Toolkit.KryptonButton buttonAppend;
        private Krypton.Toolkit.KryptonButton buttonClear;
        private Krypton.Toolkit.KryptonButton buttonRemove;
        private Krypton.Toolkit.KryptonButton buttonInsert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList imageList;
        private Krypton.Toolkit.KryptonCheckButton checkSystem;
        private Krypton.Toolkit.KryptonCheckButton checkSparkle;
        private Krypton.Toolkit.KryptonCheckButton check2010Blue;
        private Krypton.Toolkit.KryptonCheckButton check2007Blue;
        private Krypton.Toolkit.KryptonCheckSet kryptonCheckSet;
        private Krypton.Toolkit.KryptonManager kryptonManager1;
    }
}

