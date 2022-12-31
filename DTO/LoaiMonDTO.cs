using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiMonDTO
    {
        private string maLM;
        private string tenLM;
        public string MaLM { get => maLM; set => maLM = value; }
        public string TenLM { get => tenLM; set => tenLM = value; }
        public LoaiMonDTO(string maLM, string tenLM)
        {
            MaLM = maLM;
            TenLM = tenLM;
        }
        public LoaiMonDTO(DataRow row)
        {
            MaLM = row["MaLM"].ToString();
            TenLM = row["TenLM"].ToString();
        }
    }
}
