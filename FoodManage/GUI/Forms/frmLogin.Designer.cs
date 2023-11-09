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
            txtUsername = new Custom.TextboxCustom();
            txtPassword = new Custom.TextboxCustom();
            btnLogin = new Custom.ButtonRadius();
            label1 = new Label();
            pnlLogin = new Custom.PanelRadius();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            buttonRadius1 = new Custom.ButtonRadius();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Window;
            txtUsername.BoderFocusColor = Color.Transparent;
            txtUsername.BoderRadius = 20;
            txtUsername.BoderSize = 2;
            txtUsername.BorderColor = Color.Transparent;
            txtUsername.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.ForeColor = Color.DimGray;
            txtUsername.Location = new Point(59, 148);
            txtUsername.Multiline = false;
            txtUsername.Name = "txtUsername";
            txtUsername.Padding = new Padding(15, 7, 7, 7);
            txtUsername.PasswordChar = false;
            txtUsername.PlaceholderColor = Color.Gray;
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(301, 36);
            txtUsername.TabIndex = 0;
            txtUsername.UnderLineStyle = false;
            // 
            // txtPassword
            // 
            txtPassword.AutoSize = true;
            txtPassword.BackColor = Color.WhiteSmoke;
            txtPassword.BoderFocusColor = Color.Transparent;
            txtPassword.BoderRadius = 20;
            txtPassword.BoderSize = 2;
            txtPassword.BorderColor = Color.Transparent;
            txtPassword.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.DimGray;
            txtPassword.Location = new Point(59, 203);
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(15, 7, 7, 7);
            txtPassword.PasswordChar = false;
            txtPassword.PlaceholderColor = Color.Gray;
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(301, 36);
            txtPassword.TabIndex = 1;
            txtPassword.UnderLineStyle = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumSlateBlue;
            btnLogin.BackgroundColor = Color.MediumSlateBlue;
            btnLogin.BorderColor = Color.PaleVioletRed;
            btnLogin.BorderRadius = 20;
            btnLogin.BorderSize = 0;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Tahoma", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Honeydew;
            btnLogin.Location = new Point(59, 282);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(301, 47);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.TextColor = Color.Honeydew;
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
            pnlLogin.BorderColor = Color.White;
            pnlLogin.BorderRadius = 40;
            pnlLogin.BorderSize = 2;
            pnlLogin.colorBot = Color.Transparent;
            pnlLogin.colorTop = Color.Transparent;
            pnlLogin.Controls.Add(pictureBox3);
            pnlLogin.Controls.Add(pictureBox2);
            pnlLogin.Controls.Add(label2);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(txtUsername);
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.ForeColor = Color.White;
            pnlLogin.Location = new Point(248, 66);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(406, 395);
            pnlLogin.TabIndex = 3;
            pnlLogin.TextColor = Color.White;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(315, 208);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 28);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(315, 152);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(140, 38);
            label2.Name = "label2";
            label2.Size = new Size(131, 48);
            label2.TabIndex = 2;
            label2.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(900, 600);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // buttonRadius1
            // 
            buttonRadius1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonRadius1.BackColor = Color.Transparent;
            buttonRadius1.BackgroundColor = Color.Transparent;
            buttonRadius1.BorderColor = Color.Transparent;
            buttonRadius1.BorderRadius = 20;
            buttonRadius1.BorderSize = 0;
            buttonRadius1.FlatAppearance.BorderSize = 0;
            buttonRadius1.FlatStyle = FlatStyle.Flat;
            buttonRadius1.ForeColor = Color.White;
            buttonRadius1.Image = (Image)resources.GetObject("buttonRadius1.Image");
            buttonRadius1.Location = new Point(843, 11);
            buttonRadius1.Name = "buttonRadius1";
            buttonRadius1.Size = new Size(42, 34);
            buttonRadius1.TabIndex = 4;
            buttonRadius1.TextColor = Color.White;
            buttonRadius1.UseVisualStyleBackColor = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(900, 600);
            Controls.Add(buttonRadius1);
            Controls.Add(pnlLogin);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Custom.TextboxCustom txtUsername;
        private Custom.TextboxCustom txtPassword;
        private Custom.ButtonRadius btnLogin;
        private Label label1;
        private Custom.PanelRadius pnlLogin;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Custom.ButtonRadius buttonRadius1;
    }
}