using System;
using System.Collections.Generic;

namespace WebKhachHang.Models
{
    public partial class TblSanPham
    {
        public TblSanPham()
        {
            TblSanPhamGiaoDich = new HashSet<TblSanPhamGiaoDich>();
        }

        public int MaSp { get; set; }
        public string TenSp { get; set; }
        public int? MucGiamGia { get; set; }
        public int? DonGia { get; set; }
        public int? MaNcc { get; set; }
        public int? MaLh { get; set; }
        public string MoTa { get; set; }

        public TblLoaiSanPham MaLhNavigation { get; set; }
        public TblNhaCungCap MaNccNavigation { get; set; }
        public ICollection<TblSanPhamGiaoDich> TblSanPhamGiaoDich { get; set; }
    }
}
