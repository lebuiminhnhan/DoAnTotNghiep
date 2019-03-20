using System;
using System.Collections.Generic;

namespace WebKhachHang.Models
{
    public partial class TblTaiKhoan
    {
        public TblTaiKhoan()
        {
            TblKhachHang = new HashSet<TblKhachHang>();
            TblNhanVien = new HashSet<TblNhanVien>();
        }

        public int MaTk { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public int MaQuyen { get; set; }

        public TblQuyen MaQuyenNavigation { get; set; }
        public ICollection<TblKhachHang> TblKhachHang { get; set; }
        public ICollection<TblNhanVien> TblNhanVien { get; set; }
    }
}
