using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuNhapDTO
    {
        private string maPN;
        private string maNL;
        private decimal donGia;
        private int soLuong;
        private decimal thanhTien;
        public string MaPN { get => maPN; set => maPN = value; }
        public string MaNL { get => maNL; set => maNL = value; }
        public decimal DonGia { get => donGia; set => donGia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public decimal ThanhTien { get => thanhTien; set => thanhTien = value; }
        public ChiTietPhieuNhapDTO(string maPN, string maNL, decimal donGia, int soLuong, decimal thanhTien)
        {
            this.MaPN = maPN;
            this.MaNL = maNL;
            this.DonGia = donGia;
            this.SoLuong = soLuong;
            this.ThanhTien = thanhTien;
        }
        public ChiTietPhieuNhapDTO(DataRow row)
        {
            this.MaPN = row["MaPN"].ToString();
            this.MaNL = row["MaNL"].ToString();
            this.DonGia = (decimal)row["DonGia"];
            this.SoLuong = (int)row["SoLuong"];
            this.ThanhTien = (decimal)row["ThanhTien"];
        }
    }
}
