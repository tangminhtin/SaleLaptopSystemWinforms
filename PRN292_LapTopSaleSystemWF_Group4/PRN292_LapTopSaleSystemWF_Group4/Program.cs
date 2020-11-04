using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using PRN292_LapTopSaleSystemWF_Group4.View;

namespace PRN292_LapTopSaleSystemWF_Group4
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmLogin(null));
<<<<<<< HEAD
            Application.Run(new Test());
=======
            Application.Run(new frmRegis());
>>>>>>> a429ad988855b0d7381ae7004193cfc5b1ab2970
            //Application.Run(new frmUser());
        }
    }
}
