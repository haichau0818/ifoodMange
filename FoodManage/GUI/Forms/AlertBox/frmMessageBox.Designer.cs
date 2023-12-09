namespace FoodManage.GUI.Forms.AlertBox
{
    partial class frmMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessageBox));
            pnlMessageColor = new Panel();
            picCloseMessage = new PictureBox();
            picIconsMessage = new PictureBox();
            lblTitleMessage = new Label();
            btnOk = new Custom.ButtonRadius();
            btnCancel = new Custom.ButtonRadius();
            lblMessageText = new Label();
            pnlMessageColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCloseMessage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIconsMessage).BeginInit();
            SuspendLayout();
            // 
            // pnlMessageColor
            // 
            pnlMessageColor.BackColor = Color.Tomato;
            pnlMessageColor.Controls.Add(picCloseMessage);
            pnlMessageColor.Controls.Add(picIconsMessage);
            pnlMessageColor.Controls.Add(lblTitleMessage);
            pnlMessageColor.Dock = DockStyle.Top;
            pnlMessageColor.Location = new Point(0, 0);
            pnlMessageColor.Margin = new Padding(4, 3, 4, 3);
            pnlMessageColor.Name = "pnlMessageColor";
            pnlMessageColor.Size = new Size(500, 82);
            pnlMessageColor.TabIndex = 0;
            // 
            // picCloseMessage
            // 
            picCloseMessage.Image = (Image)resources.GetObject("picCloseMessage.Image");
            picCloseMessage.Location = new Point(454, 5);
            picCloseMessage.Name = "picCloseMessage";
            picCloseMessage.Size = new Size(35, 34);
            picCloseMessage.SizeMode = PictureBoxSizeMode.StretchImage;
            picCloseMessage.TabIndex = 4;
            picCloseMessage.TabStop = false;
            picCloseMessage.Click += picCloseMessage_Click;
            // 
            // picIconsMessage
            // 
            picIconsMessage.Location = new Point(9, 9);
            picIconsMessage.Name = "picIconsMessage";
            picIconsMessage.Size = new Size(66, 62);
            picIconsMessage.SizeMode = PictureBoxSizeMode.StretchImage;
            picIconsMessage.TabIndex = 3;
            picIconsMessage.TabStop = false;
            // 
            // lblTitleMessage
            // 
            lblTitleMessage.AutoSize = true;
            lblTitleMessage.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitleMessage.ForeColor = SystemColors.ControlLightLight;
            lblTitleMessage.Location = new Point(84, 20);
            lblTitleMessage.Name = "lblTitleMessage";
            lblTitleMessage.Size = new Size(169, 34);
            lblTitleMessage.TabIndex = 2;
            lblTitleMessage.Text = "Information";
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.OrangeRed;
            btnOk.BackgroundColor = Color.OrangeRed;
            btnOk.BorderColor = Color.PaleVioletRed;
            btnOk.BorderRadius = 20;
            btnOk.BorderSize = 0;
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.ForeColor = Color.White;
            btnOk.Location = new Point(382, 181);
            btnOk.Margin = new Padding(4, 3, 4, 3);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(105, 57);
            btnOk.TabIndex = 1;
            btnOk.Text = "Ok";
            btnOk.TextColor = Color.White;
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BackgroundColor = Color.Transparent;
            btnCancel.BorderColor = Color.PaleVioletRed;
            btnCancel.BorderRadius = 20;
            btnCancel.BorderSize = 0;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.OrangeRed;
            btnCancel.Location = new Point(257, 181);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(117, 57);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.TextColor = Color.OrangeRed;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblMessageText
            // 
            lblMessageText.AutoSize = true;
            lblMessageText.Location = new Point(22, 114);
            lblMessageText.Name = "lblMessageText";
            lblMessageText.Size = new Size(189, 23);
            lblMessageText.TabIndex = 2;
            lblMessageText.Text = "Content message!";
            // 
            // frmMessageBox
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 250);
            Controls.Add(lblMessageText);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(pnlMessageColor);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmMessageBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMessageBox";
            pnlMessageColor.ResumeLayout(false);
            pnlMessageColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCloseMessage).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIconsMessage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlMessageColor;
        private Custom.ButtonRadius btnOk;
        private Custom.ButtonRadius btnCancel;
        private PictureBox picIconsMessage;
        private Label lblTitleMessage;
        private Label lblMessageText;
        private PictureBox picCloseMessage;
    }
}