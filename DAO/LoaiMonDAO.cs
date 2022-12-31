using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LoaiMonDAO
    {
        private DataProvider Instance;
        public LoaiMonDAO()
        {
            Instance = new DataProvider();
        }
        public DataTable GetListLoaiMon()
        {
            return Instance.ExecuteQuery("SELECT * FROM LOAIMON");
        }
    }
}
