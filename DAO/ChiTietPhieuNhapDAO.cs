using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietPhieuNhapDAO
    {
        private DataProvider Instance;
        public ChiTietPhieuNhapDAO()
        {
            Instance = new DataProvider();
        }
        public DataTable GetListChiTietPhieuNhap()
        {
            return Instance.ExecuteQuery($"SELECT * FROM CHITIETPHIEUNHAP");
        }
        public DataTable GetListChiTietPhieuNhap(string MaPN)
        {
            return Instance.ExecuteQuery($"SELECT * FROM CHITIETPHIEUNHAP WHERE MaPN = N'{MaPN}'");
        }

        public bool InsertChiTietPhieuNhap(string maPN, string maNL, decimal donGia, int soLuong, decimal thanhTien)
        {
            try
            {
                Instance.ExecuteNonQuery($"INSERT CHITIETPHIEUNHAP (MaPN, MaNL, DonGia, SoLuong, ThanhTien) " +
                $"VALUES (N'{maPN}', N'{maNL}', {donGia}, {soLuong}, {thanhTien})");
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool DeleteChiTietPhieuNhap(string maPN, string maNL)
        {
            try
            {
                Instance.ExecuteNonQuery($"DELETE CHITIETPHIEUNHAP WHERE MaPN = N'{maPN} AND MaNL = N'{maNL}'");
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
