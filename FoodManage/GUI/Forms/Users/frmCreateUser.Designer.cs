namespace FoodManage.GUI.Forms.Users
{
    partial class frmCreateUser
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateUser));
            pnlTop = new Panel();
            label1 = new Label();
            picMinimize = new PictureBox();
            picCloseForm = new PictureBox();
            txtFullname = new Custom.TextboxCustom();
            label2 = new Label();
            label3 = new Label();
            txtEmail = new Custom.TextboxCustom();
            label4 = new Label();
            txtPhoneNumber = new Custom.TextboxCustom();
            label5 = new Label();
            txtAddress = new Custom.TextboxCustom();
            label6 = new Label();
            txtPassword = new Custom.TextboxCustom();
            label7 = new Label();
            txtConfirmPassword = new Custom.TextboxCustom();
            label8 = new Label();
            btnChooseAvatar = new Custom.ButtonRadius();
            btnSave = new Custom.ButtonRadius();
            dtpDateOfBird = new Custom.DatimePickerCustom();
            label10 = new Label();
            cboRole = new Custom.ComboBoxCustom();
            dTORoleBindingSource = new BindingSource(components);
            dTOUsersBindingSource = new BindingSource(components);
            label9 = new Label();
            picAvatar = new Custom.PictureBoxCustom();
            cboGender = new Custom.ComboBoxCustom();
            lblFolderName = new Label();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCloseForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dTORoleBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dTOUsersBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(208, 27, 69);
            pnlTop.Controls.Add(label1);
            pnlTop.Controls.Add(picMinimize);
            pnlTop.Controls.Add(picCloseForm);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(816, 51);
            pnlTop.TabIndex = 1;
            pnlTop.MouseDown += pnlTop_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(233, 236, 239);
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(282, 34);
            label1.TabIndex = 700;
            label1.Text = "Create New User";
            // 
            // picMinimize
            // 
            picMinimize.Image = (Image)resources.GetObject("picMinimize.Image");
            picMinimize.Location = new Point(739, 9);
            picMinimize.Name = "picMinimize";
            picMinimize.Size = new Size(32, 32);
            picMinimize.TabIndex = 1;
            picMinimize.TabStop = false;
            picMinimize.Click += picMinimize_Click;
            // 
            // picCloseForm
            // 
            picCloseForm.Image = (Image)resources.GetObject("picCloseForm.Image");
            picCloseForm.Location = new Point(772, 9);
            picCloseForm.Name = "picCloseForm";
            picCloseForm.Size = new Size(32, 32);
            picCloseForm.TabIndex = 0;
            picCloseForm.TabStop = false;
            picCloseForm.Click += picCloseForm_Click;
            // 
            // txtFullname
            // 
            txtFullname.BackColor = SystemColors.Window;
            txtFullname.BoderFocusColor = Color.FromArgb(153, 137, 147);
            txtFullname.BoderRadius = 0;
            txtFullname.BoderSize = 2;
            txtFullname.BorderColor = Color.FromArgb(227, 230, 233);
            txtFullname.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtFullname.Location = new Point(62, 102);
            txtFullname.Multiline = false;
            txtFullname.Name = "txtFullname";
            txtFullname.Padding = new Padding(7);
            txtFullname.PasswordChar = false;
            txtFullname.PlaceholderColor = Color.DarkGray;
            txtFullname.PlaceholderText = "";
            txtFullname.Size = new Size(312, 35);
            txtFullname.TabIndex = 1;
            txtFullname.UnderLineStyle = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(153, 137, 147);
            label2.Location = new Point(67, 84);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 100;
            label2.Text = "Full name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(153, 137, 147);
            label3.Location = new Point(67, 158);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 101;
            label3.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.Window;
            txtEmail.BoderFocusColor = Color.FromArgb(153, 137, 147);
            txtEmail.BoderRadius = 0;
            txtEmail.BoderSize = 2;
            txtEmail.BorderColor = Color.FromArgb(227, 230, 233);
            txtEmail.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(62, 176);
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(7);
            txtEmail.PasswordChar = false;
            txtEmail.PlaceholderColor = Color.DarkGray;
            txtEmail.PlaceholderText = "";
            txtEmail.Size = new Size(312, 35);
            txtEmail.TabIndex = 2;
            txtEmail.UnderLineStyle = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(153, 137, 147);
            label4.Location = new Point(67, 232);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 101;
            label4.Text = "Phone number";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = SystemColors.Window;
            txtPhoneNumber.BoderFocusColor = Color.FromArgb(153, 137, 147);
            txtPhoneNumber.BoderRadius = 0;
            txtPhoneNumber.BoderSize = 2;
            txtPhoneNumber.BorderColor = Color.FromArgb(227, 230, 233);
            txtPhoneNumber.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhoneNumber.Location = new Point(62, 250);
            txtPhoneNumber.Multiline = false;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Padding = new Padding(7);
            txtPhoneNumber.PasswordChar = false;
            txtPhoneNumber.PlaceholderColor = Color.DarkGray;
            txtPhoneNumber.PlaceholderText = "";
            txtPhoneNumber.Size = new Size(312, 35);
            txtPhoneNumber.TabIndex = 3;
            txtPhoneNumber.UnderLineStyle = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(153, 137, 147);
            label5.Location = new Point(67, 304);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 103;
            label5.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = SystemColors.Window;
            txtAddress.BoderFocusColor = Color.FromArgb(153, 137, 147);
            txtAddress.BoderRadius = 0;
            txtAddress.BoderSize = 2;
            txtAddress.BorderColor = Color.FromArgb(227, 230, 233);
            txtAddress.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(62, 322);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Padding = new Padding(7);
            txtAddress.PasswordChar = false;
            txtAddress.PlaceholderColor = Color.DarkGray;
            txtAddress.PlaceholderText = "";
            txtAddress.Size = new Size(312, 88);
            txtAddress.TabIndex = 4;
            txtAddress.UnderLineStyle = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(153, 137, 147);
            label6.Location = new Point(67, 429);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 105;
            label6.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Window;
            txtPassword.BoderFocusColor = Color.FromArgb(153, 137, 147);
            txtPassword.BoderRadius = 0;
            txtPassword.BoderSize = 2;
            txtPassword.BorderColor = Color.FromArgb(227, 230, 233);
            txtPassword.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(62, 447);
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(7);
            txtPassword.PasswordChar = true;
            txtPassword.PlaceholderColor = Color.DarkGray;
            txtPassword.PlaceholderText = "";
            txtPassword.Size = new Size(312, 35);
            txtPassword.TabIndex = 5;
            txtPassword.UnderLineStyle = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(153, 137, 147);
            label7.Location = new Point(67, 495);
            label7.Name = "label7";
            label7.Size = new Size(164, 20);
            label7.TabIndex = 107;
            label7.Text = "Confirm password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = SystemColors.Window;
            txtConfirmPassword.BoderFocusColor = Color.FromArgb(153, 137, 147);
            txtConfirmPassword.BoderRadius = 0;
            txtConfirmPassword.BoderSize = 2;
            txtConfirmPassword.BorderColor = Color.FromArgb(227, 230, 233);
            txtConfirmPassword.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmPassword.Location = new Point(62, 513);
            txtConfirmPassword.Multiline = false;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Padding = new Padding(7);
            txtConfirmPassword.PasswordChar = true;
            txtConfirmPassword.PlaceholderColor = Color.DarkGray;
            txtConfirmPassword.PlaceholderText = "";
            txtConfirmPassword.Size = new Size(312, 35);
            txtConfirmPassword.TabIndex = 6;
            txtConfirmPassword.UnderLineStyle = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(153, 137, 147);
            label8.Location = new Point(434, 84);
            label8.Name = "label8";
            label8.Size = new Size(71, 20);
            label8.TabIndex = 109;
            label8.Text = "Gender";
            // 
            // btnChooseAvatar
            // 
            btnChooseAvatar.BackColor = Color.SkyBlue;
            btnChooseAvatar.BackgroundColor = Color.SkyBlue;
            btnChooseAvatar.BorderColor = Color.PaleVioletRed;
            btnChooseAvatar.BorderRadius = 10;
            btnChooseAvatar.BorderSize = 0;
            btnChooseAvatar.FlatAppearance.BorderSize = 0;
            btnChooseAvatar.FlatStyle = FlatStyle.Flat;
            btnChooseAvatar.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnChooseAvatar.ForeColor = Color.White;
            btnChooseAvatar.Location = new Point(429, 232);
            btnChooseAvatar.Name = "btnChooseAvatar";
            btnChooseAvatar.Size = new Size(100, 53);
            btnChooseAvatar.TabIndex = 9;
            btnChooseAvatar.Text = "Choose Image";
            btnChooseAvatar.TextColor = Color.White;
            btnChooseAvatar.UseVisualStyleBackColor = false;
            btnChooseAvatar.Click += btnChooseAvatar_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 123, 255);
            btnSave.BackgroundColor = Color.FromArgb(0, 123, 255);
            btnSave.BorderColor = Color.PaleVioletRed;
            btnSave.BorderRadius = 10;
            btnSave.BorderSize = 0;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(429, 513);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(315, 57);
            btnSave.TabIndex = 12;
            btnSave.Text = "CREATE";
            btnSave.TextColor = Color.White;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dtpDateOfBird
            // 
            dtpDateOfBird.BorderColor = Color.FromArgb(227, 230, 233);
            dtpDateOfBird.BorderSize = 2;
            dtpDateOfBird.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDateOfBird.Location = new Point(429, 447);
            dtpDateOfBird.MinimumSize = new Size(0, 35);
            dtpDateOfBird.Name = "dtpDateOfBird";
            dtpDateOfBird.Size = new Size(312, 35);
            dtpDateOfBird.SkinColor = Color.Transparent;
            dtpDateOfBird.TabIndex = 10;
            dtpDateOfBird.TextColor = Color.White;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(153, 137, 147);
            label10.Location = new Point(436, 430);
            label10.Name = "label10";
            label10.Size = new Size(111, 20);
            label10.TabIndex = 209;
            label10.Text = "Date of bird";
            // 
            // cboRole
            // 
            cboRole.BackColor = SystemColors.Window;
            cboRole.BorderColor = Color.FromArgb(227, 230, 233);
            cboRole.BorderSize = 2;
            cboRole.DataSource = dTORoleBindingSource;
            cboRole.DisplayMember = "Name";
            cboRole.DropDownStyle = ComboBoxStyle.DropDown;
            cboRole.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboRole.ForeColor = Color.DimGray;
            cboRole.IconColor = Color.FromArgb(227, 230, 233);
            cboRole.ListBackColor = Color.FromArgb(230, 228, 245);
            cboRole.ListTextColor = Color.DimGray;
            cboRole.Location = new Point(429, 173);
            cboRole.MinimumSize = new Size(200, 30);
            cboRole.Name = "cboRole";
            cboRole.Padding = new Padding(2);
            cboRole.Size = new Size(312, 38);
            cboRole.TabIndex = 8;
            cboRole.Texts = "";
            cboRole.ValueMember = "Id";
            // 
            // dTORoleBindingSource
            // 
            dTORoleBindingSource.DataSource = typeof(DTO.DTO_Role);
            // 
            // dTOUsersBindingSource
            // 
            dTOUsersBindingSource.DataSource = typeof(DTO.DTO_Users);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(153, 137, 147);
            label9.Location = new Point(436, 158);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 208;
            label9.Text = "Role";
            // 
            // picAvatar
            // 
            picAvatar.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            picAvatar.BorderColor = Color.RoyalBlue;
            picAvatar.BorderColor2 = Color.HotPink;
            picAvatar.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            picAvatar.BorderSize = 2;
            picAvatar.GradientAngle = 50F;
            picAvatar.Location = new Point(545, 232);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(196, 196);
            picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            picAvatar.TabIndex = 30;
            picAvatar.TabStop = false;
            // 
            // cboGender
            // 
            cboGender.BackColor = SystemColors.Window;
            cboGender.BorderColor = Color.FromArgb(227, 230, 233);
            cboGender.BorderSize = 2;
            cboGender.DisplayMember = "Name";
            cboGender.DropDownStyle = ComboBoxStyle.DropDown;
            cboGender.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboGender.ForeColor = Color.DimGray;
            cboGender.IconColor = Color.FromArgb(227, 230, 233);
            cboGender.ListBackColor = Color.FromArgb(230, 228, 245);
            cboGender.ListTextColor = Color.DimGray;
            cboGender.Location = new Point(429, 99);
            cboGender.MinimumSize = new Size(200, 30);
            cboGender.Name = "cboGender";
            cboGender.Padding = new Padding(2);
            cboGender.Size = new Size(312, 38);
            cboGender.TabIndex = 7;
            cboGender.Texts = "";
            cboGender.ValueMember = "Id";
            // 
            // lblFolderName
            // 
            lblFolderName.AutoSize = true;
            lblFolderName.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblFolderName.ForeColor = Color.FromArgb(153, 146, 152);
            lblFolderName.Location = new Point(429, 392);
            lblFolderName.Name = "lblFolderName";
            lblFolderName.Size = new Size(97, 18);
            lblFolderName.TabIndex = 210;
            lblFolderName.Text = "folder name";
            lblFolderName.Visible = false;
            // 
            // frmCreateUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(816, 597);
            Controls.Add(lblFolderName);
            Controls.Add(label8);
            Controls.Add(picAvatar);
            Controls.Add(label9);
            Controls.Add(cboGender);
            Controls.Add(cboRole);
            Controls.Add(label10);
            Controls.Add(dtpDateOfBird);
            Controls.Add(btnSave);
            Controls.Add(btnChooseAvatar);
            Controls.Add(label7);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label6);
            Controls.Add(txtPassword);
            Controls.Add(label5);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtFullname);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCreateUser";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create";
            Load += frmCreateUser_Load;
            MouseDown += frmCreateUser_MouseDown;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCloseForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)dTORoleBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dTOUsersBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlTop;
        private PictureBox picMinimize;
        private PictureBox picCloseForm;
        private Label label1;
        private Custom.TextboxCustom txtFullname;
        private Label label2;
        private Label label3;
        private Custom.TextboxCustom txtEmail;
        private Label label4;
        private Custom.TextboxCustom txtPhoneNumber;
        private Label label5;
        private Custom.TextboxCustom txtAddress;
        private Label label6;
        private Custom.TextboxCustom txtPassword;
        private Label label7;
        private Custom.TextboxCustom txtConfirmPassword;
        private Label label8;
        private Custom.ButtonRadius btnChooseAvatar;
        private Custom.ButtonRadius btnSave;
        private Custom.DatimePickerCustom dtpDateOfBird;
        private Label label10;
        private Custom.ComboBoxCustom cboRole;
        private Label label9;
        private Custom.PictureBoxCustom picAvatar;
        private Custom.ComboBoxCustom cboGender;
        private BindingSource dTOUsersBindingSource;
        private BindingSource dTORoleBindingSource;
        private Label lblFolderName;
    }
}