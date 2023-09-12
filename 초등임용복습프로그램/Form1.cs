using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 초등임용복습프로그램.Properties;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.IO;
using Microsoft.Office.Core;

namespace 초등임용복습프로그램
{
    public partial class Form1 : Form
    {
        public static string answerSave = ""; //다음엔 answerTemp로 변수명 바꾸기
        public static string wrongTemp = "";
        public static string questionTemp = "";
        public static string refTemp = "";
        public static List<QuestSet> userList = new List<QuestSet>();
        public static bool xlFileLoaded = false;
        bool answerShow = false;

        private int challengeNum = 0;
        private int hitScore = 0;
        private int missScore = 0;
        public static int num = 0; 
        public static int combo1 = 0;
        public static int combo2 = 0;
        public static int combo3 = 0;
        public static string textTemp = "";
        public static int questNumTemp = 0;


        public delegate void MyDelegate(int x, int y, int z, List<QuestSet> listTemp);
        MyDelegate Sequence = new MyDelegate(QuestSet.sequenceCall);
        MyDelegate Random = new MyDelegate(QuestSet.randomCall);

        public static void QuestCall(int x, int y, int z, List<QuestSet> listTemp, MyDelegate dele)
        {
            dele(x, y, z, listTemp);
        }
        
        public void btnInput()
        {
            wrongTemp = textBox1.Text;
            challengeNum++;
            labelChallenge.Text = challengeNum.ToString();

            if (textBox1.Text == answerSave)
            {
                TorF.Text = "맞았다!";
                hitScore++;
                labelCorrect.Text = hitScore.ToString();
            }

            else
            {
                TorF.Text = "틀렸다!";
                missScore++;
                WrongAnswer.wrongTemp.Add(new QuestSet { Quest = questionTemp, Answer = answerSave, WrongAnswer = wrongTemp  });
                labelWrong.Text = missScore.ToString();
            }

        }




        public Form1()
        {
            InitializeComponent();

            


            this.textBox1.KeyDown += Form1_KeyDown;

            challengeNum = 0;
            hitScore = 0;
            missScore = 0;
            WrongAnswer.wrongTemp.Clear();

    }
        


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = 0;
            comboBox2.Items.Clear();
            comboBox2.Text = "항목을 선택하세요.";
            comboBox3.Items.Clear();
            comboBox3.Text = "항목을 선택하세요.";

