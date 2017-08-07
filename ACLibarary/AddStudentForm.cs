using ACLibarary.Classes;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACLibarary
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true); // this is to avoid visual artifacts
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            btnAddStudent.Enabled = false;
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

        private void btnCloseMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAddStudent_Click(object sender, EventArgs e)
        {
            string addGrade;
            string addClass;

            if (rb12.Checked)
            {
                addGrade = "12";
            }
            else {
                addGrade = "13";
            }

            if (rb1.Checked)
            {
                addClass = "1";
            }
            else if(rb2.Checked)
            {
                addClass = "2";
            }
            else if (rb3.Checked)
            {
                addClass = "3";
            }
            else if (rb4.Checked)
            {
                addClass = "4";
            }
            else if (rb5.Checked)
            {
                addClass = "5";
            }
            else if (rb6.Checked)
            {
                addClass = "6";
            }
            else if (rb7.Checked)
            {
                addClass = "7";
            }
            else 
            {
                addClass = "E";
            }

            var student = new Student
            {
                name = txtStudName.Text,
                index=txtIndex.Text,
                grade=addGrade,
                cls=addClass,
                borrowed=""
            };


            PushResponse response = await _client.PushAsync("students/", student);
            MessageBox.Show("New student sucessfullay added.", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }

        private async void txtIndex_TextChanged(object sender, EventArgs e)
        {
            bool isExist=false;
            FirebaseResponse res = await _client.GetAsync("students/");
            IDictionary<string, Student> studentList = res.ResultAs<IDictionary<string, Student>>();

            if (studentList != null)
            {

                //List<Book> bookList = res.ResultAs<List<Book>>();
                foreach (KeyValuePair<string, Student> student in studentList)
                {
                    if (student.Value.index == txtIndex.Text)
                    {
                        isExist = true;
                    }
                }

                if ((isExist))
                {
                    lblIndex.Text = "*Index number allready exists.";
                    btnAddStudent.Enabled = false;
                }
                else
                {
                    lblIndex.Text = "";
                    if ((txtStudName.Text != "") && (txtIndex.Text != ""))
                    {
                        btnAddStudent.Enabled = true;
                    }
                    else {
                        btnAddStudent.Enabled = false;
                    }
                }
            }
            else {
                if ((txtStudName.Text != "") && (txtIndex.Text != ""))
                {
                    btnAddStudent.Enabled = true;
                }
                else
                {
                    btnAddStudent.Enabled = false;
                }
            }

        }

        private void txtStudName_TextChanged(object sender, EventArgs e)
        {
            //if ((!System.Text.RegularExpressions.Regex.IsMatch(txtStudName.Text, "[a-zA-Z]"))&&(txtStudName.Text.Length>0))
            //{
            //    MessageBox.Show("This textbox accepts only alphabetical characters");
            //    txtStudName.Text.Remove(txtStudName.Text.Length - 1);
            //}
            //txtStudName.Text = string.Concat(txtStudName.Text.Where(char.IsLetter));

            if ((txtStudName.Text != "") && (txtIndex.Text != ""))
            {
                btnAddStudent.Enabled = true;
            }
            else
            {
                btnAddStudent.Enabled = false;
            }
        }

        private void txtStudName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }

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
    }
}
