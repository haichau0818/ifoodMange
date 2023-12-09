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

namespace FoodManage.GUI.Forms.AlertBox
{
    public partial class frmMessageBox : Form
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
        public frmMessageBox()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }

        public Color ColorMessage
        {
            get { return pnlMessageColor.BackColor; }
            set { pnlMessageColor.BackColor = btnOk.BackColor = btnCancel.ForeColor = value; }
        }
        public string MessageContent
        {
            get { return lblMessageText.Text; }
            set { lblMessageText.Text = value; }
        }

        public string MessageTitle
        {
            get { return lblTitleMessage.Text; }
            set { lblTitleMessage.Text = value; }
        }
        public Image IconsMessage
        {
            get { return picIconsMessage.Image; }
            set { picIconsMessage.Image = value; }
        }
        private void picCloseMessage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }
    }
}
