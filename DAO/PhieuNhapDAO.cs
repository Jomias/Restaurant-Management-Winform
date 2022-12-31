using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhieuNhapDAO
    {
        private DataProvider Instance;
        public PhieuNhapDAO()
        {
            Instance = new DataProvider();
        }
        
        public DataTable GetListPhieuNhap()
        {
            return Instance.ExecuteQuery("SELECT * FROM PHIEUNHAP");
        }
        public DataTable GetPhieuNhapByID(string maPN = "")
        {
            return Instance.ExecuteQuery($"SELECT * FROM PHIEUNHAP WHERE MaPN=N'{maPN}'");
        }


        public bool DeletePhieuNhap(string maPN)
        {
            return Instance.ExecuteNonQuery($"DELETE PHIEUNHAP WHERE MaPN = N'{maPN}'") > 0;
        }

        public bool InsertPhieuNhap(string maPN, DateTime ngayLap, decimal tongTien, string maNCC, string userName)
        {
            try
            {
                Instance.ExecuteNonQuery($"INSERT PHIEUNHAP (maPN, ngayLap, tongTien, maNCC, userName) " +
                $"VALUES (N'{maPN}', GETDATE(), {tongTien}, N'{maNCC}', N'{userName}')");
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
