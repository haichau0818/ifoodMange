using FoodManage.DAL;
using FoodManage.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodManage.GUI.Forms
{
    public partial class frmLogin : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int RightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

            );
        public frmLogin()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DTO_Users login = UserDAL.Instance.login(txtUsername.Text, txtPassword.Text);

            if (login.Username!=null)
            {
                frmMain frmMain = new frmMain();
                this.Hide();
                frmMain.Show();
            }
        }
    }
}
