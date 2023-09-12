using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 초등임용복습프로그램
{
    public partial class Form2 : Form
    {
        string answerSave = "";
        string chunkSave = "";
        public ModelSet randomList;

        Random random = new Random();

        bool chunkShow = false;
        bool answerShow = false;
        public Form2()
        {
            InitializeComponent();

            this.textBox1.KeyDown += Form2_KeyDown;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TorF.Text = "맞았나?틀렸나?";
            labelCor.Text = "";
            labelHint.Text = "";

            modelCall(0, Model.korean_modelset);
            modelCall(1, Model.math_modelset);
            modelCall(2, Model.ethics_modelset);
            modelCall(3, Model.science_modelset);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == answerSave)
            {
                TorF.Text = "맞았다!";
                
            }

            else
            {
                TorF.Text = "틀렸다!";
              
            }
        }

        private void buttonCor_Click(object sender, EventArgs e)
        {
            if (answerShow == false)
            {
                labelCor.Text = answerSave;
                answerShow = true;
            }

            else if (answerShow == true)
            {
                labelCor.Text = "";
                answerShow = false;
            }
        }

        private void modelCall(int x, List<ModelSet> listTemp)
        {


            Random random = new Random();
            if (comboBox1.SelectedIndex == x)
            {

                
                listBox1.Items.Clear();
                labelCor.Text = "-";
                int num = random.Next(0, listTemp.Count);

                randomList = listTemp[num];

                listBox1.Items.Add("<" + listTemp[num].name + ">");

                foreach (var item in listTemp[num].model)
                {
                    listBox1.Items.Add(item);

                }

                int deleteNum = random.Next(1, listTemp[num].model.Count + 1);
                answerSave = listTemp[num].model[deleteNum - 1];
                chunkSave = listTemp[num].chunk;
                listBox1.Items.RemoveAt(deleteNum);
            }    



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (chunkShow == false)
            {
                labelHint.Text = chunkSave;
                chunkShow = true;
            }

            else if (chunkShow == true)
            {
                labelHint.Text = "";
                chunkShow = false;
            }

        }

        private void buttonRA_Click(object sender, EventArgs e)
        {

            labelCor.Text = "-";
            labelHint.Text = "";
            TorF.Text = "맞았나?틀렸나?";

            Random random = new Random();
            listBox1.Items.Clear();
            listBox1.Items.Add("<" + randomList.name + ">");

            foreach (var item in randomList.model)
            {
                listBox1.Items.Add(item);

            }

            int deleteNum = random.Next(1, randomList.model.Count + 1);
            answerSave = randomList.model[deleteNum - 1];
            chunkSave = randomList.chunk;
            listBox1.Items.RemoveAt(deleteNum);
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:


                    buttonConfirm_Click(sender, e);
                    break;
                case Keys.F1:

                    buttonCor_Click(sender, e);
                    break;

                case Keys.F2:


                    button1_Click_1(sender, e);
                    break;

                case Keys.F3:

                    textBox1.Text += "·";
                    break;

                case Keys.F4:
                    buttonRA_Click(sender, e);
                    break;


                case Keys.F5:
                    button1_Click(sender, e);
                    break;







            }
        }
    }
}
