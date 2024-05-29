using BUS;
using DTO;
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
    public partial class GUI_NhomNhac : Form
    {
        BUS_NhomNhac busnn= new BUS_NhomNhac();
        public GUI_NhomNhac()
        {
            InitializeComponent();
        }

        private void GUI_NhomNhac_Load(object sender, EventArgs e)
        {
            dgvNN.DataSource = busnn.GetNhomNhac();
            dgvNN.Columns[0].HeaderText = "Mã NN";
            dgvNN.Columns[1].HeaderText = "Tên NN";
            dgvNN.Columns[2].HeaderText = "Mã NCC";
        }
        // các chức năng
        private void txtTimNN_TextChanged(object sender, EventArgs e)
        {
            GUI_NhomNhac_Load(sender, e);
            string searchText = txtTimNN.Text.Trim().ToUpperInvariant();

            for (int i = dgvNN.Rows.Count - 2; i >= 0; i--)
            {
                string cellValue0 = dgvNN[0, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue1 = dgvNN[1, i].Value?.ToString().Trim().ToUpperInvariant();

                bool containsSearchText = (!string.IsNullOrEmpty(cellValue0) && cellValue0.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue1) && cellValue1.Contains(searchText));

                if (!containsSearchText)
                {
                    dgvNN.Rows.RemoveAt(i);
                }
            }
        }
        private void btnthemNN_Click(object sender, EventArgs e)
        {
            string maNN = txtmaNN.Text;
            string tenNN = txttenNN.Text;
            string maNCC = txtmaNCC.Text;
            NhomNhac nn = new NhomNhac(maNN, tenNN, maNCC);
            if (busnn.KiemTraMaTrung(maNN) == 1)
            {
                MessageBox.Show("Mã nhóm nhạc đã tồn tại!");
            }
            else
            {
                if (busnn.ThemNN(nn))
                {
                    dgvNN.DataSource = busnn.GetNhomNhac();
                    MessageBox.Show("Thêm nhóm nhạc mới thành công");
                }
            }
        }
        private void btnsuaNN_Click(object sender, EventArgs e)
        {
            string maNN = txtmaNN.Text;
            string tenNN = txttenNN.Text;
            string maNCC = txtmaNCC.Text;
            NhomNhac nn = new NhomNhac(maNN, tenNN, maNCC);
            if (busnn.SuaNN(nn))
            {
                //MessageBox.Show("Sửa thành công");
                dgvNN.DataSource = busnn.GetNhomNhac();
                MessageBox.Show("Sửa thông tin nhóm nhạc thành công");
            }
        }
        private void btnxoaNN_Click(object sender, EventArgs e)
        {
            string ma = txtmaNN.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busnn.XoaNN(ma))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvNN.DataSource = busnn.GetNhomNhac();
                }
            }
        }
        private void btnhienThiNN_Click(object sender, EventArgs e)
        {
            txtmaNN.Text = "";
            txttenNN.Text = "";
            txtmaNCC.Text = "";
            dgvNN.DataSource = busnn.GetNhomNhac();// load lại datagridview
        }
        private void dgvNN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmaNN.Text = dgvNN[0, i].Value.ToString();
            txttenNN.Text = dgvNN[1, i].Value.ToString();
            txtmaNCC.Text = dgvNN[2, i].Value.ToString();
        }
    }
}
