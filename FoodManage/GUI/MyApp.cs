
using FoodManage.DTO;
using FoodManage.GUI.Forms;
using FoodManage.GUI.UserControls.Foods;
using FoodManage.GUI.UserControls.Home;
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
        public DTO_Users users;
        public frmMain()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {

        }

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

        private void btnWarehouse_MouseLeave(object sender, EventArgs e)
        {
            btnWarehouse.BackColor = Color.Transparent;
        }

        private void btnWarehouse_MouseMove(object sender, MouseEventArgs e)
        {
            btnWarehouse.BackColor = Color.FromArgb(48, 40, 53);
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
            int i = 0;
            //Kiểm tra các controls trong pnlMain có tồn tại UC chưa
            foreach (Control control in pnlContent.Controls)
            {
                if (control is UserControl)
                {
                    if (control.Name == "uListFood")
                    {
                        if (pnlContent.Controls[i].Name == "uListFood")
                        {
                            pnlContent.Controls[i].BringToFront();
                            return;
                        }
                    }
                }
                i++;
            }
            //Nếu chưa tồn tại UC thì Add vào pnlMain
            uFoods uListFood = new uFoods();
            uListFood.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uListFood);
            pnlContent.Controls[pnlContent.Controls.Count - 1].BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            int i = 0;
            //Kiểm tra các controls trong pnlMain có tồn tại UC chưa
            foreach (Control control in pnlContent.Controls)
            {
                if (control is UserControl)
                {
                    if (control.Name == "uHome")
                    {
                        if (pnlContent.Controls[i].Name == "uHome")
                        {
                            pnlContent.Controls[i].BringToFront();
                            return;
                        }
                    }
                }
                i++;
            }
            //Nếu chưa tồn tại UC thì Add vào pnlMain
            uHome uListFood = new uHome();
            uListFood.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uListFood);
            pnlContent.Controls[pnlContent.Controls.Count - 1].BringToFront();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
        }
    }
}
