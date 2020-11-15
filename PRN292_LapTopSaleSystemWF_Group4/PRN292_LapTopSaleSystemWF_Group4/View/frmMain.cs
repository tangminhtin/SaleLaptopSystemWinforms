using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PRN292_LapTopSaleSystemWF_Group4.Model;

namespace PRN292_LapTopSaleSystemWF_Group4.View
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        User user;
        SaleLaptopSystemEntities db = new SaleLaptopSystemEntities();
        public frmMain(User user)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.user = user;
            LoginName.Text = user.Fullname;
        }

        private void ControlBrand_Click(object sender, EventArgs e)
        {
            BrandLoad viewBrand = new BrandLoad();
            pnlView.Controls.Add(viewBrand);
            viewBrand.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin(null);
            frmLogin.Show();
            this.Visible = false;
        }

        private void btnCate_Click(object sender, EventArgs e)
        {
            CategoryLoad viewCate = new CategoryLoad();
            pnlView.Controls.Add(viewCate);
            viewCate.BringToFront();
        }

        private void ControlProductDetail_Click(object sender, EventArgs e)
        {
            CategoryLoad viewCate = new CategoryLoad();
            pnlView.Controls.Add(viewCate);
            viewCate.BringToFront();
        }
    }
}
