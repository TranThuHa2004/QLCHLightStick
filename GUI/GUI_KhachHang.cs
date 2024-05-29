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
    public partial class GUI_KhachHang : Form
    {
        BUS_KhachHang busKH = new BUS_KhachHang();
        public GUI_KhachHang()
        {
            InitializeComponent();
        }

        private void GUI_KhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = busKH.GetKhachHang();
            dgvKhachHang.Columns[0].HeaderText = "Mã KH";
            dgvKhachHang.Columns[1].HeaderText = "Họ tên KH";
            dgvKhachHang.Columns[2].HeaderText = "Giới tính";
            dgvKhachHang.Columns[3].HeaderText = "Địa chỉ";
            dgvKhachHang.Columns[4].HeaderText = "SDT";
            dgvKhachHang.Columns[5].HeaderText = "Mã HĐB";
        }
        // các chức năng
        private void btnhienThiKH_Click(object sender, EventArgs e)
        {
            txtmaKH.Text = "";
            txttenKH.Text = "";
            txtgioiTinh.Text = "";
            txtdiaChi.Text = "";
            txtsdtKH.Text = "";
            txtmaDHB.Text = "";
            dgvKhachHang.DataSource = busKH.GetKhachHang();//load lại datagridview
        }
        private void txtTimKH_TextChanged(object sender, EventArgs e)
        {
            GUI_KhachHang_Load(sender, e);
            string searchText = txtTimKH.Text.Trim().ToUpperInvariant();

            for (int i = dgvKhachHang.Rows.Count - 2; i >= 0; i--)
            {
                string cellValue0 = dgvKhachHang[1, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue1 = dgvKhachHang[0, i].Value?.ToString().Trim().ToUpperInvariant();

                bool containsSearchText = (!string.IsNullOrEmpty(cellValue1) && cellValue1.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue0) && cellValue0.Contains(searchText));

                if (!containsSearchText)
                {
                    dgvKhachHang.Rows.RemoveAt(i);
                }
            }
        }
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmaKH.Text = dgvKhachHang[0, i].Value.ToString();
            txttenKH.Text = dgvKhachHang[1, i].Value.ToString();
            txtgioiTinh.Text = dgvKhachHang[2, i].Value.ToString();
            txtdiaChi.Text = dgvKhachHang[3, i].Value.ToString();
            txtsdtKH.Text = dgvKhachHang[4, i].Value.ToString();
            txtmaDHB.Text = dgvKhachHang[5, i].Value.ToString();
        }
        private void btnthemKH_Click(object sender, EventArgs e)
        {
            string maKH = txtmaKH.Text;
            string tenKH = txttenKH.Text;
            string gioiTinh = txtgioiTinh.Text;
            string diaChi = txtdiaChi.Text;
            string sdtKH = txtsdtKH.Text;
            string maDHB = txtmaDHB.Text;
            KhachHang kh = new KhachHang(maKH, tenKH, gioiTinh, diaChi, sdtKH, maDHB);
            if (busKH.KiemTraMaTrung(maKH) == 1)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại!");
            }
            else
            {
                if (busKH.ThemKH(kh))
                {
                    dgvKhachHang.DataSource = busKH.GetKhachHang();
                    MessageBox.Show("Thêm khách hàng thành công");
                }
            }
        }
        private void btnsuaKH_Click(object sender, EventArgs e)
        {
            string maKH = txtmaKH.Text;
            string tenKH = txttenKH.Text;
            string gioiTinh = txtgioiTinh.Text;
            string diaChi = txtdiaChi.Text;
            string sdtKH = txtsdtKH.Text;
            string maDHB = txtmaDHB.Text;
            KhachHang kh = new KhachHang(maKH, tenKH, gioiTinh, diaChi, sdtKH, maDHB);
            if (busKH.SuaKH(kh))
            {
                //MessageBox.Show("Sửa thành công");
                dgvKhachHang.DataSource = busKH.GetKhachHang();
                MessageBox.Show("Sửa thông tin khách hàng thành công");

            }
        }
        private void btnxoaKH_Click(object sender, EventArgs e)
        {
            string ma = txtmaKH.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busKH.XoaKH(ma))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvKhachHang.DataSource = busKH.GetKhachHang();
                }
            }
        }
    }
}
