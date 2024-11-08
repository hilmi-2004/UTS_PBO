using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using Pet_Care.Contoller;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace Pet_Care.View
{
    public partial class V_Register : UserControl
    {
        C_Landing_Page controller;
        public V_Register(C_Landing_Page controller)
        {
            InitializeComponent();
            this.controller = controller;
        }
        private void Login_MouseHover(object sender, EventArgs e)
        {
            Login.Cursor = Cursors.Hand;
        }
        private void Login_Click(object sender, EventArgs e)
        {
            controller.v_Login = new V_Login(controller);
            controller.v_Login.Location = new Point(0, 102);
            controller.switch_view(controller.v_Login);
        }
        private void Button_Register_MouseHover(object sender, EventArgs e)
        {
            Button_Register.Cursor = Cursors.Hand;
        }
        private void Button_Register_MouseEnter(object sender, EventArgs e)
        {
            Button_Register.BackgroundImage = Properties.Resources.Register_Button_Hover;
        }
        private void Button_Register_MouseLeave(object sender, EventArgs e)
        {
            Button_Register.BackgroundImage = Properties.Resources.Register_Button;
        }
        private void Button_Register_Click(object sender, EventArgs e)
        {
            controller.register_validation();
        }
        private void Username_Enter(object sender, EventArgs e)
        {
            if (Username.Text == "Username")
            {
                Username.Text = "";
                Username.ForeColor = Color.White;
            }
        }
        private void Username_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Username.Text))
            {
                Username.Text = "Username";
                Username.ForeColor = Color.FromArgb(176, 142, 128);
            }
        }
        private void Nama_Lengkap_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Nama_Lengkap.Text))
            {
                Nama_Lengkap.Text = "Nama Lengkap";
                Nama_Lengkap.ForeColor = Color.FromArgb(176, 142, 128);
            }
        }
        private void Nama_Lengkap_Enter(object sender, EventArgs e)
        {
            if (Nama_Lengkap.Text == "Nama Lengkap")
            {
                Nama_Lengkap.Text = "";
                Nama_Lengkap.ForeColor = Color.White;
            }
        }
        private void Nomor_HP_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Nomor_HP.Text))
            {
                Nomor_HP.Text = "Nomor Hp";
                Nomor_HP.ForeColor = Color.FromArgb(176, 142, 128);
            }
        }
        private void Nomor_HP_Enter(object sender, EventArgs e)
        {
            if (Nomor_HP.Text == "Nomor Hp")
            {
                Nomor_HP.Text = "";
                Nomor_HP.ForeColor = Color.White;
            }
        }
        private void Email_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Email.Text))
            {
                Email.Text = "Email";
                Email.ForeColor = Color.FromArgb(176, 142, 128);
            }
        }
        private void Email_Enter(object sender, EventArgs e)
        {
            if (Email.Text == "Email")
            {
                Email.Text = "";
                Email.ForeColor = Color.White;
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
        private void Password_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Password.Text))
            {
                Password.Text = "Password";
                Password.ForeColor = Color.FromArgb(176, 142, 128);
            }
        }
        private void Konfirmasi_Password_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Konfirmasi_Password.Text))
            {
                Konfirmasi_Password.Text = "Konfirmasi Password";
                Konfirmasi_Password.ForeColor = Color.FromArgb(176, 142, 128);
            }
        }
        private void Konfirmasi_Password_Enter(object sender, EventArgs e)
        {
            if (Konfirmasi_Password.Text == "Konfirmasi Password")
            {
                Konfirmasi_Password.Text = "";
                Konfirmasi_Password.ForeColor = Color.White;
            }
        }
    }
}