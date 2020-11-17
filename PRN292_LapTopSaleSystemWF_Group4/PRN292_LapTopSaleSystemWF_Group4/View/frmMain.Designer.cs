namespace PRN292_LapTopSaleSystemWF_Group4.View
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.LoginName = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnLogout = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ControlBrand = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ControlCate = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ControlProductDetail = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ReportControl = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ControlUser = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ControlHistory = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.pnlView = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.LoginName,
            this.accordionControlElement1,
            this.accordionControlElement2,
            this.ControlUser,
            this.ControlHistory});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.accordionControl1.Size = new System.Drawing.Size(303, 550);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // LoginName
            // 
            this.LoginName.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnLogout});
            this.LoginName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("LoginName.ImageOptions.Image")));
            this.LoginName.Name = "LoginName";
            this.LoginName.Text = "Element1";
            // 
            // btnLogout
            // 
            this.btnLogout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.Image")));
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ControlBrand,
            this.ControlCate,
            this.ControlProductDetail});
            this.accordionControlElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement1.ImageOptions.Image")));
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Product";
            // 
            // ControlBrand
            // 
            this.ControlBrand.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ControlBrand.ImageOptions.Image")));
            this.ControlBrand.Name = "ControlBrand";
            this.ControlBrand.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ControlBrand.Text = "Brand";
            this.ControlBrand.Click += new System.EventHandler(this.ControlBrand_Click);
            // 
            // ControlCate
            // 
            this.ControlCate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ControlCate.ImageOptions.Image")));
            this.ControlCate.Name = "ControlCate";
            this.ControlCate.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ControlCate.Text = "Category";
            this.ControlCate.Click += new System.EventHandler(this.btnCate_Click);
            // 
            // ControlProductDetail
            // 
            this.ControlProductDetail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ControlProductDetail.ImageOptions.Image")));
            this.ControlProductDetail.Name = "ControlProductDetail";
            this.ControlProductDetail.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ControlProductDetail.Text = "Product";
            this.ControlProductDetail.Click += new System.EventHandler(this.ControlProductDetail_Click);
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ReportControl});
            this.accordionControlElement2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement2.ImageOptions.Image")));
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "Export";
            // 
            // ReportControl
            // 
            this.ReportControl.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement3.ImageOptions.Image")));
            this.ReportControl.Name = "ReportControl";
            this.ReportControl.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ReportControl.Text = "Report Export";
            this.ReportControl.Click += new System.EventHandler(this.ReportControl_Click);
            // 
            // ControlUser
            // 
            this.ControlUser.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ControlUser.ImageOptions.Image")));
            this.ControlUser.Name = "ControlUser";
            this.ControlUser.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ControlUser.Text = "User management";
            this.ControlUser.Click += new System.EventHandler(this.ControlUser_Click);
            // 
            // ControlHistory
            // 
            this.ControlHistory.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ControlHistory.ImageOptions.Image")));
            this.ControlHistory.Name = "ControlHistory";
            this.ControlHistory.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ControlHistory.Text = "History";
            this.ControlHistory.Click += new System.EventHandler(this.ControlHistory_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1371, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.DockingEnabled = false;
            this.fluentFormDefaultManager1.Form = this;
            // 
            // pnlView
            // 
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(303, 39);
            this.pnlView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(1068, 550);
            this.pnlView.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 589);
            this.ControlContainer = this.pnlView;
            this.Controls.Add(this.pnlView);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.NavigationControl = this.accordionControl1;
            this.Text = "frmMain";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement LoginName;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnLogout;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlBrand;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer pnlView;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlCate;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlProductDetail;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlUser;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlHistory;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ReportControl;
    }
}