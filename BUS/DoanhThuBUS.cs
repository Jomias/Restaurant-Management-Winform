using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DoanhThuBUS
    {
        private DoanhThuDAO doanhThuDAO;
        public DoanhThuBUS()
        {
            doanhThuDAO = new DoanhThuDAO();
        }
        public DataTable GetDoanhThu(string NgayBatDau, string NgayKetThuc, int loaiDT)
        {
            return doanhThuDAO.GetDoanhThu(NgayBatDau, NgayKetThuc, loaiDT);
        }
    }
}
