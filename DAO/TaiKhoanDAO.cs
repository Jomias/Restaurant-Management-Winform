using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TaiKhoanDAO
    {
        private DataProvider Instance;
        public TaiKhoanDAO()
        {
             Instance = new DataProvider();
        }
        public DataTable CheckLogin(string userName, string passWord)
        {
            return Instance.ExecuteQuery($"SELECT * FROM TAIKHOAN WHERE UserName = N'{userName}' AND PassWord = N'{passWord}'");
        }
        public DataTable GetAccountByUserName(string userName)
        {
            DataTable data = Instance.ExecuteQuery($"SELECT * FROM TAIKHOAN WHERE UserName = N'{userName}'");
            if (data.Rows.Count <= 0)
            {
                return null;
            }
            return data;
        }
        public DataTable GetListTK()
        {
            return Instance.ExecuteQuery($"SELECT * FROM TAIKHOAN");
        }
        public bool InsertTK(string userName, string passWord, string displayName, int phanQuyen)
        {
            try
            {
                Instance.ExecuteNonQuery($"INSERT TAIKHOAN (UserName, PassWord, DisplayName, PhanQuyen)" +
                $"VALUES (N'{userName}', N'{passWord}', N'{displayName}', {phanQuyen})");
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool UpdateTK(string userName, string passWord, string displayName, int phanQuyen)
        {
            try
            {
                Instance.ExecuteNonQuery($"UPDATE TAIKHOAN SET PassWord = N'{passWord}', DisplayName = N'{displayName}'," +
                $" PhanQuyen = {phanQuyen} WHERE UserName = N'{userName}'");
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool DeleteTK(string userName)
        {
            try
            {
                Instance.ExecuteNonQuery($"DELETE TAIKHOAN WHERE UserName = N'{userName}'");
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
