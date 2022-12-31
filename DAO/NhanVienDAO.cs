using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhanVienDAO
    {
        private DataProvider Instance;
        public NhanVienDAO()
        {
            Instance = new DataProvider();
        }
        public DataTable GetListNhanVien(string tenNV = "")
        {
            return Instance.ExecuteQuery($"SELECT * FROM NHANVIEN WHERE TenNV LIKE N'%{tenNV}%'");
        }

        public bool InsertNhanVien(string maNV, string tenNV, string diaChi, string gioiTinh, string sDT, string chucVu)
        {
            try
            {
                Instance.ExecuteNonQuery($"INSERT NHANVIEN (MaNV, TenNV, DiaChi, GioiTinh, SDT, ChucVu) " +
                $"VALUES (N'{maNV}', N'{tenNV}', N'{diaChi}', N'{gioiTinh}', N'{sDT}', N'{chucVu}')");
            }
            catch
            {
                return false;
            }
            return true;
        } 
        public bool UpdateNhanVien(string maNV, string tenNV, string diaChi, string gioiTinh, string sDT, string chucVu)
        {
            try
            {
                Instance.ExecuteNonQuery($"UPDATE NHANVIEN SET TenNV = N'{tenNV}', DiaChi = N'{diaChi}', GioiTinh = N'{gioiTinh}'," +
                $" SDT = N'{sDT}', ChucVu = N'{chucVu}' WHERE MaNV = N'{maNV}'");
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool DeleteNhanVien(string maNV)
        {
            return Instance.ExecuteNonQuery($"DELETE NHANVIEN WHERE MaNV = N'{maNV}'") > 0;
        }
    }
}
