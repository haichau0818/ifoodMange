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
    public partial class frmAlert : Form
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
        public frmAlert()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }

        public Color BackgroundColorAlert
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }
        public Color ColorAlert
        {
            get { return pnlProgress.BackColor; }
            set { pnlProgress.BackColor = lblTitle.ForeColor = lblContentAlert.ForeColor = value; }
        }
        public Image IconsAlert
        {
            get { return picAlert.Image; }
            set { picAlert.Image = value; }
        }
        public string TitleAlert
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }
        public string ContentAlert
        {
            get { return lblContentAlert.Text; }
            set { lblContentAlert.Text = value; }
        }
        private void PositionAlert()
        {
            int xPos = 0;
            int yPos = 0;
            xPos = Screen.GetWorkingArea(this).Width;
            yPos = Screen.GetWorkingArea(this).Height;
            this.Location = new Point(xPos - this.Width, yPos - this.Height);

        }

        private void frmAlert_Load(object sender, EventArgs e)
        {
            PositionAlert();
            for (int i = 0; i < 500; i++)
            {
                timerAnimation.Start();
            }
        }

        private void timerAnimation_Tick(object sender, EventArgs e)
        {
            pnlProgress.Width = pnlProgress.Width + 4;
            if (pnlProgress.Width >= 500)
                this.Close();
        }
    }
}
