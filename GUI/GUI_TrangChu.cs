using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.UI.WebControls;



namespace GUI
{
    public partial class GUI_TrangChu : Form
    {
        private bool isReady = true;
        public GUI_TrangChu()
        {
            InitializeComponent();
        }
        private Form FormCon;
        private void MoFormCon(Form Con)
        {
            if (FormCon != null)
            {
                FormCon.Close();
            }
            FormCon = Con;

            // Đặt form cho phép nhúng nó vào trong panel cha
            Con.TopLevel = false;

            // Loại bỏ viền của form con
            Con.FormBorderStyle = FormBorderStyle.None;

            // Đặt form con điền đầy panel cha
            Con.Dock = DockStyle.Fill;

            // Thêm form con vào danh sách Controls của panel cha
            formTrangchu.Controls.Add(Con);

            // Gán form con vào thuộc tính Tag của panel cha để dễ dàng truy cập lại sau này
            formTrangchu.Tag = Con;

            // Đưa form con lên trên cùng của form để đảm bảo nó không bị che khuất bởi các control khác
            Con.BringToFront();

            // Hiển thị form con
            Con.Show();
        }
        private void btnMaytinh_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MoFormCon(new GUI_DonHangBan());
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            MoFormCon(new GUI_NhanVien());
        }

        private void btnQL_Click(object sender, EventArgs e)
        {
            GUI_TrangChu tc = new GUI_TrangChu();
            tc.Show();
            this.Hide();
        }

        private void btnLT_Click(object sender, EventArgs e)
        {
            MoFormCon(new GUI_Lightstick());
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            MoFormCon(new GUI_NhaCungCap());
        }

        private void btnNN_Click(object sender, EventArgs e)
        {
            MoFormCon(new GUI_NhomNhac());
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            MoFormCon(new GUI_KhachHang());
        }

        private void btnDHN_Click(object sender, EventArgs e)
        {
            MoFormCon(new GUI_DonHangNhap());
        }

        private void btnCTDHN_Click(object sender, EventArgs e)
        {
            MoFormCon(new GUI_ChitietDHN());
        }

        private void btnCTDHB_Click(object sender, EventArgs e)
        {
            MoFormCon(new GUI_ChitietDHB());
        }

        private void btnDX_Click(object sender, EventArgs e)
        {
            DialogResult DangXuat;
            DangXuat = MessageBox.Show("Bạn chắc chắn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DangXuat == DialogResult.Yes)
            { 
                this.Hide();
                GUI_DangNhap login = new GUI_DangNhap();
                login.Show();
                this.Close();
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            MoFormCon(new GUI_ThongKe());
        }

        private void btnBC_Click(object sender, EventArgs e)
        {
            MoFormCon(new GUI_BaoCao());
        }

        private void GUI_TrangChu_Load(object sender, EventArgs e)
        {

        }
    }
}
