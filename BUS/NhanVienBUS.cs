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
    public class NhanVienBUS
    {
        private NhanVienDAO nhanVienDAO;
        public NhanVienBUS() 
        {
            nhanVienDAO = new NhanVienDAO();
        }
        public List<NhanVienDTO> GetListNhanVien(string tenNV = "")
        {
            List<NhanVienDTO> list = new List<NhanVienDTO>();
            DataTable data = nhanVienDAO.GetListNhanVien(tenNV);
            foreach (DataRow item in data.Rows)
            {
                list.Add(new NhanVienDTO(item));
            }
            
            return list;
        }
        public bool InsertNhanVien(string maNV, string tenNV, string diaChi, string gioiTinh, string sDT, string chucVu)
        {
            return nhanVienDAO.InsertNhanVien(maNV, tenNV, diaChi, gioiTinh, sDT, chucVu);
        }
        public bool UpdateNhanVien(string maNV, string tenNV, string diaChi, string gioiTinh, string sDT, string chucVu)
        {
            return nhanVienDAO.UpdateNhanVien(maNV, tenNV, diaChi, gioiTinh, sDT, chucVu);
        }
        public bool DeleteNhanVien(string maNV)
        {
            return nhanVienDAO.DeleteNhanVien(maNV);
        }
        public string GetDistinctID()
        {
            return GenerateID.GetID("NV");
        }
    }
}
