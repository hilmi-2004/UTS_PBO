using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using Pet_Care.Contoller;
namespace Pet_Care.View
{
    public partial class V_Login : UserControl
    {
        C_Landing_Page Controller;
        public V_Login(C_Landing_Page c_Landing_Page)
        {
            InitializeComponent();
            Controller = c_Landing_Page;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Controller.login_validation();
        }
        private void LoginButton_MouseHover(object sender, EventArgs e)
        {
            LoginButton.Cursor = Cursors.Hand;
        }
        private void LoginButton_MouseEnter(object sender, EventArgs e)
        {
            LoginButton.BackgroundImage = Properties.Resources.Button_Login_Hover;
        }
        private void LoginButton_MouseLeave(object sender, EventArgs e)
        {
            LoginButton.BackgroundImage = Properties.Resources.Login_Button;
        }
        private void Register_Click(object sender, EventArgs e)
        {
            Controller.V_Register = new V_Register(Controller);
            Controller.switch_view(Controller.V_Register);
        }
        private void Register_MouseHover(object sender, EventArgs e)
        {
            Register.Cursor = Cursors.Hand;
        }
        private void V_Login_Load(object sender, EventArgs e)
        {
        }
        private void Username_Email_Enter(object sender, EventArgs e)
        {
            if (Username_Email.Text == "Username/Email")
            {
                Username_Email.Text = "";
                Username_Email.ForeColor = Color.White;
            }
        }
        private void Username_Email_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Username_Email.Text))
            {
                Username_Email.Text = "Username/Email";
                Username_Email.ForeColor = Color.FromArgb(176, 142, 128);
            }
        }
        private void Password_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Password.Text))
            {
                Password.Text = "Password";
                Password.ForeColor = Color.FromArgb(176, 142, 128);
            }
        }
        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password.Text == "Password")
            {
                Password.Text = "";
                Password.ForeColor = Color.White;
            }
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // V_Login
            // 
            Name = "V_Login";
            Size = new Size(731, 467);
            ResumeLayout(false);
        }

        private void Username_Email_TextChanged(object sender, EventArgs e)
        {
        }
    }
}