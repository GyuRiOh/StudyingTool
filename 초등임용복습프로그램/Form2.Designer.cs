namespace 초등임용복습프로그램
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonChoice = new System.Windows.Forms.Button();
            this.TorF = new System.Windows.Forms.Label();
            this.labelCor = new System.Windows.Forms.Label();
            this.buttonCor = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonChunk = new System.Windows.Forms.Button();
            this.labelHint = new System.Windows.Forms.Label();
            this.buttonRA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(274, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(274, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "비어있는 칸의 모형 단계명, 역량명을 쓰시오. (반드시 하나는 빠져있다)";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(426, 241);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 3;
            this.buttonConfirm.Text = "확인";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(40, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(199, 424);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "<문제 출력>";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonChoice
            // 
            this.buttonChoice.Location = new System.Drawing.Point(172, 511);
            this.buttonChoice.Name = "buttonChoice";
            this.buttonChoice.Size = new System.Drawing.Size(67, 23);
            this.buttonChoice.TabIndex = 7;
            this.buttonChoice.Text = "선택";
            this.buttonChoice.UseVisualStyleBackColor = true;
            this.buttonChoice.Click += new System.EventHandler(this.button1_Click);
            // 
            // TorF
            // 
            this.TorF.AutoSize = true;
            this.TorF.Location = new System.Drawing.Point(318, 246);
            this.TorF.Name = "TorF";
            this.TorF.Size = new System.Drawing.Size(89, 12);
            this.TorF.TabIndex = 8;
            this.TorF.Text = "맞았나?틀렸나?";
            // 
            // labelCor
            // 
            this.labelCor.Location = new System.Drawing.Point(272, 293);
            this.labelCor.Name = "labelCor";
            this.labelCor.Size = new System.Drawing.Size(159, 51);
            this.labelCor.TabIndex = 9;
            this.labelCor.Text = "정답이 표시됩니다.";
            // 
            // buttonCor
            // 
            this.buttonCor.Location = new System.Drawing.Point(426, 293);
            this.buttonCor.Name = "buttonCor";
            this.buttonCor.Size = new System.Drawing.Size(75, 23);
            this.buttonCor.TabIndex = 10;
            this.buttonCor.Text = "정답";
            this.buttonCor.UseVisualStyleBackColor = true;
            this.buttonCor.Click += new System.EventHandler(this.buttonCor_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "국어 청킹",
            "수학 청킹",
            "도덕 청킹",
            "과학 청킹",
            "역량"});
            this.comboBox1.Location = new System.Drawing.Point(40, 513);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 20);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonChunk
            // 
            this.buttonChunk.Location = new System.Drawing.Point(426, 378);
            this.buttonChunk.Name = "buttonChunk";
            this.buttonChunk.Size = new System.Drawing.Size(75, 23);
            this.buttonChunk.TabIndex = 12;
            this.buttonChunk.Text = "힌트";
            this.buttonChunk.UseVisualStyleBackColor = true;
            this.buttonChunk.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // labelHint
            // 
            this.labelHint.Location = new System.Drawing.Point(259, 383);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(161, 208);
            this.labelHint.TabIndex = 13;
            this.labelHint.Text = "힌트(청킹)가 표시됩니다.";
            // 
            // buttonRA
            // 
            this.buttonRA.Location = new System.Drawing.Point(312, 25);
            this.buttonRA.Name = "buttonRA";
            this.buttonRA.Size = new System.Drawing.Size(189, 23);
            this.buttonRA.TabIndex = 14;
            this.buttonRA.Text = "이 항목에서 랜덤문제 더 내기";
            this.buttonRA.UseVisualStyleBackColor = true;
            this.buttonRA.Click += new System.EventHandler(this.buttonRA_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 637);
            this.Controls.Add(this.buttonRA);
            this.Controls.Add(this.labelHint);
            this.Controls.Add(this.buttonChunk);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonCor);
            this.Controls.Add(this.labelCor);
            this.Controls.Add(this.TorF);
            this.Controls.Add(this.buttonChoice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonChoice;
        private System.Windows.Forms.Label TorF;
        private System.Windows.Forms.Label labelCor;
        private System.Windows.Forms.Button buttonCor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonChunk;
        private System.Windows.Forms.Label labelHint;
        private System.Windows.Forms.Button buttonRA;
    }
}