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
    public class NguyenLieuBUS
    {
        private NguyenLieuDAO nguyenLieuDAO;
        public NguyenLieuBUS()
        {
            nguyenLieuDAO = new NguyenLieuDAO();
        }
        public List<NguyenLieuDTO> GetListNguyenLieu(string tenMA = "")
        {
            List<NguyenLieuDTO> list = new List<NguyenLieuDTO>();
            DataTable data = nguyenLieuDAO.GetListNguyenLieu(tenMA);
            foreach (DataRow item in data.Rows)
            {
                list.Add(new NguyenLieuDTO(item));
            }
            return list;
        }
        public List<NguyenLieuDTO> GetListNguyenLieuByLoaiMon(string maLM = "")
        {
            List<NguyenLieuDTO> list = new List<NguyenLieuDTO>();
            DataTable data = nguyenLieuDAO.GetListNguyenLieuByLoai(maLM);
            foreach (DataRow item in data.Rows)
            {
                list.Add(new NguyenLieuDTO(item));
            }
            return list;
        }
        public bool InsertNguyenLieu(string maNL, string tenNL, string dVT, int soLuong, string maLNL)
        {
            return nguyenLieuDAO.InsertNguyenLieu(maNL, tenNL, dVT,  soLuong, maLNL);
        }
        public bool UpdateNguyenLieu(string maNL, string tenNL, string dVT, int soLuong, string maLNL)
        {
            return nguyenLieuDAO.UpdateNguyenLieu(maNL, tenNL, dVT, soLuong, maLNL);
        }
        public bool DeleteNguyenLieu(string maNL)
        {
            return nguyenLieuDAO.DeleteNguyenLieu(maNL);
        }
        public string GetDistinctID()
        {
            return GenerateID.GetID("NL");
        }
        public List<string> GetListMa()
        {
            List<string> list = new List<string>();
            DataTable data = nguyenLieuDAO.GetListNguyenLieu();
            foreach (DataRow item in data.Rows)
            {
                NguyenLieuDTO a = new NguyenLieuDTO(item);
                list.Add(a.MaNL);
            }
            return list;
        }
        public NguyenLieuDTO GetNguyenLieuByMa(string maNCC)
        {
            DataTable data = nguyenLieuDAO.GetNLByMa(maNCC);
            foreach (DataRow item in data.Rows)
            {
                return new NguyenLieuDTO(item);
            }
            return null;
        }
    }
}
