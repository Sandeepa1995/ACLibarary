namespace ACLibarary
{
    partial class AddBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBookForm));
            this.btnCloseAddBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nUDAddQuan = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbAddMath = new System.Windows.Forms.RadioButton();
            this.rbAddPhy = new System.Windows.Forms.RadioButton();
            this.rbAddChem = new System.Windows.Forms.RadioButton();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.rbTheory = new System.Windows.Forms.RadioButton();
            this.rbReference = new System.Windows.Forms.RadioButton();
            this.rbQuestions = new System.Windows.Forms.RadioButton();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.cmbAuthor = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbAddOther = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nUDAddQuan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCloseAddBook
            // 
            this.btnCloseAddBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseAddBook.FlatAppearance.BorderSize = 0;
            this.btnCloseAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseAddBook.Location = new System.Drawing.Point(445, 24);
            this.btnCloseAddBook.Name = "btnCloseAddBook";
            this.btnCloseAddBook.Size = new System.Drawing.Size(32, 28);
            this.btnCloseAddBook.TabIndex = 2;
            this.btnCloseAddBook.Text = "X";
            this.btnCloseAddBook.UseVisualStyleBackColor = true;
            this.btnCloseAddBook.Click += new System.EventHandler(this.btnCloseAddBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBook.Enabled = false;
            this.btnAddBook.Location = new System.Drawing.Point(51, 362);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(395, 44);
            this.btnAddBook.TabIndex = 20;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 297);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Ref. Code/s :";
            // 
            // nUDAddQuan
            // 
            this.nUDAddQuan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nUDAddQuan.Location = new System.Drawing.Point(151, 124);
            this.nUDAddQuan.Margin = new System.Windows.Forms.Padding(4);
            this.nUDAddQuan.Name = "nUDAddQuan";
            this.nUDAddQuan.Size = new System.Drawing.Size(85, 22);
            this.nUDAddQuan.TabIndex = 17;
            this.nUDAddQuan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDAddQuan.ValueChanged += new System.EventHandler(this.nUDAddQuan_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Quantity :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Author :";
            // 
            // txtAddTitle
            // 
            this.txtAddTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddTitle.Location = new System.Drawing.Point(151, 64);
            this.txtAddTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddTitle.Name = "txtAddTitle";
            this.txtAddTitle.Size = new System.Drawing.Size(297, 22);
            this.txtAddTitle.TabIndex = 13;
            this.txtAddTitle.TextChanged += new System.EventHandler(this.txtAddTitle_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Title :";
            // 
            // rbAddMath
            // 
            this.rbAddMath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbAddMath.AutoSize = true;
            this.rbAddMath.Checked = true;
            this.rbAddMath.Location = new System.Drawing.Point(11, 21);
            this.rbAddMath.Name = "rbAddMath";
            this.rbAddMath.Size = new System.Drawing.Size(60, 21);
            this.rbAddMath.TabIndex = 21;
            this.rbAddMath.TabStop = true;
            this.rbAddMath.Text = "Math";
            this.rbAddMath.UseVisualStyleBackColor = true;
            this.rbAddMath.CheckedChanged += new System.EventHandler(this.rbAddMath_CheckedChanged);
            // 
            // rbAddPhy
            // 
            this.rbAddPhy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbAddPhy.AutoSize = true;
            this.rbAddPhy.Location = new System.Drawing.Point(92, 19);
            this.rbAddPhy.Name = "rbAddPhy";
            this.rbAddPhy.Size = new System.Drawing.Size(77, 21);
            this.rbAddPhy.TabIndex = 22;
            this.rbAddPhy.Text = "Physics";
            this.rbAddPhy.UseVisualStyleBackColor = true;
            this.rbAddPhy.CheckedChanged += new System.EventHandler(this.rbAddPhy_CheckedChanged);
            // 
            // rbAddChem
            // 
            this.rbAddChem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbAddChem.AutoSize = true;
            this.rbAddChem.Location = new System.Drawing.Point(199, 19);
            this.rbAddChem.Name = "rbAddChem";
            this.rbAddChem.Size = new System.Drawing.Size(91, 21);
            this.rbAddChem.TabIndex = 23;
            this.rbAddChem.Text = "Chemistry";
            this.rbAddChem.UseVisualStyleBackColor = true;
            this.rbAddChem.CheckedChanged += new System.EventHandler(this.rbAddChem_CheckedChanged);
            // 
            // txtRef
            // 
            this.txtRef.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRef.Location = new System.Drawing.Point(145, 294);
            this.txtRef.Multiline = true;
            this.txtRef.Name = "txtRef";
            this.txtRef.ReadOnly = true;
            this.txtRef.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRef.Size = new System.Drawing.Size(297, 61);
            this.txtRef.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Subject :";
            // 
            // cmbSubject
            // 
            this.cmbSubject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSubject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(151, 205);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(266, 24);
            this.cmbSubject.TabIndex = 26;
            this.cmbSubject.SelectedIndexChanged += new System.EventHandler(this.cmbSubject_SelectedIndexChanged);
            this.cmbSubject.TextChanged += new System.EventHandler(this.cmbSubject_TextChanged);
            // 
            // rbTheory
            // 
            this.rbTheory.AutoSize = true;
            this.rbTheory.Checked = true;
            this.rbTheory.Location = new System.Drawing.Point(13, 21);
            this.rbTheory.Name = "rbTheory";
            this.rbTheory.Size = new System.Drawing.Size(74, 21);
            this.rbTheory.TabIndex = 28;
            this.rbTheory.TabStop = true;
            this.rbTheory.Text = "Theory";
            this.rbTheory.UseVisualStyleBackColor = true;
            this.rbTheory.CheckedChanged += new System.EventHandler(this.rbTheory_CheckedChanged);
            // 
            // rbReference
            // 
            this.rbReference.AutoSize = true;
            this.rbReference.Location = new System.Drawing.Point(290, 21);
            this.rbReference.Name = "rbReference";
            this.rbReference.Size = new System.Drawing.Size(95, 21);
            this.rbReference.TabIndex = 29;
            this.rbReference.Text = "Reference";
            this.rbReference.UseVisualStyleBackColor = true;
            this.rbReference.CheckedChanged += new System.EventHandler(this.rbReference_CheckedChanged);
            // 
            // rbQuestions
            // 
            this.rbQuestions.AutoSize = true;
            this.rbQuestions.Location = new System.Drawing.Point(150, 21);
            this.rbQuestions.Name = "rbQuestions";
            this.rbQuestions.Size = new System.Drawing.Size(93, 21);
            this.rbQuestions.TabIndex = 30;
            this.rbQuestions.Text = "Questions";
            this.rbQuestions.UseVisualStyleBackColor = true;
            this.rbQuestions.CheckedChanged += new System.EventHandler(this.rbQuestions_CheckedChanged);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAuthor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddAuthor.BackgroundImage")));
            this.btnAddAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddAuthor.Enabled = false;
            this.btnAddAuthor.Location = new System.Drawing.Point(424, 94);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(24, 23);
            this.btnAddAuthor.TabIndex = 31;
            this.btnAddAuthor.UseVisualStyleBackColor = false;
            this.btnAddAuthor.Visible = false;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSubject.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddSubject.BackgroundImage")));
            this.btnAddSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddSubject.Enabled = false;
            this.btnAddSubject.Location = new System.Drawing.Point(424, 205);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(24, 24);
            this.btnAddSubject.TabIndex = 32;
            this.btnAddSubject.UseVisualStyleBackColor = false;
            this.btnAddSubject.Visible = false;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // cmbAuthor
            // 
            this.cmbAuthor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAuthor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAuthor.FormattingEnabled = true;
            this.cmbAuthor.Location = new System.Drawing.Point(151, 93);
            this.cmbAuthor.Name = "cmbAuthor";
            this.cmbAuthor.Size = new System.Drawing.Size(266, 24);
            this.cmbAuthor.TabIndex = 33;
            this.cmbAuthor.SelectedIndexChanged += new System.EventHandler(this.cmbAuthor_SelectedIndexChanged);
            this.cmbAuthor.TextChanged += new System.EventHandler(this.cmbAuthor_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTheory);
            this.groupBox1.Controls.Add(this.rbQuestions);
            this.groupBox1.Controls.Add(this.rbReference);
            this.groupBox1.Location = new System.Drawing.Point(51, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 52);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbAddOther);
            this.groupBox2.Controls.Add(this.rbAddMath);
            this.groupBox2.Controls.Add(this.rbAddPhy);
            this.groupBox2.Controls.Add(this.rbAddChem);
            this.groupBox2.Location = new System.Drawing.Point(53, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 46);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stream :";
            // 
            // rbAddOther
            // 
            this.rbAddOther.AutoSize = true;
            this.rbAddOther.Location = new System.Drawing.Point(318, 19);
            this.rbAddOther.Name = "rbAddOther";
            this.rbAddOther.Size = new System.Drawing.Size(65, 21);
            this.rbAddOther.TabIndex = 24;
            this.rbAddOther.TabStop = true;
            this.rbAddOther.Text = "Other";
            this.rbAddOther.UseVisualStyleBackColor = true;
            this.rbAddOther.CheckedChanged += new System.EventHandler(this.rbOther_CheckedChanged);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 430);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbAuthor);
            this.Controls.Add(this.btnAddSubject);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRef);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nUDAddQuan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCloseAddBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBook";
            this.Load += new System.EventHandler(this.AddBook_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddBookForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.nUDAddQuan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseAddBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nUDAddQuan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbAddMath;
        private System.Windows.Forms.RadioButton rbAddPhy;
        private System.Windows.Forms.RadioButton rbAddChem;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.RadioButton rbTheory;
        private System.Windows.Forms.RadioButton rbReference;
        private System.Windows.Forms.RadioButton rbQuestions;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.ComboBox cmbAuthor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbAddOther;
    }
}