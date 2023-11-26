namespace FoodManage.GUI.Forms
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            btnLogin = new Custom.ButtonRadius();
            label1 = new Label();
            pnlLogin = new Custom.PanelRadius();
            txtPassword = new Custom.TextboxCustom();
            txtUsername = new Custom.TextboxCustom();
            ckdRemember = new CheckBox();
            lblMessageEr = new Label();
            label2 = new Label();
            picMinimize = new PictureBox();
            picClose = new PictureBox();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.White;
            btnLogin.BackgroundColor = Color.White;
            btnLogin.BorderColor = Color.PaleVioletRed;
            btnLogin.BorderRadius = 10;
            btnLogin.BorderSize = 0;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.MediumSlateBlue;
            btnLogin.Location = new Point(59, 282);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(301, 47);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.TextColor = Color.MediumSlateBlue;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 66);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 2;
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.Transparent;
            pnlLogin.BackgroundColor = Color.Transparent;
            pnlLogin.BorderColor = Color.Transparent;
            pnlLogin.BorderRadius = 40;
            pnlLogin.BorderSize = 0;
            pnlLogin.colorBot = Color.Transparent;
            pnlLogin.colorTop = Color.FromArgb(184, 185, 209);
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Controls.Add(txtUsername);
            pnlLogin.Controls.Add(ckdRemember);
            pnlLogin.Controls.Add(lblMessageEr);
            pnlLogin.Controls.Add(label2);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.ForeColor = Color.Transparent;
            pnlLogin.Location = new Point(245, 78);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(406, 395);
            pnlLogin.TabIndex = 10;
            pnlLogin.TextColor = Color.Transparent;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Window;
            txtPassword.BoderFocusColor = Color.Transparent;
            txtPassword.BoderRadius = 10;
            txtPassword.BoderSize = 0;
            txtPassword.BorderColor = Color.Transparent;
            txtPassword.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(60, 201);
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(7);
            txtPassword.PasswordChar = true;
            txtPassword.PlaceholderColor = Color.DarkGray;
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(301, 35);
            txtPassword.TabIndex = 2;
            txtPassword.UnderLineStyle = false;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Window;
            txtUsername.BoderFocusColor = Color.Transparent;
            txtUsername.BoderRadius = 10;
            txtUsername.BoderSize = 0;
            txtUsername.BorderColor = Color.Transparent;
            txtUsername.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(60, 149);
            txtUsername.Multiline = false;
            txtUsername.Name = "txtUsername";
            txtUsername.Padding = new Padding(7);
            txtUsername.PasswordChar = false;
            txtUsername.PlaceholderColor = Color.DarkGray;
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(301, 35);
            txtUsername.TabIndex = 1;
            txtUsername.UnderLineStyle = false;
            // 
            // ckdRemember
            // 
            ckdRemember.AutoSize = true;
            ckdRemember.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ckdRemember.Location = new Point(60, 248);
            ckdRemember.Name = "ckdRemember";
            ckdRemember.Size = new Size(141, 22);
            ckdRemember.TabIndex = 3;
            ckdRemember.Text = "Remember me";
            ckdRemember.UseVisualStyleBackColor = true;
            // 
            // lblMessageEr
            // 
            lblMessageEr.AutoSize = true;
            lblMessageEr.ForeColor = Color.Red;
            lblMessageEr.Location = new Point(59, 114);
            lblMessageEr.Name = "lblMessageEr";
            lblMessageEr.Size = new Size(45, 20);
            lblMessageEr.TabIndex = 12;
            lblMessageEr.Text = "Erorr!";
            lblMessageEr.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumSlateBlue;
            label2.Location = new Point(125, 49);
            label2.Name = "label2";
            label2.Size = new Size(165, 48);
            label2.TabIndex = 11;
            label2.Text = "Sign In";
            // 
            // picMinimize
            // 
            picMinimize.BackColor = Color.Transparent;
            picMinimize.Image = (Image)resources.GetObject("picMinimize.Image");
            picMinimize.Location = new Point(821, 12);
            picMinimize.Name = "picMinimize";
            picMinimize.Size = new Size(32, 32);
            picMinimize.SizeMode = PictureBoxSizeMode.StretchImage;
            picMinimize.TabIndex = 3;
            picMinimize.TabStop = false;
            picMinimize.Click += picMinimize_Click;
            // 
            // picClose
            // 
            picClose.BackColor = Color.Transparent;
            picClose.Image = (Image)resources.GetObject("picClose.Image");
            picClose.Location = new Point(856, 12);
            picClose.Name = "picClose";
            picClose.Size = new Size(32, 32);
            picClose.SizeMode = PictureBoxSizeMode.StretchImage;
            picClose.TabIndex = 4;
            picClose.TabStop = false;
            picClose.Click += picClose_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 600);
            Controls.Add(picClose);
            Controls.Add(picMinimize);
            Controls.Add(pnlLogin);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            Load += frmLogin_Load;
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Custom.ButtonRadius btnLogin;
        private Label label1;
        private Custom.PanelRadius pnlLogin;
        private Label label2;
        private PictureBox picMinimize;
        private PictureBox picClose;
        private Label lblMessageEr;
        private Panel pnlRemember;
        private Custom.ToggleButton ckbRemember;
        private Label lblRemember;
        private CheckBox ckdRemember;
        private Custom.TextboxCustom txtPassword;
        private Custom.TextboxCustom txtUsername;

    }
}