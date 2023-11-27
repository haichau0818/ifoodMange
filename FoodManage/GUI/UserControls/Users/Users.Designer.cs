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
            panelRadius1 = new Custom.PanelRadius();
            panelRadius2 = new Custom.PanelRadius();
            dataGridView1 = new DataGridView();
            buttonRadius1 = new Custom.ButtonRadius();
            panelRadius1.SuspendLayout();
            panelRadius2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panelRadius1.Controls.Add(buttonRadius1);
            panelRadius1.Dock = DockStyle.Top;
            panelRadius1.ForeColor = Color.White;
            panelRadius1.Location = new Point(0, 0);
            panelRadius1.Name = "panelRadius1";
            panelRadius1.Size = new Size(1150, 99);
            panelRadius1.TabIndex = 0;
            panelRadius1.TextColor = Color.White;
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
            panelRadius2.Controls.Add(dataGridView1);
            panelRadius2.Dock = DockStyle.Fill;
            panelRadius2.ForeColor = Color.White;
            panelRadius2.Location = new Point(0, 99);
            panelRadius2.Name = "panelRadius2";
            panelRadius2.Size = new Size(1150, 517);
            panelRadius2.TabIndex = 1;
            panelRadius2.TextColor = Color.White;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1150, 517);
            dataGridView1.TabIndex = 0;
            // 
            // buttonRadius1
            // 
            buttonRadius1.BackColor = Color.MediumSlateBlue;
            buttonRadius1.BackgroundColor = Color.MediumSlateBlue;
            buttonRadius1.BorderColor = Color.PaleVioletRed;
            buttonRadius1.BorderRadius = 40;
            buttonRadius1.BorderSize = 0;
            buttonRadius1.FlatAppearance.BorderSize = 0;
            buttonRadius1.FlatStyle = FlatStyle.Flat;
            buttonRadius1.ForeColor = Color.White;
            buttonRadius1.Location = new Point(28, 23);
            buttonRadius1.Name = "buttonRadius1";
            buttonRadius1.Size = new Size(180, 50);
            buttonRadius1.TabIndex = 0;
            buttonRadius1.Text = "buttonRadius1";
            buttonRadius1.TextColor = Color.White;
            buttonRadius1.UseVisualStyleBackColor = false;
            buttonRadius1.Click += buttonRadius1_Click;
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
            panelRadius1.ResumeLayout(false);
            panelRadius2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Custom.PanelRadius panelRadius1;
        private Custom.PanelRadius panelRadius2;
        private DataGridView dataGridView1;
        private Custom.ButtonRadius buttonRadius1;
    }
}
