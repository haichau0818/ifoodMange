using FoodManage.DAL;
using FoodManage.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

            string userName = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (userName == "" && password == "")
            {
                lblMessageEr.Visible = true;
                lblMessageEr.Text = "Please enter username and password!";
            }
            else if (userName != "" && password == "")
            {
                lblMessageEr.Visible = true;
                lblMessageEr.Text = "Please enter password!";

            }
            else if (userName == "" && password != "")
            {
                lblMessageEr.Visible = true;
                lblMessageEr.Text = "Please enter username!";
            }
            else
            {
                DTO_Users login = UserDAL.Instance.login(userName, password);
                if (login.Username != null)
                {
                    if (ckdRemember.Checked)
                    {
                        // Get the configuration file
                        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                        // Set the username and password values
                        config.AppSettings.Settings["username"].Value = userName;
                        config.AppSettings.Settings["password"].Value = password;

                        // Save the configuration file
                        config.Save(ConfigurationSaveMode.Modified);

                        // Refresh the app settings section
                        ConfigurationManager.RefreshSection("appSettings");
                    }
                    // If the remember me checkbox is not checked, clear the username and password from the app.config file
                    else
                    {
                        // Get the configuration file
                        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                        // Clear the username and password values
                        config.AppSettings.Settings["username"].Value = "";
                        config.AppSettings.Settings["password"].Value = "";

                        // Save the configuration file
                        config.Save(ConfigurationSaveMode.Modified);

                        // Refresh the app settings section
                        ConfigurationManager.RefreshSection("appSettings");
                    }

                    frmMain frmMain = new frmMain();
                    this.Hide();
                    frmMain.Show();
                }
                else
                {
                    lblMessageEr.Visible = true;
                    lblMessageEr.Text = "Username or password not correct!";
                }
            } 

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // Get the username and password from the app.config file
            string username = ConfigurationManager.AppSettings["username"];
            string password = ConfigurationManager.AppSettings["password"];

            // If the username and password are not empty, fill them in the textboxes and check the remember me checkbox
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                btnLogin.Focus();
                txtUsername.Text = username;
                txtPassword.Text = password;
                ckdRemember.Checked = true;
            }
        }
    }
}
