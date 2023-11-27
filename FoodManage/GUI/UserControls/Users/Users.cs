using FoodManage.GUI.Forms.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodManage.GUI.UserControls.Users
{
    public partial class uUsers : UserControl
    {
        public uUsers()
        {
            InitializeComponent();
        }

        private void buttonRadius1_Click(object sender, EventArgs e)
        {
            frmCreateUser frm = new frmCreateUser();
            frm.ShowDialog();
        }
    }
}
