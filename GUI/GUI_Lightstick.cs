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
    public partial class GUI_Lightstick : Form
    {
        BUS_Lightsick buslt = new BUS_Lightsick();
        public GUI_Lightstick()
        {
            InitializeComponent();
        }

        private void GUI_Lightstick_Load(object sender, EventArgs e)
        {
            dgvLightstick.DataSource = buslt.GetLT();
            dgvLightstick.Columns[0].HeaderText = "Mã Lightstick";
            dgvLightstick.Columns[1].HeaderText = "Tên Lighstick";
            dgvLightstick.Columns[2].HeaderText = "Mã NN";
            dgvLightstick.Columns[3].HeaderText = "Số lượng";
            dgvLightstick.Columns[4].HeaderText = "Giá tiền";
        }
        // các chức năng
        private void btnhienThiLT_Click(object sender, EventArgs e)
        {
            txtmaLT.Text = "";
            txttenLT.Text = "";
            txtmaNN.Text = "";
            txtsoLuong.Text = "";
            txtgiaTien.Text = "";
            dgvLightstick.DataSource = buslt.GetLT();// load lại datagridview
        }
        private void txtTimLT_TextChanged(object sender, EventArgs e)
        {
            GUI_Lightstick_Load(sender, e);
            string searchText = txtTimLT.Text.Trim().ToUpperInvariant();

            for (int i = dgvLightstick.Rows.Count - 2; i >= 0; i--)
            {
                string cellValue0 = dgvLightstick[0, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue1 = dgvLightstick[1, i].Value?.ToString().Trim().ToUpperInvariant();

                bool containsSearchText = (!string.IsNullOrEmpty(cellValue0) && cellValue0.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue1) && cellValue1.Contains(searchText));

                if (!containsSearchText)
                {
                    dgvLightstick.Rows.RemoveAt(i);
                }
            }
        }
        private void btnthemLT_Click(object sender, EventArgs e)
        {
            string maLT = txtmaLT.Text;
            string tenLT = txttenLT.Text;
            string maNN = txtmaNN.Text;
            string soLuong = txtsoLuong.Text;
            string giaTien = txtgiaTien.Text;
            Lightstick lt = new Lightstick(maLT, tenLT, maNN, soLuong, giaTien);
            if (buslt.KiemTraMaTrung(maLT) == 1)
            {
                MessageBox.Show("Mã Lighstick đã tồn tại!");
            }
            else
            {
                if (buslt.ThemLT(lt))
                {
                    dgvLightstick.DataSource = buslt.GetLT();
                    MessageBox.Show("Thêm Lighstick mới thành công");

                }
            }
        }
        private void btnsuaLT_Click(object sender, EventArgs e)
        {
            string maLT = txtmaLT.Text;
            string tenLT = txttenLT.Text;
            string maNN = txtmaNN.Text;
            string soLuong = txtsoLuong.Text;
            string giaTien = txtgiaTien.Text;
            Lightstick lt = new Lightstick(maLT, tenLT, maNN, soLuong, giaTien);
            if (buslt.SuaLT(lt))
            {
                //MessageBox.Show("Sửa thành công");
                dgvLightstick.DataSource = buslt.GetLT();
                MessageBox.Show("Sửa thông tin Lighstick thành công");

            }
        }
        private void btnxoaLT_Click(object sender, EventArgs e)
        {
            string ma = txtmaLT.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (buslt.XoaLT(ma))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvLightstick.DataSource = buslt.GetLT();
                }
            }
        }
        private void dgvLightstick_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmaLT.Text = dgvLightstick[0, i].Value.ToString();
            txttenLT.Text = dgvLightstick[1, i].Value.ToString();
            txtmaNN.Text = dgvLightstick[2, i].Value.ToString();
            txtsoLuong.Text = dgvLightstick[3, i].Value.ToString();
            txtgiaTien.Text = dgvLightstick[4, i].Value.ToString();

        }
    }
}
