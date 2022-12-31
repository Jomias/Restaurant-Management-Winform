using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        private string maHD;
        private DateTime dateCheckIn;
        private DateTime? dateCheckOut;
        private int tinhTrang;
        private decimal? tongTien;
        private string userName;
        private string maBan;
        public string MaHD { get => maHD; set => maHD = value; }
        public DateTime DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public decimal? TongTien { get => tongTien; set => tongTien = value; }
        public string UserName { get => userName; set => userName = value; }
        public string MaBan { get => maBan; set => maBan = value; }
        public HoaDonDTO(DataRow row)
        {
            MaHD = row["MaHD"].ToString();
            DateCheckIn = (DateTime)row["DateCheckIn"];
            DateCheckOut = null;
            TinhTrang = (int)row["TinhTrang"];
            TongTien = (decimal)row["TongTien"];
            UserName = row["UserName"].ToString();
            MaBan = row["MaBan"].ToString();
        }
        public HoaDonDTO(string maHD, DateTime dateCheckIn, DateTime? dateCheckOut, int tinhTrang, decimal tongTien, string userName, string maBan)
        {
            MaHD = maHD;
            DateCheckIn = dateCheckIn;
            DateCheckOut = dateCheckOut;
            TinhTrang = tinhTrang;
            TongTien = tongTien;
            UserName = userName;
            MaBan = maBan;
        }
    }
}
