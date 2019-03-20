using System;
using System.Collections.Generic;

namespace WebKhachHang.Models
{
    public partial class TblGiaoDich
    {
        public TblGiaoDich()
        {
            TblCoUuDai = new HashSet<TblCoUuDai>();
            TblLichSuGiaoDich = new HashSet<TblLichSuGiaoDich>();
            TblSanPhamGiaoDich = new HashSet<TblSanPhamGiaoDich>();
        }

        public int MaGd { get; set; }
        public DateTime? NgayGiaoDich { get; set; }
        public int? TienThanhToan { get; set; }
        public int? DiemTich { get; set; }
        public int? TienGiam { get; set; }
        public int? DiemTru { get; set; }
        public int? TienThem { get; set; }
        public string TrangThai { get; set; }
        public int? MaNv { get; set; }
        public int? MaKh { get; set; }

        public TblKhachHang MaKhNavigation { get; set; }
        public TblNhanVien MaNvNavigation { get; set; }
        public ICollection<TblCoUuDai> TblCoUuDai { get; set; }
        public ICollection<TblLichSuGiaoDich> TblLichSuGiaoDich { get; set; }
        public ICollection<TblSanPhamGiaoDich> TblSanPhamGiaoDich { get; set; }
    }
}
