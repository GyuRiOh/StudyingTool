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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            for (int i=0; i < WrongAnswer.wrongTemp.Count; i++)
            {
                listBox1.Items.Add(WrongAnswer.wrongTemp[i].Quest);

            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            WrongAnswer.wrongTemp.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.Clear();

            for (int i = 0; i < WrongAnswer.wrongTemp.Count; i++)
            {
                listBox1.Items.Add(WrongAnswer.wrongTemp[i].Quest);

            }
        }
    }
}
