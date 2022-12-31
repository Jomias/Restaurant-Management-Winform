using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguyenLieuDTO
    {
        private string maNL;
        private string tenNL;
        private string dVT;
        private int soLuong;
        private string maLNL;
        public string MaNL { get => maNL; set => maNL = value; }
        public string TenNL { get => tenNL; set => tenNL = value; }
        public string DVT { get => dVT; set => dVT = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string MaLNL { get => maLNL; set => maLNL = value; }
        public NguyenLieuDTO(string maNL, string tenNL, string dVT, int soLuong, string maLNL)
        {
            MaNL = maNL;
            TenNL = tenNL;
            DVT = dVT;
            SoLuong = soLuong;
            MaLNL = maLNL;
        }
        public NguyenLieuDTO(DataRow row)
        {
            MaNL = row["MaNL"].ToString();
            TenNL = row["TenNL"].ToString();
            DVT = row["DVT"].ToString();
            SoLuong = int.Parse(row["SoLuong"].ToString());
            MaLNL = row["MaLNL"].ToString();
        }
    }
}
