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
using System.Data.SqlClient;
using Guna.UI2.WinForms;

namespace GUI
{
    public partial class GUI_DonHangNhap : Form
    {
        BUS_DonHangNhap busdhn = new BUS_DonHangNhap();
        BUS_NhaCungCap BUS_NhaCungCap = new BUS_NhaCungCap();
        BUS_NhanVien BUS_NhanVien = new BUS_NhanVien();
        LienKetComboBox comboBox = new LienKetComboBox();
        public GUI_DonHangNhap()
        {
            InitializeComponent();
        }

        private void GUI_DonHangNhap_Load(object sender, EventArgs e)
        {
            dgvDHN.DataSource = busdhn.GetDHN();
            dgvDHN.Columns[0].HeaderText = "Mã DHN";
            dgvDHN.Columns[1].HeaderText = "Mã NCC";
            dgvDHN.Columns[2].HeaderText = "Mã NV";
            dgvDHN.Columns[3].HeaderText = "Ngày nhập";
            dgvDHN.Columns[4].HeaderText = "Tổng thanh toán";
            comboBox.LienKet1DuLieu(BUS_NhaCungCap.GetNhaCungCap(), "maNCC", cbomaNCC); //liên kết dữ liệu từ bảng nhân viên(BUS_NhaCungCap.GetNCC()) đến combobox cbomaNCC
            comboBox.LienKet1DuLieu(BUS_NhanVien.GetNhanVien(), "maNV", cbomaNV); //liên kết dữ liệu từ bảng nhân viên(BUS_NhanVien.GetNhanVien()) đến combobox cbomaNV
        }
        // Các chức năng
        private void dgvDHN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmaDHN.Text = dgvDHN[0, i].Value.ToString();
            cbomaNCC.Text = dgvDHN[1, i].Value.ToString();
            cbomaNV.Text = dgvDHN[2, i].Value.ToString();
            dtpngayNhap.Text = dgvDHN[3, i].Value.ToString();
            txtTongThanhToan.Text = dgvDHN[4, i].Value.ToString();
        }
        private void btntimKiemDHN_Click(object sender, EventArgs e)
        {
            DateTime ngayNhap = txtTimDHN.Value;
            DataTable dtDonHangNhap = busdhn.TimDHN(ngayNhap);
            dgvDHN.DataSource = dtDonHangNhap;
        }
        private void btnthemDHN_Click(object sender, EventArgs e)
        {
            string maDHN = txtmaDHN.Text;
            string maNCC = cbomaNCC.Text;
            string maNV = cbomaNV.Text;
            string ngayNhap = dtpngayNhap.Value.ToString("yyyy-MM-dd");
            float TongThanhToan = float.Parse(txtTongThanhToan.Text);
            DonHangNhap dhn = new DonHangNhap(maDHN, maNCC, maNV, DateTime.Parse(ngayNhap), TongThanhToan);
            if (busdhn.KiemTraMaTrung(maDHN) == 1)
            {
                MessageBox.Show("Mã đơn hàng nhập đã tồn tại!");
            }
            else
            {
                if (busdhn.ThemDHN(dhn))
                {
                    dgvDHN.DataSource = busdhn.GetDHN();
                    MessageBox.Show("Thêm đơn hàng nhập thành công");
                }
            }
        }
        private void btnsuaDHN_Click(object sender, EventArgs e)
        {
            string maDHN = txtmaDHN.Text;
            string maNCC = cbomaNCC.Text;
            string maNV = cbomaNV.Text;
            string ngayNhap = dtpngayNhap.Value.ToString("yyyy-MM-dd");
            float TongThanhToan = float.Parse(txtTongThanhToan.Text) ;
            DonHangNhap dhn = new DonHangNhap(maDHN, maNCC, maNV, DateTime.Parse(ngayNhap),TongThanhToan);
            if (busdhn.SuaDHN(dhn))
            {
                //MessageBox.Show("Sửa thành công");
                dgvDHN.DataSource = busdhn.GetDHN();
                MessageBox.Show("Sửa đơn hàng nhập thành công");

            }
        }
        private void btnxoaDHN_Click(object sender, EventArgs e)
        {
            string ma = txtmaDHN.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busdhn.XoaDHN(ma))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvDHN.DataSource = busdhn.GetDHN();
                }
            }
        }
        private void btnhienThiDHN_Click(object sender, EventArgs e)
        {
            CapNhatTongTien();// click cập nhật lại cột tổng tiền 
            dgvDHN.DataSource = busdhn.GetDHN();// load lại datagridview
        }
        private void CapNhatTongTien()
        {
            string maDHN = txtmaDHN.Text;
            float tongTien = busdhn.TongTien(maDHN);
            txtTongThanhToan.Text = tongTien.ToString("N0");
        }
    }
}
