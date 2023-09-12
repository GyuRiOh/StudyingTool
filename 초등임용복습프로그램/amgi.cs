using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 초등임용복습프로그램
{
    class amgi
    {
        public static List<QuestSet> amgiList = new List<QuestSet>
        {
            new QuestSet
            {
                Quest = "목적에 따른 담화의 유형 : A은 여러 가지 정보, 지식 등을 청자나 청중에게 알려주는 것을 목적으로 하며, 대표적인 예로는 발표가 있다. B은 특정 의도를 가지고 화자가 청자의 태도 변화를 유발하는 것을 목적으로 하며 대표적인 예로는 토의, 토론 등이 있다. 마지막 C의 경우 타인과 상호작용하여 친밀한 관계를 맺고 그 관계를 유지하고 발전시키려는 것으로 대화, 인사말이 여기에 해당한다.",
                Answer = "정보 전달, 설득, 친교 및 정서 표현",
                Reference = ""
            },
            
            new QuestSet
            {
                Quest = "듣기 말하기와 A : 생각이나 정서, 정보와 지식 등을 다수의 사람들과 더불어 공유하고 즐기고 전파하는 매개 역할을 하는 것을 A라고 한다.",
                Answer = "매체",
                Reference = ""
            },
            
            new QuestSet
            {
                Quest = "A 맥락 : 담화가 이루어지는 상황과 직접적으로 관련된 맥락으로, A 맥락을 이루는 요소에는 담화가 이루어지는 시간과 장소, 담화의 의도와 목적 등이 있다.",
                Answer = "상황",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "A 맥락 : 특정한 공동체에서 오랜 시간 언어를 사용하면서 만들어진 규범과 관습",
                Answer = "",
                Reference = ""
            },
            
            new QuestSet
            {
                Quest = "A : 말하기를 앞두고 화자는 말하기 상황의 맥락적 요소들을 구체적으로 이해하고 분석해야 한다. 이를 위해 어떤 장소에서 말하기가 이루어지는지, 담화의 의도와 목적은 무엇인지 사전에 파악하고 효과적인 말하기가 이루어지도록 준비해야 한다.",
                Answer = "맥락 이해·활용하기",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "A : 청자 분석은 화자가 말을 건네는 상대방을 인식하는 것이다. 효과적인 의사소통을 위해서는 청자를 자세히 분석하고 그것에 맞게 내용을 구성하여 전달해야 한다. 청자를 분석할 때는 청자의 나이와 성별은 물론 지적인 수준, 관심사, 태도 등을 분석해야 한다.",
                Answer = "청자 분석하기",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "A : 말할 내용을 생성하기 위해 자료를 수집하고 내용을 선정하는 단계이다.",
                Answer = "내용 생성하기",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "A : 말할 내용을 조직하는 단계이다. 자료를 수집하고 화제를 선정한 뒤에는 말할 내용을 조리 있게 조직하여야 한다.",
                Answer = "내용 조직하기",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "A : 의사소통을 효과적으로 달성하기 위해 매체를 활용하는 경우를 두 가지로 정리할 수 있다. 그 하나는 매체를 전달 경로로 활용하는 경우이다. 매체 활용 방식의 또 다른 하나는 면대면 말하기의 보조 자료로 활용하는 경우이다.",
                Answer = "자료·매체 활용하기",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "A : '계획, 생성, 조직된 정보' 언어적 표현, 비언어적 표현, 반언어적 표현 전략을 사용하여 전달하는 것을 의미한다.",
                Answer = "표현·전달하기",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "A : 사실적인 듣기에 해당한다. 먼저 듣는 내용이 무엇인지 확인해야 추론, 비판, 감상 활동이 이루어질 수 있기 때문이다.",
                Answer = "내용 확인하기",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "A : 의사소통 상황에서 상대의 말을 듣거나 다른 참여자들이 주고받는 말을 들으면서 화자의 발언에 생략되었거나 표현되지 않은 내용을 추리하여 의미를 구성하는 것을 뜻한다.",
                Answer = "추론하기",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "A : 상대방의 말을 듣고 이해한 내용을 신뢰성, 타당성, 공정성 측면에서 판단하는 비판적인 듣기를 말한다. / 감상은 주로 정서 표현의 듣기와 관련되어 있다.",
                Answer = "평가·감상하기",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "A : 섣불리 자신의 견해를 개입시키지 않고 상대의 처지에 공감하는 태도가 필요하다.",
                Answer = "경청·공감하기",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "A : 화자는 청자에게 일방적으로 말하지 않는다. 화자는 청자의 반응을 고려하여 의미를 재구성하게 된다. 따라서 말하기는 화자와 청자의 부단한 의미 교섭과 의미의 재구성 과정이라고 할 수 있다.",
                Answer = "상호 교섭하기",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "A : 효과적인 듣기와 말하기를 위해서는 자신이 듣고 말하는 행위를 객관적으로 점검하여 지속적으로 조정해야 한다. 이 과정에서 상위 인지 전략을 활용한다.",
                Answer = "점검·조정하기",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "A : 글에 대해 사실적으로 확인하는 차원에서 이루어지는 읽기 방법이다.",
                Answer = "사실적 이해",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "A : 글에 드러난 내용 이외의 것들을 추측하면서 읽는 것이다.",
                Answer = "추론적 이해",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "A : 독자가 글의 내용, 형식, 표현, 글쓴이의 생각 등에 대하여 논리적이고 합리적인 사고를 바탕으로 판단과 평가를 내리며 읽는 것이다.",
                Answer = "비판적 이해",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "A : 글에 제시된 글쓴이의 생각과 독자 자신의 생각을 종합하여 새로운 의미를 만들어내는 것이다. 예를 들어 지구의 기후 변화에 관한 설명문을 읽고 독자가 읽은 내용을 바탕으로 기후 변화 문제 해결의 방법을 떠올리고 발견할 수 있다면 이는 A에 해당한다.",
                Answer = "창의적 이해",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "읽기 과정의 A : A하기는 초인지 개념에서 나온 것으로 자신의 인지 활동에 대한 통제와 조건을 의미한다.",
                Answer = "점검",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "A : 문학 작품 읽기에서 사용되는 기능으로 글에서 아름다움을 느끼고 글에 나타난 생각과 가치에 공감하며 성찰을 통해 정서적인 변화를 경험하고, 인격적으로 성숙해지는 경험과 관련되어 있다. 감상적 읽기와 연계되는 개념이다.",
                Answer = "성찰·공감하기",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "(쓰기) 상황 맥락 : 글을 쓰는 과정에 직접적으로 개입하는 요소로 글의 A, 글의 B, 글의 C의 요구 등을 일컫는다.",
                Answer = "목적, 주제, 예상 독자",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "쓰기의 과정 : 글쓴이가 글을 쓰고자 할 때에는 쓰기의 맥락과 관습을 고려하여 계획을 세운다. 그리고 이를 바탕으로 하여 내용을 생성하고 조직하며 표현을 한다. 글쓴이가 초고를 완성하면 쓰기의 목적을 고려하여 내용이 적절한지를 살펴 가며 고쳐 써야 한다. 과정 중심 쓰기는 필요에 따라 돌아갈 수 있는 A적인 특성을 가지고 있다.",
                Answer = "회귀",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "쓰기 과정 별 전략 : 계획하기 - A - B - C - D",
                Answer = "내용 생성하기, 내용 조직하기, 표현하기, 고쳐쓰기",
                Reference = "(계)속 (생)각 나, (조)은 (표)(고) 버섯"
            },

            new QuestSet
            {
                Quest = "A : 쓰기는 글쓴이의 일방적 행위가 아니라 독자와 의사소통을 이루는 상호 작용의 행위이다. 독자의 경우 실제 독자가 있고 가상 독자가 있다. 실제 독자는 구체적 모습을 그릴 수 있는 독자로 이미 알고 있는 사람이 대부분이다. 이에 비하여 가상 독자는 글을 쓰는 사람이 머릿속으로 그리고 있는 추상적인 독자이다. 독자를 고려할 때는 독자의 요구, 관심사, 지식 수준 등을 파악하여야 한다.",
                Answer = "독자 분석하기",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "A : 내용 생성하기는 글을 쓰는 데 필요한 내용은 글감을 마련하는 활동이며, 글을 쓰기 전에 쓰고자하는 내용을 구체적으로 탐색하는 활동이다.",
                Answer = "아이디어 생산하기",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "A : 내용을 생성한 후에는 생성한 내용들의 위계, 구조, 비중, 순서 등을 고려하여 내용을 조직하고 전개해야 한다. 생성한 내용이 같더라도 그것을 어떤 위치에 배치하느냐에 따라 글 전체의 흐름이 달라진다.",
                Answer = "글 구성하기",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "A : 매체는 사람들이 직접 만나지 않고 간접적으로 생각과 느낌, 지식과 정보를 전달하고 공유할 때 사용하는 매개적인 기술 수단을 말한다. 매체는 책, 신문, 잡지, 라디오, 영화, 사진, TV, 인터넷 등을 포함한다.",
                Answer = "자료·매체 활용하기",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "A : 생성하고 조직한 내용을 문자 언어로 표현하는 과정으로 본격적인 의미의 쓰기 활동이라 할 수 있다.",
                Answer = "표현하기",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "A : 애초 설정했던 주제와 실제 작성된 글 사이의 차이를 발견하여 그것을 보완함으로써, 주제를 일관되고 명확하게 드러내는 과정이다. A를 할 때에는 먼저 글 전체를 살피고 점차적으로 부분을 살펴야 한다. 즉 '글 전체 수준 -> 문단 수준 -> 문장 수준 -> 구나 절 수준-> 단어 수준'에서의 순서를 밟으며 고쳐쓰기를 한다.",
                Answer = "고쳐쓰기",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "A : 쓰기는 글쓴이의 생각과 느낌을 일방적으로 전달하는 것이 아니라 독자와 소통하는 행위이다.",
                Answer = "독자와 교류하기",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "A : 글쓴이는 쓰기 과정 내내 자신의 쓰기 전략에 대한 적절성을 평가해야 한다.",
                Answer = "점검·조정하기",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "도덕과 가치 덕목 : 도덕 시간에는 무엇을 배울까? (A, B)",
                Answer = "근면, 정직",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "도덕과 가치 덕목 : 왜 아껴써야 할까? (A)",
                Answer = "시간 관리와 절약",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "도덕과 가치 덕목 : 왜 최선을 다해야 할까? (A)",
                Answer = "인내",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "도덕과 가치 덕목 : 어떻게 하면 감정을 잘 표현할 수 있을까? (A)",
                Answer = "감정표현과 충동 조절",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "도덕과 가치 덕목 : 자주적인 삶이란 무엇일까? (A, B)",
                Answer = "자주, 자율",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "도덕과 가치 덕목 : 정직한 삶은 어떤 삶일까? (A)",
                Answer = "정직한 삶",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "도덕과 가치 덕목 : 가족의 행복을 위해 무엇을 해야 할까? (A, B)",
                Answer = "효, 우애",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "도덕과 가치 덕목 : 친구와 사이좋게 지내기 위해 어떻게 해야 할까? (A)",
                Answer = "우정",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "도덕과 가치 덕목 : 예절이 없다면 어떻게 될까? (A)",
                Answer = "예절",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "도덕과 가치 덕목 : 함께하면 무엇이 좋을까? (A)",
                Answer = "협동",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "도덕과 가치 덕목 : 사이버 공간에서 지켜야 할 것은 무엇일까? (A, B)",
                Answer = "사이버 예절, 준법",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "도덕과 가치 덕목 : 서로 생각이 다를 때 어떻게 해야 할까? (A, B)",
                Answer = "공감, 존중",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "도덕과 가치 덕목 : 우리는 남을 왜 도와야 할까? (A)",
                Answer = "봉사",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "도덕과 가치 덕목 : 나는 공공장소에서 어떻게 해야 할까? (A, B)",
                Answer = "공익, 준법",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "도덕과 가치 덕목 : 나와 다르다고 차별해도 될까? (A, B)",
                Answer = "공정성, 존중",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "도덕과 가치 덕목 : 통일은 왜 필요할까? (A, B)",
                Answer = "통일의지, 애국심",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "도덕과 가치 덕목 : 우리는 서로의 권리를 왜 존중해야 할까? (A)",
                Answer = "인권 존중",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "도덕과 가치 덕목 : 공정한 사회를 위해 무엇을 해야 할까? (A)",
                Answer = "공정성",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "도덕과 가치 덕목 : 통일로 가는 바람직한 길은 무엇일까? (A)",
                Answer = "통일의지",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "도덕과 가치 덕목 : 전 세계 사람들과 어떻게 살아갈까? (A, B)",
                Answer = "존중, 인류애",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "도덕과 가치 덕목 : 생명은 왜 소중할까? (A, B)",
                Answer = "생명 존중, 자연애",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "도덕과 가치 덕목 : 아름답게 살아가는 사람들의 모습은 어떠할까? (A)",
                Answer = "아름다움에 대한 사랑",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "도덕과 가치 덕목 : 어려움을 겪을 때 긍정적 태도가 왜 필요할까? (A, B)",
                Answer = "자아 존중, 긍정적 태도",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "도덕과 가치 덕목 : 나는 올바르게 살아가고 있을까?",
                Answer = "윤리적 성찰",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "통합교과 핵심 개념, 바생 내용 요소 맞추기 : 학교는 여러 친구와 함께 생활하는 곳이다.",
                Answer = "학교와 친구, 학교 생활과 규칙",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "통합교과 핵심 개념, 바생 내용 요소 맞추기 : 나는 몸과 마음으로 이루어져 있다.",
                Answer = "나, 몸과 마음의 건강",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "통합교과 핵심 개념, 바생 내용 요소 맞추기 : 사람들은 봄의 자연 환경에 어울리는 생활을 한다.",
                Answer = "봄맞이, 건강 수칙과 위생",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "통합교과 핵심 개념, 바생 내용 요소 맞추기 : 봄에 볼 수 있는 동식물은 다양하며, 봄에 할 수 있는 활동과 놀이가 있다.",
                Answer = "봄 동산, 생명 존중",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "통합교과 핵심 개념, 바생 내용 요소 맞추기 : 사람들은 가족과 친척의 관계 속에서 살아간다.",
                Answer = "가족과 친척, 가정 예절",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "통합교과 핵심 개념, 바생 내용 요소 맞추기 : 가족의 형태는 다양하며, 구성원마다 역할이 있다.",
                Answer = "다양한 가족, 배려와 존중",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "통합교과 핵심 개념, 바생 내용 요소 맞추기 : 사람들은 여름의 자연 환경에 어울리는 생활을 한다.",
                Answer = "여름맞이, 절약",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "통합교과 핵심 개념, 바생 내용 요소 맞추기 : 여름에 볼 수 있는 동식물은 다양하며 여름에 할 수 있는 활동과 놀이가 있다.",
                Answer = "여름 생활, 여름 생활 및 학습 계획",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "통합교과 핵심 개념, 바생 내용 요소 맞추기 : 이웃은 서로의 생활에 영향을 미친다.",
                Answer = "우리 이웃, 공중도덕",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "통합교과 핵심 개념, 바생 내용 요소 맞추기 : 내가 생활하는 동네에는 서로 다른 일을 하는 사람들이 있다.",
                Answer = "우리 동네, 일의 소중함",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "통합교과 핵심 개념, 바생 내용 요소 맞추기 : 사람들은 가을의 자연 환경에 어울리는 생활을 한다.",
                Answer = "가을맞이, 질서",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "통합교과 핵심 개념, 바생 내용 요소 맞추기 : 명절은 사람들의 생활과 관계가 있다.",
                Answer = "가을 모습, 감사",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "통합교과 핵심 개념, 바생 내용 요소 맞추기 : 우리나라에는 아름다운 전통이 있고 우리나라만의 특별한 상황이 있다.",
                Answer = "우리나라, 나라 사랑",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "통합교과 핵심 개념, 바생 내용 요소 맞추기 : 각 나라는 독특한 문화를 가지고 있다.",
                Answer = "다른 나라, 타문화 공감",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "통합교과 핵심 개념, 바생 내용 요소 맞추기 : 사람들은 겨울의 자연 환경에 어울리는 생활을 한다.",
                Answer = "겨울맞이, 나눔과 봉사",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "통합교과 핵심 개념, 바생 내용 요소 맞추기 : 사람과 동식물은 겨울 환경에 적응하며 생활한다.",
                Answer = "겨울나기, 동식물 보호, 겨울 생활 및 학습 계획",
                Reference = ""
            },
            
            new QuestSet
            {
                Quest = "체력 운동의 원리 : 이전의 운동 자극보다 더 강한 운동 자극을 받아야 운동 효과를 얻을 수 있다.",
                Answer = "과부하의 원리",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "체력 운동의 원리 : 운동 수행 중 부하를 점차적으로 늘려야 한다. 급격한 운동 부하는 운동 효과가 감소한다.",
                Answer = "점진성의 원리",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "체력 운동의 원리 : 지속적이고 반복적인 운동을 통해 기술을 습득하고, 운동에 적응하여 효과를 얻을 수 있다.",
                Answer = "반복성과 계속성의 원리",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "체력 운동의 원리 : 신체 여러 부위에 걸쳐 다양한 방법으로 운동해야 전신이 고르게 발달할 수 있다.",
                Answer = "전면성의 원리",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "무스카 모스톤 수업 스펙트럼 : 교사의 지시만으로 이루어짐",
                Answer = "명령식 스타일",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "무스카 모스톤 수업 스펙트럼 : 교사가 피드백",
                Answer = "연습식 스타일",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "무스카 모스톤 수업 스펙트럼 : 동료 학생이 피드백",
                Answer = "교류식 스타일",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "무스카 모스톤 수업 스펙트럼 : 자기 스스로 피드백",
                Answer = "자검식 스타일",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "무스카 모스톤 수업 스펙트럼 : 다른 수준의 난이도를 가진 과제 제공",
                Answer = "포함식 스타일",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "무스카 모스톤 수업 스펙트럼 : 답이 1개, 연차적 질문",
                Answer = "유도발견식 스타일",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "무스카 모스톤 수업 스펙트럼 : 답이 1개, 학생 스스로 찾기",
                Answer = "수렴발견식 스타일",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "무스카 모스톤 수업 스펙트럼 : 여러가지 해결책, 반응",
                Answer = "확산생산식 스타일",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "무스카 모스톤 수업 스펙트럼 : 교사는 포괄적인 영역을 선정해줌. 학생은 스스로 자신에게 적합한 과제를 설계하고 실행.",
                Answer = "자기설계식 스타일",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "무스카 모스톤 수업 스펙트럼 : 학생 스스로 학습 과정을 설계, 실행, 평가한다",
                Answer = "학생주도식 스타일",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "무스카 모스톤 수업 스펙트럼 : 교사의 관여가 없이 학생이 결정",
                Answer = "자기학습식 스타일",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "",
                Answer = "",
                Reference = ""
            }
        };
    }
}
