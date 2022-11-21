using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_NTM01
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
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
        private void Main_Load_1(object sender, EventArgs e)
        {

        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            panel_Controls.Controls.Clear();
            home.TopLevel = false;
            home.Dock = DockStyle.Fill;
            panel_Controls.Controls.Add(home);
            home.Show();
        }

        private void btnInvisible_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaxMininmize_Click(object sender, EventArgs e)
        {
            if (this.WindowState.ToString() == "Normal")
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaxMininmize.Image = Properties.Resources.minimize;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btnMaxMininmize.Image = Properties.Resources.maximize;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
