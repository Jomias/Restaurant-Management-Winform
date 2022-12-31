using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DoanhThuDAO
    {
        private DataProvider Instance;
        public DoanhThuDAO()
        {
            Instance = new DataProvider();
        }
        public DataTable GetDoanhThu(string NgayBatDau, string NgayKetThuc, int LoaiDT)
        {
            string query = "";
            if (LoaiDT == 0)
            {
                query = $"SELECT CONCAT(ISNULL(A.Ngay, B.Ngay), '/' ,ISNULL(A.Thang, B.Thang), '/', ISNULL(A.Nam, B.Nam)) AS N'Thời gian'," +
                    $"\r\nISNULL(A.TienBan, 0) AS N'Tổng tiền bán', ISNULL(B.TienNhap, 0) AS N'Tổng tiền nhập'," +
                    $"\r\niif(ISNULL(A.TienBan, 0) - ISNULL(B.TienNhap, 0) >= 0, N'Lãi', N'Lỗ') AS N'Đánh giá'," +
                    $"\r\nABS(ISNULL(A.TienBan, 0) - ISNULL(B.TienNhap, 0)) AS N'Tổng cộng'" +
                    $"\r\nFROM (SELECT SUM(TongTien) AS TienBan, Day(DateCheckOut) AS Ngay, MONTH(DateCheckOut) AS Thang, YEAR(DateCheckOut) AS Nam" +
                    $"\r\n\t FROM HOADON" +
                    $"\r\n\t WHERE DateCheckOut >= '{NgayBatDau}' AND DateCheckOut <= '{NgayKetThuc}'" +
                    $"\r\n\t GROUP BY YEAR(DateCheckOut), MONTH(DateCheckOut), DAY(DateCheckOut)) AS A FULL OUTER JOIN" +
                    $"\r\n\t (SELECT SUM(TongTien) AS TienNhap, Day(NgayLap) AS Ngay, MONTH(NgayLap) AS Thang, YEAR(NgayLap) AS Nam" +
                    $"\r\n\t FROM PHIEUNHAP" +
                    $"\r\n\t WHERE NgayLap >= '{NgayBatDau}' AND NgayLap <= '{NgayKetThuc}'" +
                    $"\r\n\t GROUP BY YEAR(NgayLap), MONTH(NgayLap), Day(NgayLap)) AS B" +
                    $"\r\nON A.Ngay = B.Ngay AND A.Thang = B.Thang AND A.Nam = B.Nam" +
                    $"\r\nORDER BY ISNULL(A.Nam, B.Nam), ISNULL(A.Thang, B.Thang), ISNULL(A.Ngay, B.Ngay)";
            }
            if (LoaiDT == 1) 
            {
                query = $"SELECT CONCAT(ISNULL(A.Thang, B.Thang), '/', ISNULL(A.Nam, B.Nam)) AS N'Thời gian'," +
                    $"\r\nISNULL(A.TienBan, 0) AS N'Tổng tiền bán', ISNULL(B.TienNhap, 0) AS N'Tổng tiền nhập'," +
                    $"\r\niif(ISNULL(A.TienBan, 0) - ISNULL(B.TienNhap, 0) >= 0, N'Lãi', N'Lỗ') AS N'Đánh giá'," +
                    $"\r\nABS(ISNULL(A.TienBan, 0) - ISNULL(B.TienNhap, 0)) AS N'Tổng cộng'" +
                    $"\r\nFROM (SELECT SUM(TongTien) AS TienBan, MONTH(DateCheckOut) AS Thang, YEAR(DateCheckOut) AS Nam" +
                    $"\r\n\t FROM HOADON" +
                    $"\r\n\t WHERE DateCheckOut >= '{NgayBatDau}' AND DateCheckOut <= '{NgayKetThuc}'" +
                    $"\r\n\t GROUP BY YEAR(DateCheckOut), MONTH(DateCheckOut)) AS A FULL OUTER JOIN" +
                    $"\r\n\t (SELECT SUM(TongTien) AS TienNhap, MONTH(NgayLap) AS Thang, YEAR(NgayLap) AS Nam" +
                    $"\r\n\t FROM PHIEUNHAP" +
                    $"\r\n\t WHERE NgayLap >= '{NgayBatDau}' AND NgayLap <= '{NgayKetThuc}'" +
                    $"\r\n\t GROUP BY YEAR(NgayLap), MONTH(NgayLap)) AS B" +
                    $"\r\nON A.Thang = B.Thang AND A.Nam = B.Nam" +
                    $"\r\nORDER BY ISNULL(A.Nam, B.Nam), ISNULL(A.Thang, B.Thang)";
            }
            if (LoaiDT == 2)
            {
                query = $"SELECT ISNULL(A.Nam, B.Nam) AS N'Thời gian'," +
                    $"\r\nISNULL(A.TienBan, 0) AS N'Tổng tiền bán', ISNULL(B.TienNhap, 0) AS N'Tổng tiền nhập'," +
                    $"\r\niif(ISNULL(A.TienBan, 0) - ISNULL(B.TienNhap, 0) >= 0, N'Lãi', N'Lỗ') AS N'Đánh giá'," +
                    $"\r\nABS(ISNULL(A.TienBan, 0) - ISNULL(B.TienNhap, 0)) AS N'Tổng cộng'" +
                    $"\r\nFROM (SELECT SUM(TongTien) AS TienBan, YEAR(DateCheckOut) AS Nam" +
                    $"\r\n\t FROM HOADON" +
                    $"\r\n\t WHERE DateCheckOut >= '{NgayBatDau}' AND DateCheckOut <= '{NgayKetThuc}'" +
                    $"\r\n\t GROUP BY YEAR(DateCheckOut)) AS A FULL OUTER JOIN" +
                    $"\r\n\t (SELECT SUM(TongTien) AS TienNhap, YEAR(NgayLap) AS Nam" +
                    $"\r\n\t FROM PHIEUNHAP" +
                    $"\r\n\t WHERE NgayLap >= '{NgayBatDau}' AND NgayLap <= '{NgayKetThuc}'" +
                    $"\r\n\t GROUP BY YEAR(NgayLap)) AS B" +
                    $"\r\nON A.Nam = B.Nam" +
                    $"\r\nORDER BY 1";
            }
            return Instance.ExecuteQuery(query);
        }
    }
}
