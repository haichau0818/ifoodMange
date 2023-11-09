using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodManage.GUI.UserControls.Foods
{
    public partial class uFoods : UserControl
    {
        public uFoods()
        {
            InitializeComponent();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            int i = 0;
            //Kiểm tra các controls trong pnlMain có tồn tại UC chưa
            foreach (Control control in pnlFoodContent.Controls)
            {
                if (control is UserControl)
                {
                    if (control.Name == "uCreate")
                    {
                        if (pnlFoodContent.Controls[i].Name == "uCreate")
                        {
                            pnlFoodContent.Controls[i].BringToFront();
                            return;
                        }
                    }
                }
                i++;
            }
            //Nếu chưa tồn tại UC thì Add vào pnlMain
            uCreate uCreateFood = new uCreate();
            uCreateFood.Dock = DockStyle.Fill;
            pnlFoodContent.Controls.Add(uCreateFood);
            pnlFoodContent.Controls[pnlFoodContent.Controls.Count - 1].BringToFront();
        }

        private void btnListFood_Click(object sender, EventArgs e)
        {
            int i = 0;
            //Kiểm tra các controls trong pnlMain có tồn tại UC chưa
            foreach (Control control in pnlFoodContent.Controls)
            {
                if (control is UserControl)
                {
                    if (control.Name == "uListFood")
                    {
                        if (pnlFoodContent.Controls[i].Name == "uListFood")
                        {
                            pnlFoodContent.Controls[i].BringToFront();
                            return;
                        }
                    }
                }
                i++;
            }
            //Nếu chưa tồn tại UC thì Add vào pnlMain
            uListFood uListFood = new uListFood();
            uListFood.Dock = DockStyle.Fill;
            pnlFoodContent.Controls.Add(uListFood);
            pnlFoodContent.Controls[pnlFoodContent.Controls.Count - 1].BringToFront();
        }
    }
}
