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
    public class MonAnBUS
    {
        private MonAnDAO monAnDAO;
        public MonAnBUS()
        {
            monAnDAO = new MonAnDAO();
        }
        public string GetMonAnByMa(string maMA)
        {
            DataTable data = monAnDAO.GetMonAnByMa(maMA);
            if (data.Rows.Count > 0)
            {
                MonAnDTO monAnDTO = new MonAnDTO(data.Rows[0]);
                return monAnDTO.TenMonAn;
            }
            return "";
        }
        public List<MonAnDTO> GetListMonAn(string tenMA = "")
        {
            List<MonAnDTO> list = new List<MonAnDTO>();
            DataTable data = monAnDAO.GetListMonAn(tenMA);
            foreach (DataRow item in data.Rows)
            {
                list.Add(new MonAnDTO(item));
            }
            return list;
        }
        public List<MonAnDTO> GetListMonAnByLoaiMon(string maLM = "")
        {
            List<MonAnDTO> list = new List<MonAnDTO>();
            DataTable data = monAnDAO.GetListMonAnByLoai(maLM);
            foreach (DataRow item in data.Rows)
            {
                list.Add(new MonAnDTO(item));
            }
            return list;
        }
        public List<MonAnDTO> GetListMonAnCoCongThuc(string maLM = "")
        {
            List<MonAnDTO> list = new List<MonAnDTO>();
            DataTable data = monAnDAO.GetListMonAnCoCongThuc(maLM);
            foreach (DataRow item in data.Rows)
            {
                list.Add(new MonAnDTO(item));
            }
            return list;
        }
        public bool InsertMonAn(string maMA, string tenMonAn, decimal donGia, string maLM)
        {
            return monAnDAO.InsertMonAn(maMA, tenMonAn, donGia, maLM);
        }
        public bool UpdateMonAn(string maMA, string tenMonAn, decimal donGia, string maLM)
        {
            return monAnDAO.UpdateMonAn(maMA, tenMonAn, donGia, maLM);
        }
        public bool DeleteMonAn(string maMA)
        {
            return monAnDAO.DeleteMonAn(maMA);
        }
        public string GetDistinctID()
        {
            return GenerateID.GetID("MA");
        }
    }
}
