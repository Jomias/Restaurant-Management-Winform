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
    public class ChiTietPhieuNhapBUS
    {
        private ChiTietPhieuNhapDAO chiTietPhieuNhapDAO;
        public ChiTietPhieuNhapBUS()
        {
            chiTietPhieuNhapDAO = new ChiTietPhieuNhapDAO();
        }
        public List<ChiTietPhieuNhapDTO> GetListChiTietPhieuNhap(string maPN)
        {
            List<ChiTietPhieuNhapDTO> list = new List<ChiTietPhieuNhapDTO>();
            DataTable data = chiTietPhieuNhapDAO.GetListChiTietPhieuNhap(maPN);
            foreach (DataRow item in data.Rows)
            {
                list.Add(new ChiTietPhieuNhapDTO(item));
            }
            return list;
        }

        public DataTable GetTableChiTietPhieuNhap(string maPN)
        {
            return chiTietPhieuNhapDAO.GetListChiTietPhieuNhap(maPN);
        }
        public bool InsertChiTietPhieuNhap(string maPN, string maNL, decimal donGia, int soLuong, decimal thanhTien)
        {
            return chiTietPhieuNhapDAO.InsertChiTietPhieuNhap(maPN, maNL, donGia, soLuong, thanhTien);
        }

        public bool DeleteChiTietPhieuNhap(string maPN, string maNL)
        {
            return chiTietPhieuNhapDAO.DeleteChiTietPhieuNhap(maPN, maNL);
        }
    }
}
