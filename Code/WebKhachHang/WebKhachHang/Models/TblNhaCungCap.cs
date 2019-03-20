using System;
using System.Collections.Generic;

namespace WebKhachHang.Models
{
    public partial class TblNhaCungCap
    {
        public TblNhaCungCap()
        {
            TblSanPham = new HashSet<TblSanPham>();
        }

        public int MaNcc { get; set; }
        public string TenNcc { get; set; }
        public string Sdt { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }

        public ICollection<TblSanPham> TblSanPham { get; set; }
    }
}
