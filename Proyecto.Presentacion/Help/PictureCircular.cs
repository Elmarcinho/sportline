using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace Proyecto.Presentacion.Help
{
    public class PictureCircular:PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            //GraphicsPath g = new GraphicsPath();
            //g.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            //this.Region = new System.Drawing.Region(g);
            //base.OnPaint(pe);
            base.OnPaint(pe);
            using (GraphicsPath g = new GraphicsPath())
            {
                g.AddEllipse(0, 0, this.Width-1, this.Height-1);
                Region = new Region(g);
                pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                pe.Graphics.DrawEllipse(new Pen(new SolidBrush(this.BackColor), 1), 0, 0, this.Width - 1, this.Height - 1);
            }
        }
    }
}
