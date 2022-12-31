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
    public class NhaCungCapBUS
    {
        private NhaCungCapDAO nhaCungCapDAO;
        public NhaCungCapBUS()
        {
            nhaCungCapDAO = new NhaCungCapDAO();
        }
        public List<NhaCungCapDTO> GetListNhaCungCap()
        {
            List<NhaCungCapDTO> list = new List<NhaCungCapDTO>();
            DataTable data = nhaCungCapDAO.GetListNhaCungCap();
            foreach (DataRow item in data.Rows)
            {
                list.Add(new NhaCungCapDTO(item));
            }
            return list;
        }
        public List<string> GetListMa()
        {
            List<string> list = new List<string>();
            DataTable data = nhaCungCapDAO.GetListNhaCungCap();
            foreach (DataRow item in data.Rows)
            {
                NhaCungCapDTO a = new NhaCungCapDTO(item);
                list.Add(a.MaNCC);
            }
            return list;
        }

        public NhaCungCapDTO GetNhaCungCapByMa(string maNCC)
        {
            DataTable data = nhaCungCapDAO.GetListNhaCungCapByID(maNCC);
            foreach (DataRow item in data.Rows)
            {
                return new NhaCungCapDTO(item);
            }
            return null;
        }
    }
}
