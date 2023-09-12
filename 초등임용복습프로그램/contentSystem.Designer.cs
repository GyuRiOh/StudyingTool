namespace 초등임용복습프로그램
{
    partial class contentSystem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coreConceptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.content34DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.content56DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.functionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conSysDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonChoose = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conSysDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.areaDataGridViewTextBoxColumn,
            this.coreConceptDataGridViewTextBoxColumn,
            this.content34DataGridViewTextBoxColumn,
            this.content56DataGridViewTextBoxColumn,
            this.functionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.conSysDataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(671, 476);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "area";
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.areaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.areaDataGridViewTextBoxColumn.HeaderText = "영역";
            this.areaDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            // 
            // coreConceptDataGridViewTextBoxColumn
            // 
            this.coreConceptDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.coreConceptDataGridViewTextBoxColumn.DataPropertyName = "coreConcept";
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.coreConceptDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.coreConceptDataGridViewTextBoxColumn.HeaderText = "핵심 개념";
            this.coreConceptDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.coreConceptDataGridViewTextBoxColumn.Name = "coreConceptDataGridViewTextBoxColumn";
            this.coreConceptDataGridViewTextBoxColumn.Width = 120;
            // 
            // content34DataGridViewTextBoxColumn
            // 
            this.content34DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.content34DataGridViewTextBoxColumn.DataPropertyName = "content34";
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.content34DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.content34DataGridViewTextBoxColumn.HeaderText = "내용 요소(3~4)";
            this.content34DataGridViewTextBoxColumn.MinimumWidth = 100;
            this.content34DataGridViewTextBoxColumn.Name = "content34DataGridViewTextBoxColumn";
            // 
            // content56DataGridViewTextBoxColumn
            // 
            this.content56DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.content56DataGridViewTextBoxColumn.DataPropertyName = "content56";
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.content56DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.content56DataGridViewTextBoxColumn.HeaderText = "내용 요소(5~6)";
            this.content56DataGridViewTextBoxColumn.MinimumWidth = 150;
            this.content56DataGridViewTextBoxColumn.Name = "content56DataGridViewTextBoxColumn";
            this.content56DataGridViewTextBoxColumn.Width = 150;
            // 
            // functionDataGridViewTextBoxColumn
            // 
            this.functionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.functionDataGridViewTextBoxColumn.DataPropertyName = "function";
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.functionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.functionDataGridViewTextBoxColumn.HeaderText = "기능";
            this.functionDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.functionDataGridViewTextBoxColumn.Name = "functionDataGridViewTextBoxColumn";
            // 
            // conSysDataBindingSource
            // 
            this.conSysDataBindingSource.DataSource = typeof(초등임용복습프로그램.ConSysData);
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(727, 63);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(75, 23);
            this.buttonChoose.TabIndex = 1;
            this.buttonChoose.Text = "선택";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "음악",
            "미술",
            "실과",
            "체육",
            "음악 요소, 개념"});
            this.comboBox1.Location = new System.Drawing.Point(727, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 20);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1개",
            "2개",
            "3개",
            "4개",
            "5개",
            "모두 빈칸"});
            this.comboBox2.Location = new System.Drawing.Point(808, 37);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(87, 20);
            this.comboBox2.TabIndex = 3;
            // 
            // contentSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 611);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonChoose);
            this.Controls.Add(this.dataGridView1);
            this.Name = "contentSystem";
            this.Text = "contentSystem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conSysDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.BindingSource conSysDataBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coreConceptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn content34DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn content56DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn functionDataGridViewTextBoxColumn;
    }
}