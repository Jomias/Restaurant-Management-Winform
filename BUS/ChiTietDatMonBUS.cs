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
    public class ChiTietDatMonBUS
    {
        private ChiTietDatMonDAO chiTietDatMonDAO;
        public ChiTietDatMonBUS()
        {
            chiTietDatMonDAO = new ChiTietDatMonDAO();
        }
        public List<ChiTietDatMonDTO> GetListChiTietDatMon(string maHD = "")
        {
            List<ChiTietDatMonDTO> list = new List<ChiTietDatMonDTO>();
            DataTable data = chiTietDatMonDAO.GetListChiTietDatMon(maHD);
            foreach (DataRow item in data.Rows)
            {
                list.Add(new ChiTietDatMonDTO(item));
            }
            return list;
        }

        public DataTable GetTableChiTietDatMon (string maHD)
        {
            return chiTietDatMonDAO.GetListChiTietDatMon(maHD);
        }
        public bool InsertChiTietDatMon(string maHD, string maMA, decimal donGia, int soLuong, decimal thanhTien)
        {
            return chiTietDatMonDAO.InsertChiTietDatMon(maHD, maMA, donGia, soLuong, thanhTien);
        }
    }
}
