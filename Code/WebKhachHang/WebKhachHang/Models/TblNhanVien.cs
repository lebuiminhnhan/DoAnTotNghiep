using System;
using System.Collections.Generic;

namespace WebKhachHang.Models
{
    public partial class TblNhanVien
    {
        public TblNhanVien()
        {
            TblGiaoDich = new HashSet<TblGiaoDich>();
        }

        public int MaNv { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string NamSinh { get; set; }
        public string Email { get; set; }
        public string Sdt { get; set; }
        public string DiaChi { get; set; }
        public int? MaTk { get; set; }

        public TblTaiKhoan MaTkNavigation { get; set; }
        public ICollection<TblGiaoDich> TblGiaoDich { get; set; }
    }
}
