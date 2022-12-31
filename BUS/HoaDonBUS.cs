using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDonBUS
    {
        HoaDonDAO hoaDonDAO;
        public HoaDonBUS()
        {
            hoaDonDAO = new HoaDonDAO();
        }
        public string GetMaHoaDonByBanAn(string maBan)
        {
            DataTable data = hoaDonDAO.GetHoaDonChuaThanhToanByMaBan(maBan);
            if (data.Rows.Count > 0)
            {
                HoaDonDTO hoaDonDTO = new HoaDonDTO(data.Rows[0]);
                return hoaDonDTO.MaHD;
            }
            return "";
        }
        public bool InsertHoaDon(string maHD, DateTime dateCheckIn, DateTime? dateCheckOut, int tinhTrang, decimal tongTien, string userName, string maBan) 
        {
            return hoaDonDAO.InsertHoaDon(maHD, dateCheckIn, dateCheckOut, tinhTrang, tongTien, userName, maBan);
        }
        public string GetDistinctID()
        {
            return GenerateID.GetID("HDB");
        }
        public bool DeleteHoaDon(string maHD) 
        {
            return hoaDonDAO.DeleteHoaDon(maHD);
        }

        public bool CheckOut(string maHD)
        {
            return hoaDonDAO.CheckOut(maHD);
        }
        public decimal GetTongTienByMa(string maHD)
        {
            DataTable data = hoaDonDAO.GetHoaDonByMa(maHD);
            if (data.Rows.Count > 0)
            {
                HoaDonDTO hoaDonDTO = new HoaDonDTO(data.Rows[0]);
                return (decimal)hoaDonDTO.TongTien;
            }
            return 0;
        }
        public HoaDonDTO GetHoaDonByMa(string maHD)
        {
            DataTable data = hoaDonDAO.GetHoaDonByMa(maHD);
            if (data.Rows.Count > 0)
            {
                return new HoaDonDTO(data.Rows[0]);
            }
            return null;
        }
    }
}
