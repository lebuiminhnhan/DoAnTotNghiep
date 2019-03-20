using System;
using System.Collections.Generic;

namespace WebKhachHang.Models
{
    public partial class TblLoaiSanPham
    {
        public TblLoaiSanPham()
        {
            TblSanPham = new HashSet<TblSanPham>();
        }

        public int MaLoai { get; set; }
        public string TenLoai { get; set; }

        public ICollection<TblSanPham> TblSanPham { get; set; }
    }
}
