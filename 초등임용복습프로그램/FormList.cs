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
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Runtime.InteropServices;

namespace 초등임용복습프로그램.Properties
{
    public partial class FormList : Form
    {
        public static int num = 0;
        public static List<QuestSet> listTemp = new List<QuestSet>();
        public static string filename = "";
        private bool mod = false;
        private int listIndex = 0;

        static Excel.Application excelApp = null;
        static Excel.Workbook workBook = null;
        static Excel.Worksheet workSheet = null; 
        public FormList()
        {
            InitializeComponent();
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

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            num = 0;
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            num = 0;
            comboBox3.Items.Clear();
            comboBox3.Text = "항목을 선택하세요.";

            ItemAdd2(0, 0, new string[] { "총론" });
            ItemAdd2(1, 0, new string[] { "기본이론" });
            ItemAdd2(1, 1, new string[] { "수의 체계", "수의 연산", "도형", "측정", "규칙성", "자료와 가능성" });
            ItemAdd2(1, 2, new string[] { "1~2학년", "3~4학년", "5~6학년" });
            ItemAdd2(2, 0, new string[] { "기본이론" });
            ItemAdd2(2, 1, new string[] { "물질", "생명", "운동과 에너지", "지구와 우주", "통합 단원" });
            ItemAdd2(3, 0, new string[] { "교육과정", "기본이론" });
            ItemAdd2(3, 1, new string[] { "3~4학년", "5~6학년" });
            ItemAdd2(4, 0, new string[] { "기본이론", "교육과정" });
            ItemAdd2(5, 0, new string[] { "기본이론" });
            ItemAdd2(6, 0, new string[] { "기본이론", "교육과정" });
            ItemAdd2(7, 0, new string[] { "기본이론" });
            ItemAdd2(8, 0, new string[] { "기본이론", "교육과정" });

        }

        private void buttonChoice_Click(object sender, EventArgs e)
        {
            printQ();
        }

        private void PrintQuest(int x, int y, int z, List<QuestSet> templist)
        {
            
            if (comboBox1.SelectedIndex == x && comboBox2.SelectedIndex == y && comboBox3.SelectedIndex == z)
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                listTemp = templist;
                for (int i = 0; i < templist.Count; i++)
                {
                    listBox1.Items.Add(i + 1 + "번 문제 : " + templist[i].Quest);
                    listBox2.Items.Add(i+1+ "번 정답 : " + templist[i].Answer);                                           
                }
               

                
            }

        }

