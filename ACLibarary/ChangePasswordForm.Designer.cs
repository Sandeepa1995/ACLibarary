namespace ACLibarary
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.btnCloseMain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassCurrent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassNew = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassNewRe = new System.Windows.Forms.TextBox();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnSeePass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCloseMain
            // 
            this.btnCloseMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseMain.FlatAppearance.BorderSize = 0;
            this.btnCloseMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseMain.Location = new System.Drawing.Point(464, 23);
            this.btnCloseMain.Name = "btnCloseMain";
            this.btnCloseMain.Size = new System.Drawing.Size(32, 28);
            this.btnCloseMain.TabIndex = 2;
            this.btnCloseMain.Text = "X";
            this.btnCloseMain.UseVisualStyleBackColor = true;
            this.btnCloseMain.Click += new System.EventHandler(this.btnCloseMain_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Password :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPassCurrent
            // 
            this.txtPassCurrent.Location = new System.Drawing.Point(215, 75);
            this.txtPassCurrent.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassCurrent.Name = "txtPassCurrent";
            this.txtPassCurrent.PasswordChar = '*';
            this.txtPassCurrent.Size = new System.Drawing.Size(265, 22);
            this.txtPassCurrent.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "New Password :";
            // 
            // txtPassNew
            // 
            this.txtPassNew.Location = new System.Drawing.Point(215, 105);
            this.txtPassNew.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassNew.Name = "txtPassNew";
            this.txtPassNew.PasswordChar = '*';
            this.txtPassNew.Size = new System.Drawing.Size(265, 22);
            this.txtPassNew.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Re-type New Password :";
            // 
            // txtPassNewRe
            // 
            this.txtPassNewRe.Location = new System.Drawing.Point(215, 135);
            this.txtPassNewRe.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassNewRe.Name = "txtPassNewRe";
            this.txtPassNewRe.PasswordChar = '*';
            this.txtPassNewRe.Size = new System.Drawing.Size(265, 22);
            this.txtPassNewRe.TabIndex = 8;
            // 
            // btnChangePass
            // 
            this.btnChangePass.Location = new System.Drawing.Point(43, 172);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(437, 46);
            this.btnChangePass.TabIndex = 9;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnSeePass
            // 
            this.btnSeePass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSeePass.BackgroundImage")));
            this.btnSeePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeePass.FlatAppearance.BorderSize = 0;
            this.btnSeePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeePass.Location = new System.Drawing.Point(430, 24);
            this.btnSeePass.Name = "btnSeePass";
            this.btnSeePass.Size = new System.Drawing.Size(28, 26);
            this.btnSeePass.TabIndex = 10;
            this.btnSeePass.UseVisualStyleBackColor = true;
            this.btnSeePass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSeePass_MouseDown);
            this.btnSeePass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSeePass_MouseUp);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 264);
            this.Controls.Add(this.btnSeePass);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassNewRe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassCurrent);
            this.Controls.Add(this.btnCloseMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePasswordForm";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassCurrent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassNewRe;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button btnSeePass;
    }
}