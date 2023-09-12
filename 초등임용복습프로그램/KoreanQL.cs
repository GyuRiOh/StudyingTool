using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 초등임용복습프로그램
{
    class KoreanQL
    {
        public static List<QuestSet> korean_CU = new List<QuestSet>
        {
            new QuestSet
            {
                Quest = "1. 성격 - A는 대한민국의 공용어로서 사고와 의사소통의 도구이자 문화 창조와 전승의 기반이다. 학습자는 A를 활용하여 자아를 인식하고 타인과 교류하며 세계를 이해한다. 또한 다양한 A 활동을 통해 문화를 이해·향유하며 새로운 문화의 발전에 참여한다.",
                Answer = "국어",
                Reference = ""

            },
            
            new QuestSet
            {
                Quest = "1. 성격 - 학교 안과 밖에서 이루어지는 대부분의 학습은 국어를 통해 이루어지므로 A은 학습의 성패를 결정하는 중요한 요인이 된다. A이 부족하면 효과적인 학습이 어렵고 결과적으로 성공적인 삶을 영위하기도 어렵다. 따라서 학습자는 학교생활을 통해 폭넓은 국어 경험을 쌓으며 일상생활과 학습에 필요한 실질적인 A을 길러야 한다.",
                Answer = "국어 능력",
                Reference = ""

            },
            
            new QuestSet
            {
                Quest = "1. 성격 - 이를 바탕으로 학습자는 더 깊이 있는 사고와 효과적인 소통, 발전적인 문화 창조 능력을 갖추게 된다. 나아가 자신의 말이나 글에 책임지는 태도를 지니고 바람직한 인성과 공동체 의식을 기름으로써 A을 달성할 수 있다.",
                Answer = "국어 교육의 목적",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "1. 성격 - 학습자는 '국어'의 학습을 통해 '국어'가 추구하는 역량인 A, B, C, D, E, F을 기를 수 있다.",
                Answer = "비판적·창의적 사고 역량, 자료·정보 활용 역량, 의사소통 역량, 공동체·대인 관계 역량, 문화 향유 역량, 자기 성찰·계발 역량",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "1. 성격 - A은 다양한 상황이나 자료, 담화, 글을 주체적인 관점에서 해석하고 평가하여 새롭고 독창적인 의미를 부여하거나 만드는 능력이다.",
                Answer = "비판적·창의적 사고 역량",
                Reference = "다르게 생각하기"

            },

            new QuestSet
            {
                Quest = "1. 성격 - A은 필요한 자료나 정보를 수집, 분석, 평가하고 이를 효과적으로 활용하여 의사를 결정하거나 문제를 해결하는 능력이다.",
                Answer = "자료·정보 활용 역량",
                Reference = "자료 찾아보기"

            },

            new QuestSet
            {
                Quest = "1. 성격 - A은 음성 언어, 문자 언어, 기호와 매체 등을 활용하여 생각과 느낌, 경험을 표현하거나 이해하면서 의미를 구성하고 자아와 타인, 세계의 관계를 점검·조정하는 능력이다.",
                Answer = "의사소통 역량",
                Reference = "함께 이야기하기"

            },

            new QuestSet
            {
                Quest = "1. 성격 - A은 공동체의 가치와 공동체 구성원의 다양성을 존중하고 상호 협력하며 관계를 맺고 갈등을 조정하는 능력이다.",
                Answer = "공동체·대인 관계 역량",
                Reference = "마음 나누기"

            },

            new QuestSet
            {
                Quest = "1. 성격 - A은 삶의 가치와 의미를 끊임없이 반성하고 탐색하며 변화하는 사회에서 필요한 재능과 자질을 계발하고 관리하는 능력이다.",
                Answer = "자기 성찰·계발 역량",
                Reference = "자신 알아보기"

            },

            new QuestSet
            {
                Quest = "1. 성격 - A은 국어로 형성·계승되는 다양한 문화를 이해하고 그 아름다움과 가치를 내면화하여 수준 높은 문화를 향유·생산하는 능력이다.",
                Answer = "문화 향유 역량",
                Reference = "누리며 즐기기"

            },

            new QuestSet
            {
                Quest = "1. 성격 - '국어'의 하위 영역은 A, B, C, D, E이다. 학습자는 이들 영역에 관한 F을 갖추고 각 영역의 수행에 필요한 G과 H를 기름으로써 '국어'의 목표를 달성할 수 있다.",
                Answer = "듣기·말하기, 읽기, 쓰기, 문법, 문학, 지식, 기능, 태도",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "1. 성격 - '국어'가 지니는 또 하나의 특성은 국어 교과가 다른 교과의 학습 및 비교과 활동과 A된다는 점이다.",
                Answer = "범교과적으로 연계",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "1. 성격 - 그러므로 '국어'의 교수·학습과 A는 학습자가 다양한 차원의 통합적 활동을 통하여 교과 역량을 기반으로 한 실질적인 B을 기르도록 하는 데 중점을 두어야 한다.",
                Answer = "평가, 국어 능력",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "2. 목표 - 가. 다양한 유형의 A, B, C을 정확하고 비판적으로 D하고 효과적이고 창의적으로 E하며 소통하는 데 필요한 F을 익힌다.",
                Answer = "담화, 글 작품, 이해, 표현, 기능",
                Reference = "'이해'와 관련된 언어 기능 - 듣기·읽기"

            },

            new QuestSet
            {
                Quest = "2. 목표 - 나. 듣기·말하기, 읽기, 쓰기 활동 및 문법 탐구와 문학 향유에 도움이 되는 기본 A을 갖춘다.",
                Answer = "지식",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "2. 목표 - 다. 국어의 가치와 국어 능력의 중요성을 인식하고 주체적으로 국어생활을 하는 A를 기른다.",
                Answer = "태도",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "3-가. 내용 체계 : '국어'의 교수·학습 내용은 A, B, C, D, E 영역으로 구성하였다. 각 영역의 내용은 하위 범주별 'F'과 'G'을 바탕으로 하여 '학년(군)별 H'로 전개하였으며, 이를 통해서 각 영역이 추구하는 통합적 'I'을 신장하도록 하였다.",
                Answer = "듣기·말하기, 읽기, 쓰기, 문법, 문학, 핵심 개념, 일반화된 지식, 내용 요소, 기능",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "3-나. 성취기준의 제시 순서는 대체로 내용 체계의 순서에 따랐는데, 이 순서가 교수·학습의 순서를 의미하지는 않는다. 'A'는 성취기준과 관련된 내용의 범위와 수준을 명료하게 제시하기 위한 것으로, 다양한 교수·학습 상황에 맞게 재구성할 수 있다. 'B'은 설정의 취지나 학습 요소에 대해 오해의 소지가 있거나 상세한 설명이 필요한 경우에 한하여 제시하였으며, 해설의 제시 여부가 학습 내용의 경중을 의미하지는 않는다. 모든 성취기준의 내용과 'C'는 학습자의 요구와 수준에 따라 통합적 관점에서 내용의 위계성과 학습의 계열성을 고려하며 창의적으로 재구성하여 활용할 수 있다.",
                Answer = "학습 요소, 성취기준 해설, 국어 자료의 예",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "초등학교 1~2학년 : 취학 전의 국어 경험을 발전시켜 일상생활과 학습에 필요한 A을 갖추고, 말과 글(또는 책)에 B를 가진다.",
                Answer = "기초 문식성, 흥미",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "[초등1~2] (1) 듣기·말하기 : 초등학교 1~2학년 듣기·말하기 영역 성취기준은 학습자가 학교생활에 적응하면서 다른 사람과의 상호 작용에 필요한 A을 갖추는 데 중점을 두어 설정하였다.",
                Answer = "기초적인 듣기·말하기 능력",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "[초등1~2] (1) 듣기·말하기 : 다른 사람의 말을 경청하고 자신의 감정이나 경험을 자신 있게 말하는 활동을 바탕으로 하여 듣기·말하기의 A과 B를 바르게 형성하는 데 주안점을 둔다.",
                Answer = "습관, 태도",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "[2국01-01] 상황에 어울리는 A을 주고받는다.",
                Answer = "인사말",
                Reference = "",
                FullSentence = "상황에 어울리는 인사말을 주고받는다."

            },

            new QuestSet
            {
                Quest = "[2국01-02] A이 일어난 B를 고려하며 듣고 말한다.",
                Answer = "일, 순서",
                Reference = "",
                FullSentence = "일이 일어난 순서를 고려하며 듣고 말한다."

            },

            new QuestSet
            {
                Quest = "[2국01-03] 자신의 감정을 표현하며 A를 나눈다.",
                Answer = "대화",
                Reference = "감정 : 기쁨, 슬픔, 사랑, 미움 등. 2009개정 교육과정에서는 '기분이나 느낌을 말로 표현한다.' 였다.",
                FullSentence = "자신의 감정을 표현하며 대화를 나눈다."

            },

            new QuestSet
            {
                Quest = "[2국01-04] 듣는 이를 바라보며 A로 B 있게 말한다.",
                Answer = "바른 자세, 자신",
                Reference = "",
                FullSentence = "듣는 이를 바라보며 바른 자세로 자신 있게 말한다."

            },

            new QuestSet
            {
                Quest = "[2국01-05] 말하는 이와 말의 내용에 A하며 B는다.",
                Answer = "집중, 듣",
                Reference = "",
                FullSentence = "말하는 이와 말의 내용에 집중하며 듣는다."

            },

            new QuestSet
            {
                Quest = "[2국01-06] A을 사용하여 말하는 태도를 지닌다.",
                Answer = "바르고 고운 말",
                Reference = "",
                FullSentence = "바르고 고운 말을 사용하여 말하는 태도를 지닌다."

            },

            new QuestSet
            {
                Quest = "(1) 듣기·말하기 학습 요소 : A 주고받기, B 이해하기, C하기(감정 표현), D 있게 말하기, 바른 자세로 말하기, E하며 듣기, F 사용하기",
                Answer = "인사말, 일의 순서, 대화, 자신, 주의 집중, 바르고 고운 말",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "(1) 듣기·말하기 성취기준 해설 : [2국01-01] 이 성취기준은 생활 속에서 상황에 맞는 인사말을 주고받음으로써 타인과 원만한 관계를 형성하는 능력을 기르기 위해 설정하였다. 학교생활에 적응할 때에도 자연스러운 인사말이 필요하고, 집을 나서거나 집으로 돌아올 때, 사람을 만나거나 헤어질 때, 처음 만나는 사람끼리 자기소개를 할 때, 상대방에게 고마운 마음을 드러낼 때 등 A에 따라 주고받는 인사말이 다르다. 학습자가 처할 수 있는 여러 상황별로 어울리는 인사말을 이해하고 연습하는 데 중점을 둔다.",
                Answer = "상황",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "(1) 듣기·말하기 성취기준 해설 : [2국01-03] 이 성취기준은 대화를 나눌 때 자신의 감정을 적절하게 표현함으로써 타인과의 관계를 유지하고 발전시키는 능력을 기르기 위해 설정하였다. 자신의 감정을 이해하고 상황에 적절하게 감정을 표현하는 것은 자기를 이해하고 A을 형성하는 데 도움이 된다는 점을 알도록 하고, 기쁨, 슬픔, 사랑, 미움 등 다양한 종류의 B을 자연스럽게 표현하도록 하는 데 중점을 둔다.",
                Answer = "대인 관계, 감정",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "(1) 듣기·말하기 성취기준 해설 : [2국01-05] 이 성취기준은 바른 듣기 방법과 태도를 배우고 연습함으로써 말하는 이를 존중하고 말의 내용을 정확하게 이해하는 능력을 기르기 위해 설정하였다. 말하는 이와 말의 내용에 주의를 집중하며 듣는 것은 내용을 이해하기 위해서 필요할 뿐 아니라, 상대를 배려하며 듣는 태도의 문제이며 A과도 관계가 있다. B, C 등의 반응을 보임으로써 상대방의 말에 집중하며 듣고 있음을 상대가 알도록 하는 데 중점을 둔다.",
                Answer = "언어 예절, 눈 맞춤, 고개 끄덕임",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "(1) 듣기·말하기 교학방유 : 듣기 활동을 지도할 때에는 학습자의 흥미와 관심을 고려하여 이야기 구조가 있는 A를 선정하고 교사가 직접 이야기해 주거나 B를 활용하는 등 다양한 방법을 활용할 수 있다.",
                Answer = "담화, 시청각 매체",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "(1) 듣기·말하기 교학방유 : 감정을 표현하는 말하기를 지도할 때에는 자신의 감정을 직접 A하거나 B 등을 활용하여 다양하게 A해보게 한다.",
                Answer = "표현, 역할극",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "(1) 듣기·말하기 교학방유 : 집중하며 듣기를 지도할 때에는 A에 따라 말하는 이의 기분이 어떻게 다른지 말해 보는 활동을 활용한다.",
                Answer = "듣는 이의 반응",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "(1) 듣기·말하기 평방유 : 인사말, 감정 표현하기, 바른 자세로 말하기, 바른 말을 사용하는 태도 지니기 등의 학습 요소는 학습자가 A뿐 아니라 B에서의 말하기에서도 잘 실천하고 있는지 점검하여, 학교 안팎에서 듣기·말하기 능력이 균형 있게 발달할 수 있도록 한다.",
                Answer = "학교, 가정",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "[2국02-01] A, B, C을 소리 내어 읽는다.",
                Answer = "글자, 낱말, 문장",
                FullSentence = "글자, 낱말, 문장을 소리 내어 읽는다.",
                Reference = "관련 부록 주제 <초기 문자 지도> 발음 중심, 의미 중심, 절충식 접근 방법"

            },

            new QuestSet
            {
                Quest = "[2국02-02] A과 글을 알맞게 B 읽는다.",
                Answer = "문장, 띄어",
                Reference = "문장과 글을 알맞게 띄어 읽는다."

            },

            new QuestSet
            {
                Quest = "[2국02-03] 글을 읽고 주요 A을 B한다.",
                Answer = "내용, 확인",
                Reference = "1~2학년 군의 「주요 내용 확인」: '무엇이 어떠하다', '누가 무엇을 하였다.' 3~4학년군의 「내용 간추리기」: '글의 유형을 고려하여 대강의 내용을 간추린다.'",
                FullSentence = "글을 읽고 주요 내용을 확인한다."


            },

            new QuestSet
            {
                Quest = "[2국02-04] 글을 읽고 A의 B와 C을 짐작한다.",
                Answer = "인물, 처지, 마음",
                Reference = "'공감 능력' 읽기 기능 : 성찰·공감하기, 듣기·말하기 기능 : 경청·공감하기",
                FullSentence = "글을 읽고 인물의 처지와 마음을 짐작한다."

            },

            new QuestSet
            {
                Quest = "[2국02-05] 읽기에 A를 가지고 즐겨 읽는 B를 지닌다.",
                Answer = "흥미, 태도",
                Reference = "",
                FullSentence = "읽기에 흥미를 가지고 즐겨 읽는 태도를 지닌다."

            },

            new QuestSet
            {
                Quest = "(2) 읽기 학습 요소 : 정확하게 A 내어 읽기, 알맞게 B 읽기, 주요 C 확인하기, 인물의 D와 E 짐작하기, 읽기에 F 갖기",
                Answer = "소리, 띄어, 내용, 처지, 마음, 흥미",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "(2) 읽기 성취기준 해설 : [2국02-02] 이 성취기준은 알맞게 띄어 읽기를 통해 글의 내용을 파악하는 능력을 기르기 위해 설정하였다. A를 할 때에는 B, C 다음, D와 E 등을 단위로 하여 띄어 읽을 수 있는데, 이들 용어를 노출시키지 않도록 주의한다. 쉬는 지점과 쉼의 길이에 유의하여 알맞게 띄어 읽도록 하는 데 중점을 둔다.",
                Answer = "띄어 읽기, 어절, 문장 부호, 주어부, 서술어부",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "(2) 읽기 성취기준 해설 : [2국02-04] 이 성취기준은 글에 등장하는 인물의 심리를 상상하고 이에 A하는 능력을 기르기 위해 설정하였다. 등장인물이 어떤 처지와 상황에 있는지, 혹은 어떤 마음인지를 짐작해보는 활동에 주안점을 둔다. 이를 위해서는 글의 내용을 확인하고, 등장인물의 마음을 B과 비교하는 활동을 해보는 것이 좋다. 이러한 과정을 통해 타인에 대한 공감 능력을 기름으로써 실제 주변 인물에 대한 이해를 높일 수 있다.",
                Answer = "공감, 자신의 경험",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "(2) 읽기 교학방유 : 학교 안내판, 학급 게시판, 광고지 등 주변에서 접할 수 있는 읽기 자료를 보고 학습자 스스로 읽기를 시도해 보도록 한다. 예컨대, A, B, C을 소리내어 읽기를 지도할 때에는 낱자의 형태, 소리, 이름 등을 읽기 보다는 '자동차'의 '자'와 같이 학습자가 익숙한 B 속에서 글자의 형태와 소리를 익히도록 한다.",
                Answer = "글자, 낱말, 문장",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "(2) 읽기 교학방유 : 띄어 읽기를 지도할 때에는 다 같이 읽기보다는 A를 하여 기계적으로 띄어 읽기를 하지 않도록 한다. 여러 단위에서 띄어 읽기가 가능하므로 특정한 띄어 읽기 방법을 강요하지 않으며 의미가 통할 수 있는 수준에서 띄어 읽도록 지도한다.",
                Answer = "혼자 읽기",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "(2) 읽기 교학방유 : 글을 읽고 A를 지도할 때에는 '무엇이 어떠하다', '누가 무엇을 하였다.'와 같은 수준에서 내용을 파악하도록 지도한다.",
                Answer = "내용 확인하기",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "(2) 읽기 교학방유 : 글을 읽고 인물의 처지와 마음 짐작하기를 지도할 때에는 그렇게 짐작한 A을 말해보게 함으로써 인물의 처지나 마음을 바르게 짐작하였는지를 살펴본다. 또한 인물의 처지나 마음을 표현할 때에는 '기분이 좋다, 기분이 나쁘다'와 같은 표현을 이용하기보다는 '신나다, 즐겁다, 설레다, 창피하다, 기죽다, 답답하다'와 같이 B을 사용하여 표현할 수 있도록 지도한다.",
                Answer = "까닭, 감정을 표현하는 다양한 어휘",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "(2) 읽기 평방유 : 글자, 낱말, 문장 소리 내어 읽기와 알맞게 띄어 읽기는 교실 수업 상황에서 돌아가며 읽기 등의 A에서 평가할 수 있다. 또한 친구들끼리 서로 평가하도록 할 수도 있는데, 이 과정에서 자신의 읽기를 자연스럽게 B해 볼 수 있게 한다.",
                Answer = "수행 과정, 점검",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "(2) 읽기 평방유 : 글자, 낱말, 문장 소리 내어 읽기를 평가할 때에는 음운 변동이 없는 낱말이나 문장을 주로 평가하되, 음운 변동을 다루더라도 A이나 B(C) 위주로 다룬다.",
                Answer = "연음 현상, 경음화, 된소리되기",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "(2) 읽기 평방유 : 인물의 처지나 마음을 짐작하는 글 읽기에서는 글을 읽고 내용을 확인하기, A, 글쓴이의 마음이나 처지를 파악하기를 순차적으로 평가하여 학습자의 읽기 능력을 정확하게 점검하도록 한다.",
                Answer = "자신과 비슷한 경험을 떠올리기",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "[2국03-01] A를 바르게 쓴다.",
                Answer = "글자",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "[2국03-02] 자신의 생각을 A으로 표현한다.",
                Answer = "문장",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "[2국03-03] A의 사람이나 사물에 대해 짧은 글을 쓴다.",
                Answer = "주변",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "[2국03-04] 인상 깊었던 일이나 A에 대한 B이나 C을 쓴다.",
                Answer = "겪은 일, 생각, 느낌",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "[2국03-05] 쓰기에 A을 가지고 즐겨 쓰는 B를 지닌다.",
                Answer = "흥미, 태도",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "(3) 쓰기 학습 요소 : A 정확하게 쓰기, 글씨 바르게 쓰기, 완성된 B 쓰기, 짧은 글 쓰기, 경험에 대한 생각이나 느낌 쓰기, 쓰기에 C 갖기",
                Answer = "글자, 문장, 흥미",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "(3) 쓰기 성취기준 해설 : [2국03-01] 이 성취기준은 바른 자세로 글자를 정확하게 쓰는 습관을 기르기 위해 설정하였다. A에는 바르게 앉아 쓰기, 연필 바르게 잡기, 낱자의 모양이나 간격 등을 고려하여 글씨 바르게 쓰기가 포함된다. 글자를 정확하게 쓰기 위해서는 짜임과 필순에 맞게 B를 쓰게 한다. 글자의 복잡성 정도를 고려하여 처음에는 받침이 없는 간단한 글자부터 시작하여 점차 받침이 있는 복잡한 글자를 쓸 수 있게 한다.",
                Answer = "바른 자세로 글씨 쓰기, 낱자",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "(3) 쓰기 성취기준 해설 : [2국03-02] 이 성취기준은 문장 구성 능력을 기르기 위해 설정하였다. 문장은 글을 구성하는 기본이다. 글을 잘 쓰려면 먼저 자신의 생각을 정확하게 문장으로 표현할 수 있어야 한다. 한두 문장으로 짤막하게 자신의 생각이나 느낌을 표현하되, 마침표, 물음표, 느낌표 등의 A를 사용하여 자신의 생각을 문장으로 정확하게 구성하는 기본 능력을 기르도록 지도한다. 또한 B을 넣어 자신의 생각과 느낌을 구체적으로 표현하도록 지도한다.",
                Answer = "문장 부호, 꾸며주는 말",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "(3) 쓰기 교학방유 : 글자 바르게 쓰기를 지도할 때에는 학습자의 A와 B을 고려하여 기본적인 C과 D을 제시하여 글씨 쓰기를 연습하도록 한다. 학습자의 B을 넘는 C이나 D을 제시하면 쓰기를 어려워할 수 있으므로 적절한 수준의 C이나 D을 제시하여 쓰기에 흥미를 갖도록 지도한다. 특히 읽기 능력에 비해 쓰기 능력의 발달이 늦다는 점을 고려한다.",
                Answer = "발달 단계, 수준, 낱말, 문장",
                Reference = "부록 <초기 문자 지도> 中 의미 중심(낱말식, 문장식)"

            },

            new QuestSet
            {
                Quest = "(3) 쓰기 교학방유 : 받아쓰기는 글자를 정확하게 쓰는 데 도움이 될 수 있으나, 학습자가 부담을 갖게 되면 국어 활동에 자신감을 잃을 수도 있으므로 신중하게 활용한다. 너무 어려운 글자를 받아쓰게 하여 국어에 대한 흥미가 떨어지지 않도록 유의하며 요소 중심으로 (예 : A 현상이 나타나는 낱말) 지도한다.",
                Answer = "된소리되기",
                Reference = "음운 변동이 일어나는 경우 때문에 학습을 어려워한다."

            },

            new QuestSet
            {
                Quest = "(3) 쓰기 교학방유 : 기초 한글 학습이 부족한 학습자를 위해서는 문자 학습에 흥미를 느낄 수 있도록 A 중심, B 중심으로 교수·학습을 진행한다.",
                Answer = "놀이, 활동",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "(3) 쓰기 교학방유 : 인상 깊었던 일이나 겪은 일을 쓸 때에는 한 편의 글이 갖추어야 하는 A적인 측면을 지나치게 강조하지 말고 자신의 생각을 자유롭게 B하는 데 중점을 둔다.",
                Answer = "형식, 표현",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "(3) 쓰기 교학방유 : 쓰기를 처음 시작하는 단계이므로 쓰기에 흥미와 자신감을 가지도록 격려하고, 최대한 A 중심, B 중심의 수업이 되도록 지도한다.",
                Answer = "활동, 놀이",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "(3) 쓰기 평방유 : 평가를 위한 별도의 시간을 마련하거나 활동을 계획하기보다는 수업 및 학교생활에서 학습자의 수행과 태도의 변화 과정을 A하여 B한다. 평소 자신이 쓴 C을 정리해 두도록 하여 이를 평가하는 방법을 적극적으로 활용한다.",
                Answer = "누적 기록, 평가, 쓰기 결과물",
                Reference = "관찰 평가, 포트폴리오 평가"

            },

            new QuestSet
            {
                Quest = "(4) 문법 : 초등학교 1~2학년 문법 영역 성취기준은 학습자가 A을 습득하여 학교에서의 국어 생활에 원활히 적응하도록 하는 데 중점을 두어 설정하였다. 한글을 해득하고, B과 C, D을 바르게 사용하며 말과 글에 대한 관심을 갖게 하는 데 주안점을 둔다.",
                Answer = "기초 문식성, 낱말, 문장, 문장 부호",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "[2국04-01] 한글 자모의 A과 B을 알고 정확하게 발음하고 쓴다.",
                Answer = "이름, 소릿값",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "[2국04-02] A와 B가 다를 수 있음을 알고 낱말을 바르게 읽고 쓴다.",
                Answer = "소리, 표기",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "[2국04-03] A에 따라 알맞은 B를 사용한다.",
                Answer = "문장, 문장 부호",
                Reference = ""

            },

            new QuestSet
            {
                Quest = "[2국04-04] A, B, C을 관심 있게 살펴보고 흥미를 가진다.",
                Answer = "글자, 낱말, 문장",
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
