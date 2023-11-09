using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace FoodManage.GUI.Custom
{
    public class PanelGradient:Panel
    {
        public Color colorTop { get; set; }
        public Color colorBot { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, this.colorTop, this.colorBot, 90F);

            Graphics g = e.Graphics;

            g.FillRectangle(lgb, this.ClientRectangle);

            base.OnPaint(e);
        }
    }
}
