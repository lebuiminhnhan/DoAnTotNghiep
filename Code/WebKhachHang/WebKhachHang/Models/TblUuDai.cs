using System;
using System.Collections.Generic;

namespace WebKhachHang.Models
{
    public partial class TblUuDai
    {
        public TblUuDai()
        {
            TblCoUuDai = new HashSet<TblCoUuDai>();
        }

        public int MaUd { get; set; }
        public string TenUd { get; set; }
        public DateTime? ThoiGianBd { get; set; }
        public DateTime? ThoiGianKt { get; set; }
        public string MoTa { get; set; }

        public ICollection<TblCoUuDai> TblCoUuDai { get; set; }
    }
}
