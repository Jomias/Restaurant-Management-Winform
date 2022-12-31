using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CongThucDTO
    {
        private string maMA;
        private string maNL;
        private int soLuong;
        public string MaMA { get => maMA; set => maMA = value; }
        public string MaNL { get => maNL; set => maNL = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public CongThucDTO(string maMA, string maNL, int soLuong)
        {
            this.MaMA = maMA;
            this.MaNL = maNL;
            this.SoLuong = soLuong;
        }
        public CongThucDTO(DataRow row)
        {
            this.MaMA = row["MaMA"].ToString();
            this.MaNL = row["MaNL"].ToString();
            this.SoLuong = (int)row["SoLuong"];
        }
    }
}
