namespace PRN292_LapTopSaleSystemWF_Group4.View
{
    partial class Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnUser = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnProduct = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnProductDetail = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnBrands = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnCategory = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator2 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlElement7 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnOder = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnOderdetail = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement11 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnExport = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlSeparator1,
            this.accordionControlElement3,
            this.accordionControlSeparator2,
            this.accordionControlElement7,
            this.accordionControlElement11});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Auto;
            this.accordionControl1.Size = new System.Drawing.Size(312, 608);
            this.accordionControl1.TabIndex = 0;
            this.accordionControl1.Text = "accordionControl1";
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnUser});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement1.ImageOptions.Image")));
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "User Management";
            // 
            // btnUser
            // 
            this.btnUser.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.btnUser.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.ImageOptions.Image")));
            this.btnUser.Name = "btnUser";
            this.btnUser.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnUser.Text = "Users";
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnProduct,
            this.btnProductDetail,
            this.btnBrands,
            this.btnCategory});
            this.accordionControlElement3.Expanded = true;
            this.accordionControlElement3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement3.ImageOptions.Image")));
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Text = "Product Management";
            // 
            // btnProduct
            // 
            this.btnProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.ImageOptions.Image")));
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnProduct.Text = "Product";
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnProductDetail
            // 
            this.btnProductDetail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProductDetail.ImageOptions.Image")));
            this.btnProductDetail.Name = "btnProductDetail";
            this.btnProductDetail.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnProductDetail.Text = "Product Detail";
            this.btnProductDetail.Click += new System.EventHandler(this.btnProductDetail_Click);
            // 
            // btnBrands
            // 
            this.btnBrands.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBrands.ImageOptions.Image")));
            this.btnBrands.Name = "btnBrands";
            this.btnBrands.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnBrands.Text = "Brands";
            this.btnBrands.Click += new System.EventHandler(this.btnBrands_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCategory.ImageOptions.Image")));
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnCategory.Text = "Category";
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // accordionControlSeparator2
            // 
            this.accordionControlSeparator2.Name = "accordionControlSeparator2";
            // 
            // accordionControlElement7
            // 
            this.accordionControlElement7.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnOder,
            this.btnOderdetail});
            this.accordionControlElement7.Expanded = true;
            this.accordionControlElement7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement7.ImageOptions.Image")));
            this.accordionControlElement7.Name = "accordionControlElement7";
            this.accordionControlElement7.Text = "Oder Management";
            // 
            // btnOder
            // 
            this.btnOder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOder.ImageOptions.Image")));
            this.btnOder.Name = "btnOder";
            this.btnOder.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnOder.Text = "Oder";
            // 
            // btnOderdetail
            // 
            this.btnOderdetail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOderdetail.ImageOptions.Image")));
            this.btnOderdetail.Name = "btnOderdetail";
            this.btnOderdetail.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnOderdetail.Text = "Oder detail";
            // 
            // accordionControlElement11
            // 
            this.accordionControlElement11.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnExport});
            this.accordionControlElement11.Expanded = true;
            this.accordionControlElement11.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement11.ImageOptions.Image")));
            this.accordionControlElement11.Name = "accordionControlElement11";
            this.accordionControlElement11.Text = "Export";
            // 
            // btnExport
            // 
            this.btnExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.ImageOptions.Image")));
            this.btnExport.Name = "btnExport";
            this.btnExport.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnExport.Text = "Export Pdf";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(312, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 608);
            this.panel1.TabIndex = 1;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 608);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.accordionControl1);
            this.Name = "Test";
            this.Text = "Test";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnUser;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnProduct;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnProductDetail;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnBrands;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnCategory;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement7;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnOder;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnOderdetail;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement11;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnExport;
        private System.Windows.Forms.Panel panel1;
    }
}