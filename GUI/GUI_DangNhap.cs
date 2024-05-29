using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_DangNhap : Form
    {
        public GUI_DangNhap()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {

            DialogResult Thoat;
            Thoat = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Thoat == DialogResult.Yes)
            {
                //phương thức này sẽ kích hoạt đến FormClosing của tất cả các Form đang mở
                Application.Exit();
            }
        }

        private void GUI_DangNhap_Load(object sender, EventArgs e)
        {
            txtTaikhoan.Select();//Yêu cầu con trỏ nhận vào dòng tài khoản đầu tiên
        }

        private void btDangnhap_Click(object sender, EventArgs e)
        {
            if ((txtTaikhoan.Text.ToLower() == "admin") && (txtMatkhau.Text == "admin"))
            {
                this.Hide();  //ẩn form đăng nhập
                GUI_TrangChu Menu = new GUI_TrangChu();
                Menu.Show();
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không đúng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTaikhoan.Focus();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtMatkhau.PasswordChar == '*')
            {
                // Hiện mật khẩu
                txtMatkhau.PasswordChar = '\0';
            }
            else
            {
                // mật khẩu
                txtMatkhau.PasswordChar = '*';
            }
        }

        private void txtMatkhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
