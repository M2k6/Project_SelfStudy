using Project_NTM01.Usercontrol;
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
    public partial class TimeTable : Form
    {
        int temp_month, temp_year;
        public TimeTable()
        {
            InitializeComponent();
        }
        private void DisplayDate(int year,int month)
        {
            panel_Date.Controls.Clear();
            int days = DateTime.DaysInMonth(year, month);
            for (int i = 0; i < days; i++)
            {
                TimeTable_Day timeTable_Day = new TimeTable_Day();
                timeTable_Day.Day = i;
                if (month == DateTime.Now.Month && year == DateTime.Now.Year && i == DateTime.Now.Day)
                    timeTable_Day.DisplayToday();
                panel_Date.Controls.Add(timeTable_Day);
            }
        }
        private void TimeTable_Load(object sender, EventArgs e)
        {
            DisplayDate(DateTime.Now.Year,DateTime.Now.Month);
            label2.Text = $"Tháng {DateTime.Now.Month}, Năm {DateTime.Now.Year}";
            temp_month = DateTime.Now.Month;
            temp_year = DateTime.Now.Year;
        }

        private void btnAfter_Click(object sender, EventArgs e)
        {
            panel_Date.Controls.Clear();
            TimeTable_Day timeTable_Day = new TimeTable_Day();
            DisplayDate(temp_year + 1, temp_month + 1);
            panel_Date.Controls.Add(timeTable_Day);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            panel_Date.Controls.Clear();
            TimeTable_Day timeTable_Day = new TimeTable_Day();
            DisplayDate(temp_year - 1, temp_month - 1);
            panel_Date.Controls.Add(timeTable_Day);
        }
    }
}
