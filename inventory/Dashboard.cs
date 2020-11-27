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
    public partial class Dashboard : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        bool focus = false;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void materialDivider5_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            pictureBox1.Region = BorderRadius.BorderX(pictureBox1.Width, pictureBox1.Height, pictureBox1.Height);
            pAdminPanelBody.Size = new System.Drawing.Size(0, 727);
            pDashboardBody.Size = new System.Drawing.Size(1150, 727);
            pUserInfo.Size = new System.Drawing.Size(0, 599);
            pUserManagement.Size = new System.Drawing.Size(1086, 599);
            pCreateUser.Size = new System.Drawing.Size(0, 599);
            /*btnDashboard.Region = BorderRadius.BorderX(btnDashboard.Width, btnDashboard.Height, btnDashboard.Height);
            btnManageUsers.Region = BorderRadius.BorderX(btnManageUsers.Width, btnManageUsers.Height, btnManageUsers.Height);
            btnInventory.Region = BorderRadius.BorderX(btnInventory.Width, btnInventory.Height, btnInventory.Height);*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dl.Close_Execution = true;
            this.Close();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void headPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void UserMgtBtn_Click(object sender, EventArgs e)
        {
            pDashboardBody.Size = new System.Drawing.Size(0, 727);
            pAdminPanelBody.Size = new System.Drawing.Size(1150, 727);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pDashboardBody.Size = new System.Drawing.Size(1150, 727);
            pAdminPanelBody.Size = new System.Drawing.Size(0, 727);
        }

        private void button43_Click(object sender, EventArgs e)
        {

        }

        private void materialDivider9_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void button83_Click(object sender, EventArgs e)
        {
            pUserManagement.Size = new System.Drawing.Size(0, 599);
            pUserInfo.Size = new System.Drawing.Size(1086, 599);
        }

        private void button90_Click(object sender, EventArgs e)
        {
            pUserInfo.Size = new System.Drawing.Size(0, 599);
            pUserManagement.Size = new System.Drawing.Size(1086, 599);
        }

        private void button90_Click_1(object sender, EventArgs e)
        {
            txtUserInfoFullName.ReadOnly = false;
            /*txtUserInfoFullName.Region = BorderRadius.BorderX(txtUserInfoFullName.Width, txtUserInfoFullName.Height, txtUserInfoFullName.Height);*/
            txtUserInfoFullName.BackColor = Color.Gainsboro;
            txtUserInfoUsername.ReadOnly = false;
            txtUserInfoUsername.BackColor = Color.Gainsboro;
            /*txtUserInfoUsername.Region = BorderRadius.BorderX(txtUserInfoUsername.Width, txtUserInfoUsername.Height, txtUserInfoUsername.Height);*/
            txtUserInfoPosition.ReadOnly = false;
            txtUserInfoPosition.BackColor = Color.Gainsboro;
            /*txtUserInfoPosition.Region = BorderRadius.BorderX(txtUserInfoPosition.Width, txtUserInfoPosition.Height, txtUserInfoPosition.Height);*/
            txtUserInfoPhone.ReadOnly = false;
            txtUserInfoPhone.BackColor = Color.Gainsboro;
            /*txtUserInfoPhone.Region = BorderRadius.BorderX(txtUserInfoPhone.Width, txtUserInfoPhone.Height, txtUserInfoPhone.Height);*/
            txtUserInfoAddress.ReadOnly = false;
            txtUserInfoAddress.BackColor = Color.Gainsboro;
            /*txtUserInfoAddress.Region = BorderRadius.BorderX(txtUserInfoAddress.Width, txtUserInfoAddress.Height, txtUserInfoAddress.Height);*/
            txtUserInfoEmail.ReadOnly = false;
            txtUserInfoEmail.BackColor = Color.Gainsboro;
            /*txtUserInfoEmail.Region = BorderRadius.BorderX(txtUserInfoEmail.Width, txtUserInfoEmail.Height, txtUserInfoEmail.Height);*/
            txtUserInfoPassword.ReadOnly = false;
            txtUserInfoPassword.BackColor = Color.Gainsboro;
            /*txtUserInfoPassword.Region = BorderRadius.BorderX(txtUserInfoPassword.Width, txtUserInfoPassword.Height, txtUserInfoPassword.Height);*/
            txtUserInfoDepartment.ReadOnly = false;
            txtUserInfoDepartment.BackColor = Color.Gainsboro;
            /*txtUserInfoDepartment.Region = BorderRadius.BorderX(txtUserInfoDepartment.Width, txtUserInfoDepartment.Height, txtUserInfoDepartment.Height);*/
            btnUserInfoUpdate.Visible = true;
            btnUserInfoCancel.Visible = true;
            btnUserInfoEdit.Visible = false;
            btnUserInfoDelete.Visible = false;
        }

        private void btnUserInfoUpdate_Click(object sender, EventArgs e)
        {
            txtUserInfoFullName.ReadOnly = true;
            txtUserInfoFullName.BackColor = Color.Silver;
            txtUserInfoUsername.ReadOnly = true;
            txtUserInfoUsername.BackColor = Color.White;
            txtUserInfoPosition.ReadOnly = true;
            txtUserInfoPosition.BackColor = Color.White;
            txtUserInfoPhone.ReadOnly = true;
            txtUserInfoPhone.BackColor = Color.White;
            txtUserInfoAddress.ReadOnly = true;
            txtUserInfoAddress.BackColor = Color.White;
            txtUserInfoEmail.ReadOnly = true;
            txtUserInfoEmail.BackColor = Color.White;
            txtUserInfoPassword.ReadOnly = true;
            txtUserInfoPassword.BackColor = Color.White;
            txtUserInfoDepartment.ReadOnly = true;
            txtUserInfoDepartment.BackColor = Color.White;
            btnUserInfoUpdate.Visible = false;
            btnUserInfoCancel.Visible = false;
            btnUserInfoEdit.Visible = true;
            btnUserInfoDelete.Visible = true;
        }

        private void button89_Click(object sender, EventArgs e)
        {
            DeletePrompt prompt = new DeletePrompt();
            prompt.ShowDialog();
        }

        private void button81_Click(object sender, EventArgs e)
        {
            pUserManagement.Size = new System.Drawing.Size(0, 599);
            pCreateUser.Size = new System.Drawing.Size(1086, 599);
        }

        private void button92_Click(object sender, EventArgs e)
        {
            pCreateUser.Size = new System.Drawing.Size(0, 599);
            pUserManagement.Size = new System.Drawing.Size(1086, 599);
        }

        private void button93_Click(object sender, EventArgs e)
        {
            pCreateUser.Size = new System.Drawing.Size(0, 599);
            pUserManagement.Size = new System.Drawing.Size(1086, 599);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if(System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, " ^ [0-9]"))
            {
                textBox3.Text = "";
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button94_Click(object sender, EventArgs e)
        {
            PrinterSetup setup = new PrinterSetup();
            setup.ShowDialog();
        }

        private void btnActivateDeactivate_Click(object sender, EventArgs e)
        {
            if(btnActivateDeactivate.Text == "Deactivated")
            {
                btnActivateDeactivate.Text = "Activated";
                btnActivateDeactivate.BackColor = Color.FromArgb(112, 193, 64);
            }
            else
            {
                btnActivateDeactivate.Text = "Deactivated";
                btnActivateDeactivate.BackColor = Color.FromArgb(255, 107, 107);
            }
        }

        private void button82_Click(object sender, EventArgs e)
        {
            pUserManagement.Size = new System.Drawing.Size(0, 599);
            pUserInfo.Size = new System.Drawing.Size(1086, 599);
        }

        private void button84_Click(object sender, EventArgs e)
        {
            pUserManagement.Size = new System.Drawing.Size(0, 599);
            pUserInfo.Size = new System.Drawing.Size(1086, 599);
        }

        private void button85_Click(object sender, EventArgs e)
        {
            pUserManagement.Size = new System.Drawing.Size(0, 599);
            pUserInfo.Size = new System.Drawing.Size(1086, 599);
        }

        private void button86_Click(object sender, EventArgs e)
        {
            pUserManagement.Size = new System.Drawing.Size(0, 599);
            pUserInfo.Size = new System.Drawing.Size(1086, 599);
        }

        private void button87_Click(object sender, EventArgs e)
        {
            pUserManagement.Size = new System.Drawing.Size(0, 599);
            pUserInfo.Size = new System.Drawing.Size(1086, 599);
        }

        private void button88_Click(object sender, EventArgs e)
        {
            pUserManagement.Size = new System.Drawing.Size(0, 599);
            pUserInfo.Size = new System.Drawing.Size(1086, 599);
        }
    }
}
