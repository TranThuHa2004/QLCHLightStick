using BUS;
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
    public partial class GUI_ThongKe : Form
    {
        BUS_ThongKe thongKe = new BUS_ThongKe();
        private readonly BUS_BaoCao reportBUS;
        public GUI_ThongKe()
        {
            InitializeComponent();
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            cboxThongKe_SelectedIndexChanged(sender,e);
        }

        private void cboxThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy giá trị đã chọn từ ComboBox
            string selectedOption = cboxThongKe.SelectedItem.ToString();
            DateTime fromDate = FromDate.Value; // Lấy giá trị ngày bắt đầu muốn thống kê
            DateTime toDate = ToDate.Value; // Lấy ra ngày kết thúc thống kê

            // lựa chọn trong ComboBox
            switch (selectedOption)
            {
                case "Mặt hàng bán chạy nhất":
                    DataTable dt = thongKe.HangBanChay(fromDate, toDate); // Truyền ngày tháng năm vào phương thức HangBanChay
                    dgvThongKe.DataSource = dt;
                    break;
                case "Số lượng hàng tồn kho":
                    DataTable dr = thongKe.HangTonKho(fromDate, toDate); // Truyền ngày tháng năm vào phương thức HangTonKho
                    dgvThongKe.DataSource = dr;
                    break;
                default:
                    break;
            }
        }
    }
}
