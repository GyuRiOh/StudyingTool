using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 초등임용복습프로그램
{
    public partial class Timer : Form
    {

        public static int elapsedTime = 0;

        public Timer()
        {
            InitializeComponent();
        }

        private void Timer_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            labelTime.Text = Convert.ToString(elapsedTime) + "초 경과";
        }
    }
}
