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
    public class PhieuNhapBUS
    {
        PhieuNhapDAO phieuNhapDAO = new PhieuNhapDAO();
        public List<string> GetListMa()
        {
            List<string> list = new List<string>();
            DataTable data = phieuNhapDAO.GetListPhieuNhap();
            foreach (DataRow item in data.Rows)
            {
                PhieuNhapDTO a = new PhieuNhapDTO(item);
                list.Add(a.MaPN);
            }
            return list;
        }

        public PhieuNhapDTO GetPhieuNhapByMa(string maNCC)
        {
            DataTable data = phieuNhapDAO.GetPhieuNhapByID(maNCC);
            foreach (DataRow item in data.Rows)
            {
                return new PhieuNhapDTO(item);
            }
            return null;
        }
        public bool DeletePhieuNhap(string maPN)
        {
            return phieuNhapDAO.DeletePhieuNhap(maPN);
        }
        public string GetDistinctID()
        {
            return GenerateID.GetID("PN");
        }

        public bool InsertPhieuNhap(string maPN, DateTime ngayLap, decimal tongTien, string maNCC, string userName)
        {
            return phieuNhapDAO.InsertPhieuNhap(maPN, ngayLap, tongTien, maNCC, userName);
        }
    }
}
