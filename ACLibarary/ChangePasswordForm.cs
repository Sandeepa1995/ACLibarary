﻿using ACLibarary.Classes;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACLibarary
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true); // this is to avoid visual artifacts
        }

        protected override void OnPaint(PaintEventArgs e) // you can safely omit this method if you want
        {
            e.Graphics.FillRectangle(Brushes.Maroon, Top);
            e.Graphics.FillRectangle(Brushes.Maroon, Left);
            e.Graphics.FillRectangle(Brushes.Maroon, Right);
            e.Graphics.FillRectangle(Brushes.Maroon, Bottom);
        }

        private const int
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17;

        const int _ = 10; // you can rename this variable if you like

        Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, _); } }
        Rectangle Left { get { return new Rectangle(0, 0, _, this.ClientSize.Height); } }
        Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); } }
        Rectangle Right { get { return new Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }

        Rectangle TopLeft { get { return new Rectangle(0, 0, _, _); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - _, 0, _, _); } }


        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - _, _, _); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }


        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;


        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST)
                message.Result = (IntPtr)(HT_CAPTION);

            if (message.Msg == 0x84) // WM_NCHITTEST
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (Top.Contains(cursor)) message.Result = (IntPtr)HTTOP;
                else if (Left.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                else if (Right.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                else if (Bottom.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
            }
        }

        static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = Encryption.ciphperString,
            BasePath = "https://anandamathslib.firebaseio.com/"
        };
        IFirebaseClient _client = new FirebaseClient(config);

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {

        }

        private async void btnChangePass_Click(object sender, EventArgs e)
        {
            if (txtPassCurrent.Text == Encryption.enteredPass)
            {
                if (txtPassNew.Text == txtPassNewRe.Text)
                {
                    string newAccess = Encryption.Encrypt(Encryption.ciphperString, txtPassNew.Text);
                    Thread.Sleep(200);
                    await _client.SetAsync("key/authSecret",newAccess );
                    MessageBox.Show("Password changed sucessfully.", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The new passowrds do not match.", "Incorrect passwords", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("The current password entered is incorrect.", "Incorrect password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSeePass_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassCurrent.PasswordChar = '\0';
            txtPassNew.PasswordChar = '\0';
            txtPassNewRe.PasswordChar = '\0';

        }

        private void btnSeePass_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassCurrent.PasswordChar = '*';
            txtPassNew.PasswordChar = '*';
            txtPassNewRe.PasswordChar = '*';
        }

        private void btnCloseMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
