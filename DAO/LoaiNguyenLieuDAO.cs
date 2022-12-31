using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LoaiNguyenLieuDAO
    {
        private DataProvider Instance;
        public LoaiNguyenLieuDAO()
        {
            Instance = new DataProvider();
        }
        public DataTable GetListLoaiNguyenLieu()
        {
            return Instance.ExecuteQuery("SELECT * FROM LOAINGUYENLIEU");
        }
    }
}
