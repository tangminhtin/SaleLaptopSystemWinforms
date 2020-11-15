using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PRN292_LapTopSaleSystemWF_Group4.Validate;
using System.Security.Cryptography;
using PRN292_LapTopSaleSystemWF_Group4.Model;
using PRN292_LapTopSaleSystemWF_Group4.DAO;

namespace PRN292_LapTopSaleSystemWF_Group4.View
{
    public partial class frmRegis : DevExpress.XtraEditors.XtraForm
    {
        public frmRegis()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.lblcheckPass.Visible = false;
            this.lblConf.Visible = false;
            this.lblEmailCheck.Visible = false;
            this.lblPhonecheck.Visible = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin(null);
            frmLogin.Show();
            this.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            AuthenticationValidate validate = new AuthenticationValidate();
            SaleLaptopSystemEntities db = new SaleLaptopSystemEntities();
            UserDAO uDAO = new UserDAO();

            String fullname = txtFullname.Text.Trim();
            String email = txtEmail.Text.Trim();
            String password = txtPass.Text.Trim();
            String confirm = txtConfirm.Text.Trim();
            String phone = txtPhone.Text.Trim();
            String address = txtAddress.Text.Trim();
            String img = txtImage.Text.Trim();
            int role = cbbRole.SelectedIndex;

            if (fullname == "" || email == "" || password == "" || confirm == "" || phone == "" || address == "" || img == "")
            {
                MessageBox.Show("Input the fill", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (!validate.checkEmail(email))
                {
                    MessageBox.Show("Incorrect email format", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

/*                if (!validate.checkPassword(password))
                {
                    MessageBox.Show("Password must have 8-15 character and have 1 special and number", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }*/

/*                if (!validate.checkPhone(phone))
                {
                    MessageBox.Show("Incorrect phone format", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }*/


                if (password.Length <= 8)
                {
                    MessageBox.Show("Password length must be greater equal 8 character", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (password != confirm)
                {
                    MessageBox.Show("Password not pair", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(validate.checkUserExist(txtEmail.Text.Trim())!=null)
                {
                    MessageBox.Show("Email existed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                

                if (!uDAO.registration(fullname,password,email,phone,address,img,role+1))
                {
                    MessageBox.Show("Registration error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    frmLogin frmLogin = new frmLogin(null);
                    frmLogin.Show();
                    this.Visible = false;
                }
            }


        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            AuthenticationValidate validate = new AuthenticationValidate();
            String password = txtPass.Text.Trim();
            if (validate.checkPassword(password))
            {
                lblcheckPass.Visible = true;
            }
            else
            {
                lblcheckPass.Visible = false;
            }
            
        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {
            AuthenticationValidate validate = new AuthenticationValidate();
            String password = txtPass.Text.Trim();
            String confirm = txtConfirm.Text.Trim();
            if (password != confirm)
            {
                this.lblConf.Visible = false;
            }
            else
            {
                this.lblConf.Visible = true;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            AuthenticationValidate validate = new AuthenticationValidate();
            String email = txtEmail.Text.Trim();
            if (!validate.checkEmail(email))
            {
                this.lblEmailCheck.Visible = false;
            }
            else
            {
                if(validate.checkUserExist(email) == null)
                {
                    this.lblEmailCheck.Visible = true;
                }
                else
                {
                    this.lblEmailCheck.Visible = false;
                }
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            AuthenticationValidate validate = new AuthenticationValidate();
            String phone = txtPhone.Text.Trim();
            if (!validate.checkPhone(phone))
            {
                this.lblPhonecheck.Visible = false;
            }
            else
            {
                this.lblPhonecheck.Visible = true;
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            TextBox txt = sender as TextBox;
        }
    }
}