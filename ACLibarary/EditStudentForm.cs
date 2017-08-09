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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACLibarary
{
    public partial class EditStudentForm : Form
    {
        string key;
        string borrowed;
        public EditStudentForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true); // this is to avoid visual artifacts
        }



        static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = Encryption.ciphperString,
            BasePath = "https://anandamathslib.firebaseio.com/"
        };
        IFirebaseClient _client = new FirebaseClient(config);

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

        private void btnCloseMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnEditStudent_Click(object sender, EventArgs e)
        {
            string addGrade;
            string addClass;

            if (rb12.Checked)
            {
                addGrade = "12";
            }
            else
            {
                addGrade = "13";
            }

            if (rb1.Checked)
            {
                addClass = "1";
            }
            else if (rb2.Checked)
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
                index = txtIndex.Text,
                grade = addGrade,
                cls = addClass,
                borrowed = borrowed
            };


            SetResponse response = await _client.SetAsync("students/"+key, student);
            MessageBox.Show("Student sucessfullay edited.", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }

        private async void txtIndex_TextChanged(object sender, EventArgs e)
        {
            bool isExist = false;
            Thread.Sleep(200);
            FirebaseResponse res = await _client.GetAsync("students/");
            IDictionary<string, Student> studentList = res.ResultAs<IDictionary<string, Student>>();

                //List<Book> bookList = res.ResultAs<List<Book>>();
                foreach (KeyValuePair<string, Student> student in studentList)
                {
                    if (student.Value.index == txtIndex.Text)
                    {
                        isExist = true;
                    }
                }

                if ((isExist)&&(Holder.editStudent!=txtIndex.Text))
                {
                    lblIndex.Text = "*Index number allready exists.";
                    btnEditStudent.Enabled = false;
                }
                else
                {
                    lblIndex.Text = "";
                    if ((txtStudName.Text != "") && (txtIndex.Text != ""))
                    {
                        btnEditStudent.Enabled = true;
                    }
                    else
                    {
                        btnEditStudent.Enabled = false;
                    }
                }
        }

        private void txtStudName_TextChanged(object sender, EventArgs e)
        {
            if ((txtStudName.Text != "") && (txtIndex.Text != ""))
            {
                btnEditStudent.Enabled = true;
            }
            else
            {
                btnEditStudent.Enabled = false;
            }
        }

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
        private async void EditStudentForm_Load(object sender, EventArgs e)
        {
            Thread.Sleep(200);
            FirebaseResponse res = await _client.GetAsync("students/");
            IDictionary<string, Student> studentList = res.ResultAs<IDictionary<string, Student>>();

            //List<Book> bookList = res.ResultAs<List<Book>>();
            foreach (KeyValuePair<string, Student> bok in studentList)
            {
                if (bok.Value.index == Holder.editStudent) {
                    key = bok.Key;
                    borrowed = bok.Value.borrowed;
                    txtStudName.Text = bok.Value.name;
                    txtIndex.Text = bok.Value.index;

                    if (bok.Value.grade == "12") {
                        rb12.Checked = true;
                    }
                    else if (bok.Value.grade == "13")
                    {
                        rb13.Checked = true;
                    }

                    if (bok.Value.cls == "1")
                    {
                        rb1.Checked = true;
                    }
                    else if (bok.Value.cls == "2")
                    {
                        rb2.Checked = true;
                    }
                    else if (bok.Value.cls == "3")
                    {
                        rb3.Checked = true;
                    }
                    else if (bok.Value.cls == "4")
                    {
                        rb4.Checked = true;
                    }
                    else if (bok.Value.cls == "5")
                    {
                        rb5.Checked = true;
                    }
                    else if (bok.Value.cls == "6")
                    {
                        rb6.Checked = true;
                    }
                    else if (bok.Value.cls == "7")
                    {
                        rb7.Checked = true;
                    }
                    else if (bok.Value.cls == "E")
                    {
                        rbE.Checked = true;
                    }
                }
                
            }
        }
    }
}