            ItemAdd(0, new string[] { "총론" }); //총론
            ItemAdd(1, new string[] { "기본이론", "각론", "교육과정" }); //수학
            ItemAdd(2, new string[] { "기본이론", "각론" }); //과학
            ItemAdd(3, new string[] { "기본이론", "각론" }); //음악
            ItemAdd(4, new string[] { "기본이론", "각론" }); //실과
            ItemAdd(5, new string[] { "기본이론" }); //도덕
            ItemAdd(6, new string[] { "기본이론" }); //영어
            ItemAdd(7, new string[] { "기본이론", "각론" }); //사회
            ItemAdd(8, new string[] { "기본이론", "각론" }); //미술
            ItemAdd(9, new string[] { "기본이론", "각론" });//체육
            ItemAdd(10, new string[] { "기본이론","각론" });//국어
            ItemAdd(11, new string[] { "통합교과"});//통합교과
            ItemAdd(13, new string[] { "사용자 파일" });//사용자 파일
            ItemAdd(12, new string[] { "필수암기리스트" });//필수 암기 리스트


        }
        
        
        public void buttonSelection_Click(object sender, EventArgs e)
        {
            //랜덤 문제 호출
            textBox1.Clear();
            TorF.Text = "맞을까?틀릴까?";
            RightAnswer.Text = "-";

            labelRef.Text = "";

            combo1 = comboBox1.SelectedIndex;
            combo2 = comboBox2.SelectedIndex;
            combo3 = comboBox3.SelectedIndex;



            Random(0, 0, 0, GeneralQL.general_CU);
            QuestCall(1, 0, 0, MathQL.Math_Basic_Theory, Random);
            QuestCall(1, 1, 0, MathQL2.math_Part_NumSys, Random);
            QuestCall(1, 1, 1, MathQL2.math_Part_NumCalcu, Random);
            QuestCall(1, 1, 2, MathQL3.math_Part_Geometry, Random);
            QuestCall(1, 2, 0, MathQL.math_CU_12, Random);
            QuestCall(1, 2, 1, MathQL.math_CU_34, Random);
            QuestCall(1, 2, 2, MathQL.math_CU_56, Random);
            QuestCall(2, 0, 0, ScienceQL.Science_Basic_Theory, Random);
            QuestCall(2, 1, 0, ScienceQL.Science_Particulars_Matter, Random);
            QuestCall(2, 1, 1, ScienceQL2.Science_Particulars_Life, Random);
            QuestCall(2, 1, 2, ScienceQL2.science_part_moveNenergy, Random);
            QuestCall(3, 0, 0, MusicQL.music_CU, Random);
            QuestCall(3, 1, 0, MusicQL.music_Part_34, Random);
            QuestCall(4, 0, 1, PracticalCourseQL.pract_CU, Random);
            QuestCall(5, 0, 0, EthicsQL.Ethics_edu, Random);
            QuestCall(6, 0, 0, EnglishQL.Eng_edu, Random);
            QuestCall(6, 0, 1, EnglishQL.Eng_CU, Random);
            QuestCall(7, 0, 0, SocialStudiesQL.social_edu, Random);
            QuestCall(8, 0, 0, ArtQL.art_edu, Random);
            QuestCall(8, 0, 1, ArtQL.art_CU, Random);
            QuestCall(9, 0, 0, PhysicsQL.physics_edu, Random);
            QuestCall(9, 0, 1, PhysicsQL.physics_CU, Random);
            QuestCall(10, 0, 1, KoreanQL.korean_CU, Random);
            QuestCall(13, 0, 0, userList, Random);


            label1.Text = textTemp;
            labelQN.Text = Convert.ToString(questNumTemp);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Enter:
                    
                    
                    btnInput();
                    break;
                case Keys.F1:

                    buttonSelection_Click(sender, e);
                    break;

                case Keys.F2:


                    button1_Click(sender, e);
                    break;

                case Keys.F3:

                    textBox1.Text += "·";
                    break;

                case Keys.F4:
                    ConfirmAnswer_Click(sender, e);
                    break;







            }

             
                
        }
        private void buttonInput_Click(object sender, EventArgs e)
        {
            btnInput();


        }

        private void ConfirmAnswer_Click(object sender, EventArgs e)
        {
            if (answerShow == false)
            {
                RightAnswer.Text = answerSave;
                labelRef.Text = "참고 자료 : " + refTemp;
                answerShow = true;
            }

            else if (answerShow == true)
            {
                RightAnswer.Text = "";
                labelRef.Text = "";
                answerShow = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //선택(순서대로) 버튼
            labelRef.Text = "";
            textBox1.Clear();
            TorF.Text = "맞을까?틀릴까?";
            RightAnswer.Text = "-";

            combo1 = comboBox1.SelectedIndex;
            combo2 = comboBox2.SelectedIndex;
            combo3 = comboBox3.SelectedIndex;

            QuestCall(0, 0, 0, GeneralQL.general_CU, Sequence);
            QuestCall(1, 0, 0, MathQL.Math_Basic_Theory, Sequence);
            QuestCall(1, 1, 0, MathQL2.math_Part_NumSys, Sequence);
            QuestCall(1, 1, 1, MathQL2.math_Part_NumCalcu, Sequence);
            QuestCall(1, 1, 2, MathQL3.math_Part_Geometry, Sequence);
            QuestCall(1, 2, 0, MathQL.math_CU_12, Sequence);
            QuestCall(1, 2, 1, MathQL.math_CU_34, Sequence);
            QuestCall(1, 2, 2, MathQL.math_CU_56, Sequence);
            QuestCall(2, 0, 0, ScienceQL.Science_Basic_Theory, Sequence);
            QuestCall(2, 1, 0, ScienceQL.Science_Particulars_Matter, Sequence);
            QuestCall(2, 1, 1, ScienceQL2.Science_Particulars_Life, Sequence);
            QuestCall(2, 1, 2, ScienceQL2.science_part_moveNenergy, Sequence);
            QuestCall(3, 0, 0, MusicQL.music_CU, Sequence);
            QuestCall(3, 1, 0, MusicQL.music_Part_34, Sequence);
            QuestCall(4, 0, 1, PracticalCourseQL.pract_CU, Sequence);
            QuestCall(5, 0, 0, EthicsQL.Ethics_edu, Sequence);
            QuestCall(6, 0, 0, EnglishQL.Eng_edu, Sequence);
            QuestCall(6, 0, 1, EnglishQL.Eng_CU, Sequence);
            QuestCall(7, 0, 0, SocialStudiesQL.social_edu, Sequence);
            QuestCall(8, 0, 0, ArtQL.art_edu, Sequence);
            QuestCall(8, 0, 1, ArtQL.art_CU, Sequence);
            QuestCall(9, 0, 0, PhysicsQL.physics_edu, Sequence);
            QuestCall(9, 0, 1, PhysicsQL.physics_CU, Sequence);
            QuestCall(10, 0, 1, KoreanQL.korean_CU, Sequence);
            QuestCall(13, 0, 0, userList, Sequence);
            Sequence(12, 0, 0, amgi.amgiList);


            label1.Text = textTemp;
            labelQN.Text = Convert.ToString(questNumTemp);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = 0;
            comboBox3.Items.Clear();
            comboBox3.Text = "항목을 선택하세요.";

            ItemAdd2(0, 0, new string[] {"총론"});
            ItemAdd2(1, 0, new string[] {"기본이론"});
            ItemAdd2(1, 1, new string[] {"수의 체계", "수의 연산", "도형", "측정", "규칙성", "자료와 가능성"});
            ItemAdd2(1, 2, new string[] {"1~2학년", "3~4학년", "5~6학년" });
            ItemAdd2(2, 0, new string[] {"기본이론"});
            ItemAdd2(2, 1, new string[] {"물질", "생명", "운동과 에너지", "지구와 우주", "통합 단원" });
            ItemAdd2(3, 0, new string[] {"교육과정","기본이론"});
            ItemAdd2(3, 1, new string[] {"3~4학년", "5~6학년" });
            ItemAdd2(4, 0, new string[] {"기본이론", "교육과정"});
            ItemAdd2(4, 1, new string[] { "국악", "양악" });
            ItemAdd2(5, 0, new string[] {"기본이론"});
            ItemAdd2(6, 0, new string[] {"기본이론", "교육과정"});
            ItemAdd2(7, 0, new string[] {"기본이론"});
            ItemAdd2(7, 1, new string[] { "각론" });
            ItemAdd2(8, 0, new string[] {"기본이론", "교육과정"});
            ItemAdd2(8, 1, new string[] { "각론" });
            ItemAdd2(9, 0, new string[] { "기본이론", "교육과정" });
            ItemAdd2(9, 1, new string[] { "각론" });
            ItemAdd2(10, 0, new string[] { "기본이론", "교육과정" });
            ItemAdd2(10, 1, new string[] { "각론" });
            ItemAdd2(11, 0, new string[] { "기본이론", "교육과정" });
            ItemAdd2(12, 0, new string[] { "필수 암기 리스트" });
            ItemAdd2(13, 0, new string[] { "사용자 파일" });
            //사용자 파일

        }

        private void ItemAdd2(int x, int y, string[] array)
        {
          
            if (comboBox1.SelectedIndex == x && comboBox2.SelectedIndex == y)
            {
                comboBox3.Items.AddRange(array);
            }
        }

        private void ItemAdd(int x, string[] array)
        {
            if (comboBox1.SelectedIndex == x)
            {
                comboBox2.Items.AddRange(array);
            }
        }

        private void jumpToModel_Click(object sender, EventArgs e)
        {
            Form2 showForm2 = new Form2();
            showForm2.Show();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = 0;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonWrong_Click_1(object sender, EventArgs e)
        {
            WrongAnswerNote showWAN = new WrongAnswerNote();
            showWAN.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCS_Click(object sender, EventArgs e)
        {
            contentSystem showCS = new contentSystem();
            showCS.Show();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            FormList formlist = new FormList();
            formlist.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp = null;
            Excel.Workbook xlWorkbook = null;
            Excel.Worksheet xlWorksheet = null;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel File (*.xlsx) |*.xlsx| Xls files(*.xls)| *.xls| All Files (*.*) | *.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    userList.Clear();
                    xlApp = new Excel.Application();
                    xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
                    xlWorksheet = (Excel.Worksheet)xlWorkbook.Worksheets.get_Item(1);

                    Excel.Range range = xlWorksheet.UsedRange;
                    object[,] data = range.Value;

                    for (int i = 0; i<=range.Rows.Count - 2; i++)
                    {
                        userList.Add(new QuestSet());

                        if (data[i + 2, 1] != null)
                            userList[i].Quest = data[i + 2, 1].ToString();

                        if (data[i + 2, 2] != null)
                            userList[i].Answer = data[i + 2, 2].ToString();


                        if (data[i + 2, 3] != null)
                            userList[i].Reference = data[i + 2, 3].ToString();


                        if (data[i + 2, 4] != null)
                            userList[i].FullSentence = data[i + 2, 4].ToString();

                    }

                    xlFileLoaded = true;
                    label8.Text = Path.GetFileName(ofd.FileName);


                    xlWorkbook.Close(true);
                    xlApp.Quit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    ReleaseObject(xlWorksheet);
                    ReleaseObject(xlWorkbook);
                    ReleaseObject(xlApp);
                }

            }

                
        }

        private static void ReleaseObject(object obj)
        {
            try
            {
                if (obj != null)
                {
                    Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }
            catch (Exception ex)
            {
                obj = null;
                throw ex;
            }
            finally
            {
                GC.Collect();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
