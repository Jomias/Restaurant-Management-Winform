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
    public class LoaiNguyenLieuBUS
    {
        private LoaiNguyenLieuDAO loaiNguyenLieuDAO;
        public LoaiNguyenLieuBUS()
        {
            loaiNguyenLieuDAO = new LoaiNguyenLieuDAO();
        }
        public List<LoaiNguyenLieuDTO> GetListLoaiNguyenLieu()
        {
            List<LoaiNguyenLieuDTO> list = new List<LoaiNguyenLieuDTO>();
            DataTable data = loaiNguyenLieuDAO.GetListLoaiNguyenLieu();
            foreach (DataRow item in data.Rows)
            {
                list.Add(new LoaiNguyenLieuDTO(item));
            }
            return list;
        }
    }
}
