using ACLibarary.Classes;
using FireSharp;
//using Firebase.Database;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 


namespace ACLibarary
{
    public partial class Login : Form
    {

        static IFirebaseConfig config = new FirebaseConfig
        {
            BasePath = "https://anandamathslib.firebaseio.com/"
        };
        IFirebaseClient _client = new FirebaseClient(config);


        public Login()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true); // this is to avoid visual artifacts
        }

        private void Form1_Load(object sender, EventArgs e)
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

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            //var student = new Student
            //{
            //    name = "Paveen Perera",
            //    year = 2014,
            //    cls = 5
            //};

            //var book = new Book
            //{
            //    title = "Book2",
            //    author = "Locha",
            //    holder = "Library",
            //    refCode = "MAT000001",
            //    type = "MAT"
            //};

            //PushResponse response = await _client.PushAsync("books/", book);
           
            //SetResponse response = await _client.SetAsync("students/" + "48963", student);
            //Student result = response.ResultAs<Student>(); //The response will contain the data written
            //MessageBox.Show(result.ToString());

            //FirebaseResponse res = await _client.GetAsync("students/" + "48963"+"/borrowed");
            //MessageBox.Show(res.ToString());
            //Student todo = res.ResultAs<Student>(); //The response will contain the data being retreived
            //MessageBox.Show(todo.name.ToString());
            
            //if ((txtPass.Text == "00000"))
            //{
            //    //Clipboard.SetText(Encryption.Encrypt("bftTpTIVZPM1G3wk8ywunEdwXLJIm2mXxWCYXXWz", txtPass.Text));
            //    config.AuthSecret = (Encryption.Decrypt("Hsd1PygbTgs71UhbHJzUjUYPp / tgnU3L6H1ChvPBv5iBGqZWqJ8wzko2XeSYqoO9", txtPass.Text));
            //    //this.DialogResult = DialogResult.OK;
            //}
            //else
            //{
            try
            {
                FirebaseResponse res = await _client.GetAsync("key");
                IDictionary<string, string> reslt = res.ResultAs<IDictionary<string, string>>();
                Encryption.ciphperString = Encryption.Decrypt(reslt["authSecret"],txtPass.Text);
    
                if (Convert.ToBoolean(reslt["pass"]))
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (CryptographicException ex) {
                MessageBox.Show("Incorrect username or password!", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               
            //}
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            //Hsd1PygbTgs71UhbHJzUjUYPp / tgnU3L6H1ChvPBv5iBGqZWqJ8wzko2XeSYqoO9
        }
    }
}
