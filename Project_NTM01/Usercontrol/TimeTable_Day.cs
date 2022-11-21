using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_NTM01.Usercontrol
{
    public partial class TimeTable_Day : UserControl
    {
        // Fields
        public int Day { get; set ; }
        public bool Status { get; set; }
        public bool IsToday
        {
            get { return IsToday; }
            set 
            {
                /*if (OnValueChanged(value))
                {
                    IsToday = true;
                    DisplayToday();
                }
                else IsToday = false;*/
                IsToday = value;
            }
        }
        //
        public TimeTable_Day()
        {
            InitializeComponent();
        }
        public void DisplayToday()
        {
            lb_Date.Text = Day.ToString();
            if (IsToday == true) lb_Date.ForeColor = Color.Red;
        }
        private void TimeTable_Day_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(168,209,223);
        }

        private void TimeTable_Day_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        // EventNotification
        private event EventHandler _ValueChanged;
        public event EventHandler ValueChanged
        {
            add { _ValueChanged += value; }
            remove { _ValueChanged -= value; }
        }
        bool OnValueChanged(bool value) 
        {
            if (_ValueChanged != null) _ValueChanged(this, new EventArgs());
            if (value == true) return true;
            else return false;
        }
    }
}
