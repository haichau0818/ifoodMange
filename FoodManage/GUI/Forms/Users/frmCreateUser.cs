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
using FoodManage.DTO;
using FoodManage.DAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using FoodManage.ULTI;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace FoodManage.GUI.Forms.Users
{
    public partial class frmCreateUser : Form
    {

        private DTO_Role _role = new DTO_Role();
        private DTO_Gender _gender = new DTO_Gender();
        private DTO_Users _user = new DTO_Users();

        public bool isUpate = false;



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
        #region handle form
        private void frmCreateUser_MouseDown(object sender, MouseEventArgs e)
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

        #endregion

        #region feature form




        private void btnChooseAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                picAvatar.Image = new Bitmap(open.FileName);
                // image file path
                lblFolderName.Visible = true;
                lblFolderName.Text = open.FileName;

            }
        }


        private void loadGender()
        {
            List<DTO_Gender> listGender = GenderDAL.Instance.GetAll();
            cboGender.DataSource = listGender;
        }

        private void loadRole()
        {
            List<DTO_Role> listRole = RoleDAL.Instance.GetRole();
            cboRole.DataSource = listRole;
        }
        #endregion

        #region Properties

        private DTO_Users _userProperties
        {
            get
            {

                _user.FullName = txtFullname.Text.Trim();
                _user.Email = txtEmail.Text.Trim();
                _user.Password = txtConfirmPassword.Text.Trim();
                _user.Address = txtAddress.Text.Trim();
                _user.Phonenumber = txtPhoneNumber.Text.Trim();
                _user.Gender = cboGender.Texts.Trim();
                _user.Avatar = handle.ConvertImageFromPictureBox(picAvatar);
                _user.Role = Convert.ToInt32(cboRole.ValueMember);
                _user.Dateofbird = dtpDateOfBird.Value;
                return _user;
            }
            set
            {

                _user = value;
                txtFullname.Text = value.FullName;
                txtEmail.Text = value.Email;
                txtPassword.Text = value.Password;
                txtAddress.Text = value.Address;
                txtPhoneNumber.Text = value.Phonenumber;
                picAvatar.Image = handle.ConverByteArrayToImage(value.Avatar);
                cboGender.ValueMember = value.Gender.ToString();
                cboRole.ValueMember = value.Role.ToString();
            }
        }

        void ResetValue()
        {
            this._userProperties = new DTO_Users();
            dtpDateOfBird.Value = DateTime.Now;
        }

        #endregion


        private void frmCreateUser_Load(object sender, EventArgs e)
        {
            //load gender text and auto select first item
            loadGender();
            cboGender.SelectedIndex = 0;
            loadRole();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isUpate)
            {
                if (UserDAL.Instance.Insert(this._userProperties)) { 
                    //MessageBox.Show
                    
                }
            }
        }
    }
}
