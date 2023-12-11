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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dtgvListUser = new DataGridView();
            dTOUsersBindingSource = new BindingSource(components);
            panelRadius1 = new Custom.PanelRadius();
            btnExportExcel = new Custom.ButtonRadius();
            btnAddUser = new Custom.ButtonRadius();
            panelRadius2 = new Custom.PanelRadius();
            ((System.ComponentModel.ISupportInitialize)dtgvListUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dTOUsersBindingSource).BeginInit();
            panelRadius1.SuspendLayout();
            panelRadius2.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvListUser
            // 
            dtgvListUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvListUser.BackgroundColor = Color.FromArgb(48, 40, 53);
            dtgvListUser.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dtgvListUser.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(48, 40, 53);
            dataGridViewCellStyle1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(252, 252, 252);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(48, 40, 53);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(252, 252, 252);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgvListUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgvListUser.ColumnHeadersHeight = 50;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(48, 40, 53);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(244, 246, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(48, 40, 53);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgvListUser.DefaultCellStyle = dataGridViewCellStyle2;
            dtgvListUser.Dock = DockStyle.Fill;
            dtgvListUser.EnableHeadersVisualStyles = false;
            dtgvListUser.Location = new Point(0, 0);
            dtgvListUser.Name = "dtgvListUser";
            dtgvListUser.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgvListUser.RowHeadersVisible = false;
            dtgvListUser.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(252, 252, 252);
            dtgvListUser.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dtgvListUser.RowTemplate.Height = 32;
            dtgvListUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvListUser.Size = new Size(1150, 517);
            dtgvListUser.TabIndex = 0;
            dtgvListUser.CellContentClick += dtgvListUser_CellContentClick;
            // 
            // dTOUsersBindingSource
            // 
            dTOUsersBindingSource.DataSource = typeof(DTO.DTO_Users);
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
            ((System.ComponentModel.ISupportInitialize)dtgvListUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)dTOUsersBindingSource).EndInit();
            panelRadius1.ResumeLayout(false);
            panelRadius2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Custom.PanelRadius panelRadius1;
        private Custom.PanelRadius panelRadius2;
        private DataGridView dtgvListUser;
        private Custom.ButtonRadius btnAddUser;
        private Custom.ButtonRadius btnExportExcel;
        private BindingSource dTOUsersBindingSource;
    }
}
