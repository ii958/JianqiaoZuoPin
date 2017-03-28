using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 十三娘的伟大的独一无二的第一个的应用程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            label2.Text = DateTime.Now.ToString("yyyy-MM-dd");
            label2.Visible = true;

            label4.Text = DateTime.Now.ToString("HH:mm:ss");
            label4.Visible = true;

            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            this.timer1.Start();

            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("yyyy-MM-dd");
            label4.Text = DateTime.Now.ToString("HH:mm:ss");
            DateTime today = DateTime.Now;
            timeless(today);
        }

        private void timeless(DateTime time)
        {
            int time_y= time.Year;
            int time_M = time.Month;
            int time_d = time.Day;

            int time_h = time.Hour;
            int time_m = time.Minute;
            int time_s = time.Second;

            DateTime today = DateTime.Now;
            DateTime theDay = DateTime.Parse("2018-08-08 00:00:00");
            TimeSpan span = theDay.Subtract(today);
            int days = span.Days;
            int year = days / 365;
            int day = days % 365;

            int hour = span.Hours % 24;
            int min = span.Minutes % 60;
            int sec = span.Seconds % 60;
            label6.Text = year + "年" + day + "天" + hour + "小时" + min + "分钟" + sec + "秒";
        }
    }
}
