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

namespace GUI
{
    public partial class GUI_BaoCao : Form
    {
        BUS_BaoCao bS_BaoCao = new BUS_BaoCao();
        public GUI_BaoCao()
        {
            InitializeComponent();
        }
        private void btnBaocao_Click(object sender, EventArgs e)
        {
            DateTime fromDate = FromDate.Value; // Ngày bắt đầu muốn thống kê
            DateTime toDate = ToDate.Value; // Ngày kết thúc thống kê
            DataTable dt = bS_BaoCao.BaoCaoDoanhThu(fromDate, toDate); // Truyền ngày tháng năm vào phương thức BaoCaoDoanhThu ở BUS Báo cáo
            dgvBaoCao.DataSource = dt;
        }

        private void dgvBaoCao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtBan.Text = dgvBaoCao[2, i].Value.ToString();
            txtNhap.Text = dgvBaoCao[3, i].Value.ToString();
            txtLai.Text = dgvBaoCao[4, i].Value.ToString();
            txtsoLuongBan.Text = dgvBaoCao[5, i].Value.ToString();
            txtSoLuongNhap.Text = dgvBaoCao[6, i].Value.ToString();
        }

        private void dgvBaoCao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
