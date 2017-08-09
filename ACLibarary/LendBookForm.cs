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
    public partial class LendBookForm : Form
    {
        public LendBookForm()
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

        private void btnCloseAddBook_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - _, _, _); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {
            loadSelectedStudents();
        }

        private void txtStudentIndex_TextChanged(object sender, EventArgs e)
        {
            loadSelectedStudents();
        }

        private void cb12_CheckedChanged(object sender, EventArgs e)
        {
            loadSelectedStudents();
        }

        private void cb13_CheckedChanged(object sender, EventArgs e)
        {
            loadSelectedStudents();
        }

        private void clbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadSelectedStudents();
        }

        private async void btnLend_Click(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count > 0)
            {
                int selectedrowindex = dgvStudent.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvStudent.Rows[selectedrowindex];

                string lendStudent = (Convert.ToString(selectedRow.Cells["Index"].Value));

                Thread.Sleep(200);
                FirebaseResponse res = await _client.GetAsync("students/");
                IDictionary<string, Student> studentList = res.ResultAs<IDictionary<string, Student>>();
                
                foreach (KeyValuePair<string, Student> bok in studentList)
                {
                    if (bok.Value.index == lendStudent) {
                        await _client.SetAsync("students/"+bok.Key+"/borrowed", Holder.lendBook);
                        break;
                    }
                }

                Thread.Sleep(200);
                FirebaseResponse result = await _client.GetAsync("books/");
                IDictionary<string, Book> bookList = result.ResultAs<IDictionary<string, Book>>();

                foreach (KeyValuePair<string, Book> bok in bookList)
                {
                    if (bok.Value.refCode == Holder.lendBook)
                    {
                        await _client.SetAsync("books/" + bok.Key + "/holder", lendStudent);
                        break;
                    }
                }

                MessageBox.Show("Book sucessfully lent.", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

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
        private async void AddSubjectForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Holder.lendBook);
            lblRef.Text = Holder.lendBook;
            lblTitle.Text = Holder.lendTitle;
            lblAuth.Text = Holder.lendAuthor;
            LoadAllStudents();
            for (int i = 0; i < clbClass.Items.Count; i++)
                clbClass.SetItemChecked(i, true);


        }

        public async void LoadAllStudents()
        {
            Thread.Sleep(200);
            FirebaseResponse res = await _client.GetAsync("students/");
            IDictionary<string, Student> studentList = res.ResultAs<IDictionary<string, Student>>();
            dgvStudent.Rows.Clear();
            dgvStudent.Refresh();

            //List<Book> bookList = res.ResultAs<List<Book>>();
            foreach (KeyValuePair<string, Student> bok in studentList)
            {
                //MessageBox.Show(bok.Value.title);
                this.dgvStudent.Rows.Add(bok.Value.index, bok.Value.name, bok.Value.grade, bok.Value.cls, bok.Value.borrowed);
            }

        }

        public async void loadSelectedStudents()
        {
            txtStudentIndex.Text = "";
            Thread.Sleep(200);
            FirebaseResponse res = await _client.GetAsync("students/");
            IDictionary<string, Student> studentList = res.ResultAs<IDictionary<string, Student>>();
            dgvStudent.Rows.Clear();
            dgvStudent.Refresh();

            foreach (KeyValuePair<string, Student> bok in studentList)
            {
                if (this.txtStudentName.Text.Trim() == "")
                {
                    if ((bok.Value.grade == "12") && (cb12.Checked))
                    {
                        if ((bok.Value.cls == "1") && (clbClass.GetItemChecked(0)))
                        {
                            this.dgvStudent.Rows.Add(bok.Value.index, bok.Value.name, bok.Value.grade, bok.Value.cls, bok.Value.borrowed);
                        }
                        else if ((bok.Value.cls == "2") && (clbClass.GetItemChecked(1)))
                        {
                            this.dgvStudent.Rows.Add(bok.Value.index, bok.Value.name, bok.Value.grade, bok.Value.cls, bok.Value.borrowed);
                        }
                        else if ((bok.Value.cls == "3") && (clbClass.GetItemChecked(2)))
                        {
                            this.dgvStudent.Rows.Add(bok.Value.index, bok.Value.name, bok.Value.grade, bok.Value.cls, bok.Value.borrowed);
                        }
                        else if ((bok.Value.cls == "4") && (clbClass.GetItemChecked(3)))
                        {
                            this.dgvStudent.Rows.Add(bok.Value.index, bok.Value.name, bok.Value.grade, bok.Value.cls, bok.Value.borrowed);
                        }
                        else if ((bok.Value.cls == "5") && (clbClass.GetItemChecked(4)))
                        {
                            this.dgvStudent.Rows.Add(bok.Value.index, bok.Value.name, bok.Value.grade, bok.Value.cls, bok.Value.borrowed);
                        }
                        else if ((bok.Value.cls == "6") && (clbClass.GetItemChecked(5)))
                        {
                            this.dgvStudent.Rows.Add(bok.Value.index, bok.Value.name, bok.Value.grade, bok.Value.cls, bok.Value.borrowed);
                        }
                        else if ((bok.Value.cls == "7") && (clbClass.GetItemChecked(6)))
                        {
                            this.dgvStudent.Rows.Add(bok.Value.index, bok.Value.name, bok.Value.grade, bok.Value.cls, bok.Value.borrowed);
                        }
                        else if ((bok.Value.cls == "E") && (clbClass.GetItemChecked(7)))
                        {
                            this.dgvStudent.Rows.Add(bok.Value.index, bok.Value.name, bok.Value.grade, bok.Value.cls, bok.Value.borrowed);
                        }

                    }
                    else if ((bok.Value.grade == "13") && (cb13.Checked))
                    {
                        if ((bok.Value.cls == "1") && (clbClass.GetItemChecked(0)))
                        {
                            this.dgvStudent.Rows.Add(bok.Value.index, bok.Value.name, bok.Value.grade, bok.Value.cls, bok.Value.borrowed);
                        }
                        else if ((bok.Value.cls == "2") && (clbClass.GetItemChecked(1)))
                        {
                            this.dgvStudent.Rows.Add(bok.Value.index, bok.Value.name, bok.Value.grade, bok.Value.cls, bok.Value.borrowed);
                        }
                        else if ((bok.Value.cls == "3") && (clbClass.GetItemChecked(2)))
                        {
                            this.dgvStudent.Rows.Add(bok.Value.index, bok.Value.name, bok.Value.grade, bok.Value.cls, bok.Value.borrowed);
                        }
                        else if ((bok.Value.cls == "4") && (clbClass.GetItemChecked(3)))
                        {
                            this.dgvStudent.Rows.Add(bok.Value.index, bok.Value.name, bok.Value.grade, bok.Value.cls, bok.Value.borrowed);
                        }
                        else if ((bok.Value.cls == "5") && (clbClass.GetItemChecked(4)))
                        {
                            this.dgvStudent.Rows.Add(bok.Value.index, bok.Value.name, bok.Value.grade, bok.Value.cls, bok.Value.borrowed);
                        }
                        else if ((bok.Value.cls == "6") && (clbClass.GetItemChecked(5)))
                        {
                            this.dgvStudent.Rows.Add(bok.Value.index, bok.Value.name, bok.Value.grade, bok.Value.cls, bok.Value.borrowed);
                        }
                        else if ((bok.Value.cls == "7") && (clbClass.GetItemChecked(6)))
                        {
                            this.dgvStudent.Rows.Add(bok.Value.index, bok.Value.name, bok.Value.grade, bok.Value.cls, bok.Value.borrowed);
                        }
                        else if ((bok.Value.cls == "E") && (clbClass.GetItemChecked(7)))
                        {
                            this.dgvStudent.Rows.Add(bok.Value.index, bok.Value.name, bok.Value.grade, bok.Value.cls, bok.Value.borrowed);
                        }
                    }
                }
                else if (bok.Value.name.ToLower().Contains(this.txtStudentName.Text.Trim().ToLower()))
                {
                    if ((bok.Value.grade == "12") && (cb12.Checked))
                    {
                        if ((bok.Value.cls == "1") && (clbClass.GetItemChecked(0)))
                        {
                            this.dgvStudent.Rows.Add(bok.Value.index, bok.Value.name, bok.Value.grade, bok.Value.cls, bok.Value.borrowed);
                        }
                        else if ((bok.Value.cls == "2") && (clbClass.GetItemChecked(1)))
                        {
                            this.dgvStudent.Rows.Add(bok.Value.index, bok.Value.name, bok.Value.grade, bok.Value.cls, bok.Value.borrowed);
                        }
                        else if ((bok.Value.cls == "3") && (clbClass.GetItemChecked(2)))
                        {
                            this.dgvStudent.Rows.Add(bok.Value.index, bok.Value.name, bok.Value.grade, bok.Value.cls, bok.Value.borrowed);
                        }
                        else if ((bok.Value.cls == "4") && (clbClass.GetItemChecked(3)))
                        {
                            this.dgvStudent.Rows.Add(bok.Value.index, bok.Value.name, bok.Value.grade, bok.Value.cls, bok.Value.borrowed);
                        }
                        else if ((bok.Value.cls == "5") && (clbClass.GetItemChecked(4)))
                        {
                            this.dgvStudent.Rows.Add(bok.Value.index, bok.Value.name, bok.Value.grade, bok.Value.cls, bok.Value.borrowed);
                        }
                        else if ((bok.Value.cls == "6") && (clbClass.GetItemChecked(5)))
                        {
                            this.dgvStudent.Rows.Add(bok.Value.index, bok.Value.name, bok.Value.grade, bok.Value.cls, bok.Value.borrowed);
                        }
                        else if ((bok.Value.cls == "7") && (clbClass.GetItemChecked(6)))
                        {
                            this.dgvStudent.Rows.Add(bok.Value.index, bok.Value.name, bok.Value.grade, bok.Value.cls, bok.Value.borrowed);
                        }
                        else if ((bok.Value.cls == "E") && (clbClass.GetItemChecked(7)))
                        {
                            this.dgvStudent.Rows.Add(bok.Value.index, bok.Value.name, bok.Value.grade, bok.Value.cls, bok.Value.borrowed);
                        }

                    }
                    else if ((bok.Value.grade == "13") && (cb13.Checked))
                    {
                        if ((bok.Value.cls == "1") && (clbClass.GetItemChecked(0)))
                        {
                            this.dgvStudent.Rows.Add(bok.Value.index, bok.Value.name, bok.Value.grade, bok.Value.cls, bok.Value.borrowed);
                        }
                        else if ((bok.Value.cls == "2") && (clbClass.GetItemChecked(1)))
                        {
                            this.dgvStudent.Rows.Add(bok.Value.index, bok.Value.name, bok.Value.grade, bok.Value.cls, bok.Value.borrowed);
                        }
                        else if ((bok.Value.cls == "3") && (clbClass.GetItemChecked(2)))
                        {
                            this.dgvStudent.Rows.Add(bok.Value.index, bok.Value.name, bok.Value.grade, bok.Value.cls, bok.Value.borrowed);
                        }
                        else if ((bok.Value.cls == "4") && (clbClass.GetItemChecked(3)))
                        {
                            this.dgvStudent.Rows.Add(bok.Value.index, bok.Value.name, bok.Value.grade, bok.Value.cls, bok.Value.borrowed);
                        }
                        else if ((bok.Value.cls == "5") && (clbClass.GetItemChecked(4)))
                        {
                            this.dgvStudent.Rows.Add(bok.Value.index, bok.Value.name, bok.Value.grade, bok.Value.cls, bok.Value.borrowed);
                        }
                        else if ((bok.Value.cls == "6") && (clbClass.GetItemChecked(5)))
                        {
                            this.dgvStudent.Rows.Add(bok.Value.index, bok.Value.name, bok.Value.grade, bok.Value.cls, bok.Value.borrowed);
                        }
                        else if ((bok.Value.cls == "7") && (clbClass.GetItemChecked(6)))
                        {
                            this.dgvStudent.Rows.Add(bok.Value.index, bok.Value.name, bok.Value.grade, bok.Value.cls, bok.Value.borrowed);
                        }
                        else if ((bok.Value.cls == "E") && (clbClass.GetItemChecked(7)))
                        {
                            this.dgvStudent.Rows.Add(bok.Value.index, bok.Value.name, bok.Value.grade, bok.Value.cls, bok.Value.borrowed);
                        }
                    }
                }
            }
        }
    }
}
