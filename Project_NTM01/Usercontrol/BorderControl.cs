using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Project_NTM01.Usercontrol
{
    public class BorderControl : Panel
    {
        // Declare Fields
        private Color color_background = Color.FromArgb(149,159,166);
        private Color color_border = Color.White;
        public BorderControl()
        {
        }
        // Drawing
        // Creating Accessors
        // Advance
        private const int cGrip = 16;
        private const int cCaption = 32;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }

            }
            base.WndProc(ref m);
        }
    }
}
