using FoodManage.DAL;
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

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmCreateUser _frm = new frmCreateUser();
            _frm.ShowDialog();
            LoadUser();
        }

        private void uUsers_Load(object sender, EventArgs e)
        {
            LoadUser();
        }

        private void LoadUser()
        {
            dtgvListUser.DataSource = UserDAL.Instance.getAll();
        }
    }
}
