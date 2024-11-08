using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pet_Care.View;
using Pet_Care.Model;
namespace Pet_Care.Contoller
{
    public class C_Landing_Page
    {
        public C_MainFrame controller_main_frame;
        V_landing_Page v_Landing_Page;
        public V_Login v_Login;
        public V_Register V_Register;
        M_Akun m_Akun = new M_Akun();
        public C_Landing_Page(C_MainFrame Main_Frame)
        {
            controller_main_frame = Main_Frame;
            v_Landing_Page = new V_landing_Page(this);
            v_Login = new V_Login(this);
            v_Login.Location = new Point(0, 102);
            V_Register = new V_Register(this);
            controller_main_frame.move_view(v_Landing_Page);
            switch_view(v_Login);
        }
        public void switch_view(UserControl form)
        {
            v_Landing_Page.PanelInput.Controls.Clear();
            v_Landing_Page.PanelInput.Controls.Add(form);
        }
        public void login_validation()
        {
            if (v_Login.Username_Email.Text == "Username/Email" || v_Login.Password.Text == "Password")
            {
                controller_main_frame.show_message_box("Invalid Login");
                return;
            }
            m_Akun.Get(v_Login.Username_Email.Text, v_Login.Password.Text);
            if (M_Session.session_status)
            {
                controller_main_frame.controller_main_menu = new C_MainMenu(controller_main_frame);
            }
            else
            {
                controller_main_frame.show_message_box("Invalid Login");
            }
        }
        public void register_validation()
        {
            int nomor_hp;
            if (V_Register.Username.Text == "Username" || V_Register.Password.Text == "Password" || V_Register.Nama_Lengkap.Text == "Nama Lengkap" || V_Register.Nomor_HP.Text == "Nomor Hp" || V_Register.Email.Text == "Email" || V_Register.Konfirmasi_Password.Text != V_Register.Password.Text)
            {
                controller_main_frame.show_message_box("Invalid Register");
                return;
            }
            Akun data_akun = new Akun
            {
                Username = V_Register.Username.Text,
                Password = V_Register.Password.Text,
                Name = V_Register.Nama_Lengkap.Text,
                Nomor_Hp = V_Register.Nomor_HP.Text,
                Email = V_Register.Email.Text
            };
            if (m_Akun.Insert(data_akun))
            {
                switch_view(v_Login);
            }
            else
            {
                controller_main_frame.show_message_box("Akun Sudah Tersedia");
            }
        }
    }
}