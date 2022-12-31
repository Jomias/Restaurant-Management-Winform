using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhapDTO
    {
        private string maPN;
        private DateTime ngayLap;
        private decimal tongTien;
        private string maNCC;
        private string userName;
        public string MaPN { get => maPN; set => maPN = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public decimal TongTien { get => tongTien; set => tongTien = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string UserName { get => userName; set => userName = value; }
        public PhieuNhapDTO(string maPN, string maNCC, decimal tongTien, string userName, DateTime ngayLap)
        {
            MaPN = maPN;
            NgayLap = ngayLap;
            TongTien = tongTien;
            MaNCC = maNCC;
            UserName = userName;
        }
        public PhieuNhapDTO(DataRow row)
        {
            MaPN = row["MaPN"].ToString();
            NgayLap = DateTime.Parse(row["NgayLap"].ToString());
            TongTien = decimal.Parse(row["TongTien"].ToString());
            MaNCC = row["MaNCC"].ToString();
            UserName = row["UserName"].ToString();
        }
    }
}
