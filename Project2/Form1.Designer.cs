namespace Project2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bntReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.nAge = new System.Windows.Forms.NumericUpDown();
            this.lbAge = new System.Windows.Forms.Label();
            this.txtHp = new System.Windows.Forms.TextBox();
            this.lbHp = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.lbUid = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAge)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(434, 289);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bntReset);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.nAge);
            this.groupBox1.Controls.Add(this.lbAge);
            this.groupBox1.Controls.Add(this.txtHp);
            this.groupBox1.Controls.Add(this.lbHp);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Controls.Add(this.txtUid);
            this.groupBox1.Controls.Add(this.lbUid);
            this.groupBox1.Location = new System.Drawing.Point(452, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 199);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "데이터 추가/수정/삭제";
            // 
            // bntReset
            // 
            this.bntReset.Location = new System.Drawing.Point(92, 165);
            this.bntReset.Name = "bntReset";
            this.bntReset.Size = new System.Drawing.Size(80, 23);
            this.bntReset.TabIndex = 11;
            this.bntReset.Text = "리셋";
            this.bntReset.UseVisualStyleBackColor = true;
            this.bntReset.Click += new System.EventHandler(this.bntReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 165);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(92, 136);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(6, 136);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(80, 23);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "추가";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // nAge
            // 
            this.nAge.Location = new System.Drawing.Point(54, 107);
            this.nAge.Name = "nAge";
            this.nAge.Size = new System.Drawing.Size(116, 23);
            this.nAge.TabIndex = 7;
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(9, 109);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(31, 15);
            this.lbAge.TabIndex = 6;
            this.lbAge.Text = "나이";
            // 
            // txtHp
            // 
            this.txtHp.Location = new System.Drawing.Point(54, 77);
            this.txtHp.Name = "txtHp";
            this.txtHp.Size = new System.Drawing.Size(116, 23);
            this.txtHp.TabIndex = 5;
            // 
            // lbHp
            // 
            this.lbHp.AutoSize = true;
            this.lbHp.Location = new System.Drawing.Point(9, 80);
            this.lbHp.Name = "lbHp";
            this.lbHp.Size = new System.Drawing.Size(43, 15);
            this.lbHp.TabIndex = 4;
            this.lbHp.Text = "휴대폰";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(54, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(116, 23);
            this.txtName.TabIndex = 3;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(9, 51);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(31, 15);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "이름";
            // 
            // txtUid
            // 
            this.txtUid.Location = new System.Drawing.Point(54, 19);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(116, 23);
            this.txtUid.TabIndex = 1;
            // 
            // lbUid
            // 
            this.lbUid.AutoSize = true;
            this.lbUid.Location = new System.Drawing.Point(9, 22);
            this.lbUid.Name = "lbUid";
            this.lbUid.Size = new System.Drawing.Size(43, 15);
            this.lbUid.TabIndex = 0;
            this.lbUid.Text = "아이디";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(452, 12);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "조회";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 313);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "데이터 베이스";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button bntReset;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private NumericUpDown nAge;
        private Label lbAge;
        private TextBox txtHp;
        private Label lbHp;
        private TextBox txtName;
        private Label lbName;
        private TextBox txtUid;
        private Label lbUid;
        private Button btnSelect;
    }
}