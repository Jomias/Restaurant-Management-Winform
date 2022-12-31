using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        private string userName;
        private string displayName;
        private string passWord;
        private int phanQuyen;
        public string UserName { get => userName; set => userName = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public int PhanQuyen { get => phanQuyen; set => phanQuyen = value; }
        public TaiKhoanDTO(string userName, string passWord, string displayName, int phanQuyen)
        {
            UserName = userName;
            PassWord = passWord;
            DisplayName = displayName;
            PhanQuyen = phanQuyen;
        }
        public TaiKhoanDTO(DataRow row)
        {
            UserName = row["UserName"].ToString();
            PassWord = row["PassWord"].ToString();
            DisplayName = row["DisplayName"].ToString();
            PhanQuyen = (int)row["PhanQuyen"];
        }
    }
}
