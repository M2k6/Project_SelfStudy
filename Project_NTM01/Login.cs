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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            lbRegister.ForeColor = SystemColors.HotTrack;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            lbRegister.ForeColor = SystemColors.ControlText;
        }

        private void lbRegister_Click(object sender, EventArgs e)
        {
            
        }
    }
}
