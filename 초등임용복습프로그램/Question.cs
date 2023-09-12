using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 초등임용복습프로그램
{
    public class QuestSet
    {
        public string Quest { get; set; }
        public string Answer { get; set; }
        public string FullSentence { get; set; }

        public string Reference { get; set; }

        public string WrongAnswer { get; set; }

        



        public static void randomCall(int x, int y, int z, List<QuestSet> listTemp)
        {
          
            Random random = new Random();           

            if (Form1.combo1 == x && Form1.combo2 == y && Form1.combo3 == z)
            {
                Form1.questNumTemp = listTemp.Count;               
                int randomNum = random.Next(0, listTemp.Count);

                if (listTemp.Count == 0)
                    Form1.textTemp = "더이상 표시할 문제가 없습니다.";
                else
                {
                    Form1.questionTemp = listTemp[randomNum].Quest;
                    Form1.answerSave = listTemp[randomNum].Answer;
                    Form1.refTemp = listTemp[randomNum].Reference;
                    Form1.textTemp = Form1.questionTemp;
                    listTemp.RemoveAt(randomNum);




                }
            }


        }

        public static void sequenceCall(int x, int y, int z, List<QuestSet> listTemp)
        {
           
            if (Form1.combo1 == x && Form1.combo2 == y && Form1.combo3 == z)
            {
                Form1.questNumTemp = listTemp.Count;
                if (listTemp.Count == 0)
                    Form1.textTemp = "더이상 표시할 문제가 없습니다.";
                else
                {
                    if (Form1.num == listTemp.Count)
                    {
                        Form1.textTemp = "문제가 끝났습니다. 문제 번호를 초기화합니다.";
                        Form1.num = 0;
                    }

                    else
                    {
                        Form1.questNumTemp = listTemp.Count;
                        Form1.questionTemp = listTemp[Form1.num].Quest;
                        Form1.answerSave = listTemp[Form1.num].Answer;
                        Form1.refTemp = listTemp[Form1.num].Reference;
                        Form1.textTemp = Form1.questionTemp;
                        Form1.num++;
                    }
                }


            }
        }


    }


    public class ModelSet : QuestSet
    {

        public string name { get; set; }
        public List<string> model = new List<string>();
        public string chunk { get; set; }

    }

    


}
