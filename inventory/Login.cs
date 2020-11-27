using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory
{
    public partial class Login : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        bool focus = false;

        public Login()
        {
            dl.Run_First();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Check_ProductCredential())
            {
                loginBtn.Region = BorderRadius.BorderX(loginBtn.Width, loginBtn.Height, loginBtn.Height);
            }
            else
            {
                this.Close();
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Hide();
            Dashboard all = new Dashboard();
            all.ShowDialog();
            all = null;
            if(dl.Close_Execution)
            {
                this.Close();
            }
            else
            {
                Show();
            }
          
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {

            btnClose.ForeColor = Color.Firebrick;

        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {

            btnClose.ForeColor = Color.White;

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == dll.username_placeholder)
                txtUsername.Text = "";
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == dll.bstring)
                txtUsername.Text = dll.username_placeholder;

            
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if(txtPassword.Text==dll.password_placeholder)
            {
                txtPassword.Text = "";txtPassword.PasswordChar = dll.pchar;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == dll.bstring)
            {
                txtPassword.Text = dll.password_placeholder; 
                txtPassword.PasswordChar = dl.emptyChar;
            }
        }
        private bool Check_ProductCredential()
        {
            Enabled = false;
            Product_Key_Form all = new Product_Key_Form();
            all.ShowDialog();
            all = null; 
            Enabled = true;
            return true;
        }
    }
}
