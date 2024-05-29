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
using Guna.UI2.WinForms;

namespace GUI
{
    public partial class GUI_DonHangBan : Form
    {
        BUS_DonHangBan busdhb = new BUS_DonHangBan();
        BUS_NhanVien BUS_NhanVien = new BUS_NhanVien();
        BUS_KhachHang BUS_KhachHang = new BUS_KhachHang();
        LienKetComboBox comboBox = new LienKetComboBox();
        public GUI_DonHangBan()
        {
            InitializeComponent();
        }

        private void GUI_DonHangBan_Load(object sender, EventArgs e)
        {
            dgvDHB.DataSource = busdhb.GetDHB();
            dgvDHB.Columns[0].HeaderText = "Mã DHB";
            dgvDHB.Columns[1].HeaderText = "Mã NV";
            dgvDHB.Columns[2].HeaderText = "Mã KH";
            dgvDHB.Columns[3].HeaderText = "Ngày bán";
            dgvDHB.Columns[4].HeaderText = "Tổng thanh toán";

            comboBox.LienKet1DuLieu(BUS_NhanVien.GetNhanVien(), "maNV", cbomaNV);// Hiển thị mã nhân viên và tên nhân viên

            comboBox.LienKet2DuLieu(BUS_KhachHang.GetKhachHang(), "tenKH", "maKH", cbotenKH);
            cbomaKH.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);// sự kiện hiển thị tên khách theo mã

            comboBox.LienKet2DuLieu(BUS_KhachHang.GetKhachHang(), "maKH", "tenKH", cbomaKH);
            cbotenKH.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
        }
        // các chức năng
        private void dgvDHB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmaDHB.Text = dgvDHB[0, i].Value.ToString();
            cbomaNV.Text = dgvDHB[1, i].Value.ToString();
            cbomaKH.Text = dgvDHB[2, i].Value.ToString();
            dtpngayBan.Text = dgvDHB[3, i].Value.ToString();
            txtTongThanhToan.Text = dgvDHB[4, i].Value.ToString();
        }
        private void btntimKiemDHB_Click(object sender, EventArgs e)
        {
            DateTime ngayBan = txtTimHDB.Value;
            DataTable dtDonHangBan = busdhb.TimDHB(ngayBan);// TimDHB ở bus đơn hàng bán, tìm bằng datetime
            dgvDHB.DataSource = dtDonHangBan;
        }
        private void btnthemDHB_Click(object sender, EventArgs e)
        {
            string maDHB = txtmaDHB.Text;
            string maNV = cbomaNV.Text;
            string maKH = cbomaKH.Text;
            string ngayBan = dtpngayBan.Value.ToString("yyyy-MM-dd");
            float TongThanhToan = float.Parse(txtTongThanhToan.Text);
            DonHangBan dhb = new DonHangBan(maDHB, maNV, maKH, DateTime.Parse(ngayBan), TongThanhToan);
            if (busdhb.KiemTraMaTrung(maDHB) == 1)
            {
                MessageBox.Show("Mã đơn hàng bán đã tồn tại!");
            }
            else
            {
                if (busdhb.ThemDHB(dhb))
                {
                    dgvDHB.DataSource = busdhb.GetDHB();
                    MessageBox.Show("Thêm đơn hàng bán thành công");

                }
            }
        }
        private void btnsuaDHB_Click(object sender, EventArgs e)
        {
            string maDHB = txtmaDHB.Text;
            string maNV = cbomaNV.Text;
            string maKH = cbomaKH.Text;
            string ngayBan = dtpngayBan.Value.ToString("yyyy-MM-dd");
            float TongThanhToan = float.Parse(txtTongThanhToan.Text);
            DonHangBan dhb = new DonHangBan(maDHB, maNV, maKH, DateTime.Parse(ngayBan), TongThanhToan);
            if (busdhb.SuaDHB(dhb))
            {
                //MessageBox.Show("Sửa thành công");
                dgvDHB.DataSource = busdhb.GetDHB();
                MessageBox.Show("Sửa đơn hàng bán thành công");
            }
        }
        private void btnxoaDHB_Click(object sender, EventArgs e)
        {
            string ma = txtmaDHB.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busdhb.XoaDHB(ma))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvDHB.DataSource = busdhb.GetDHB();
                }
            }
        }
        private void btnhienThiDHB_Click(object sender, EventArgs e)
        {
            CapNhatTongTien();// click hiển thị để cập nhật cột tổng tiền lên bảng 
            dgvDHB.DataSource = busdhb.GetDHB();// load lại datagidview
        }
        private void CapNhatTongTien()
        {
            string maHDB = txtmaDHB.Text;
            float tongTien = busdhb.TongTien(maHDB);// tỉnh tổng tiền từ DAL bảng đơn hàng bán và Bus bảng chi tiết đơn bán
            txtTongThanhToan.Text = tongTien.ToString("N0");
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox ComboBox = sender as ComboBox;
            if (ComboBox != null && ComboBox.SelectedIndex != -1)
            {
                string KH = ((DataRowView)ComboBox.SelectedItem)[ComboBox.ValueMember].ToString();
                if (ComboBox == cbomaKH)
                {
                    cbotenKH.Text = KH;
                }
                else if (ComboBox == cbotenKH)
                {
                    cbomaKH.Text = KH;
                }
            }
        }
    }
}
