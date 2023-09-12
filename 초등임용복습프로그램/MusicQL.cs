using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 초등임용복습프로그램
{
    class MusicQL
    {
        public static List<QuestSet> music_CU = new List<QuestSet>
        {
            new QuestSet
            {
                Quest = "[성격] 음악 교과는 다양한 특성을 통해 A, B, C, D, E, F을 기를 수 있게 한다.",
                Answer = "음악적 소통 역량, 음악정보처리 역량, 음악적 창의·융합 사고 역량, 자기관리 역량, 문화적 공동체 역량, 음악적 감성 역량",
                Reference = "소음창자공감 - 소음이 일어나서 창자에서 공감을 했다."
            },

            new QuestSet
            {
                Quest = "'A'은 음악이 가지고 있는 아름다움, 특징 및 가치를 개방적으로 수용하고 이해하며, 깊이 있는 성찰과 상상력을 발휘하여 삶의 질을 향상시키고 행복을 창출할 수 있는 역량이다.",
                Answer = "음악적 감성 역량"
            },

            new QuestSet
            {
                Quest = "'A'은 음악 분야의 전문 지식과 소양을 토대로 새롭고 독창적인 아이디어를 산출해 내고, 자신이 학습하거나 경험한 음악 정보들을 다양한 현상에 융합적으로 활용할 수 있는 역량이다.",
                Answer = "음악적 창의·융합 사고 역량"
            },

            new QuestSet
            {
                Quest = "'A'은 소리, 음악적 상징, 신체 등을 활용하여 자신의 생각과 느낌을 음악적으로 표현하고, 타인의 음악적 표현을 이해하고 공감하여 효율적으로 소통하고 조정할 수 있는 역량이다.",
                Answer = "음악적 소통 역량"
            },

            new QuestSet
            {
                Quest = "'A'은 음악을 통해 우리 문화의 전통과 세계의 다양한 문화를 이해함으로써 지역, 국가, 세계 공동체의 구성원으로서 요구되는 다양한 가치와 문화를 수용하고, 공동체의 문제 해결 및 발전을 위해 자신의 역할과 책임을 다할 수 있는 역량이다.",
                Answer = "문화적 공동체 역량"
            },

            new QuestSet
            {
                Quest = "'A'은 음악과 관련된 정보와 자료를 수집, 분석, 분류, 평가, 조작함으로써 정보와 자료에 내재된 의미를 올바르게 파악하고, 적절한 매체를 활용하여 정보와 자료를 효과적으로 처리함으로써 생활의 다양한 문제를 합리적으로 해결할 수 있는 역량이다.",
                Answer = "음악정보처리 역량"
            },

            new QuestSet
            {
                Quest = "'A'은 음악적 표현과 감상 활동, 음악을 생활화하는 태도를 바탕으로 표현력과 감수성을 길러 자아 정체성을 형성하고, 자기 주도적으로 음악을 학습하고 그 과정을 관리함으로써 음악적으로 풍요로운 삶을 유지해나갈 수 있는 역량이다.",
                Answer = "자기관리 역량"
            },

            new QuestSet
            {
                Quest = "[초등3~4] (1) 표현 : 3~4학년의 표현 영역에서는 음악의 구성 A에 대한 이해와 소리의 B 및 노래, 악기 C, 신체표현, 음악 D 등의 다양한 활동을 통해 음악성과 창의성을 기른다.",
                Answer = "요소, 탐색, 연주, 만들기",
                FullSentence = "3~4학년의 표현 영역에서는 음악의 구성 요소에 대한 이해와 소리의 탐색 및 노래, 악기 연주, 신체표현, 음악 만들기 등의 다양한 활동을 통해 음악성과 창의성을 기른다."
            },

            new QuestSet
            {
                Quest = "[4음01-01] 악곡의 A을 이해하며 B 부르거나 C로 연주한다.",
                Answer = "특징, 노래, 악기",
                FullSentence = "악곡의 특징을 이해하며 노래 부르거나 악기로 연주한다."
            },

            new QuestSet
            {
                Quest = "[4음01-02] 악곡에 어울리는 A을 한다.",
                Answer = "신체표현",
                FullSentence = "악곡에 어울리는 신체표현을 한다."
            },

            new QuestSet
            {
                Quest = "[4음01-03] 제재곡의 A을 바꾸거나 A에 맞는 B로 만든다.",
                Answer = "노랫말, 말붙임새",
                FullSentence = "제재곡의 노랫말을 바꾸거나 노랫말에 맞는 말붙임새로 만든다."
            },

            new QuestSet
            {
                Quest = "[4음01-04] 제재곡의 A이나 B을 바꾸어 표현한다.",
                Answer = "리듬꼴, 장단꼴",
                FullSentence = "제재곡의 리듬꼴이나 장단꼴을 바꾸어 표현한다."
            },

            new QuestSet
            {
                Quest = "[4음01-05] 주변의 A를 탐색하여 다양한 B으로 C한다.",
                Answer = "소리, 방법, 표현",
                FullSentence = "주변의 소리를 탐색하여 다양한 방법으로 표현한다."
            },

            new QuestSet
            {
                Quest = "[4음01-06] 바른 A로 노래 부르거나 바른 A와 B으로 악기를 C한다.",
                Answer = "자세, 주법, 연주",
                FullSentence = "바른 자세로 노래 부르거나 바른 자세와 주법으로 악기를 연주한다."
            },

            new QuestSet
            {
                Quest = "[4음01-01], [4음01-02] 해설 : 노래를 부르거나, 여러 가지 악기로 연주하고, 악곡의 전체적인 분위기와 특징에 어울리는 신체 표현을 하는 등 다양한 A으로 음악을 B하도록 한다. 이때 악곡에 포함된 3~4학년 수준의 음악 요소를 C과 D하여 학습하면서 음악 개념을 형성하고, 특히 악곡의 특징을 살려서 노래 부르거나 악기로 연주하며, 느낌을 자연스럽게 표현하고 즐거움을 느낄 수 있도록 한다. ",
                Answer = "방법, 표현, 활동, 연계",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "[4음01-03], [4음01-04], [4음01-05] 해설 : 악곡의 노랫말과 음악의 구성 요소를 활용하여 A을 자유롭게 만들고 이를 표현하도록 하며, 주변 환경의 다양한 소리에 관심을 갖고 이를 재현하는 활동을 하도록 한다.",
                Answer = "음악적 산출물",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "다양한 음악적 경험을 통해 음악을 구성하는 A들을 이해하고, 악곡의 특징을 B, C, D, E 등을 활용하여 창의적으로 F하도록 한다.",
                Answer = "요소, 목소리, 악기, 신체, 그림, 표현",
                FullSentence = "다양한 음악적 경험을 통해 음악을 구성하는 요소들을 이해하고, 악곡의 특징을 목소리, 악기, 신체, 그림 등을 활용하여 창의적으로 표현하도록 한다."
            },

            new QuestSet
            {
                Quest = "학생들의 생각과 경험을 바탕으로 A을 창의적으로 바꿀 수 있도록 지도하며, A의 의미를 살려 B를 만들도록 한다.",
                Answer = "노랫말, 말붙임새",
                FullSentence = "학생들의 생각과 경험을 바탕으로 노랫말을 창의적으로 바꿀 수 있도록 지도하며, 노랫말의 의미를 살려 말붙임새롤 만들도록 한다."
            },

            new QuestSet
            {
                Quest = "악곡의 A과 B을 충분히 습득한 후, 창의적으로 A과 B을 바꾸어 표현할 수 있도록 단계적으로 지도한다.",
                Answer = "리듬꼴, 장단꼴",
                FullSentence = "악곡의 리듬꼴과 장단꼴을 충분히 습득한 후, 창의적으로 리듬꼴과 장단꼴을 바꾸어 표현할 수 있도록 단계적으로 지도한다."
            },

            new QuestSet
            {
                Quest = "자연이나 생활 속의 다양한 소리를 A하여 B, C, D, E 등으로 표현하도록 한다. ",
                Answer = "탐색, 목소리, 악기, 신체, 물체",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "노래, 악기 A, B 을 C적으로 활용하여 표현할 수 있도록 한다.",
                Answer = "연주, 신체표현, 통합",
                FullSentence = "노래, 악기 연주, 신체표현을 통합적으로 활용하여 표현할 수 있도록 한다."
            },

            new QuestSet
            {
                Quest = "노래 부르기는 A과 B의 C를 탐색하고, 그에 따른 느낌을 자유롭게 표현하도록 한다.",
                Answer = "노랫말, 가락, 관계",
                FullSentence = "노래 부르기는 노랫말과 가락의 관계를 탐색하고, 그에 따른 느낌을 자유롭게 표현하도록 한다."
            },

            new QuestSet
            {
                Quest = "가락, A, B을 지도할 때에는 C, D 등을 활용하여 다양하게 표현하도록 한다.",
                Answer = "시김새, 창법, 손, 가락선 악보",
                FullSentence = "가락, 시김새, 창법을 지도할 때에는 손, 가락선 악보 등을 활용하여 다양하게 표현하도록 한다."
            },

            new QuestSet
            {
                Quest = "악기의 소리를 A하고 그 B을 살려 연주하도록 한다.",
                Answer = "탐색, 특징",
                FullSentence = "악기의 소리를 탐색하고 그 특징을 살려 연주하도록 한다."
            },

            new QuestSet
            {
                Quest = "학생의 수준에 따라 A, B, C, D 등을 활용하여 음악을 만들어 표현하도록 한다.",
                Answer = "그림, 기호, 문자, 악보",
                FullSentence = "학생의 수준에 따라 그림, 기호, 문자, 악보 등을 활용하여 음악을 만들어 표현하도록 한다."
            },

            new QuestSet
            {
                Quest = "A 위주의 수업보다 B 위주의 수업을 통해 악곡의 C을 지도한다. ",
                Answer = "이론, 활동, 특징",
                FullSentence = "이론 위주의 수업보다 활동 위주의 수업을 통해 악곡의 특징을 지도한다."
            },

            new QuestSet
            {
                Quest = "국악곡은 되도록 A로 반주하여 국악의 B을 살려 노래 부를 수 있도록 한다.",
                Answer = "국악기, 특징",
                FullSentence = "국악곡은 되도록 국악기로 반주하여 국악의 특징을 살려 노래 부를 수 있도록 한다."
            },

            new QuestSet
            {
                Quest = "자유롭게 A를 탐색하고 음악을 B적으로 만들 수 있는 분위기를 조성한다.",
                Answer = "소리, 창의",
                FullSentence = "자유롭게 소리를 탐색하고 음악을 창의적으로 만들 수 있는 분위기를 조성한다."
            },

            new QuestSet
            {
                Quest = "A과 관련된 음악 만들기는 B를 활용하거나 노래 부르기를 통해 그 결과를 표현할 수 있도록 한다.",
                Answer = "국악, 국악기",
                FullSentence = "국악과 관련된 음악 만들기는 국악기를 활용하거나 노래 부르기를 통해 그 결과를 표현할 수 있도록 한다."
            },

            new QuestSet
            {
                Quest = "노래 부르거나 악기 연주 시 A로 연주할 수 있도록 지도한다.",
                Answer = "바른 자세",
                FullSentence = "노래 부르거나 악기 연주 시 바른 자세로 연주할 수 있도록 지도한다."
            },

            new QuestSet
            {
                Quest = "악기의 좋은 소리를 유지하기 위해 악기를 A하는 법을 안내한다.",
                Answer = "관리",
                FullSentence = "악기의 좋은 소리를 유지하기 위해 악기를 관리하는 법을 안내한다."
            },

            new QuestSet
            {
                Quest = "평가의 내용에 따라 A, B, C 등 다양한 유형의 D을 적절하게 활용한다.",
                Answer = "실기 평가, 관찰, 포트폴리오, 방법",
                FullSentence = "평가의 내용에 따라 실기 평가, 관찰, 포트폴리오 등 다양한 유형의 방법을 적절하게 활용한다."
            },

            new QuestSet
            {
                Quest = "[초등3~4] (2) 감상 : 3~4학년의 감상 영역에서는 음악 A와 B을 알고 C이나 D 등을 표현한 음악을 듣고 종류 및 배경을 파악하여 음악적 이해와 감성을 넓힌다.",
                Answer = "요소, 개념, 상황, 이야기",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "[4음02-01] 3~4학년 수준의 A와 B을 C하여 D한다.",
                Answer = "음악 요소, 개념, 구별, 표현",
                FullSentence = "3~4학년 수준의 음악 요소의 개념을 구별하여 표현한다."
            },

            new QuestSet
            {
                Quest = "[4음02-02] A나 B 등을 표현한 음악을 듣고 D을 E한다.",
                Answer = "상황, 이야기, 느낌, 발표",
                FullSentence = "상황이나 이야기 등을 표현한 음악을 듣고 느낌을 발표한다."
            },

            new QuestSet
            {
                Quest = "[4음02-01] 해설 : 악곡에서 3~4학년 수준의 A와 B을 알고 C, D, E, F 등의 다양한 방식으로 표현하도록 한다.",
                Answer = "음악 요소, 개념, 소리, 언어, 그림, 신체",
                FullSentence = "악곡에서 3~4학년 수준의 음악 요소와 개념을 알고 소리, 언어, 그림, 신체 등의 다양한 방식으로 표현하도록 한다."
            },

            new QuestSet
            {
                Quest = "[4음02-02] 해설 : A나 B 등을 표현한 음악을 듣고, 장면이나 줄거리에 어울리는 음악의 표현적 요소에 대해 파악하고 느낌을 발표하도록 한다.",
                Answer = "상황, 이야기",
                FullSentence = "상황이나 이야기 등을 표현한 음악을 듣고, 장면이나 줄거리에 어울리는 음악의 표현적 요소에 대해 파악하고 느낌을 발표하도록 한다."
            },

            new QuestSet
            {
                Quest = "A을 통해 음악 요소와 개념을 B할 수 있도록 지도한다.",
                Answer = "실음, 구별",
                FullSentence = "실음을 통해 음악 요소와 개념을 구별할 수 있도록 지도한다.",
                Reference = "실음 = 실제 소리"
            },

            new QuestSet
            {
                Quest = "음악 요소와 개념은 A, B, C 활동 등을 적극적으로 활용하여 지도한다.",
                Answer = "시각적, 청각적, 신체적",
                FullSentence = "음악 요소와 개념은 시각적, 청각적, 신체적 활동 등을 적극적으로 활용하여 지도한다."
            },

            new QuestSet
            {
                Quest = "악곡의 A을 파악하기 위해 B, C, D등 여러 가지 E를 활용한다.",
                Answer = "특징, 음원, 그림, 영상, 자료",
                FullSentence = "악곡의 특징을 파악하기 위해 음원, 그림, 영상 등 여러 가지 자료를 활용한다."
            },

            new QuestSet
            {
                Quest = "A을 통해 학생들이 음악에 대한 B 체험을 할 수 있도록 다양한 교수·학습 방법을 활용한다.",
                Answer = "음악 감상, 미적",
                FullSentence = "음악 감상을 통해 학생들이 음악에 대한 미적 체험을 할 수 있도록 다양한 교수·학습 방법을 활용한다."
            },

            new QuestSet
            {
                Quest = "평가의 내용에 따라 A, B, C, D 등 다양한 유형의 방법을 적절하게 활용한다.",
                Answer = "실음 지필 평가, 관찰, 포트폴리오, 보고서",
                FullSentence = "평가의 내용에 따라 실음 지필 평가, 관찰, 포트폴리오, 보고서 등 다양한 유형의 방법을 적절하게 활용한다."
            },

            new QuestSet
            {
                Quest = "교사의 평가뿐만 아니라 A, B 등 C의 평가를 병행하여 실시할 수 있다.",
                Answer = "상호 평가, 자기 평가, 학생",
                FullSentence = "교사의 평가 뿐만 아니라 상호 평가, 자기 평가 등 학생의 평가를 병행하여 실시할 수 있다."
            },

            new QuestSet
            {
                Quest = "음악에 대한 포괄적 A의 정도와 B 등을 평가한다.",
                Answer = "이해, 태도",
                FullSentence = "음악에 대한 포괄적 이해의 정도와 태도 등을 평가한다."
            },

            new QuestSet
            {
                Quest = "[초등3~4] (3) 생활화 : 3~4학년의 생활화 영역에서는 학생들이 자기 주변의 A에 참여하고 실내외의 다양한 B를 하면서 음악을 활용하고 즐기는 태도를 갖도록 한다. 또한 C을 통해 우리음악을 애호하는 마음과 태도를 기른다.",
                Answer = "행사, 놀이, 생활 속의 국악",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "[4음03-01] 음악을 활용하여 A, B, C 등의 D에 참여하고 느낌을 E한다.",
                Answer = "가정, 학교, 사회, 행사, 발표",
                FullSentence = "음악을 활용하여 가정, 학교, 사회 등의 행사에 참여하고 느낌을 발표한다."
            },

            new QuestSet
            {
                Quest = "[4음03-02] 음악을 A에 활용해보고 느낌을 B한다.",
                Answer = "놀이, 발표",
                FullSentence = "음악을 놀이에 활용해보고 느낌을 발표한다."
            },

            new QuestSet
            {
                Quest = "[4음03-03] A 속에서 활용되고 있는 B을 찾아 발표한다.",
                Answer = "생활, 국악",
                FullSentence = "생활 속에서 활용되고 있는 국악을 찾아 발표한다."
            },

            new QuestSet
            {
                Quest = "[4음03-02] 해설 : 다양한 종류의 A에 사용된 음악에 관심을 갖고 음악이 사용된 A를 하거나 음악을 활용해서 A를 해본 느낌을 발표하도록 한다.",
                Answer = "놀이",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "학교 내외의 음악 활동과 관련된 다양한 정보와 기회를 제공하여 학생들이 A적으로 음악 활동에 B할 수 있도록 지도한다.",
                Answer = "적극, 참여",
                FullSentence = "학교 내외의 음악 활동과 관련된 다양한 정보와 기회를 제공하여 학생들이 적극적으로 음악 활동에 참여할 수 있도록 지도한다."
            },

            new QuestSet
            {
                Quest = "학교 내외의 음악 활동에 A하는 정도, 음악에 대한 B와 C의 실천 정도 등을 평가한다.",
                Answer = "참여, 태도, 생활화",
                FullSentence = "학교 내외의 음악 활동에 참여하는 정도, 음악에 대한 태도와 생활화의 실천 정도 등을 평가한다."
            },

            new QuestSet
            {
                Quest = "[초등5~6] (1) 표현 : 5~6학년의 표현 영역에서는 A 요소에 대한 이해와 노래, B, 신체 표현, 음악 만들기 등의 다양한 활동을 통해 음악성과 창의성을 기른다.",
                Answer = "음악의 구성, 악기 연주",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "[6음01-01] 악곡의 A을 이해하며 B 부르거나 C로 D한다.",
                Answer = "특징, 노래, 악기, 연주",
                FullSentence = "악곡의 특징을 이해하며 노래 부르거나 악기로 연주한다.",
                Reference = "[4음01-01] 성취기준과 같다."
            },

            new QuestSet
            {
                Quest = "[6음01-02] A에 어울리는 B표현을 한다.",
                Answer = "악곡, 신체",
                FullSentence = "악곡에 어울리는 신체표현을 한다.",
                Reference = "[4음01-02] 성취기준과 같다."
            },

            new QuestSet
            {
                Quest = "[6음01-03] 제재곡의 A을 바꾸거나 A에 맞는 B로 만든다.",
                Answer = "노랫말, 말붙임새",
                FullSentence = "제재곡의 노랫말을 바꾸거나 노랫말에 맞는 말붙임새로 만든다.",
                Reference = "[4음01-03] 성취기준과 같다."
            },

            new QuestSet
            {
                Quest = "[6음01-04] 제재곡의 일부 A을 B 표현한다.",
                Answer = "가락, 바꾸어",
                FullSentence = "제재곡의 일부 가락을 바꾸어 표현한다."
            },

            new QuestSet
            {
                Quest = "[6음01-05] 이야기의 A이나 B을 음악으로 C한다.",
                Answer = "장면, 상황, 표현",
                FullSentence = "이야기의 장면이나 상황을 음악으로 표현한다."
            },

            new QuestSet
            {
                Quest = "[6음01-06] 바른 A와 B으로 노래 부르거나 바른 A와 C으로 악기를 연주한다.  ",
                Answer = "자세, 호흡, 주법",
                FullSentence = "바른 자세와 호흡으로 노래 부르거나 바른 자세와 주법으로 악기를 연주한다."
            },

            new QuestSet
            {
                Quest = "[6음01-01], [6음01-02] 해설 : 노래를 부르거나 여러 가지 악기로 연주하고, 악곡의 전체적인 분위기와 특징에 어울리는 신체표현을 하는 등 다양한 방법으로 음악을 표현하도록 한다. 이때 악곡에 포함된 5~6학년 수준의 A를 활동과 연계하여 학습하면서 음악 개념을 형성하고, 특히 악곡의 특징을 살려서 노래 부르거나 악기로 연주하며, 느낌을 자유롭게 표현할 수 있도록 한다.",
                Answer = "음악 요소",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "[6음01-03] [6음01-04] [6음01-05] 해설 : 악곡의 일부 A을 주어진 B에 적합하게 바꾸어 노래 부르거나 악기로 연주할 수 있도록 한다. 그리고 이야기의 C이나 D에서 음악적으로 표현할 수 있는 요소를 탐색하여 E, F, G, H 등을 이용하여 음악으로 표현할 수 있도록 한다.",
                Answer = "가락, 조건, 장면, 상황, 목소리, 악기, 신체, 물체",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "[6음01-06] 해설 : 노래를 부를 때 앉아서 또는 서서 부르거나, 자세에 따라 소리가 달라지는 것을 경험하고, 바른 자세와 A의 B에 따라 좋은 소리를 낼 수 있도록 한다.",
                Answer = "호흡, 조절",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "A 바꾸기는 노랫말과 A의 관계를 탐색하고, 악곡의 특징에 대한 이해를 바탕으로 A을 바꾸도록 지도한다.",
                Answer = "가락",
                FullSentence = "가락 바꾸기는 노랫말과 가락의 관계를 탐색하고, 악곡의 특징에 대한 이해를 바탕으로 가락을 바꾸도록 지도한다."
            },

            new QuestSet
            {
                Quest = "A 부르기는 B의 의미를 파악하고, 정확한 C와 바른 D으로 B을 전달할 수 있도록 지도한다.",
                Answer = "노래, 노랫말, 발음, 호흡",
                FullSentence = "노래 부르기는 노랫말의 의미를 파악하고, 정확한 발음과 바른 호흡으로 노랫말을 전달할 수 있도록 지도한다."
            },

            new QuestSet
            {
                Quest = "[초등5~6] (2) 감상 : 5~6학년의 감상 영역에서는 다양한 A의 음악을 듣고 B 요소와 개념, B의 종류와 C을 파악하여 음악적 이해와 감성의 폭을 넓힌다.",
                Answer = "문화권, 음악, 배경",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "[6음02-01] 5~6학년 수준의 A와 B을 구별하여 표현한다.",
                Answer = "음악 요소, 개념",
                FullSentence = "5~6학년 수준의 음악 요소와 개념을 구별하여 표현한다."
            },

            new QuestSet
            {
                Quest = "[6음02-02] 다양한 A의 음악을 듣고 음악의 특징에 관해 B한다.",
                Answer = "문화권, 발표",
                FullSentence = "다양한 문화권의 음악을 듣고 음악의 특징에 관해 발표한다."
            },

            new QuestSet
            {
                Quest = "다른 A와의 연계를 통해 음악의 다양한 B을 폭넓게 이해할 수 있도록 한다.",
                Answer = "교과, 문화적 배경",
                FullSentence = "다른 교과와의 연계를 통해 음악의 다양한 문화적 배경을 폭넓게 이해할 수 있도록 한다."
            },

            new QuestSet
            {
                Quest = "[6음03-01] 음악을 활용하여 A, B, C 등의 D에 참여하고 느낌을 발표한다.",
                Answer = "가정, 학교, 사회, 행사",
                FullSentence = "음악을 활용하여 가정, 학교, 사회 등의 행사에 참여하고 느낌을 발표한다.",
                Reference = "[4음03-01] 성취기준과 같다."
            },

            new QuestSet
            {
                Quest = "[6음03-02] 음악이 A에 미치는 영향에 대해 발표한다.",
                Answer = "심신 건강",
                FullSentence = "음악이 심신 건강에 미치는 영향에 대해 발표한다."
            },

            new QuestSet
            {
                Quest = "[6음03-03] 우리 A에 전승되어 오는 음악 B을 찾아 발표한다.",
                Answer = "지역, 문화유산",
                FullSentence = "우리 지역에 전승되어 오는 음악 문화유산을 찾아 발표한다."
            },

            new QuestSet
            {
                Quest = "[6음03-01] 해설 : 생일과 기념일 등의 가족 행사, 입학식과 졸업식 및 학예회 등의 학교 행사, 지역의 축제 등과 같은 행사에서 음악을 활용할 수 있는 방법에 대해 살펴보고, A의 입장에서 뿐만 아니라 공연자 또는 연주자로서 직접 B한 과정과 느낌에 대하여 C하도록 한다.",
                Answer = "관객, 체험, 발표",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "음악이 몸과 마음의 안정, 정서의 순화, 치유 등 A에 영향을 미치는 사례를 조사하여 발표하도록 한다. ",
                Answer = "심신 건강",
                FullSentence = "음악이 몸과 마음의 안정, 정서의 순화, 치유 등 심신 건강에 영향을 미치는 사례를 조사하여 발표하도록 한다."
            },

            new QuestSet
            {
                Quest = "A에 대한 B과 C에 대한 올바른 가치관을 형성할 수 있도록 지도한다.",
                Answer = "지역, 애호심, 국악",
                FullSentence = "지역에 대한 애호심과 국악에 대한 올바른 가치관을 형성할 수 있도록 지도한다."
            },

            new QuestSet
            {
                Quest = "[평방유] 평가의 내용에 따라 A, 포트폴리오, B 등 다양한 유형의 방법을 적절하게 활용한다.",
                Answer = "관찰, 보고서",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "[평방유] A의 평가 뿐만 아니라 상호 평가, 자기 평가 등 B의 평가를 병행하여 실시할 수 있다.",
                Answer = "교사, 학생",
                FullSentence = ""
            },

             new QuestSet
            {
                Quest = "[평방유] 학교 내외의 음악 활동에 참여하는 정도, 음악에 대한 A와 생활화의 실천 정도 등을 평가한다.",
                Answer = "태도"
            },


        };

        public static List<QuestSet> music_Part_34 = new List<QuestSet>
        {            
            new QuestSet
            {
                Quest = "장구의 각 부의 명칭은?",
                Answer = "북편, 조이개, 채편, 궁굴채, 열채"
            }, 
            
            new QuestSet
            {
                Quest = "장단 기보법에서 '(l)' 부호를 사용할 때, 구음과 명칭을 쓰시오. (구음, 명칭) ",
                Answer = "덩, 합장단"
            },

            new QuestSet
            {
                Quest = "'덩' 소리가 나는 합장단의 연주법을 서술하시오.",
                Answer = "장구의 북편과 채편을 함께 친다."
            },

            new QuestSet
            {
                Quest = "장단 기보법에서 'l' 부호를 사용할 때, 구음과 명칭을 쓰시오. (구음, 명칭)",
                Answer = "덕, 채편"
            },

            new QuestSet
            {
                Quest = "'덕' 소리가 나는 채편의 연주법을 서술하시오.",
                Answer = "장구의 채편만 친다."
            },

            new QuestSet
            {
                Quest = "장단 기보법에서 '○' 부호를 사용할 때, 구음과 명칭을 쓰시오. (구음, 명칭)",
                Answer = "쿵, 북편"
            },

            new QuestSet
            {
                Quest = "'쿵' 소리가 나는 북편의 연주법을 서술하시오.",
                Answer = "장구의 북편만 친다."
            },

            new QuestSet
            {
                Quest = "장단 기보법에서 '|(짧은 줄이 세로로 2개 연달아 나있음)' 부호를 사용할 때, 구음과 명칭을 쓰시오. (구음, 명칭)",
                Answer = "기덕, 겹채"
            },

            new QuestSet
            {
                Quest = "장단 기보법에서 '|(짧은 줄이 세로로 4개 연달아 나있음)' 부호를 사용할 때, 구음과 명칭을 쓰시오.",
                Answer = "더러러러, 채굴림"
            },

            new QuestSet
            {
                Quest = "채굴림의 연주법을 서술하시오.",
                Answer = "채로 채편을 여러 번 굴려 친다."
            },

            new QuestSet
            {
                Quest = "겹채의 연주법을 서술하시오.",
                Answer = "채로 채편을 먼저 약하고 짧게 치고 세게 다시 한 번 친다."
            },

            new QuestSet
            {
                Quest = "장구는 북편의 소리가 채편의 소리보다 높다. (O 아니면 X)",
                Answer = "X",
                Reference = "북편의 울림통이 더 크다."
            },

            new QuestSet
            {
                Quest = "장구의 조이개를 A 쪽으로 움직이면 소리가 높아진다.",
                Answer = "채편"
            },

            new QuestSet
            {
                Quest = "장구의 조이개를 A 쪽으로 움직이면 소리가 낮아진다.",
                Answer = "북편"
            },

            new QuestSet
            {
                Quest = "장구를 보관하는 방법으로는 1. A 쪽으로 조이개를 풀어놓아야 한다는 것, 2. B에는 통풍이 잘 되고 습기가 적은 곳에 보관하며 C에는 가방에 넣어서 보관하는 것 등이 있다.",
                Answer = "북편, 여름, 겨울"
            },

            new QuestSet
            {
                Quest = "A 장구는 노래나 산조(기악 독주곡) 등을 반주할 때, 북편을 손으로 연주하고, 몸의 중심부에 놓고 연주한다. 반면 B 장구는 사물놀이나 풍물놀이를 연주할 때 사용하며, 북편을 궁굴채로 연주하고, 채편이 몸 가운데에 와야 한다.",
                Answer = "반주, 풍물"
            },

            new QuestSet
            {
                Quest = "A 연주시 유의점으로는, 열채가 사선으로 A의 한가운데를 지나도록 쳐야 한다는 것이 있다.",
                Answer = "채편"
            },

            new QuestSet
            {
                Quest = "세마치장단의 구음을 띄어쓰기 없이 서술하시오.",
                Answer = "덩덩덕쿵덕"
            },

            new QuestSet
            {
                Quest = "자진모리장단의 구음을 12소박 단위로 나누어 A, B의 형태로 띄어쓰기 없이 서술하시오.(A, B)",
                Answer = "덩쿵쿵덕쿵, 덩덕쿵덕쿵덕쿵덕"
            },

            new QuestSet
            {
                Quest = "굿거리장단의 구음을 12소박 단위로 나누어 A, B의 형태로 띄어쓰기 없이 서술하시오. (A, B)",
                Answer = "덩기덕쿵더러러러쿵기덕쿵더러러러, 덩기덕쿵더러러러쿵기덕쿵덕"
            },

            new QuestSet
            {
                Quest = "중중모리장단의 구음을 12소박 단위로 나누어 A, B의 형태로 띄어쓰기 없이 서술하시오.",
                Answer = "덩덕쿵덕덕쿵쿵덕쿵쿵, 덩덕쿵덕덕쿵쿵덕쿵덕"
            },

            new QuestSet
            {
                Quest = "3소박 3박자이며, '덩덩덕쿵덕' 구음을 가진 장단의 이름은?",
                Answer = "세마치장단"
            },

            new QuestSet
            {
                Quest = "3소박 4박자이며, '덩쿵쿵덕쿵, 덩덕쿵덕쿵덕쿵덕' 구음을 가진 장단의 이름은? ",
                Answer = "자진모리장단"
            },

            new QuestSet
            {
                Quest = "3소박 4박자이며, '덩기덕쿵더러러러쿵기덕쿵더러러러' 구음을 가진 장단의 이름은?",
                Answer = "굿거리장단"
            },

            new QuestSet
            {
                Quest = "3소박 4박자이며, '덩덕쿵덕덕쿵쿵덕쿵쿵, 덩덕쿵덕덕쿵쿵덕쿵덕' 구음을 가진 장단의 이름은?",
                Answer = "중중모리장단"
            },

            new QuestSet
            {
                Quest = "세종대왕이 만든 것으로, '우물 정(井)'자 모양의 칸에 음악을 기록한 악보는?",
                Answer = "정간보"
            },

            new QuestSet
            {
                Quest = "정간보에 적어넣을 수 있는 것은 A, B, C 3가지가 있다. 3가지를 순서대로 쓰시오. (A, B, C)",
                Answer = "율명, 구음, 부호"
            },

            new QuestSet
            {
                Quest = "정간보에서 <의 이름은 A로, 빠르게 숨을 쉬라는 의미다. 반면 △의 이름은 B로, 해당 박만큼 쉬어야 한다는 뜻이다.",
                Answer = "숨표, 쉼표"
            },

            new QuestSet
            {
                Quest = "정간보를 읽을 때에는 순서대로 A에서 B로, C에서 D으로 읽는다. ",
                Answer = "위, 아래, 오른쪽, 왼쪽"
            },

            new QuestSet
            {
                Quest = "정간보에서 A 한 칸은 한 박(기본박), 점4분음표를 의미한다.",
                Answer = "실선 정간"
            },

            new QuestSet
            {
                Quest = "정간보에서 A으로 표현된 정간은 소박, 8분음표를 의미한다.",
                Answer = "점선"
            },

            new QuestSet
            {
                Quest = "A는 가락을 꾸며주는 역할을 하며, 가락의 자연스러운 연결이나 유연한 흐름을 위하여 또는 화려함과 멋스러움을 위하여 사용하는 표현 기법이다.",
                Answer = "시김새"
            },

            new QuestSet
            {
                Quest = "음계, 발성, 분위기와 시김새가 나타나는 각 지역 노래의 특징은?",
                Answer = "토리"
            },

            /*new QuestSet
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
            },

            new QuestSet
            {
                Quest = "",
                Answer = ""
            }
            */
        };
    }
}
