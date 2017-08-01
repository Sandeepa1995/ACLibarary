namespace ACLibarary
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUserPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCloseMain = new System.Windows.Forms.Button();
            this.btnMinimizeMain = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.refCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBookCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookAuth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.r2 = new System.Windows.Forms.RadioButton();
            this.r1 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.chkMath = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chkChem = new System.Windows.Forms.CheckBox();
            this.chkPhysics = new System.Windows.Forms.CheckBox();
            this.menuMain.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Dock = System.Windows.Forms.DockStyle.None;
            this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(18, 12);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(126, 28);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentToolStripMenuItem,
            this.addNewBookToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.addNewStudentToolStripMenuItem.Text = "Add New Student";
            this.addNewStudentToolStripMenuItem.Click += new System.EventHandler(this.addNewStudentToolStripMenuItem_Click);
            // 
            // addNewBookToolStripMenuItem
            // 
            this.addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            this.addNewBookToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.addNewBookToolStripMenuItem.Text = "Add New Book";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeUserPasswordToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.editToolStripMenuItem.Text = "Settings";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // changeUserPasswordToolStripMenuItem
            // 
            this.changeUserPasswordToolStripMenuItem.Name = "changeUserPasswordToolStripMenuItem";
            this.changeUserPasswordToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.changeUserPasswordToolStripMenuItem.Text = "Change User Password";
            // 
            // btnCloseMain
            // 
            this.btnCloseMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseMain.FlatAppearance.BorderSize = 0;
            this.btnCloseMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseMain.Location = new System.Drawing.Point(898, 12);
            this.btnCloseMain.Name = "btnCloseMain";
            this.btnCloseMain.Size = new System.Drawing.Size(32, 28);
            this.btnCloseMain.TabIndex = 1;
            this.btnCloseMain.Text = "X";
            this.btnCloseMain.UseVisualStyleBackColor = true;
            this.btnCloseMain.Click += new System.EventHandler(this.btnCloseMain_Click);
            // 
            // btnMinimizeMain
            // 
            this.btnMinimizeMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizeMain.FlatAppearance.BorderSize = 0;
            this.btnMinimizeMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizeMain.Location = new System.Drawing.Point(860, 12);
            this.btnMinimizeMain.Name = "btnMinimizeMain";
            this.btnMinimizeMain.Size = new System.Drawing.Size(32, 28);
            this.btnMinimizeMain.TabIndex = 2;
            this.btnMinimizeMain.Text = "_";
            this.btnMinimizeMain.UseVisualStyleBackColor = true;
            this.btnMinimizeMain.Click += new System.EventHandler(this.btnMinimizeMain_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(18, 47);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(916, 479);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.dgvBooks);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(908, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Books";
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.refCode,
            this.title,
            this.type,
            this.author,
            this.holder});
            this.dgvBooks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBooks.Location = new System.Drawing.Point(8, 123);
            this.dgvBooks.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBooks.MultiSelect = false;
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.RowHeadersVisible = false;
            this.dgvBooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(893, 320);
            this.dgvBooks.TabIndex = 4;
            // 
            // refCode
            // 
            this.refCode.HeaderText = "Reference Code";
            this.refCode.Name = "refCode";
            this.refCode.ReadOnly = true;
            // 
            // title
            // 
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // author
            // 
            this.author.HeaderText = "Author";
            this.author.Name = "author";
            this.author.ReadOnly = true;
            // 
            // holder
            // 
            this.holder.HeaderText = "Holder";
            this.holder.Name = "holder";
            this.holder.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBookCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBookAuth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBookTitle);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(893, 108);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkChem);
            this.groupBox2.Controls.Add(this.chkPhysics);
            this.groupBox2.Controls.Add(this.chkMath);
            this.groupBox2.Location = new System.Drawing.Point(471, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(261, 43);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(740, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 73);
            this.button1.TabIndex = 10;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ref Code";
            // 
            // txtBookCode
            // 
            this.txtBookCode.Location = new System.Drawing.Point(547, 72);
            this.txtBookCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookCode.Name = "txtBookCode";
            this.txtBookCode.Size = new System.Drawing.Size(179, 22);
            this.txtBookCode.TabIndex = 8;
            this.txtBookCode.TextChanged += new System.EventHandler(this.txtBookCode_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Author";
            // 
            // txtBookAuth
            // 
            this.txtBookAuth.Location = new System.Drawing.Point(76, 71);
            this.txtBookAuth.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookAuth.Name = "txtBookAuth";
            this.txtBookAuth.Size = new System.Drawing.Size(385, 22);
            this.txtBookAuth.TabIndex = 2;
            this.txtBookAuth.TextChanged += new System.EventHandler(this.txtBookAuth_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(76, 28);
            this.txtBookTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(385, 22);
            this.txtBookTitle.TabIndex = 1;
            this.txtBookTitle.TextChanged += new System.EventHandler(this.txtBookTitle_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(908, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Students";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 79);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(893, 357);
            this.dataGridView2.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.r2);
            this.groupBox3.Controls.Add(this.r1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Location = new System.Drawing.Point(11, 7);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(887, 64);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // r2
            // 
            this.r2.AutoSize = true;
            this.r2.Location = new System.Drawing.Point(319, 28);
            this.r2.Margin = new System.Windows.Forms.Padding(4);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(45, 21);
            this.r2.TabIndex = 9;
            this.r2.Text = "13";
            this.r2.UseVisualStyleBackColor = false;
            // 
            // r1
            // 
            this.r1.AutoSize = true;
            this.r1.Checked = true;
            this.r1.Location = new System.Drawing.Point(227, 28);
            this.r1.Margin = new System.Windows.Forms.Padding(4);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(45, 21);
            this.r1.TabIndex = 8;
            this.r1.TabStop = true;
            this.r1.Text = "12";
            this.r1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(768, 23);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Index";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(79, 28);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(123, 22);
            this.textBox4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Name";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(442, 26);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(305, 22);
            this.textBox5.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(909, 525);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 24);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // chkMath
            // 
            this.chkMath.AutoSize = true;
            this.chkMath.Checked = true;
            this.chkMath.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMath.Location = new System.Drawing.Point(7, 15);
            this.chkMath.Name = "chkMath";
            this.chkMath.Size = new System.Drawing.Size(61, 21);
            this.chkMath.TabIndex = 5;
            this.chkMath.Text = "Math";
            this.chkMath.UseVisualStyleBackColor = true;
            this.chkMath.CheckedChanged += new System.EventHandler(this.chkMath_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(-19, -19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // chkChem
            // 
            this.chkChem.AutoSize = true;
            this.chkChem.Checked = true;
            this.chkChem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChem.Location = new System.Drawing.Point(158, 15);
            this.chkChem.Name = "chkChem";
            this.chkChem.Size = new System.Drawing.Size(92, 21);
            this.chkChem.TabIndex = 7;
            this.chkChem.Text = "Chemistry";
            this.chkChem.UseVisualStyleBackColor = true;
            this.chkChem.CheckedChanged += new System.EventHandler(this.chkChem_CheckedChanged);
            // 
            // chkPhysics
            // 
            this.chkPhysics.AutoSize = true;
            this.chkPhysics.Checked = true;
            this.chkPhysics.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPhysics.Location = new System.Drawing.Point(74, 15);
            this.chkPhysics.Name = "chkPhysics";
            this.chkPhysics.Size = new System.Drawing.Size(78, 21);
            this.chkPhysics.TabIndex = 5;
            this.chkPhysics.Text = "Physics";
            this.chkPhysics.UseVisualStyleBackColor = true;
            this.chkPhysics.CheckedChanged += new System.EventHandler(this.chkPhysics_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 568);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnMinimizeMain);
            this.Controls.Add(this.btnCloseMain);
            this.Controls.Add(this.menuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AC_Libr@ry";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentToolStripMenuItem;
        private System.Windows.Forms.Button btnCloseMain;
        private System.Windows.Forms.Button btnMinimizeMain;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeUserPasswordToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBookCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookAuth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton r2;
        private System.Windows.Forms.RadioButton r1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn refCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn holder;
        private System.Windows.Forms.CheckBox chkMath;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chkChem;
        private System.Windows.Forms.CheckBox chkPhysics;
    }
}