using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI
{
    public partial class GUI_NhanVien : Form
    {
        BUS_NhanVien busNV = new BUS_NhanVien();
        public GUI_NhanVien()
        {
            InitializeComponent();
        }
        private void GUI_NhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = busNV.GetNhanVien();
            dgvNhanVien.Columns[0].HeaderText = "Mã NV";
            dgvNhanVien.Columns[1].HeaderText = "Họ tên nhân viên";
            dgvNhanVien.Columns[2].HeaderText = "Giới tính";
            dgvNhanVien.Columns[3].HeaderText = "Địa chỉ";
            dgvNhanVien.Columns[4].HeaderText = "SDT";
            dgvNhanVien.Columns[5].HeaderText = "Lương";
            
        }
        // các chức năng
        private void txtTimNhanvien_TextChanged(object sender, EventArgs e)
        {
            GUI_NhanVien_Load(sender, e);
            string searchText = txtTimNhanvien.Text.Trim().ToUpperInvariant(); //nội dung của ô nhập liệu, loại bỏ khoảng trắng ở đầu và cuối chuỗi, và chuyển nó thành chữ in hoa

            for (int i = dgvNhanVien.Rows.Count - 2; i >= 0; i--)
            {
                string cellValue0 = dgvNhanVien[0, i].Value?.ToString().Trim().ToUpperInvariant();//ấy giá trị của ô tại cột đầu tiên (cột có chỉ số 0) của hàng hiện tại
                string cellValue1 = dgvNhanVien[1, i].Value?.ToString().Trim().ToUpperInvariant();//ấy giá trị của ô tại cột thứ 2(cột có chỉ số 1) của hàng hiện tại

                bool containsSearchText = (!string.IsNullOrEmpty(cellValue0) && cellValue0.Contains(searchText)) || // kiểm tra xem giá trị của ô
                                          (!string.IsNullOrEmpty(cellValue1) && cellValue1.Contains(searchText));

                if (!containsSearchText)
                {
                    dgvNhanVien.Rows.RemoveAt(i);
                }
            }
        }
        private void btnthemNV_Click(object sender, EventArgs e)
        {
            string manv = txtmaNV.Text;
            string tennv = txttenNV.Text;
            string gioiTinh = txtgioiTinh.Text;
            string diaChi = txtdiaChi.Text;
            string sdtNV = txtsdtNV.Text;
            int Luong = int.Parse(txtLuong.Text);
            NhanVien nv = new NhanVien(manv, tennv, gioiTinh, diaChi, sdtNV, Luong);
            if (busNV.KiemTraMaTrung(manv) == 1)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");
            }
            else
            {
                if (busNV.ThemNV(nv))
                {
                    dgvNhanVien.DataSource = busNV.GetNhanVien();
                    MessageBox.Show("Thêm nhân viên thành công");
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string manv = txtmaNV.Text;
            string tennv = txttenNV.Text;
            string gioiTinh = txtgioiTinh.Text;
            string diaChi = txtdiaChi.Text;
            string sdtNV = txtsdtNV.Text;
            int Luong = int.Parse(txtLuong.Text);
            NhanVien nv = new NhanVien(manv, tennv, gioiTinh, diaChi, sdtNV, Luong);
            if (busNV.SuaNV(nv))
            {
                //MessageBox.Show("Sửa thành công");
                dgvNhanVien.DataSource = busNV.GetNhanVien();
                MessageBox.Show("Sửa thông tin nhân viên thành công");

            }
        }
        private void btnxoaNV_Click(object sender, EventArgs e)
        {
            string ma = txtmaNV.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busNV.XoaNV(ma))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvNhanVien.DataSource = busNV.GetNhanVien();
                }
            }
        }
        private void btnhienThiNV_Click(object sender, EventArgs e)
        {
            txtmaNV.Text = "";
            txttenNV.Text = "";
            txtgioiTinh.Text = "";
            txtdiaChi.Text = "";
            txtsdtNV.Text = "";
            txtLuong.Text = "";
            dgvNhanVien.DataSource = busNV.GetNhanVien();//load lại datagridview
        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmaNV.Text = dgvNhanVien[0, i].Value.ToString();
            txttenNV.Text = dgvNhanVien[1, i].Value.ToString();
            txtgioiTinh.Text = dgvNhanVien[2, i].Value.ToString();
            txtdiaChi.Text = dgvNhanVien[3, i].Value.ToString();
            txtsdtNV.Text = dgvNhanVien[4, i].Value.ToString();
            txtLuong.Text = dgvNhanVien[5, i].Value.ToString();
        }
    }
}
