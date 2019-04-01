using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebKhachHang.ViewModel
{
    public  class KhachHang
    {
        public int MaKh { get; set; }
        public string HoTen { get; set; }
        public DateTime? NamSinh { get; set; }
        public string GioiTinh { get; set; }
        public string NgheNghiep { get; set; }
        public string Cmnd { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public DateTime? NgayThamGia { get; set; }
        public int? DiemTichLuy { get; set; }
        public int? DiemHienCo { get; set; }
        public string LoaiKhachHang { get; set; }
        public string TrangThai { get; set; }
        public int? MaTk { get; set; }
    }
}
