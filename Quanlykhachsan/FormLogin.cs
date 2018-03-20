using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAO;
using DTO;
using BUS;
using System.Collections;

namespace Quanlykhachsan
{
    public partial class FormLogin : Form
    {
        public FormMain frmMain;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void Login()
        {
            LoginBUS lgBUS = new LoginBUS();

            IList<LoginDTO> list = lgBUS.Login(txtTenDangNhap.Text, frmMain.MaHoa(txtMatKhau.Text));

            if (list.Count == 0)
            {
                if (MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng!", "Đăng nhập thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    txtMatKhau.Clear();
                    txtMatKhau.Focus();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                foreach (LoginDTO lgDTO in list)
                {
                    frmMain.m_username = lgDTO.Username;
                    frmMain.m_chucvu = lgDTO.ChucVu;
                    frmMain.m_maNV = lgDTO.MaNV;
                }
                this.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Login();
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }


    }
}
