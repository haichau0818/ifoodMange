using FoodManage.DAL;
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
    public partial class uListFood : UserControl
    {
        public uListFood()
        {
            InitializeComponent();
            LoadFood();
        }


        void LoadFood()
        {
            dtgvListFood.DataSource = FoodDAL.Instance.loadTable();
        }
    }
}
