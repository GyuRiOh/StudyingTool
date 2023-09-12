using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace 초등임용복습프로그램
{
    public partial class WrongAnswerNote : Form
    {
        static string filename = "";

        static Excel.Application excelApp = null;
        static Excel.Workbook workBook = null;
        static Excel.Worksheet workSheet = null;
        public WrongAnswerNote()
        {
            InitializeComponent();
            

        }

        private void WrongAnswerNote_Load(object sender, EventArgs e)
        {
            int x = 0;
            for ( int i = 0; i < WrongAnswer.wrongTemp.Count; i++)
            {
                listBox1.Items.Insert(x, "★" + WrongAnswer.wrongTemp[i].Quest );
                listBox1.Items.Insert(x+1, "답 : " + WrongAnswer.wrongTemp[i].Answer);

                x += 2;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSW_Click(object sender, EventArgs e)
        {
            StreamWriter sw;
            string date = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            sw = new StreamWriter(date + "-오답노트.txt");
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox1.Items[i] += "\r\n";

                sw.Write(listBox1.Items[i]);
            }

            sw.Close();

            Process.Start(date + "-오답노트.txt");

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string date = DateTime.Now.ToString("yyyy-MM-dd");
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
                    workSheet.Cells[1, 5] = "날짜";
                    workSheet.Cells[1, 6] = "오답";

                    for (int i = 0; i < WrongAnswer.wrongTemp.Count; i++)
                    {
                        QuestSet questSet = WrongAnswer.wrongTemp[i];

                        workSheet.Cells[2 + i, 1] = questSet.Quest;
                        workSheet.Cells[2 + i, 2] = questSet.Answer;
                        workSheet.Cells[2 + i, 5] = date;
                        workSheet.Cells[2 + i, 6] = questSet.WrongAnswer;
 
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
        private void button2_Click(object sender, EventArgs e)
        {
            WrongAnswer.wrongTemp.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.Clear();
            for (int i = 0; i < WrongAnswer.wrongTemp.Count; i++)
            {
                listBox1.Items.Insert(i, WrongAnswer.wrongTemp[i]);
            }
        }
    }
}
