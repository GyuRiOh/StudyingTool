﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 초등임용복습프로그램
{
    class PracticalCourseQL
    {
        public static List<QuestSet> pract_CU = new List<QuestSet>
        {
            new QuestSet
            {
                Quest = "실과는 A 교과의 성격을 가진 보통 교과이다.",
                Answer = "실천"
            },
            
            new QuestSet
            {
                Quest = "실과(기술·가정) 교과는 'A', 'B'로 교육 분야를 구분하여 개인과 가족이 전 생애에서 직면하게 될 생활의 경험과 문제를 실제적이고 통합적인 내용으로 구성하고, C을 비롯한 다양한 실천적 경험을 바탕으로 학습자들이 문제해결능력을 길러 일과 직업에 대한 건전한 가치관을 형성하여 진로 탐색을 할 수 있는 D를 길러주는 데 중점을 둔다.",
                Answer = "가정생활, 기술의 세계, 노작활동, 역량"
            },

            new QuestSet
            {
                Quest = "초등학교 '실과'는 실천적이고 창의적인 A을 통하여 일상생활에 필요한 지식, B, 가치 판단력 등을 함양하여 스스로 생활을 개선할 수 있도록 한다.",
                Answer = "노작활동, 기초생활능력"
            },

            new QuestSet
            {
                Quest = "'A' 분야에서는 청소년기의 발달 단계에 있는 학습자들이 현재와 미래의 삶에서 개인과 가족의 신체적, 정서적, 사회적 건강과 안녕을 유지하며 가정생활의 행복감을 향상시킬 수 있도록 자신과 가족, 지역사회, 자원, 환경과의 건강한 상호작용을 통해 관계를 형성하고, 자립적인 생활능력과 B를 길러주는 데 중점을 둔다.",
                Answer = "가정생활, 실천적문제해결능력"
            },

            new QuestSet
            {
                Quest = "이러한 실천적 경험 속에서 'A, B, C'의 교과 역량이 함양될 수 있도록 하여 자신과 가족의 행복한 삶, 안전하고 건강한 삶, 균형 있고 조화로운 삶을 이뤄나가는 데 기여하도록 한다.",
                Answer = "실천적문제해결능력, 생활자립능력, 관계형성능력"
            },

            new QuestSet
            {
                Quest = "'A'은 일상생활 속에서 발생될 수 있는 다양한 문제에 대하여 그 배경을 이해하고 문제 해결의 대안을 탐색한 후, 비판적 사고를 통한 추론과 가치 판단에 따른 의사 결정으로 실행할 수 있는 능력이다.",
                Answer = "실천적문제해결능력"
            },

            new QuestSet
            {
                Quest = "'A'은 삶의 주체로서 자신의 발달 과정에서 자아정체감을 형성하여 일상생활의 문제를 스스로 판단·수행할 수 있으며, 주도적인 관점에서 자기 관리 및 생애를 설계할 수 있는 능력이다.",
                Answer = "생활자립능력"
            },

            new QuestSet
            {
                Quest = "'A'은 대상과의 관계를 소중히 여기고, 존중과 공감, 배려와 돌봄을 통해 공동체 감수성을 함양하여 자신과 가족, 친구, 지역사회, 자원, 환경의 건강한 상호작용과 관계를 형성·유지할 수 있는 능력이다.",
                Answer = "관계형성능력"
            },

            new QuestSet
            {
                Quest = "'A'분야는 인간의 조작적 욕구에 부합하는 활동으로 자연으로부터 얻은 자원을 활용하여 생존과 적응에 필요한 산출물을 만드는 창의적 능력을 높이는 역할을 수행하고 있다.",
                Answer = "기술의 세계"
            },

            new QuestSet
            {
                Quest = "'기술의 세계' 분야의 교육은 'A' 영역의 생산·수송·통신 기술과 'B' 영역인 발명, 표준, 지속가능 발전에 대한 경험과 실천을 통해 이루어진다.",
                Answer = "기술 시스템, 기술 활용"
            },

            new QuestSet
            {
                Quest = "따라서 '기술의 세계' 분야는 '기술 시스템', '기술 활용' 영역을 중심으로 A, B, C, D, E, F을 핵심 개념으로 설정하여 교육내용을 구성·제공함으로써 G, H, I를 기를 수 있다. ",
                Answer = "창조, 효율, 소통, 적응, 혁신, 지속가능, 기술적문제해결능력, 기술시스템설계능력, 기술활용능력"
            },

            new QuestSet
            {
                Quest = "'A'은 기술과 관련된 문제를 이해하고 다양한 해결책을 탐색하여 창의적인 아이디어를 구현한 해결책을 평가하고 개선할 수 있는 능력이다.",
                Answer = "기술적문제해결능력"
            },

            new QuestSet
            {
                Quest = "'A'은 다양한 자원을 활용하여 B·C·D 기술의 투입, 과정, 산출, 되먹임의 흐름이 효율적으로 이루어지도록 필요한 기술을 개발하거나 설계하는 능력이다.",
                Answer = "기술시스템설계능력, 생산, 수송, 통신"
            },

            new QuestSet
            {
                Quest = "'A'은 생산·수송·통신 기술의 개발, 혁신, 적용, 융합을 통해 지속가능한 발전을 위한 발명과 표준화가 효율적으로 이루어지도록 촉진하는 능력이다.",
                Answer = "기술활용능력"
            },

            new QuestSet
            {
                Quest = "<총괄 목표> 실과(기술·가정)에서는 A에 대한 지식, 능력, 가치 판단력을 함양하여 B을 통해 자립적인 삶을 영위하고, 기술에 대한 실천적 학습 경험을 통해 기술의 지식, 기능, 태도를 함양하여 기술적 능력을 높여, 현재와 미래의 행복하고 건강한 가정생활과 창조적인 C를 주도적으로 영위할 수 있도록 한다.",
                Answer = "가정생활, 실천적 문제 해결, 기술의 세계"
            },

            new QuestSet
            {
                Quest = "<세부 목표> 가. 자신의 발달과 가족 관계에 대한 이해를 바탕으로 긍정적 자아정체감을 형성하고 배려와 돌봄을 실천함으로써 행복한 삶을 위한 A과 B을 기른다.",
                Answer = "관계형성능력, 실천적문제해결능력"
            },

            new QuestSet
            {
                Quest = "<세부 목표> 나. 가정생활과 관련된 실천적 문제를 이해하고, 노작활동과 체험, 비판적 사고와 반성적 행동을 통해 개인과 가족의 안전하고 건강한 삶을 위한 A과 B을 기른다.",
                Answer = "실천적문제해결능력, 생활자립능력"
            },

            new QuestSet
            {
                Quest = "<세부 목표> 다. 공동체와 환경을 고려한 생활 자원의 관리와 미래를 준비하는 생애 설계를 통해 자신의 균형있고 조화로운 삶을 위한 A과 B을 기른다.",
                Answer = "관계형성능력, 생활자립능력"
            },

            new QuestSet
            {
                Quest = "<세부 목표> 라. 기술에 대한 이해를 기초로 기술적 문제를 창의적으로 해결하고 일상생활에 적용할 수 있는 A과 B을 기른다.",
                Answer = "기술적문제해결능력, 기술활용능력"
            },

            new QuestSet
            {
                Quest = "<세부 목표> 마. 기술의 발달과 사회의 변화에 적극적으로 대처하고 적응할 수 있는 A과 B을 기른다.",
                Answer = "기술활용능력, 기술시스템설계능력"
            },

            new QuestSet
            {
                Quest = "<세부 목표> 바. 다양한 자원을 활용하여 기술적 문제를 이해하고 해결 방안을 탐색하고 개발할 수 있는 A과 B을 기른다.",
                Answer = "기술시스템설계능력, 기술적문제해결능력"
            },

            new QuestSet
            {
                Quest = "(1) A 영역 : 자신의 발달과 삶을 이해하는 기본적 조건으로써 가족의 관계와 가정생활의 중요성을 인식하여 가족 구성원 간 B와 C을 실천할 수 있다.",
                Answer = "인간 발달과 가족, 배려, 돌봄"
            },

            new QuestSet
            {
                Quest = "[6실01-01] A의 신체적, 인지적, 정서적, 사회적 B 및 발달의 개인차를 알아 자신을 이해하고, 건강하게 발달하기 위해 필요한 조건을 설명한다.",
                Answer = "아동기, 발달의 특징"
            },

            new QuestSet
            {
                Quest = "[6실01-02] A에 나타나는 남녀의 성적 발달 변화를 긍정적으로 이해하고, B과 관련한 C을 D하여 E한다.",
                Answer = "아동기, 성적 발달, 자기 관리 방법, 탐색, 실천"
            },

            new QuestSet
            {
                Quest = "[6실01-03] 주변 가족의 모습을 통해 A 및 역할을 이해하고, B한 가족의 가정생활 C을 파악하여 가정생활의 중요성을 설명한다.",
                Answer = "나와 가족의 관계, 다양, 공통점"
            },

            new QuestSet
            {
                Quest = "[6실01-04] 건강한 가정생활을 위해 A 구성원의 다양한 B에 대하여 서로 간의 C와 D이 필요함을 이해한다.",
                Answer = "가족, 요구, 배려, 돌봄"
            },

            new QuestSet
            {
                Quest = "인간 발달과 가족 성취기준 해설 : [6실01-02] 성적 성숙으로 나타나는 남녀의 생리적 변화를 건강한 성인이 되어가는 자연스러운 과정으로 이해하고 이러한 변화 (초경, 몽정 등)와 관련한 올바른 A을 알고 실천하도록 한다.",
                Answer = "자기 관리 방법"
            },

            new QuestSet
            {
                Quest = "인간 발달과 가족 성취기준 해설 : [6실01-03] A를 이해하고 가족 구성원들의 역할은 가족 상황에 따라 다를 수 있으며, 가족 구성의 모습은 달라도 의식주 생활을 영위하고 있는 B의 모습은 공통성이 있다는 것을 이해하도록 한다.",
                Answer = "나와 가족의 관계, 가정생활"
            },

            new QuestSet
            {
                Quest = "인간 발달과 가족 교학방유 : 아동의 A에는 신체적 측면 외에도 B, C, D 측면에 있음을 알게 하고, 다른 친구들의 A을 E하도록 지도한다.",
                Answer = "발달, 인지적, 정서적, 사회적, 존중"
            },

            new QuestSet
            {
                Quest = "인간 발달과 가족 교학방유 : 성적 발달과 관련하여 생활 속에서 실천할 수 있는 A에 대해 스스로 B하고, C 목록을 세워보도록 한다. 또한 건강한 발달을 위해 필요한 조건을 탐색하여 실생활에 적용하도록 한다.",
                Answer = "자기 관리 방법, 탐색, 실천"
            },

            new QuestSet
            {
                Quest = "인간 발달과 가족 교학방유 : 역할 놀이, 광고, 뉴스, 노래, UCC, 프리젠테이션 등을 제작, 발표해 보도록 하여 A을 긍정적으로 이해하고 건강한 B의 중요성을 알게 한다.",
                Answer = "자신의 발달 특징, 가정생활"
            },
            
            new QuestSet
            {
                Quest = "인간 발달과 가족 평방유 : '인간 발달과 가족' 영역에서는 실제적인 A와 B을 중심으로 C을 작성한 후 평가할 수 있다.",
                Answer = "사례, 경험, 보고서"
            },

            new QuestSet
            {
                Quest = "인간 발달과 가족 평방유 : '성적 발달과 관련된 A'에서는 B, C, 등과 같은 D를 활용한 평가를 실시할 수 있다.",
                Answer = "자기 관리, 실천 점검표, 자기 평가지, 체크리스트"
            },

            new QuestSet
            {
                Quest = "(2) A 영역 : 가정생활을 중심으로 한 기본 B을 습득하여 가정 생활 문화를 이해하고, 생활 속 안전 문제를 인식하여 안전한 일상 생활을 영위할 수 있다.",
                Answer = "가정생활과 안전, 생활 수행 능력"
            },

            new QuestSet
            {
                Quest = "[6실02-01] 건강을 위한 A의 중요성과 조건을 알고 자신의 식사를 B한다.",
                Answer = "균형 잡힌 식사, 평가"
            },

            new QuestSet
            {
                Quest = "[6실02-02] 성장기에 필요한 간식의 중요성을 이해하고 간식을 선택하거나 만들어 먹을 수 있으며 이때 식생활 예절을 A한다.",
                Answer = "적용"
            },

            new QuestSet
            {
                Quest = "[6실02-03] A을 이해하여 때와 장소, B에 맞는 C을 D한다.",
                Answer = "옷의 기능, 상황, 옷차림, 적용",
                Reference = "내용 요소 : 옷 입기와 의생활 예절"
            },

            new QuestSet
            {
                Quest = "[6실02-04] 다양한 A을 비교·분석하여 올바른 식습관 형성에 B한다.",
                Answer = "식재료의 맛, 적용",
                Reference = "오감교육 지도"
            },

            new QuestSet
            {
                Quest = "[6실02-05] 바느질의 기초를 익혀 간단한 A에 B한다.",
                Answer = "수선, 활용"
            },

            new QuestSet
            {
                Quest = "[6실02-06] 간단한 생활 A을 창의적으로 B하여 C한다.",
                Answer = "소품, 제작, 활용"
            },

            new QuestSet
            {
                Quest = "[6실02-07] 자신의 A을 고려하여 건강하고 B한 C을 D한다.",
                Answer = "신체발달, 안전, 옷차림, 실천"
            },

            new QuestSet
            {
                Quest = "[6실02-08] 생활 A의 종류와 B 방법을 알아 실생활에 C한다.",
                Answer = "안전사고, 예방, 적용",
                Reference = "'안전' 관련 성취기준"
            },

            new QuestSet
            {
                Quest = "[6실02-09] A과 위생을 고려하여 식사를 선택하는 방법을 B하고 실생활에 C한다.",
                Answer = "안전, 탐색, 적용"
            },

            new QuestSet
            {
                Quest = "[6실02-10] 밥을 이용한 한 그릇 음식을 위생적이고 A하게 준비, B하여 C한다.",
                Answer = "안전, 조리, 평가"
            },

            new QuestSet
            {
                Quest = "조리 실습 시 교수학습 및 평가 중점은 A와 B이다.",
                Answer = "협력, 책임감"
            },

            new QuestSet
            {
                Quest = "가정생활과 안전 영역 성취기준 해설 : [6실02-04] 식재료나 이를 활용하여 만들어진 다양한 음식의 맛을 느끼고 즐기는 과정을 통하여 A이 이루어질 수 있도록 하고, 이를 편식의 교정 등 올바른 식습관 형성에 적용하도록 지도한다. 특히 지역 및 B 식품을 사용하여 C의 의미를 알게 한다.",
                Answer = "오감 교육, 제철, 친환경적인 식생활"
            },

            new QuestSet
            {
                Quest = "가정생활과 안전 영역 성취기준 해설 : [6실02-05] 의복이나 소품 등이 A이나 B로 만들어진 것임을 알고, 의복의 구성과 제작의 기본 원리를 이해하도록 한다. 기초 바느질을 익혀 간단한 수선을 통해 의생활과 관련된 문제를 스스로 해결할 수 있는 능력을 키워주도록 한다.",
                Answer = "직물, 편물"
            },
            new QuestSet
            {
                Quest = "가정생활과 안전 영역 성취기준 해설 : [6실02-06] 다양한 바느질 도구를 활용하여 간단한 생활 소품을 만들어 노작의 즐거움과 의미를 알게 한다. 이러한 활동을 통해 손 조작 능력, 창의성 등 다양한 능력을 향상할 수 있도록 하고, A을 실천하도록 한다.",
                Answer = "환경과 나눔"
            },

            new QuestSet
            {
                Quest = "가정생활과 안전 영역 성취기준 해설 : [6실02-08] A생활, B 활동, C 활동, D·E 등에서 발생할 수 있는 F의 종류와 예방 방법을 탐색하도록 한다. 특히 휴대폰이나 이어폰 사용으로 발생할 수 있는 생활 안전사고와 이를 예방하는 방법을 강조한다. 또한 학용품이나 소지품 등의 안전한 사용법을 살펴보고 이를 생활화하도록 한다.",
                Answer = "가정, 교내외, 체험, 실험, 실습, 생활 안전사고"
            },

            new QuestSet
            {
                Quest = "가정생활과 안전 영역 성취기준 해설 : [6실02-10] 밥을 이용한 한 그릇 음식을 만들어 식사를 스스로 해결할 수 있도록 하여 자립적인 A을 길러 주도록 한다. 이때, 음식을 만드는 과정에서 균형 잡힌 식사의 조건, 위생 및 안전을 고려하도록 한다.",
                Answer = "생활 수행 능력"
            },

            new QuestSet
            {
                Quest = "가정생활과 안전 영역 교학방유 : 간식을 만드는 모둠 활동을 통해 A과 각자의 역할에 대한 B을 키울 수 있도록 하고 조리 시 안전하게 실습하도록 지도한다. 음식을 완성한 후에는 식사 예절을 지키면서 함께 음식을 나누어 먹고 모둠 활동에 대해 서로 평가한다.",
                Answer = "협력, 책임감"
            },

            new QuestSet
            {
                Quest = "가정생활과 안전 영역 교학방유 : 식재료나 음식의 맛을 경험하는 과정에서 모양과 색깔, 냄새, 촉감 등을 살펴보고 맛을 비교·분석할 수 있도록 하며, A, B 등의 다양한 C 기법을 적용하여 정리하고 D을 통한 E 역량을 신장시킬 수 있도록 지도한다.",
                Answer = "마인드맵, 브레인스토밍, 창의성, 오감, 감성"
            },

            new QuestSet
            {
                Quest = "가정생활과 안전 영역 교학방유 : A과 관련된 수업에서는 실제적인 B와 C을 중심으로 안전생활에 대한 D를 형성하도록 지도한다.",
                Answer = "생활 안전, 사례, 경험, 실천 동기"
            },

            new QuestSet
            {
                Quest = "가정생활과 안전 영역 교학방유 : 여러 가지 생활용품과 도구 등을 안전하게 사용하는 방법에 대한 사례를 A하여 이를 B에 적용할 수 있도록 지도한다.",
                Answer = "조사, 실제 상황"
            },

            new QuestSet
            {
                Quest = "가정생활과 안전 영역 교학방유 : 한 그릇 음식을 만들어 보는 수업에서는 균형 잡힌 식사의 조건을 고려하여 A, B, C, D, E, F의 전 과정이 위생적이고 안전하게 이루어질 수 있도록 지도한다.",
                Answer = "조리 계획, 준비, 조리, 상차림, 식사, 뒷정리"
            },

            new QuestSet
            {
                Quest = "가정생활과 안전 영역 교학방유 : 특히 조리 실습 시 A, B 등의 C에 대해 지도한다.",
                Answer = "화상 예방, 조리 도구 및 소화기 사용법, 안전 수칙"
            },

            new QuestSet
            {
                Quest = "가정생활과 안전 평방유 : 균형 잡힌 식사에 대한 평가에서는 올바른 A을 실천하고 있는지, 편식을 교정하려고 노력하는지 등과 같은 B가 이루어질 수 있도록 한다.",
                Answer = "식습관, 과정 중심의 평가"
            },

            new QuestSet
            {
                Quest = "가정생활과 안전 영역 평방유 : 간단한 A에서는 B, C, D, E의 전 과정을 평가한다. 특히 최종 결과물만 평가하기보다는 F, G 및 H 결과물을 비교하여 학생의 성장 정도를 평가하도록 한다. ",
                Answer = "생활 소품 만들기, 소품 만들기 계획, 준비, 제작, 뒷정리, 처음, 중간, 최종"
            },

            new QuestSet
            {
                Quest = "가정생활과 안전 영역 평방유 : 한 그릇 음식을 만드는 모둠 활동에서는 A과 맡은 역할을 B있게 수행하였는지를 평가에 반영하도록 한다.",
                Answer = "협력, 책임감"
            },

            new QuestSet
            {
                Quest = "(3) A 영역 : 옷, 용돈, 시간 등의 B을 합리적으로 소비·관리하고, 쾌적한 생활공간 환경을 유지할 수 있는 능력을 길러 C적인 생활을 영위할 수 있다.",
                Answer = "자원 관리와 자립, 생활 자원, 자립",
                Reference = "관련 교과 역량 : 생활 자립 능력"
            },

            new QuestSet
            {
                Quest = "[6실03-01] A의 종류와 용도에 맞게 B·C하는 방법을 알고 D과 관련지어 A 관리의 중요성을 이해한다.",
                Answer = "옷, 정리, 보관, 환경",
                Reference = "관련 핵심 개념 : 관리"
            },

            new QuestSet
            {
                Quest = "[6실03-02] A 자원의 B을 알고, 올바른 A 관리 방법을 C한 후 실생활에 D한다.",
                Answer = "시간, 특성, 탐색, 적용",
                Reference = "시간은 하루 24시간으로 한정되어 있고, 되돌릴 수 없으며, 저축하거나 빌릴 수 없는 소중한 자원이다."
            },

            new QuestSet
            {
                Quest = "[6실03-03] A의 필요성을 알고 자신의 필요와 욕구를 고려한 합리적인 소비생활 방법을 B하여 실생활에 C한다.",
                Answer = "용돈 관리, 탐색, 적용"
            },

            new QuestSet
            {
                Quest = "[6실03-04] 쾌적한 생활공간 관리의 A을 B과 관련지어 이해하고, 올바른 관리 방법을 C하여 D한다.",
                Answer = "필요성, 환경, 계획, 실천"
            },

            new QuestSet
            {
                Quest = "[6실03-05] A을 담당하고 있는 가족원들의 역할을 B하고, C에 미치는 영향을 이해한다.",
                Answer = "가정일, 탐색, 가정생활"
            },

            new QuestSet
            {
                Quest = "[6실03-06] 자신의 위치에서 할 수 있는 A을 찾아 B하고 C한다.",
                Answer = "가정일, 계획, 실천"
            },

            new QuestSet
            {
                Quest = "자원 관리와 자립 성취기준 해설 : [6실03-01] 입었던 옷의 세탁 여부에 대한 결정, 옷 개어 두기, 옷의 종류와 용도에 맞는 정리·보관은 A과 B을 위해 필요할 뿐만 아니라 C와 D과 관련되어 있음을 알게 하고 스스로 E을 F할 수 있는 능력의 중요성을 강조한다.",
                Answer = "위생, 안전한 생활, 자원 절약, 환경, 옷, 관리"
            },

            new QuestSet
            {
                Quest = "자원 관리와 자립 성취기준 해설 : [6실03-03] 자신의 A 실태를 통하여 용돈 관리의 필요성을 알게 한다. 용돈은 제한된 자원임을 알아 B와 C를 구별하여 소비할 수 있는 능력을 길러 준다. 또한 생활 자원을 구매·사용·폐기할 떄도 환경과 안전을 고려하는 합리적 소비가 필요함을 강조한다.",
                Answer = "용돈 관리, 필요, 욕구"
            },

            new QuestSet
            {
                Quest = "자원 관리와 자립 성취기준 해설 : [6실03-04] A, B, C의 일련의 과정은 생활환경을 관리하는 것임을 알게 하고 이의 관리 방안을 계획하고 방법을 습득하여 실천할 수 있도록 지도한다. 이때, 생활환경 관리 및 올바른 실천이 D 문제의 해결과 관련이 있음을 강조한다.",
                Answer = "정리정돈과 청소, 쓰레기 분리수거, 재활용, 환경"
            },

            new QuestSet
            {
                Quest = "자원 관리와 자립 성취기준 해설 : [6실03-05] 다양한 가정일의 종류와 특징을 파악하고 가정일의 의미와 중요성을 알게 한다. 가정일 수행이 가정생활에 미치는 영향을 살펴 가정일에 대한 A과 B을 강조한다.",
                Answer = "가족원 모두의 역할, 책임"
            },

            new QuestSet
            {
                Quest = "자원 관리와 자립 교학방유 : 학생들이 경험할 수 있는 다양한 A의 문제를 제시하고 그 원인과 해결책을 B·C하여 옷의 종류와 용도에 맞게 스스로 정리, 보관할 수 있도록 지도한다.",
                Answer = "옷 관리, 토의, 토론"
            },

            new QuestSet
            {
                Quest = "자원 관리와 자립 교학방유 : A, B, C, D 등을 하지 않았을 때의 문제점을 조사하고 이를 해결할 수 있는 실천 가능한 방안을 탐색하여 자신의 E에 F하도록 지도한다.",
                Answer = "정리정돈, 청소, 쓰레기 분리수거, 재활용, 생활, 적용"
            },

            new QuestSet
            {
                Quest = "자원 관리와 자립 교학방유 : 모둠별로 다양한 가정일의 종류와 특정 역할 분담에 대해 조사하고 발표해 보도록 하고, 이때 A과 B을 비교하여 가정일이 가정생활에 미치는 영향을 살펴보도록 지도한다.",
                Answer = "고정된 성 역할에 따른 역할 분담, 각 가정의 상황과 조건을 고려한 유연한 역할 분담"
            },

             new QuestSet
            {
                Quest = "자원 관리와 자립 교학방유 : 어떠한 A을 할 것인지 선정하고 실행 계획을 세워 실천할 수 있도록 한다. 또한 A을 수행하는 과정에서 어떠한 일에 관심, 소질, 흥미 등이 있는지 탐색하여 B에 활용할 수 있도록 한다.",
                Answer = "가정일, 진로교육"
            },


            new QuestSet
            {
                Quest = "자원 관리와 자립 평방유 : A을 평가할 때에는 과제 결과물뿐만 아니라, B에서의 상호작용, 의사소통 역할 충실도 등을 평가에 반영하도록 한다.",
                Answer = "모둠 활동, 수행 과정"
            },

            new QuestSet
            {
                Quest = "자원 관리와 자립 교학방유 : A는 학생들의 실제 생활을 중심으로 합리적으로 소비하고 있는지를 지속적으로 점검하고 수시로 피드백하여 B 평가, C 평가 등을 실시할 수 있다.",
                Answer = "시간 및 용돈 관리, 자기, 동료"
            },

            new QuestSet
            {
                Quest = "(4) A 영역 : 기술이 B - C - D - E의 시스템을 통해 이루어지는 것을 이해하고 체험활동을 통해 F 및 G을 함양한다.",
                Answer = "기술 시스템, 투입, 과정, 산출, 되먹임, 기술적문제해결능력, 기술시스템설계능력"
            },

            new QuestSet
            {
                Quest = "[6실04-01] A와 B의 의미를 이해하고 동식물 자원의 중요성을 설명한다.",
                Answer = "가꾸기, 기르기"
            },

            new QuestSet
            {
                Quest = "[6실04-02] 생활 속 A을 활용 목적에 따라 분류하고, B 활동을 C한다.",
                Answer = "식물, 가꾸기, 실행"
            },

            new QuestSet
            {
                Quest = "[6실04-03] 생활 속 A을 활용 목적에 따라 분류하고, B 기르는 과정을 C한다.",
                Answer = "동물, 돌보고, 실행"
            },

            new QuestSet
            {
                Quest = "[6실04-04] 수송과 수송 수단의 의미를 알고, 수송 수단의 A를 설명한다.",
                Answer = "기본 요소"
            },

            new QuestSet
            {
                Quest = "[6실04-05] 다양한 재료를 활용하여 수송 수단을 구상하고, A한다.",
                Answer = "제작"
            },

            new QuestSet
            {
                Quest = "[6실04-06] A의 B와 C하게 D하는 방법을 알고 E한다.",
                Answer = "자전거, 구성 요소, 안전, 관리, 실천"
            },

            new QuestSet
            {
                Quest = "[6실04-07] A가 적용된 사례를 찾아보고 우리 생활에 미치는 영향을 B한다.",
                Answer = "소프트웨어, 이해"
            },

            new QuestSet
            {
                Quest = "[6실04-08] A 사고에 의한 B의 순서를 생각하고 C한다.",
                Answer = "절차적, 문제 해결, 적용"
            },

            new QuestSet
            {
                Quest = "[6실04-09] A를 사용하여 기초적인 프로그래밍 과정을 체험한다.",
                Answer = "프로그래밍 도구"
            },

            new QuestSet
            {
                Quest = "[6실04-10] 자료를 A하고 필요한 B를 수행한 후 결과를 C하는 단순한 프로그램을 설계한다.",
                Answer = "입력, 처리, 출력"
            },

            new QuestSet
            {
                Quest = "[6실04-11] 문제를 해결하는 프로그램을 만드는 과정에서 A, B, C 등의 구조를 이해한다.",
                Answer = "순차, 선택, 반복"
            },

            new QuestSet
            {
                Quest = "기술 시스템 성취기준 해설 : [6실04-01] 가꾸기와 기르기를 A - B - C - D의 E로 이해하고 일상생활 속에서 동식물을 자원으로 활용한 사례를 살펴보는 활동을 통해 우리 생활에서 동식물 자원의 중요성을 강조한다.",
                Answer = "투입, 과정, 산출, 되먹임, 생명 기술 시스템"
            },

            new QuestSet
            {
                Quest = "기술 시스템 성취기준 해설 : [6실04-05] 수송 수단의 제작은 다양한 재료를 활용하여 수송 수단의 기본 요소 중 A, B, C 중 최소 한 가지 이상의 요소를 충족하는 수송 수단을 제작하여 봄으로써 수송 수단의 중요성을 강조한다.",
                Answer = "구동장치, 조향장치, 제동장치"
            },

            new QuestSet
            {
                Quest = "기술 시스템 성취기준 해설 : [6실04-09] A를 활용하여 기초적인 프로그래밍 과정을 체험하고 자신만의 간단한 프로그램을 만들어 본다.",
                Answer = "블록 기반의 교육용 프로그래밍 도구"
            },

            new QuestSet
            {
                Quest = "기술 시스템 성취기준 해설 : [6실04-10] 수치 값을 A하여 덧셈이나 뺄셈의 결과를 B하거나, 복수의 문자열을 A하여 두 문자열을 서로 연결한 결과를 출력하는 프로그램을 만들어 봄으로써, 소프트웨어의 A, C, B 과정을 이해한다.",
                Answer = "입력, 출력, 처리"
            },

            new QuestSet
            {
                Quest = "기술 시스템 성취기준 해설 : [6실04-11] 'A'는 명령문을 위에서 아래로 하나씩 순차적으로 수행하는 과정이며, 'B'는 주어진 조건에 따라 명령문을 선택적으로 수행하는 과정이다. 'C'은 명령문을 특정 횟수만큼 반복하거나 주어진 조건이 만족할 때까지 반복하는 과정이다. 일상의 문제를 해결하는 프로그램을 만드는 기초 과정을 통해 위 프로그램의 3가지 구조를 이해한다.",
                Answer = "순차, 선택, 반복"
            },

            new QuestSet
            {
                Quest = "기술 시스템 교학방유 : 생명 기술 시스템으로서 가꾸기와 기르기에 대한 학습은 A를 중심으로 이루어질 수 있도록 하며, 획득한 지식을 직접 활용하고 적용해볼 수 있는 기회를 제공하도록 한다.",
                Answer = "프로젝트"
            },

            new QuestSet
            {
                Quest = "기술 시스템 교학방유 : 자전거의 A, B 장치, C 장치, D 장치, E를 통해 수송 수단이 갖추어야 할 기본 요소를 이해하도록 한다.",
                Answer = "프레임, 구동, 조향, 제동, 바퀴"
            },

            new QuestSet
            {
                Quest = "기술 시스템 교학방유 : 응용 소프트웨어의 사용법이나 프로그래밍 언어의 문법 학습을 최소화하고, 문제 해결에 필요한 프로그래밍을 통한 A 신장에 초점을 맞춘다.",
                Answer = "컴퓨팅 사고력"
            },

            new QuestSet
            {
                Quest = "기술 시스템 교학방유 : 절차적 사고를 적용할 수 있는 일상생활 속의 사례들을 찾아보고, A 중심의 B, 퍼즐 등의 다양한 활동을 통해 절차적인 문제해결과정을 이해하도록 한다.",
                Answer = "놀이, 신체 활동"
            },

            new QuestSet
            {
                Quest = "기술 시스템 교학방유 : 실생활 속에서 일어나는 A을 중심으로 학생들이 B를 활용할 수 있도록 지도한다.",
                Answer = "문제 상황, 컴퓨팅 사고"
            },

            new QuestSet
            {
                Quest = "기술 시스템 교학방유 : A 활동 시 놀이와 학습이 동시에 이루어질 수 있도록 시간과 내용을 적절히 구성하여 지도한다.",
                Answer = "언플러그드"
            },

            new QuestSet
            {
                Quest = "기술 시스템 교학방유 : A는 소프트웨어 교육에 국한되는 것이 아니므로 국어, 사회, 수학, 과학 등 다양한 교과에서도 반영하여 지도한다.",
                Answer = "컴퓨팅적인 사고"
            },

            new QuestSet
            {
                Quest = "기술 시스템 평방유 : A나 B를 활용하는 평가를 통해 식물이나 동물을 가꾸고 기르면서 경험한 일의 C, D, E, F 등의 인성 및 G 측면을 평가할 수 있다.",
                Answer = "재배 일지, 사육 일지, 소중함, 책임감, 생명존중, 배려, 정의적"
            },

            new QuestSet
            {
                Quest = "기술 시스템 평방유 : A 만들기에서는 A의 기본 요소 충족, 다양한 재료 활용, 창의적 아이디어 적용 여부 등의 평가 요소를 중점으로 B를 사전에 제시하여 학생들이 활동 수행 시 참고할 수 있도록 하며, 시연 과정에서 C 평가나 D 평가를 실시하도록 한다.",
                Answer = "수송 수단, 서술형 채점 기준표, 동료, 자기"
            },

            new QuestSet
            {
                Quest = "A의 B 관리 평가에서는 B과 관련된 자전거의 기본 요소를 파악하고 있는지에 대해 C로 평가하고, D 형식의 안전 점검표를 만들이 자전거 B 관리에 대한 E를 실시하도록 한다.",
                Answer = "수송 수단, 안전, 구술, 체크리스트, 자기 평가"
            },

            new QuestSet
            {
                Quest = "다양한 A 도구를 활용하여 소프트웨어 교육을 통한 B의 향상 정도를 측정할 수 있도록 한다.",
                Answer = "평가, 컴퓨팅 사고력"
            },

            new QuestSet
            {
                Quest = "(5) A 영역 : 생활 속에서의 A 사례를 B, C, D과 관련하여 살펴보고, 체험 활동을 통해 E 및 F을 함양한다.",
                Answer = "기술 활용, 적응, 혁신, 지속 가능, 기술적문제해결능력, 기술활용능력"
            },

            new QuestSet
            {
                Quest = "[6실05-01] A의 의미와 중요성을 이해한다.",
                Answer = "일과 직업"
            },

            new QuestSet
            {
                Quest = "[6실05-02] A하고 적성, 흥미, 성격에 맞는 B을 C한다.",
                Answer = "나를 이해, 직업, 탐색"
            },

            new QuestSet
            {
                Quest = "[6실05-03] 생활 속에 적용된 A과 B의 사례를 통해 발명의 의미와 중요성을 이해한다.",
                Answer = "발명, 문제해결"
            },

            new QuestSet
            {
                Quest = "[6실05-04] 다양한 재료를 활용하여 창의적인 제품을 구상하고 A한다.",
                Answer = "제작"
            },

            new QuestSet
            {
                Quest = "[6실05-05] 사이버 중독 예방, A 및 B의 의미를 알고 생활 속에서 C한다.",
                Answer = "개인 정보 보호, 지식 재산 보호, 실천"
            },

            new QuestSet
            {
                Quest = "[6실05-06] 생활 속에서 A 활용 사례를 통해 작동 원리와 활동 분야를 이해한다.",
                Answer = "로봇"
            },

            new QuestSet
            {
                Quest = "[6실05-07] 여러 가지 센서를 장착한 로봇을 A한다.",
                Answer = "제작"
            },

            new QuestSet
            {
                Quest = "[6실05-08] 지속 가능한 미래 사회를 위한 A의 역할과 중요성을 이해한다.",
                Answer = "친환경 농업"
            },

            new QuestSet
            {
                Quest = "[6실05-09] A을 통해 지속 가능한 생활을 이해하고 실천 방안을 B한다.",
                Answer = "생활 속의 농업 체험, 제안"
            },

            new QuestSet
            {
                Quest = "기술 활용 영역 성취기준 해설 : [6실05-03] 발명에 사용되는 더하기·빼기·용도 바꾸기·반대로 하기 등의 다양한 A을 이해하고, B 속에서 사용하는 C을 선정하여 발명 이유, D, 적용된 E 등을 탐색하여 발명의 의미와 중요성을 강조한다.",
                Answer = "발명 기법, 일상생활, 물건, 해결된 문제, 발명 사고 기법"
            },

            new QuestSet
            {
                Quest = "기술 활용 영역 성취기준 해설 : [6실05-07] A와 B를 비교하여 이해하고 센서를 장착한 로봇을 제작하여 구동시켜 봄으로써 로봇의 C를 강조한다.",
                Answer = "로봇에 사용되는 센서, 인체 구조, 작동 원리"
            },

            new QuestSet
            {
                Quest = "기술 활용 영역 교학방유 : A와 B을 지도할 때에는 생활 속에서 활용되는 용품을 사례로 하여 발명 기법의 적용과 효과를 이해할 수 있도록 하며, C, D, E, F의 G를 경험할 수 있도록 한다.",
                Answer = "발명, 문제해결, 문제 이해, 연구와 개발, 실현, 평가, 기술적 문제해결과정",
                Reference = "관련 교과 역량 : 기술적문제해결능력"
            },
            
            new QuestSet
            {
                Quest = "기술 활용 영역 교학방유 : 사이버 중독 예방, 개인 정보와 지식 재산 보호의 중요성과 보호 방법에 대해 지도할 때에는 신문 기사나 뉴스 등 실제 사례를 중심으로 탐색해 보고 A 등을 통해 실천 방안을 도출할 수 있도록 한다.",
                Answer = "토의"
            },

            new QuestSet
            {
                Quest = "기술 활용 영역 교학방유 : 소프트웨어를 활용하여 로봇을 작동시켜 A와 B을 C하여 지도하도록 한다.",
                Answer = "소프트웨어, 로봇, 연계"
            },

            new QuestSet
            {
                Quest = "기술 활용 영역 교학방유 : 포스터 및 UCC를 제작 할 때는 워드프로세서, 프레젠테이션 등의 응용 소프트웨어를 활용함으로써 A을 함양할 수 있도록 한다.",
                Answer = "기본적인 ICT 활용 소양"
            },

            new QuestSet
            {
                Quest = "기술 활용 영역 평방유 : 자신에 대한 이해, 직업 세계에 대한 탐색을 바탕으로 A를 작성하여 발표하고 평가하도록 한다.",
                Answer = "포트폴리오"
            },

            new QuestSet
            {
                Quest = "기술 활용 영역 평방유 : 창의적인 제품 만들기는 A, B, C, D, E 등을 중심으로 문제 해결 과정과 결과를 종합적으로 평가하도록 하며, 평가의 요소 및 기준은 학교의 여건에 따라 달리할 수 있다.",
                Answer = "기능성, 창의성, 실용성, 경제성, 심미성",
                Reference = "경기실심창"
            },

            new QuestSet
            {
                Quest = "기술 활용 영역 평방유 : 개인 정보 보호와 지식 재산 보호에 대한 기본적인 기준과 절차에 대해 A를 구성하여 자신의 이해 여부와 노력 정도를 평가해보도록 한다.",
                Answer = "체크리스트"
            },

            new QuestSet
            {
                Quest = "기술 활용 영역 평방유 : 생활 속에서 로봇이 활용된 예를 찾아 어떻게 작동하는지를 분석하고, 다양한 로봇의 활용 분야에 대해 조사하여 작성한 A를 대상으로 평가한다.",
                Answer = "연구 보고서"
            },

            new QuestSet
            {
                Quest = "기술 활용 영역 평방유 : 체험 활동에 대한 평가는 결과 중심의 평가를 지양하고 A와 B를 C적으로 평가할 수 있도록 한다.",
                Answer = "과정, 결과, 종합"
            },

            new QuestSet
            {
                Quest = "<교수·학습 및 평가의 방향> 가. 교수·학습 방향 - (3) 학생들의 발달 단계, 학습 수준, 관심, 흥미 등을 고려하여 A으로 전개하면서도 교과 역량을 충분히 기를 수 있도록 수업을 계획한다.",
                Answer = "학생 중심 활동"
            },

            new QuestSet
            {
                Quest = "<교수·학습 및 평가의 방향> 가. 교수·학습 방향 - (4) 학교마다 학생 특성, 학교 환경, 실험·실습실 여건, 예산, 지역 사회의 특성 등이 다양하므로 사전에 A을 파악하여 지도 계획에 충분히 반영한다.",
                Answer = "학생 및 학교의 요구와 상황"
            },

            new QuestSet
            {
                Quest = "<교수·학습 및 평가의 방향> 가. 교수·학습 방향 - (5) 학습 소재와 재료는 A 속에서 쉽게 접할 수 있는 것으로 B하여 수업에서 습득한 지식과 기능을 C에서 적극적으로 활용할 수 있도록 한다.",
                Answer = "실생활, 선택, 일상생활",
                Reference = "실생활에 활용·확장되는 교수·학습 방법"
            },

            new QuestSet
            {
                Quest = "<교수·학습 및 평가의 방향> 가. 교수·학습 방향 - (6) 실생활과 관련한 체험 활동을 중시하고, 가정 실습, 학교 및 지역 사회 행사 등을 적극 활용한다. 특히 지역의 A을 활용하고, 지역 내의 박물관, 과학관, 기업을 견학 및 탐방하는 등 다양한 B와 연계하여 학습에 도움이 되도록 지도한다.",
                Answer = "인적 자원, 교육 커뮤니티"
            },

            new QuestSet
            {
                Quest = "<교수·학습 및 평가의 방향> 가. 교수·학습 방향 - (7) 실과(기술·가정) 교수·학습 방법은 관련 내용에 따라 A, B, C, D, E, F, G 등 다양한 방법을 활용하되, 특히 활동이나 실제 사례에 초점을 두도록 한다.",
                Answer = "실천적문제해결학습, 프로젝트법, 문제 중심 수업, 실험·실습, 토의·토론법, 역할 놀이, 협동 학습"
            },

            new QuestSet
            {
                Quest = "<교수·학습 및 평가의 방향> 가. 교수·학습 방향 - (8) 실물이나 모형, 인터넷 자료, 사진 및 동영상 자료, 멀티미디어 자료 등 다양한 학습 자료를 활용하여 교수·학습의 A을 높이고 B 있는 교수·학습 활동이 이루어지도록 한다.",
                Answer = "효율성, 생동감"
            },

            new QuestSet
            {
                Quest = "<교수·학습 및 평가의 방향> 가. 교수·학습 방향 - (9) A 활동이 효과적으로 이루어지도록 최소한 가정실, 기술실 등을 반드시 확보하고, 교과의 단원 분석을 통하여 연간 A 계획을 세워 각 학기별로 A 활동에 필요한 재료, 설비, 기구 및 자재 등을 사전에 B하고 C한다.",
                Answer = "실험·실습, 준비, 점검"
            },

            new QuestSet
            {
                Quest = "<교수·학습 및 평가의 방향> 가. 교수·학습 방향 - (10) 실험·실습 활동 시 아래 사항을 유의하도록 한다. (가) 기계, 도구 및 기구, 설비나 용구 등의 정확한 사용 방법을 A하여 안전 및 유의 사항을 숙지하도록 점검한다.",
                Answer = "사전에 지도"
            },

            new QuestSet
            {
                Quest = "<교수·학습 및 평가의 방향> 가. 교수·학습 방향 - (10) 실험·실습 활동 시 아래 사항을 유의하도록 한다. (나) 조리기구, 열원과 연료를 다룰 때의 A과 B 등을 지도하여 안전사고가 발생하지 않도록 주의한다.",
                Answer = "주의점, 소화기 사용법"
            },

            new QuestSet
            {
                Quest = "<교수·학습 및 평가의 방향> 가. 교수·학습 방향 - (10) 실험·실습 활동 시 아래 사항을 유의하도록 한다. (다) 안전사고 발생 시 간단한 A에 대해 지도하고 즉각적으로 치료를 받을 수 있도록 지도한다.",
                Answer = "응급 처치 요령"
            },

            new QuestSet
            {
                Quest = "<교수·학습 및 평가의 방향> 가. 교수·학습 방향 - (10) 실험·실습 활동 시 아래 사항을 유의하도록 한다. (라) 조리 실험·실습에서는 식품의 선택, 손질, 보관할 때 위생과 안전을 고려하도록 하여 A에 유의하도록 지도한다.",
                Answer = "식중독"
            },

            new QuestSet
            {
                Quest = "<교수·학습 및 평가의 방향> 가. 교수·학습 방향 - (10) 실험·실습 활동 시 아래 사항을 유의하도록 한다. (마) 실험·실습 후에는 실습실 내 뒷정리 등 A하는 습관을 갖도록 한다. 음식물 쓰레기, 약품, 폐기물 등은 수거 처리하여 B을 C시키지 않도록 유의하여 지도한다.",
                Answer = "정리·정돈, 환경, 오염"
            },

            new QuestSet
            {
                Quest = "<교수·학습 및 평가의 방향> 나. 평가 방향 - (2) 평가에서는 A, B, C 영역에서 모든 영역이 균형 있게 평가될 수 있도록 계획하되 다음과 같은 사항에 중점을 두어 평가한다.",
                Answer = "지적, 정의적, 기능적"
            },

            new QuestSet
            {
                Quest = "<교수·학습 및 평가의 방향> 나. 평가 방향 - (2) (가) 기본적인 개념이나 원리, 사실 등의 A과 B",
                Answer = "기초 지식, 배경 지식의 이해 능력"
            },

            new QuestSet
            {
                Quest = "<교수·학습 및 평가의 방향> 나. 평가 방향 - (2) (나) 비판적 사고 능력, 의사결정능력, 창의력 등을 활용한 A",
                Answer = "실천적문제해결능력"
            },

            new QuestSet
            {
                Quest = "<교수·학습 및 평가의 방향> 나. 평가 방향 - (2) (다) 실험·실습 방법과 과정에 따른 A",
                Answer = "실천적 수행 능력"
            },

            new QuestSet
            {
                Quest = "<교수·학습 및 평가의 방향> 나. 평가 방향 - (2) (라) 학습 내용을 A에 적극적으로 적용해 보려는 B",
                Answer = "실생활, 실천적 태도"
            },

            new QuestSet
            {
                Quest = "<교수·학습 및 평가의 방향> 나. 평가 방향 - (3) 평가의 A은 교육과정에 제시된 성취기준의 범위와 수준에 근거하되, 다양한 교수·학습 과정과 B에서 산출된 자료를 활용하여 C과의 D를 강화한다.",
                Answer = "내용, 결과, 교수·학습, 연계"
            },

            new QuestSet
            {
                Quest = "<교수·학습 및 평가의 방향> 나. 평가 방향 - (4) 실험·실습의 평가는 세부적인 평가 기준을 사전에 제시하고 평가하되, A뿐만 아니라 포트폴리오, B, 학생용 C, D 등을 활용하여 E 및 F을 평가한다.",
                Answer = "산출물 평가, 관찰용 점검표, 자기 평가, 동료 평가, 과정 중심 평가, 수행 능력"
            },

            new QuestSet
            {
                Quest = "<교수·학습 및 평가의 방향> 나. 평가 방향 - (6) 평가 목적, 평가 내용이나 영역, 평가 결과 활용 등을 종합적으로 고려하여 검사 도구를 제작·적용하고, 점수를 산출하는 A와 수량화되지 않은 다양한 형태의 자료를 수집하여 평가하는 B를 적절하게 활용하도록 한다.",
                Answer = "양적 평가, 질적 평가"
            },

            new QuestSet
            {
                Quest = "<교수·학습 및 평가의 방향> 나. 평가 방향 - (7) 학습자의 학업 성취를 위한 평가 결과는 학생의 평정 점수 외에 학생의 자기 진단을 위한 자료 및 학업 개선의 자료로 활용하며, 궁극적으로 학생의 A 및 B의 기초 자료로 활용하도록 한다.",
                Answer = "적성 파악, 진로 지도"
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
            }*/
            
        };
    }
}
