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
    public class LoaiMonBUS
    {
        private LoaiMonDAO loaiMonDAO;
        public LoaiMonBUS()
        {
            loaiMonDAO = new LoaiMonDAO();
        }
        public List<LoaiMonDTO> GetListLoaiMon()
        {
            List<LoaiMonDTO> list = new List<LoaiMonDTO>();
            DataTable data = loaiMonDAO.GetListLoaiMon();
            foreach (DataRow item in data.Rows)
            {
                list.Add(new LoaiMonDTO(item));
            }
            return list;
        }
    }
}
