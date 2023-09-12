using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 초등임용복습프로그램
{
    class ArtQL
    {
        public static List<QuestSet> art_CU = new List<QuestSet>
        {
            new QuestSet
            {
                Quest = "1. 성격 - 미술 교과에서는 A, B, C, D, E 등을 교과 역량으로 삼고 있다.",
                Answer = "미적 감수성, 시각적 소통 능력, 창의·융합 능력, 미술 문화 이해 능력, 자기 주도적 미술 학습 능력",
                FullSentence = "미술 교과에서는 미적 감수성, 시각적 소통 능력, 창의·융합 능력, 미술 문화 이해 능력, 자기 주도적 미술 학습 능력 등을 교과 역량으로 삼고 있다."
            },

            new QuestSet
            {
                Quest = "첫째. 'A'은 다양한 대상 및 현상에 대한 지각을 통해 자신의 느낌과 생각을 이해하고 표현하며 미적 경험에 반응하면서 미적 가치를 느끼고 내면화할 수 있는 능력이다.",
                Answer = "미적 감수성",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "둘째. 'A'은 변화하는 시각 문화 속에서 이미지와 정보, 시각 매체를 이해하고 비판적으로 해석하며, 이를 활용한 미술 활동을 통해 소통할 수 있는 능력이다.",
                Answer = "시각적 소통 능력",
                Reference = "총론 - 의사소통 역량",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "셋째. 'A'은 자신의 느낌과 생각을 다양한 매체를 활용하여 창의적으로 표현하고 미술 활동 과정에 타 분야의 지식, 기술, 경험 등을 연계, 융합하여 새로운 가능성을 발견할 수 있는 능력이다.",
                Answer = "창의·융합 능력",
                Reference = "총론 - 창의적 사고 역량",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "넷째. 'A'은 우리 미술 문화에 대한 이해를 바탕으로 정체성을 확립하고, 유연하고 개방적인 태도로 세계 미술 문화의 다원적 가치를 이해하고 존중하며 공동체의 발전에 참여할 수 있는 능력이다.",
                Answer = "미술 문화 이해 능력",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "다섯째. 'A'은 미술 활동에 자발적이고 주도적으로 참여하면서 자기를 계발·성찰하며, 그 과정에서 타인의 생각과 느낌을 이해하고 존중·배려하며 협력할 수 있는 능력이다.",
                Answer = "자기 주도적 미술 학습 능력",
                Reference = "총론 - 자기관리 역량",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "미술 교과 내용은 A, B, C 영역으로 구성된다.",
                Answer = "체험, 표현, 감상",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "'A' 영역에서는 감각을 통해 자신과 주변 세계와의 관계를 이해하고 조화를 발견한다. 또한 시각 문화의 역할과 가치를 이해하고 참여하며, 미술과 타 분야를 관련지어 이해하는 한편 생활 속에서 미술을 활용하도록 한다.",
                Answer = "체험",
                Reference = "지각, 소통, 연결",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "'A' 영역에서는 다양한 방식으로 주제나 아이디어를 탐색하고, 작품의 표현 방법과 제작 과정을 계획하며, 표현 과정에서 매체를 탐구하여 창의적으로 제작하도록 한다.",
                Answer = "표현",
                Reference = "발상, 제작",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "'A' 영역에서는 미술 작품의 조형적 특징, 작가, 시대적·지역적 배경을 이해하고 해석하며, 다양한 비평 관점에 따라 작품을 판단 및 평가한다. 그리고 우리의 전통 미술과 다양한 미술 문화를 이해하고 존중하도록 한다.",
                Answer = "감상",
                Reference = "이해, 비평",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "2. 목표 - 다양한 미술 활동을 통하여 대상을 감각적으로 인식하고, 느낌과 생각을 창의적으로 표현하며, 미술 작품의 가치를 판단함으로써 삶 속에서 A를 B할 수 있는 능력을 기른다.",
                Answer = "미술 문화, 향유",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "가. 주변 A를 미적으로 B하고 시각적으로 C하는 능력을 기른다.",
                Answer = "세계, 인식, 소통",
                Reference = "미적 감수성, 시각적 소통 능력",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "나. A인 미술 활동을 통해 B으로 사고하고 표현할 수 있는 능력을 기른다.",
                Answer = "자기 주도적, 창의·융합적",
                Reference = "자기 주도적 미술 학습 능력, 창의·융합 능력",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "다. 미술 작품이 지닌 특징을 A하고 B할 수 있는 능력을 기른다.",
                Answer = "이해, 비평",
                Reference = "미술 문화 이해 능력, 시각적 소통 능력",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "라. 미술을 A하며 문화의 다원적 B를 C하는 태도를 지닌다.",
                Answer = "생활화, 가치, 존중",
                Reference = "자기 주도적 미술 학습 능력, 미술 문화 이해 능력",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "초등학교 미술에서는 A을 함양하는 데 중점을 둔다.",
                Answer = "미술의 기초 능력",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "[초등3~4] (1) 체험 : 3, 4학년의 '체험' 영역에서는 몸의 A을 활용하여 다양한 활동에 자발적으로 참여하면서 미술에 흥미와 관심을 가지고 기초적인 미적 지각 능력 및 미술과 B을 C할 수 있는 능력을 기른다. 이를 위해 다양한 감각을 활용한 탐색 활동을 통해 D에 대한 자신의 느낌과 생각을 나타내고, 생활 속에서 미술을 발견하여 자신과 관련짓는 데 중점을 둔다.",
                Answer = "감각, 생활, 연결, 대상",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "[4미01-01] 자연물과 인공물을 A하는 데 B을 활용할 수 있다.",
                Answer = "탐색, 다양한 감각",
                Reference = "내용 요소 - 자신의 감각, 기능 - 탐색하기, 감각 활용하기",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "[4미01-02] 주변 A을 B하여 자신의 느낌과 생각을 다양한 방법으로 C 수 있다.",
                Answer = "대상, 탐색, 나타낼",
                Reference = "내용 요소 - 대상의 탐색, 기능 - 나타내기",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "[4미01-03] A 속에서 다양하게 활용되고 있는 B을 C할 수 있다.",
                Answer = "생활, 미술, 발견",
                Reference = "내용 요소 - 미술과 생활, 기능 - 발견하기",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "[4미01-04] A을 자신의 B과 C지을 수 있다.",
                Answer = "미술, 생활, 관련",
                Reference = "내용 요소 - 미술과 생활, 기능 - 관련짓기",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "3~4학년 '체험' 영역 교학방유 : 체험 활동 후 자신의 느낌이나 생각을 A, B, C, D, E, F 등을 통해 자유롭게 나타내도록 G적인 수업 분위기를 조성한다.",
                Answer = "글, 이미지, 소리, 영상, 사진, 행위, 허용",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "3~4학년 '체험' 영역 교학방유 : 현장 학습을 통한 A이나 사진, 영상, 멀티미디어 자료 등을 활용한 B 등을 통해 지도한다.",
                Answer = "직접적인 체험, 간접적인 체험",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "3~4학년 '체험' 영역 평방유 : A을 B하는 능력, C을 D하고 E하는 능력, F 속에서 G을 발견하는 능력 등을 평가한다.",
                Answer = "감각, 활용, 대상, 관찰, 이해, 생활, 미술",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "[초등3~4] (2) 표현 : 3, 4학년의 '표현' 영역에서는 생활 속에서 표현 주제를 찾거나 A을 통해 표현 주제를 탐색할 수 있는 B 능력과 작품 C에 대한 기본적인 이해를 바탕으로 D의 사용법 등을 익혀 기초적인 E 능력을 기른다. 이를 위해 F한 방식으로 G를 풍부하게 떠올리고 H을 세울 수 있으며, 표현 의도에 적합한 I를 탐색하고, 기본적인 J를 활용하여 자유롭게 작품을 제작하는 데 중점을 둔다.",
                Answer = "관찰과 상상, 발상, 제작, 표현 재료와 용구, 제작, 다양, 주제, 표현 계획, 조형 요소, 재료와 용구",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "[4미02-01] 미술의 A한 표현 B에 관심을 가질 수 있다.",
                Answer = "다양, 주제",
                Reference = "내용 요소 - 다양한 주제"
            },

            new QuestSet
            {
                Quest = "[4미02-02] A를 자유롭게 떠올릴 수 있다.",
                Answer = "주제",
                Reference = "다양한 주제"
            },

            new QuestSet
            {
                Quest = "[4미02-03] 연상, A하거나 대상을 B하여 주제를 탐색할 수 있다.",
                Answer = "상상, 관찰",
                Reference = "내용 요소 - 상상과 관찰, 기능 - 관찰하기",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "[4미02-04] A 방법과 과정에 관심을 가지고 B할 수 있다.",
                Answer = "표현, 계획",
                Reference = "내용 요소 - 표현 계획, 기능 - 계획하기"
            },

            new QuestSet
            {
                Quest = "[4미02-05] A (B, C, D, E, F, G, H 등)의 특징을 탐색하고, 표현 의도에 적합하게 적용할 수 있다.",
                Answer = "조형 요소, 점, 선, 면, 형·형태, 색, 질감, 양감",
                Reference = "내용 요소 - 조형 요소",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "[4미02-06] 기본적인 A의 B을 익혀 안전하게 사용할 수 있다.",
                Answer = "표현 재료와 용구, 사용법",
                Reference = "내용 요소 - 표현 재료와 용구, 기능 - 방법 익히기",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "3~4학년 '표현' 영역 교학방유 : A이나 B 등을 활용하여 다양한 주제를 찾아보도록 지도한다.",
                Answer = "학생 작품, 작가 작품",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "3~4학년 '표현' 영역 교학방유 : 학습자의 삶에서 A하고 B로운 것으로부터 C를 자유롭게 떠올리도록 지도한다.",
                Answer = "친근, 흥미, 주제",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "3~4학년 '표현' 영역 교학방유 : A과 B의 방법으로 유연하게 사고하거나 C의 방법으로 세심하게 대상을 탐색하도록 지도한다.",
                Answer = "연상, 상상, 관찰",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "3~4학년 '표현' 영역 교학방유 : A는 체험, 감상 활동과 연계하여 자연스럽게 이해하고 적용하도록 지도한다.",
                Answer = "조형 요소",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "3~4학년 '표현' 영역 교학방유 : A을 활용하여 기본적인 재료와 용구의 사용법을 구조화된 연습과 독립적인 연습을 통해 익히고, 안전하게 사용하도록 지도한다.",
                Answer = "직접 교수법",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "3~4학년 '표현' 영역 평방유 : 다양한 A 능력, 상상과 관찰 능력, 조형 요소 이해 및 적용 능력, 기본적인 표현 재료와 용구 사용 능력 등을 평가한다.",
                Answer = "주제 탐색",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "[초등3~4] (3) 감상 : 3, 4학년의 '감상' 영역에서는 A를 이해하는 기초적인 소양을 기르며, 서로 다른 느낌과 생각을 이해하고 존중하는 태도를 기른다. 이를 위해 다양한 분야의 미술 B과 C들이 있음을 알고, 미술 B에 대한 자신의 D과 E을 설명하며, 미술 작품을 올바른 F로 G하는 데 중점을 둔다.",
                Answer = "미술 문화, 작품, 미술가, 느낌, 생각, 태도, 감상",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "[4미03-01] 다양한 분야의 미술 A과 B들에 관심을 가질 수 있다.",
                Answer = "작품, 미술가",
                Reference = "내용 요소 - 작품과 미술가",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "[4미03-02] 관심있는 미술 A과 B에 대하여 C할 수 있다.",
                Answer = "작품, 미술가, 설명",
                Reference = "내용 요소 - 작품과 미술가, 기능 - 설명하기",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "[4미03-03] 미술 작품에 대한 A을 발표하고 그 이유를 B할 수 있다.",
                Answer = "자신의 느낌과 생각, 설명",
                Reference = "내용 요소 - 작품에 대한 느낌과 생각, 기능 - 설명하기"
            },


            new QuestSet
            {
                Quest = "[4미03-04] 미술 작품을 A하는 올바른 B를 알고 작품을 소중히 다룰 수 있다.",
                Answer = "감상, 태도",
                Reference = "내용 요소 - 감상 태도",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "3~4학년 '감상' 영역 교학방유 : 작품에 대한 문장 만들기, 작품을 소개하는 편지쓰기, 작품 카드 찾기, 작품 속 장면을 연극으로 표현하기 등 A와 B을 중심으로 자신의 느낌과 생각을 발표하도록 지도한다.",
                Answer = "놀이, 활동",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "[초등5~6] (1) 체험 : 5, 6학년의 '체험' 영역에서는 미적 지각의 기초적인 개념을 이해하고, 미술의 다양한 이미지를 통해 시각적으로 A하고 B할 수 있는 능력을 기른다. 이를 위해 C의 D을 발견하고 E를 활용하여 자신의 느낌과 생각을 전달하며, F를 미술 활동에 적극적으로 활용하는 데 중점을 둔다.",
                Answer = "소통, 연결, 자신과 대상, 시각적 특징, 이미지, 타 교과",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "[6미01-01] A의 특징을 다양한 방법으로 B할 수 있다.",
                Answer = "자신, 탐색",
                Reference = "내용 요소 - 자신과 대상, 기능 - 탐색하기",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "[6미01-02] A이나 현상에서 시각적 특징을 B할 수 있다.",
                Answer = "대상, 발견",
                Reference = "내용 요소 - 대상의 탐색, 기능 - 발견하기",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "[6미01-03] A가 나타내는 B를 찾을 수 있다.",
                Answer = "이미지, 의미",
                Reference = "내용 요소 - 이미지와 의미",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "[6미01-04] A를 활용하여 자신의 느낌과 생각을 전달할 수 있다.",
                Answer = "이미지",
                Reference = "내용 요소 - 이미지와 의미",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "[6미01-05] A 활동에 B의 내용, 방법 등을 활용할 수 있다.",
                Answer = "미술, 타 교과",
                Reference = "내용 요소 - 미술과 타 교과",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "5~6학년 '체험' 영역 교학방유 : 자신의 A 뿐만 아니라 성격, 취향, 관심 등의 B을 마인드 맵, 브레인스토밍 등을 활용하여 찾아보도록 지도한다.",
                Answer = "외적 특징, 내적 특징",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "5~6학년 '체험' 영역 교학방유 : 자신에게 의미 있는 A이나 B, C 등을 주의 깊게 관찰하여 특징적인 D, E, F, G 등을 발견하도록 지도한다.",
                Answer = "인물, 사물, 현상, 선, 형, 색, 이미지",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "5~6학년 '체험' 영역 교학방유 : 마크, 표지판, A, B, C 등의 D를 생활 속에서 찾아보고 관찰하도록 지도한다.",
                Answer = "픽토그램, 포스터, 광고, 시각 이미지",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "5~6학년 '체험' 영역 교학방유 : 미술 수업 내용과 관련된 A의 내용과 방법을 수업 전에 미리 찾아보도록 지도한다.",
                Answer = "다른 교과",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "[초등5~6] (2) 표현 : 5, 6학년의 '표현' 영역에서는 아이디어를 주제로 발전시킬 수 있는 발상 능력과 다양한 방법으로 작품을 시각화할 수 있는 능력, 자신의 작품에 대해 설명할 수 있는 능력을 기른다. 이를 위해 작품 발상 과정에서 A와 B, C을 탐색하고, 표현 의도에 적합한 D, 다양한 표현 재료와 용구, E 등을 활용하여 작품을 F하며, 작품의 전체 과정에 대해 G하는 데 중점을 둔다.",
                Answer = "소재, 주제, 발상 방법, 조형 원리, 표현 방법, 제작, 설명",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "[6미02-01] 표현 A를 잘 나타낼 수 있는 다양한 B를 탐색할 수 있다.",
                Answer = "주제, 소재",
                Reference = "내용 요소 - 소재와 주제",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "[6미02-02] 다양한 A으로 아이디어를 B시킬 수 있다.",
                Answer = "발상 방법, 발전",
                Reference = "내용 요소 - 발상 방법, 기능 - 발전시키기",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "[6미02-03] 다양한 A를 활용하여 아이디어와 관련된 B 내용을 구체화할 수 있다.",
                Answer = "자료, 표현",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "[6미02-04] A(B, C, D, E, F, G, H, I, J, K, L, M 등)의 특징을 탐색하고, 표현 의도에 적합하게 활용할 수 있다.",
                Answer = "조형 원리, 비례, 율동, 강조, 반복, 통일, 균형, 대비, 대칭, 점증·점이, 조화, 변화, 동세",
                Reference = "내용 요소 - 조형 원리"
            },

            new QuestSet
            {
                Quest = "[6미02-05] 다양한 A의 특징과 과정을 탐색하여 활용할 수 있다.",
                Answer = "표현 방법",
                Reference = "내용 요소 - 표현 방법"
            },

            new QuestSet
            {
                Quest = "[6미02-06] 작품 A의 전체 과정에서 느낀 점, 알게 된 점 등을 서로 이야기할 수 있다.",
                Answer = "제작",
                Reference = "내용 요소 - 제작 발표"
            },

            new QuestSet
            {
                Quest = "5~6학년 '표현' 영역 교학방유 : 주변 관찰, 자료 수집, 마인드맵, 참고 작품 감상 등을 통하여 A를 탐색하고, B로 발전시키도록 지도한다.",
                Answer = "소재, 표현 주제",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "5~6학년 '표현' 영역 교학방유 : A, B, C 등 다양한 발상 방법을 활용하도록 지도한다.",
                Answer = "결합, 분해, 강조",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "5~6학년 '표현' 영역 교학방유 : 조형 A는 체험, 감상 활동과 B하여 자연스럽게 이해하고, 3, 4학년에서 학습한 C와 B하여 활용하도록 지도한다.",
                Answer = "원리, 연계, 조형 요소",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "[초등5~6] (3) 감상 : 5, 6학년의 '감상' 영역에서는 우리나라 미술의 특징을 A과 관련지어 이해하고, 작품을 감상할 수 있는 기초 능력을 기른다. 이를 위해 우리나라 전통 미술의 특징을 현대 미술과 비교하면서 미술 작품이 A과 관련된다는 것을 이해하고, B을 다양한 방법으로 감상하는 데 중점을 둔다.",
                Answer = "시대적 배경, 작품의 내용과 형식",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "[6미03-01] 우리나라 전통 미술의 특징을 현대 미술과 A할 수 있다.",
                Answer = "비교",
                Reference = "기능 - 비교하기"
            },

            new QuestSet
            {
                Quest = "[6미03-02] 미술 A이 시대적 B과 C된다는 것을 D할 수 있다.",
                Answer = "작품, 배경, 관련, 이해",
                Reference = "내용 요소 - 작품과 배경, 기능 - 이해하기, 비교하기"
            },

            new QuestSet
            {
                Quest = "[6미03-03] 미술 작품의 A(소재, 주제 등)과 B(재료와 용구, 표현 방법, 조형 요소와 원리 등)을 미술 용어를 활용하여 C할 수 있다.",
                Answer = "내용, 형식, 설명",
                Reference = "내용 요소 - 작품의 내용과 형식, 기능 - 설명하기"
            },

            new QuestSet
            {
                Quest = "[6미03-04] 다양한 A 방법(비교 또는 단독 A, 내용 또는 형식 A 등)을 알고 활용할 수 있다. ",
                Answer = "감상",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "교수·학습 및 평가의 방향 : 가 - 1. 미술 교과 역량인 A, B, C, D, E을 반영하여 교수·학습을 계획한다.",
                Answer = "미적 감수성, 시각적 소통 능력, 창의·융합 능력, 미술 문화 이해 능력, 자기 주도적 미술 학습 능력",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "교수·학습 및 평가의 방향 : 가 - 2. A 중심의 활동이 이루어질 수 있도록 생활 또는 타 B나 타 C 등과 D·E하여 교수·학습을 계획하고 실행한다.",
                Answer = "학습자 체험, 교과, 분야, 연계, 융합",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "교수·학습 및 평가의 방향 : 가 - 7 - 가. 미적 감수성을 기르기 위해 실제적 경험을 통해 학습자의 감각을 자극하거나 반응을 이끌어낼 수 있는 관찰 학습, 조사 학습, 체험 학습, A 등을 활용할 수 있다.",
                Answer = "반응 중심 학습법",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "교수·학습 및 평가의 방향 : 가 - 7 - 나. 시각적 소통 능력을 기르기 위해 삶 속에서 시각 이미지의 다양한 의미를 탐색하고 적용하며 공유할 수 있는 체험 학습, 탐구 학습, 조사 학습, 토의·토론 학습, A 등을 활용할 수 있다.",
                Answer = "프로젝트 학습",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "교수·학습 및 평가의 방향 : 가 - 7 - 다. 창의·융합 능력을 기르기 위해 미술과 다양한 분야를 연계하여 사고를 확장시키고 상상력을 자극할 수 있는 탐구 학습, 주제 학습, 프로젝트 학습, A 등을 활용할 수 있다.",
                Answer = "창의적 문제 해결법",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "교수·학습 및 평가의 방향 : 가 - 7 - 라. 미술 문화 이해 능력을 기르기 위해 유연하고 개방적인 태도로 다양한 미술 문화의 가치를 존중할 수 있는 비교 감상 학습, 토의·토론 학습, A, B, 극화, 현장 견학 등을 활용할 수 있다.",
                Answer = "귀납적 사고법, 반응 중심 학습법",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "교수·학습 및 평가의 방향 : 가 - 7 - 마. 자기 주도적 미술 학습 능력을 기르기 위해 자신의 학습 과정을 성찰하고 계발, 발전시킬 수 있는 A 학습, B 학습, C 학습 등을 활용할 수 있다.",
                Answer = "프로젝트, 협력, 탐구",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "교수·학습 및 평가의 방향 : 가 - 8. 학습자의 호기심과 동기를 유발하고 유지할 수 있는 A과 B을 적극 활용한다.",
                Answer = "발문, 개방적 질문",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "교수·학습 및 평가의 방향 : 가 - 9. 정보 통신 기술(ICT)과 사진, 영상, 멀티미디어 등 A를 활용하여 학습의 효과를 높인다.",
                Answer = "다양한 매체",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "교수·학습 및 평가의 방향 : 가 - 10. 박물관, 미술관, 전시장 등을 한 학기에 A회 이상 관람하도록 한다.",
                Answer = "1",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "교수·학습 및 평가의 방향 : 가 - 11. 미술에 대한 관심과 이해를 높이기 위하여 지역의 A와 B, C 등을 적극적으로 활용한다.",
                Answer = "미술 자료, 문화 공간, 시설",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "교수·학습 및 평가의 방향 : 가 - 12. 체험, 표현, 감상 영역의 학습 활동에 적합한 A 및 B를 구비하여 활용한다.",
                Answer = "시설, 재료와 용구",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "교수·학습 및 평가의 방향 : 나 - 1. 미술 교과 역량에 기반한 A, B의 C를 계획하고 실행한다.",
                Answer = "과정 중심, 수행 중심, 평가",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "교수·학습 및 평가의 방향 : 나 - 2. 평가 목표와 내용은 A, 교육과정의 B와 C을 근거로 설정하되 학습자의 성취 수준을 고려한다.",
                Answer = "미술 교과 역량, 내용 체계, 성취기준",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "교수·학습 및 평가의 방향 : 나 - 4. 학습자의 A, 학습 B, 학습 C가 고루 평가되며, D적, E적, F적 요소가 균형 있게 평가되도록 계획하고 실행한다.",
                Answer = "태도, 과정, 결과, 인지, 심동, 정의",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "교수·학습 및 평가의 방향 : 나 - 5. 평가 기준을 학습자에게 미리 제시하여 평가의 A과 B을 높인다.",
                Answer = "객관성, 신뢰성",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "교수·학습 및 평가의 방향 : 나 - 6. 평가 목표, 평가 내용, 평가 상황 등을 고려하여 A형 및 B형 검사법, C, D, E, F, G, H 등의 평가 방법을 적절하게 활용한다.",
                Answer = "서술, 논술, 관찰법, 발표 및 토론법, 자기 평가 및 동료 평가 보고서법, 연구보고서법, 감상문, 포트폴리오법",
                Reference = ""
            },

            new QuestSet
            {
                Quest = "교수·학습 및 평가의 방향 : 나 - 7. A 평가와 B 평가를 적절하게 활용하되, 모둠 평가 시 개인의 역할과 비중을 고려하여 평가 기준과 방법 등을 선정한다.",
                Answer = "개별, 모둠",
                Reference = ""
            },

            /*new QuestSet
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
            }*/


        };


        public static List<QuestSet> art_edu = new List<QuestSet>
        {
            new QuestSet
            {
                Quest = "로웬펠드가 주장한 표현 능력 발달 단계는 'A' 표현과 'B' 표현으로 구분하여 특징지을 수 있다.",
                Answer = "평면, 입체",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "로웬펠드가 주장한 평면 표현 능력 발달 단계는 A - B - C - D - E - F 순서이다.",
                Answer = "난화기, 전도식기, 도식기, 또래집단기, 의사실기, 결정기",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "로웬펠드가 주장한 입체 표현 능력 발달 단계는 A - B - C - D - E - F 순서이다.",
                Answer = "난화기, 전도식기, 도식기, 또래집단기, 의사실기, 결정기",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "로웬펠드의 평면 표현 능력 발달 단계에서 난화기는 A한 난화기 → B하는 난화기 → C하는 난화기 순으로 발달한다.",
                Answer = "무질서, 조절, 명명",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "로웬펠드의 평면 표현 능력 발달 단계에서 A에서는 점차 의식적인 표현 과정에 들어서며, 알고 있는 대상을 표현하기 시작한다. 또한 자기중심적 표현이 주가 되며, 객관적 사실성은 미흡하다.",
                Answer = "전도식기",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "로웬펠드의 평면 표현 능력 발달 단계 중 A에서는 도식적 표현이 나타난다. 즉, 아이들이 반복해서 나타내는 대상의 상징적인 표현이 나타난다. 또한 시공간의 동시 표현, B, C적 표현이 나타나며, 대상에 따른 일정한 색이 결정된다.",
                Answer = "도식기, 기저선, 투영",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "로웬펠드의 평면 표현 능력 발달 단계 중 A에서는 또래집단의 의사를 존중하며, 주위 환경에 관심을 갖는 경향이 나타난다. 도식적 표현과 사실적 표현이 공존하며(과도기), 이때 교사는 오감을 활용한 관찰로서 지도할 수 있다. 초등학교 3~4학년에 주로 나타나는 단계이다.",
                Answer = "또래 집단기",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "로웬펠드의 평면 표현 능력 발달 단계 중 A에서는 대상을 사실적으로 표현하려 노력하는 경향이 나타나며, 시각형과 비시각형(촉각형)의 경향이 나타난다. ",
                Answer = "의사실기",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "로웬펠드의 평면 표현 능력 발달 단계 중 A에서는 창조적으로 그림을 그릴 수 있으며, 촉각형, 중각형, 시각형 등이 나타난다.",
                Answer = "결정기",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "로웬펠드의 입체 표현 능력 발달 단계 중 A에서는 찰흙의 특성을 촉각적 경험을 통해 탐색한다.",
                Answer = "난화기",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "로웬펠드의 입체 표현 능력 발달 단계 중 A에서는 의식적(의도적) 표현을 위해 돌출, 접합할 수 있다.",
                Answer = "전도식기",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "로웬펠드의 입체 표현 능력 발달 단계 중 A는 입체 표현 지도가 적합한 단계이며, B와 C 2가지 방법으로 입체를 표현할 수 있다.",
                Answer = "도식기, 분석적 방법, 종합적 방법",
                Reference = "분석적 방법(시각형) : 하나의 덩어리로 대상을 만드는 방법 - 전체 → 부분, 종합적 방법 (촉각형) : 부분을 접합해서 대상을 만드는 방법 - 부분 → 전체"
            },

            new QuestSet
            {
                Quest = "로웬펠드의 입체 표현 능력 발달 단계 중 A에서는 다양한 표현 재료를 쓸 수 있고, 질감 표현이 보다 사실적이 된다.",
                Answer = "또래집단기",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "로웬펠드의 입체 표현 능력 발달 단계 중 A에서는 소조와 조소를 활용할 수 있다.",
                Answer = "의사실기",
               
            },

            new QuestSet
            {
                Quest = "A는 뼈대에 살을 붙여 가면서 형태를 나타내는 것이다.",
                Answer = "소조",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "A는 커다란 덩어리로부터 떼어내면서 형태를 표현하는 것이다.",
                Answer = "조소",
                FullSentence = ""
            },

            new QuestSet
            {
                Quest = "로웬펠드의 입체 표현 능력 발달 단계 중 A에서는 비례와 움직임을 정확히 표현할 수 있고, 개인의 감정 역시도 표현할 수 있다.",
                Answer = "결정기",
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
            }


        };

        public static List<QuestSet> art_Part = new List<QuestSet>
        {
          /*new QuestSet("무보수로 일하며, 박물관이나 미술관 등에서 관람객들에게 전시물을 설명하는 안내인의 호칭을 무엇이라 하는가?","도슨트"),
          new QuestSet("박물관 및 미술관에서 재정의 확보, 유물의 보존 관리, 자료의 전시, 홍보 활동을 하는 사람을 무엇이라 하는가?","큐레이터"),
          new QuestSet("구체적인 형상을 만드는 미술의 기본 단위를 무엇이라 하는가?","조형 요소"),
          new QuestSet("선, 형, 색 등의 조형 요소가 작품에서 어우러지고 구성되어 나타나는 원리를 무엇이라 하는가?","조형 원리")
          */

        
        };
    }
}
