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
    public partial class AddBookForm : Form
    {

        //private ToolTip _toolTip = new ToolTip();
        //private Control _currentToolTipControl = null;

        private string abrAuth="";
        private string abrSub="";
        private string abrType="";
        private string abrStream="";
        private List<string> toAddRefs = new List<string>();
        private int bookindx;

        private string newSubAbr;

        public AddBookForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true); // this is to avoid visual artifacts
            //_toolTip.SetToolTip(this.btnAddBook, "You cannot add a bool unless it has a title as well as a author and subject which are added to the database.");
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
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - _, _, _); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }

        private async void cmbAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            FirebaseResponse res = await _client.GetAsync("authors/"+cmbAuthor.Text);
            string auth = res.ResultAs<string>();

            abrAuth = auth;
        }

        private async void cmbAuthor_TextChanged(object sender, EventArgs e)
        {
            bool isMatch=false;
            FirebaseResponse res = await _client.GetAsync("authors/");
            IDictionary<string, string> authList = res.ResultAs<IDictionary<string, string>>();

            //List<Book> bookList = res.ResultAs<List<Book>>();
            foreach (KeyValuePair<string, string> bok in authList)
            {
                if (bok.Key == cmbAuthor.Text) {
                    isMatch = true;
                }
            }

            if (!isMatch)
            {
                btnAddAuthor.Enabled = true;
                btnAddBook.Enabled = false;
                btnAddAuthor.Visible = true;
            }
            else {
                btnAddAuthor.Enabled = false;
                btnAddAuthor.Visible = false;
                checkToAdd();
            }
        }

        private async void btnAddAuthor_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to add this author to the database?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string text = cmbAuthor.Text;
                string firstLetters = "";

                foreach (var part in text.Split(' '))
                {
                    firstLetters += part.Substring(0, 1);
                }

                //MessageBox.Show(firstLetters.ToUpper());
                SetResponse response = await _client.SetAsync("authors/" + cmbAuthor.Text, firstLetters.ToUpper() );
                MessageBox.Show("New author sucessfullay added.", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                abrAuth = firstLetters;
                btnAddAuthor.Enabled = false;
                btnAddAuthor.Visible = false;
                checkToAdd();
            }
        }

        private void btnCloseAddBook_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAddTitle_TextChanged(object sender, EventArgs e)
        {
            checkToAdd();
        }

        private void AddBookForm_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            string nbstream;
            string nbtype;

            if (rbAddMath.Checked)
            {
                nbstream = "Math";
            }
            else if (rbAddPhy.Checked)
            {
                nbstream = "Physics";
            }
            else if (rbAddChem.Checked)
            {
                nbstream = "Chemistry";
            }
            else
            {
                nbstream = "Other";
            }

            if (rbTheory.Checked)
            {
                nbtype = "Theory";
            }
            else if (rbQuestions.Checked)
            {
                nbtype = "Questions";
            }
            else
            {
                nbtype = "Reference";
            }

            for (int i = 0; i < nUDAddQuan.Value; i++)
            {
                var book = new Book
                {
                    title=txtAddTitle.Text,
                    author=cmbAuthor.Text,
                    stream= nbstream,
                    type=nbtype,
                    holder="Library",
                    refCode=toAddRefs[i],
                    subject=cmbSubject.Text
                };
                PushResponse response = await _client.PushAsync("books/", book);
                Thread.Sleep(200);
            }

            await _client.SetAsync("bookindex/" + abrStream + "/" + abrSub + "/" + abrAuth + "/" + abrType,bookindx);
            MessageBox.Show("New Book/s sucessfullay added.", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }

        private void rbAddMath_CheckedChanged(object sender, EventArgs e)
        {
            checkSub();
            abrStream = "M";
            cmbSubject_TextChanged(sender, e);
        }

        private void rbAddPhy_CheckedChanged(object sender, EventArgs e)
        {
            checkSub();
            abrStream = "P";
            cmbSubject_TextChanged(sender, e);
        }

        private void rbAddChem_CheckedChanged(object sender, EventArgs e)
        {
            checkSub();
            abrStream = "C";
            cmbSubject_TextChanged(sender, e);
        }

        private async void cmbSubject_TextChanged(object sender, EventArgs e)
        {
            if (cmbSubject.Text.Length > 2)
            {
                bool isMatch = false;

                FirebaseResponse res;

                if (rbAddMath.Checked)
                {
                    res = await _client.GetAsync("subjects/MAT");
                }
                else if (rbAddPhy.Checked)
                {
                    res = await _client.GetAsync("subjects/PHY");
                }
                else if (rbAddChem.Checked)
                {
                    res = await _client.GetAsync("subjects/CHM");
                }
                else
                {
                    res = await _client.GetAsync("subjects/OTH");
                }

                IDictionary<string, string> subList = res.ResultAs<IDictionary<string, string>>();

                if (subList != null)
                {
                    //List<Book> bookList = res.ResultAs<List<Book>>();
                    foreach (KeyValuePair<string, string> bok in subList)
                    {
                        if (bok.Key == cmbSubject.Text)
                        {
                            isMatch = true;
                            break;
                        }
                    }
                }

                if (!isMatch)
                {
                    btnAddSubject.Enabled = true;
                    btnAddBook.Enabled = false;
                    btnAddSubject.Visible = true;

                    string abr = cmbSubject.Text.Substring(0, 2).ToUpper();

                    for (int i = 2; i < cmbSubject.Text.Length; i++)
                    {
                        bool isMatchtoAbr = false;
                        string abr1 = abr;
                        abr1 += (cmbSubject.Text[i].ToString().ToUpper());


                        if (subList != null)
                        {
                            foreach (KeyValuePair<string, string> bok in subList)
                            {
                                if (bok.Value == abr1)
                                {
                                    isMatchtoAbr = true;
                                    //MessageBox.Show(abr1 + " " + bok.Value);
                                    break;
                                }
                            }
                        }

                        if (!isMatchtoAbr)
                        {
                            abrSub = abr1;
                            newSubAbr = abr1;
                            //MessageBox.Show(abr1 + "a");
                            break;
                        }
                    }

                }
                else
                {
                    btnAddSubject.Enabled = false;
                    btnAddSubject.Visible = false;
                    checkToAdd();
                }
            }
        }

        private async void btnAddSubject_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to add this subject to the database?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SetResponse res;
                //MessageBox.Show(firstLetters.ToUpper());
                if (rbAddMath.Checked)
                {
                    res = await _client.SetAsync("subjects/MAT/"+ cmbSubject.Text , newSubAbr);
                }
                else if (rbAddPhy.Checked)
                {
                    res = await _client.SetAsync("subjects/PHY/" + cmbSubject.Text, newSubAbr);
                }
                else if (rbAddChem.Checked)
                {
                    res = await _client.SetAsync("subjects/CHM/" + cmbSubject.Text, newSubAbr);
                }
                else
                {
                    res = await _client.SetAsync("subjects/OTH/" + cmbSubject.Text, newSubAbr);
                }
                
                MessageBox.Show("New subject sucessfullay added.", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                btnAddSubject.Enabled = false;
                btnAddSubject.Visible = false;
                checkToAdd();
            }
        }

        private void rbOther_CheckedChanged(object sender, EventArgs e)
        {
            checkSub();
            abrStream = "O";
            cmbSubject_TextChanged(sender, e);
        }

        private void rbTheory_CheckedChanged(object sender, EventArgs e)
        {
            abrType = "T";
            checkToAdd();
        }

        private void rbQuestions_CheckedChanged(object sender, EventArgs e)
        {
            abrType = "Q";
            checkToAdd();
        }

        private void rbReference_CheckedChanged(object sender, EventArgs e)
        {
            abrType = "R";
            checkToAdd();
        }

        private async void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            FirebaseResponse res;

            if (rbAddMath.Checked)
            {
                res = await _client.GetAsync("subjects/MAT/" + cmbSubject.Text);
            }
            else if (rbAddPhy.Checked)
            {
                res = await _client.GetAsync("subjects/PHY/" + cmbSubject.Text);
            }
            else if (rbAddChem.Checked)
            {
                res = await _client.GetAsync("subjects/CHM/" + cmbSubject.Text);
            }
            else
            {
                res = await _client.GetAsync("subjects/OTH/" + cmbSubject.Text);
            }

            string sub = res.ResultAs<string>();
            abrSub = sub;

        }

        private void nUDAddQuan_ValueChanged(object sender, EventArgs e)
        {
            Thread.Sleep(200);
            checkToAdd();
        }

        public async void checkToAdd() {
            txtRef.Text = "";
            if ((txtAddTitle.Text != "") && (cmbAuthor.Text != "") && (cmbSubject.Text != ""))
            {
                btnAddBook.Enabled = true;
                FirebaseResponse res = await _client.GetAsync("bookindex/"+abrStream+"/"+abrSub+"/" + abrAuth + "/" + abrType);
                txtRef.Text = "";
                    try
                    {
                        bookindx = Int32.Parse(res.ResultAs<String>());
                    }
                    catch (Exception e) {
                        bookindx = 0;
                    }
                
                toAddRefs = new List<string>();
                for (int i = 0; i < nUDAddQuan.Value; i++)
                {
                    txtRef.Text += (abrStream + "-" + abrSub + "-" + abrAuth + "-" + abrType + "-" + bookindx.ToString("000"));
                    txtRef.Text += Environment.NewLine;
                    toAddRefs.Add((abrStream + "-" + abrSub + "-" + abrAuth + "-" + abrType + "-" + bookindx.ToString("000")));
                    bookindx += 1;
                }
            }
            else {
                btnAddBook.Enabled = false;
            }

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

        private async void AddBook_Load(object sender, EventArgs e)
        {
            FirebaseResponse res = await _client.GetAsync("authors/");
            IDictionary<string,string> authList = res.ResultAs<IDictionary<string, string>>();

            if (authList != null)
            {
                //List<Book> bookList = res.ResultAs<List<Book>>();
                foreach (KeyValuePair<string, string> bok in authList)
                {
                    cmbAuthor.Items.Add(bok.Key);
                }
            }

            abrStream = "M";
            abrType = "T";
            checkSub();
        }

        public async void checkSub() {
            cmbSubject.Text = "";
            if (rbAddMath.Checked)
            {
                FirebaseResponse res1 = await _client.GetAsync("subjects/MAT");
                IDictionary<string, string> subList = res1.ResultAs<IDictionary<string, string>>();
                cmbSubject.Items.Clear();

                if (subList != null)
                {
                    //List<Book> bookList = res.ResultAs<List<Book>>();
                    foreach (KeyValuePair<string, string> bok in subList)
                    {
                        cmbSubject.Items.Add(bok.Key);
                    }
                }

            }
            else if (rbAddPhy.Checked)
            {
                FirebaseResponse res1 = await _client.GetAsync("subjects/PHY");
                IDictionary<string, string> subList = res1.ResultAs<IDictionary<string, string>>();
                cmbSubject.Items.Clear();

                if (subList != null)
                {
                    //List<Book> bookList = res.ResultAs<List<Book>>();
                    foreach (KeyValuePair<string, string> bok in subList)
                    {
                        cmbSubject.Items.Add(bok.Key);
                    }
                }

            }
            else if (rbAddChem.Checked)
            {
                FirebaseResponse res1 = await _client.GetAsync("subjects/CHM");
                IDictionary<string, string> subList = res1.ResultAs<IDictionary<string, string>>();
                cmbSubject.Items.Clear();

                if (subList != null)
                {
                    //List<Book> bookList = res.ResultAs<List<Book>>();
                    foreach (KeyValuePair<string, string> bok in subList)
                    {
                        cmbSubject.Items.Add(bok.Key);
                    }
                }

            }
            else if (rbAddOther.Checked)
            {
                FirebaseResponse res1 = await _client.GetAsync("subjects/OTH");
                IDictionary<string, string> subList = res1.ResultAs<IDictionary<string, string>>();
                cmbSubject.Items.Clear();

                if (subList != null)
                {
                    //List<Book> bookList = res.ResultAs<List<Book>>();
                    foreach (KeyValuePair<string, string> bok in subList)
                    {
                        cmbSubject.Items.Add(bok.Key);
                    }
                }

            }
            checkToAdd();

        }
    }
}
