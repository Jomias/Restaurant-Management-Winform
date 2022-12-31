using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCapDTO
    {
        private string maNCC;
        private string tenNCC;
        private string diaChi;
        private string sDT;
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public NhaCungCapDTO(string maNCC, string tenNCC, string diaChi, string sDT)
        {
            MaNCC = maNCC;
            TenNCC = tenNCC;
            DiaChi = diaChi;
            SDT = sDT;
        }
        public NhaCungCapDTO(DataRow row)
        {
            MaNCC = row["MaNCC"].ToString();
            TenNCC = row["TenNCC"].ToString();
            DiaChi = row["DiaChi"].ToString();
            SDT = row["SDT"].ToString();
        }
    }
}
