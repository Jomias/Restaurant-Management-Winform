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
    public class BanAnBUS
    {
        private BanAnDAO banAnDAO;
        public static int banAnWidth = 80;
        public static int banAnHeight = 80;
        public BanAnBUS()
        {
            banAnDAO = new BanAnDAO();
        }
        
        public List<BanAnDTO> GetListBanAn()
        {
            DataTable data = banAnDAO.GetListBanAn();
            List <BanAnDTO> list = new List<BanAnDTO>();
            foreach (DataRow item in data.Rows)
            {
                BanAnDTO banAnDTO = new BanAnDTO(item);
                list.Add(banAnDTO);
            }
            return list;
        }
        public bool InsertBanAn(string maBan, string tenBan, string tinhTrang)
        {
            return banAnDAO.InsertBanAn(maBan, tenBan, tinhTrang);
        }
        public bool UpdateBanAn(string maBan, string tenBan, string tinhTrang)
        {
            return banAnDAO.UpdateBanAn(maBan, tenBan, tinhTrang);
        }
        public bool DeleteBanAn(string maBan)
        {
            return banAnDAO.DeleteBanAn(maBan);
        }
        public bool UpdateTinhTrangBan(string MaBan, string TrangThai)
        {
            return banAnDAO.UpdateTrangThai(MaBan, TrangThai);
        }
    }
}