        private void FormList_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("문제 또는 정답을 입력해주세요.");
            else
            {
                listTemp.Add(new QuestSet { Quest = "", Answer = "" });
                listTemp[listTemp.Count - 1].Quest = textBox2.Text;
                listTemp[listTemp.Count - 1].Answer = textBox1.Text;

                    
            }
            printQ();


        }

        public void button2_Click(object sender, EventArgs e)
        {
            //엑셀로 저장 버튼

            string date = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            SaveFileDialog newSaveFile = new SaveFileDialog();
            newSaveFile.InitialDirectory = @"C";
            newSaveFile.Title = "Excel 저장 위치 지정";
            newSaveFile.DefaultExt = "xlsx";
            newSaveFile.Filter = "Excel File (*.xlsx) |*.xlsx| Xls files(*.xls)| *.xls| All Files (*.*) | *.*";

            if (newSaveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string path = Path.Combine(desktopPath, filename + ".xlsx");

                    excelApp = new Excel.Application();
                    workBook = excelApp.Workbooks.Add();
                    workSheet = workBook.Worksheets.get_Item(1) as Excel.Worksheet;

                    workSheet.Cells[1, 1] = "문제";
                    workSheet.Cells[1, 2] = "정답";
                    workSheet.Cells[1, 3] = "참고 자료";
                    workSheet.Cells[1, 4] = "전체 문장(교육과정)";

                    for (int i = 0; i < listTemp.Count; i++)
                    {
                        QuestSet questSet = listTemp[i];

                        workSheet.Cells[2 + i, 1] = questSet.Quest;
                        workSheet.Cells[2 + i, 2] = questSet.Answer;
                        workSheet.Cells[2 + i, 3] = questSet.Reference;
                        workSheet.Cells[2 + i, 4] = questSet.FullSentence;
                    }

                    workSheet.Columns.AutoFit();


                    workBook.SaveCopyAs(path);
                    workBook.Close(true);
                    excelApp.Quit();



                }
                finally
                {
                    ReleaseObject(workSheet);
                    ReleaseObject(workBook);
                    ReleaseObject(excelApp);
                    MessageBox.Show(filename + ".xlsx로 저장되었습니다.");

                }
            }

           

            
        }

        private static void ReleaseObject(object obj)
        {
            try
            {
                if(obj != null)
                {
                    Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }
            catch(Exception ex)
            {
                obj = null;
                throw ex;
            }
            finally
            {
                GC.Collect();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBox5.Text, out listIndex))
            {
                if (listIndex <= 0 || listIndex > listTemp.Count)
                    MessageBox.Show("문제 번호를 다시 입력해주세요.");
                else
                {
                    mod = true;
                    label10.Text = "ON";
                    textBox3.Text = listTemp[listIndex - 1].Quest;
                    textBox4.Text = listTemp[listIndex - 1].Answer;
                }
            }
            else
                MessageBox.Show("문제 번호를 올바르게 입력해주세요.");

            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (mod == true)
                {
                    listTemp[listIndex - 1].Quest = textBox3.Text;
                    listTemp[listIndex - 1].Answer = textBox4.Text;
                    textBox3.Clear();
                    textBox4.Clear();
                    mod = false;
                    label10.Text = "OFF";


                    printQ();
                }
        }

        public void printQ()
        {

            PrintQuest(0, 0, 0, GeneralQL.general_CU);
            PrintQuest(1, 0, 0, MathQL.Math_Basic_Theory);
            PrintQuest(1, 1, 0, MathQL2.math_Part_NumSys);
            PrintQuest(1, 1, 1, MathQL2.math_Part_NumCalcu);
            PrintQuest(1, 1, 2, MathQL3.math_Part_Geometry);
            PrintQuest(1, 2, 0, MathQL.math_CU_12);
            PrintQuest(1, 2, 1, MathQL.math_CU_34);
            PrintQuest(1, 2, 2, MathQL.math_CU_56);
            PrintQuest(2, 0, 0, ScienceQL.Science_Basic_Theory);
            PrintQuest(2, 1, 0, ScienceQL.Science_Particulars_Matter);
            PrintQuest(2, 1, 1, ScienceQL2.Science_Particulars_Life);
            PrintQuest(2, 1, 2, ScienceQL2.science_part_moveNenergy);
            PrintQuest(3, 0, 0, MusicQL.music_CU);
            PrintQuest(3, 1, 0, MusicQL.music_Part_34);
            PrintQuest(4, 0, 1, PracticalCourseQL.pract_CU);
            PrintQuest(5, 0, 0, EthicsQL.Ethics_edu);
            PrintQuest(6, 0, 0, EnglishQL.Eng_edu);
            PrintQuest(7, 0, 0, SocialStudiesQL.social_edu);
            PrintQuest(8, 0, 0, ArtQL.art_edu);
            

        }

        private List<QuestSet> CheckQ(int x, int y, int z, ref List<QuestSet> templist)
        {
            if (comboBox1.SelectedIndex == x && comboBox2.SelectedIndex == y && comboBox3.SelectedIndex == z)
            {
                templist = listTemp;
            }
            return templist;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedIndex = -1;
            Point point = e.Location;

            selectedIndex = listBox1.IndexFromPoint(point);

            if (selectedIndex != -1)
            {
                MessageBox.Show(listBox1.Items[selectedIndex] as string);
            }


        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedIndex = -1;
            Point point = e.Location;

            selectedIndex = listBox2.IndexFromPoint(point);

            if (selectedIndex != -1)
            {
                MessageBox.Show(listBox2.Items[selectedIndex] as string);
            }
        }
    }
}
