namespace FoodManage.GUI.Forms.AlertBox
{
    partial class frmAlert
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
            picAlert = new PictureBox();
            lblTitle = new Label();
            lblContentAlert = new Label();
            pnlProgress = new Panel();
            timerAnimation = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picAlert).BeginInit();
            SuspendLayout();
            // 
            // picAlert
            // 
            picAlert.Location = new Point(24, 19);
            picAlert.Name = "picAlert";
            picAlert.Size = new Size(65, 65);
            picAlert.SizeMode = PictureBoxSizeMode.StretchImage;
            picAlert.TabIndex = 0;
            picAlert.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(97, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(67, 34);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Title";
            // 
            // lblContentAlert
            // 
            lblContentAlert.AutoSize = true;
            lblContentAlert.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblContentAlert.Location = new Point(102, 56);
            lblContentAlert.Name = "lblContentAlert";
            lblContentAlert.Size = new Size(46, 23);
            lblContentAlert.TabIndex = 1;
            lblContentAlert.Text = "Title";
            // 
            // pnlProgress
            // 
            pnlProgress.BackColor = SystemColors.ActiveCaptionText;
            pnlProgress.Location = new Point(0, 95);
            pnlProgress.Name = "pnlProgress";
            pnlProgress.Size = new Size(1, 6);
            pnlProgress.TabIndex = 2;
            // 
            // timerAnimation
            // 
            timerAnimation.Interval = 10;
            timerAnimation.Tick += timerAnimation_Tick;
            // 
            // frmAlert
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(500, 100);
            Controls.Add(pnlProgress);
            Controls.Add(lblContentAlert);
            Controls.Add(lblTitle);
            Controls.Add(picAlert);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAlert";
            Text = "frmAlert";
            Load += frmAlert_Load;
            ((System.ComponentModel.ISupportInitialize)picAlert).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picAlert;
        private Label lblTitle;
        private Label lblContentAlert;
        private Panel pnlProgress;
        private System.Windows.Forms.Timer timerAnimation;
    }
}