using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietDatMonDTO
    {
        private string maHD;
        private string maMA;
        private decimal? donGia;
        private int soLuong;
        private decimal? thanhTien;
        public string MaHD { get => maHD; set => maHD = value; }
        public string MaMA { get => maMA; set => maMA = value; }
        public decimal? DonGia { get => donGia; set => donGia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public decimal? ThanhTien { get => thanhTien; set => thanhTien = value; }
        public ChiTietDatMonDTO(string maHD, string maMA, decimal donGia, int soLuong, decimal thanhTien)
        {
            this.MaHD = maHD;
            this.MaMA = maMA;
            this.DonGia = donGia;
            this.SoLuong = soLuong;
            this.ThanhTien = thanhTien;
        }

        public ChiTietDatMonDTO(DataRow row)
        {
            this.MaHD = row["MaHD"].ToString();
            this.MaMA = row["MaMA"].ToString();
            this.DonGia = (decimal)row["DonGia"];
            this.SoLuong = (int)row["SoLuong"];
            this.ThanhTien = (decimal)row["ThanhTien"];
        }
    }
}
