using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void fLogin_FormClosing(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnClearField_Click(object sender, EventArgs e)
        {
            txtPassWord.Clear();
            txtUser.Clear();
            txtUser.Focus();
            lblHelpText.Text = "";
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
            txtUser.PasswordChar = '\0';
        }

        private void btnClearPass_Click(object sender, EventArgs e)
        {

            if (txtPassWord.PasswordChar == '*')
            {
                txtPassWord.PasswordChar = '\0';
            }
            else
            {
                txtPassWord.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassWord.Text == "")
            {
                lblHelpText.Text = "Chưa nhập mật khẩu";
                txtPassWord.Focus();
                return;
            }
            if (txtUser.Text == "")
            {
                lblHelpText.Text = "Chưa nhập tên đăng nhập";
                txtUser.Focus();
                return;
            }

            TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
            if (!taiKhoanBUS.CheckLogin(txtUser.Text, txtPassWord.Text))
            {
                lblHelpText.Text = "Sai tên đăng nhập hoặc mật khẩu";
                return;
            }
            fManager f = new fManager(taiKhoanBUS.GetAccountByUserName(txtUser.Text));
            this.Hide();
            f.ShowDialog();
        }
    }
}
