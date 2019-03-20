using System;
using System.Collections.Generic;

namespace WebKhachHang.Models
{
    public partial class TblQuyen
    {
        public TblQuyen()
        {
            TblTaiKhoan = new HashSet<TblTaiKhoan>();
        }

        public int MaQuyen { get; set; }
        public string TenQuyen { get; set; }

        public ICollection<TblTaiKhoan> TblTaiKhoan { get; set; }
    }
}
