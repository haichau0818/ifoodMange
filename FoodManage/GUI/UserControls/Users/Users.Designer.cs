namespace FoodManage.GUI.UserControls.Users
{
    partial class uUsers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelRadius1 = new Custom.PanelRadius();
            btnExportExcel = new Custom.ButtonRadius();
            btnAddUser = new Custom.ButtonRadius();
            panelRadius2 = new Custom.PanelRadius();
            dtgvListUser = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phonenumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateofbirdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            avatarDataGridViewImageColumn = new DataGridViewImageColumn();
            dTOUsersBindingSource = new BindingSource(components);
            panelRadius1.SuspendLayout();
            panelRadius2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvListUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dTOUsersBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panelRadius1
            // 
            panelRadius1.BackColor = Color.FromArgb(22, 24, 35);
            panelRadius1.BackgroundColor = Color.FromArgb(22, 24, 35);
            panelRadius1.BorderColor = Color.PaleVioletRed;
            panelRadius1.BorderRadius = 40;
            panelRadius1.BorderSize = 0;
            panelRadius1.colorBot = Color.Empty;
            panelRadius1.colorTop = Color.Empty;
            panelRadius1.Controls.Add(btnExportExcel);
            panelRadius1.Controls.Add(btnAddUser);
            panelRadius1.Dock = DockStyle.Top;
            panelRadius1.ForeColor = Color.White;
            panelRadius1.Location = new Point(0, 0);
            panelRadius1.Name = "panelRadius1";
            panelRadius1.Size = new Size(1150, 99);
            panelRadius1.TabIndex = 0;
            panelRadius1.TextColor = Color.White;
            // 
            // btnExportExcel
            // 
            btnExportExcel.BackColor = Color.Transparent;
            btnExportExcel.BackgroundColor = Color.Transparent;
            btnExportExcel.BorderColor = Color.FromArgb(233, 236, 239);
            btnExportExcel.BorderRadius = 20;
            btnExportExcel.BorderSize = 2;
            btnExportExcel.FlatAppearance.BorderSize = 0;
            btnExportExcel.FlatStyle = FlatStyle.Flat;
            btnExportExcel.ForeColor = Color.White;
            btnExportExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportExcel.Location = new Point(214, 23);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(180, 50);
            btnExportExcel.TabIndex = 0;
            btnExportExcel.Text = "Export excel";
            btnExportExcel.TextColor = Color.White;
            btnExportExcel.UseVisualStyleBackColor = false;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.Transparent;
            btnAddUser.BackgroundColor = Color.Transparent;
            btnAddUser.BorderColor = Color.FromArgb(233, 236, 239);
            btnAddUser.BorderRadius = 20;
            btnAddUser.BorderSize = 2;
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.ForeColor = Color.White;
            btnAddUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddUser.Location = new Point(28, 23);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(180, 50);
            btnAddUser.TabIndex = 0;
            btnAddUser.Text = "Add new user";
            btnAddUser.TextColor = Color.White;
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // panelRadius2
            // 
            panelRadius2.BackColor = Color.Transparent;
            panelRadius2.BackgroundColor = Color.Transparent;
            panelRadius2.BorderColor = Color.PaleVioletRed;
            panelRadius2.BorderRadius = 40;
            panelRadius2.BorderSize = 0;
            panelRadius2.colorBot = Color.Empty;
            panelRadius2.colorTop = Color.Empty;
            panelRadius2.Controls.Add(dtgvListUser);
            panelRadius2.Dock = DockStyle.Fill;
            panelRadius2.ForeColor = Color.White;
            panelRadius2.Location = new Point(0, 99);
            panelRadius2.Name = "panelRadius2";
            panelRadius2.Size = new Size(1150, 517);
            panelRadius2.TabIndex = 1;
            panelRadius2.TextColor = Color.White;
            // 
            // dtgvListUser
            // 
            dtgvListUser.AutoGenerateColumns = false;
            dtgvListUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvListUser.BackgroundColor = Color.FromArgb(48, 40, 53);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(48, 40, 53);
            dataGridViewCellStyle1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(252, 252, 252);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(194, 203, 199);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(252, 252, 252);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgvListUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgvListUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvListUser.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, genderDataGridViewCheckBoxColumn, emailDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, phonenumberDataGridViewTextBoxColumn, dateofbirdDataGridViewTextBoxColumn, roleDataGridViewTextBoxColumn, avatarDataGridViewImageColumn });
            dtgvListUser.DataSource = dTOUsersBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(48, 40, 53);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(194, 203, 199);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtgvListUser.DefaultCellStyle = dataGridViewCellStyle3;
            dtgvListUser.Dock = DockStyle.Fill;
            dtgvListUser.Location = new Point(0, 0);
            dtgvListUser.Name = "dtgvListUser";
            dtgvListUser.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(252, 252, 252);
            dtgvListUser.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dtgvListUser.RowTemplate.Height = 29;
            dtgvListUser.ShowCellToolTips = false;
            dtgvListUser.Size = new Size(1150, 517);
            dtgvListUser.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            dataGridViewCellStyle2.BackColor = Color.FromArgb(48, 40, 53);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(194, 203, 199);
            idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            idDataGridViewTextBoxColumn.HeaderText = "ID";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "Full name";
            fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewCheckBoxColumn
            // 
            genderDataGridViewCheckBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewCheckBoxColumn.HeaderText = "Gender";
            genderDataGridViewCheckBoxColumn.MinimumWidth = 6;
            genderDataGridViewCheckBoxColumn.Name = "genderDataGridViewCheckBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            phonenumberDataGridViewTextBoxColumn.DataPropertyName = "Phonenumber";
            phonenumberDataGridViewTextBoxColumn.HeaderText = "Phone number";
            phonenumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            // 
            // dateofbirdDataGridViewTextBoxColumn
            // 
            dateofbirdDataGridViewTextBoxColumn.DataPropertyName = "Dateofbird";
            dateofbirdDataGridViewTextBoxColumn.HeaderText = "Date of bird";
            dateofbirdDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateofbirdDataGridViewTextBoxColumn.Name = "dateofbirdDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            roleDataGridViewTextBoxColumn.HeaderText = "Role";
            roleDataGridViewTextBoxColumn.MinimumWidth = 6;
            roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // avatarDataGridViewImageColumn
            // 
            avatarDataGridViewImageColumn.DataPropertyName = "Avatar";
            avatarDataGridViewImageColumn.HeaderText = "Avatar";
            avatarDataGridViewImageColumn.MinimumWidth = 6;
            avatarDataGridViewImageColumn.Name = "avatarDataGridViewImageColumn";
            // 
            // dTOUsersBindingSource
            // 
            dTOUsersBindingSource.DataSource = typeof(DTO.DTO_Users);
            // 
            // uUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 40, 53);
            Controls.Add(panelRadius2);
            Controls.Add(panelRadius1);
            Name = "uUsers";
            Size = new Size(1150, 616);
            Load += uUsers_Load;
            panelRadius1.ResumeLayout(false);
            panelRadius2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvListUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)dTOUsersBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Custom.PanelRadius panelRadius1;
        private Custom.PanelRadius panelRadius2;
        private DataGridView dtgvListUser;
        private Custom.ButtonRadius btnAddUser;
        private Custom.ButtonRadius btnExportExcel;
        private BindingSource dTOUsersBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn genderDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateofbirdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private DataGridViewImageColumn avatarDataGridViewImageColumn;
    }
}
