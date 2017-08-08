namespace ACLibarary
{
    partial class LendBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LendBookForm));
            this.btnCloseAddBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRef = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuth = new System.Windows.Forms.Label();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudentIndex = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cb12 = new System.Windows.Forms.CheckBox();
            this.cb13 = new System.Windows.Forms.CheckBox();
            this.clbClass = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCloseAddBook
            // 
            this.btnCloseAddBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseAddBook.FlatAppearance.BorderSize = 0;
            this.btnCloseAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseAddBook.Location = new System.Drawing.Point(797, 21);
            this.btnCloseAddBook.Name = "btnCloseAddBook";
            this.btnCloseAddBook.Size = new System.Drawing.Size(32, 28);
            this.btnCloseAddBook.TabIndex = 3;
            this.btnCloseAddBook.Text = "X";
            this.btnCloseAddBook.UseVisualStyleBackColor = true;
            this.btnCloseAddBook.Click += new System.EventHandler(this.btnCloseAddBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Reference Code :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Title :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Author :";
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.Location = new System.Drawing.Point(166, 18);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(30, 17);
            this.lblRef.TabIndex = 7;
            this.lblRef.Text = "Ref";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(166, 44);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 17);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Title";
            // 
            // lblAuth
            // 
            this.lblAuth.AutoSize = true;
            this.lblAuth.Location = new System.Drawing.Point(166, 74);
            this.lblAuth.Name = "lblAuth";
            this.lblAuth.Size = new System.Drawing.Size(37, 17);
            this.lblAuth.TabIndex = 9;
            this.lblAuth.Text = "Auth";
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.name,
            this.grade,
            this.sclass,
            this.borrowed});
            this.dgvStudent.Location = new System.Drawing.Point(42, 268);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowHeadersVisible = false;
            this.dgvStudent.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(759, 201);
            this.dgvStudent.TabIndex = 11;
            this.dgvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellContentClick);
            // 
            // index
            // 
            this.index.HeaderText = "Index";
            this.index.Name = "index";
            this.index.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // grade
            // 
            this.grade.HeaderText = "Grade";
            this.grade.Name = "grade";
            this.grade.ReadOnly = true;
            // 
            // sclass
            // 
            this.sclass.HeaderText = "Class";
            this.sclass.Name = "sclass";
            this.sclass.ReadOnly = true;
            // 
            // borrowed
            // 
            this.borrowed.HeaderText = "Borrowed";
            this.borrowed.Name = "borrowed";
            this.borrowed.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Index :";
            // 
            // txtStudentIndex
            // 
            this.txtStudentIndex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStudentIndex.Location = new System.Drawing.Point(80, 55);
            this.txtStudentIndex.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentIndex.Name = "txtStudentIndex";
            this.txtStudentIndex.Size = new System.Drawing.Size(123, 22);
            this.txtStudentIndex.TabIndex = 3;
            this.txtStudentIndex.TextChanged += new System.EventHandler(this.txtStudentIndex_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Name :";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStudentName.Location = new System.Drawing.Point(80, 22);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(287, 22);
            this.txtStudentName.TabIndex = 2;
            this.txtStudentName.TextChanged += new System.EventHandler(this.txtStudentName_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.clbClass);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtStudentIndex);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtStudentName);
            this.groupBox3.Location = new System.Drawing.Point(42, 162);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(755, 98);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cb12);
            this.groupBox4.Controls.Add(this.cb13);
            this.groupBox4.Location = new System.Drawing.Point(417, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(164, 52);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Grade";
            // 
            // cb12
            // 
            this.cb12.AutoSize = true;
            this.cb12.Checked = true;
            this.cb12.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb12.Location = new System.Drawing.Point(6, 21);
            this.cb12.Name = "cb12";
            this.cb12.Size = new System.Drawing.Size(46, 21);
            this.cb12.TabIndex = 9;
            this.cb12.Text = "12";
            this.cb12.UseVisualStyleBackColor = true;
            this.cb12.CheckedChanged += new System.EventHandler(this.cb12_CheckedChanged);
            // 
            // cb13
            // 
            this.cb13.AutoSize = true;
            this.cb13.Checked = true;
            this.cb13.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb13.Location = new System.Drawing.Point(112, 21);
            this.cb13.Name = "cb13";
            this.cb13.Size = new System.Drawing.Size(46, 21);
            this.cb13.TabIndex = 8;
            this.cb13.Text = "13";
            this.cb13.UseVisualStyleBackColor = true;
            this.cb13.CheckedChanged += new System.EventHandler(this.cb13_CheckedChanged);
            // 
            // clbClass
            // 
            this.clbClass.CheckOnClick = true;
            this.clbClass.FormattingEnabled = true;
            this.clbClass.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "E"});
            this.clbClass.Location = new System.Drawing.Point(681, 12);
            this.clbClass.MinimumSize = new System.Drawing.Size(4, 40);
            this.clbClass.Name = "clbClass";
            this.clbClass.Size = new System.Drawing.Size(67, 72);
            this.clbClass.TabIndex = 12;
            this.clbClass.SelectedIndexChanged += new System.EventHandler(this.clbClass_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(625, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Class :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblAuth);
            this.groupBox1.Controls.Add(this.lblRef);
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Location = new System.Drawing.Point(42, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book";
            // 
            // btnLend
            // 
            this.btnLend.Location = new System.Drawing.Point(42, 476);
            this.btnLend.Name = "btnLend";
            this.btnLend.Size = new System.Drawing.Size(759, 63);
            this.btnLend.TabIndex = 13;
            this.btnLend.Text = "Lend";
            this.btnLend.UseVisualStyleBackColor = true;
            this.btnLend.Click += new System.EventHandler(this.btnLend_Click);
            // 
            // LendBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 589);
            this.Controls.Add(this.btnLend);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCloseAddBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LendBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSubjectForm";
            this.Load += new System.EventHandler(this.AddSubjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCloseAddBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuth;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn sclass;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStudentIndex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cb12;
        private System.Windows.Forms.CheckBox cb13;
        private System.Windows.Forms.CheckedListBox clbClass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLend;
    }
}