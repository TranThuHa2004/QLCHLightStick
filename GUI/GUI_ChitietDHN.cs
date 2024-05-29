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
    public partial class GUI_ChitietDHN : Form
    {
        BUS_DonHangNhap busdhn = new BUS_DonHangNhap();
        BUS_ChitietDHN busctdhn = new BUS_ChitietDHN();
        BUS_Lightsick BUS_Lightsick = new BUS_Lightsick();
        LienKetComboBox comboBox = new LienKetComboBox();
        public GUI_ChitietDHN()
        {
            InitializeComponent();
        }
        private void GUI_ChitietDHN_Load(object sender, EventArgs e)
        {
            dgvCTDHN.DataSource = busctdhn.GetCTDHN();
            dgvCTDHN.Columns[0].HeaderText = "Mã CTN";
            dgvCTDHN.Columns[1].HeaderText = "Mã DHN";
            dgvCTDHN.Columns[2].HeaderText = "Mã LT";
            dgvCTDHN.Columns[3].HeaderText = "Giá tiền";
            dgvCTDHN.Columns[4].HeaderText = "Số lượng";
            dgvCTDHN.Columns[5].HeaderText = "Tổng tiền";

            comboBox.LienKet2DuLieu(BUS_Lightsick.GetLT(), "maLT", "TenLT", cbomaLT);//Liên kết bảng LT với combobox Mã LT và Tên LT

            cbomaLT.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);//Hiển thị tên LT theo mã LT được chọn


            // ở dưới tương tự
            comboBox.LienKet2DuLieu(BUS_Lightsick.GetLT(), "TenLT", "maLT", txttenLT);
            txttenLT.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);

            comboBox.LienKet1DuLieu(busdhn.GetDHN(), "maDHN", cbomaDHN);
        }
        // Các chức năng
        private void btnhienThiCTDHN_Click(object sender, EventArgs e)
        {
            cbomaDHN.Text = "";
            txtgiaTien.Text = "";
            txtsoLuong.Refresh();
            txtTongTien.Text = "";
        }
        private void txtTimDHN_TextChanged(object sender, EventArgs e)
        {
            GUI_ChitietDHN_Load(sender, e);
            string searchText = txtTimDHN.Text.Trim().ToUpperInvariant();

            for (int i = dgvCTDHN.Rows.Count - 2; i >= 0; i--)
            {
                string cellValue1 = dgvCTDHN[1, i].Value?.ToString().Trim().ToUpperInvariant();


                bool containsSearchText = (!string.IsNullOrEmpty(cellValue1) && cellValue1.Contains(searchText));


                if (!containsSearchText)
                {
                    dgvCTDHN.Rows.RemoveAt(i);
                }
            }
        }
        private void btnthemCTDHN_Click(object sender, EventArgs e)
        {
            string maCTN = txtMaCTN.Text;
            string maDHN = cbomaDHN.Text;
            string maLT = cbomaLT.Text;
            float giaTien = float.Parse(txtgiaTien.Text);
            int soLuong = int.Parse(txtsoLuong.Text);
            float TongTien = float.Parse(txtTongTien.Text);
            ChitietDHN ctdhn = new ChitietDHN(maCTN, maDHN, maLT, giaTien, soLuong, TongTien);
            if (busctdhn.KiemTraMaTrung(maDHN) == 1)
            {
                MessageBox.Show("Mã chi tiết đơn hàng nhập đã tồn tại!");
            }
            else
            {
                if (busctdhn.ThemCTDHN(ctdhn))
                {
                    BUS_Lightsick.TangSoLuong(cbomaLT.Text, int.Parse(txtsoLuong.Text));
                    dgvCTDHN.DataSource = busctdhn.GetCTDHN();
                    MessageBox.Show("Thêm chi tiết đơn hàng nhập thành công");

                }
            }
        }
        private void btnsuaCTDHN_Click(object sender, EventArgs e)
        {
            string maCTN = txtMaCTN.Text;
            string maDHN = cbomaDHN.Text;
            string maLT = cbomaLT.Text;
            float giaTien = float.Parse(txtgiaTien.Text);
            int soLuong = int.Parse(txtsoLuong.Text);
            float TongTien = float.Parse(txtTongTien.Text);
            ChitietDHN ctdhn = new ChitietDHN(maCTN, maDHN, maLT, giaTien, soLuong, TongTien);
            if (busctdhn.SuaCTDHN(ctdhn))
            {
                //MessageBox.Show("Sửa thành công");
                dgvCTDHN.DataSource = busctdhn.GetCTDHN();
                MessageBox.Show("Sửa chi tiết đơn hàng nhập thành công");
            }
        }
        private void btnxoaCTDHN_Click(object sender, EventArgs e)
        {
            string ma = cbomaDHN.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busctdhn.XoaCTDHN(ma))
                {
                    BUS_Lightsick.GiamSoLuong(cbomaLT.Text, int.Parse(txtsoLuong.Text));

                    MessageBox.Show("Xóa thành công");
                    dgvCTDHN.DataSource = busctdhn.GetCTDHN();
                }
            }
        }
        private void txtDonGiaXuat_TextChanged(object sender, EventArgs e)
        {
            // IsNullOrEmpty có tác dụng kiểm tra txtgiaTien có phải là Null hoặc là một chuỗi rỗng hay không
            if (!string.IsNullOrEmpty(txtgiaTien.Text) && float.TryParse(txtgiaTien.Text, out float donGiaNhap))// khai báo txtgiaTien là float, out là donGiaNhap 
            {
                int soLuong = (int)txtsoLuong.Value;
                float thanhTien = donGiaNhap * soLuong;
                txtTongTien.Text = thanhTien.ToString("N0");
            }
        }
        private void txtSoLuong_ValueChanged(object sender, EventArgs e)
        {
            // Khi số lượng thay đổi, tính toán lại thành tiền
            txtDonGiaXuat_TextChanged(sender, e);
        }
        private void dgvCTDHN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMaCTN.Text = dgvCTDHN[0, i].Value.ToString();
            cbomaDHN.Text = dgvCTDHN[1, i].Value.ToString();
            cbomaLT.Text = dgvCTDHN[2, i].Value.ToString();
            txtgiaTien.Text = dgvCTDHN[3, i].Value.ToString();
            txtsoLuong.Text = dgvCTDHN[4, i].Value.ToString();
            txtTongTien.Text = dgvCTDHN[5, i].Value.ToString();
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox ComboBox = sender as ComboBox;
            if (ComboBox != null && ComboBox.SelectedIndex != -1)
            {
                string LT = ((DataRowView)ComboBox.SelectedItem)[ComboBox.ValueMember].ToString();
                if (ComboBox == txttenLT)// chọn tên LT ở combobox TenLT
                {
                    cbomaLT.Text = LT;// maLT tương ứng sẽ hiển thị ra ở combobox maLT
                }
                else if (ComboBox == cbomaLT)
                {
                    txttenLT.Text = LT;
                }
            }
        }
    }
}
