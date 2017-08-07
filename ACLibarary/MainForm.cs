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
    public partial class MainForm : Form
    {
        public MainForm()
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

        private void Main_Load(object sender, EventArgs e)
        {
            LoadAllBooks();
            for (int i = 0; i < clbClass.Items.Count; i++)
                clbClass.SetItemChecked(i, true);
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


        private void btnMinimizeMain_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


       

        private void chkMath_CheckedChanged(object sender, EventArgs e)
        {
            loadSelectedType();
        }

        private void chkPhysics_CheckedChanged(object sender, EventArgs e)
        {
            loadSelectedType();
        }

        private void changeUserPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm cPF = new ChangePasswordForm();
            cPF.ShowDialog();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void newBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookForm aBF = new AddBookForm();
            aBF.ShowDialog();
        }

        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm aSF = new AddStudentForm();
            aSF.ShowDialog();
        }

        private void clbClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkChem_CheckedChanged(object sender, EventArgs e)
        {
            loadSelectedType();
        }

        private void txtBookTitle_TextChanged(object sender, EventArgs e)
        {
            loadSelectedType();
        }

        private void txtBookAuth_TextChanged(object sender, EventArgs e)
        {
            loadSelectedType();
        }

        private async void txtBookCode_TextChanged(object sender, EventArgs e)
        {
            txtBookAuth.Text = "";
            txtBookTitle.Text = "";
            chkMath.Checked = true;
            chkPhysics.Checked = true;
            chkChem.Checked = true;
            FirebaseResponse res = await _client.GetAsync("books/");
            IDictionary<string, Book> bookList = res.ResultAs<IDictionary<string, Book>>();
            dgvBooks.Rows.Clear();
            dgvBooks.Refresh();

            foreach (KeyValuePair<string, Book> bok in bookList)
            {           
                if (bok.Value.refCode.ToLower().Contains(txtBookCode.Text.ToLower()))
                {
                    this.dgvBooks.Rows.Add(bok.Value.refCode, bok.Value.title, bok.Value.type, bok.Value.author, bok.Value.holder);
                }
            }
        }

        

        private void btnCloseMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public async void LoadAllBooks() {
            FirebaseResponse res = await _client.GetAsync("books/");
            IDictionary<string, Book> bookList = res.ResultAs<IDictionary<string, Book>>();

            //List<Book> bookList = res.ResultAs<List<Book>>();
            foreach (KeyValuePair<string, Book> bok in bookList) {
                //MessageBox.Show(bok.Value.title);
                this.dgvBooks.Rows.Add(bok.Value.refCode, bok.Value.title, bok.Value.type, bok.Value.author, bok.Value.holder);
            }
        }

        public async void loadSelectedType() {
            txtBookCode.Text = "";
            FirebaseResponse res = await _client.GetAsync("books/");
            IDictionary<string, Book> bookList = res.ResultAs<IDictionary<string, Book>>();
            dgvBooks.Rows.Clear();
            dgvBooks.Refresh();

            foreach (KeyValuePair<string, Book> bok in bookList)
            {
                if ((txtBookAuth.Text.Trim() == "") && (txtBookTitle.Text.Trim() == ""))
                {
                    if ((bok.Value.type == "Math") && (this.chkMath.Checked))
                    {
                        this.dgvBooks.Rows.Add(bok.Value.refCode, bok.Value.title, bok.Value.type, bok.Value.author, bok.Value.holder);
                    }
                    else if ((bok.Value.type == "Physics") && (this.chkPhysics.Checked))
                    {
                        this.dgvBooks.Rows.Add(bok.Value.refCode, bok.Value.title, bok.Value.type, bok.Value.author, bok.Value.holder);
                    }
                    else if ((bok.Value.type == "Chemistry") && (this.chkChem.Checked))
                    {
                        this.dgvBooks.Rows.Add(bok.Value.refCode, bok.Value.title, bok.Value.type, bok.Value.author, bok.Value.holder);
                    }
                }
                else if ((txtBookAuth.Text.Trim() == ""))
                {
                    if (bok.Value.title.ToLower().Contains(txtBookTitle.Text.ToLower()))
                    {
                        if ((bok.Value.type == "Math") && (this.chkMath.Checked))
                        {
                            this.dgvBooks.Rows.Add(bok.Value.refCode, bok.Value.title, bok.Value.type, bok.Value.author, bok.Value.holder);
                        }
                        else if ((bok.Value.type == "Physics") && (this.chkPhysics.Checked))
                        {
                            this.dgvBooks.Rows.Add(bok.Value.refCode, bok.Value.title, bok.Value.type, bok.Value.author, bok.Value.holder);
                        }
                        else if ((bok.Value.type == "Chemistry") && (this.chkChem.Checked))
                        {
                            this.dgvBooks.Rows.Add(bok.Value.refCode, bok.Value.title, bok.Value.type, bok.Value.author, bok.Value.holder);
                        }
                    }
                }
                else if ((txtBookTitle.Text.Trim() == ""))
                {
                    if ((bok.Value.author.ToLower().Contains(txtBookAuth.Text.ToLower())))
                    {
                        if ((bok.Value.type == "Math") && (this.chkMath.Checked))
                        {
                            this.dgvBooks.Rows.Add(bok.Value.refCode, bok.Value.title, bok.Value.type, bok.Value.author, bok.Value.holder);
                        }
                        else if ((bok.Value.type == "Physics") && (this.chkPhysics.Checked))
                        {
                            this.dgvBooks.Rows.Add(bok.Value.refCode, bok.Value.title, bok.Value.type, bok.Value.author, bok.Value.holder);
                        }
                        else if ((bok.Value.type == "Chemistry") && (this.chkChem.Checked))
                        {
                            this.dgvBooks.Rows.Add(bok.Value.refCode, bok.Value.title, bok.Value.type, bok.Value.author, bok.Value.holder);
                        }
                    }
                }
                else 
                {
                    if ((bok.Value.title.ToLower().Contains(txtBookTitle.Text.ToLower()))&&(bok.Value.author.ToLower().Contains(txtBookAuth.Text.ToLower())))
                    {
                        if ((bok.Value.type == "Math") && (this.chkMath.Checked))
                        {
                            this.dgvBooks.Rows.Add(bok.Value.refCode, bok.Value.title, bok.Value.type, bok.Value.author, bok.Value.holder);
                        }
                        else if ((bok.Value.type == "Physics") && (this.chkPhysics.Checked))
                        {
                            this.dgvBooks.Rows.Add(bok.Value.refCode, bok.Value.title, bok.Value.type, bok.Value.author, bok.Value.holder);
                        }
                        else if ((bok.Value.type == "Chemistry") && (this.chkChem.Checked))
                        {
                            this.dgvBooks.Rows.Add(bok.Value.refCode, bok.Value.title, bok.Value.type, bok.Value.author, bok.Value.holder);
                        }
                    }
                }
            }
        }
    }
}
