namespace FoodManage.GUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            pnlHeader = new Panel();
            panelRadius1 = new Custom.PanelRadius();
            picAvatar = new Custom.PictureBoxCustom();
            lblUserInfor = new Label();
            btnMinimize = new Custom.ButtonRadius();
            btnClose = new Custom.ButtonRadius();
            pnlUser = new Custom.PanelRadius();
            buttonRadius4 = new Custom.ButtonRadius();
            buttonRadius3 = new Custom.ButtonRadius();
            buttonRadius2 = new Custom.ButtonRadius();
            pnlMenu = new Panel();
            btnUser = new Custom.ButtonRadius();
            btnTable = new Custom.ButtonRadius();
            btnFood = new Custom.ButtonRadius();
            btnHome = new Custom.ButtonRadius();
            pnlPadingRight = new Panel();
            pnlPadingLeft = new Panel();
            pnlLogo = new Panel();
            pictureBox1 = new PictureBox();
            pnlContent = new Custom.PanelRadius();
            panel1 = new Panel();
            panel2 = new Panel();
            pnlHeader.SuspendLayout();
            panelRadius1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            pnlUser.SuspendLayout();
            pnlMenu.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(panelRadius1);
            pnlHeader.Controls.Add(btnMinimize);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(207, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1178, 119);
            pnlHeader.TabIndex = 1;
            // 
            // panelRadius1
            // 
            panelRadius1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelRadius1.BackColor = Color.FromArgb(48, 40, 53);
            panelRadius1.BackgroundColor = Color.FromArgb(48, 40, 53);
            panelRadius1.BorderColor = Color.PaleVioletRed;
            panelRadius1.BorderRadius = 20;
            panelRadius1.BorderSize = 0;
            panelRadius1.colorBot = Color.Empty;
            panelRadius1.colorTop = Color.Empty;
            panelRadius1.Controls.Add(picAvatar);
            panelRadius1.Controls.Add(lblUserInfor);
            panelRadius1.ForeColor = Color.White;
            panelRadius1.Location = new Point(938, 37);
            panelRadius1.Name = "panelRadius1";
            panelRadius1.Size = new Size(220, 76);
            panelRadius1.TabIndex = 5;
            panelRadius1.TextColor = Color.White;
            // 
            // picAvatar
            // 
            picAvatar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picAvatar.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            picAvatar.BorderColor = Color.RoyalBlue;
            picAvatar.BorderColor2 = Color.HotPink;
            picAvatar.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            picAvatar.BorderSize = 2;
            picAvatar.GradientAngle = 50F;
            picAvatar.Location = new Point(18, 8);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(62, 62);
            picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            picAvatar.TabIndex = 2;
            picAvatar.TabStop = false;
            // 
            // lblUserInfor
            // 
            lblUserInfor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUserInfor.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserInfor.ForeColor = SystemColors.Control;
            lblUserInfor.ImageAlign = ContentAlignment.TopLeft;
            lblUserInfor.Location = new Point(88, 14);
            lblUserInfor.Name = "lblUserInfor";
            lblUserInfor.Size = new Size(119, 56);
            lblUserInfor.TabIndex = 3;
            lblUserInfor.Text = "Name";
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.BackgroundColor = Color.Transparent;
            btnMinimize.BorderColor = Color.PaleVioletRed;
            btnMinimize.BorderRadius = 20;
            btnMinimize.BorderSize = 0;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new Point(1087, 2);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(42, 36);
            btnMinimize.TabIndex = 0;
            btnMinimize.TextColor = Color.White;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            btnMinimize.MouseLeave += btnMinimize_MouseLeave;
            btnMinimize.MouseMove += btnMinimize_MouseMove;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundColor = Color.Transparent;
            btnClose.BorderColor = Color.PaleVioletRed;
            btnClose.BorderRadius = 20;
            btnClose.BorderSize = 0;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(1135, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(42, 36);
            btnClose.TabIndex = 0;
            btnClose.TextColor = Color.White;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            btnClose.MouseLeave += btnClose_MouseLeave;
            btnClose.MouseMove += btnClose_MouseMove;
            // 
            // pnlUser
            // 
            pnlUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlUser.BackColor = Color.FromArgb(48, 40, 53);
            pnlUser.BackgroundColor = Color.FromArgb(48, 40, 53);
            pnlUser.BorderColor = Color.PaleVioletRed;
            pnlUser.BorderRadius = 20;
            pnlUser.BorderSize = 0;
            pnlUser.colorBot = Color.Empty;
            pnlUser.colorTop = Color.Empty;
            pnlUser.Controls.Add(buttonRadius4);
            pnlUser.Controls.Add(buttonRadius3);
            pnlUser.Controls.Add(buttonRadius2);
            pnlUser.ForeColor = Color.White;
            pnlUser.Location = new Point(835, 0);
            pnlUser.Name = "pnlUser";
            pnlUser.Size = new Size(322, 180);
            pnlUser.TabIndex = 3;
            pnlUser.TextColor = Color.White;
            pnlUser.Visible = false;
            // 
            // buttonRadius4
            // 
            buttonRadius4.BackColor = Color.Transparent;
            buttonRadius4.BackgroundColor = Color.Transparent;
            buttonRadius4.BorderColor = Color.PaleVioletRed;
            buttonRadius4.BorderRadius = 20;
            buttonRadius4.BorderSize = 0;
            buttonRadius4.FlatAppearance.BorderSize = 0;
            buttonRadius4.FlatStyle = FlatStyle.Flat;
            buttonRadius4.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRadius4.ForeColor = Color.White;
            buttonRadius4.Image = (Image)resources.GetObject("buttonRadius4.Image");
            buttonRadius4.ImageAlign = ContentAlignment.TopCenter;
            buttonRadius4.Location = new Point(208, 22);
            buttonRadius4.Name = "buttonRadius4";
            buttonRadius4.Size = new Size(89, 133);
            buttonRadius4.TabIndex = 1;
            buttonRadius4.Text = "Log Out";
            buttonRadius4.TextColor = Color.White;
            buttonRadius4.UseVisualStyleBackColor = false;
            // 
            // buttonRadius3
            // 
            buttonRadius3.BackColor = Color.Transparent;
            buttonRadius3.BackgroundColor = Color.Transparent;
            buttonRadius3.BorderColor = Color.PaleVioletRed;
            buttonRadius3.BorderRadius = 20;
            buttonRadius3.BorderSize = 0;
            buttonRadius3.FlatAppearance.BorderSize = 0;
            buttonRadius3.FlatStyle = FlatStyle.Flat;
            buttonRadius3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRadius3.ForeColor = Color.White;
            buttonRadius3.Image = (Image)resources.GetObject("buttonRadius3.Image");
            buttonRadius3.ImageAlign = ContentAlignment.TopCenter;
            buttonRadius3.Location = new Point(113, 22);
            buttonRadius3.Name = "buttonRadius3";
            buttonRadius3.Size = new Size(89, 133);
            buttonRadius3.TabIndex = 0;
            buttonRadius3.Text = "Sign Up";
            buttonRadius3.TextColor = Color.White;
            buttonRadius3.UseVisualStyleBackColor = false;
            // 
            // buttonRadius2
            // 
            buttonRadius2.BackColor = Color.Transparent;
            buttonRadius2.BackgroundColor = Color.Transparent;
            buttonRadius2.BorderColor = Color.PaleVioletRed;
            buttonRadius2.BorderRadius = 20;
            buttonRadius2.BorderSize = 0;
            buttonRadius2.FlatAppearance.BorderSize = 0;
            buttonRadius2.FlatStyle = FlatStyle.Flat;
            buttonRadius2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRadius2.ForeColor = Color.White;
            buttonRadius2.Image = (Image)resources.GetObject("buttonRadius2.Image");
            buttonRadius2.ImageAlign = ContentAlignment.TopCenter;
            buttonRadius2.Location = new Point(18, 22);
            buttonRadius2.Name = "buttonRadius2";
            buttonRadius2.Size = new Size(89, 133);
            buttonRadius2.TabIndex = 0;
            buttonRadius2.Text = "Change Password";
            buttonRadius2.TextColor = Color.White;
            buttonRadius2.UseVisualStyleBackColor = false;
            // 
            // pnlMenu
            // 
            pnlMenu.Controls.Add(btnUser);
            pnlMenu.Controls.Add(btnTable);
            pnlMenu.Controls.Add(btnFood);
            pnlMenu.Controls.Add(btnHome);
            pnlMenu.Controls.Add(pnlPadingRight);
            pnlMenu.Controls.Add(pnlPadingLeft);
            pnlMenu.Controls.Add(pnlLogo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(207, 753);
            pnlMenu.TabIndex = 2;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.Transparent;
            btnUser.BackgroundColor = Color.Transparent;
            btnUser.BorderColor = Color.PaleVioletRed;
            btnUser.BorderRadius = 20;
            btnUser.BorderSize = 0;
            btnUser.Dock = DockStyle.Top;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUser.ForeColor = Color.White;
            btnUser.Image = (Image)resources.GetObject("btnUser.Image");
            btnUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnUser.Location = new Point(10, 360);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(187, 65);
            btnUser.TabIndex = 9;
            btnUser.Text = "              Manage User";
            btnUser.TextAlign = ContentAlignment.MiddleLeft;
            btnUser.TextColor = Color.White;
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += btnUser_Click;
            btnUser.MouseLeave += btnUser_MouseLeave;
            btnUser.MouseMove += btnUser_MouseMove;
            // 
            // btnTable
            // 
            btnTable.BackColor = Color.Transparent;
            btnTable.BackgroundColor = Color.Transparent;
            btnTable.BorderColor = Color.PaleVioletRed;
            btnTable.BorderRadius = 20;
            btnTable.BorderSize = 0;
            btnTable.Dock = DockStyle.Top;
            btnTable.FlatAppearance.BorderSize = 0;
            btnTable.FlatStyle = FlatStyle.Flat;
            btnTable.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTable.ForeColor = Color.White;
            btnTable.Image = (Image)resources.GetObject("btnTable.Image");
            btnTable.ImageAlign = ContentAlignment.MiddleLeft;
            btnTable.Location = new Point(10, 295);
            btnTable.Name = "btnTable";
            btnTable.Size = new Size(187, 65);
            btnTable.TabIndex = 5;
            btnTable.Text = "              Table";
            btnTable.TextAlign = ContentAlignment.MiddleLeft;
            btnTable.TextColor = Color.White;
            btnTable.UseVisualStyleBackColor = false;
            btnTable.MouseLeave += btnTable_MouseLeave;
            btnTable.MouseMove += btnTable_MouseMove;
            // 
            // btnFood
            // 
            btnFood.BackColor = Color.Transparent;
            btnFood.BackgroundColor = Color.Transparent;
            btnFood.BorderColor = Color.PaleVioletRed;
            btnFood.BorderRadius = 20;
            btnFood.BorderSize = 0;
            btnFood.Dock = DockStyle.Top;
            btnFood.FlatAppearance.BorderSize = 0;
            btnFood.FlatStyle = FlatStyle.Flat;
            btnFood.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFood.ForeColor = Color.White;
            btnFood.Image = (Image)resources.GetObject("btnFood.Image");
            btnFood.ImageAlign = ContentAlignment.MiddleLeft;
            btnFood.Location = new Point(10, 230);
            btnFood.Name = "btnFood";
            btnFood.Size = new Size(187, 65);
            btnFood.TabIndex = 4;
            btnFood.Text = "              Food";
            btnFood.TextAlign = ContentAlignment.MiddleLeft;
            btnFood.TextColor = Color.White;
            btnFood.UseVisualStyleBackColor = false;
            btnFood.Click += btnFood_Click;
            btnFood.MouseLeave += btnFood_MouseLeave;
            btnFood.MouseMove += btnFood_MouseMove;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Transparent;
            btnHome.BackgroundColor = Color.Transparent;
            btnHome.BorderColor = Color.PaleVioletRed;
            btnHome.BorderRadius = 20;
            btnHome.BorderSize = 0;
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(10, 165);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(187, 65);
            btnHome.TabIndex = 3;
            btnHome.Text = "              Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextColor = Color.White;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            btnHome.MouseLeave += btnHome_MouseLeave;
            btnHome.MouseMove += btnHome_MouseMove;
            // 
            // pnlPadingRight
            // 
            pnlPadingRight.Dock = DockStyle.Right;
            pnlPadingRight.Location = new Point(197, 165);
            pnlPadingRight.Name = "pnlPadingRight";
            pnlPadingRight.Size = new Size(10, 588);
            pnlPadingRight.TabIndex = 8;
            // 
            // pnlPadingLeft
            // 
            pnlPadingLeft.Dock = DockStyle.Left;
            pnlPadingLeft.Location = new Point(0, 165);
            pnlPadingLeft.Name = "pnlPadingLeft";
            pnlPadingLeft.Size = new Size(10, 588);
            pnlPadingLeft.TabIndex = 7;
            // 
            // pnlLogo
            // 
            pnlLogo.Controls.Add(pictureBox1);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(207, 165);
            pnlLogo.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.Transparent;
            pnlContent.BackgroundColor = Color.Transparent;
            pnlContent.BorderColor = Color.PaleVioletRed;
            pnlContent.BorderRadius = 40;
            pnlContent.BorderSize = 0;
            pnlContent.colorBot = Color.Empty;
            pnlContent.colorTop = Color.Empty;
            pnlContent.Controls.Add(pnlUser);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.ForeColor = Color.White;
            pnlContent.Location = new Point(207, 119);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1158, 614);
            pnlContent.TabIndex = 4;
            pnlContent.TextColor = Color.White;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(207, 733);
            panel1.Name = "panel1";
            panel1.Size = new Size(1178, 20);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1365, 119);
            panel2.Name = "panel2";
            panel2.Size = new Size(20, 614);
            panel2.TabIndex = 6;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 24, 35);
            ClientSize = new Size(1385, 753);
            Controls.Add(pnlContent);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlHeader);
            Controls.Add(pnlMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMain";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Food Manage";
            WindowState = FormWindowState.Maximized;
            FormClosed += frmMain_FormClosed;
            Load += frmMain_Load;
            pnlHeader.ResumeLayout(false);
            panelRadius1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            pnlUser.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlHeader;
        private Panel pnlMenu;
        private Panel pnlLogo;
        private PictureBox pictureBox1;
        private Custom.ButtonRadius btnHome;
        private Custom.ButtonRadius btnTable;
        private Custom.ButtonRadius btnFood;
        private Custom.ButtonRadius btnMinimize;
        private Custom.ButtonRadius btnClose;
        private Custom.PanelRadius pnlUser;
        private Custom.ButtonRadius buttonRadius3;
        private Custom.ButtonRadius buttonRadius2;
        private Custom.PanelRadius pnlContent;
        private Panel pnlPadingRight;
        private Panel pnlPadingLeft;
        private Custom.ButtonRadius buttonRadius4;
        private Custom.ButtonRadius btnUser;
        private Panel panel1;
        private Panel panel2;
        private Custom.PictureBoxCustom picAvatar;
        private Label lblUserInfor;
        private Custom.PanelRadius panelRadius1;
    }
}