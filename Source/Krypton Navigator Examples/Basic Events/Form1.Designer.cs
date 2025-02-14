namespace BasicEvents
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.kryptonNavigator1 = new Krypton.Navigator.KryptonNavigator();
            this.kryptonPage1 = new Krypton.Navigator.KryptonPage();
            this.kryptonPage2 = new Krypton.Navigator.KryptonPage();
            this.groupBoxPages = new System.Windows.Forms.GroupBox();
            this.kryptonButtonEnable = new Krypton.Toolkit.KryptonButton();
            this.kryptonButtonClear = new Krypton.Toolkit.KryptonButton();
            this.kryptonButtonRemove = new Krypton.Toolkit.KryptonButton();
            this.kryptonButtonAdd = new Krypton.Toolkit.KryptonButton();
            this.groupBoxProperties = new System.Windows.Forms.GroupBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonClearEventList = new System.Windows.Forms.Button();
            this.kryptonManager1 = new Krypton.Toolkit.KryptonManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).BeginInit();
            this.kryptonNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).BeginInit();
            this.groupBoxPages.SuspendLayout();
            this.groupBoxProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "alarmclock.png");
            this.imageList1.Images.SetKeyName(1, "apple.png");
            this.imageList1.Images.SetKeyName(2, "banana.png");
            this.imageList1.Images.SetKeyName(3, "basketball.png");
            this.imageList1.Images.SetKeyName(4, "cloud_sun.png");
            this.imageList1.Images.SetKeyName(5, "die_blue.png");
            this.imageList1.Images.SetKeyName(6, "doctor.png");
            this.imageList1.Images.SetKeyName(7, "flower_blue.png");
            this.imageList1.Images.SetKeyName(8, "gear.png");
            this.imageList1.Images.SetKeyName(9, "house.png");
            // 
            // kryptonNavigator1
            // 
            this.kryptonNavigator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.kryptonNavigator1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.kryptonNavigator1.Button.ButtonDisplayLogic = Krypton.Navigator.ButtonDisplayLogic.ContextNextPrevious;
            this.kryptonNavigator1.Button.CloseButtonAction = Krypton.Navigator.CloseButtonAction.RemovePageAndDispose;
            this.kryptonNavigator1.Button.CloseButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic;
            this.kryptonNavigator1.Button.ContextButtonAction = Krypton.Navigator.ContextButtonAction.SelectPage;
            this.kryptonNavigator1.Button.ContextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic;
            this.kryptonNavigator1.Button.ContextMenuMapImage = Krypton.Navigator.MapKryptonPageImage.Small;
            this.kryptonNavigator1.Button.ContextMenuMapText = Krypton.Navigator.MapKryptonPageText.TextTitle;
            this.kryptonNavigator1.Button.NextButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction;
            this.kryptonNavigator1.Button.NextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic;
            this.kryptonNavigator1.Button.PreviousButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction;
            this.kryptonNavigator1.Button.PreviousButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic;
            this.kryptonNavigator1.Group.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient;
            this.kryptonNavigator1.Group.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.ControlClient;
            this.kryptonNavigator1.Header.HeaderPositionBar = Krypton.Toolkit.VisualOrientation.Top;
            this.kryptonNavigator1.Header.HeaderPositionPrimary = Krypton.Toolkit.VisualOrientation.Top;
            this.kryptonNavigator1.Header.HeaderPositionSecondary = Krypton.Toolkit.VisualOrientation.Bottom;
            this.kryptonNavigator1.Header.HeaderStyleBar = Krypton.Toolkit.HeaderStyle.Secondary;
            this.kryptonNavigator1.Header.HeaderStylePrimary = Krypton.Toolkit.HeaderStyle.Primary;
            this.kryptonNavigator1.Header.HeaderStyleSecondary = Krypton.Toolkit.HeaderStyle.Secondary;
            this.kryptonNavigator1.Location = new System.Drawing.Point(18, 31);
            this.kryptonNavigator1.Name = "kryptonNavigator1";
            this.kryptonNavigator1.NavigatorMode = Krypton.Navigator.NavigatorMode.BarTabGroup;
            this.kryptonNavigator1.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient;
            this.kryptonNavigator1.Pages.AddRange(new Krypton.Navigator.KryptonPage[] {
            this.kryptonPage1,
            this.kryptonPage2});
            this.kryptonNavigator1.Panel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.kryptonNavigator1.SelectedIndex = 0;
            this.kryptonNavigator1.Size = new System.Drawing.Size(297, 355);
            this.kryptonNavigator1.StateCommon.CheckButton.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonNavigator1.StateCommon.CheckButton.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonNavigator1.StateCommon.CheckButton.Content.Image.Effect = Krypton.Toolkit.PaletteImageEffect.Inherit;
            this.kryptonNavigator1.StateCommon.CheckButton.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonNavigator1.StateCommon.CheckButton.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonNavigator1.StateCommon.CheckButton.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.kryptonNavigator1.TabIndex = 0;
            this.kryptonNavigator1.Text = "kryptonNavigator1";
            this.kryptonNavigator1.SelectedPageChanged += new System.EventHandler(this.kryptonNavigator1_SelectedPageChanged);
            this.kryptonNavigator1.Selecting += new System.EventHandler<Krypton.Navigator.KryptonPageCancelEventArgs>(this.kryptonNavigator1_Selecting);
            this.kryptonNavigator1.Selected += new System.EventHandler<Krypton.Navigator.KryptonPageEventArgs>(this.kryptonNavigator1_Selected);
            this.kryptonNavigator1.Deselecting += new System.EventHandler<Krypton.Navigator.KryptonPageCancelEventArgs>(this.kryptonNavigator1_Deselecting);
            this.kryptonNavigator1.Deselected += new System.EventHandler<Krypton.Navigator.KryptonPageEventArgs>(this.kryptonNavigator1_Deselected);
            this.kryptonNavigator1.PreviousAction += new System.EventHandler<Krypton.Navigator.DirectionActionEventArgs>(this.kryptonNavigator1_PreviousAction);
            this.kryptonNavigator1.NextAction += new System.EventHandler<Krypton.Navigator.DirectionActionEventArgs>(this.kryptonNavigator1_NextAction);
            this.kryptonNavigator1.ContextAction += new System.EventHandler<Krypton.Navigator.ContextActionEventArgs>(this.kryptonNavigator1_ContextAction);
            this.kryptonNavigator1.CloseAction += new System.EventHandler<Krypton.Navigator.CloseActionEventArgs>(this.kryptonNavigator1_CloseAction);
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.ImageLarge = ((System.Drawing.Bitmap)(resources.GetObject("kryptonPage1.ImageLarge")));
            this.kryptonPage1.ImageMedium = ((System.Drawing.Bitmap)(resources.GetObject("kryptonPage1.ImageMedium")));
            this.kryptonPage1.ImageSmall = ((System.Drawing.Bitmap)(resources.GetObject("kryptonPage1.ImageSmall")));
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(295, 328);
            this.kryptonPage1.Text = "Page 1";
            this.kryptonPage1.TextDescription = "Page 1 Description";
            this.kryptonPage1.TextTitle = "Page 1 Title";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "BA1D4D82F8F54F79BA1D4D82F8F54F79";
            // 
            // kryptonPage2
            // 
            this.kryptonPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage2.Flags = 65534;
            this.kryptonPage2.ImageLarge = ((System.Drawing.Bitmap)(resources.GetObject("kryptonPage2.ImageLarge")));
            this.kryptonPage2.ImageMedium = ((System.Drawing.Bitmap)(resources.GetObject("kryptonPage2.ImageMedium")));
            this.kryptonPage2.ImageSmall = ((System.Drawing.Bitmap)(resources.GetObject("kryptonPage2.ImageSmall")));
            this.kryptonPage2.LastVisibleSet = true;
            this.kryptonPage2.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage2.Name = "kryptonPage2";
            this.kryptonPage2.Size = new System.Drawing.Size(295, 329);
            this.kryptonPage2.Text = "Page 2";
            this.kryptonPage2.TextDescription = "Page 2 Description";
            this.kryptonPage2.TextTitle = "Page 2 Title";
            this.kryptonPage2.ToolTipTitle = "Page ToolTip";
            this.kryptonPage2.UniqueName = "1FDD9B3FB1A6438C1FDD9B3FB1A6438C";
            // 
            // groupBoxPages
            // 
            this.groupBoxPages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxPages.Controls.Add(this.kryptonButtonEnable);
            this.groupBoxPages.Controls.Add(this.kryptonButtonClear);
            this.groupBoxPages.Controls.Add(this.kryptonButtonRemove);
            this.groupBoxPages.Controls.Add(this.kryptonButtonAdd);
            this.groupBoxPages.Location = new System.Drawing.Point(13, 407);
            this.groupBoxPages.Name = "groupBoxPages";
            this.groupBoxPages.Size = new System.Drawing.Size(309, 69);
            this.groupBoxPages.TabIndex = 1;
            this.groupBoxPages.TabStop = false;
            this.groupBoxPages.Text = "Pages";
            // 
            // kryptonButtonEnable
            // 
            this.kryptonButtonEnable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.kryptonButtonEnable.DialogResult = System.Windows.Forms.DialogResult.None;
            this.kryptonButtonEnable.Location = new System.Drawing.Point(234, 26);
            this.kryptonButtonEnable.Name = "kryptonButtonEnable";
            this.kryptonButtonEnable.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.kryptonButtonEnable.Size = new System.Drawing.Size(65, 29);
            this.kryptonButtonEnable.TabIndex = 4;
            this.kryptonButtonEnable.Values.Text = "Enable";
            this.kryptonButtonEnable.Click += new System.EventHandler(this.kryptonButtonEnable_Click);
            // 
            // kryptonButtonClear
            // 
            this.kryptonButtonClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.kryptonButtonClear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.kryptonButtonClear.Location = new System.Drawing.Point(159, 26);
            this.kryptonButtonClear.Name = "kryptonButtonClear";
            this.kryptonButtonClear.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.kryptonButtonClear.Size = new System.Drawing.Size(65, 29);
            this.kryptonButtonClear.TabIndex = 2;
            this.kryptonButtonClear.Values.Text = "Clear";
            this.kryptonButtonClear.Click += new System.EventHandler(this.kryptonButtonClear_Click);
            // 
            // kryptonButtonRemove
            // 
            this.kryptonButtonRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.kryptonButtonRemove.DialogResult = System.Windows.Forms.DialogResult.None;
            this.kryptonButtonRemove.Location = new System.Drawing.Point(84, 26);
            this.kryptonButtonRemove.Name = "kryptonButtonRemove";
            this.kryptonButtonRemove.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.kryptonButtonRemove.Size = new System.Drawing.Size(65, 29);
            this.kryptonButtonRemove.TabIndex = 1;
            this.kryptonButtonRemove.Values.Text = "Remove";
            this.kryptonButtonRemove.Click += new System.EventHandler(this.kryptonButtonRemove_Click);
            // 
            // kryptonButtonAdd
            // 
            this.kryptonButtonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.kryptonButtonAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.kryptonButtonAdd.Location = new System.Drawing.Point(9, 26);
            this.kryptonButtonAdd.Name = "kryptonButtonAdd";
            this.kryptonButtonAdd.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.kryptonButtonAdd.Size = new System.Drawing.Size(65, 29);
            this.kryptonButtonAdd.TabIndex = 0;
            this.kryptonButtonAdd.Values.Text = "Add";
            this.kryptonButtonAdd.Click += new System.EventHandler(this.kryptonButtonAdd_Click);
            // 
            // groupBoxProperties
            // 
            this.groupBoxProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxProperties.Controls.Add(this.listBoxEvents);
            this.groupBoxProperties.Location = new System.Drawing.Point(328, 12);
            this.groupBoxProperties.Name = "groupBoxProperties";
            this.groupBoxProperties.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxProperties.Size = new System.Drawing.Size(325, 464);
            this.groupBoxProperties.TabIndex = 2;
            this.groupBoxProperties.TabStop = false;
            this.groupBoxProperties.Text = "Properties for KryptonNavigator";
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxEvents.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 15;
            this.listBoxEvents.Location = new System.Drawing.Point(5, 19);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(315, 440);
            this.listBoxEvents.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(578, 485);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonClearEventList
            // 
            this.buttonClearEventList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearEventList.Location = new System.Drawing.Point(468, 485);
            this.buttonClearEventList.Name = "buttonClearEventList";
            this.buttonClearEventList.Size = new System.Drawing.Size(104, 23);
            this.buttonClearEventList.TabIndex = 3;
            this.buttonClearEventList.Text = "Clear Event List";
            this.buttonClearEventList.UseVisualStyleBackColor = true;
            this.buttonClearEventList.Click += new System.EventHandler(this.buttonClearEventList_Click);
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteModeManager.Office2010Blue;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 516);
            this.Controls.Add(this.buttonClearEventList);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxProperties);
            this.Controls.Add(this.groupBoxPages);
            this.Controls.Add(this.kryptonNavigator1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(530, 326);
            this.Name = "Form1";
            this.Text = "Basic Events";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).EndInit();
            this.kryptonNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).EndInit();
            this.groupBoxPages.ResumeLayout(false);
            this.groupBoxProperties.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private Krypton.Navigator.KryptonNavigator kryptonNavigator1;
        private System.Windows.Forms.GroupBox groupBoxPages;
        private Krypton.Toolkit.KryptonButton kryptonButtonClear;
        private Krypton.Toolkit.KryptonButton kryptonButtonRemove;
        private Krypton.Toolkit.KryptonButton kryptonButtonAdd;
        private System.Windows.Forms.GroupBox groupBoxProperties;
        private System.Windows.Forms.Button buttonClose;
        private Krypton.Navigator.KryptonPage kryptonPage1;
        private Krypton.Navigator.KryptonPage kryptonPage2;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Button buttonClearEventList;
        private Krypton.Toolkit.KryptonButton kryptonButtonEnable;
        private Krypton.Toolkit.KryptonManager kryptonManager1;
    }
}

