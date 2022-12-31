using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HoaDonDAO
    {
        private DataProvider Instance;
        public HoaDonDAO()
        {
            Instance = new DataProvider();
        }

        public DataTable GetHoaDonChuaThanhToanByMaBan(string maBan) 
        {
            return Instance.ExecuteQuery($"SELECT * FROM HOADON WHERE MaBan=N'{maBan}' AND TinhTrang = 0");
        }

        public bool CheckOut(string maHD)
        {
            return Instance.ExecuteNonQuery($"UPDATE HOADON SET DateCheckOut = GETDATE(), TinhTrang = 1 WHERE MaHD=N'{maHD}'") > 0;
        }

        public bool InsertHoaDon(string maHD, DateTime dateCheckIn, DateTime? dateCheckOut, int tinhTrang, decimal tongTien, string userName, string maBan)
        {
            if (dateCheckOut == null)
            {
                return Instance.ExecuteNonQuery($"INSERT HOADON (maHD, dateCheckIn, dateCheckOut, tinhTrang, tongTien, userName, maBan) " +
                $"VALUES (N'{maHD}', N'{dateCheckIn.ToString("yyyy-MM-dd hh:mm:ss")}', NULL , {tinhTrang}, {tongTien}, N'{userName}', N'{maBan}')") > 0;
            }

            return Instance.ExecuteNonQuery($"INSERT HOADON (maHD, dateCheckIn, dateCheckOut, tinhTrang, tongTien, userName, maBan) " +
                $"VALUES (N'{maHD}', N'{dateCheckIn.ToString("yyyy-MM-dd hh:mm:ss")}', N'{dateCheckOut?.ToString("yyyy-MM-dd hh:mm:ss")} , {tinhTrang}, {tongTien}, N'{userName}', N'{maBan}')") > 0; ;
        }

        public bool DeleteHoaDon(string maHD)
        {
            return Instance.ExecuteNonQuery($"DELETE HOADON WHERE MaHD = N'{maHD}'") > 0;
        }

        public DataTable GetHoaDonByMa(string maHD)
        {
            return Instance.ExecuteQuery($"SELECT * FROM HOADON WHERE MaHD = N'{maHD}'");
        }
    }
}
