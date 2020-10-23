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
            btnInfo.Caption = user.fullname.Trim();
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLogin frmLogin = new frmLogin(null);
            frmLogin.Show();
            this.Visible = false;
        }
    }
}
