namespace 초등임용복습프로그램
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSelection = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonInput = new System.Windows.Forms.Button();
            this.TorF = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RightAnswer = new System.Windows.Forms.Label();
            this.ConfirmAnswer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelChallenge = new System.Windows.Forms.Label();
            this.labelCorrect = new System.Windows.Forms.Label();
            this.labelWrong = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.jumpToModel = new System.Windows.Forms.Button();
            this.questionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonWrong = new System.Windows.Forms.Button();
            this.labelQN = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonCS = new System.Windows.Forms.Button();
            this.labelRef = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "총론",
            "수학",
            "과학",
            "음악",
            "실과",
            "도덕",
            "영어",
            "사회",
            "미술",
            "체육",
            "국어",
            "통합교과",
            "필수암기리스트",
            "사용자 파일"});
            this.comboBox1.Location = new System.Drawing.Point(19, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(19, 115);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(19, 150);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 20);
            this.comboBox3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(206, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(757, 218);
            this.label1.TabIndex = 3;
            this.label1.Text = "여기에 문제가 나옵니다.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonSelection
            // 
            this.buttonSelection.Location = new System.Drawing.Point(19, 218);
            this.buttonSelection.Name = "buttonSelection";
            this.buttonSelection.Size = new System.Drawing.Size(75, 23);
            this.buttonSelection.TabIndex = 4;
            this.buttonSelection.Text = "선택 (랜덤)";
            this.buttonSelection.UseVisualStyleBackColor = true;
            this.buttonSelection.Click += new System.EventHandler(this.buttonSelection_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(312, 319);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(396, 21);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonInput
            // 
            this.buttonInput.Location = new System.Drawing.Point(723, 317);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(75, 23);
            this.buttonInput.TabIndex = 6;
            this.buttonInput.Text = "입력!";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // TorF
            // 
            this.TorF.AutoSize = true;
            this.TorF.Location = new System.Drawing.Point(843, 322);
            this.TorF.Name = "TorF";
            this.TorF.Size = new System.Drawing.Size(89, 12);
            this.TorF.TabIndex = 7;
            this.TorF.Text = "맞을까?틀릴까?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔명조", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(356, 27);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(352, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "<초등임용 암기 프로그램 ver.200609>";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // RightAnswer
            // 
            this.RightAnswer.Location = new System.Drawing.Point(210, 359);
            this.RightAnswer.Name = "RightAnswer";
            this.RightAnswer.Size = new System.Drawing.Size(507, 64);
            this.RightAnswer.TabIndex = 9;
            this.RightAnswer.Text = "정답을 표시합니다.";
            this.RightAnswer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ConfirmAnswer
            // 
            this.ConfirmAnswer.Location = new System.Drawing.Point(723, 359);
            this.ConfirmAnswer.Name = "ConfirmAnswer";
            this.ConfirmAnswer.Size = new System.Drawing.Size(75, 23);
            this.ConfirmAnswer.TabIndex = 10;
            this.ConfirmAnswer.Text = "정답";
            this.ConfirmAnswer.UseVisualStyleBackColor = true;
            this.ConfirmAnswer.Click += new System.EventHandler(this.ConfirmAnswer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(774, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "도전 문제 수 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(774, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "맞은 문제 수 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(774, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "틀린 문제 수 :";
            // 
            // labelChallenge
            // 
            this.labelChallenge.AutoSize = true;
            this.labelChallenge.Location = new System.Drawing.Point(875, 9);
            this.labelChallenge.Name = "labelChallenge";
            this.labelChallenge.Size = new System.Drawing.Size(11, 12);
            this.labelChallenge.TabIndex = 14;
            this.labelChallenge.Text = "0";
            // 
            // labelCorrect
            // 
            this.labelCorrect.AutoSize = true;
            this.labelCorrect.Location = new System.Drawing.Point(875, 27);
            this.labelCorrect.Name = "labelCorrect";
            this.labelCorrect.Size = new System.Drawing.Size(11, 12);
            this.labelCorrect.TabIndex = 15;
            this.labelCorrect.Text = "0";
            // 
            // labelWrong
            // 
            this.labelWrong.AutoSize = true;
            this.labelWrong.Location = new System.Drawing.Point(875, 48);
            this.labelWrong.Name = "labelWrong";
            this.labelWrong.Size = new System.Drawing.Size(11, 12);
            this.labelWrong.TabIndex = 16;
            this.labelWrong.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "선택 (순서대로)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // jumpToModel
            // 
            this.jumpToModel.Location = new System.Drawing.Point(19, 12);
            this.jumpToModel.Name = "jumpToModel";
            this.jumpToModel.Size = new System.Drawing.Size(206, 23);
            this.jumpToModel.TabIndex = 18;
            this.jumpToModel.Text = "모형을외우고싶은자이걸누르시오";
            this.jumpToModel.UseVisualStyleBackColor = true;
            this.jumpToModel.Click += new System.EventHandler(this.jumpToModel_Click);
            // 
            // buttonWrong
            // 
            this.buttonWrong.Location = new System.Drawing.Point(910, 22);
            this.buttonWrong.Name = "buttonWrong";
            this.buttonWrong.Size = new System.Drawing.Size(75, 23);
            this.buttonWrong.TabIndex = 19;
            this.buttonWrong.Text = "오답 확인";
            this.buttonWrong.UseVisualStyleBackColor = true;
            this.buttonWrong.Click += new System.EventHandler(this.buttonWrong_Click_1);
            // 
            // labelQN
            // 
            this.labelQN.AutoSize = true;
            this.labelQN.Location = new System.Drawing.Point(146, 190);
            this.labelQN.Name = "labelQN";
            this.labelQN.Size = new System.Drawing.Size(11, 12);
            this.labelQN.TabIndex = 21;
            this.labelQN.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "선택한 항목의 문제 수: ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonCS
            // 
            this.buttonCS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCS.Location = new System.Drawing.Point(19, 43);
            this.buttonCS.Name = "buttonCS";
            this.buttonCS.Size = new System.Drawing.Size(181, 23);
            this.buttonCS.TabIndex = 23;
            this.buttonCS.Text = "여기는내용체계로통하는문";
            this.buttonCS.UseVisualStyleBackColor = true;
            this.buttonCS.Click += new System.EventHandler(this.buttonCS_Click);
            // 
            // labelRef
            // 
            this.labelRef.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelRef.Location = new System.Drawing.Point(208, 447);
            this.labelRef.Name = "labelRef";
            this.labelRef.Size = new System.Drawing.Size(722, 90);
            this.labelRef.TabIndex = 24;
            this.labelRef.Text = "참조 자료를 표시합니다. 자료가 없다면 표시하지 않습니다.";
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(19, 303);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(112, 31);
            this.buttonInsert.TabIndex = 25;
            this.buttonInsert.Text = "문제 직접 만들기";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 28);
            this.button2.TabIndex = 26;
            this.button2.Text = "직접 만든 문제 가지고 오기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 27;
            this.label7.Text = "로드된 파일 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(101, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 28;
            this.label8.Text = "없음";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(872, 480);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(113, 23);
            this.buttonDelete.TabIndex = 29;
            this.buttonDelete.Text = "오답노트 삭제";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 546);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.labelRef);
            this.Controls.Add(this.buttonCS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelQN);
            this.Controls.Add(this.buttonWrong);
            this.Controls.Add(this.jumpToModel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelWrong);
            this.Controls.Add(this.labelCorrect);
            this.Controls.Add(this.labelChallenge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ConfirmAnswer);
            this.Controls.Add(this.RightAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TorF);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonSelection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource questionBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ConfirmAnswer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelChallenge;
        private System.Windows.Forms.Label labelCorrect;
        private System.Windows.Forms.Label labelWrong;
        private System.Windows.Forms.Button jumpToModel;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.ComboBox comboBox3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button buttonSelection;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button buttonInput;
        public System.Windows.Forms.Label RightAnswer;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label TorF;
        private System.Windows.Forms.Button buttonWrong;
        private System.Windows.Forms.Label labelQN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonCS;
        private System.Windows.Forms.Label labelRef;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonDelete;
    }

    }

