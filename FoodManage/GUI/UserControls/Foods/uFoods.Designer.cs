namespace FoodManage.GUI.UserControls.Foods
{
    partial class uFoods
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
            pnlCRUD = new Custom.PanelRadius();
            buttonRadius1 = new Custom.ButtonRadius();
            btnListFood = new Custom.ButtonRadius();
            btnAddFood = new Custom.ButtonRadius();
            pnlFoodContent = new Custom.PanelRadius();
            pnlCRUD.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCRUD
            // 
            pnlCRUD.BackColor = Color.Transparent;
            pnlCRUD.BackgroundColor = Color.Transparent;
            pnlCRUD.BorderColor = Color.PaleVioletRed;
            pnlCRUD.BorderRadius = 40;
            pnlCRUD.BorderSize = 0;
            pnlCRUD.Controls.Add(buttonRadius1);
            pnlCRUD.Controls.Add(btnListFood);
            pnlCRUD.Controls.Add(btnAddFood);
            pnlCRUD.Dock = DockStyle.Top;
            pnlCRUD.ForeColor = Color.White;
            pnlCRUD.Location = new Point(0, 0);
            pnlCRUD.Name = "pnlCRUD";
            pnlCRUD.Size = new Size(1400, 89);
            pnlCRUD.TabIndex = 0;
            pnlCRUD.TextColor = Color.White;
            // 
            // buttonRadius1
            // 
            buttonRadius1.BackColor = Color.Transparent;
            buttonRadius1.BackgroundColor = Color.Transparent;
            buttonRadius1.BorderColor = Color.FromArgb(252, 252, 252);
            buttonRadius1.BorderRadius = 20;
            buttonRadius1.BorderSize = 2;
            buttonRadius1.FlatAppearance.BorderSize = 0;
            buttonRadius1.FlatStyle = FlatStyle.Flat;
            buttonRadius1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRadius1.ForeColor = Color.White;
            buttonRadius1.Location = new Point(363, 20);
            buttonRadius1.Name = "buttonRadius1";
            buttonRadius1.Size = new Size(163, 50);
            buttonRadius1.TabIndex = 0;
            buttonRadius1.Text = "Export Excel";
            buttonRadius1.TextColor = Color.White;
            buttonRadius1.UseVisualStyleBackColor = false;
            buttonRadius1.Click += btnAddFood_Click;
            // 
            // btnListFood
            // 
            btnListFood.BackColor = Color.Transparent;
            btnListFood.BackgroundColor = Color.Transparent;
            btnListFood.BorderColor = Color.FromArgb(252, 252, 252);
            btnListFood.BorderRadius = 20;
            btnListFood.BorderSize = 2;
            btnListFood.FlatAppearance.BorderSize = 0;
            btnListFood.FlatStyle = FlatStyle.Flat;
            btnListFood.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnListFood.ForeColor = Color.White;
            btnListFood.Location = new Point(194, 20);
            btnListFood.Name = "btnListFood";
            btnListFood.Size = new Size(163, 50);
            btnListFood.TabIndex = 0;
            btnListFood.Text = "View List Food";
            btnListFood.TextColor = Color.White;
            btnListFood.UseVisualStyleBackColor = false;
            btnListFood.Click += btnListFood_Click;
            // 
            // btnAddFood
            // 
            btnAddFood.BackColor = Color.Transparent;
            btnAddFood.BackgroundColor = Color.Transparent;
            btnAddFood.BorderColor = Color.FromArgb(252, 252, 252);
            btnAddFood.BorderRadius = 20;
            btnAddFood.BorderSize = 2;
            btnAddFood.FlatAppearance.BorderSize = 0;
            btnAddFood.FlatStyle = FlatStyle.Flat;
            btnAddFood.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddFood.ForeColor = Color.White;
            btnAddFood.Location = new Point(25, 20);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(163, 50);
            btnAddFood.TabIndex = 0;
            btnAddFood.Text = "Add New Food";
            btnAddFood.TextColor = Color.White;
            btnAddFood.UseVisualStyleBackColor = false;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // pnlFoodContent
            // 
            pnlFoodContent.BackColor = Color.MediumSlateBlue;
            pnlFoodContent.BackgroundColor = Color.MediumSlateBlue;
            pnlFoodContent.BorderColor = Color.PaleVioletRed;
            pnlFoodContent.BorderRadius = 40;
            pnlFoodContent.BorderSize = 0;
            pnlFoodContent.Dock = DockStyle.Fill;
            pnlFoodContent.ForeColor = Color.White;
            pnlFoodContent.Location = new Point(0, 89);
            pnlFoodContent.Name = "pnlFoodContent";
            pnlFoodContent.Size = new Size(1400, 611);
            pnlFoodContent.TabIndex = 1;
            pnlFoodContent.TextColor = Color.White;
            // 
            // uFoods
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnlFoodContent);
            Controls.Add(pnlCRUD);
            Name = "uFoods";
            Size = new Size(1400, 700);
            pnlCRUD.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Custom.PanelRadius pnlCRUD;
        private Custom.ButtonRadius btnAddFood;
        private Custom.PanelRadius pnlFoodContent;
        private Custom.ButtonRadius buttonRadius1;
        private Custom.ButtonRadius btnListFood;
    }
}
