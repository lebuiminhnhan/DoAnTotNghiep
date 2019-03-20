using System;
using System.Collections.Generic;

namespace WebKhachHang.Models
{
    public partial class TblLichSuGiaoDich
    {
        public int MaLsgd { get; set; }
        public int? TongTienGd { get; set; }
        public int? MaGd { get; set; }
        public int? MaKh { get; set; }

        public TblGiaoDich MaGdNavigation { get; set; }
        public TblKhachHang MaKhNavigation { get; set; }
    }
}
