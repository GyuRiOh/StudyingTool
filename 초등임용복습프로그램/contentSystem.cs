using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 초등임용복습프로그램
{
    public partial class contentSystem : Form
    {
        string AnswerTemp = "";
        string Quest = "[?]";
        List<List<bool>> cellLocal = new List<List<bool>>();
        int rowRandom = 0;
        int cellRandom = 0;

        private List<ConSysData> musicSys = new List<ConSysData>
        {

             new ConSysData
             {
                 area = "표현",
                 coreConcept = "소리의 상호 작용" + Environment.NewLine + "음악의 표현 방법",
                 content34 = "음악의 구성" + Environment.NewLine + "자세와 연주법",
                 content56 = "음악의 구성" + Environment.NewLine + "자세와 연주법",
                 function = "노래 부르기" + Environment.NewLine + "악기로 연주하기" + Environment.NewLine + "신체표현하기" + Environment.NewLine + "만들기" + Environment.NewLine + "표현하기"
      
            },

            new ConSysData
            {
                area = "감상",
                coreConcept = "음악 요소와 개념" + Environment.NewLine + "음악의 종류" + Environment.NewLine + "음악의 표현 방법",
                content34 = "3~4학년 수준의 음악 요소와 개념" + Environment.NewLine + "5~6학년 수준의 음악 요소와 개념",
                content56 = "상황이나 이야기 등을 표현한 음악" + Environment.NewLine + "다양한 문화권의 음악",
                function = "구별하기" + Environment.NewLine + "표현하기" + Environment.NewLine + "발표하기"
               

            },

            new ConSysData
            {

                area = "생활화",
                coreConcept = "음악의 활용" + Environment.NewLine + "음악을 즐기는 태도",
                content34 = "음악과 행사" + Environment.NewLine + "음악과 놀이" + Environment.NewLine + "생활 속의 국악",
                content56 = "음악과 행사" + Environment.NewLine + "음악과 건강" + Environment.NewLine + "국악과 문화유산",
                function = "참여하기" + Environment.NewLine + "조사하기" + Environment.NewLine + "발표하기"

                
            }
                    
            


    };
        private List<ConSysData> musicConcept = new List<ConSysData>
        {

             new ConSysData
             {
                 coreConcept = "리듬",
                 content34 = "박, 박자" + Environment.NewLine + "장단, 장단의 세" + Environment.NewLine + "음의 길고 짧음" + Environment.NewLine + "간단한 리듬꼴" + Environment.NewLine + "장단꼴" + Environment.NewLine + "말붙임새",
                 content56 = "박, 박자" + Environment.NewLine + "장단, 장단의 세" + Environment.NewLine + "-" + Environment.NewLine + "여러 가지 리듬꼴" + Environment.NewLine + "장단꼴" + Environment.NewLine + "말붙임새"

            },

            new ConSysData
            {
                coreConcept = "가락",
                content34 = "음의 높고 낮음" + Environment.NewLine + "차례가기와 뛰어가기" + Environment.NewLine + "-" + Environment.NewLine + "시김새",
                content56 = "음이름, 계이름, 율명" + Environment.NewLine + "장음계, 단음계" + Environment.NewLine + "여러 지역의 토리" + Environment.NewLine + "시김새"


            },

            new ConSysData
            {

                coreConcept = "화성",
                content34 = "-" + Environment.NewLine + "소리의 어울림",
                content56 = "주요 3화음" + Environment.NewLine + "다양한 소리의 어울림"


            },

            new ConSysData
            {

                coreConcept = "형식",
                content34 = "형식(메기고 받는 형식, ab 등)",
                content56 = "형식(긴자진 형식, 시조 형식, aba, AB 등)",


            },

            new ConSysData
            {

                coreConcept = "셈여림",
                content34 = "셈여림",
                content56 = "셈여림의 변화",


            },

            new ConSysData
            {

                coreConcept = "빠르기",
                content34 = "빠르기/한배",
                content56 = "빠르기의 변화/한배의 변화",


            },

            new ConSysData
            {

                coreConcept = "음색",
                content34 = "목소리, 물체 소리, 타악기의 음색",
                content56 = "관악기, 현악기의 음색",


            }




    };

        private List<ConSysData> artSys = new List<ConSysData>
        {
            new ConSysData
            {
                area = "체험",
                coreConcept = "지각" + Environment.NewLine + "소통" + Environment.NewLine + "연결",
                content34 = "지각 : 자신의 감각" + Environment.NewLine + "지각 : 대상의 탐색"+ Environment.NewLine + "연결 : 미술과 생활",
                content56 = "체험 : 자신과 대상" + Environment.NewLine + "소통 : 이미지와 의미"+ Environment.NewLine + "연결 : 미술과 타 교과",
                function = "감각 활용하기"+ Environment.NewLine + "탐색하기" + Environment.NewLine + "반응하기" + Environment.NewLine + "발견하기" + Environment.NewLine + "나타내기" + Environment.NewLine + "관련짓기"



            },

            new ConSysData
            {
                 area = "표현",
                coreConcept = "발상" + Environment.NewLine + "제작",
                content34 = "발상 : 다양한 주제" + Environment.NewLine + "발상 : 상상과 관찰"+ Environment.NewLine + "제작 : 표현 계획"+ Environment.NewLine +"제작 : 조형 요소"+ Environment.NewLine + "제작 : 표현 재료와 용구",
                content56 = "발상 : 소재와 주제" + Environment.NewLine + "발상 : 발상 방법"+ Environment.NewLine + "제작 : 조형 원리"+ Environment.NewLine +"제작 : 표현 방법"+ Environment.NewLine + "제작 : 제작 발표",
                function = "관찰하기"+ Environment.NewLine + "상상하기" + Environment.NewLine + "계획하기" + Environment.NewLine + "방법 익히기" + Environment.NewLine + "발전시키기" + Environment.NewLine + "구체화하기" +Environment.NewLine + "표현하기"
            },

            new ConSysData
            {

                area = "감상",
                coreConcept = "이해" + Environment.NewLine + "비평",
                content34 = "이해 : 작품과 미술가" + Environment.NewLine + "비평 : 작품에 대한 느낌과 생각"+ Environment.NewLine + "비평 : 감상 태도",
                content56 = "이해 : 작품과 배경" + Environment.NewLine + "비평 : 작품의 내용과 형식"+ Environment.NewLine + "비평 : 감상 방법",
                function = "이해하기"+ Environment.NewLine + "설명하기" + Environment.NewLine + "비교하기" + Environment.NewLine + "분석하기" + Environment.NewLine + "존중하기"
            }

        };

        private List<ConSysData> practCourseSys = new List<ConSysData>
        {
            new ConSysData
            {
                area = "인간 발달과 가족",
                coreConcept = "발달"+ Environment.NewLine + "관계",
                content34 = "",
                content56 = "발달 : 아동기 발달의 특징" + Environment.NewLine +"발달 : 아동기 성의 발달" + Environment.NewLine +"관계 : 나와 가족의 관계"+ Environment.NewLine +"관계 : 가족의 요구 살피기와 돌봄",
                function = "탐색하기"+ Environment.NewLine + "계획하기" + Environment.NewLine+ "실천하기"
            },
            
            new ConSysData
            {
                area = "가정 생활과 안전",
                coreConcept = "생활 문화" + Environment.NewLine + "안전",
                content34 = "",
                content56 = "생활 문화 : 균형 잡힌 식생활" + Environment.NewLine +"생활 문화 : 식재료의 특성과 음식의 맛" + Environment.NewLine +"생활 문화 : 옷 입기와 의생활 예절"+ Environment.NewLine +"생활 문화 : 생활 소품 만들기"+ Environment.NewLine +"안전 : 안전한 옷차림"+ Environment.NewLine +"안전 : 생활 안전사고의 예방"+ Environment.NewLine +"안전 : 안전한 식품 선택과 조리",
                function = "조작하기" + Environment.NewLine + "활용하기" + Environment.NewLine + "적용하기"
            },

            new ConSysData
            {
                area = "자원 관리와 자립",                
                coreConcept = "관리" + Environment.NewLine + "생애 설계",
                content34 = "",
                content56 = "관리 : 시간·용돈 관리" + Environment.NewLine + "관리 : 옷의 정리와 보관" + Environment.NewLine + "관리 : 정리정돈과 재활용" + Environment.NewLine + "생애 설계 : 가정생활과 일" + Environment.NewLine + "생애 설계 : 가정일의 분담과 실천",
                function = "종합하기" + Environment.NewLine + "평가하기" 
            },

            new ConSysData
            {
                area = "기술 시스템",
                coreConcept = "창조" + Environment.NewLine + "효율" + Environment.NewLine + "소통",
                content34 = "",
                content56 = "창조 : 생명 기술 시스템" + Environment.NewLine + "창조 : 식물 가꾸기" + Environment.NewLine + "창조 : 동물 돌보기" + Environment.NewLine + "효율 : 수송 기술과 생활" + Environment.NewLine + "효율 : 수송 수단의 안전 관리" + Environment.NewLine + "소통 : 소프트웨어의 이해" + Environment.NewLine + "소통 : 절차적 문제 해결" + Environment.NewLine + "소통 : 프로그래밍 요소와 구조",
                function = "제안하기" + Environment.NewLine + "설계하기" + Environment.NewLine + "제작하기" + Environment.NewLine + "실행하기"
            },

            new ConSysData
            {
                area = "기술 활용",
                coreConcept = "적응" + Environment.NewLine + "혁신" + Environment.NewLine + "지속 가능",
                content34 = "",
                content56 = "적응 : 일과 직업의 세계" + Environment.NewLine + "적응 : 자기 이해와 직업 탐색" + Environment.NewLine + "혁신 : 발명과 문제 해결" + Environment.NewLine + "혁신 : 개인 정보와 지식 재산 보호" + Environment.NewLine + "혁신 : 로봇의 기능과 구조" + Environment.NewLine + "지속 가능 : 친환경 미래 농업" + Environment.NewLine + "지속 가능 : 생활 속의 농업 체험",
                function = "판단하기" + Environment.NewLine + "조사하기" + Environment.NewLine + "추론하기"

            }
            
        };

        private List<ConSysData> physicsSys = new List<ConSysData>
        {
            new ConSysData
            {
                area = "건강",
                coreConcept = "건강 관리" + Environment.NewLine + "체력 증진" + Environment.NewLine + "여가 선용" + Environment.NewLine + "자기 관리",
                content34 = "건강한 생활 습관, 건강한 여가 생활" + Environment.NewLine + "운동과 체력, 체력 운동 방법" + Environment.NewLine + "자기 인식, 실천 의지",
                content56 = "건강한 성장 발달, 운동과 여가 생활" + Environment.NewLine + "건강 체력의 증진, 운동 체력의 증진" + Environment.NewLine + "자기 수용, 근면성",
                function = "평가하기" + Environment.NewLine + "계획하기" + Environment.NewLine + "관리하기" + Environment.NewLine + "실천하기"
            },

            new ConSysData
            {
                area = "도전",
                coreConcept = "도전 의미" + Environment.NewLine + "목표 설정" + Environment.NewLine + "신체·정신 수련" + Environment.NewLine + "도전 정신",
                content34 = "속도 도전의 의미, 동작 도전의 의미" + Environment.NewLine + "속도 도전 활동의 기본 기능, 동작 도전 활동의 기본 기능" + Environment.NewLine + "속도 도전 활동의 방법, 기본 기능 동작 도전 활동의 방법" + Environment.NewLine + "끈기, 자신감",
                content56 = "거리 도전의 의미, 표적/투기 도전의 의미" + Environment.NewLine + "거리 도전 활동의 기본 기능, 표적/투기 도전 활동의 기본 기능" + Environment.NewLine + "거리 도전 활동의 방법, 표적/투기 도전 활동의 방법"+ Environment.NewLine+"적극성, 겸손",
                function = "시도하기" + Environment.NewLine + "분석하기" + Environment.NewLine + "수련하기" + Environment.NewLine + "극복하기"

            },
            
            new ConSysData
            {
                area = "경쟁",
                coreConcept = "경쟁 의미" + Environment.NewLine + "상황 판단" + Environment.NewLine + "경쟁·협동 수행" + Environment.NewLine + "대인 관계",
                content34 = "경쟁 활동의 의미, 영역형 경쟁의 의미" + Environment.NewLine + "경쟁 활동의 기초 기능, 영역형 게임의 기본 기능" + Environment.NewLine + "경쟁 활동의 방법과 기본 전략, 영역형 게임의 방법과 기본 전략" + Environment.NewLine + "규칙 준수, 협동심",
                content56 = "필드형 경쟁의 의미, 네트형 경쟁의 의미" + Environment.NewLine + "필드형 게임의 기본 기능, 네트형 게임의 기본 기능" + Environment.NewLine + "필드형 게임의 방법과 기본 전략, 네트형 게임의 방법과 기본 전략"+ Environment.NewLine + "책임감, 배려",
                function = "분석하기" + Environment.NewLine + "협력하기" + Environment.NewLine + "의사소통 하기"+ Environment.NewLine + "경기 수행 하기"
            },

            new ConSysData
            {
                area = "표현",
                coreConcept = "표현 의미" + Environment.NewLine + "표현 양식" + Environment.NewLine + "표현 창작" + Environment.NewLine + "감상·비평",
                content34 = "움직임 표현의 의미, 리듬 표현의 의미" + Environment.NewLine + "움직임 표현의 기본 동작, 리듬 표현의 기본 동작" + Environment.NewLine + "움직임 표현의 구성 방법, 리듬 표현의 구성 방법" + Environment.NewLine + "신체 인식, 민감성",
                content56 = "민속 표현의 의미, 주제 표현의 의미" + Environment.NewLine + "민속 표현의 기본 동작, 주제 표현의 기본 동작" + Environment.NewLine + "민속 표현의 구성 방법, 주제 표현의 구성 방법" + Environment.NewLine + "개방성, 독창성",
                function = "탐구하기" + Environment.NewLine + "신체 표현 하기" + Environment.NewLine + "감상하기" + Environment.NewLine + "의사소통 하기"
            },

            new ConSysData
            {
                area = "안전",
                coreConcept = "신체 안전" + Environment.NewLine + "안전 의식",
                content34 = "신체활동과 안전, 운동장비와 안전" + Environment.NewLine + "수상 활동 안전, 게임 활동 안전" + Environment.NewLine + "위험 인지, 조심성",
                content56 = "응급 처치, 운동시설과 안전" + Environment.NewLine + "빙상·설상 활동 안전" + Environment.NewLine + "침착성, 상황 판단력",
                function = "상황 파악하기" + Environment.NewLine + "의사 결정 하기" + Environment.NewLine + "대처하기" + Environment.NewLine + "습관화 하기"
            }


        };
        public contentSystem()
        {
            InitializeComponent();
            comboBox1.Text = "과목";
            comboBox2.Text = "빈칸 개수";
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {

                callSubList(0, musicSys);
                callSubList(1, artSys);
                callSubList(2, practCourseSys);
                callSubList(3, physicsSys);
                callSubList(4, musicConcept);



        }

        private void callSubList (int x, List<ConSysData> templist)
        {

            try
            {
                if (comboBox1.SelectedIndex == x)
                {
                    dataGridView1.DataSource = templist;

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        cellLocal.Add(new List<bool>());

                        for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        {
                            cellLocal[i].Add(true);

                        }
                    }


                    randomCall(comboBox2.SelectedIndex + 1, templist);
                    comboBox2.Hide();

                }
            }

            catch(Exception ex)
            {

                MessageBox.Show("에러!");
                throw ex;
            }


        }

        private void randomCall(int x, List<ConSysData> templist)
        {

            try
            {
                Random random = new Random();

                dataGridView1.DataSource = templist;

                rowRandom = random.Next(0, dataGridView1.Rows.Count);
                cellRandom = random.Next(0, dataGridView1.ColumnCount);

                if (x == 7)
                {
                    x = dataGridView1.RowCount * dataGridView1.ColumnCount;
                }

                for (int i = 0; i < x; i++)
                {


                    while (cellLocal[rowRandom][cellRandom] == false)
                    {

                        rowRandom = random.Next(0, dataGridView1.Rows.Count);
                        cellRandom = random.Next(0, dataGridView1.ColumnCount);
                    }

                    cellLocal[rowRandom][cellRandom] = false;


                    AnswerTemp = dataGridView1.Rows[rowRandom].Cells[cellRandom].Value.ToString();
                    dataGridView1[cellRandom, rowRandom].Value = Quest;
                    i++;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("에러");
                throw ex;
            }
        }

        public void integratedeSubCall()
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
