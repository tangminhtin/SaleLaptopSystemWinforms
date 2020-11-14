using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using PRN292_LapTopSaleSystemWF_Group4.Model;
using PRN292_LapTopSaleSystemWF_Group4.DAO;
using DevExpress.XtraEditors;

namespace PRN292_LapTopSaleSystemWF_Group4.View
{
    public partial class UserLoad : UserControl
    {
        SaleLaptopSystemEntities db = new SaleLaptopSystemEntities();
        UserDAO userDao = new UserDAO();
        Boolean isAdd = false;
        public UserLoad()
        {
            InitializeComponent();
            usersBindingSource1.DataSource = db.Users.ToList();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            usersBindingSource1.AddNew();
            isAdd = true;
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Do you want to delete", "Infor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtId.Text.Trim());
                if (userDao.delete(id))
                {
                    XtraMessageBox.Show("Delete Success");
                    usersBindingSource1.DataSource = db.Users.ToList();
                }
                else
                {
                    XtraMessageBox.Show("Can not delete");
                }
            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isAdd)
            {
                String name = txtName.Text.Trim();
                String password = txtPassword.Text.Trim();
                String email = txtEmail.Text.Trim();
                String phone = txtPhone.Text.Trim();
                String address = txtAddress.Text.Trim();
                String image = txtImage.Text.Trim();
                int role = Convert.ToInt32(txtRole.Text.Trim());
                int activeint = cbCheck.Checked ? 1 : 0;
                Boolean active = activeint == 1 ? true : false;

                if (userDao.registration(name, password,email,phone,address ,image,role))
                {
                    usersBindingSource1.DataSource = db.Users.ToList();
                }
                else
                {
                    MessageBox.Show("loi");
                }
                isAdd = false;
            }

            else
            {
                int id = Convert.ToInt32(txtId.Text.Trim());
                String name = txtName.Text.Trim();
                String password = txtPassword.Text.Trim();
                String email = txtEmail.Text.Trim();
                String phone = txtPhone.Text.Trim();
                String address = txtAddress.Text.Trim();
                String image = txtImage.Text.Trim();
                string role = txtRole.Text.Trim();
                int activeint = cbCheck.Checked ? 1 : 0;
                Boolean active = activeint == 1 ? true : false;
                if (userDao.update(id, name,password,email,phone,address, image, role, active))
                {
                    usersBindingSource1.DataSource = db.Brands.ToList();
                }
                else
                {
                    MessageBox.Show("loi");
                }
            }
        }
    }
}
