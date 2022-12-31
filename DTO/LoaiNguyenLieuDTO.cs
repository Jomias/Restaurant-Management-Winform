using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiNguyenLieuDTO
    {
        private string maLNL;
        private string tenLNL;
        public string MaLNL { get => maLNL; set => maLNL = value; }
        public string TenLNL { get => tenLNL; set => tenLNL = value; }
        public LoaiNguyenLieuDTO(string maLNL, string tenLNL)
        {
            MaLNL = maLNL;
            TenLNL = tenLNL;
        }
        public LoaiNguyenLieuDTO(DataRow row)
        {
            MaLNL = row["MaLNL"].ToString();
            TenLNL = row["TenLNL"].ToString();
        }
    }
}
