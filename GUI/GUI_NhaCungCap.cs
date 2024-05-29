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
    public partial class GUI_NhaCungCap : Form
    {
        BUS_NhaCungCap busncc = new BUS_NhaCungCap();
        public GUI_NhaCungCap()
        {
            InitializeComponent();
        }
        private void GUI_NhaCungCap_Load(object sender, EventArgs e)
        {
            dgvNCC.DataSource = busncc.GetNhaCungCap();
            dgvNCC.Columns[0].HeaderText = "Mã NCC";
            dgvNCC.Columns[1].HeaderText = "Họ tên NCC";
            dgvNCC.Columns[2].HeaderText = "Địa chỉ";
            dgvNCC.Columns[3].HeaderText = "SĐT";
        }
        // các chức năng
        private void txtTimNCC_TextChanged(object sender, EventArgs e)
        {
            GUI_NhaCungCap_Load(sender, e);
            string searchText = txtTimNCC.Text.Trim().ToUpperInvariant();

            for (int i = dgvNCC.Rows.Count - 2; i >= 0; i--)
            {
                string cellValue0 = dgvNCC[0, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue1 = dgvNCC[1, i].Value?.ToString().Trim().ToUpperInvariant();

                bool containsSearchText = (!string.IsNullOrEmpty(cellValue0) && cellValue0.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue1) && cellValue1.Contains(searchText));

                if (!containsSearchText)
                {
                    dgvNCC.Rows.RemoveAt(i);
                }
            }
        }
        private void btnthemNCC_Click(object sender, EventArgs e)
        {
            string maNCC = txtmaNCC.Text;
            string tenNCC = txttenNCC.Text;
            string diaChi = txtdiaChi.Text;
            string sdtNCC = txtsdtNCC.Text;
            NhaCungCap ncc = new NhaCungCap(maNCC, tenNCC, diaChi, sdtNCC);
            if (busncc.KiemTraMaTrung(maNCC) == 1)
            {
                MessageBox.Show("Mã nhà cung cấp đã tồn tại!");
            }
            else
            {
                if (busncc.ThemNCC(ncc))
                {
                    dgvNCC.DataSource = busncc.GetNhaCungCap();
                    MessageBox.Show("Thêm nhà cung cấp mới thành công");
                }
            }
        }
        private void btnsuaNCC_Click(object sender, EventArgs e)
        {
            string maNCC = txtmaNCC.Text;
            string tenNCC = txttenNCC.Text;
            string diaChi = txtdiaChi.Text;
            string sdtNCC = txtsdtNCC.Text;
            NhaCungCap ncc = new NhaCungCap(maNCC, tenNCC, diaChi, sdtNCC);
            if (busncc.SuaNCC(ncc))
            {
                //MessageBox.Show("Sửa thành công");
                dgvNCC.DataSource = busncc.GetNhaCungCap();
                MessageBox.Show("Sửa thông tin nhà cung cấp thành công");
            }
        }
        private void btnxoaNCC_Click(object sender, EventArgs e)
        {
            string ma = txtmaNCC.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busncc.XoaNCC(ma))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvNCC.DataSource = busncc.GetNhaCungCap();
                }
            }
        }
        private void btnhienThiNCC_Click(object sender, EventArgs e)
        {
            txtmaNCC.Text = "";
            txttenNCC.Text = "";
            txtdiaChi.Text = "";
            txtsdtNCC.Text = "";
            dgvNCC.DataSource = busncc.GetNhaCungCap();//Load lại datagridview
        }
        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmaNCC.Text = dgvNCC[0, i].Value.ToString();
            txttenNCC.Text = dgvNCC[1, i].Value.ToString();
            txtdiaChi.Text = dgvNCC[2, i].Value.ToString();
            txtsdtNCC.Text = dgvNCC[3, i].Value.ToString();
        }
    }
}
