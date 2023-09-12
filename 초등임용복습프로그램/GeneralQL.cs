using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 초등임용복습프로그램
{
    class GeneralQL
    {
        public static List<QuestSet> general_CU = new List<QuestSet>
        {
            new QuestSet
            {
                Quest = "이 교육과정은 A 제23조 제2항에 의거하여 고시한 것으로, 초중등학교의 교육 목적과 교육 목표를 달성하기 위한 국가 수준의 교육과정이며, 초중등학교에서 B,C하여야 할 D 교육과정의 E적이고 F적인 G을 H한 것이다.",
                Answer = "초중등교육법, 편성, 운영, 학교, 공통, 일반, 기준, 제시",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "가. 국가 수준의 A와 지역, 학교, 개인 수준의 B를 동시에 추구하는 교육과정이다.",
                Answer = "공통성, 다양성",
                FullSentence = "국가 수준의 공통성과 지역, 학교, 개인 수준의 다양성을 동시에 추구하는 교육과정이다."
            },

            new QuestSet
            {
                Quest = "나. 학습자의 A과 B을 신장하기 위한 C의 교육과정이다.",
                Answer = "자율성, 창의성, 학생 중심",
                FullSentence = "학습자의 자율성과 창의성을 신장하기 위한 학생 중심의 교육과정이다."
            },

            new QuestSet
            {
                Quest = "다. 학교와 교육청, A, 교원·학생·학부모가 함께 실현해 가는 교육과정이다.",
                Answer = "지역사회",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "라. 학교 교육 체제를 A으로 구현하기 위한 교육과정이다.",
                Answer = "교육과정 중심",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "마. 학교 교육의 A적 수준을 B하고 개선하기 위한 교육과정이다.",
                Answer = "질, 관리",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "우리나라의 교육은 A의 이념 아래 모든 국민으로 하여금 인격을 도야하고, 자주적 생활 능력과 민주 시민으로서 필요한 자질을 갖추게 함으로써 인간다운 삶을 영위하게 하고, 민주 국가의 발전과 인류 공영의 이상을 실현하는 데에 이바지하게 함을 목적으로 하고 있다.",
                Answer = "홍익인간",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "가. A을 바탕으로 B을 확립하고 자신의 진로와 삶을 개척하는 C적인 사람",
                Answer = "전인적 성장, 자아정체성, 자주",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "나. A의 바탕 위에 다양한 발상과 도전으로 새로운 것을 창출하는 B적인 사람.",
                Answer = "기초 능력, 창의",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "다. 문화적 소양과 다원적 가치에 대한 이해를 바탕으로 인류 문화를 향유하고 발전시키는 A 사람.",
                Answer = "교양 있는",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "라. A을 가지고 세계와 소통하는 민주 시민으로서 배려와 나눔을 B하는 C 사람",
                Answer = "공동체 의식, 실천, 더불어 사는",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "2015개정교육과정 핵심역량 6가지를 서술하시오.",
                Answer = "공동체 역량, 자기관리 역량, 의사소통 역량, 심미적 감성 역량, 지식정보처리 역량, 창의적 사고 역량",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "가. A과 자신감을 가지고 B의 삶과 진로에 필요한 기초 능력과 자질을 갖추어 C적으로 살아갈 수 있는 D 역량",
                Answer = "자아정체성, 자신, 자기주도, 자기관리",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "나. 문제를 합리적으로 해결하기 위하여 다양한 영역의 A과 B를 처리하고 활용할 수 있는 C 역량",
                Answer = "지식, 정보, 지식정보처리",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "다. 폭넓은 기초 지식을 바탕으로 다양한 전문 분야의 지식, 기술, 경험을 A으로 활용하여 B 것을 C하는 D 역량",
                Answer = "융합적, 새로운, 창출, 창의적 사고",
                FullSentence = "폭넓은 기초 지식을 바탕으로 다양한 전문 분야의 지식, 기술, 경험을 융합적으로 활용하여 새로운 것을 창출하는 창의적 사고 역량"

            },

            new QuestSet
            {
                Quest = "라. 인간에 대한 공감적 이해와 문화적 A을 바탕으로 삶의 의미와 가치를 발견하고 B하는 C 역량",
                Answer = "감수성, 향유, 심미적 감성 역량",
                FullSentence = "인간에 대한 공감적 이해와 문화적 감수성을 바탕으로 삶의 의미와 가치를 발견하고 향유하는 심미적 감성 역량"

            },

            new QuestSet
            {
                Quest = "마. 다양한 상황에서 자신의 생각과 감정을 효과적으로 A하고 다른 사람의 의견을 B하며 존중하는 C 역량",
                Answer = "표현, 경청, 의사소통",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "바. 지역·국가·세계 A의 구성원에게 요구되는 가치와 태도를 가지고 A 발전에 적극적으로 B하는 A 역량",
                Answer = "공동체, 참여",
                FullSentence = "지역·국가·세계 공동체의 구성원에게 요구되는 가치와 태도를 가지고 공동체 발전에 적극적으로 참여하는 공동체 역량"

            },

            new QuestSet
            {
                Quest = "이 교육과정은 우리나라 교육과정이 추구해 온 교육 A과 B을 바탕으로, 미래 사회가 요구하는 C을 함양하여 바른 D을 갖춘 E를 양성하는 데에 F를 둔다. 이를 위한 교육과정 구성의 F은 다음과 같다.",
                Answer = "이념, 인간상, 핵심역량, 인성, 창의융합형 인재, 중점",
                FullSentence = "이 교육과정은 우리나라 교육과정이 추구해 온 교육 이념과 인간상을 바탕으로, 미래 사회가 요구하는 핵심역량을 함양하여 바른 인성을 갖춘 창의융합형 인재를 양성하는 데에 중점을 둔다. 이를 위한 교육과정 구성의 중점은 다음과 같다."

            },

            new QuestSet
            {
                Quest = "가. A·사회·B 기초 소양을 균형있게 함양하고, 학생의 적성과 진로에 따른 선택학습을 강화한다.",
                Answer = "인문, 과학기술",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "나. 교과의 A을 중심으로 학습 내용을 B하고 학습량을 C하여 학습의 D한다.",
                Answer = "핵심 개념, 구조화, 적정화, 질을 개선",
                FullSentence = "교과의 핵심 개념을 중심으로 학습 내용을 구조화하고 학습량을 적정화하여 학습의 질을 개선한다."

            },

            new QuestSet
            {
                Quest = "다. 교과 특성에 맞는 다양한 A을 활성화하여 B을 기르고 학습의 C을 경험하도록 한다. ",
                Answer = "학생 참여형 수업, 자기주도적 학습 능력, 즐거움",
                FullSentence = "교과 특성에 맞는 다양한 학생 참여형 수업을 활성화하여 자기주도적 학습 능력을 기르고 학습의 즐거움을 경험하도록 한다."

            },

            new QuestSet
            {
                Quest = "라. 학습의 A을 중시하는 B를 강화하여 학생이 자신의 학습을 C하도록 하고, B 결과를 활용하여 교수·학습의 D을 E한다.",
                Answer = "과정, 평가, 성찰, 질, 개선",
                FullSentence = "학습의 과정을 중시하는 평가를 강화하여 학생이 자신의 학습을 성찰하도록 하고, 평가 결과를 활용하여 교수·학습의 질을 개선한다."

            },

            new QuestSet
            {
                Quest = "마. 교과의 교육 A, 교육 B, 교수·학습 및 C의 D을 강화한다.",
                Answer = "목표, 내용, 평가, 일관성",
                FullSentence = "교과의 교육 목표, 교육 내용, 교수·학습 및 평가의 일관성을 강화한다."

            },

            new QuestSet
            {
                Quest = "초등학교 교육 목표 : 초등학교 교육은 학생의 A과 B에 필요한 C을 기르고, D을 함양하는 데에 중점을 둔다.",
                Answer = "일상생활, 학습, 기본 습관 및 기초 능력, 바른 인성",
                FullSentence = "초등학교 교육은 학생의 일상생활과 학습에 필요한 기본 습관 및 기초 능력을 기르고, 바른 인성을 함양하는 데에 중점을 둔다."

            },

            new QuestSet
            {
                Quest = "1) 자신의 A을 알고 건강한 B을 기르며, 풍부한 C을 통해 자신의 D을 키운다.",
                Answer = "소중함, 생활 습관, 학습 경험, 꿈",
                FullSentence = "자신의 소중함을 알고 건강한 생활 습관을 기르며, 풍부한 학습 경험을 통해 자신의 꿈을 키운다."

            },

            new QuestSet
            {
                Quest = "2) 학습과 생활에서 A를 발견하고 해결하는 B을 기르고, 이를 새롭게 경험할 수 있는 C을 키운다.",
                Answer = "문제, 기초 능력, 상상력",
                FullSentence = "학습과 생활에서 문제를 발견하고 해결하는 기초 능력을 기르고, 이를 새롭게 경험할 수 있는 상상력을 키운다."

            },

            new QuestSet
            {
                Quest = "3) 다양한 A을 즐기고 B과 C 속에서 D과 E을 느낄 수 있는 F을 기른다.",
                Answer = "문화 활동, 자연, 생활, 아름다움, 행복, 심성",
                FullSentence = "다양한 문화 활동을 즐기고 자연과 생활 속에서 아름다움과 행복을 느낄 수 있는 심성을 기른다."

            },

            new QuestSet
            {
                Quest = "4) A과 B를 지키고 C을 바탕으로 서로 돕고 배려하는 태도를 기른다.",
                Answer = "규칙, 질서, 협동정신",
                FullSentence = "규칙과 질서를 지키고 협동정신을 바탕으로 서로 돕고 배려하는 태도를 기른다."

            },

            new QuestSet
            {
                Quest = "학교 급별 교육과정 편성·운영의 기준 : 나. A 간 상호 연계와 협력을 통해 학교 교육과정을 B하게 편성·운영할 수 있도록 C을 D한다.",
                Answer = "학년, 유연, 학년군, 설정",
                FullSentence = "학년 간 상호 연계와 협력을 통해 학교 교육과정을 유연하게 편성·운영할 수 있도록 학년군을 설정한다."

            },

            new QuestSet
            {
                Quest = "학교 급별 교육과정 편성·운영의 기준 : 다. 공통 교육과정의 교과는 교육 목적상의 A, 학문 탐구 대상 또는 방법상의 B, 생활양식에서의 C 등을 고려하여 D으로 E한다.",
                Answer = "근접성, 인접성, 연관성, 교과군, 재분류",
                FullSentence = "공통 교육과정의 교과는 교육 목적상의 근접성, 학문 탐구 대상 또는 방법상의 인접성, 생활양식에서의 연관성 등을 고려하여 교과군으로 재분류한다."

            },

            new QuestSet
            {
                Quest = "학교 급별 교육과정 편성·운영의 기준 : 바. A을 B하고, 의미 있는 C 활동이 이루어질 수 있도록 D당 이수 E를 조정하여 F를 실시할 수 있다.",
                Answer = "학습 부담, 적정화, 학습, 학기, 교과목 수, 집중이수",
                FullSentence = "학습 부담을 적정화하고, 의미 있는 학습 활동이 이루어질 수 있도록 학기당 이수 교과목 수를 조정하여 집중이수를 실시할 수 있다."

            },

            new QuestSet
            {
                Quest = "학교 급별 교육과정 편성·운영의 기준 : 사. A은 학생의 소질과 잠재력을 계발하고 B을 기르는 데에 중점을 둔다.",
                Answer = "창의적 체험활동, 공동체 의식",
                FullSentence = "창의적 체험활동은 학생의 소질과 잠재력을 계발하고 공동체 의식을 기르는 데에 중점을 둔다."

            },

            new QuestSet
            {
                Quest = "학교 급별 교육과정 편성·운영의 기준 : 아. A는 교과와 창의적 체험활동 등 교육 활동 전반에 걸쳐 통합적으로 다루도록 하고, 지역사회 및 가정과 연계하여 지도한다.",
                Answer = "범교과 학습 주제",
                FullSentence = "범교과 학습 주제는 교과와 창의적 체험활동 등 교육 활동 전반에 걸쳐 통합적으로 다루도록 하고, 지역사회 및 가정과 연계하여 지도한다."

            },

            new QuestSet
            {
                Quest = "학교 급별 교육과정 편성·운영의 기준 : 자. 학교는 필요에 따라 A을 실시할 수 있으며, 이 경우 A 지침에 따른다.",
                Answer = "계기 교육",
                FullSentence = "학교는 필요에 따라 계기 교육을 실시할 수 있으며, 이 경우 계기 교육 지침에 따른다."

            },

            new QuestSet
            {
                Quest = "학교 급별 교육과정 편성·운영의 기준 : 나-1). 학교는 모든 교육 활동을 통해 학생의 A, B, C을 함양할 수 있도록 교육과정을 편성·운영한다.",
                Answer = "기본 생활 습관, 기초 학습 능력, 바른 인성",
                FullSentence = "학교는 모든 교육 활동을 통해 학생의 기본 생활 습관, 기초 학습 능력, 바른 인성을 함양할 수 있도록 교육과정을 편성·운영한다."

            },

            new QuestSet
            {
                Quest = "학교 급별 교육과정 편성·운영의 기준 : 나-3). 학교는 각 교과의 A, B 요소들이 체계적으로 학습되도록 교육과정을 편성·운영한다. 특히 C과 D의 기초가 부족한 학생들을 대상으로 기초 학습 능력 향상을 위한 별도의 프로그램을 편성·운영할 수 있다.",
                Answer = "기초적, 기본적, 국어 사용 능력, 수리 능력",
                FullSentence = "학교는 각 교과의 기초적, 기본적 요소들이 체계적으로 학습되도록 교육과정을 편성·운영한다. 특히 국어 사용 능력과 수리 능력의 기초가 부족한 학생들을 대상으로 기초 학습 능력 향상을 위한 별도의 프로그램을 편성·운영할 수 있다."

            },

            new QuestSet
            {
                Quest = "학교 급별 교육과정 편성·운영의 기준 : 나-4) 학교는 학교의 특성, 학생·교사·학부모의 요구 및 필요에 따라 A에서 시수를 증감하여 편성·운영할 수 있다. 단 B, C 교과는 D를 감축하여 편성·운영할 수 없다.",
                Answer = "교과(군)별 20% 범위 내, 체육, 예술(음악/미술) 교과, 기준 수업 시수",
                FullSentence = "학교는 학교의 특성, 학생·교사·학부모의 요구 및 필요에 따라 교과(군) 별 20% 범위 내에서 시수를 증감하여 편성·운영할 수 있다. 단, 체육, 예술(음악/미술) 교과는 기준 수업 시수를 감축하여 편성·운영할 수 없다."

            },

            new QuestSet
            {
                Quest = "학교 급별 교육과정 편성·운영의 기준 : 나-5) 학교는 교육의 효과를 높이기 위하여 필요한 경우 학년별, 학기별로 A를 실시할 수 있다.",
                Answer = "교과 집중 이수",
                FullSentence = "학교는 교육의 효과를 높이기 위하여 필요한 경우 학년별, 학기별로 교과 집중 이수를 실시할 수 있다."

            },

            new QuestSet
            {
                Quest = "학교 급별 교육과정 편성·운영의 기준 : 나-6) A 학생이 특정 교과를 이수하지 못할 경우, 교육청과 학교에서는 B 학습 과정 등을 통해 학습 C이 발생하지 않도록 한다.",
                Answer = "전입, 보충, 결손",
                FullSentence = "전입 학생이 특정 교과를 이수하지 못할 경우, 교육청과 학교에서는 보충 학습 과정 등을 통해 학습 결손이 발생하지 않도록 한다."

            },

            new QuestSet
            {
                Quest = "학교 급별 교육과정 편성·운영의 기준 : 나-7) 학년을 달리하는 학생을 대상으로 A을 편성·운영하는 경우에는 교육 내용의 B를 조정하거나 공통 주제를 중심으로 C를 D하여 활용할 수 있다.",
                Answer = "복식 학급, 학년별 순서, 교재, 재구성",
                FullSentence = "학년을 달리하는 학생을 대상으로 복식 학급을 편성·운영하는 경우에는 교육 내용의 학년별 순서를 조정하거나 공통 주제를 중심으로 교재를 재구성하여 활용할 수 있다."

            },

            new QuestSet
            {
                Quest = "학교 급별 교육과정 편성·운영의 기준 : 나-8) 학교는 창의적 체험활동의 A을 학생들의 발달 수준, 학교의 여건 등을 고려하여 B별로 C으로 편성·운영할 수 있다. ",
                Answer = "영역, 학년(군), 선택적",
                FullSentence = "학교는 창의적 체험활동의 영역을 학생들의 발달 수준, 학교의 여건 등을 고려하여 학년(군)별로 선택적으로 편성·운영할 수 있다."

            },

            new QuestSet
            {
                Quest = "학교 급별 교육과정 편성·운영의 기준 : 나-9) 학교는 1학년 학생들의 A을 위해 B의 시간을 활용하여 자율적으로 C 등을 편성·운영할 수 있다.",
                Answer = "입학 초기 적응 교육, 창의적 체험활동, 입학 초기 적응 프로그램",
                FullSentence = "학교는 1학년 학생들의 입학 초기 적응 교육을 위해 창의적 체험활동의 시간을 활용하여 자율적으로 입학 초기 적응 프로그램 등을 편성·운영할 수 있다."

            },

            new QuestSet
            {
                Quest = "학교 급별 교육과정 편성·운영의 기준 : 나-10) A 교육, B 교육, C 교육 등은 관련 교과(군)와 체험활동 시간을 활용하여 체계적인 지도가 이루어질 수 있도록 한다.",
                Answer = "정보통신활용, 보건, 한자",
                FullSentence = "정보통신활용 교육, 보건 교육, 한자 교육 등은 관련 교과(군)와 체험활동 시간을 활용하여 체계적인 지도가 이루어질 수 있도록 한다."

            },

            new QuestSet
            {
                Quest = "특수한 학교에서의 교육과정 편성·운영 : 나. 국가가 설립 운영하는 학교의 교육과정은 해당 A의 B을 참고하여 C이 편성한다.",
                Answer = "시·도 교육청, 편성·운영 지침, 학교장",
                FullSentence = "국가가 설립 운영하는 학교의 교육과정은 해당 시·도 교육청의 편성·운영 지침을 참고하여 학교장이 편성한다."

            },

            new QuestSet
            {
                Quest = "특수한 학교에서의 교육과정 편성·운영 : 바. 특성화 학교, 자율 학교, 재외한국학교 등 법령에 따라 교육과정 편성·운영의 자율성이 부여되는 학교의 경우에는 학교의 설립 목적 및 특성에 따른 교육이 가능하도록 교육과정 편성·운영의 A을 부여하고, 이와 관련한 구체적인 사항은 B(재외한국학교의 경우 교육부)의 지침에 따른다.",
                Answer = "자율권, 시·도 교육청",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "특수한 학교에서의 교육과정 편성·운영 : 사. 교육과정의 연구 등을 위해 새로운 방식으로 교육과정을 편성·운영하고자 하는 학교는 A의 승인을 받아 이 교육과정의 기준과는 다르게 학교 교육과정을 편성·운영할 수 있다.",
                Answer = "교육부 장관",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 1-나. 학교는 학교 교육과정 편성·운영 계획을 바탕으로 A 및 B을 편성할 수 있다. ",
                Answer = "학년(군)별 교육과정, 교과(목)별 교육과정",
                FullSentence = "학교는 학교 교육과정 편성·운영 계획을 바탕으로 학년(군)별 교육과정 및 교과(목)별 교육과정을 편성할 수 있다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 1-라. 교육과정의 합리적 편성과 효율적 운영을 위해 A, B, C 등이 참여하는 D를 구성하여 운영하며, 이 위원회는 E의 F을 담당한다. 단, 특성화 고등학교와 산업수요 맞춤형 고등학교의 경우에는 산업계 인사가 참여할 수 있고, G이 이루어지는 학교의 경우에는 H가 참여할 것을 권장한다.",
                Answer = "교원, 교육과정 전문가, 학부모, 학교 교육과정 위원회, 학교장 교육과정 운영 및 의사 결정에 관한 자문의 역할, 통합교육, 특수교사",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 1-마. 학교 교육과정을 편성·운영할 때에는 A, B, C, D 등 교육 여건과 환경을 충분히 반영하도록 노력한다.",
                Answer = "교원의 조직, 학생의 실태, 학부모의 요구, 지역사회의 실정 및 교육 시설·설비",
                FullSentence = "학교 교육과정을 편성·운영할 때에는 교원의 조직, 학생의 실태, 학부모의 요구, 지역사회의 실정 및 교육 시설·설비 등 교육 여건과 환경을 충분히 반영하도록 노력한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 1-바. 교과와 창의적 체험활동의 내용 배열은 반드시 학습의 순서를 의미하는 것은 아니므로, A, B과 C, D에 따라 각 교과목의 E을 위한 지도 F의 G와 H, I 등을 조정하여 운영할 수 있다.",
                Answer = "지역의 특수성, 계절 및 학교의 실정, 학생의 요구, 교사의 필요, 학년군별 목표 달성, 내용, 순서, 비중, 방법",
                FullSentence = "교과와 창의적 체험활동의 내용 배열은 반드시 학습의 순서를 의미하는 것은 아니므로, 지역의 특수성, 계절 및 학교의 실정과 학생의 요구, 교사의 필요에 따라 각 교과목의 학년군별 목표 달성을 위한 지도 내용의 순서와 비중, 방법 등을 조정하여 운영할 수 있다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 1-사. 학교는 교과와 창의적 체험활동의 효율적인 운영을 위하여 A의 B을 계획적으로 활용한다.",
                Answer = "지역사회, 인적, 물적 자원",
                FullSentence = "학교는 교과와 창의적 체험활동의 효율적인 운영을 위하여 지역사회의 인적, 물적 자원을 계획적으로 활용한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 1-아. 학교는 학생의 요구, 학교의 실정 및 특색 등을 종합적으로 고려하여 창의적 체험활동의 A, B, C 등을 D적으로 E할 수 있다.",
                Answer = "영역, 활동, 시간, 자율, 편성·운영",
                FullSentence = "학교는 학생의 요구, 학교의 실정 및 특색 등을 종합적으로 고려하여 창의적 체험활동의 영역, 활동, 시간 등을 자율적으로 편성·운영할 수 있다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 1-자. 학교는 창의적 체험활동이 A이 되도록 B의 C과 D하여 프로그램을 운영할 수 있다.",
                Answer = "실질적 체험학습, 지역사회, 유관 기관, 연계·협력",
                FullSentence = "학교는 창의적 체험활동이 실질적 체험학습이 되도록 지역사회의 유관 기관과 연계·협력하여 프로그램을 운영할 수 있다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 1-차. 학교는 학생과 학부모의 요구를 바탕으로 A 또는 B을 개설할 수 있으며, 학생들의 자발적인 참여를 원칙으로 한다.",
                Answer = "방과후학교, 방학 중 프로그램",
                FullSentence = "학교는 학생과 학부모의 요구를 바탕으로 방과후학교 또는 방학 중 프로그램을 개설할 수 있으며, 학생들의 자발적인 참여를 원칙으로 한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 1-타. 학교는 A, B, C, D 등을 통해서 교사들의 교육 활동 개선이 이루어지도록 한다.",
                Answer = "동학년 모임, 교과별 모임, 현장 연구, 자체 연수",
                FullSentence = "학교는 동학년 모임, 교과별 모임, 현장 연구, 자체 연수 등을 통해서 교사들의 교육 활동 개선이 이루어지도록 한다.",
                Reference = "동교현자"

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 1-파. 학교는 학교 교육과정 편성·운영의 A과 B 등을 C하여 D과 E을 추출하고, 다음 학년도의 교육과정 편성·운영에 그 결과를 반영한다.",
                Answer = "적절성, 효과성, 자체 평가, 문제점, 개선점",
                FullSentence = "학교는 학교 교육과정 편성·운영의 적절성과 효과성 등을 자체 평가하여 문제점과 개선점을 추출하고, 다음 학년도의 교육과정 편성·운영에 그 결과를 반영한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 2-가. 학교는 A별 B에 따라 다음과 같은 사항에 중점을 두고 교수·학습이 이루어지도록 한다.",
                Answer = "교과목, 성취기준",
                FullSentence = "학교는 교과목별 성취기준에 따라 다음과 같은 사항에 중점을 두고 교수·학습이 이루어지도록 한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 2-가-1. 교과의 학습은 단편적 지식의 암기를 지양하고 A과 B의 심층적 이해에 중점을 둔다.",
                Answer = "핵심 개념, 일반화된 지식",
                FullSentence = "교과의 학습은 단편적 지식의 암기를 지양하고 핵심 개념과 일반화된 지식의 심층적 이해에 중점을 둔다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 2-가-2. 각 교과의 A과 B 및 C이 학생의 발달 단계에 따라 그 폭과 깊이를 심화할 수 있도록 수업을 체계적으로 설계한다.",
                Answer = "핵심 개념, 일반화된 지식, 기능",
                FullSentence = "각 교과의 핵심 개념과 일반화된 지식 및 기능이 학생의 발달 단계에 따라 그 폭과 깊이를 심화할 수 있도록 수업을 체계적으로 설계한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 2-가-3. 학생의 A를 기를 수 있도록 B, C을 고려하여 지도한다.",
                Answer = "융합적 사고, 교과 내, 교과 간 내용 연계성",
                FullSentence = "학생의 융합적 사고를 기를 수 있도록 교과 내, 교과 간 내용 연계성을 고려하여 지도한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 2-가-4. A, B, C, D, E, F, G 등의 H이 충분히 이루어지도록 한다.",
                Answer = "실험, 관찰, 조사, 실측, 수집, 노작, 견학, 직접 체험 활동",
                FullSentence = "실험, 관찰, 조사, 실측, 수집, 노작, 견학 등의 직접 체험 활동이 충분히 이루어지도록 한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 2-가-5. A과 함께 B을 통하여 협력적으로 문제를 해결하는 C을 충분히 제공한다.",
                Answer = "개별 학습 활동, 소집단 공동 학습 활동, 협동학습 경험",
                FullSentence = "개별 학습 활동과 함께 소집단 공동 학습 활동을 통하여 협력적으로 문제를 해결하는 협동학습 경험을 충분히 제공한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 2-가-6. 학생이 A으로 수업에 참여하고 자신의 생각을 B하는 기회를 가질 수 있도록 C을 활성화한다.",
                Answer = "능동적, 표현, 토의·토론 학습",
                FullSentence = "학생이 능동적으로 수업에 참여하고 자신의 생각을 표현하는 기회를 가질 수 있도록 토의·토론 학습을 활성화한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 2-가-7. 학생에게 학습 내용을 A 속에서 B하고 C할 수 있는 기회를 충분히 제공한다.",
                Answer = "실제적 맥락, 적용, 활용",
                FullSentence = "학생에게 학습 내용을 실제적 맥락 속에서 적용하고 활용할 수 있는 기회를 충분히 제공한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 2-가-8. 학생이 스스로 자신의 A과 B을 C하고 D하며 E으로 학습할 수 있도록 지도한다.",
                Answer = "학습 과정, 학습 전략, 점검, 개선, 자기주도적",
                FullSentence = "학생이 스스로 자신의 학습 과정과 학습 전략을 점검하고 개선하며 자기주도적으로 학습할 수 있도록 지도한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 2-나. 학교는 효과적인 A를 위해 다음과 같은 사항에 중점을 둔다.",
                Answer = "교수·학습 환경 설계",
                FullSentence = "학교는 효과적인 교수·학습 환경 설계를 위해 다음과 같은 사항에 중점을 둔다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 2-나-1. A 간, B 간 상호 C와 D이 가능한 교수·학습 환경을 제공한다.",
                Answer = "교사와 학생, 학생과 학생, 신뢰, 협력",
                FullSentence = "교사와 학생 간, 학생과 학생 간 상호 신뢰와 협력이 가능한 교수·학습 환경을 제공한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 2-나-2. 학생의 A, B, C를 고려하여 교육 내용과 방법을 D하고, 학교의 여건과 학생의 특성에 따라 E을 구성하여 F을 하도록 한다.",
                Answer = "능력, 적성, 진로, 다양화, 다양한 학습 집단, 학생 맞춤형 수업",
                FullSentence = "학생의 능력, 적성, 진로를 고려하여 교육 내용과 방법을 다양화하고, 학교의 여건과 학생의 특성에 따라 다양한 학습 집단을 구성하여 학생 맞춤형 수업을 하도록 한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 2-나-3. 학교는 A을 보충할 수 있도록 B을 운영할 수 있으며, 이에 대한 제반 운영 사항은 학교가 자율적으로 결정한다.",
                Answer = "학습 결손, 특별 보충 수업",
                FullSentence = "학교는 학습 결손을 보충할 수 있도록 특별 보충 수업을 운영할 수 있으며, 이에 대한 제반 운영 사항은 학교가 자율적으로 결정한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 2-나-4. 각 교과에 특성에 맞는 다양한 학습이 이루어질 수 있도록 A 운영을 활성화 한다.",
                Answer = "교과 교실제",
                FullSentence = "각 교과의 특성에 맞는 다양한 학습이 이루어질 수 있도록 교과 교실제 운영을 활성화한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 2-나-5. 학교는 교과용 A 이외에 교육청이나 학교에서 개발한 다양한 교수·학습 자료를 활용할 수 있다.",
                Answer = "도서",
                FullSentence = "학교는 교과용 도서 이외에 교육청이나 학교에서 개발한 다양한 교수·학습 자료를 활용할 수 있다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 2-나-6. A 및 B 과정에서 학생의 C를 D하기 위해 E, F, G의 안전에 만전을 기한다.",
                Answer = "실험 실습, 실기 지도, 안전사고, 예방, 시설 및 기계 기구, 약품, 용구 사용",
                FullSentence = "실험 실습 및 실기 지도 과정에서 학생의 안전사고를 예방하기 위해 시설 및 기계 기구, 약품, 용구 사용의 안전에 만전을 기한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 3-가. 평가는 학생의 A를 확인하고 B을 C하는데 주안점을 둔다.",
                Answer = "교육 목표 도달도, 교수·학습의 질, 개선",
                FullSentence = "평가는 학생의 교육 목표 도달도를 확인하고 교수·학습의 질을 개선하는데 주안점을 둔다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 3-가-1. 학교는 학생에게 A에 대한 B과 C를 통해 학생이 자신의 학습을 D적으로 E하고 F할 수 있도록 지도한다.",
                Answer = "평가 결과, 적절한 정보 제공, 추수 지도, 지속, 활용, 개선",
                FullSentence = "학교는 학생에게 평가 결과에 대한 적절한 정보 제공과 추수 지도를 통해 학생이 자신의 학습을 지속적으로 성찰하고 개선할 수 있도록 지도한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 3-가-2. 학생 A 결과를 활용하여 수업의 B을 C적으로 D한다.",
                Answer = "평가, 질, 지속, 개선",
                FullSentence = "학생 평가 결과를 활용하여 수업의 질을 지속적으로 개선한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 3-나. 학교와 교사는 A에 근거하여 학교에서 중요하게 지도한 B과 C을 D하며 교수·학습과 평가 활동이 E 있게 이루어지도록 한다.",
                Answer = "성취기준, 내용, 기능, 평가, 일관성",
                FullSentence = "학교와 교사는 성취기준에 근거하여 학교에서 중요하게 지도한 내용과 기능을 평가하며 교수·학습과 평가 활동이 일관성 있게 이루어지도록 한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 3-나-2. 학습의 결과뿐만 아니라 학습의 A을 B하여 모든 학생이 교육 목표에 성공적으로 도달할 수 있도록 한다.",
                Answer = "과정, 평가",
                FullSentence = "학습의 결과뿐만 아니라 학습의 과정을 평가하여 모든 학생이 교육 목표에 성공적으로 도달할 수 있도록 한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 3-나-3. 학교는 학생의 A과 B에 대한 평가가 균형 있게 이루어질 수 있도록 한다.",
                Answer = "인지적 능력, 정의적 능력",
                FullSentence = "학교는 학생의 인지적 능력과 정의적 능력에 대한 평가가 균형 있게 이루어질 수 있도록 한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 3-다. 학교는 교과의 A과 B에 적합한 C 방법을 활용한다.",
                Answer = "성격, 특성, 평가",
                FullSentence = "학교는 교과의 성격과 특성에 적합한 평가 방법을 활용한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 3-다-1. 서술형과 논술형 평가 및 A의 비중을 확대한다.",
                Answer = "수행평가",
                FullSentence = "서술형과 논술형 평가 및 수행평가의 비중을 확대한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 3-다-2. A적, B적, C적인 면이 특히 중시되는 교과는 D한 E에 따라 평가를 실시한다.",
                Answer = "정의, 기능, 창의, 타당, 평정 기준과 척도",
                FullSentence = "정의적, 기능적, 창의적인 면이 특히 중시되는 교과는 평정 기준과 척도에 따라 평가를 실시한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 3-다-4. 창의적 체험활동은 A과 B을 고려하여 평가의 주안점을 C에서 결정하여 평가한다.",
                Answer = "내용, 특성, 학교",
                FullSentence = "창의적 체험활동은 내용과 특성을 고려하여 평가의 주안점을 학교에서 결정하여 평가한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 4-다. 특수 교육 대상 학생을 위해 A을 설치·운영하는 경우, 학생의 장애 특성 및 정도를 고려하여 이 교육과정을 조정하여 운영하거나 특수 교육 교육과정 및 교수·학습 자료를 활용할 수 있다.",
                Answer = "특수 학급",
                FullSentence = "특수 교육 대상 학생을 위해 특수 학급을 설치·운영하는 경우, 학생의 장애 특성 및 정도를 고려하여 이 교육과정을 조정하여 운영하거나 특수 교육 교육과정 및 교수·학습 자료를 활용할 수 있다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 편성·운영 : 4-라. 다문화 가정 학생을 위한 A을 설치·운영하는 경우, 다문화 가정 학생의 한국어 능력을 고려하여 이 교육과정을 조정하여 운영하거나, 한국어 교육과정 및 교수·학습 자료를 활용할 수 있다. 한국어 교육과정은 학교의 특성, 학생·교사·학부모의 요구 및 필요에 따라 주당 B시간 내외에서 운영할 수 있다.",
                Answer = "특별 학급, 10",
                FullSentence = ""

            },

            /*new QuestSet
            {
                Quest = "학교 교육과정 지원 : 1. 국가 수준의 지원 - 나. 이 교육과정의 A를 위하여 주기적으로 B, C, D를 실시하고 그 결과를 교육과정 개선에 활용한다.",
                Answer = "질 관리, 학업 성취도 평가, 학교와 교육 기관 평가, 교육과정 편성·운영에 관한 평가",
                FullSentence = "이 교육과정의 질 관리를 위하여 주기적으로 학업 성취도 평가, 학교와 교육 기관 평가, 교육과정 편성·운영에 관한 평가를 실시하고 그 결과를 교육과정 개선에 활용한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 지원 : 1. 국가 수준의 지원 - 다-1. 교과별로 성취기준에 따른 A을 개발·보급하여 학교가 교과 교육과정의 목표에 부합되는 평가를 실시할 수 있도록 한다.",
                Answer = "평가 기준",
                FullSentence = "교과별로 성취기준에 따른 평가 기준을 개발·보급하여 학교가 교과 교육과정의 목표에 부합되는 평가를 실시할 수 있도록 한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 지원 : 1. 국가 수준의 지원 - 바. 이 교육과정이 교육 현장에 정착될 수 있도록 교육청 수준의 A와 전국 단위의 B 활동을 적극적으로 지원한다.",
                Answer = "교원 연수, 교과 연구회",
                FullSentence = "이 교육과정이 교육 현장에 정착될 수 있도록 교육청 수준의 교원 연수와 전국 단위의 교과 연구회 활동을 적극적으로 지원한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 지원 : 2. 교육청 수준의 지원 - 가. 시·도의 특성과 교육적 요구를 구현하기 위하여 A를 조직하여 운영한다.",
                Answer = "시·도 교육청 교육과정 위원회",
                FullSentence = "시·도의 특성과 교육적 요구를 구현하기 위하여 시·도 교육청 교육과정 위원회를 조직하여 운영한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 지원 : 2. 교육청 수준의 지원 - 가-1. 이 위원회(시·도 교육청 교육과정 위원회)는 교육과정 편성·운영에 관한 A와 B을 담당한다.",
                Answer = "조사 연구, 자문 기능",
                FullSentence = "이 위원회는 교육과정 편성·운영에 관한 조사 연구와 자문 기능을 담당한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 지원 : 2. 교육청 수준의 지원 - 나. 지역의 특수성, 교육의 실태, 학생·교원·주민의 요구와 필요 등을 반영하여 교육청 단위의 A을 설정하고, 학교 교육과정 개발을 위한 B을 마련하여 안내한다.",
                Answer = "교육 중점, 시·도 교육청 수준 교육과정 편성·운영 지침",
                FullSentence = "지역의 특수성, 교육의 실태, 학생·교원·주민의 요구와 필요 등을 반영하여 교육청 단위의 교육 중점을 설정하고, 학교 교육과정 개발을 위한 시·도 교육청 수준 교육과정 편성·운영 지침을 마련하여 안내한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 지원 : 2. 교육청 수준의 지원 - 사. 학교가 지역사회의 유관 기관과 적극적으로 연계·협력해서 교과, 창의적 체험활동을 내실 있게 운영할 수 있도록 지원하며, 관내 학교가 활용할 수 있는 'A'을 작성하여 제공하는 등 구체적인 지원 방안을 마련한다.",
                Answer = "지역 자원 목록",
                FullSentence = "학교가 지역사회의 유관 기관과 적극적으로 연계·협력해서 교과, 창의적 체험활동을 내실 있게 운영할 수 있도록 지원하며, 관내 학교가 활용할 수 있는 '지역 자원 목록'을 작성하여 제공하는 등 구체적인 지원 방안을 마련한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 지원 : 2. 교육청 수준의 지원 - 타-2. 학교 교육과정의 효율적인 편성·운영을 지원하기 위해 A 등 지원 기구를 운영하며 교육과정 편성·운영을 위한 각종 자료를 개발하여 보급한다.",
                Answer = "교육과정 컨설팅 지원단",
                FullSentence = "학교 교육과정의 효율적인 편성·운영을 지원하기 위해 교육과정 컨설팅 지원단 등 지원 기구를 운영하며 교육과정 편성·운영을 위한 각종 자료를 개발하여 보급한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 지원 : 2. 교육청 수준의 지원 - 타-3. 학교 교육과정 편성·운영의 개선과 수업 개선을 위해 A를 운영하고 연구 교사제 및 교과별 연구회 활동 등을 적극적으로 지원한다.",
                Answer = "연구학교",
                FullSentence = "학교 교육과정 편성·운영의 개선과 수업 개선을 위해 연구학교를 운영하고 연구 교사제 및 교과별 연구회 활동 등을 적극적으로 지원한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 지원 : 2. 교육청 수준의 지원 - 파-4. 수준별 수업을 효율적으로 운영하도록 지원하며, 기초학력 향상과 학습 결손 보충이 가능하도록 A을 운영하는 데 필요한 행·재정적인 지원을 한다.",
                Answer = "특별 보충 수업",
                FullSentence = "수준별 수업을 효율적으로 운영하도록 지원하며, 기초학력 향상과 학습 결손 보충이 가능하도록 특별 보충 수업을 운영하는 데 필요한 행·재정적인 지원을 한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 지원 : 2. 교육청 수준의 지원 - 파-7. A 및 B 함양을 위해 독서 활동을 활성화하도록 다양한 지원을 한다.",
                Answer = "인문학적 소양, 통합적 읽기 능력",
                FullSentence = "인문학적 소양 및 통합적 읽기 능력 함양을 위해 독서 활동을 활성화하도록 다양한 지원을 한다."

            },

            new QuestSet
            {
                Quest = "학교 교육과정 지원 : 2. 교육청 수준의 지원 - 하-2. 학교의 교육과정 편성·운영에 대한 질 관리와 교육과정 편성·운영 체제의 적절성 및 실효성을 높이기 위하여 A, B 등을 실시하고 그 결과를 교육과정 개선에 활용한다.",
                Answer = "학업 성취도 평가, 학교 교육과정 평가",
                FullSentence = "학교의 교육과정 편성·운영에 대한 질 관리와 교육과정 편성·운영 체제의 적절성 및 실효성을 높이기 위하여 학업 성취도 평가, 학교 교육과정 평가 등을 실시하고 그 결과를 교육과정 개선에 활용한다."

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                FullSentence = ""

            }*/
        };
    }
}
