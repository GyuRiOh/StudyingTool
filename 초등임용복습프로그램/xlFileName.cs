using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 초등임용복습프로그램.Properties;

namespace 초등임용복습프로그램
{
    public partial class xlFileName : Form
    {
        public xlFileName()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormList.filename = textBox1.Text;
            Close();
            
        }
    }
}
