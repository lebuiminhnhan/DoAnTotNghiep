//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLiKhachHang.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblSanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSanPham()
        {
            this.tblSanPhamGiaoDich = new HashSet<tblSanPhamGiaoDich>();
        }
    
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public Nullable<int> MucGiamGia { get; set; }
        public Nullable<int> DonGia { get; set; }
        public Nullable<int> MaNCC { get; set; }
        public Nullable<int> MaLH { get; set; }
        public string MoTa { get; set; }
    
        public virtual tblLoaiSanPham tblLoaiSanPham { get; set; }
        public virtual tblNhaCungCap tblNhaCungCap { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSanPhamGiaoDich> tblSanPhamGiaoDich { get; set; }
    }
}
