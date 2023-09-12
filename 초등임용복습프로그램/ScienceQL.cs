using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 초등임용복습프로그램
{
    class ScienceQL
    {
        //각론편에 5-2, 6-2 내용 스제트 없음. 내가 만들어야함

        public static List<QuestSet> Science_Basic_Theory = new List<QuestSet>()
            {
                new QuestSet()
                {
                    Quest = "과학의 본성 : 과학은 자연 현상을 설명하고 이해하는 데 도움이 되는 개념적 모형을 제공하지만, 현재의 모델은 __적인 것으로 절대적인 진리를 의미하지는 않는다. (3글자)",
                    Answer = "잠정성",
                    FullSentence = "null"
                },

                new QuestSet()
                {
                    Quest = "과학의 본성 : 과학은 실세계에 대한 __을 구성하는 과정으로, __은 실재의 상세한 부분이 생략되어 있지만, 가장 중요한 부분을 표착하는 표상이다. (3글자)",
                    Answer = "모형화",
                    FullSentence = "null",
                },

                new QuestSet()
                {
                    Quest = "과학에 관련된 태도 : 과학자들의 활동은 자연 세계에 대하여 알고 이해하고자 하는 ___에서 시작된다. 자연 현상에 대해 스스로 의문을 품고 답하려는 자세는 과학의 발달에서 매우 중요한 역할이 되고, 탐구의 원동력을 제공한다..",
                    Answer = "호기심",
                    FullSentence = "null",
                },

                new QuestSet()
                {
                    Quest = "과학에 관련된 태도 : 과학에서는 관찰된 현상을 설명하려고 사용하는 초자연적 설명보다 결론과 주장을 지지하는 논리적 증거를 중시한다. 이는 __적 논증 과정을 통하여 검증된 사실을 중시한다는 의미이다. (3글자)",
                    Answer = "합리성",
                    FullSentence = ""
                },

                new QuestSet()
                 {
                    Quest = "과학에 관련된 태도 : 과학적 탐구 과정을 수행할 때에는 개인적인 감정에 좌우되어서는 안 되며, 자료를 수집하고 해석하여 결론을 내리는 과정에서 다른 사람의 비논리적인 판단에 간섭을 받아서도 안 된다.",
                    Answer = "객관성",
                    FullSentence = ""
                 },

                new QuestSet()
                 {
                    Quest = "과학에 관련된 태도 : 불충분한 증거에 근거한 일반화는 경계해야 하며, 이에 대하여 적절한 이의를 제기할 수 있어야 한다. 가설은 일시적이고 잠정적인 것이며, 지식은 끊임없이 수정되는 것이기에 반드시 충분한 증거를 가지고 판단해야 한다.",
                    Answer = "판단 유보",
                    FullSentence = ""
                 },

                new QuestSet()
                 {
                    Quest = "과학에 관련된 태도 : ______은 다른 사람이 진술한 내용에 대한 증거를 요구하도록 한다. 이는 학생이 단순히 결과적인 지식을 습득하려는 시도가 아니고 지식의 근원과 신뢰도를 밝히려는 과정이다.",
                    Answer = "비판적인 마음",
                    FullSentence = ""
                 },

                new QuestSet()
                 {
                    Quest = "과학에 관련된 태도 : 과학자들은 흔히 자연 세계에는 항상 어느 정도의 불확실성이 있다고 받아들인다. 과학자들도 증거에 비추어 볼 때 어떤 사물이나 사상에 대하여 다른 설명이 필요하다면 기꺼이 자신의 이론이나 설명을 변경해야 한다.",
                    Answer = "개방성",
                    FullSentence = ""
                 },

                new QuestSet()
                 {
                    Quest = "과학에 관련된 태도 : 학생들은 과학을 수행함에 있어서 진실을 추구하고 존중해야 한다. 학생들이 관찰한 것을 진실되고 양심적으로 보고할 수 있어야 한다.",
                    Answer = "정직성",
                    FullSentence = ""
                 },

                new QuestSet()
                 {
                    Quest = "과학에 관련된 태도 : 진정한 과학자는 다른 이론의 주장에 타당성이 있으면 __하게 받아들이고, 아무리 권위 있는 사람의 이론이라고 하더라도 납득하기 어려운 점이 있으면 일단 __를 가지고 판단하게 된다.",
                    Answer = "겸손과 회의",
                    FullSentence = ""
                 },

                new QuestSet()
                 {
                    Quest = "과학에 관련된 태도 : 과학적 사고가 다른 사고와는 다른 대표적인 특징은 __에 기초하여 사고한다는 것이다. (5글자)",
                    Answer = "증거의 존중",
                    FullSentence = ""
                 },

                new QuestSet()
                 {
                    Quest = "과학에 관련된 태도 : 과학 활동을 수행하는 과정에서 과학자들 사이의 __은 매우 중요한 태도이다. (3글자)",
                    Answer = "협동심",
                    FullSentence = ""
                 },

                new QuestSet()
                 {
                    Quest = "과학에 관련된 태도 : __는 미지의 것을 탐구할 때 발생하는 자연스러운 과정이다. (8글자) ",
                    Answer = "실패의 긍정적 수용",
                    FullSentence = ""
                 }
            };

        public static List<QuestSet> Science_Particulars_Matter = new List<QuestSet>

        {
            new QuestSet()
            {
                Quest = "A이란 질량을 가지고 공간을 차지하는 것을 말한다.(A)",
                Answer = "물질",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "물질을 이루는 기본 입자는?",
                Answer = "원자",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "원자가 결합하여 만들어진 입자로, 물질의 성질을 가진 최소 단위는?",
                Answer = "분자",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "분자를 다시 원자로 분해하면?",
                Answer = "물질의 성질을 잃는다.",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "화학적 또는 물리적인 방법에 의해 더는 단순한 물질로 분해할 수 없는 물질은?",
                Answer = "원소",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "전기적인 성질을 띄는 입자는?",
                Answer = "이온",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "이온의 대표적인 예시를 들어보시오. A(B)의 형태로",
                Answer = "소금(염화나트륨)",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "[4과01-02] 크기와 모양은 같지만, 서로 다른 A로 이루어진 B들을 관찰하여 물질의 여러가지 C을 비교할 수 있다. (A, B, C)",
                Answer = "물질, 물체, 성질",
                FullSentence = "크기와 모양은 같지만, 서로 다른 물질로 이루어진 물체들을 관찰하여 물질의 여러가지 성질을 비교할 수 있다."
            },

            new QuestSet()
            {
                Quest = "천연고무의 경우 합성고무와 달리 비중이 1보다 A 물에 B. (A, B)",
                Answer = "작아, 뜬다",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "물질의 겉보기 성질 중 단단하기를 비교하기 위해서는 A(B)를 비교한다. (A(B))",
                Answer = "경도(굳기)",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "질량을 부피로 나눈 값은?",
                Answer = "밀도",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "어떤 물질의 밀도를 표준물 질량의 밀도로 나눈 값은?",
                Answer = "비중",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "비중과 밀도 중 물질의 특성에 해당하는 것은?",
                Answer = "밀도",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "질량과 부피를 차지하고 있는 것을 나타내는 과학 용어는?",
                Answer = "물질",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "한 종류의 물질로 이루어져 있는 물질은? 녹는 점, 어는 점, 끓는 점, 밀도 등이 일정하다.",
                Answer = "순물질",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "순물질은 A인 방법으로는 분리할 수 없다. (A)",
                Answer = "물리적",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "한 종류의 원소로 이루어진 물질은? (A(B))",
                Answer = "홑원소 물질(원소)",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "두 종류 이상의 원소들이 화학적으로 결합하여 이루어진 순물질은? 암모니아, 에탄올, 염화 나트륨 등이 있다.",
                Answer = "화합물",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "순물질은 화학적 방법으로 분리가 가능하다? O 아니면 X",
                Answer = "X",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "금, 철, 수소, 산소, 헬륨, 구리, 오존 등을 무엇이라 하는가?",
                Answer = "홑원소 물질",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "순물질이 가지고 있는 성질을 이용하여 분리하는 방법은? 자석 이용, 끓임 등",
                Answer = "물리적 분해 방법",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "화합물을 분해하면 물질의 성질은 없어진다. O 아니면 X",
                Answer = "O",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "두 가지 이상의 순물질이 본래의 성질을 잃지 않고 단순히 섞여 있는 물질은?",
                Answer = "혼합물",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "혼합물의 종류는? (A, B)",
                Answer = "균일 혼합물, 불균일 혼합물",
                FullSentence = ""
            }
,

            new QuestSet()
            {
                Quest = "성분 물질이 균일하게(고르게) 섞인 혼합물의 예시는?",
                Answer = "설탕물",
                FullSentence = ""
            }
,

            new QuestSet()
            {
                Quest = "성분 물질이 불균일하게 섞인 혼합물의 예시는?",
                Answer = "철광석",
                FullSentence = ""
            }
,

            new QuestSet()
            {
                Quest = "균일 혼합물은 농도가 일정하다? O 아니면 X",
                Answer = "O",
                FullSentence = ""
            }
,

            new QuestSet()
            {
                Quest = "자연에 존재하는 대부분의 물질은 A로 존재한다.",
                Answer = "혼합물",
                FullSentence = ""
            }
,

            new QuestSet()
            {
                Quest = "혼합물을 분리하는 이유는?",
                Answer = "필요한 순물질을 얻기 위해서",
                FullSentence = ""
            }
,

            new QuestSet()
            {
                Quest = "순물질은 끓는 점, 어는 점 등의 성질이 A하다. 반면 혼합물은 끓는 점, 어는 점 등의 성질이 A하지 않다.",
                Answer = "일정",
                FullSentence = ""
            }
,

            new QuestSet()
            {
                Quest = "물질의 여러가지 성질 중 그 물질만이 가지고 있는 고유한 성질은? (5글자, 띄어쓰기 있음)",
                Answer = "물질의 특성",
                FullSentence = ""
            }
,

            new QuestSet()
            {
                Quest = "감각기관을 이용하여 알아볼 수 있는 물질의 성질은? 색깔, 맛, 냄새, 결정, 굳기 등",
                Answer = "겉보기 성질",
                FullSentence = ""
            }
,

            new QuestSet()
            {
                Quest = "물질의 양에 관계없이 측정값이 일정한 성질은?",
                Answer = "세기 성질",
                FullSentence = ""
            }
,

            new QuestSet()
            {
                Quest = "물질의 양에 비례하여 그 값이 커지는 성질은?",
                Answer = "크기 성질",
                FullSentence = ""
            }
,

            new QuestSet()
            {
                Quest = "밀도, 끓는 점, 녹는 점, 어는 점, 용해도, 온도 등을 뭐라고 하는가? ",
                Answer = "세기 성질",
                FullSentence = ""
            }
,

            new QuestSet()
            {
                Quest = "모든 세기 성질은 물질의 특성이 될 수 있다? 온도는 제외. O 아니면 X",
                Answer = "X",
                FullSentence = ""
            }
,

            new QuestSet()
            {
                Quest = "재료의 단단하고 무른 정도를 가리키는 것으로, 긁어서 비교한다.",
                Answer = "경도",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "재료의 모양을 구부리거나 쪼개는 등 재료를 처음 모양으로 돌아갈 수 없는 수준으로 변형시키는 데 필요한 힘이다. 휘어서 비교한다.",
                Answer = "강도",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "'종류가 같은 물체를 서로 다른 물질로 만드는 까닭 알아보기' 실험에서 적용 가능한 학습모형?",
                Answer = "발견학습모형",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "[탐구정리] A가 같은 물체라도 물체가 이루고 있는 물질의 B에 따라 좋은 점이 다르다. (A,B)",
                Answer = "종류, 성질",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "액체 붕사가 피부에 닿았을 때 대처 방법은?",
                Answer = "곧바로 물로 씻는다.",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "폴리비닐 알코올(PVA)과 붕사가 결합하면서 나타나는 화학적 변화는? 탱탱볼 만들기",
                Answer = "가교 결합",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "물질의 본질 자체는 변하지 않고 모양, 크기, 상태 등만 변하는 것은? 물의 상태 변화, 용해 현상 등",
                Answer = "물리 변화",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "물질을 구성하는 원자들 사이 결합이 깨진 후 재배열하여 새로운 물질을 만드는 과정은? 연소 현상, 중화 반응 등",
                Answer = "화학 변화",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "물리적 변화는 분자 자체는 변하지 않고 A만 달라진다.(A)",
                Answer = "분자들의 배열",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "화학적 변화는 물질의 A이 달라져 다른 분자가 만들어진다.(A)",
                Answer = "성질",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "탱탱볼 만들기 실험에서 화학적 변화를 A으로 관찰한다. (A)",
                Answer = "정성적",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "초는 A와 B가 주성분인 파라핀 왁스로 만들어져 있다. 초가 산소와 결합하여 C하게 되면 D와 E가 생성된다. (A, B, C, D, E) ",
                Answer = "탄소, 수소, 연소, 이산화탄소, 물",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "대부분의 물질은 A와 B에 따라 고체, 액체, 기체의 세 가지 상태로 존재한다.(A,B)",
                Answer = "온도, 압력",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "고체는 일정한 형태를 가지고 있어 A이나 B의 변화에도 C나 D가 변하지 않는 상태로, 담는 그릇이 바뀌어도 C과 D가 일정하다. (A, B, C, D)",
                Answer = "힘, 압력, 모양, 부피",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "입자의 배열 상태에 따른 고체의 종류는? (A, B)",
                Answer = "결정성 고체, 비결정성 고체",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "가루 물질의 상태는?",
                Answer = "고체",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "'액체 알아보기' 실험에서 적용할 수 있는 학습 모형은?",
                Answer = "경험학습모형",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "물의 모양은 담는 그릇의 모양에 따라 A. (A)",
                Answer = "달라진다",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "처음 사용한 그릇으로 다시 옮기면 물의 높이가 처음과 A. (A)",
                Answer = "같다",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "[탐구정리] 물과 주스는 담는 그릇의 모양에 따라 A는 변하지만 B는 변하지 않습니다.",
                Answer = "모양, 부피",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "액체의 입자들이 거의 달라붙어 있지만 입자의 위치가 달라질 수 있어서, 담는 그릇에 따라 모양은 변하고 부피는 일정하다는 것과 관련된 개념은?",
                Answer = "유동성",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "액체는 A가 크고, B이 작다. (A, B)",
                Answer = "밀도, 압축성",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "'모든 액체는 물을 포함한다.'의 지도방안은?",
                Answer = "반례를 제시한다. (꿀, 샴푸, 참기름)",
                FullSentence = "",
                Reference = "물의 포함 여부와 관계없이 담는 그릇의 모양에 따라 모양이 변하지만, 부피는 변하지 않는 물질의 상태를 액체라고 함을 지도한다.  "
            },

            new QuestSet()
            {
                Quest = "[4과07-02] 기체가 A을 차지하고 있음을 알아보는 실험을 할 수 있다. (A)",
                Answer = "공간",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "바닥에 구멍이 뚫리지 않은 플라스틱 컵을 물이 담긴 수조에 거꾸로 넣으면 컵 속의 페트병 뚜껑이 A, 물의 높이는 B. (A, B)",
                Answer = "내려가고, 조금 높아진다.",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "바닥에 구멍이 뚫린 플라스틱 컵을 물이 담긴 수조에 넣으면, 컵 속의 페트병 뚜껑이 A, 물의 높이는 B. (A, B)",
                Answer = "그대로 있고, 변화가 없다",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "코끼리 나팔 실험과 주사기 피스톤 실험을 통해 알 수 있는 공기의 성질은?",
                Answer = "공기는 다른 곳으로 이동할 수 있다.",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "기체는 담는 그릇에 따라 모양과 부피가 A, 담긴 그릇을 B 물질의 상태이다.",
                Answer = "변하고, 항상 가득 채우는",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "기체는 한 곳에 몰려있지 않고, 활발하게 움직이면서 공간을 가득 채우는 성질과 관련된 개념은?",
                Answer = "확산",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "기체의 분자운동과 온도와의 관계는?",
                Answer = "온도가 높을 수록 속도가 빠른 분자들의 비율이 증가한다.",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "보일 법칙 : 기체의 압력과 부피는 A 관계이다. (A)",
                Answer = "반비례",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "샤를 법칙 : 일정한 압력에서 일정량의 기체 부피는 A에 B. (A, B)",
                Answer = "절대온도, 비례",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "1기압에서 물이 어는점을 0℃, 끓는점을 100℃로 하고, 이를 100등분한 온도는?",
                Answer = "섭씨온도",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "분자 운동이 완전히 멈추는 온도를 0으로 정한 온도는?",
                Answer = "절대온도",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "기체의 압력과 부피가 반비례하는 이유는, 기체는 입자 사이의 거리가 A 때문에 B가 많기 때문이다. 따라서 C가 크다. (A, B, C) ",
                Answer = "멀기, 빈 공간, 압축성",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "'공기는 물질이 아니다' 오개념의 지도방안은?",
                Answer = "물질은 질량과 부피를 가지고 있는 것으로, 공기도 질량과 부피를 갖고 있다.",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "'기체는 공기다.' 오개념의 지도방안은?",
                Answer = "기체는 어떤 특정 물질을 지칭하는 것이 아니라, 물질의 상태를 의미하는 것으로, 공기는 기체에 포함",
            },

            new QuestSet()
            {
                Quest = "'기체는 눈에 보이지 않는다.' 오개념의 지도방안은?",
                Answer = "반례 제시 : 브로민 기체(갈색), 아이오딘 기체(보라색), 염소 기체(황록색)",
            },

            new QuestSet()
            {
                Quest = "색이 있는 기체의 영상 자료를 제시하는 것은 어떤 의미를 갖는가?",
                Answer = "개념변화학습 모형의 갈등 상황 경험 단계에 제시",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "[4과07-03] 기체가 A가 있음을 알아보는 실험을 할 수 있다.",
                Answer = "무게",
                FullSentence = ""
            },

            new QuestSet()
            {
                Quest = "탐구활동의 목적이 공기의 무게를 A하는 것이 아니라, 페트병에 공기를 1기압으로 담은 상태의 무게와 공기를 1기압 이상으로 압축한 상태의 무게를 B함으로써 공기도 무게가 있음을 알아보는 것이다. 따라서 A한 무게가 공기의 실제 무게라고 인식하지 않도록 한다. (A, B)",
                Answer = "측정, 비교"

            },

            new QuestSet()
            {
                Quest = "[탐구 정리] 공기 압축 마개를 누르기 전보다 누른 후 페트병의 무게가 A한 것을 통해 공기는 B가 있다는 것을 알 수 있습니다. (A, B)",
                Answer = "늘어난, 무게"

            },

            new QuestSet()
            {
                Quest = "공기는 순물질인가? 아니라면 무엇인가? (O 아니면 X, 추가답변)",
                Answer = "X, 균일 혼합물"

            },

            new QuestSet()
            {
                Quest = "1몰은 무엇인가?",
                Answer = "물질의 양을 나타내는 단위"

            },

            new QuestSet()
            {
                Quest = "'기체는 무게나 질량이 없다.'의 오개념 유형은?",
                Answer = "현상 중심적 사고"

            },

            new QuestSet()
            {
                Quest = "'기체는 무게나 질량이 없다.' 오개념의 지도 방안은?",
                Answer = "'공기 압축 마개' 실험을 통해 인지적 갈등을 제공하고, 고체나 액체에 비교했을 때 단위 부피당 질량이 매우 작지만 기체도 질량과 부피가 있음을 지도한다." 

            },

            new QuestSet()
            {
                Quest = "풍선 로켓의 이동 원리는?",
                Answer = "작용과 반작용의 원리"

            },

            new QuestSet()
            {
                Quest = "풍선 로켓을 빠르게 이동하게 하기 위해서는 풍선을 크게 불어야 하는가? (O 아니면 X)",
                Answer = "X",
                Reference = "고무는 많이 늘어날 수록 두께가 얇아져서 탄성력이 작아지기 때문에 풍선이 공기를 미는 힘이 약해지기 때문이다."

            },

            new QuestSet()
            {
                Quest = "풍선 로켓의 이동 원리를 작용 - 반작용의 원리로 생각하지 못하는 아동의 오개념 유형은?",
                Answer = "단순 인과적 사고",
                Reference = "1. 작용에 대한 반작용의 개념을 이해하지 못하는 아동-> 가역적 사고를 하지 못하는 아동. 어떤 현상의 결과에 대한 원인이 여러 가지인데 한 가지 원인으로만 결과가 발생했다고 생각하는 아동."

            },

            new QuestSet()
            {
                Quest = "[4과12-01] 일상 생활에서 A의 예를 찾고, B의 필요성을 설명할 수 있다.",
                Answer = "혼합물, 혼합물 분리"

            },

            new QuestSet()
            {
                Quest = "혼합물은 여러 가지 물질을 섞었을 때 각 물질의 성질이 A, 성분 물질을 다시 분리할 때에도 물질의 성질은 B. (A, B)  ",
                Answer = "변하지 않고, 변하지 않는다."

            },

            new QuestSet()
            {
                Quest = "두 가지 이상의 순물질이 성질이 변하지 않은 채 서로 섞여있는 것은?",
                Answer = "혼합물"

            },

            new QuestSet()
            {
                Quest = "혼합물은 그 A이 다양할 수 있다. 예를 들어 물이 든 컵에 설탕 한 숟가락을 넣는 순간에는 고체인 설탕과 액체인 물로 이루어진 B이지만, 유리 막대로 계속 저으면 완전히 용해되어 C이 된다.",
                Answer = "조성, 불균일 혼합물, 균일 혼합물"

            },

            new QuestSet()
            {
                Quest = "혼합물을 분리하면 좋은 점은?",
                Answer = "혼합물을 분리하면 원하는 물질을 얻을 수 있고, 이를 우리 생활의 필요한 곳에 효과적으로 이용할 수 있다."

            },

            new QuestSet()
            {
                Quest = "생활 속에서 혼합물을 분리하는 예는?",
                Answer = "우리 생활 속에서 많이 사용되는 구리, 철 등은 혼합물인 광석에서 얻는다."

            },

            new QuestSet()
            {
                Quest = "순물질과 혼합물의 차이점은? (2가지. A, B)",
                Answer = "끓는점 오름, 어는점 내림",
                Reference = "순물질은 끓는점과 어는점(녹는점)이 일정하지만, 혼합물은 일정하지 않다. 순물질 여러 개를 섞었기 때문에 혼합물만이 가지고 있는 고유한 특징이 없기 때문이다."
            },

            new QuestSet()
            {
                Quest = "혼합물은 순물질보다 A 온도에서 끓기 시작하고, 끓는 동안 온도가 계속 B. (A, B)",
                Answer = "높은, 올라간다"

            },

            new QuestSet()
            {
                Quest = "혼합물은 순물질보다 A 온도에서 얼기 시작하고, 어는 동안 온도가 계속 B. (A, B)",
                Answer = "낮은, 내려간다"

            },

            new QuestSet()
            {
                Quest = "겨울철에 눈이 내릴 때 도로에 A을 뿌리면 물의 어는점이 낮아져 눈이 얼지 않아 차가 미끄러지는 사고를 예방할 수 있다.",
                Answer = "염화칼슘"

            },

            new QuestSet()
            {
                Quest = "물에 다른 용질을 넣었을 때 용질 입자들이 물 분자의 결합(물이 얾)을 방해하는 것을 가리키는 현상은?",
                Answer = "어는점 내림"

            },

            new QuestSet()
            {
                Quest = "끓는점 오름 현상에서 끓는 동안 온도가 계속 올라가는 이유는, 물이 끓으면서 소금의 농도가 더 A 때문이다. (A) ",
                Answer = "진해지기"

            },

            new QuestSet()
            {
                Quest = "[4과12-02] A와 B을 이용하여 고체 혼합물을 분리할 수 있다.",
                Answer = "알갱이의 크기, 자석에 붙는 성질"

            },

            new QuestSet()
            {
                Quest = "'콩, 팥, 좁쌀의 혼합물 분리하기' 실험에서 혼합물을 분리하는 방법은?",
                Answer = "눈의 크기가 다른 체 두 개를 사용하여 혼합물을 분리한다."

            },

            new QuestSet()
            {
                Quest = "콩, 팥, 좁쌀의 혼합물은 A가 다른 점을 이용하여 B로 분리할 수 있습니다.",
                Answer = "알갱이의 크기, 체"

            },

            new QuestSet()
            {
                Quest = "'플라스틱 구슬과 철 구슬의 혼합물 분리하기' 실험에서 혼합물을 분리할 때 이용하는 물질의 특성은? ",
                Answer = "자석에 붙는 성질과 자석에 붙지 않는 성질"

            },

            new QuestSet()
            {
                Quest = "모든 금속은 자석에 잘 붙는가? (O 아니면 X)",
                Answer = "X",
                Reference = "알루미늄, 구리는 자석에 붙지 않는다. 자석을 사용한 자동 분리기로 철 캔과 알루미늄 캔을 분리할 수 있다. "

            },

            new QuestSet()
            {
                Quest = "물리적 성질이란 물질의 A 없이 관찰되고 측정될 수 없는 성질이다. 녹는점, 끓는점, 밀도, 자성 등이 있다.",
                Answer = "조성 변화"
            },

            new QuestSet()
            {
                Quest = "물질이 가지는 자기적 성질은 무엇인가?",
                Answer = "자성"
            }
,

            new QuestSet()
            {
                Quest = "우리 주변의 물질을 지니고 있는 자성에 따라 A, B, C 3가지로 분류하면? (A, B, C)",
                Answer = "강자성체, 상자성체, 반자성체"
            }
,

            new QuestSet()
            {
                Quest = "[4과12-03] A를 꾸며 물에 녹는 물질과 녹지 않는 물질의 혼합물을 분리할 수 있다.",
                Answer = "거름 장치"
            }
,

            new QuestSet()
            {
                Quest = "[4과12-04] 물을 A시켜 물에 녹아 있는 고체 물질을 B할 수 있다.",
                Answer = "증발, 분리"
            }
,

            new QuestSet()
            {
                Quest = "증발 접시에서 물이 끓어 수증기가 되는 현상을 A이라 하고, B에서 물이 C하여 수증기가 되는 현상을 D이라고 하며, 이를 서로 구분한다. 하지만 교육과정상 이 단원에서는 D와 A를 엄격하게 구분하여 지도하지 않는다. (A, B, C, D)",
                Answer = "끓음, 표면, 기화, 증발"
            }
,

            new QuestSet()
            {
                Quest = "거름 장치를 꾸밀 때 거름 종이를 설치하는 방법은?",
                Answer = "거름 종이를 깔대기 안에 넣고 물을 묻힌다.",
                Reference = "깔대기와 거름종이가 들뜨지 않도록 하기 위해서이다."
            }
,

            new QuestSet()
            {
                Quest = "거름 장치를 꾸밀 때 깔대기를 설치하는 방법은?",
                Answer = "깔대기 끝의 긴 부분을 비커 옆면에 닿게 설치한다.",
                Reference = "물질이 튀지 않도록 하기 위해서이다."
            }
,

            new QuestSet()
            {
                Quest = "거름 장치를 사용할 때 액체 혼합물을 붓는 방법은?",
                Answer = "거르고자 하는 액체 혼합물이 유리 막대를 타고 천천히 흐르도록 붓는다.",
                Reference = "용액이 튀지 않도록 하기 위해서이다."
            }
,

            new QuestSet()
            {
                Quest = "거름 장치 실험에서 거름종이에 남아있는 물질 A와 거름종이를 빠져나간 물질 B를 말하시오. (A, B)",
                Answer = "모래, 소금물"
            }
,

            new QuestSet()
            {
                Quest = "증발접시에 소금물을 끓일 때 나타나는 현상은?",
                Answer = "물의 양이 줄어든다. 하얀색 고체 또는 하얀색 가루 물질이 생긴다."
            }
,

           new QuestSet()
            {
                Quest = "증발접시에 소금물을 끓일 때 하얀색 고체(또는 가루 물질)이 사방으로 튀는 이유는?",
                Answer = "소금 내부에 있는 물이 팽창하면서 소금이 깨지기 때문이다. "
            }
,

            new QuestSet()
            {
                Quest = "소금과 모래 혼합물에서 모래를 분리할 때 사용한 물질의 성질은?",
                Answer = "물에 녹지 않는 성질"
            }
,

            new QuestSet()
            {
                Quest = "소금물에서 소금과 물을 분리할 때 사용한 물질의 성질은?",
                Answer = "물의 끓는점",
                Reference = "이때 소금물은 혼합물이기 때문에 100도보다 높은 온도에서 끓는다."
            }
,

            new QuestSet()
            {
                Quest = "용질은?",
                Answer = "녹는 물질"
            }
,

            new QuestSet()
            {
                Quest = "용매는?",
                Answer = "녹이는 물질"
            }
,

            new QuestSet()
            {
                Quest = "용질과 용질 사이의 인력, 또는 용매와 용매 사이의 인력보다 용질과 용매 사이의 인력이 커지는 것을 무슨 원리라고 하는가?",
                Answer = "용해"
            }
,

            new QuestSet()
            {
                Quest = "모래가 물에 녹지 않는 까닭은?",
                Answer = "모래 분자인 이산화규소와 물 분자는 인력이 크지 않기 때문이다. "
            }
,

            new QuestSet()
            {
                Quest = "헝겊이나 거름종이 등을 이용하여 액체에 녹지 않는 고체 물질을 분리하는 방법을 무엇이라 하는가?",
                Answer = "거름"
            }
,

            new QuestSet()
            {
                Quest = "거름종이 위에는 A가 남고, 거른 용액 속에는 B가 섞여있다. (A, B)",
                Answer = "용매에 녹지 않는 고체, 용매에 녹는 고체"
            }
,

            new QuestSet()
            {
                Quest = "거름의 원리는무엇을 이용하는가?",
                Answer = "용해도의 차이"
            },

            new QuestSet()
            {
                Quest = "알코올램프의 알코올 보충 방법 : 알코올이 부족해지면 심지 꽂이를 빼고 A를 사용하여 용기의 B~C%가 되도록 알코올을 넣는다. (A, B, C)",
                Answer = "깔대기, 70, 80"
            },

            new QuestSet()
            {
                Quest = "알코올램프 사용 시 성냥불은 A에서 스치듯이 붙인다.",
                Answer = "옆쪽"
            }
,

            new QuestSet()
            {
                Quest = "알코올램프 사용 시 불을 끄는 방법 : 뚜껑을 A에서부터 B 끈다. 잠시 후 뚜껑을 열어 불이 꺼진 것을 다시 확인하고 액화된 알코올을 증발시킨 후 C. (A, B, C)",
                Answer = "옆, 덮어서, 덮는다"
            }
,

            new QuestSet()
            {
                Quest = "'재생종이 만들기' 실험에서 거름의 원리가 적용된 단계는?",
                Answer = "종이죽과 물을 섞은 혼합물을 종이 만들기 틀을 이용하여 종이뜨기를 하는 과정"
            }
,

            new QuestSet()
            {
                Quest = "'재생종이 만들기' 실험에서 증발의 원리가 적용된 단계는?",
                Answer = "종이 뜨기를 한 후 말리는 과정."
            }
,

            new QuestSet()
            {
                Quest = "[4과14-01] 물이 A나 B으로 변할 수 있음을 알고, 물이 얼 때와 얼음이 녹을 때의 C를 관찰할 수 있다.(A, B, C)",
                Answer = "수증기, 얼음, 부피와 무게 변화",
                Reference = "물이 얼 때와 녹을 때의 부피 변화를 정확한 수치로 측정하여 비교하지 않고, 물기둥의 높이 변화로 부피가 변했음을 이해할 수 있도록 한다. -> 정성적 관찰"
            }
,

            new QuestSet()
            {
                Quest = "'물이 얼 때의 부피와 무게 변화 관찰하기' 실험에서 플라스틱 시험관에 물을 A 정도로 붓는다. (A) ",
                Answer = "A",
                Reference = "물은 얼면서 부피가 증가하기 때문에 가득 부으면 안 된다."
            }
,

            new QuestSet()
            {
                Quest = "비커에 잘게 부순 얼음을 넣고 그 안에 A를 넣는다. (A)",
                Answer = "소금"
            }
,

            new QuestSet()
            {
                Quest = "물이 언 플라스틱 시험관의 무게를 측정할 때 유의점은?",
                Answer = "플라스틱 시험관 겉면의 물기를 닦은 후 무게를 측정해야 한다.",
                Reference = "플라스틱 시험관 바깥 쪽에 물방울이 응결되었기 때문이다."
            }
,

            new QuestSet()
            {
                Quest = "물이 얼면 부피는 A. 물이 얼면 무게는 B. (A, B)",
                Answer = "늘어난다, 변하지 않는다."
            }
,

            new QuestSet()
            {
                Quest = "일반적으로 어떤 물질이 액체에서 고체가 되면 부피는 A하지만, 물은 액체에서 고체가 되면 부피가 B한다.(A, B)",
                Answer = "감소, 증가"
            }
,

            new QuestSet()
            {
                Quest = "물질은 A에 따라 B, C, D의 세 가지 상태로 존재한다. (A, B, C, D)",
                Answer = "온도, 고체, 액체, 기체"
            }
,

            new QuestSet()
            {
                Quest = "고체가 A하면 액체가 되고, 액체가 A하면 기체가 된다. 기체가 B하면 액체가 되고, 액체가 B하면 고체가 된다.",
                Answer = "흡열, 발열"
            }
,

            new QuestSet()
            {
                Quest = "A에 의해 물질의 상태가 변해도 물질의 B는 변하지 않는다.",
                Answer = "열, 특성"
            }
,

            new QuestSet()
            {
                Quest = "물질의 상태 변화는 물리적 변화인가? (O 아니면 X)",
                Answer = "O"
            }
,

            new QuestSet()
            {
                Quest = "물질의 상태마다 특성이 다른 까닭은?",
                Answer = "입자의 배열이 다르기 때문이다."
            }
,

            new QuestSet()
            {
                Quest = "고체는 물질을 이루는 분자들이 매우 강한 힘(A)으로 연결되어 B 배열을 하고 있다. 이 때문에 일정한 C을 가지며 대체로 단단하다.(A, B, C)",
                Answer = "응집력, 규칙적인, 모양"
            }
,

            new QuestSet()
            {
                Quest = "액체는 고체보다 물질을 이루는 분자들 사이에서 작용하는 힘이 약하다. 이 때문에 A가 일정하지 않고, 흐르는 성질 B가 있다. ",
                Answer = "모양, 유동성"
            }
,

            new QuestSet()
            {
                Quest = "기체는 분자들 사이에서 끌어당기는 힘이 매우 약하다. 또 분자가 많은 에너지를 가지고 A하므로 분자 사이의 거리가 B. 이 때문에 담는 그릇의 모양이나 가하는 힘의 크기에 따라 C이나 D가 쉽게 변한다.",
                Answer = "활발하게 운동, 멀다, 모양, 부피"
            }
,

            new QuestSet()
            {
                Quest = "물이 얼면 삼차원적 수소결합에 의해 부피가 증가한다. 이를 풀어서 설명하시오.",
                Answer = "물을 냉각하면 물 분자들끼리 육각형의 결정을 이루고, 이 때문에 물 분자 사이에 공간이 생겨 부피가 늘어난다."
            }
,

            new QuestSet()
            {
                Quest = "물이 얼어 얼음이 되면 A는 변하지 않지만 부피는 B. (A, B)",
                Answer = "무게, 늘어난다"
            }
,

            new QuestSet()
            {
                Quest = "얼음이 녹아 물이 되면 A는 변하지 않지만 부피는 B. (A, B)",
                Answer = "무게, 줄어든다"
            }
,

            new QuestSet()
            {
                Quest = "물을 얼릴 때 소금을 넣는 까닭에는 A, B가 있다. (A, B)",
                Answer = "흡열반응을 2번 일어나게 하기 위해, 어는점 내림 현상을 이용하기 위해",
                Reference = "얼음에 소금을 뿌리면 얼음이 녹는 과정 (얼음의 용해열)과 소금이 물에 녹는 과정(소금의 용해열) 모두 주변의 열을 흡수하는 흡열반응이 일어난다. "
            }
,

            new QuestSet()
            {
                Quest = "얼음을 잘게 부수는 이유는?",
                Answer = "소금과 얼음이 닿는 면적을 넓혀 물이 어는 데 걸리는 시간을 더 줄이기 위해서."
            }
,

            new QuestSet()
            {
                Quest = "'물은 둥근 모양이다.' 오개념의 원인은?",
                Answer = "물의 표면장력",
                Reference = "액체가 표면적을 작게 하려고 분자들끼리 끌어당기는 힘"
            }
,

            new QuestSet()
            {
                Quest = "'물은 둥근 모양이다.'의 지도 방안은 다음과 같다. 담는 그릇의 모양을 A 해 물을 옮겨 담아 봄으로써 모양이 B하지 않고 담는 그릇에 따라 물의 C이 변함을 이해하도록 지도한다. (A, B, C)",
                Answer = "다르게, 일정, 모양"
            }
,

            new QuestSet()
            {
                Quest = "물 분자는 산소 원자가 수소 원자에 비하여 A를 끌어당기는 힘이 강하여 산소 원자는 부분적으로 B전하를 띠고 수소 원자는 부분적으로 C전하를 띤다. 그래서 분자 사이에 D가 작용하게 되는데 이러한 분자 사이의 결합을 E라고 한다.",
                Answer = "공유 전자쌍, 음, 양, 인력, 수소 결합",
                Reference = "하나의 물 분자를 중심으로 네 개의 물 분자가 정사면체 모양으로 배치하게 되는 삼차원적 수소 결합이 물이 얼면서 부피가 늘어나는 것의 원인이다."
            }
,

            new QuestSet()
            {
                Quest = "부분적으로 전기적 성질을 가지고 있는 물질을 무엇이라 하는가?",
                Answer = "극성물질"
            }
,

            new QuestSet()
            {
                Quest = "물과 기름이 섞이지 않는 이유는 물은 A이고 기름은 B이기 때문이다. (A, B)",
                Answer = "극성물질, 무극성물질"
            }
,

            new QuestSet()
            {
                Quest = "식용유가 물 위에 뜨는 이유는 물의 A가 식용유의 A보다 크기 때문이다. (A) ",
                Answer = "비중"
            }
,

            new QuestSet()
            {
                Quest = "얼음이 녹으면 부피는 A. 반면 무게는 B. (A, B)",
                Answer = "줄어든다, 변하지 않는다"
            }
,

            new QuestSet()
            {
                Quest = "얼음이 물 위에 뜨는 까닭을 A, B 2가지 쓰시오. (A, B)",
                Answer = "삼차원적 수소결합에 의해 얼음이 되면서 부피가 늘어난다, 부피가 늘어남에 따라 물보다 밀도가 낮아져(=비중이 낮아져) 얼음이 물 위에 뜬다."
            }
,

            new QuestSet()
            {
                Quest = "물에 떠 있는 얼음이 녹아도 물의 높이가 변하지 않는 까닭은 무엇인가?",
                Answer = "물에 떠 있던 얼음이 녹아 물이 될 때 얼음이 물에 뜬 만큼 늘어났던 부피가 다시 원래대로 돌아오기 때문이다."
            }
,

            new QuestSet()
            {
                Quest = "이론적으로 바다의 빙하가 녹으면 해수면이 올라가지 않는다? (O 아니면 X)",
                Answer = "O",
                Reference = "빙하가 녹아서 해수면이 상승하는 것은 육지에 있는 빙하가 녹을 때의 이야기이다."
            }
,

            new QuestSet()
            {
                Quest = "[4과14-02] 물이 A와 B의 변화를 관찰하여 차이점을 알고, 이와 관련된 예를 우리 주변에서 찾을 수 있다.",
                Answer = "증발할 때, 끓을 때"
            }
,

            new QuestSet()
            {
                Quest = "'과일을 말리면 그 안에 있던 물은 어떻게 될까요?'에 적용할 수 있는 수업 모형은?",
                Answer = "순환 학습 모형"
            }
,

            new QuestSet()
            {
                Quest = "식품 건조기에 넣은 사과 조각이 변한 까닭은?",
                Answer = "과일에 들어 있던 물이 증발하여 수증기로 변해 공기 중으로 흩어졌기 때문이다."
            }
,

            new QuestSet()
            {
                Quest = "물 표면에서 액체인 물이 기체인 수증기로 상태가 변하는 현상은?",
                Answer = "증발"
            }
,

            new QuestSet()
            {
                Quest = "A는 액체 상태인 물질이 기체 상태인 물질로 변하는 현상으로, 증발하거나 끓을 때 현상이 나타난다. 이 때 열 에너지를 흡수하기 때문이다.",
                Answer = "기화"
            }
,

            new QuestSet()
            {
                Quest = "기화의 예 A, B 2가지를 '기화'로 보지 않고 서로 같게 보는 사고 C는? (A, B, C)",
                Answer = "증발, 끓음, 상황 의존적 사고"
            }
,

            new QuestSet()
            {
                Quest = "증발이 잘 일어나는 상황에는 A, B, C 3가지가 있다. (A, B, C)",
                Answer = "습도가 낮을 때, 공기의 온도가 높을 때, 표면적이 넓을 때"
            }
,

            new QuestSet()
            {
                Quest = "증발은 A에 상관없이 발생한다.",
                Answer = "온도"
            }
,

            new QuestSet()
            {
                Quest = "공기가 계속 수증기를 받아들일 수 있는 상태를 A라고 하며, 주위 공기가 수증기를 최대로 받아들인 상태를 B라고 한다.",
                Answer = "불포화 상태, 포화 상태"
            },

            new QuestSet()
            {
                Quest = "물이 100℃가 되지 않아도 증발하는 까닭은?",
                Answer = "공기가 수증기를 계속 받아들일 수 있는 상태를 불포화 상태라고 하는데, 물은 주위의 공기가 수증기를 최대로 받아들여 포화상태가 될 때까지 증발한다."
            },

            new QuestSet()
            {
                Quest = "A이 넘어가게 되면 물은 수증기가 되지 않고 응결하게 된다.",
                Answer = "포화 수증기량"
            }
,

            new QuestSet()
            {
                Quest = "A는 온도에 따라 달라지는데, 공기 1㎥속에 최대한 들어갈 수 있는 수증기 양을 질량(g)으로 표시한 것이다.",
                Answer = "포화 수증기량"
            }
,

            new QuestSet()
            {
                Quest = "A란 응결이 되기 시작하는 온도, 즉 포화수증기량이 되는 온도이다.",
                Answer = "이슬점"
            }
,

            new QuestSet()
            {
                Quest = "A는 공기의 온도가 낮아져 물이 수증기의 상태로 있을 수 있는 양이 포화 상태가 되어 공기 중의 수증기가 물방울로 변하기 시작하는 온도를 가리킨다.",
                Answer = ""
            }
,

            new QuestSet()
            {
                Quest = "A는 물의 표면 뿐만 아니라 물 속에서도 액체인 물이 기체인 수증기로 상태가 변하는 현상을 가리킨다.",
                Answer = "끓음"
            }
,

            new QuestSet()
            {
                Quest = "물이 끓을 때도 증발 현상은 계속 일어난다. (O 아니면 X)",
                Answer = "O"
            }
,

            new QuestSet()
            {
                Quest = "물의 끓는 점은?",
                Answer = "1기압에서 100℃"
            }
,

            new QuestSet()
            {
                Quest = "기압이 높을 수록 끓는 점이 높다. (O 아니면 X)",
                Answer = "O"
            }
,

            new QuestSet()
            {
                Quest = "대기압과 증기압의 관계는?",
                Answer = "대기압과 증기압이 같을 때 끓게 된다."
            }
,

            new QuestSet()
            {
                Quest = "4-2-2. 물의 상태 변화 성취기준 : [4과14-02] 물이 A와 B의 변화를 관찰하여 차이점을 알고, 이와 관련된 예를 우리 주변에서 찾을 수 있다.",
                Answer = "증발할 때, 끓을 때"
            }
,

            new QuestSet()
            {
                Quest = "'과일을 말리면 그 안에 있던 물은 어떻게 될까요?'에 적용할 수 있는 수업 모형은 A이다.",
                Answer = "순환 학습 모형",
                Reference = "탐색 - 개념 도입 - 개념 적용"                
            }
,

            new QuestSet()
            {
                Quest = "물 표면에서 A인 물이 B인 C로 상태가 변하는 현상을 증발이라고 한다.",
                Answer = "액체, 기체, 수증기"
            }
,

            new QuestSet()
            {
                Quest = "기화는 A 상태인 물질이 B 상태인 물질로 변하는 현상으로, C하거나 D 때 기화 현상이 나타난다. 이때는 E를 흡수하기 때문이다.",
                Answer = "액체, 기체, 증발, 끓을, 열 에너지"
            }
,

            new QuestSet()
            {
                Quest = "증발, 끓음이라는 기화의 예 2가지를 '기화'로 보지 않고 서로 같게 보는 사고를 A라고 한다.",
                Answer = "상황 의존적 사고"
            }
,

            new QuestSet()
            {
                Quest = "증발이 잘 일어나는 상황은 다음과 같다. ① A가 낮은 날 ② B가 높은 날 ③ C이 넓을 때",
                Answer = "습도, 공기의 온도, 표면적"
            }
,

            new QuestSet()
            {
                Quest = "A 상태는 공기가 계속 수증기를 받아들일 수 있는 상태를 의미한다. 반면 B 상태는 주위의 공기가 수증기를 최대로 받아들인 상태를 의미한다.",
                Answer = "불포화, 포화"
            }
,

            new QuestSet()
            {
                Quest = "물이 100℃가 되지 않아도 증발하는 까닭을 한 문장으로 서술하시오.",
                Answer = "공기가 수증기를 계속 받아들일 수 있는 상태를 불포화상태라고 하는데, 물은 주위 불포화상태의 공기가 수증기를 최대로 받아들여 포화상태가 될 때까지 증발한다."
            }
,

            new QuestSet()
            {
                Quest = "수증기가 응결되는 까닭은 공기 중의 수증기량이 A을 넘어가게 되었기 때문이다.",
                Answer = "포화 수증기량"
            }
,

            new QuestSet()
            {
                Quest = "포화 수증기량은 A에 따라 달라지는데, B 1㎥속에 최대한 들어갈 수 있는 수증기양을 C(g)으로 표시한 것이다.",
                Answer = "온도, 공기, 질량"
            }
,

            new QuestSet()
            {
                Quest = "이슬점이란 A이 되기 시작하는 온도이다. (B에 도달한 시점의 온도이다.) 즉 공기의 C가 낮아져 물이 수증기의 상태로 있을 수 있는 양이 포화 상태가 되어 공기 중의 수증기가 물방울로 변하기 시작하는 온도이다.",
                Answer = "응결, 포화수증기량, 온도"
            }
,

            new QuestSet()
            {
                Quest = "A은 물의 표면 뿐만 아니라 물속에서도 액체인 물이 기체인 수증기로 상태가 변하는 현상을 의미한다.",
                Answer = "끓음",
                Reference = "물이 끓을 때도 물 표면에서의 증발 현상은 계속 일어난다."
            }
,

            new QuestSet()
            {
                Quest = "물의 끓는점은 A에서 B℃이다.",
                Answer = "1기압, 100"
            }
,

            new QuestSet()
            {
                Quest = "기압이 높을 수록 끓는점이 높다?",
                Answer = "O"
            }
,

            new QuestSet()
            {
                Quest = "대기압과 증기압의 관계를 한 문장으로 서술하시오.",
                Answer = "대기압과 증기압이 같을 때 액체의 끓음 현상이 나타난다."
            }
,

            new QuestSet()
            {
                Quest = "액체가 끓고 있는 도중에 액체의 온도가 일정하게 유지되는 까닭은 A(B) 때문이다.",
                Answer = "숨은열, 잠열",
                Reference = "잠열이란 어떤 물체의 상태가 변할 때 온도의 변화는 없이 방출되거나 흡수되는 열이다. 액체가 끓고 있는 동안에 흡수되는 열 에너지는 액체에서 기체로 상태가 변하는 데 모두 쓰인다."
            }
,

            new QuestSet()
            {
                Quest = "증발과 끓음의 공통점은 'A'이다.",
                Answer = "물이 수증기 상태로 변함"
            }
,

            new QuestSet()
            {
                Quest = "증발과 끓음의 차이점은 다음과 같다. ① 증발은 A에서 물이 수증기로 상태가 변한다. 반면 끓음은 A, B에서 물이 수증기로 변한다. ② 증발은 C이 매우 천천히 줄어든다. 반면 끓음은 증발할 때보다 C가 빠르게 줄어든다. ③ 증발은 D에 상관 없이 일어나지만, 끓음은 1기압 100℃에서 일어난다.",
                Answer = "물 표면, 물 속, 물의 양, 온도"
            }
,

            new QuestSet()
            {
                Quest = "물을 끓이기 전과 끓을 때 물 속에서 생기는 기포의 차이점을 서술하시오.",
                Answer = "물이 끓기 전에 올라오는 기포는 물 속에도 매우 적은 양의 공기가 녹아 있는데 그 공기가 공기바울의 형태로 밖으로 빠져나오는 것이다. 한편 물이 끓는 점에 이르면 물 내부에 큰 기포가 형성되는데, 이것은 공기방울이 아니라 기체 상태인 수증기가 모여 방울을 형성한 것이다."
            }
,

            new QuestSet()
            {
                Quest = "4-2-2. 물의 상태 변화 성취기준 : [4과14-03] 수증기가 A하는 현상을 관찰하고, 이와 관련된 예를 우리 주변에서 찾을 수 있다.",
                Answer = "응결"
            }
,

            new QuestSet()
            {
                Quest = "수증기가 물이 되는 상태 변화를 관찰하는 실험을 할 때 가능한 활동을 서술하시오.",
                Answer = "차가운 컵 표면에서 일어나는 변화 관찰하기"
            }
,

            new QuestSet()
            {
                Quest = "'수증기가 물이 되는 상태 변화 관찰하기' 실험의 결과는 다음과 같다. ① 컵 표면에 A이 맺힌다. ② 시간이 지나면서 은박 접시에 A이 고인다. ③ 처음보다 나중의 무게가 더 B.",
                Answer = "물방울, 무겁다"
            }
,

            new QuestSet()
            {
                Quest = "'차가운 컵 표면에서 일어나는 변화 관찰하기' 실험에서 컵의 무게가 달라진 까닭은 공기 중의 A가 B해 물로 상태가 변해서 컵 표면에 달라붙었기 때문이다.",
                Answer = "수증기, 응결"
            }
,

            new QuestSet()
            {
                Quest = "'차가운 컵 표면에서 일어나는 변화 관찰하기' 실험에서 측정 활동이 끝난 뒤 컵 표면에 맺힌 물방울을 휴지로 닦는 이유를 서술하시오.",
                Answer = "컵 표면에 맺힌 물방울의 색깔이 없음을 확인하기 위함이다.",
                Reference = "컵 안의 주스가 밖으로 나온 것이 아님을 확인하기 위한 것이다."
            }
,

            new QuestSet()
            {
                Quest = "A이란 기체인 수증기가 액체인 물로 상태가 변하는 현상이다.",
                Answer = "응결",
                Reference = "액화의 한 종류 : 기체 → 액체"
            }
,

            new QuestSet()
            {
                Quest = "수증기가 응결되는 까닭을 서술하시오.",
                Answer = "공기의 온도가 낮아져 이슬점 아래로 내려가면 공기 중에 포함될 수 있는 수증기의 양이 줄어들어 수증기가 물로 응결한다."
            }
,

            new QuestSet()
            {
                Quest = "수증기 응결로 인한 기상 현상의 대표적 예시로는 A, B, C가 있다.",
                Answer = "안개, 이슬, 구름"
            }
,

            new QuestSet()
            {
                Quest = "A는 수증기 응결로 인한 기상 현상으로, 따뜻한 공기가 차가운 공기를 만나면 수증기가 응결해 작은 물방울 상태로 공기 중에 떠있게 되는 현상이다.",
                Answer = "안개"
            }
,

            new QuestSet()
            {
                Quest = "A는 따뜻한 공기가 차가운 물체를 만나 물체 표면에 맺힌 것이다. 낮과 밤의 기온 차가 크면 공기의 포화수증기량이 감소해 남은 수증기가 A로 B한다.",
                Answer = "이슬, 응결"
            }
,

            new QuestSet()
            {
                Quest = "A는 공기 중의 수증기가 높은 하늘에서 응결해 생성되는 것이다.",
                Answer = "구름",
                Reference = "수증기→승화(발열)→얼음(고체) ; 성에, 서리 (차가운 물체 표면에 생긴다)"
            }
,

            new QuestSet()
            {
                Quest = "액화와 달리 응결은 A의 상태 변화에만 한정해 사용하는 용어이다.",
                Answer = "물",
                Reference = "응결 또한 액화의 한 종류"
            }
,

            new QuestSet()
            {
                Quest = "컵 표면에 맺힌 물방울은 컵 속의 물이 밖으로 새어 나온 것이다. (O 아니면 X)",
                Answer = "X"
            }
,

            new QuestSet()
            {
                Quest = "'컵 표면에 맺힌 물방울은 컵 속의 물이 밖으로 새어 나온 것이다.' 오개념을 지도하기 위한 방안은 다음과 같다. ① 화장지로 컵의 표면을 닦아 A을 확인한다. ② 컵 안의 B가 줄지 않았음을 확인한다. ③ C를 비교한다. (D 유발하는 실험을 통해 확인한다.)",
                Answer = "색깔이 없음, 물의 높이, 무게, 인지적 갈등"
            }
,

            new QuestSet()
            {
                Quest = "이슬이 맑은 날 잘 생기는 이유를 서술하시오.",
                Answer = "낮과 밤의 기온 차가 심하여 새벽에 기온이 낮아 공기 포화수증기량이 크게 감소하기 때문에 여분의 수증기가 많아지고 그것이 이슬로 응결하는 것이다."
            }
,

            new QuestSet()
            {
                Quest = "구름의 생성 원인은 다음과 같다. 지표의 공기가 올라가 A이 내려가므로 B가 늘어난다. B가 늘어나면서 공기가 한 일의 양만큼 C가 내려간다. 이러한 과정을 D이라 한다. 즉 D(열의 출입이 없이 팽창)하며 C가 내려가고 수증기가 E하여 구름이 만들어진다.",
                Answer = "기압, 부피, 온도, 단열 팽창, 응결",
                Reference = "증발한 수증기 → 상승 → 부피 팽창(단열 팽창) → 온도 하강 → 수증기 응결 → 구름 생성"
            }
,

            new QuestSet()
            {
                Quest = "4-2-2. 물의 상태 변화 성취기준 : [4과14-01] 물이 A나 B으로 변할 수 있음을 알고, 물이 얼 때나 얼음이 녹을 때의 C와 D를 관찰할 수 있다.",
                Answer = "수증기, 얼음, 부피, 무게 변화"
            }
,

            new QuestSet()
            {
                Quest = "4-2-2. 물의 상태 변화 성취기준 : [4과14-02] 물이 A와 B의 변화를 관찰하여 차이점을 알고, 이와 관련된 예를 우리 주변에서 찾을 수 있다.",
                Answer = "증발할 때, 끓을 때"
            }
,

            new QuestSet()
            {
                Quest = "4-2-2. 물의 상태 변화 성취기준 : [4과14-03] 수증기가 A하는 현상을 관찰하고, 이와 관련된 예를 우리 주변에서 찾을 수 있다.",
                Answer = "응결"
            },

            new QuestSet
            {
                Quest = "우리 생활에서 물의 상태변화를 이용한 예를 서술하시오.",
                Answer = "얼음과자 만들 때, 물을 얼려 붙여 얼음 작품 만들 때, 음식을 찔 때, 스키장 인공 눈 만들 때, 가습기 이용할 때, 스팀 다리미로 옷의 주름 펼 때, 스팀 청소기로 바닥을 닦을 때"
            },

            new QuestSet
            {
                Quest = "5-1-4. 용해와 용액 성취기준 : [6과03-01] 물질이 물에 A을 관찰하고 용액을 설명할 수 있다.",
                Answer = "녹는 현상",
                Reference = "<성취기준 해설> 용해의 과정과 용해의 결과인 용액을 관찰하고 그 특징을 알게 한다. 물에 녹는 물질과 녹지 않는 물질을 물에 넣어서 비교하는 활동을 통하여 물질이 용해되는 현상을 이해하도록 한다. 물질을 물에 녹이기 전과 후의 무게를 비교하는 실험을 통하여 용해의 과정을 이해할 수 있도록 돕는다."
            },

            new QuestSet
            {
                Quest = "용해의 조건은 다음과 같다. ① 어떤 용질이 용매에 녹으려면 용질과 용매 사이의 A이 용질 입자 사이의 A이나 용매 입자 사이의 A보다 B야한다. ② 극성 물질은 극성 용매에, 무극성 물질은 무극성 용매에 C.",
                Answer = "인력, 커, 잘 녹는다",
                Reference = "극성 물질 : 분자 구조 상 부분적으로 (+), (-)극의 전기적인 성질을 가지고 있는 물질이다. 무극성 물질 : 분자 내부에 전기적 성질이 없는 물질이다."
                 
                
            },

            new QuestSet
            {
                Quest = "5-1-4. 용해와 용액 단원지도 유의점 : 용해 현상에 있어서 A보다 B에 초점을 두어 학습하도록 하고, 실험할 용질이 용해되었는지 여부는 C으로 관찰하고 판단하도록 한다.",
                Answer = "녹는 시간, 녹는 양, 맨눈"
            },

            new QuestSet
            {
                Quest = "5-1-4. 용해와 용액 단원지도 유의점 : 물질을 물에 많이 녹이는 경우는 A, B, C와 관련된 것이며, 물질을 빨리 녹이는 경우는 D와 관련된 것이므로 혼동하지 않도록 주의한다.",
                Answer = "포화, 과포화, 용해도, 물질의 녹는 빠르기"
            },

            new QuestSet
            {
                Quest = "5-1-4. 용해와 용액 단원지도 유의점 : 물의 A 가루물질이 빨리 녹으면서 더 많이 녹는다. 그런데 B 더 빨리 녹일 수는 있지만 더 많이 녹지는 않는다.",
                Answer = "온도를 높이면, 용액을 저으면"
            },

            new QuestSet
            {
                Quest = "A은 두 가지 이상의 순수한 물질이 균일하게 섞인 혼합물이다. A은 오래 두어도 가라앉거나 뜨는 것이 없고 거름 장치에 걸러도 남는 것이 없다.",
                Answer = "용액"
            },

            new QuestSet
            {
                Quest = "우유는 용액이다. (O 아니면 X)",
                Answer = "O",
                Reference = "우유는 콜로이드 용액이다. 입자가 용매 속에 떠다니는 모습으로 나타난다."

            },

            new QuestSet
            {
                Quest = "미숫가루 탄 물은 용액이다. (O 아니면 X)",
                Answer = "X",
                Reference = "시간이 지나면 바닥에 가라앉는 물질이 생긴다. 거름종이로 걸러도 걸러진다. 그렇다면 용액이 아니다!"
            },

            new QuestSet
            {
                Quest = "용액과 용액이 아닌 것을 구별하는 방법은 A에 의해 구하는 것이다.",
                Answer = "조작적 관찰"
            },

            new QuestSet
            {
                Quest = "'액체 탑 만들기' 실험에서 설탕물이 섞이지 않는 이유는 A가 다르기 때문이다.",
                Answer = "밀도",
                Reference = "실험을 할 때 밀도가 큰 순서대로 넣어야 한다. 또한 설탕물의 경우 농도가 진할 수록 밀도가 커진다."
            },

            new QuestSet
            {
                Quest = "'액체 탑 만들기' 실험에서 설탕물 층이 잘 생기지 않을 경우에는 어떻게 하는지 서술하시오.",
                Answer = "녹이는 설탕의 양을 밀도 차이가 크도록 적절히 증감한다."
            },

            new QuestSet
            {
                Quest = "설탕물을 넣을 때 시험관 벽을 따라 흘려 넣는 이유를 서술하시오.",
                Answer = "설탕물을 넣을 때에 물리적인 충격 때문에 용액이 서로 섞이지 않도록 하기 위해서이다."
            },

            new QuestSet
            {
                Quest = "설탕물 층을 만든 후 몇 분이 지나면 어떻게 되는지 서술하시오. ",
                Answer = "층들 간의 경계가 무너지기 시작하여 결국 층의 구분이 없이 섞이게 된다.",
                Reference = "밀도가 높은 물질이 낮은 물질로 이동(확산)하면서 서로 섞여 용액 간에 밀도 차이가 없어지기 때문이다."
            },

            new QuestSet
            {
                Quest = "A는 소금이나 설탕이 물에 녹는 것처럼, 어떤 물질이 다른 물질에 녹아 골고루 섞이는 현상을 말한다.",
                Answer = "용해"
            },

            new QuestSet
            {
                Quest = "A는 소금이나 설탕처럼, 다른 물질에 녹는 물질을 말한다.",
                Answer = "용질"
            },

            new QuestSet
            {
                Quest = "A는 물처럼, 다른 물질을 녹이는 물질을 말한다.",
                Answer = "용매"
            },

            new QuestSet
            {
                Quest = "A는 소금물이나 설탕물처럼 두 가지 이상의 물질이 골고루 섞여있는 물질이다. 즉 두 가지 이상의 순수한 물질이 균일하게 섞여있는 균일혼합물이다.",
                Answer = "용액",
                Reference = "cf) ① 서로 섞이는 물질의 상태는 상관없는데, 초등학교 수준에서는 용질이 고체, 용매가 액체인 경우를 다룬다. ② (물질 상태 상관 없이) 양 많은 물질 = 용매, 양 적은 물질 = 용질, ③ 불균일 혼합물은 용액이 아니다."
            },

            new QuestSet
            {
                Quest = "다음은 소금, 분말 주스(시트르산), 나프탈렌이라는 3가지의 용질을 물과 아세톤이라는 2가지 용매에 녹인 결과이다. 소금과 분말주스는 물에 A. 반면 나프탈렌은 물에 B. 소금은 아세톤에 C. 분말주스와 나프탈렌은 아세톤에 D.",
                Answer = "녹는다, 녹지 않는다, 거의 녹지 않는다, 조금 녹는다"
            },

            new QuestSet
            {
                Quest = "소금이 물에는 잘 녹지만 아세톤에는 녹지 않는 까닭은 소금은 A이고, 아세톤은 B인 용매이기 때문이다.",
                Answer = "극성 물질, 약간 극성",
                Reference = "(소금의 염화이온-나트륨이온 사이의 인력) > (염화이온, 나트륨이온-아세톤 분자의 인력), (아세톤 분자 사이의 인력) > (염화이온, 나트륨이온-아세톤 분자 사이의 인력)"
            },

            new QuestSet
            {
                Quest = "시트르산(분말 주스)이 물에는 잘 녹고 아세톤에 약간 녹는 까닭은 시트르산 분자가 A의 B을 띠는 물질이기 때문이다.",
                Answer = "약간, 극성",
                Reference = "극성 용매인 물과 시트르산 분자 사이에는 강한 인력이 작용하여 잘 녹는다. 또한 약간의 극성을 띤 용매인 아세톤에도 잘 녹게 된다."
            },

            new QuestSet
            {
                Quest = "나프탈렌이 물에는 녹지 않고 아세톤에 약간 녹는 까닭은 나프탈렌이 전형적인 A이기 때문이다. 따라서 B인 물에는 거의 녹지 않으며, C의 D을 띤 아세톤에는 조금 녹는다.",
                Answer = "무극성 물질, 극성 용매, 약간, 극성",
                Reference = "아세톤 분자와 나프탈렌 분자 사이에는 약한 인력이 작용한다. 반면 물 분자와 나프탈렌 분자 사이에는 인력이 작용하지 않는다."
            },

            new QuestSet
            {
                Quest = "분말 주스의 실험 결과를 용해, 용질, 용매, 용액이라는 낱말을 이용해 설명해봅시다.",
                Answer = "용질인 분말주스가 용매인 물에 잘 용해되어 서로 골고루 섞여 분말주스 용액이 되었다.",
                Reference = "분말주스 용액에서처럼 색깔이 있는 경우도 (투명하다면) 용액이라고 할 수 있다."
            },

            new QuestSet
            {
                Quest = "용액의 특성 'A', 'B', 'C' 3가지를 서술하시오.",
                Answer = "오래 두어도 가라앉거나 뜨는 것이 없다, 거름 장치로 걸러도 거름종이에 남는 것이 없다, 어느 부분이나 물질의 섞여 있는 정도가 같다",
                Reference = "조작적 차원에서 확인할 수 있는 특성이다."
            },

            new QuestSet
            {
                Quest = "멸치가루나 미숫가루는 용액이다. (O 아니면 X)",
                Answer = "X",
                Reference = "저었을 때는 물과 섞여 용액 같지만, 10분 정도 두면 가라앉는 것이 보인다."

            },

            new QuestSet
            {
                Quest = "'각설탕이 물에 A되기 전과 A된 후의 무게 비교하기' 실험에서는 물질이 없어진 것이 아님을 B하게 하는 활동에 중점을 두어 지도한다.",
                Answer = "용해, 추리"
            },

            new QuestSet
            {
                Quest = "POE모형을 적용하였을 때, 예상하기 단계에서는 각설탕이 물에 A과 B무게를 예상해본다. 관찰하기 단계에서는 각설탕이 물에 C과 D무게를 비교한다. 설명하기 단계에서는 용해 전후의 무게가 E 까닭을 F한다.",
                Answer = "용해되기 전, 용해된 후, 용해되기 전, 용해된 후, 같은, 추리"
            },

            new QuestSet
            {
                Quest = "각설탕이 물에 용해되기 전과 용해된 후의 무게가 변하지 않은 까닭은 A가 용해되기 전과 후에 변하지 않았기 때문이다.",
                Answer = "설탕의 입자 수"
            },

            new QuestSet
            {
                Quest = "'추리하기'를 POE 모형의 설명하기 단계에서 많이 쓰는 까닭을 서술하시오.",
                Answer = "설명하기 단계는 예상과 관찰 사이의 모순에 대해 설명해야 하기에 관찰한 것에 대해서 해석하고 설명해야 하기 때문이다."
            },

            new QuestSet
            {
                Quest = "만일 각설탕이 물에 용해되기 전후의 무게를 비교할 때 원하는 값이 나오지 않는 경우, 즉 오차가 생기는 경우 그 이유를 서술하시오.",
                Answer = "실험 도중 증발하는 물의 양이나 유리 막대로 저을 때 유리 막대에 묻는 물의 양 때문에 용해 후 무게가 줄어들었다고 생각할 수 있다."
            },

            new QuestSet
            {
                Quest = "소금이나 설탕이 물에 용해되면 물에 보이지 않는 까닭을 서술하시오.",
                Answer = "소금은 나트륨 이온과 염화 이온으로 나뉘어 물과 섞이고, 설탕은 설탕 분자로 나뉘어 물 분자와 섞이기 때문이다. 물에 섞인 이온이나 분자가 눈에 보이지 않는 것은 이들 입자의 크기가 매우 작기 때문이다."
            },

            new QuestSet
            {
                Quest = "'설탕이 물에 용해되면 용해되기 전보다 무게가 가벼워진다'는 오개념은 A 사고이다.",
                Answer = "현상 중심적"
            },

            new QuestSet
            {
                Quest = "'설탕이 물에 용해되면 용해되기 전보다 무게가 가벼워진다.' 오개념을 지도하는 방안을 서술하시오.",
                Answer = "설탕물의 맛을 보게 하여, 눈에 보이지는 않지만 설탕이 물 속에 용해되어 있음을 이해하도록 하며, 용질이 사라진 것이 아니라 물과 골고루 섞여있음을 이해시킨다.",
                Reference = "구체적 조작기 → 질량 보존의 개념 가지고 있음"
            },

            new QuestSet
            {
                Quest = "용해와 입자의 크기 : 어떤 용질이 용매에 녹으려면 A과 B의 인력이 C의 인력이나 D 사이의 인력보다 커야 한다.",
                Answer = "용질, 용매, 용질 입자, 용매 입자"
            },

            new QuestSet
            {
                Quest = "'물질이 물에 녹으면 무게가 어떻게 될까요?' 에 POE모형을 적용했을 때, 예상 단계의 활동을 서술하시오.",
                Answer = "용해 전후의 무게에 대한 학생들의 선행 개념이 드러나게 한다."
            },

            new QuestSet
            {
                Quest = "'물질이 물에 녹으면 무게가 어떻게 될까요?' 에 POE모형을 적용했을 때, 관찰 단계의 활동을 서술하시오.",
                Answer = "자신의 예상을 확인하기 위하여 설탕을 녹인 후 무게 변화를 측정하는 실험을 함으로써 인지 갈등 유발"
            },

            new QuestSet
            {
                Quest = "'물질이 물에 녹으면 무게가 어떻게 될까요?' 에 POE모형을 적용했을 때, 설명 단계의 활동을 서술하시오.",
                Answer = "자신의 예쌍과 관찰 결과를 비교하고, 결과에 대해 설명함으로써 인지 갈등이 해결된다."
            },

            new QuestSet
            {
                Quest = "'각설탕이 물에 용해되는 과정 관찰하기'에서는 POE모형을 사용하는데, '예상' 단계에서 생길 수 있는 오개념을 서술하시오.",
                Answer = "설탕은 물에 녹으면 사라진다.",
                Reference = "현상 중심적 사고"
            },

            new QuestSet
            {
                Quest = "'물질이 물에 녹으면 무게가 어떻게 될까요?' 차시에서 POE모형을 사용할 때, 인지 갈등 상황이 해결되는 단계는 A 단계이다.",
                Answer = "설명",
                Reference = "Explanation"
            },

            new QuestSet
            {
                Quest = "A는 물질의 성질을 가진 가장 작은 알갱이인 분자를 대신하여 초등학교 교육과정에서 부르는 용어이다.",
                Answer = "입자"
            },

            new QuestSet
            {
                Quest = "물질이 용해되면 어떻게 되는지 서술하시오.",
                Answer = "물질이 없어지는 것이 아니라 더 작은 입자로 나누어져 용매에 골고루 섞여 용액이 된다."
            },

            new QuestSet
            {
                Quest = "'용해 전후의 무게 예상하기' 실험과 피아제의 인지 발달론을 연결지어 설명하시오.",
                Answer = "이 실험은 '질량 보존 개념(용해 전 무게 = 용해 후 무게)'을 가지고 있는 가에 대한 것이다. 대부분의 5학년 학생들은 구체적 조작기에 해당되므로 용해 전후의 무게가 변함이 없다는 것을 알고 있을 것이다. 설탕이 없어져서 무게가 가벼워진다고 생각하는 학생은 질량 보존 개념이 형성되어있지 않다고 볼 수 있다.",
                Reference = "구체적 조작기 : '가역적 사고'를 바탕으로 '보존 개념' 형성함"
            },

            new QuestSet
            {
                Quest = "소금과 같은 이온성 물질이나 설탕과 같은 분자성 고체가 물에 녹는 과정을 서술하시오.",
                Answer = "물에 소금을 넣으면 나트륨이온이나 염화이온은 물 분자에 강하게 이끌려 떨어져 나온 후, 물 분자에 둘러싸여 물에 퍼진다. 설탕 사이의 인력보다 설탕 분자와 물 분자 사이의 인력이 크므로 쉽게 녹는다.",
                Reference = "수화 : 물질을 구성하는 입자가 용매인 물로 둘러싸이는 현상"
            },

            new QuestSet
            {
                Quest = "각설탕이 용해될 때 아지랑이가 나타나는 까닭을 서술하시오.",
                Answer = "각설탕이 물에 녹으면 설탕 주위의 물은 다른 부분의 물보다 밀도가 조금 높아진다. 따라서 설탕이 녹은 물은 주변으로 퍼지게 되고 그 부분을 통과하는 빛이 굴절되어 아지랑이처럼 보인다.",
                Reference = "빛의 굴절 : 밀도가 다른 곳을 지날 때(한 물질에서 다른 물질을 만날 때) 빛의 경로가 꺾이는 것"
            },

            new QuestSet
            {
                Quest = "A는 물질이 가지고 있는 고유한 양을 의미하지만 B는 물체에 작용하는 중력의 크기를 의미한다.",
                Answer = "질량, 무게",
                Reference = "이 차시에서는 질량과 무게를 구분하지 않고 용해되기 전과 용해된 후의 입자의 개수가 동일하므로 질량(무게)도 변하지 않는다는 수준으로 지도한다."
            },

            new QuestSet
            {
                Quest = "5-1-4. 용해와 용액 성취기준 : [6과03-02] A에 따라 B이 달라짐을 비교할 수 있다.",
                Answer = "용질의 종류, 물에 녹는 양"
            },

            new QuestSet
            {
                Quest = "'용질의 종류에 따라 물에 녹는 양이 달라짐을 비교할 수 있다.' 에서 독립변인은 A이고 종속변인은 B이다.",
                Answer = "용질의 종류, 물에 녹는 양"
            },

            new QuestSet
            {
                Quest = "소금, 설탕, 베이킹소다를 온도와 양이 같은 물에 용해되는 양을 비교한 실험의 결과를 서술하시오.",
                Answer = "물의 온도와 양이 같을 때 용질마다 물에 용해되는 양이 서로 다르다."
            },

            new QuestSet
            {
                Quest = "설탕, 백반, 붕산을 물에 더 녹이고 싶다면 어떻게 해야 할까?",
                Answer = "물을 더 넣거나 온도를 높이면 된다."
            },

            new QuestSet
            {
                Quest = "소금은 온도를 높일수록 아주 많이 녹는다. (O 아니면 X)",
                Answer = "X"
            },

            new QuestSet
            {
                Quest = "A는 어떤 온도에서 용매 100g 속에 최대로 녹아있는 (포화 상태인) 용질의 g 수이다.",
                Answer = "용해도"
            },

            new QuestSet
            {
                Quest = "설탕이내 백반, 붕산과 같은 물질의 경우 A에 따라 B 변화가 크다. 그러나 소금은 A가 변하여도 B가 거의 일정하므로 A에 따른 B 차이가 매우 적다. 따라서 활동을 마친 뒤에 백반처럼 물의 A에 따라 물에 녹는 양의 차이가 큰 물질도 있고, 소금처럼 물에 녹는 차이가 작은 물질도 있다는 것을 이해하도록 한다.",
                Answer = "온도, 용해도",
                Reference = "→ 백반 실험 후 모든 물질이 온도가 높아지면 용해도가 증가한다고 일반화시키면 안 된다."
            },

            new QuestSet
            {
                Quest = "백반, 붕산, 소금을 용해도 순(기울기 차이 순서)으로 나열하면 A > B > C이다.",
                Answer = "백반, 붕산, 소금"
            },

            new QuestSet
            {
                Quest = "용질이 A에서 용해도만큼 B 상태를 C라고 한다. 용질이 더 이상 용해되지 않는 가장 진한 용액은 D라고 한다.",
                Answer = "어떤 온도, 최대한 용해, 포화 상태, 포화 용액"
            },

            new QuestSet
            {
                Quest = "일정한 양의 용매에 녹는 용질의 양이 일정한 까닭은 물질을 용해시키는 A의 입자의 수가 B이기 때문이다.",
                Answer = "용매, 한정적",
                Reference = "따라서 물을 더 부으면 용매 입자수가 증가해서 더 많이 녹일 수 있다."
            },

            new QuestSet
            {
                Quest = "온도에 따라 얼마나 많이 녹는지 실험하고 싶다면, 실험 대상으로 부적절한 용질(독립변인)은?",
                Answer = "소금",
                Reference = "소금은 온도에 따른 용해도 차이가 크지 않다."
            },

            new QuestSet
            {
                Quest = "A이란 고체 입자가 규칙적으로 배열되어 특별한 형태를 가지는 것이다.",
                Answer = "결정"
            },

            new QuestSet
            {
                Quest = "결정은 A을 통해 만들거나 물을 B시켜 만든다. 또한 물질의 특성이 될 수 C.",
                Answer = "포화용액, 물, 있다."
            },

            new QuestSet
            {
                Quest = "소금의 결정 모양은 A 모양이고 백반의 결정 모양은 B 모양이다.",
                Answer = "정육면체, 정팔면체"
            },

            new QuestSet
            {
                Quest = "포화상태에서 A를 서서히 내리면 결정이 석출된다.",
                Answer = "온도",
                Reference = "소금의 경우 온도에 따른 용해도 차이가 크지 않아 증발을 시켜 결정을 석출한다."
            },

            new QuestSet
            {
                Quest = "5-1-4. 용해와 용액 성취기준 : [6과03-03] 물의 A에 따라 B이 달라짐을 실험할 수 있다.",
                Answer = "온도, 용질의 녹는 양"
            },

            new QuestSet
            {
                Quest = "물의 온도에 따라 백반이 용해되는 양 비교하기 실험에서 알 수 있는 것은, 물의 A가 높으면 백반이 더 많이 B된다는 사실이다. 이 실험에서 군마다 다르게 해야할 조건(C변인)은 물의 A이고, 같게 해야 할 조건(D변인)은 E, F 등이다.",
                Answer = "온도, 용해, 독립, 통제, 백반의 양, 물의 양"
            },

            new QuestSet
            {
                Quest = "따뜻한 물에서 모두 용해된 백반 용액이 든 비커를 얼음물에 넣으면 어떻게 되는지 서술하시오.",
                Answer = "백반 알갱이가 다시 생긴다. 즉 정팔면체 모양 결정이 석출된다."
            },

            new QuestSet
            {
                Quest = "모든 물질은 온도가 높을 수록 용해도가 높아진다. (O 아니면 X)",
                Answer = "X"
            },

            new QuestSet
            {
                Quest = "'모든 물질은 온도가 높을 수록 용해도가 높아진다.'의 예외적 물질은 A와 B이다.",
                Answer = "수산화칼슘, 수산화나트륨",
                Reference = "이들은 온도가 높아질수록 용해도가 낮아지는 용질이다. 왜냐하면 녹으면서 주변으로 열을 방출하기 때문이다. 둘 다 녹을 때 발열반응을 하는 물질이다."
            },

            new QuestSet
            {
                Quest = "대부분 기체는 온도가 A 때 용해도가 높아진다.",
                Answer = "낮을"
            },

            new QuestSet
            {
                Quest = "물의 온도와 용질의 용해 : 일반적으로 물의 온도가 높아질수록 물질의 용해도가 높아지는 것은 입자의 A로 설명할 수 있다. 입자의 A은 온도가 높아질 수록 증가한다. A가 큰 물 입자가 활발하게 운동하여 더 많은 용질 입자와 잘 섞인다. 따라서 온도가 높으면 고체 용질의 용해도가 증가한다.",
                Answer = "운동 에너지"
            },

            new QuestSet
            {
                Quest = "용매를 빨리 저을수록 용질이 빨리 녹는 까닭을 서술하시오.",
                Answer = "가루 물질 등 녹는 물질의 입자 사이의 결합이 끊어져야 물에 녹을 수 있는데, 물질을 물에 넣은 뒤 저으면 물 입자와 서로 부딪히면서 가루 물질의 입자들이 쉽게 떨어질 가능성이 높아지므로 빨리 녹게 된다."
            },

            new QuestSet
            {
                Quest = "백반을 더 많이 용해하려면 빨리 저으면 된다. (O 아니면 X)",
                Answer = "X",
                Reference = "용질을 빨리 용해하는 것과 많이 용해하는 것이 다름을 이해시킨다."

            },

            new QuestSet
            {
                Quest = "백반을 더 많이 녹일 수 있는 (물질을 더 많이 녹일 수 있는) 방법 2가지를 서술하시오.",
                Answer = "물의 양을 증가한다, 온도를 높인다."
            },

            new QuestSet
            {
                Quest = "용질이 녹는 '속도'와 '양' 모두 관련된 변인은 A이다.",
                Answer = "온도"
            },

            new QuestSet
            {
                Quest = "알갱이의 크기와 상관 있는 변인은 A이다.",
                Answer = "녹는 빠르기"
            },

            new QuestSet
            {
                Quest = "용질이 녹는 빠르기(종속변인)의 영향을 주는 A, B, C 3가지 요인(실험의 독립변인)을 서술하시오.",
                Answer = "젓는 빠르기, 용질의 알갱이 크기, 용매의 온도",
                Reference = "물의 양은 해당되지 않는다."
            },

            new QuestSet
            {
                Quest = "A 변인은 실험 결과에 영향을 줄 수 있는 변인을 말한다. B 변인은 A 변인이 변함에 따라 얻어지는 결과, 즉 측정이나 관찰한 결과를 말한다. C 변인은 실험에서 조작하지 않고 통제하는 변인이다.",
                Answer = "독립, 종속, 통제"
            },

            new QuestSet
            {
                Quest = "용매를 빨리 저을 수록 용질이 빨리 녹는 까닭은, A이 끊어져야 물에 녹을 수 있기 때문이다.",
                Answer = "입자 사이의 결합"
            },

            new QuestSet
            {
                Quest = "물질을 물에 넣은 뒤 저으면 A와 서로 부딪히면서 B들이 쉽게 떨어질 가능성이 높아진다.",
                Answer = "물 입자, 가루 물질의 입자"
            },

            new QuestSet
            {
                Quest = "물을 저으면 A와 B를 잘 만나게 해주어 가루 물질이 더 빨리 녹게 된다.",
                Answer = "물 입자, 가루 물질의 입자"
            },

            new QuestSet
            {
                Quest = "용질의 알갱이 크기가 작을 수록 빨리 녹는 까닭은 다음과 같다. 물 입자와 충돌할 수 있는 A이 넓은 가루의 형태가 상대적으로 A이 작은 덩어리보다 물에 빨리 녹게 된다.",
                Answer = "표면적"
            },

            new QuestSet
            {
                Quest = "일정한 양의 용매에 용질이 녹는 양이 일정한 까닭은 A가 한정되어 있기 때문이다.",
                Answer = "용매 입자의 수",
                Reference = "물 입자의 수는 한정되어 있는데, 물 속에 들어온 물질 입자의 수가 계속하여 많아지면 더 이상 물 입자와 물질 입자가 서로 끌어당겨 물에 녹을 수 없다. 물 입자의 수가 부족하기 때문이다. 따라서 이 경우에는 물을 더 넣어주어야 녹지 않고 남아있던 물질을 녹일 수 있다."

            },

            new QuestSet
            {
                Quest = "용매의 온도가 높을 수록 용질이 빨리 녹는 까닭은 온도를 높이면 A이 활발해져 서로 붙어 있던 작은 알갱이들이 쉽게 떨어지기 때문이다.",
                Answer = "입자들의 운동",
                Reference = "온도가 높으면 빨리 녹기도 하지만 많이 녹기도 한다."
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
            }








        };
    }
}
