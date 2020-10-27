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
using PRN292_LapTopSaleSystemWF_Group4.DAO;
using PRN292_LapTopSaleSystemWF_Group4.Model;

namespace PRN292_LapTopSaleSystemWF_Group4.View
{
    public partial class frmUser : DevExpress.XtraEditors.XtraForm
    {
        UserDAO userDao = new UserDAO();
        SaleLaptopSystemEntities db = new SaleLaptopSystemEntities();
        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'saleLaptopSystemDataSet10.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.saleLaptopSystemDataSet10.Users);

        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmRegis frmR = new frmRegis();
            //frmR.MdiParent = this;
            frmR.Show();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             if (XtraMessageBox.Show("Do you want to delete", "Infor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtId.Text.Trim());
                if (userDao.delete(id))
                {
                    XtraMessageBox.Show("Delete Success");
                    usersBindingSource.DataSource = db.Users.ToList();
                }
                else
                {
                    XtraMessageBox.Show("Can not delete");
                }
            }
        }
    }
}