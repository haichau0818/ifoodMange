using FoodManage.DAL;
using FoodManage.GUI.Forms.Users;
using FoodManage.ULTI;
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
            DataGridViewImageColumn Editlink = new DataGridViewImageColumn();
            Editlink.HeaderText = "Edit";
            Editlink.Image = Properties.Resources.edit_grid;
            Editlink.DataPropertyName = "lnkColumn";
            Editlink.DefaultCellStyle.SelectionForeColor = Color.FromArgb(22, 24, 35);
            Editlink.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgvListUser.Columns.Add(Editlink);

            //Delete link

            DataGridViewImageColumn deleteColumn = new DataGridViewImageColumn();
            deleteColumn.HeaderText = "Delete";
            deleteColumn.Image = Properties.Resources.delete_24;
            deleteColumn.DataPropertyName = "lnkColumn";
            deleteColumn.DefaultCellStyle.SelectionForeColor = Color.FromArgb(22, 24, 35);
            deleteColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvListUser.Columns.Add(deleteColumn);
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
                DialogResult result = handle.MessageBoxInformation("Are u sure edit user?");
                if (result == DialogResult.OK)
                {
                    frmCreateUser _frm = new frmCreateUser(id);
                    _frm.isUpate = true;
                    _frm.ShowDialog();
                }
                else if(result == DialogResult.Cancel)
                {
                    return;
                }
            }
            if (e.ColumnIndex == 1)
            {

                DialogResult result = handle.MessageBoxWarning("Are u sure delete user?");
                if (result == DialogResult.OK)
                {
                    UserDAL.Instance.delete(id);
                    LoadUser();
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }

            }

        }
    }
}
