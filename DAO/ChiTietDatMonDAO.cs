using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietDatMonDAO
    {
        private DataProvider Instance;
        public ChiTietDatMonDAO()
        {
            Instance = new DataProvider();
        }
        public DataTable GetListChiTietDatMon(string MaHD)
        {
            return Instance.ExecuteQuery($"SELECT * FROM CHITIETDATMON WHERE MaHD = N'{MaHD}'");
        }

        public bool InsertChiTietDatMon(string maHD, string maMA, decimal donGia, int soLuong, decimal thanhTien)
        {
            try
            {
                Instance.ExecuteNonQuery($"INSERT CHITIETDATMON (MaHD, MaMA, DonGia, SoLuong, ThanhTien) " +
                $"VALUES (N'{maHD}', N'{maMA}', {donGia}, {soLuong}, {thanhTien})");
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool DeleteChiTietDatMon(string maHD)
        {
            try
            {
                Instance.ExecuteNonQuery($"DELETE CHITIETDATMON WHERE MaHD = N'{maHD}'");
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
