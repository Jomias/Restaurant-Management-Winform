using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhaCungCapDAO
    {
        private DataProvider Instance;
        public NhaCungCapDAO()
        {
            Instance = new DataProvider();
        }
        public DataTable GetListNhaCungCap()
        {
            return Instance.ExecuteQuery("SELECT * FROM NHACUNGCAP");
        }

        public DataTable GetListNhaCungCapByID(string maNCC)
        {
            return Instance.ExecuteQuery($"SELECT * FROM NHACUNGCAP WHERE MaNCC = N'{maNCC}'");
        }
    }
}
