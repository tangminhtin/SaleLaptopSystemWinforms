using DevExpress.LookAndFeel;
using PRN292_LapTopSaleSystemWF_Group4.Model;
using PRN292_LapTopSaleSystemWF_Group4.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PRN292_LapTopSaleSystemWF_Group4
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        User user;
        public frmMain(User user)
        {
            InitializeComponent();
            UserLookAndFeel.Default.SetSkinStyle("Valentine");
            this.CenterToScreen();
            this.user = user;
            setUserInfo();
        }

        public void setUserInfo()
        {
            btnInfo.Caption = user.Fullname.Trim();
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLogin frmLogin = new frmLogin(null);
            frmLogin.Show();
            this.Visible = false;
        }

        private void btnProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
      
        }

        private void btnBrand_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBrand frBrand = new frmBrand();
            frBrand.MdiParent = this;
            frBrand.Show();
        }

        private void btnCate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCategory frmCategory = new frmCategory();
            frmCategory.MdiParent = this;
            frmCategory.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmUser frmUser = new frmUser();
            frmUser.MdiParent = this;
            frmUser.Show();
        }
    }
}
