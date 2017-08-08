namespace ACLibarary
{
    partial class AddSubjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSubjectForm));
            this.btnCloseAddBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCloseAddBook
            // 
            this.btnCloseAddBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseAddBook.FlatAppearance.BorderSize = 0;
            this.btnCloseAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseAddBook.Location = new System.Drawing.Point(442, 28);
            this.btnCloseAddBook.Name = "btnCloseAddBook";
            this.btnCloseAddBook.Size = new System.Drawing.Size(32, 28);
            this.btnCloseAddBook.TabIndex = 3;
            this.btnCloseAddBook.Text = "X";
            this.btnCloseAddBook.UseVisualStyleBackColor = true;
            this.btnCloseAddBook.Click += new System.EventHandler(this.btnCloseAddBook_Click);
            // 
            // AddSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 459);
            this.Controls.Add(this.btnCloseAddBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddSubjectForm";
            this.Text = "AddSubjectForm";
            this.Load += new System.EventHandler(this.AddSubjectForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCloseAddBook;
    }
}