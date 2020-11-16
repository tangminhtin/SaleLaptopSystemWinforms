using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRN292_LapTopSaleSystemWF_Group4.Model;

namespace PRN292_LapTopSaleSystemWF_Group4.View
{
    public partial class UserLoad : UserControl
    {
        SaleLaptopSystemEntities db = new SaleLaptopSystemEntities();
        int id = -1;
        User user;
        public UserLoad()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {
            var list = from user in db.Users
                       orderby user.Fullname ascending
                       select new
                       {
                           ID = user.ID,
                           Fullname = user.Fullname,
                           Email = user.Email,
                           Phone = user.Phone,
                           Address = user.Address,
                           Role = user.Role,
                           Active = user.Active
                       };
            dtTableBrand.DataSource = list.ToList();
            dtTableBrand.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtTableBrand.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dtTableBrand_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.id = Convert.ToInt32(dtTableBrand.Rows[dtTableBrand.CurrentCell.RowIndex].Cells[0].Value);
            this.user = db.Users.FirstOrDefault(b => b.ID == this.id);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(this.id < 0)
            {
                MessageBox.Show("Please select user to update");
            }
            else
            {
                User userU = db.Users.FirstOrDefault(x => x.ID == this.id);
                userU.Active = user.Active == true ? false : true;
                db.SaveChanges();
                load();
            }          
        }

        private void cbbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            String value = cbbRole.SelectedItem.ToString();
            var list = from user in db.Users
                       orderby user.Fullname ascending
                       where user.Role == value 
                       select new
                       {
                           ID = user.ID,
                           Fullname = user.Fullname,
                           Email = user.Email,
                           Phone = user.Phone,
                           Address = user.Address,
                           Role = user.Role,
                           Active = user.Active
                       };
            dtTableBrand.DataSource = list.ToList();
            dtTableBrand.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtTableBrand.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            load();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String text = txtSearch.Text.Trim();
            if (text == "")
            {
                load();
            }
            var list = from user in db.Users
                       where user.Fullname.Contains(text)
                       select new
                       {
                           ID = user.ID,
                           Fullname = user.Fullname,
                           Email = user.Email,
                           Phone = user.Phone,
                           Address = user.Address,
                           Role = user.Role,
                           Active = user.Active
                       };
            dtTableBrand.DataSource = list.ToList();
            dtTableBrand.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtTableBrand.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void cbbActive_CheckedChanged(object sender, EventArgs e)
        {
            var list = from user in db.Users
                       orderby user.Fullname ascending
                       select new
                       {
                           ID = user.ID,
                           Fullname = user.Fullname,
                           Email = user.Email,
                           Phone = user.Phone,
                           Address = user.Address,
                           Role = user.Role,
                           Active = user.Active
                       };
            if (cbbActive.Checked)
            {
                dtTableBrand.DataSource = list.Where(x => x.Active == true).ToList();
                dtTableBrand.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtTableBrand.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            else
            {
                dtTableBrand.DataSource = list.Where(x => x.Active == false).ToList();
                dtTableBrand.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtTableBrand.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            User uChange = db.Users.FirstOrDefault(x => x.ID == this.id);
            if (uChange.Role == "Admin")
            {
                uChange.Role = "User";
                db.SaveChanges();
            }
            else
            {
                uChange.Role = "Admin";
                db.SaveChanges();
            }
            load();
        }
    }
}
