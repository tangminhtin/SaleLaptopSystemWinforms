namespace PRN292_SystemSaleLaptop_Group4
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barbtnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.rbbPageUserSys = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbbPageGrAuthen = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barbtnLogin,
            this.barbtnLogout});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 385;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbbPageUserSys});
            this.ribbonControl1.Size = new System.Drawing.Size(884, 193);
            // 
            // barbtnLogin
            // 
            this.barbtnLogin.Caption = "Login";
            this.barbtnLogin.Id = 1;
            this.barbtnLogin.Name = "barbtnLogin";
            // 
            // barbtnLogout
            // 
            this.barbtnLogout.Caption = "Logout";
            this.barbtnLogout.Id = 2;
            this.barbtnLogout.Name = "barbtnLogout";
            // 
            // rbbPageUserSys
            // 
            this.rbbPageUserSys.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbbPageGrAuthen});
            this.rbbPageUserSys.Name = "rbbPageUserSys";
            this.rbbPageUserSys.Text = "User system";
            // 
            // rbbPageGrAuthen
            // 
            this.rbbPageGrAuthen.ItemLinks.Add(this.barbtnLogout);
            this.rbbPageGrAuthen.Name = "rbbPageGrAuthen";
            this.rbbPageGrAuthen.Text = "Authentication";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 443);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "HackBrain_LaptopSale";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbbPageUserSys;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbbPageGrAuthen;
        private DevExpress.XtraBars.BarButtonItem barbtnLogin;
        private DevExpress.XtraBars.BarButtonItem barbtnLogout;
    }
}

