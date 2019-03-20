using System;
using System.Collections.Generic;

namespace WebKhachHang.Models
{
    public partial class TblSanPhamGiaoDich
    {
        public int MaGd { get; set; }
        public int MaSp { get; set; }
        public int? SoLuong { get; set; }
        public int? TongTien { get; set; }

        public TblGiaoDich MaGdNavigation { get; set; }
        public TblSanPham MaSpNavigation { get; set; }
    }
}
