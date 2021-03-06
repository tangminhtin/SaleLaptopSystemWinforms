﻿using DevExpress.XtraBars;
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
            ProductView viewProduct = new ProductView();
            pnlView.Controls.Add(viewProduct);
            viewProduct.BringToFront();
        }

        private void ControlUser_Click(object sender, EventArgs e)
        {
            UserLoad userLoad = new UserLoad();
            pnlView.Controls.Add(userLoad);
            userLoad.BringToFront();
        }

        private void ControlHistory_Click(object sender, EventArgs e)
        {
            HistoryControl history = new HistoryControl();
            pnlView.Controls.Add(history);
            history.BringToFront();
        }

        private void ReportControl_Click(object sender, EventArgs e)
        {

        }
    }
}
