using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BUS
{
    public class BUS_BaoCao
    {
        private readonly DAL_BaoCao DoanhThu;

        public BUS_BaoCao()
        {
            DoanhThu = new DAL_BaoCao();
        }

        public DataTable BaoCaoDoanhThu( DateTime fromDate, DateTime toDate)
        {
            return DoanhThu.BaoCaoDoanhThu(fromDate, toDate);// Bus báo cáo doanh thu trong khoảng thời gian nhập từ bàn phím
        }
    }
}
