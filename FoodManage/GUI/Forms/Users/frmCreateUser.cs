using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FoodManage.DTO;
using FoodManage.DAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FoodManage.GUI.Forms.Users
{
    public partial class frmCreateUser : Form
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

        #region Move form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion
        public frmCreateUser()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void frmCreateUser_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void picCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DTO_Users user = new DTO_Users();
            user.FullName = txtFullname.Text.Trim();
            user.Email = txtEmail.Text;
            user.Password = txtPassword.Text;
            user.Phonenumber = txtPhoneNumber.Text;
            user.Address = txtAddress.Text;

            user.Gender = true;
            Image imagee = picAvatar.Image;
            byte[] image_aray;
            ImageConverter converter = new ImageConverter();
            image_aray = (byte[])converter.ConvertTo(imagee, typeof(byte[]));
            user.Avatar = image_aray;
            user.Dateofbird = dtpDateOfBird.Value;
            user.Role = 1;
            UserDAL.Instance.insert(user);
            this.Close();

        }

        private void btnChooseAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                picAvatar.Image = new Bitmap(open.FileName);
                // image file path
                
            }
        }
    }
}
