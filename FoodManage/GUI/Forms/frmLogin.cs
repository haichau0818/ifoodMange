using FoodManage.DAL;
using FoodManage.DTO;
using FoodManage.ULTI;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FoodManage.GUI.Forms
{
    public partial class frmLogin : Form
    {
        #region Rounded Corners Form
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

        #endregion
        public frmLogin()
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        string email = "";
        string password = "";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            email = this.txtEmail.Text;
            password = this.txtPassword.Text;

            //hash password with key: ifoodmanagebyhai from web online
            password = handle.Encrypt("aWZvb2RtYW5hZ2VieWhhaQ==", password);
            password = handle.Decrypt("aWZvb2RtYW5hZ2VieWhhaQ==", password);


            if (email == "" && password == "")
            {
                lblMessageEr.Visible = true;
                lblMessageEr.Text = "Please enter email and password!";
            }
            else if (email != "" && password == "")
            {
                lblMessageEr.Visible = true;
                lblMessageEr.Text = "Please enter password!";

            }
            else if (email == "" && password != "")
            {
                lblMessageEr.Visible = true;
                lblMessageEr.Text = "Please enter email!";
            }
            else
            {

                //Get login in4 from db
                DTO_Users login = UserDAL.Instance.login(email, password);
                if (login.Email != null)
                {
                    if (ckdRemember.Checked)
                    {
                        // Get the configuration file
                        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                        // Set the email and password values
                        config.AppSettings.Settings["email"].Value = email;
                        config.AppSettings.Settings["password"].Value = password;

                        // Save the configuration file
                        config.Save(ConfigurationSaveMode.Modified);

                        // Refresh the app settings section
                        ConfigurationManager.RefreshSection("appSettings");
                    }
                    // If the remember me checkbox is not checked, clear the email and password from the app.config file
                    else
                    {
                        // Get the configuration file
                        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                        // Clear the email and password values
                        config.AppSettings.Settings["email"].Value = "";
                        config.AppSettings.Settings["password"].Value = "";

                        // Save the configuration file
                        config.Save(ConfigurationSaveMode.Modified);

                        // Refresh the app settings section
                        ConfigurationManager.RefreshSection("appSettings");
                    }

                    frmMain frmMain = new frmMain();
                    frmMain._users = login;
                    this.Hide();
                    frmMain.Show();
                }
                else
                {
                    lblMessageEr.Visible = true;
                    lblMessageEr.Text = "email or password not correct!";
                }
            }

        }
        #region event form
        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        private void frmLogin_Load(object sender, EventArgs e)
        {
            // Get the email and password from the app.config file
            string _email = ConfigurationManager.AppSettings["email"];
            string _password = ConfigurationManager.AppSettings["password"];

            // If the email and password are not empty, fill them in the textboxes and check the remember me checkbox
            if (!string.IsNullOrEmpty(_email) && !string.IsNullOrEmpty(_password))
            {
                this.txtEmail.isPlaceholder = false;
                this.txtPassword.isPlaceholder = false;
                this.txtPassword.PasswordChar = true;
                this.txtEmail.ForeColor = Color.Black;
                this.txtEmail.Text = _email;
                this.txtPassword.PasswordChar = true;
                this.txtPassword.ForeColor = Color.Black;
                this.txtPassword.Text = _password;
                this.ckdRemember.Checked = true;
            }
            else
            {
                this.ckdRemember.Checked = false;
            }
        }


    }
}
