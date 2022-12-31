using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        private string maNV;
        private string tenNV;
        private string diaChi;
        private string gioiTinh;
        private string sDT;
        private string chucVu;
        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public NhanVienDTO(string maNV, string tenNV, string diaChi, string gioiTinh, string sDT, string chucVu)
        {
            MaNV = maNV;
            TenNV = tenNV;
            DiaChi = diaChi;
            GioiTinh = gioiTinh;
            SDT = sDT;
            ChucVu = chucVu;
        }
        public NhanVienDTO(DataRow row)
        {
            MaNV = row["MaNV"].ToString();
            TenNV = row["TenNV"].ToString();
            DiaChi = row["DiaChi"].ToString();
            GioiTinh = row["GioiTinh"].ToString();
            SDT = row["SDT"].ToString();
            ChucVu = row["CHUCVU"].ToString();
        }
    }
}
