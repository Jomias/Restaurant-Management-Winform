using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BanAnDAO
    {
        private DataProvider Instance;
        public BanAnDAO()
        {
            Instance = new DataProvider();
        }
        public DataTable GetListBanAn()
        {
            return Instance.ExecuteQuery($"SELECT * FROM BANAN");
        }

        public bool InsertBanAn(string maBan, string tenBan, string tinhTrang)
        {
            try
            {
                Instance.ExecuteNonQuery($"INSERT BANAN (MaBan, TenBan, TinhTrang) " +
                $"VALUES (N'{maBan}', N'{tenBan}',  N'{tinhTrang}')");
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool UpdateBanAn(string maBan, string tenBan, string tinhTrang)
        {
            try
            {
                Instance.ExecuteNonQuery($"UPDATE BANAN SET TenBan = N'{tenBan}'," +
                $" TinhTrang = {tinhTrang} WHERE MaBan = N'{maBan}'");
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool DeleteBanAn(string maBan)
        {
            try
            {
                Instance.ExecuteNonQuery($"DELETE BANAN WHERE MaBan = N'{maBan}'");
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool UpdateTrangThai(string maBan, string TrangThai) 
        {
            return Instance.ExecuteNonQuery($"UPDATE BANAN SET TinhTrang = N'{TrangThai}' WHERE MaBan = N'{maBan}'") > 0;
        }
    }
}
