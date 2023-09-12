using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 초등임용복습프로그램
{
    class Model
    {
        public static List<ModelSet> korean_modelset = new List<ModelSet>
        {
            new ModelSet
            {
                name = "국어과 핵심 역량",
                model = {"공동체·대인관계 역량","자기 성찰 계발 역량", "자료 정보 활용 역량", "문화 향유 역량", "비판적·창의적 사고 역량", "의사소통 역량"},
                chunk = "(공)(대)생이 (자기)(성)기 (발)기 시켜서 (자)(정)에 (활용)하려는데 여성분 : (문)(향)기야? 역겨워; (비)(창)해진 남자.. (의사) 찾아가야겟다 ㅠㅠ"
            },

            new ModelSet
            {
                name = "국어 - 창의성 계발 학습 모형",
                model = {"문제 발견하기","아이디어 생성하기", "아이디어 선택하기", "아이디어 적용하기"},
                chunk = "(고양이 입장에서) 오늘은 (발견)한 (생)(선)이 (적)당 ㅠㅠ"
            },

            new ModelSet
            {
                name = "국어 - 지식 탐구 학습 모형",
                model = {"문제 확인하기","자료 탐색하기", "지식 발견하기", "지식 적용하기"},
                chunk = "임고공부가 하기 싫을 때는 (확)! (자)(발)(적)으로 지식을 탐구해버려!"
            },

            new ModelSet
            {
                name = "국어 - 역할 수행 학습 모형",
                model = {"상황 설정하기","준비 및 연습하기", "실연하기", "평가하기"},
                chunk = "니가 역할을 수행할 때마다 (상)을 준 건 모두 네 (실)력을 (평가) 하기 위해서였다."
            },

            new ModelSet
            {
                name = "국어 - 가치 탐구 학습 모형",
                model = {"문제 분석하기","가치 확인하기", "가치 평가하기", "가치 일반화하기"},
                chunk = "(분)하다! 달력을 (확인)하니 오늘은 (평)(일)ㅠㅠ"
            },

            new ModelSet
            {
                name = "과정 중심 읽기 지도 - 읽기 전",
                model = {"읽는 목적 설정하기","배경지식 활성화하기", "얼른 살펴보기", "예측하기", "읽는 방법 설정하기", "읽고 싶은 마음 가지기"},
                chunk = "읽기 전 - (목)(배) (얼)굴(살) (예)(방)(마)"

            },

            new ModelSet
            {
                name = "과정 중심 읽기 지도 - 읽기 중",
                model = {"점검하기","집중하여 읽기", "추론하기", "사실여부 판단하기", "연결관계 파악하기", "연상/상상하기", "예측한 내용 확인하기", "구조 파악하기", "질문하기", "되새기며 읽기", "중심내용 파악하기"},
                chunk = "(점)(집)(추) (사)(연) (연상)(예)인이 (구)(질)(되)(중)? 점집 추천 받고 가서 사연을 이야기함, 무당 왈 연상 애인이 구질되죠?"
            },

            new ModelSet
            {
                name = "과정 중심 읽기 지도 - 읽기 후",
                model = {"요약 또는 중요한 내용 메모하기","독서 감상문 쓰기","글의 주제 찾기", "협의·토론하기", "다른 갈래로 바꾸어보기", "비평하기"},
                chunk = "(요)(중)(메) (독)(주)(토)? (갈)(비) : 요즘에 독주(혼자 술)하고 토한다면서요? 몸보신하게 갈비드세요~"
            },

            new ModelSet
            {
                name = "과정 중심 쓰기 지도",
                model = {"글의 조건이나 형태 분석하기","글쓰기 계획 세우기", "글을 쓰는 목적 생각하기"},
                chunk = "(조)(형)(태) (계)(세) 시키려는 (목적)"
            },

            new ModelSet
            {
                name = "아이디어 생성하기",
                model = {"경험하기","일지쓰기","읽기","열거하기","이야기 나누기","생각그물 만들기","자유연상하기", "명상하기"},
                chunk = "성(경험) (일지) (읽)어보니까 (열)라 (야)한 (생각)많이 하기로 (자)(명)"
            },

            new ModelSet
            {
                name = "아이디어 조직하기",
                model = {"얼개짜기(개요작성)","다발짓기"},
                chunk = "(얼) ~~ (다발)"
            },

            new ModelSet
            {
                name = "표현하기",
                model = {"말로쓰기(구두작문)","내리쓰기(얼른쓰기)", "문장 쓰기 전략 활용하기"},
                chunk = "(말)을 (내리) 쏟아 붓는 중! 하지만 거세 기구는 (장전) 됨"
            },

            new ModelSet
            {
                name = "수정하기",
                model = {"의미지도 그리기","훑어 읽기", "돌려 읽기"},
                chunk = "실낱같은 (의지)를 갖고 (훑)..ㅠㅠㅠ 내 고추 (돌려)줘!!! 빼액!"
            },

            new ModelSet
            {
                name = "조정하기",
                model = {"자기 조정하기","출판하기/작품화하기"},
                chunk = "(자)(조)적인 글을 (출판)해서 (작품화)했다."
            },

            new ModelSet
            {
                name = "어휘 지도 방법",
                model = {"국어사전 찾기를 통한 지도", "문맥이나 상황 등 맥락 활용지도", "의미 자질 분석법", "의미 구조도 그리기", "의미 지도 그리기를 통한 지도", "낱말 구조 분석을 통한 지도", "말놀이를 통한 지도"},
                chunk = "(국)(문)(의자)(구조)(지도)(낱(말)놀이)"
            },

            new ModelSet
            {
                name = "듣기·말하기 평가 방법",
                model = {"구술법","질문지법", "일화기록법", "관찰기록법", "지필법", "포트폴리오법", "녹화기록법"},
                chunk = "(구)(질)구질한 (일)(관)(지)(포)로 (녹)인다."
            },

            new ModelSet
            {
                name = "읽기 평가 방법",
                model = {"선다형","진위형", "서답형", "빈칸 메우기 검사", "오독 분석법", "중요도 평정법", "프로토콜 분석법"},
                chunk = "(선)(진)(서)의 (빈)(오)(중)(프)"
            },

            new ModelSet
            {
                name = "쓰기 평가 방법",
                model = {"선다형 평가","논술형 평가(분석, 총체, 주요 특질 평가)", "프로토콜 분석법", "과정상 질문법", "오필 분석법"},
                chunk = "(선)(논)(프)(과)(오)"
            },

            new ModelSet
            {
                name = "독서 생활화를 위한 독서 수업 아이디어",
                model = {"교실 환경 조성하기","소리내어 읽기", "연극과 극화하기", "독서 모델로서의 교사", "과정 독서 지도", "출판하기", "독서 수업에서 경쟁을 활용할 때 주의할 점"},
                chunk = "(교)(소)(연)(모델)(과정)(출판)(경쟁)"
            },

            new ModelSet
            {
                name = "독서 동기 촉진하기",
                model = {"몰입","시범", "기대", "책임", "사용","유사성","반응"},
                chunk = "(몰)(시)(기)(책)(사)(유)(반)"
            },

            new ModelSet
            {
                name = "듣기·말하기 내체표 기능",
                model = {"상호 교섭하기","추론하기","평가·감상하기","청자 분석하기","내용 생성하기", "내용 조직하기","맥락 이해·활용하기", "자료·매체 활용하기", "표현·전달하기", "내용 확인하기"},
                chunk = "(상)(추)가 (평)(청)에서 (내)(내) (맥)주 마시다 (자)(표)(내)"
            },

            new ModelSet
            {
                name = "읽기 내체표 기능",
                model = {"맥락 이해하기","몰입하기","내용 확인하기","독서 경험 공유하기","점검·조정하기","추론하기", "성찰·공감하기", "비판하기", "통합·적용하기"},
                chunk = "(맥)주를 (몰)(내) (독)(점)했더니 (추)(성)훈이 (비)(통)해 하였다."
            },

            new ModelSet
            {
                name = "쓰기 내체표 기능",
                model = {"맥락 이해하기","독자 분석하기", "아이디어 생산하기", "글 구성하기", "자료·매체 활용하기", "표현하기", "고쳐쓰기", "독자와 교류하기", "점검·조정하기"},
                chunk = "(맥)주를 (독)점한 (아이)가 (글)(자)가 쓰인 (표)(고)버섯을 (교류)하고 (점검)했다."
            },

            new ModelSet
            {
                name = "문학 내체표 기능",
                model = {"감상·비평하기","성찰·향유하기", "몰입하기", "이해·해석하기", "공유·소통하기","모방·창작하기", "점검·조정하기"},
                chunk = "(감)(성)(몰)(이) (공)(모)(점)"
            },

            new ModelSet
            {
                name = "직접 교수법",
                model = {"설명하기","시범 보이기", "질문하기", "활동하기"},
                chunk = "(설)(범)(문)(활)"
            },

            new ModelSet
            {
                name = "반응 중심 학습법",
                model = {"반응 준비하기","반응 형성하기", "반응 명료화하기", "반응 심화하기"},
                chunk = "(준)(형)(명)(심)"
            },

            new ModelSet
            {
                name = "전문가 협동학습 모형",
                model = {"계획하기","탐구하기","서로 가르치기", "발표 및 정리하기"},
                chunk = "(계)(탐)(서)(발)"
            },

            new ModelSet
            {
                name = "국어 어휘지도 방법 6가지",
                model = {"국어사전찾기","맥락활용지도","의미관계 비교", "낱말구조 분석", "의미지도 그리기", "말놀이"},
                chunk = "(사)(맥)(관비)(낱구)(지)(말) - 소맥건배 남기지마"
            },

            /*new ModelSet
            {
                name = "국어 표준 발음 지도 내용 (오류 내용)",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            }*/
        };

        public static List<ModelSet> pracCourse_modelset = new List<ModelSet>
        {
            new ModelSet
            {
                name = "",
                model = {"",""}
            }
        };

        public static List<ModelSet> math_modelset = new List<ModelSet>
        {
             new ModelSet
            {
                name = "수학 - 개념 학습 모형",
                model = {"범례 제시 및 범례 분류하기", "공통의 성질 추상화하기", "개념 정의하기", "개념 익히기"},
                chunk = "(범)수네 (공)통주택에는 (추)성훈이 (개)(정)색하고 고기를 (익히)고 있다."
            },

            new ModelSet
            {
                name = "수학 - 원리 탐구 학습 모형",
                model = {"새로운 문제 상황 제시", "수학적 원리의 필요성 인식", "수학적 원리가 내재된 조작 활동", "수학적 원리의 형식화", "수학적 원리 익히기 및 적용하기"},
                chunk = "(새) (필)통이 (조)(형)(적)으로 아름답구나"
            }
,

            new ModelSet
            {
                name = "수학 - 귀납 추론 학습 모형",
                model = {"사례 수집 및 관찰 실험", "추측하기", "추측의 검증", "일반화 및 정당화"},
                chunk = "(사)랑스러운 (추)사랑과 아빠 (추)성훈은 (일)본사람"

            }
,

            new ModelSet
            {
                name = "수학 - 문제 해결 학습 모형",
                model = {"문제의 이해", "해결 계획의 수립", "해결 계획의 실행", "반성"}
            },

            new ModelSet
            {
                name = "브루너의 학습 이론",
                model = {"구성의 원리","표현의 원리","대조와 다양화의 원리", "연결성의 원리"},
                chunk = "(구)준(표) (대)가리 (연)두색"
            },

            new ModelSet
            {
                name = "수학의 가치",
                model = {"도야적 가치","실용적 가치", "문화적 가치", "심미적 가치"},
                chunk = "(도)서(실)(문)을 (미)친듯이 두드려라"
            },

            new ModelSet
            {
                name = "2015 개정 수학과 교육과정 평가 방법",
                model = {"지필 평가","프로젝트 평가", "포트폴리오 평가", "관찰 평가", "면담 평가", "구술 평가", "자기 평가", "동료 평가"},
                chunk = "(필)시 (프로)(포)즈는 서로 (구)(면)인 (관)계에서 (자)(동)으로 성공한다."
            },

            new ModelSet
            {
                name = "딘즈 수학 개념학습",
                model = {"자유놀이 단계","게임 단계", "공통성 탐색 단계","표현 단계","기호화의 단계","형식화의 단계"},
                chunk = "(자)신이 (게)이임을 (공)(표)한 (기)(형)이!"
            },

            new ModelSet
            {
                name = "각론 - 자연수의 의미",
                model = {"집합수","순서수","이름수"},
                chunk = "자연수는 (집)(순)(이)"
            },

            new ModelSet
            {
                name = "각론 - 수 세기 원리",
                model = {"추상의 원리","안정된 순서의 원리", "집합수의 원리", "순서 무관의 원리", "일대일 대응의 원리"},
                chunk = "(추)천 (안)한 (집)(순)(일)이"
            },

            new ModelSet
            {
                name = "각론 - 수 세기 전략",
                model = {"이어 세기","거꾸로 세기", "묶어 세기", "뛰어 세기"},
                chunk = "(이)(거) (묶)고 (뛰)어"
            },

            new ModelSet
            {
                name = "각론 - 기수법",
                model = {"위치적 기수법","승법적 기수법", "가법적 기수법"},
                chunk = "(위)(승)이에게 (가)"
            },

            new ModelSet
            {
                name = "폴리아의 문제 해결 전략 10가지",
                model = {"목록 만들기","표 만들기", "식 만들기", "단순화하기", "그림 그리기", "거꾸로 풀기", "논리적 추론", "예상과 확인", "규칙 찾기", "실제로 해보기"},
                chunk = "(목)(표) (식)(단) (그)(거)(논)(예) 아무 (규)(실)도 못합니더."
            },

            /*new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            }*/
            
        };

        public static List<ModelSet> science_modelset = new List<ModelSet>
        {
           new ModelSet
            {

                name = "과학 - 발견 학습 모형",
                model = {"탐색 및 문제 파악", "자료 제시 및 관찰 탐색", "추가 자료 제시 및 관찰 탐색","규칙성 발견 및 개념 정리","적용 및 응용"},
                chunk = "경찰 : 저기요 ~ 저 (탐문)좀 하겠습니다. (자), (관찰)할게요~ 근데 (규)가 (발개정)네요? 침입자 : 제가 이런 거 (적)(응)이 안 되어서요."

            },

            new ModelSet
            {
                name = "과학 - 경험 학습 모형",
                model = {"자유 탐색","탐색 결과 발표","교사의 안내에 따른 탐색","탐색 결과 정리"},


            },

            new ModelSet
            {
                name = "과학 - 탐구 학습 모형",
                model = {"탐색 및 문제 파악", "가설 설정", "실험 설계", "실험", "가설 검증", "적용 및 새로운 문제 발견"}
            },

            new ModelSet
            {
                name = "과학 - 순환 학습 모형",
                model = {"탐색", "개념 도입", "개념 적용"}
            },

            new ModelSet
            {
                name = "과학 - POE모형",
                model = {"예상", "관찰", "설명"}
            },

            new ModelSet
            {
                name = "과학 - 5E모형",
                model = {"참여", "탐색", "설명", "정교화", "평가"}
            },

            new ModelSet
            {
                name = "과학 - 개념 변화 학습 모형",
                model = {"개념 표현", "개념 재구성", "@명료화, 교환", "@갈등 상황 경험", "@새로운 개념 구성", "@새로운 개념 평가", "개념 응용", "개념 변화 검토" },
                chunk = "불이타활"

            },

            new ModelSet
            { 
                name = "과학 교과 역량",
                model = {"과학적 사고력","과학적 탐구 능력", "과학적 문제 해결력", "과학적 의사소통능력", "과학적 참여와 평생 학습 능력"},
                chunk = "(사)(탐)(문)(의)(참)~"
            },

            new ModelSet
            {
                name = "오개념 유형",
                model = {"현상 중심적 사고","제한적 사고","변화 중심적 사고", "단순 인과적 사고", "미분화된 개념", "상황 의존적 사고"},
                chunk = "(현)(중)아... (제한적)으로 (변)(중)(단)하고 (미)(개)(상)타자"
            },

            new ModelSet
            {
                name = "기초 탐구 기능",
                model = {"예상","분류","추리","의사소통","관찰","측정"},
                chunk = "(예)(분)(추)(의)(관)(측) - 예쁜 추의 관측"
            },

            new ModelSet
            {
                name = "통합 탐구 기능",
                model = {"문제 인식","가설 설정","변인 통제","자료 변환","자료 해석", "결론 도출", "일반화"},
                chunk = "(제)(가) (인)(자) (료)(론)(일) 없게 하겠습니다 ㅠ"
            }


        };

        public static List<ModelSet> socialStudy_modelset = new List<ModelSet>
        {
            new ModelSet
            {
                name = "사회과 핵심 역량",
                model = {"창의적 사고력","문제 해결력 및 의사 결정력", "의사소통 및 협업 능력", "정보 활용 능력", "비판적 사고력"},
                chunk = "(창)(문)(의) (의)(협)(정)(비)"
            },
            
            new ModelSet
            {
                name = "기능",
                model = {"탐구 능력","정보 활용 능력", "의사결정 능력", "사회참여 능력"},
                chunk = "탐정의사"
            },

            new ModelSet
            {
                name = "고급 사고력의 종류",
                model = {"메타인지","비판적 사고력", "의사 결정 능력", "탐구 능력"},
                chunk = "(메)(비)우스의 (창)(의)력이 (탐)난다"
            },

            new ModelSet
            {
                name = "사회과 하위 목표",
                model = {"가치","태도", "지식", "기능"},
                chunk = "(가)(태)(지)(기)"
            },

            new ModelSet
            {
                name = "지리적 사고력",
                model = {"관계적 사고력","분포적 사고력", "지역적 사고력"},
                chunk = "관포지"
            },

            new ModelSet
            {
                name = "사회과 역사 영역의 지도 - 시간 인지 발달단계",
                model = {"시원 의식","고금 의식", "대비 의식", "변천 의식", "인과 의식", "시대 의식"},
                chunk = "(시원)하(금) (대)(변)(과)(시)!"
            },

            new ModelSet
            {
                name = "속성 모형",
                model = {"문제 제기","속성 제시와 정의", "속성 검토", "사례(예/비례) 검토", "가설 검증", "개념 분석", "관련 문제 검토", "평가"},
                chunk = "(제)(정)이 열악하여 (검)(사)에게 (가)(개)부를 (분석)받았다. 검사는 (문제)를 (검토)하고 (평가함)!"
            },

            new ModelSet
            {
                name = "원형 모형",
                model = {"문제 제기","개념의 원형과 정의 제시", "비례 제시", "속성 검토", "개념 분석", "관련 문제 검토", "평가"},
                chunk = "(원)(정)을 떠난 줄 알았던 (비)는 사실 (속)(토)로 갔다고 한다."
            },

            new ModelSet
            {
                name = "상황 모형",
                model = {"문제 제기","관련된 상황 또는 경험 제시", "개념의 예와 비례 제시", "속성 검토 및 개념 정의", "개념 분석", "관련 문제 검토", "평가"},
                chunk = "(관)(상)을 본 (경험)이 (개)(예)(속!) (개)(정)되는 중이다."
            },

            new ModelSet
            {
                name = "마시알라스 콕스 탐구 학습 모형",
                model = {"탐구 문제 파악","가설 설정", "탐색", "증거 제시", "일반화"},
                chunk = "(파)(가)(색)(기) (증)(일) 탐구만 하냐?"
            },

            new ModelSet
            {
                name = "뱅크스 탐구 학습 모형",
                model = {"문제 제기","가설 설정", "용어 정의 및 개념화", "자료 수집", "자료 분석", "가설 검증 및 일반화"},
                chunk = "(제)(가)(용) (집)구(석)에서 (증)(일)탐구만 해요"
            },

            new ModelSet
            {
                name = "문제 해결 학습 모형",
                model = {"문제 확인","문제 발생 원인 파악", "문제 해결 방안 탐색", "문제 해결 방안 결정", "문제 해결 방안 실천"},
                chunk = "(확)(원)에서 (해)법(탐)구를 푼 게 (결)(실)을 맺었다."
            },

            new ModelSet
            {
                name = "논쟁 문제 학습 모형",
                model = {"문제 제기","개념의 명확화", "사실의 경험적 확인", "가치 갈등의 해결(대립 가치 분석)", "대안 모색 및 결론"},
                chunk = "(제)(명)에 못 살고 (사)(경)을 헤매려고 (가)(해)자랑 (대)(결)하고 논쟁하냐?"
            },

            new ModelSet
            {
                name = "합리적 의사 결정 모형",
                model = {"문제 제기","사회 탐구", "@가설 설정","@자료 수집","@자료 분석","@가설 검증","가치 탐구","@가치 문제 및 가치 갈등 확인","@대안의 검토와 결과 예측","@가치 선택","의사결정(대안 검토와 결과 예측)","행동"},
                chunk = "(제)(사)(가) (의)(결)됨! (행동)"
            },

            new ModelSet
            {
                name = "사회탐구",
                model = {"가설 설정","자료 수집", "자료 분석", "가설 검증"},
                chunk = "(제사할때 어르신이 명령) (가설) (수)(분)이 얼마나 되는지 (검증)해봐!!"
            },

            new ModelSet
            {
                name = "의사 결정 매트릭스 모형",
                model = {"문제 정의","대안 나열", "선택 기준 작성", "대안 평가", "의사 결정"},
                chunk = "(문)헌(정)보학과 (대)(나)무숲에서 (선)(기)(작)(대)라는 (평가)가 나오자(의사결정)"
            },

            new ModelSet
            {
                name = "STAD 집단 성취 분담 모형",
                model = {"집단(모둠)구성","교사의 수업 안내와 학습지 배부","집단(모둠)학습", "학습지 작성 및 정답지 확인", "개별 평가 및 집단(모둠)보상"},
                chunk = "(집)(수학)(집)(작정)(개집) 집-수학-집 작정하고 공부하는 계집이구만!"
            },

            new ModelSet
            {
                name = "역사적 사고력",
                model = {"연대기적 파악력","역사적 탐구력", "역사적 상상력", "역사적 판단력"},
                chunk = "연탐상단"
            },

            new ModelSet
            {
                name = "극화학습, 모의학습 적용 수업 예시",
                model = {"상황 설정","역할분담", "실행 규칙", "실시", "반성"},
                chunk = ""
            },

            new ModelSet
            {
                name = "논쟁 문제 수업에서의 교사의 역할 (켈리)",
                model = {"배타적 중립형","배타적 편파형","신념을 가진 공정형", "중립적 공정형"},
                chunk = "(배중)에서 어떤 (배편)을 탈지 (신)(중)해야 한다."
            },

            new ModelSet
            {
                name = "논쟁 문제 수업에서의 교사의 역할 (하우드)",
                model = {"공정한 의장형","신념형", "관심형", "객관형", "악마 옹호형", "옹호형"},
                chunk = "(공)부의 (신) (관)(객) (악)수 포(옹)"
            },

            new ModelSet
            {
                name = "각론 - 지도의 기본 요소 ",
                model = {"방위표","기호와 범례", "등고선", "축척"},
                chunk = "(방)(기)(범) (등)(척)! (방귀범을 등쳐!)"
            },

            new ModelSet
            {
                name = "국민의 의무",
                model = {"국방의 의무","교육의 의무", "납세의 의무", "근로의 의무", "환경보전의 의무", "재산권 행사의 의무"},
                chunk = "(국)(교)(세)(로)(보)(재)"
            },

            new ModelSet
            {
                name = "국민의 기본권",
                model = {"참정권","사회권", "자유권","평등권","청구권"},
                chunk = "참사자평청"
            },

            new ModelSet
            {
                name = "민주적 의사결정 원리",
                model = {"소수 의견 존중","다수결의 원칙", "대화와 타협"},
                chunk = "(소)(다)(대)(타) -DJ Soda의 대타"
            },

            new ModelSet
            {
                name = "민주주의의 기본 정신",
                model = {"존엄","자유", "평등"},
                chunk = ""
            },

            new ModelSet
            {
                name = "민주선거의 기본원칙",
                model = {"평등선거","직접선거", "비밀선거","보통선거"},
                chunk = "(평)(직)원의 (비)(보)"
            },

            /*new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            }*/
        };

        public static List<ModelSet> art_modelset = new List<ModelSet>
        {
            new ModelSet
            {
                name = "",
                model = {"",""}
            }
        };

        public static List<ModelSet> ethics_modelset = new List<ModelSet>
        {
            new ModelSet
            {
                name = "도덕 - 초등 도덕과 수업의 기본적 과정·절차",
                model = {"도입(문제의식화)","@도덕적 문제 의식 갖기", "@학습 동기 일으키기", "@학습 문제 인식하기","인지적 접근 과정","@도덕적 지식·이해 심화하기","@도덕적 사고·판단력 및 합리적 의사 결정력 기르기","정의적 접근 과정","@도덕적 감정·정서 기르기","@도덕적 열정·의지 기르기","행동적 접근 과정","@도덕적 행위 기능·능력 기르기","도덕적 행동 성향·습관 기르기","정리(확대 적용 및 생활화)","@학습 내용 정리하기","@보충·심화 학습하기","생활 속 확대 적용과 실천 생활화 장려하기"}
            },

            new ModelSet
            {
                name = "도덕 - 지식 이해 중심의 수업 과정·절차",
                model = {"학습 문제 인식 및 동기 유발","가치 사례 제시 및 관련 규범 파악","가치 규범 탐구 및 이해의 심화","@주관화","@공통화","@초점화","도덕적 정서 및 의지의 강화","정리 및 확대 적용과 실천 생활화"}
            },

            new ModelSet
            {
                name = "도덕 - 가치 판단 중심의 수업 과정·절차",
                model = {"학습 문제 인식 및 동기 유발","도덕적 문제 사태의 제시 및 분석","도덕 판단·합리적 의사 결정의 학습","도덕적 정서 및 의지의 강화","정리 확대 적용과 실천 생활화"}
            },

            new ModelSet
            {
                name = "도덕 - 모범 감화 중심의 수업 과정·절차",
                model = {"학습 문제 인식 및 동기 유발","도덕적 모범의 제시와 관련 내용 파악","도덕적 모범의 탐구 및 감동 감화","도덕적 정서 및 의지의 강화","정리 및 확대 적용과 실천 생활화"}
            },

            new ModelSet
            {
                name = "도덕 - 가치 심화 중심의 수업 과정·절차",
                model = {"학습 문제 인식 및 동기 유발","가치 사례의 제시 및 성찰","가치 규범의 추구 및 심화","도덕적 정서 및 의지와 강화","정리 및 확대 적용과 실천 생활화"}
            },

            new ModelSet
            {
                name = "도덕 - 실습 실연 중심의 수업 과정·절차",
                model = {"학습 문제 인식 및 동기 유발","모범 행동의 제시 및 이해","모범 행동의 실습 실연","도덕적 정서 및 의지의 강화","정리 및 확대 적용과 실천 생활화"}
            },

            new ModelSet
            {
                name = "도덕 - 실천 체험 중심의 수업 과정·절차",
                model = {"학습 문제 인식 및 동기 유발","실천 체험 주제 설정 및 계획","실천 체험 학습 활동의 실행","실천 체험 결과 발표 및 도덕적 정서·의지 강화","정리 및 확대 적용과 실천 생활화"}
            },

            new ModelSet
            {
                name = "도덕 - 역할놀이 수업 모형",
                model = {"역할놀이 준비", "역할놀이 참가자 선정", "무대 설치", "참여적 관찰자로서 청중의 준비","역할놀이 시연","토론 및 평가","재연", "경험의 공유와 일반화"},
                chunk = "(준)나 (참)... (무대)도 (참),,,, (시)발 (토)나와 (재)(경)"
            },

            new ModelSet
            {
                name = "도덕 - 개념 분석 수업 모형",
                model = {"분석될 가치 개념의 확인","개념의 전형적인 사례와 개념에 반대되는 사례 탐구","개념의 경계에 해당하는 사례 확인","그 개념과 관련된 개념의 분석","가상적인 사태에의 적용","분석된 의미의 수용 여부 검토와 정리"},
                chunk = "(분가)하니 (전반)(경)(관)이 (가)(분)(수)"
            },

            new ModelSet
            {
                name = "도덕과 핵심 역량",
                model = {"윤리적 성찰 및 실천 성향","도덕적 대인관계 능력", "도덕적 사고 능력", "자기 존중 및 관리 능력", "도덕적 공동체 의식", "도덕적 정서 능력"},
                chunk = "(윤)(성)이랑 하다 (실)(성) 했대 ㄷㄷ - (도)(대)체 (관계)(능력)이 어떘길래? - (도)(사)(능력)이래 도사.. - 첨엔 (자)기(존)나 (관)(능)적이다 라고 멘트 치더니 - (공)(식)적으로 (정)(력)발산하더래!"
            },

            new ModelSet
            {
                name = "뒤르켐 - 도덕 사회화론의 관점",
                model = {"집단에 대한 애착","규율 정신","자율성"},
                chunk = "(뒷)(집)에 (귤)(자)기꺼"
            },

            new ModelSet
            {
                name = "도덕과 교수·학습 평가",
                model = {"집단 활동의 원리","학교·가정·지역사회의 연계에 대한 지도의 원리", "자율적 탐구 학습의 원리", "주체적 자각화와 개별화의 원리", "정합성의 원리", "지적·도덕적 발달 단계 고려의 원리", "능동적 참여와 토론 학습의 원리", "인지화의 원리", "통합성의 원리", "심정화의 원리", "행동화의 원리"},
                chunk = "(집)(학교)가는 버스(자)(주)(정)(찌) (고)래서 (능)(동)반 하면서 다니는데 (인)체 (통)증이 (심)(행)"
            },

            new ModelSet
            {
                name = "직접적 가치 전수 방법",
                model = {"강의","도덕 이야기","모형 제시", "독서", "정보통신 기술 활용"},
                chunk = "(강)(도)가 나를 (모)(독)하길래 (정보)를 줬다"
            },

            new ModelSet
            {
                name = "간접적 가치 탐구 방법",
                model = {"문답","집단 탐구", "글쓰기", "역할 놀이", "토의·토론"},
                chunk = "학창시절 (문)(집) (글)보니 (역)겨워 (토)나옴"
            },

            new ModelSet
            {
                name = "실천·체험을 통한 가치 학습 방법",
                model = {"참여적 실천 체험 활동","현장 학습", "실습·실연", "덕목실천 학습", "집단 수련 활동"},
                chunk = "(참) (현)(실)적인 (덕)(집)"
            },
            /*
            new ModelSet
            {
                name = "가치 분석 수업 모형",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            }*/
        };
        
        public static List<ModelSet> physical_modelset = new List<ModelSet>
        {
            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            }
        };

        public static List<ModelSet> English_modelset = new List<ModelSet>
        {
            new ModelSet
            {
                name = "영어 핵심 역량",
                model = {"공동체 역량","자기관리 역량", "영어 의사소통 역량", "지식정보처리 역량"},
                chunk = "(공)(자)(의)(지)"
            },

            new ModelSet
            {
                name = "제2언어 습득 모형 5 가설Hypothesis",
                model = {"Natural order","Monitor","Affective filter","Input","Acquisition-learning"},
                chunk = "(내) (모)(피) (이쁘)니까 (아끼지)"
            },

            new ModelSet
            {
                name = "초등 학습자의 특성",
                model = {"놀이와 재미를 추구하는 충동","풍부한 상상력","간접 학습 능력","창의적 언어 사용 능력","의미 파악 능력","움직이고 말하고자 하는 충동"},
                chunk = "(놀)(부)(가) (창)(의)적으로 (움직)여~"
            },

            new ModelSet
            {
                name = "교사 언어의 특징",
                model = {"반복적이다", "천천히 말한다","명확한 발음을 사용한다","어휘를 조정하여 사용한다","문법을 조정하여 사용한다","담화를 조정하여 사용한다"},
                chunk = ""
            },

            new ModelSet
            {
                name = "오류 수정 방법",
                model = {"metalinguistic feedback","repetition","clarification request","recast","elicitation","explicit correction"},
                chunk = "머리카락이 2개 m/r/c/r/e/e"
            },

            new ModelSet
            {
                name = "음철법 지도 순서",
                model = {"알파벳 음소에 대한 인식","철자와 소리의 상관관계 인식","구체적인 낱말 읽기","인지 낱말의 확장","어구 읽기","문장 읽기","독립적인 글 읽기"},
                chunk = "(알)(철)(구)(인)(어)(문)(독)"
            },

            /*new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            }*/
        };

        public static List<ModelSet> integrated_modelset = new List<ModelSet>
        {
            new ModelSet
            {
                name = "바른생활 내용요소",
                model = {"학교 - 학교생활과 규칙","학교 - 몸과 마음의 건강","봄 - 건강수칙과 위생","봄 - 생명 존중","가족 - 가정 예절","가족 - 배려와 존중", "여름 - 절약", "여름 - 여름생활 및 학습 계획", "마을 - 공중도덕", "마을 - 일의 소중함", "가을 - 질서", "가을 - 감사", "나라 - 나라 사랑", "나라 - 타문화 공감", "겨울 - 나눔과 봉사", "겨울 - 동식물 보호", "겨울 - 겨울생활 및 학습 계획"},
                chunk = "(학)생, (몸)이 (건)강하게 (생)겼네? (가)빠랑 (배) 근육이 (절)어(여)! - (공)사(일)로 만들어낸 (질)(감)이에요 - (나)는 (타)(나)서 (동)생같은 근육은 처음본(겨)"
            },

            new ModelSet
            {
                name = "실천활동 중심 교수 학습 모형",
                model = {"학습문제 인지하기","바른행동 알아보기", "바른행동 해보기", "바른행동 다짐하기"},
                chunk = "(학)(인)(알)(했)(다) 확 인용RT 했다"
            },

            new ModelSet
            {
                name = "탐구활동 중심 교수 학습 모형",
                model = {"탐구상황 확인하기","탐색하기", "탐구 활동하기", "탐구 결과 정리하기"},
                chunk = "(상)(탐)(활)(결)- 상담할걸"
            },

            new ModelSet
            {
                name = "표현 중심 교수 학습 모형",
                model = {"준비하기","탐색하기","표현 놀이 하기", "느낌 나누기"},
                chunk = "(준)(탐)(표)(늘)"
            }
        };

        public static List<ModelSet> memorize_modelset = new List<ModelSet>
        {
            new ModelSet
            {
                name = "",
                model = {"",""},
                chunk = ""
            }
        };


        /*public static List<ModelSet> modelset = new List<ModelSet>
        {
            
            new ModelSet
            {
                
                name = "과학 - 발견 학습 모형",
                model = {"탐색 및 문제 파악", "자료 제시 및 관찰 탐색", "추가 자료 제시 및 관찰 탐색","규칙성 발견 및 개념 정리","적용 및 응용"}
                
            },

            new ModelSet
            {
                name = "과학 - 경험 학습 모형",
                model = {"자유 탐색","탐색 결과 발표","교사의 안내에 따른 탐색","탐색 결과 정리"}

            },

            new ModelSet
            {
                name = "과학 - 탐구 학습 모형",
                model = {"탐색 및 문제 파악", "가설 설정", "실험 설계", "실험", "가설 검증", "적용 및 새로운 문제 발견"}
            },

            new ModelSet
            {
                name = "과학 - 순환 학습 모형",
                model = {"탐색", "개념 도입", "개념 적용"}
            },

            new ModelSet
            {
                name = "과학 - POE모형",
                model = {"예상", "관찰", "설명"}
            },

            new ModelSet
            {
                name = "과학 - 5E모형",
                model = {"참여", "탐색", "설명", "정교화", "평가"}
            },

            new ModelSet
            {
                name = "과학 - 개념 변화 학습 모형",
                model = {"개념 표현", "개념 재구성", "@명료화, 교환", "@갈등 상황 경험", "@새로운 개념 구성", "@새로운 개념 평가", "개념 응용", "개념 변화 검토" }

            },

            new ModelSet
            {
                name = "수학 - 개념 학습 모형",
                model = {"범례 제시 및 범례 분류하기", "공통의 성질 추상화하기", "개념 정의하기", "개념 익히기"}
            },

            new ModelSet
            {
                name = "수학 - 원리 탐구 학습 모형",
                model = {"새로운 문제 상황 제시", "수학적 원리의 필요성 인식", "수학적 원리가 내재된 조작 활동", "수학적 원리의 형식화", "수학적 원리 익히기 및 적용하기"}
            }
,

            new ModelSet
            {
                name = "수학 - 귀납 추론 학습 모형",
                model = {"사례 수집 및 관찰 실험", "추측하기", "추측의 검증", "일반화 및 정당화"}
                    
            }
,

            new ModelSet
            {
                name = "수학 - 문제 해결 학습 모형",
                model = {"문제의 이해", "해결 계획의 수립", "해결 계획의 실행", "반성"}
            },

            new ModelSet
            {
                name = "수학 교과 역량",
                model = {"창의,융합 역량","문제해결 능력","의사소통 역량","태도 및 실천","추론 능력","정보 처리 역량"}

            },
            new ModelSet
            {
                name = "과학 교과 역량",
                model = {"과학적 사고력","과학적 탐구 능력","과학적 문제 해결력","과학적 의사소통 능력","과학적 참여와 평생 학습 능력" }
            }, 
            
            new ModelSet
            {
                name = "일반 교과 역량",
                model = {"공동체 역량", "자기관리 역량", "지식정보처리 역량", "창의적 사고 역량", "의사소통 역량", "심미적 감성 역량"}
            },

            new ModelSet
            {
                name = "미술 교과 역량",
                model = {"창의 융합 능력", "미술문화 이해 능력", "미적 감수성", "시각적 소통 능력", "자기 주도적 미술학습능력"}
            },

            new ModelSet
            {
                name = "음악 교과 역량",
                model = {"음악적 창의융합 사고 역량", "음악 정보처리 역량", "문화적 공동체 역량", "자기관리 역량", "음악적 소통 역량", "음악적 감성 역량"}
            },

            new ModelSet
            {
                name = "국어 교과 역량",
                model = {"자료정보 활용 역량", "공동체 대인관계 역량", "자기 성찰 계발 역량", "의사소통 역량", "비판적 창의적 사고 역량", "문화 향유 역량"}
            },

            new ModelSet
            {
                name = "도덕 - 초등 도덕과 수업의 기본적 과정·절차",
                model = {"도입(문제의식화)","@도덕적 문제 의식 갖기", "@학습 동기 일으키기", "@학습 문제 인식하기","인지적 접근 과정","@도덕적 지식·이해 심화하기","@도덕적 사고·판단력 및 합리적 의사 결정력 기르기","정의적 접근 과정","@도덕적 감정·정서 기르기","@도덕적 열정·의지 기르기","행동적 접근 과정","@도덕적 행위 기능·능력 기르기","도덕적 행동 성향·습관 기르기","정리(확대 적용 및 생활화)","@학습 내용 정리하기","@보충·심화 학습하기","생활 속 확대 적용과 실천 생활화 장려하기"}
            },

            new ModelSet
            {
                name = "도덕 - 지식 이해 중심의 수업 과정·절차",
                model = {"학습 문제 인식 및 동기 유발","가치 사례 제시 및 관련 규범 파악","가치 규범 탐구 및 이해의 심화","@주관화","@공통화","@초점화","도덕적 정서 및 의지의 강화","정리 및 확대 적용과 실천 생활화"}
            },

            new ModelSet
            {
                name = "도덕 - 가치 판단 중심의 수업 과정·절차",
                model = {"학습 문제 인식 및 동기 유발","도덕적 문제 사태의 제시 및 분석","도덕 판단·합리적 의사 결정의 학습","도덕적 정서 및 의지의 강화","정리 확대 적용과 실천 생활화"}
            },

            new ModelSet
            {
                name = "도덕 - 모범 감화 중심의 수업 과정·절차",
                model = {"학습 문제 인식 및 동기 유발","도덕적 모범의 제시와 관련 내용 파악","도덕적 모범의 탐구 및 감동 감화","도덕적 정서 및 의지의 강화","정리 및 확대 적용과 실천 생활화"}
            },

            new ModelSet
            {
                name = "도덕 - 가치 심화 중심의 수업 과정·절차",
                model = {"학습 문제 인식 및 동기 유발","가치 사례의 제시 및 성찰","가치 규범의 추구 및 심화","도덕적 정서 및 의지와 강화","정리 및 확대 적용과 실천 생활화"}
            },

            new ModelSet
            {
                name = "도덕 - 실습 실연 중심의 수업 과정·절차",
                model = {"학습 문제 인식 및 동기 유발","모범 행동의 제시 및 이해","모범 행동의 실습 실연","도덕적 정서 및 의지의 강화","정리 및 확대 적용과 실천 생활화"}
            },

            new ModelSet
            {
                name = "도덕 - 실천 체험 중심의 수업 과정·절차",
                model = {"학습 문제 인식 및 동기 유발","실천 체험 주제 설정 및 계획","실천 체험 학습 활동의 실행","실천 체험 결과 발표 및 도덕적 정서·의지 강화","정리 및 확대 적용과 실천 생활화"}
            },

            new ModelSet
            {
                name = "도덕 - 역할놀이 수업 모형",
                model = {"역할놀이 준비", "역할놀이 참가자 선정", "무대 설치", "참여적 관찰자로서 청중의 준비","역할놀이 시연","토론 및 평가","재연", "경험의 공유와 일반화"}
            },

            new ModelSet
            {
                name = "도덕 - 개념 분석 수업 모형",
                model = {"분석될 가치 개념의 확인","개념의 전형적인 사례와 개념에 반대되는 사례 탐구","개념의 경계에 해당하는 사례 확인","그 개념과 관련된 개념의 분석","가상적인 사태에의 적용","분석된 의미의 수용 여부 검토와 정리"}
            },

            new ModelSet
            {
                name = "",
                model = {""},
                chunk = ""
            },

            new ModelSet
            {
                name = "",
                model = {""}
            },

            new ModelSet
            {
                name = "",
                model = {""}
            },

            new ModelSet
            {
                name = "",
                model = {""}
            },

            new ModelSet
            {
                name = "",
                model = {""}
            },

            new ModelSet
            {
                name = "",
                model = {""}
            },

            new ModelSet
            {
                name = "",
                model = {""}
            },

            new ModelSet
            {
                name = "",
                model = {""}
            },

            new ModelSet
            {
                name = "",
                model = {""}
            },

            new ModelSet
            {
                name = "",
                model = {""}
            },

            new ModelSet
            {
                name = "",
                model = {""}
            },

            new ModelSet
            {
                name = "",
                model = {""}
            },

            new ModelSet
            {
                name = "",
                model = {""}
            },

            new ModelSet
            {
                name = "",
                model = {""}
            }
            









        };*/




    }
}

