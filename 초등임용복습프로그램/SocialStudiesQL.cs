using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 초등임용복습프로그램
{
    class SocialStudiesQL
    {
        public static List<QuestSet> social_edu = new List<QuestSet>
        {
            new QuestSet
            {
                Quest = "사회과 교육 모형에서 바, 바스, 셔미스가 주장한 것에는 A, B, C가 있다.",
                Answer = "시민성 전달, 사회 과학, 반성적 탐구"
            },

            new QuestSet
            {
                Quest = "시민성 전달 모형에서 교육의 목표는 A 강한 시민(=B 시민)이다. 이에 따라 올바른 지식, 적절한 행동, 권위 존중, 참여, 수용과 복종 등을 강조한다.",
                Answer = "애국심, 훌륭한"
            },
            
            new QuestSet
            {
                Quest = "시민성 전달 모형의 교육 내용은 사회 유지에 필요한 A과 B이다. 이는 그것이 전통적으로 바람직하다고 간주되기 때문이다.",
                Answer = "지식, 가치"
            },

            new QuestSet
            {
                Quest = "시민성 전달 모형의 장점은 A와 B에 기여한다는 것이다. 단점은 지식 전달과 구체적 행위의 C가 떨어지며, 가치를 절대시하며 비판적 사고를 무시하고, 교육 내용을 미화하며, 기존 사회 질서와 문화를 재생산한다는 것이다.",
                Answer = "사회안정, 질서 유지, 연관성"
            },

            new QuestSet
            {
                Quest = "시민성 전달 모형의 교육 방법은 다음과 같다. ① A 전달 방식 : 설명, 해석, 주입, 암기, 반복 ② B 전달방식 : 교실 활용 = 잠재적 교육과정 ③ C 전달 방식 : 제한적 탐구 → 소극적 학습자관",
                Answer = "직접적, 간접적, 탐구 지향적"
            },

            new QuestSet
            {
                Quest = "사회과학 모형의 교육 목표는 A를 양성하는 것이다. 즉 B를 기르는 것에 초점을 맞춘다.",
                Answer = "꼬마 사회과학자, 탐구능력",
                Reference = "사회과학자의 관점, 탐구 방법, 사고방식을 습득하기"
            },

            new QuestSet
            {
                Quest = "사회과학 모형의 교육 내용은 A적 탐구 방법과 A의 B 및 C을 하는 것이다. 이때 B은 범주화·추상화하여 표현할 수 있는 것을 의미하고, C는 개념 사이의 연관성을 진술한 것을 말한다. ",
                Answer = "사회과학, 개념, 일반화"
            },

            new QuestSet
            {
                Quest = "사회과학 모형의 단점은 탐구력과 A로의 실행이 불분명하다는 것이다. 가치중립적 지식은 가치 A를 지시하지 않고, 객관적 지식은 구체적 A를 지시하지 않는다.",
                Answer = "행위"
            },

            new QuestSet
            {
                Quest = "사회과학 모형의 교육방법은 A이며, 이것이 A 모형의 토대가 된다.",
                Answer = "탐구학습"
            },

            new QuestSet
            {
                Quest = "반성적 탐구 모형의 교육 목표는 (사회 문제-쟁점에 대한) A를 양성하는 것이다. 이에 따라 B와 C를 기르는 것을 목표로 한다.",
                Answer = "합리적 의사결정자, 문제 해결 능력, 의사 결정 능력"
            },

            new QuestSet
            {
                Quest = "반성적 탐구 모형의 교육 내용은 학생의 A·B를 반영한 사회 문제이다.",
                Answer = "필요, 흥미"
            },

            new QuestSet
            {
                Quest = "반성적 탐구 모형의 교육 내용의 단점은 A 능력과 B 간의 연관성이 떨어진다는 것과, 보편적 기준과 원리를 제시하지 않는다는 것(추상적), 학생의 흥미가 낮아진다는 것이 있다.",
                Answer = "의사결정, 행위"
            },

            new QuestSet
            {
                Quest = "반성적 탐구 모형의 교육 방법은 A와 B이다. 이에 따라 문제해결/논쟁문제/의사결정 학습모형이 등장하게 된다.",
                Answer = "반성적 탐구, 토론"
            },

            new QuestSet
            {
                Quest = "넬슨, 마이클리스는 사회과를 바라보는 관점으로 A, B을 제시했다.",
                Answer = "사회 비판, 개인적 발달"
            },

            new QuestSet
            {
                Quest = "사회 비판 모형의 교육 목표는 A를 기르는 것이다.",
                Answer = "비판적 사고",
                Reference = "사회문제 비판적 분석 + 사회 개혁 방안 제시 능력"
            },

            new QuestSet
            {
                Quest = "개인적 발달 모형의 교육 목표는 A이다.",
                Answer = "잠재능력 발휘"
            },

            new QuestSet
            {
                Quest = "사회 비판 모형의 교육 내용은 A와 B이다.",
                Answer = "사회 문제, 자료"
            },

            new QuestSet
            {
                Quest = "사회 비판 모형의 교육 방법은 A와 B이다.",
                Answer = "사회 비판, 토론"
            },

            new QuestSet
            {
                Quest = "개인적 발달 모형의 교육 내용은 학생의 A, B 등을 고려한 내용이다.",
                Answer = "소질, 적성"
            },

            new QuestSet
            {
                Quest = "개인적 발달 모형의 교육 방법은 A 중심 교수학습 활동이다.",
                Answer = "학생"
            },new QuestSet
            {
                Quest = "사회과학 모형은 교수학습모형 중 A에 영향을 주었으며, B적 문제를 다룬다. 이를 통해 신장시키고자 하는 능력은 C이다.",
                Answer = "탐구학습모형, 사회과학, 탐구능력"
            },

            new QuestSet
            {
                Quest = "반성적 탐구 모형은 교수학습모형 중 A(사회적 문제), B(사회적 + 개인적 문제)에 영향을 주었다. 이때 사실과 가치가 혼재되어 있다. 다루는 문제의 특성은 C 속 문제라는 것이다. 신장시키고자 하는 능력은 D, E이다.",
                Answer = "논쟁문제학습모형, 의사결정학습모형, 일상생활, 문제해결능력, 의사결정능력"
            },

            new QuestSet
            {
                Quest = "A는 민주적인 사회의 형성자로서의 시민에게 필요한 제 특성을 가리킨다.",
                Answer = "시민적 자질",
                Reference = "합리적인 의사결정 능력"
            },

            /*

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            },*/

        };
            
    }
}
