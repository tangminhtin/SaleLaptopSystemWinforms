namespace PRN292_LapTopSaleSystemWF_Group4
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.barSSInfo = new DevExpress.XtraBars.BarStaticItem();
            this.btnInfo = new DevExpress.XtraBars.BarButtonItem();
            this.btnProduct = new DevExpress.XtraBars.BarButtonItem();
            this.btnBrand = new DevExpress.XtraBars.BarButtonItem();
            this.btnCate = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItem1,
            this.btnLogout,
            this.skinRibbonGalleryBarItem1,
            this.barSSInfo,
            this.btnInfo,
            this.btnProduct,
            this.btnBrand,
            this.btnCate,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 12;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 385;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1357, 193);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Logout";
            this.btnLogout.Id = 2;
            this.btnLogout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.Image")));
            this.btnLogout.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.LargeImage")));
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 3;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // barSSInfo
            // 
            this.barSSInfo.Caption = "barStaticItem1";
            this.barSSInfo.Id = 4;
            this.barSSInfo.Name = "barSSInfo";
            // 
            // btnInfo
            // 
            this.btnInfo.Caption = "barButtonItem2";
            this.btnInfo.Id = 5;
            this.btnInfo.Name = "btnInfo";
            // 
            // btnProduct
            // 
            this.btnProduct.Caption = "Product";
            this.btnProduct.Id = 6;
            this.btnProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.ImageOptions.Image")));
            this.btnProduct.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnProduct.ImageOptions.LargeImage")));
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProduct_ItemClick);
            // 
            // btnBrand
            // 
            this.btnBrand.Caption = "Brand";
            this.btnBrand.Id = 7;
            this.btnBrand.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBrand.ImageOptions.Image")));
            this.btnBrand.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBrand.ImageOptions.LargeImage")));
            this.btnBrand.Name = "btnBrand";
            this.btnBrand.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBrand_ItemClick);
            // 
            // btnCate
            // 
            this.btnCate.Caption = "Category";
            this.btnCate.Id = 8;
            this.btnCate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCate.ImageOptions.Image")));
            this.btnCate.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCate.ImageOptions.LargeImage")));
            this.btnCate.Name = "btnCate";
            this.btnCate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCate_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "User";
            this.barButtonItem5.Id = 9;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "barButtonItem6";
            this.barButtonItem6.Id = 10;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "barButtonItem7";
            this.barButtonItem7.Id = 11;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "User Management";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnInfo);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogout);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Auth";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnProduct);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnBrand);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCate);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Management System";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 576);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Laptop sale system";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.BarStaticItem barSSInfo;
        private DevExpress.XtraBars.BarButtonItem btnInfo;
        private DevExpress.XtraBars.BarButtonItem btnProduct;
        private DevExpress.XtraBars.BarButtonItem btnBrand;
        private DevExpress.XtraBars.BarButtonItem btnCate;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}

