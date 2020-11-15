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
    }
}
