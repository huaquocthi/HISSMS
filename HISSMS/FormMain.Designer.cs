namespace HISSMS
{
    partial class FormHISSMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHISSMS));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.appMenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.btnDSBN = new DevExpress.XtraBars.BarButtonItem();
            this.iExit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.btnThamSo = new DevExpress.XtraBars.BarButtonItem();
            this.siStatus = new DevExpress.XtraBars.BarStaticItem();
            this.alignButtonGroup = new DevExpress.XtraBars.BarButtonGroup();
            this.iBoldFontStyle = new DevExpress.XtraBars.BarButtonItem();
            this.iItalicFontStyle = new DevExpress.XtraBars.BarButtonItem();
            this.iUnderlinedFontStyle = new DevExpress.XtraBars.BarButtonItem();
            this.fontStyleButtonGroup = new DevExpress.XtraBars.BarButtonGroup();
            this.iLeftTextAlign = new DevExpress.XtraBars.BarButtonItem();
            this.iCenterTextAlign = new DevExpress.XtraBars.BarButtonItem();
            this.iRightTextAlign = new DevExpress.XtraBars.BarButtonItem();
            this.rgbiSkins = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.barButtonItemMau20 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonImageCollectionLarge = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupBHYT = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.homeRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.fileRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.exitRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabControlMain = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ApplicationButtonDropDownControl = this.appMenu;
            this.ribbonControl.ApplicationButtonText = null;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Images = this.ribbonImageCollection;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.btnDSBN,
            this.iExit,
            this.btnThamSo,
            this.siStatus,
            this.alignButtonGroup,
            this.iBoldFontStyle,
            this.iItalicFontStyle,
            this.iUnderlinedFontStyle,
            this.fontStyleButtonGroup,
            this.iLeftTextAlign,
            this.iCenterTextAlign,
            this.iRightTextAlign,
            this.rgbiSkins,
            this.barButtonItemMau20});
            this.ribbonControl.LargeImages = this.ribbonImageCollectionLarge;
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 63;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.PageHeaderItemLinks.Add(this.btnThamSo);
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.homeRibbonPage,
            this.ribbonPage2});
            this.ribbonControl.QuickToolbarItemLinks.Add(this.btnDSBN);
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl.Size = new System.Drawing.Size(1100, 179);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            // 
            // appMenu
            // 
            this.appMenu.ItemLinks.Add(this.btnDSBN);
            this.appMenu.ItemLinks.Add(this.iExit);
            this.appMenu.Name = "appMenu";
            this.appMenu.Ribbon = this.ribbonControl;
            this.appMenu.ShowRightPane = true;
            // 
            // btnDSBN
            // 
            this.btnDSBN.Caption = "Danh sách";
            this.btnDSBN.Description = "Creates a new, blank file.";
            this.btnDSBN.Hint = "Creates a new, blank file";
            this.btnDSBN.Id = 1;
            this.btnDSBN.ImageOptions.ImageIndex = 15;
            this.btnDSBN.ImageOptions.LargeImageIndex = 9;
            this.btnDSBN.Name = "btnDSBN";
            this.btnDSBN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSBN_ItemClick);
            // 
            // iExit
            // 
            this.iExit.Caption = "Exit";
            this.iExit.Description = "Closes this program after prompting you to save unsaved data.";
            this.iExit.Hint = "Closes this program after prompting you to save unsaved data";
            this.iExit.Id = 20;
            this.iExit.ImageOptions.ImageIndex = 6;
            this.iExit.ImageOptions.LargeImageIndex = 6;
            this.iExit.Name = "iExit";
            this.iExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iExit_ItemClick);
            // 
            // ribbonImageCollection
            // 
            this.ribbonImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollection.ImageStream")));
            this.ribbonImageCollection.Images.SetKeyName(0, "Ribbon_New_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(1, "Ribbon_Open_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(2, "Ribbon_Close_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(3, "Ribbon_Find_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(4, "Ribbon_Save_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(5, "Ribbon_SaveAs_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(6, "Ribbon_Exit_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(7, "Ribbon_Content_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(8, "Ribbon_Info_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(9, "Ribbon_Bold_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(10, "Ribbon_Italic_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(11, "Ribbon_Underline_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(12, "Ribbon_AlignLeft_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(13, "Ribbon_AlignCenter_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(14, "Ribbon_AlignRight_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(15, "Apps-preferences-contact-list-icon.png");
            // 
            // btnThamSo
            // 
            this.btnThamSo.Caption = "Tham số";
            this.btnThamSo.Description = "Displays general program information.";
            this.btnThamSo.Hint = "Displays general program information";
            this.btnThamSo.Id = 24;
            this.btnThamSo.ImageOptions.ImageIndex = 8;
            this.btnThamSo.ImageOptions.LargeImageIndex = 10;
            this.btnThamSo.Name = "btnThamSo";
            this.btnThamSo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThamSo_ItemClick);
            // 
            // siStatus
            // 
            this.siStatus.Caption = "VNPT HIS SMS";
            this.siStatus.Id = 31;
            this.siStatus.Name = "siStatus";
            // 
            // alignButtonGroup
            // 
            this.alignButtonGroup.Caption = "Align Commands";
            this.alignButtonGroup.Id = 52;
            this.alignButtonGroup.ItemLinks.Add(this.iBoldFontStyle);
            this.alignButtonGroup.ItemLinks.Add(this.iItalicFontStyle);
            this.alignButtonGroup.ItemLinks.Add(this.iUnderlinedFontStyle);
            this.alignButtonGroup.Name = "alignButtonGroup";
            // 
            // iBoldFontStyle
            // 
            this.iBoldFontStyle.Caption = "Bold";
            this.iBoldFontStyle.Id = 53;
            this.iBoldFontStyle.ImageOptions.ImageIndex = 9;
            this.iBoldFontStyle.Name = "iBoldFontStyle";
            // 
            // iItalicFontStyle
            // 
            this.iItalicFontStyle.Caption = "Italic";
            this.iItalicFontStyle.Id = 54;
            this.iItalicFontStyle.ImageOptions.ImageIndex = 10;
            this.iItalicFontStyle.Name = "iItalicFontStyle";
            // 
            // iUnderlinedFontStyle
            // 
            this.iUnderlinedFontStyle.Caption = "Underlined";
            this.iUnderlinedFontStyle.Id = 55;
            this.iUnderlinedFontStyle.ImageOptions.ImageIndex = 11;
            this.iUnderlinedFontStyle.Name = "iUnderlinedFontStyle";
            // 
            // fontStyleButtonGroup
            // 
            this.fontStyleButtonGroup.Caption = "Font Style";
            this.fontStyleButtonGroup.Id = 56;
            this.fontStyleButtonGroup.ItemLinks.Add(this.iLeftTextAlign);
            this.fontStyleButtonGroup.ItemLinks.Add(this.iCenterTextAlign);
            this.fontStyleButtonGroup.ItemLinks.Add(this.iRightTextAlign);
            this.fontStyleButtonGroup.Name = "fontStyleButtonGroup";
            // 
            // iLeftTextAlign
            // 
            this.iLeftTextAlign.Caption = "Left";
            this.iLeftTextAlign.Id = 57;
            this.iLeftTextAlign.ImageOptions.ImageIndex = 12;
            this.iLeftTextAlign.Name = "iLeftTextAlign";
            // 
            // iCenterTextAlign
            // 
            this.iCenterTextAlign.Caption = "Center";
            this.iCenterTextAlign.Id = 58;
            this.iCenterTextAlign.ImageOptions.ImageIndex = 13;
            this.iCenterTextAlign.Name = "iCenterTextAlign";
            // 
            // iRightTextAlign
            // 
            this.iRightTextAlign.Caption = "Right";
            this.iRightTextAlign.Id = 59;
            this.iRightTextAlign.ImageOptions.ImageIndex = 14;
            this.iRightTextAlign.Name = "iRightTextAlign";
            // 
            // rgbiSkins
            // 
            this.rgbiSkins.Caption = "Skins";
            // 
            // 
            // 
            this.rgbiSkins.Gallery.AllowHoverImages = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rgbiSkins.Gallery.ColumnCount = 4;
            this.rgbiSkins.Gallery.FixedHoverImageSize = false;
            this.rgbiSkins.Gallery.ImageSize = new System.Drawing.Size(32, 17);
            this.rgbiSkins.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top;
            this.rgbiSkins.Gallery.RowCount = 4;
            this.rgbiSkins.Id = 60;
            this.rgbiSkins.Name = "rgbiSkins";
            // 
            // barButtonItemMau20
            // 
            this.barButtonItemMau20.Caption = "Mẫu 20";
            this.barButtonItemMau20.Id = 62;
            this.barButtonItemMau20.ImageOptions.Image = global::HISSMS.Properties.Resources.Apps_preferences_contact_list_icon_32x32;
            this.barButtonItemMau20.ImageOptions.LargeImageIndex = 9;
            this.barButtonItemMau20.Name = "barButtonItemMau20";
            this.barButtonItemMau20.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemMau20_ItemClick);
            // 
            // ribbonImageCollectionLarge
            // 
            this.ribbonImageCollectionLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.ribbonImageCollectionLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollectionLarge.ImageStream")));
            this.ribbonImageCollectionLarge.Images.SetKeyName(0, "Ribbon_New_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(1, "Ribbon_Open_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(2, "Ribbon_Close_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(3, "Ribbon_Find_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(4, "Ribbon_Save_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(5, "Ribbon_SaveAs_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(6, "Ribbon_Exit_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(7, "Ribbon_Content_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(8, "Ribbon_Info_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(9, "Apps-preferences-contact-list-icon_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(10, "Settings-icon_32x32.png");
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupBHYT});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Báo cáo";
            // 
            // ribbonPageGroupBHYT
            // 
            this.ribbonPageGroupBHYT.ItemLinks.Add(this.barButtonItemMau20);
            this.ribbonPageGroupBHYT.Name = "ribbonPageGroupBHYT";
            this.ribbonPageGroupBHYT.Text = "BHYT";
            // 
            // homeRibbonPage
            // 
            this.homeRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.fileRibbonPageGroup});
            this.homeRibbonPage.Name = "homeRibbonPage";
            this.homeRibbonPage.Text = "SMS";
            // 
            // fileRibbonPageGroup
            // 
            this.fileRibbonPageGroup.ItemLinks.Add(this.btnDSBN);
            this.fileRibbonPageGroup.ItemLinks.Add(this.btnThamSo);
            this.fileRibbonPageGroup.Name = "fileRibbonPageGroup";
            this.fileRibbonPageGroup.Text = "Gửi tin nhắn";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.exitRibbonPageGroup});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Hệ thống";
            // 
            // exitRibbonPageGroup
            // 
            this.exitRibbonPageGroup.ItemLinks.Add(this.iExit);
            this.exitRibbonPageGroup.Name = "exitRibbonPageGroup";
            this.exitRibbonPageGroup.Text = "Exit";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.siStatus);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 660);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1100, 40);
            // 
            // xtraTabControlMain
            // 
            this.xtraTabControlMain.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlMain.Location = new System.Drawing.Point(0, 179);
            this.xtraTabControlMain.Name = "xtraTabControlMain";
            this.xtraTabControlMain.Size = new System.Drawing.Size(1100, 481);
            this.xtraTabControlMain.TabIndex = 8;
            this.xtraTabControlMain.CloseButtonClick += new System.EventHandler(this.xtraTabControlMain_CloseButtonClick);
            // 
            // FormHISSMS
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.xtraTabControlMain);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FormHISSMS";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "VNPT HIS SMS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem btnDSBN;
        private DevExpress.XtraBars.BarButtonItem iExit;
        private DevExpress.XtraBars.BarButtonItem btnThamSo;
        private DevExpress.XtraBars.BarStaticItem siStatus;
        private DevExpress.XtraBars.BarButtonGroup alignButtonGroup;
        private DevExpress.XtraBars.BarButtonItem iBoldFontStyle;
        private DevExpress.XtraBars.BarButtonItem iItalicFontStyle;
        private DevExpress.XtraBars.BarButtonItem iUnderlinedFontStyle;
        private DevExpress.XtraBars.BarButtonGroup fontStyleButtonGroup;
        private DevExpress.XtraBars.BarButtonItem iLeftTextAlign;
        private DevExpress.XtraBars.BarButtonItem iCenterTextAlign;
        private DevExpress.XtraBars.BarButtonItem iRightTextAlign;
        private DevExpress.XtraBars.RibbonGalleryBarItem rgbiSkins;
        private DevExpress.XtraBars.Ribbon.RibbonPage homeRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup fileRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup exitRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu appMenu;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.Utils.ImageCollection ribbonImageCollection;
        private DevExpress.Utils.ImageCollection ribbonImageCollectionLarge;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlMain;
        private DevExpress.XtraBars.BarButtonItem barButtonItemMau20;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupBHYT;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
    }
}
