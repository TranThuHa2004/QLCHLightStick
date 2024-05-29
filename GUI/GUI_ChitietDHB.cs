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
    public partial class GUI_ChitietDHB : Form
    {
        BUS_ChitietDHB busctdhb = new BUS_ChitietDHB();
        BUS_Lightsick BUS_Lightsick = new BUS_Lightsick();
        BUS_DonHangBan BUS_DonHangBan = new BUS_DonHangBan();
        LienKetComboBox comboBox = new LienKetComboBox();
        public GUI_ChitietDHB()
        {
            InitializeComponent();
        }
        private void GUI_ChitietDHB_Load(object sender, EventArgs e)
        {
            dgvCTDHB.DataSource = busctdhb.GetCTDHB();
            dgvCTDHB.Columns[0].HeaderText = "Mã CTB";
            dgvCTDHB.Columns[1].HeaderText = "Mã DHB";
            dgvCTDHB.Columns[2].HeaderText = "Mã LT";
            dgvCTDHB.Columns[3].HeaderText = "Giá tiền";
            dgvCTDHB.Columns[4].HeaderText = "Số lượng";
            dgvCTDHB.Columns[5].HeaderText = "Tổng Tiền";

            comboBox.LienKet2DuLieu(BUS_Lightsick.GetLT(), "maLT", "TenLT", txtmaLT);//Liên kết bảng LT với combobox Mã LT và Tên LT

            txtmaLT.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);//Hiển thị tên LT theo mã LT được chọn

            // ở dưới tương tự
            comboBox.LienKet2DuLieu(BUS_Lightsick.GetLT(), "TenLT", "maLT", txttenLT);

            txttenLT.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);

            comboBox.LienKet1DuLieu(BUS_DonHangBan.GetDHB(), "maDHB", txtmaDHB);// chỉ hiển thị mã đơn hàng bán vào combobox

        }

        // Chức năng 
        private void dgvCTDHB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMaCTB.Text = dgvCTDHB[0, i].Value.ToString();
            txtmaDHB.Text = dgvCTDHB[1, i].Value.ToString();
            txtmaLT.Text = dgvCTDHB[2, i].Value.ToString();
            txtgiaTien.Text = dgvCTDHB[3, i].Value.ToString();
            txtsoLuong.Text = dgvCTDHB[4, i].Value.ToString();
            txtTongTien.Text = dgvCTDHB[5, i].Value.ToString();
        }

        private void txtTimCTB_TextChanged(object sender, EventArgs e)
        {
            GUI_ChitietDHB_Load(sender, e);
            string searchText = txtTimCTB.Text.Trim().ToUpperInvariant();

            for (int i = dgvCTDHB.Rows.Count - 2; i >= 0; i--)
            {
                string cellValue1 = dgvCTDHB[1, i].Value?.ToString().Trim().ToUpperInvariant();


                bool containsSearchText = (!string.IsNullOrEmpty(cellValue1) && cellValue1.Contains(searchText));


                if (!containsSearchText)
                {
                    dgvCTDHB.Rows.RemoveAt(i);
                }
            }
        }
        private void btnthemCTDHB_Click(object sender, EventArgs e)
        {
            string maCTB = txtMaCTB.Text;
            string maDHB = txtmaDHB.Text;
            string maLT = txtmaLT.Text;
            float giaTien = float.Parse(txtgiaTien.Text);
            int soLuong = int.Parse(txtsoLuong.Text);
            float TongTien = float.Parse(txtTongTien.Text);
            ChitietDHB ctdhb = new ChitietDHB(maCTB, maDHB, maLT, giaTien, soLuong, TongTien);
            if (busctdhb.KiemTraMaTrung(maDHB) == 1)
            {
                MessageBox.Show("Mã chi tiết đơn hàng bán đã tồn tại!");
            }
            else
            {
                if (busctdhb.ThemCTDHB(ctdhb))
                {
                    // Thêm chi tiết bán thành công thì số lượng hàng tự giảm đi
                    BUS_Lightsick.GiamSoLuong(txtmaLT.Text, int.Parse(txtsoLuong.Text));
                    dgvCTDHB.DataSource = busctdhb.GetCTDHB();
                    MessageBox.Show("Thêm chi tiết đơn hàng bán thành công");
                }
            }
        }
        private void btnsuaCTDHB_Click(object sender, EventArgs e)
        {
            string maCTB = txtMaCTB.Text;
            string maDHB = txtmaDHB.Text;
            string maLT = txtmaLT.Text;
            float giaTien = float.Parse(txtgiaTien.Text);
            int soLuong = int.Parse(txtsoLuong.Text);
            float TongTien = float.Parse(txtTongTien.Text);
            ChitietDHB ctdhb = new ChitietDHB(maCTB, maDHB, maLT, giaTien, soLuong, TongTien);
            if (busctdhb.SuaCTDHB(ctdhb))
            {
                //MessageBox.Show("Sửa thành công");
                dgvCTDHB.DataSource = busctdhb.GetCTDHB();
                MessageBox.Show("Sửa thông tin chi tiết đơn hàng bán thành công");

            }
        }
        private void btnxoaCTDHB_Click(object sender, EventArgs e)
        {
            string ma = txtmaDHB.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busctdhb.XoaCTDHB(ma))
                {
                    // xoá chi tiết bán thành công thì số lượng hàng trở về số lượng ban đầu
                    BUS_Lightsick.TangSoLuong(txtmaLT.Text, int.Parse(txtsoLuong.Text));
                    MessageBox.Show("Xóa thành công");
                    dgvCTDHB.DataSource = busctdhb.GetCTDHB();
                }
            }
        }
        private void btnhienThiCTDHB_Click(object sender, EventArgs e)
        {
            txtmaDHB.Text = "";
            txtmaLT.Text = "";
            txtsoLuong.Text = "";
            txtgiaTien.Text = "";
            txtTongTien.Text = "";
            dgvCTDHB.DataSource = busctdhb.GetCTDHB();// click với mục đích load lại bảng chi tiết bán vào datagridview
        }
        // tính tổng tiền  
        private void txtgiaTien_TextChanged(object sender, EventArgs e)
        {
            // IsNullOrEmpty có tác dụng kiểm tra txtgiaTien có phải là Null hoặc là một chuỗi rỗng hay không
            if (!string.IsNullOrEmpty(txtgiaTien.Text) && float.TryParse(txtgiaTien.Text, out float donGiaBan))// khai báo txtgiaTien là float, out là donGiaBan 
            {
                int soLuong = (int)txtsoLuong.Value;
                float thanhTien = donGiaBan * soLuong;
                txtTongTien.Text = thanhTien.ToString("N0");
            }
        }
        // sự kiện tăng giảm số lượng thì tổng tiền cũng tăng giảm (giá tiền x số lượng)
        private void txtsoLuong_ValueChanged(object sender, EventArgs e)
        {
            txtgiaTien_TextChanged(sender, e);
        }
        // phương thức kết nối tới phần tử trong hàng trong một bảng và đẩy vào combobox
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox ComboBox = sender as ComboBox;
            if (ComboBox != null && ComboBox.SelectedIndex != -1)
            {
                string LT = ((DataRowView)ComboBox.SelectedItem)[ComboBox.ValueMember].ToString();
                if (ComboBox == txttenLT)// chọn tên LT ở combobox TenLT
                {
                    txtmaLT.Text = LT;// maLT tương ứng sẽ hiển thị ra ở combobox maLT
                }
                else if (ComboBox == txtmaLT)
                {
                    txttenLT.Text = LT;
                }
            }
        }
    }
}
