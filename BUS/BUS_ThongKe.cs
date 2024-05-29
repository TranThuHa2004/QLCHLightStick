using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BUS
{
    public class BUS_ThongKe
    {
        private readonly DAL_ThongKe ThongKe;
        public BUS_ThongKe()
        {
            ThongKe = new DAL_ThongKe();
        }

        public DataTable HangBanChay(DateTime fromDate, DateTime toDate)
        {
            return ThongKe.HangBanChay(fromDate, toDate);//Thống kê top 5 mặt hàng bán chạy trong khoảng thời gian nhập từ bàn phím 
        }
        public DataTable HangTonKho(DateTime fromDate, DateTime toDate)
        {
            return ThongKe.HangTonKho(fromDate, toDate);// thống kê số lượng mặt hàng còn tồn trong kho trong khoảng thời gian nhập từ bàn phím (chỉ hiển thị những mặt hàng đã được thêm vào đơn hàng bán)
        }

    }
}
