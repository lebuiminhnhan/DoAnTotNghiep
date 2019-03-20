using System;
using System.Collections.Generic;

namespace WebKhachHang.Models
{
    public partial class TblCoUuDai
    {
        public int MaUd { get; set; }
        public int MaKh { get; set; }
        public int MaGd { get; set; }

        public TblGiaoDich MaGdNavigation { get; set; }
        public TblKhachHang MaKhNavigation { get; set; }
        public TblUuDai MaUdNavigation { get; set; }
    }
}
