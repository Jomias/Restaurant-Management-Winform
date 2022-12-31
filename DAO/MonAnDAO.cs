using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MonAnDAO
    {
        private DataProvider Instance;
        public MonAnDAO()
        {
            Instance = new DataProvider();
        }
        public DataTable GetListMonAn(string tenMonAn = "")
        {
            return Instance.ExecuteQuery($"SELECT * FROM MONAN WHERE TenMonAn LIKE N'%{tenMonAn}%'");
        }
        public DataTable GetMonAnByMa(string maMA = "")
        {
            return Instance.ExecuteQuery($"SELECT * FROM MONAN WHERE MaMA = N'{maMA}'");
        }
        public DataTable GetListMonAnByLoai(string maLM)
        {
            return Instance.ExecuteQuery($"SELECT * FROM MONAN WHERE MaLM = N'{maLM}'");
        }
        public DataTable GetListMonAnCoCongThuc(string maLM)
        {
            return Instance.ExecuteQuery($"SELECT * FROM MONAN WHERE MaLM = N'{maLM}' AND MaMA IN (SELECT MaMA FROM CONGTHUC)");
        }
        public bool InsertMonAn(string maMA, string tenMonAn, decimal donGia, string maLM)
        {
            try
            {
                Instance.ExecuteNonQuery($"INSERT MONAN (MaMA, TenMonAn, DonGia, MaLM) " +
                $"VALUES (N'{maMA}', N'{tenMonAn}', {donGia}, N'{maLM}')");
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool UpdateMonAn(string maMA, string tenMonAn, decimal donGia, string maLM)
        {
            try
            {
                Instance.ExecuteNonQuery($"UPDATE MONAN SET TenMonAn = N'{tenMonAn}', DonGia = {donGia}," +
                $" MaLM = N'{maLM}' WHERE MaMA = N'{maMA}'");
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool DeleteMonAn(string maMA)
        {
            try
            {
                Instance.ExecuteNonQuery($"DELETE MONAN WHERE MaMA = N'{maMA}'");
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
