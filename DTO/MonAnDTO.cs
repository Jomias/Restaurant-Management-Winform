using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonAnDTO
    {
        private string maMA;
        private string tenMonAn;
        private decimal donGia;
        private string maLM;
        public string MaMA { get => maMA; set => maMA = value; }
        public string TenMonAn { get => tenMonAn; set => tenMonAn = value; }
        public decimal DonGia { get => donGia; set => donGia = value; }
        public string MaLM { get => maLM; set => maLM = value; }
        public MonAnDTO(string maMA, string tenMonAn, decimal donGia, string maLM)
        {
            MaMA = maMA;
            TenMonAn = tenMonAn;
            DonGia = donGia;
            MaLM = maLM;
        }
        public MonAnDTO(DataRow row)
        {
            MaMA = row["MaMA"].ToString();
            TenMonAn = row["TenMonAn"].ToString();
            DonGia = (decimal)row["DonGia"];
            MaLM = row["MaLM"].ToString();
        }

    }
}
