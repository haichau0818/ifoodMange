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
            DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
            Editlink.UseColumnTextForLinkValue = true;
            Editlink.HeaderText = "Edit";
            Editlink.DataPropertyName = "lnkColumn";
            Editlink.LinkColor = Color.FromArgb(252, 252, 252);
            Editlink.LinkBehavior = LinkBehavior.NeverUnderline;
            Editlink.DefaultCellStyle.SelectionForeColor = Color.FromArgb(22, 24, 35);
            Editlink.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            Editlink.Text = "Edit";
            dtgvListUser.Columns.Add(Editlink);

            //Delete link

            DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
            Deletelink.UseColumnTextForLinkValue = true;
            Deletelink.HeaderText = "Delete";
            Deletelink.LinkColor = Color.FromArgb(252, 252, 252);
            Deletelink.DataPropertyName = "lnkColumn";
            Deletelink.LinkBehavior = LinkBehavior.NeverUnderline;
            Deletelink.DefaultCellStyle.SelectionForeColor = Color.FromArgb(22, 24, 35);
            Deletelink.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Deletelink.Text = "Delete";
            dtgvListUser.Columns.Add(Deletelink);
        }

        private void LoadUser()
        {

            dtgvListUser.DataSource = UserDAL.Instance.getAll();
        }

        private void dtgvListUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dtgvListUser.Rows[e.RowIndex].Cells["Id"].Value);
            if (e.ColumnIndex == 0)
            {

            }
            if (e.ColumnIndex == 1)
            {

                DialogResult result = MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    UserDAL.Instance.delete(id);
                    LoadUser();
                }
                else if (result == DialogResult.No)
                {
                    return;
                }

            }

        }
    }
}
