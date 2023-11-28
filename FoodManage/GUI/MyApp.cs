using FoodManage.DTO;
using FoodManage.GUI.Forms;
using FoodManage.GUI.Forms.Users;
using FoodManage.GUI.UserControls.Foods;
using FoodManage.GUI.UserControls.Home;
using FoodManage.GUI.UserControls.Users;
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

namespace FoodManage.GUI
{
    public partial class frmMain : Form
    {
        public DTO_Users _users;

        public frmMain()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {

        }
        #region event button
        private void btnHome_MouseMove(object sender, MouseEventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(48, 40, 53);
        }


        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.Transparent;
        }

        private void btnFood_MouseLeave(object sender, EventArgs e)
        {
            btnFood.BackColor = Color.Transparent;
        }

        private void btnFood_MouseMove(object sender, MouseEventArgs e)
        {
            btnFood.BackColor = Color.FromArgb(48, 40, 53);
        }

        private void btnTable_MouseLeave(object sender, EventArgs e)
        {
            btnTable.BackColor = Color.Transparent;
        }

        private void btnTable_MouseMove(object sender, MouseEventArgs e)
        {
            btnTable.BackColor = Color.FromArgb(48, 40, 53);
        }

       

        private void btnClose_MouseMove(object sender, MouseEventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(48, 40, 53);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
        }

        private void btnMinimize_MouseMove(object sender, MouseEventArgs e)
        {
            btnMinimize.BackColor = Color.FromArgb(48, 40, 53);
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.Transparent;
        }

        #endregion
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin loginForm = new frmLogin();
            loginForm.Show();

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonRadius1_MouseMove(object sender, MouseEventArgs e)
        {
            pnlUser.Visible = true;
            this.pnlUser.BringToFront();
        }

        private void buttonRadius1_MouseLeave(object sender, EventArgs e)
        {
            pnlUser.Visible = false;
        }
        private void buttonRadius1_Click(object sender, EventArgs e)
        {
            pnlUser.Visible = true;
            this.pnlUser.BringToFront();
        }
        private void btnFood_Click(object sender, EventArgs e)
        {

            uFoods uListFood = new uFoods();
            AddUserControl(uListFood);

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            uHome uListFood = new uHome();
            AddUserControl(uListFood);
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (_users != null)
            {
                lblUserInfor.Text = _users.FullName;
                if (_users.Avatar != null)
                    picAvatar.Image = byteArrayToImage(_users.Avatar);
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            uUsers _uUsers = new uUsers();
            AddUserControl(_uUsers);

        }

        private void AddUserControl(UserControl userControl)
        {
            int i = 0;
            //Kiểm tra các controls trong pnlMain có tồn tại UC chưa
            foreach (Control control in pnlContent.Controls)
            {
                if (control is UserControl)
                {
                    if (control.Name == userControl.Name)
                    {
                        if (pnlContent.Controls[i].Name == userControl.Name)
                        {
                            pnlContent.Controls[i].BringToFront();
                            return;
                        }
                    }
                }
                i++;
            }
            userControl.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(userControl);
            pnlContent.Controls[pnlContent.Controls.Count - 1].BringToFront();
        }

        #region convert image

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        #endregion

        private void btnWarehouse_Click(object sender, EventArgs e)
        {

        }

        private void btnUser_MouseMove(object sender, MouseEventArgs e)
        {
            btnUser.BackColor = Color.FromArgb(48, 40, 53);
        }

        private void btnUser_MouseLeave(object sender, EventArgs e)
        {
            btnUser.BackColor = Color.Transparent;
        }
    }
}
