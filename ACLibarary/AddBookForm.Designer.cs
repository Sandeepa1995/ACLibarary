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
            this.label4 = new System.Windows.Forms.Label();
            this.nUDAddQuan = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddAuth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbAddMath = new System.Windows.Forms.RadioButton();
            this.rbAddPhy = new System.Windows.Forms.RadioButton();
            this.rbAddChem = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUDAddQuan)).BeginInit();
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
            this.btnAddBook.Location = new System.Drawing.Point(348, 323);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(100, 28);
            this.btnAddBook.TabIndex = 20;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 237);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Ref. Code/s";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Catagory";
            // 
            // nUDAddQuan
            // 
            this.nUDAddQuan.Location = new System.Drawing.Point(151, 161);
            this.nUDAddQuan.Margin = new System.Windows.Forms.Padding(4);
            this.nUDAddQuan.Name = "nUDAddQuan";
            this.nUDAddQuan.Size = new System.Drawing.Size(85, 22);
            this.nUDAddQuan.TabIndex = 17;
            this.nUDAddQuan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Quantity";
            // 
            // txtAddAuth
            // 
            this.txtAddAuth.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddAuth.Location = new System.Drawing.Point(151, 130);
            this.txtAddAuth.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddAuth.Name = "txtAddAuth";
            this.txtAddAuth.Size = new System.Drawing.Size(297, 22);
            this.txtAddAuth.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Author";
            // 
            // txtAddTitle
            // 
            this.txtAddTitle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddTitle.Location = new System.Drawing.Point(151, 93);
            this.txtAddTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddTitle.Name = "txtAddTitle";
            this.txtAddTitle.Size = new System.Drawing.Size(297, 22);
            this.txtAddTitle.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // rbAddMath
            // 
            this.rbAddMath.AutoSize = true;
            this.rbAddMath.Checked = true;
            this.rbAddMath.Location = new System.Drawing.Point(151, 199);
            this.rbAddMath.Name = "rbAddMath";
            this.rbAddMath.Size = new System.Drawing.Size(60, 21);
            this.rbAddMath.TabIndex = 21;
            this.rbAddMath.TabStop = true;
            this.rbAddMath.Text = "Math";
            this.rbAddMath.UseVisualStyleBackColor = true;
            // 
            // rbAddPhy
            // 
            this.rbAddPhy.AutoSize = true;
            this.rbAddPhy.Location = new System.Drawing.Point(217, 199);
            this.rbAddPhy.Name = "rbAddPhy";
            this.rbAddPhy.Size = new System.Drawing.Size(77, 21);
            this.rbAddPhy.TabIndex = 22;
            this.rbAddPhy.Text = "Physics";
            this.rbAddPhy.UseVisualStyleBackColor = true;
            // 
            // rbAddChem
            // 
            this.rbAddChem.AutoSize = true;
            this.rbAddChem.Location = new System.Drawing.Point(300, 199);
            this.rbAddChem.Name = "rbAddChem";
            this.rbAddChem.Size = new System.Drawing.Size(91, 21);
            this.rbAddChem.TabIndex = 23;
            this.rbAddChem.Text = "Chemistry";
            this.rbAddChem.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 234);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(297, 61);
            this.textBox1.TabIndex = 24;
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 387);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rbAddChem);
            this.Controls.Add(this.rbAddPhy);
            this.Controls.Add(this.rbAddMath);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nUDAddQuan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddAuth);
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
            ((System.ComponentModel.ISupportInitialize)(this.nUDAddQuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseAddBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nUDAddQuan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddAuth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbAddMath;
        private System.Windows.Forms.RadioButton rbAddPhy;
        private System.Windows.Forms.RadioButton rbAddChem;
        private System.Windows.Forms.TextBox textBox1;
    }
}