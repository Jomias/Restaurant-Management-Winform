using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BanAnDTO
    {
        private string maBan;
        private string tenBan;
        private string tinhTrang;
        public string MaBan { get => maBan; set => maBan = value; }
        public string TenBan { get => tenBan; set => tenBan = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public BanAnDTO(string maBan, string tenBan, string tinhTrang)
        {
            this.MaBan = maBan;
            this.TenBan = tenBan;
            this.TinhTrang = tinhTrang;
        }
        public BanAnDTO(DataRow row)
        {
            this.MaBan = row["MaBan"].ToString();
            this.TenBan = row["TenBan"].ToString();
            this.TinhTrang = row["TinhTrang"].ToString();
        }
    }
}
