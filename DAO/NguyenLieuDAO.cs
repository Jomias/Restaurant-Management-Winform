using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NguyenLieuDAO
    {
        private DataProvider Instance;
        public NguyenLieuDAO()
        {
            Instance = new DataProvider();
        }
        public DataTable GetListNguyenLieu(string tenNguyenLieu = "")
        {
            return Instance.ExecuteQuery($"SELECT * FROM NGUYENLIEU WHERE TenNL LIKE N'%{tenNguyenLieu}%'");
        }
        public DataTable GetListNguyenLieuByLoai(string maLNL)
        {
            return Instance.ExecuteQuery($"SELECT * FROM NGUYENLIEU WHERE MaLNL = N'{maLNL}'");
        }

        public bool InsertNguyenLieu(string maNL, string tenNL, string dVT, int soLuong, string maLNL)
        {
            try
            {
                Instance.ExecuteNonQuery($"INSERT NGUYENLIEU (MaNL, TenNL, DVT, SoLuong, MaLNL) " +
                $"VALUES (N'{maNL}', N'{tenNL}',  N'{dVT}', {soLuong} ,N'{maLNL}')");
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool UpdateNguyenLieu(string maNL, string tenNL, string dVT, int soLuong, string maLNL)
        {
            try
            {
                Instance.ExecuteNonQuery($"UPDATE NGUYENLIEU SET TenNL = N'{tenNL}', DVT = N'{dVT}'," +
                $" SoLuong = {soLuong}, MaLNL = N'{maLNL}' WHERE MaNL = N'{maNL}'");
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool DeleteNguyenLieu(string maNL)
        {
            try
            {
                Instance.ExecuteNonQuery($"DELETE NGUYENLIEU WHERE MaNL = N'{maNL}'");
            }
            catch
            {
                return false;
            }
            return true;
        }
        public DataTable GetListMa()
        {
            return Instance.ExecuteQuery("SELECT MaNL FROM NGUYENLIEU");
        }
        public DataTable GetNLByMa(string maNL)
        {
            return Instance.ExecuteQuery($"SELECT * FROM NGUYENLIEU WHERE MaNL= N'{maNL}'");
        }
    }
}
