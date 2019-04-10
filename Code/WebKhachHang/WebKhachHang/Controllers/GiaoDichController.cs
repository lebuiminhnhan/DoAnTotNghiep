using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebKhachHang.Models;

namespace WebKhachHang.Controllers
{
    public class GiaoDichController : Controller
    {
        private readonly VinMartv1Context _context;
        const string SessionID = "_ID";
        const string SessionName = "_Name";
        public GiaoDichController(VinMartv1Context context)
        {
            _context = context;
        }

        // GET: GiaoDich
        public async Task<IActionResult> Index()
        {
            int? checkid = HttpContext.Session.GetInt32(SessionID);
            string checkName = HttpContext.Session.GetString(SessionName);
            ViewBag.Name = checkName;
            var vinMartv1Context = _context.TblGiaoDich.Where(x=>x.MaKh==checkid).Include(t => t.MaKhNavigation).Include(t => t.MaNvNavigation);
            return View(await vinMartv1Context.ToListAsync());
        }

        // GET: GiaoDich/Details/5
        public IActionResult Details(int? id)
        {
            string checkName = HttpContext.Session.GetString(SessionName);
            ViewBag.Name = checkName;
            if (id == null)
            {
                return NotFound();
            }

            var Spgd = (from a in _context.TblSanPhamGiaoDich
                       join s in _context.TblSanPham on a.MaSp equals s.MaSp
                       where a.MaGd == id
                       select new ListSP
                       {
                           TenSP = s.TenSp,
                           SL = a.SoLuong,
                           TT = a.TongTien,
                           Gia = a.MaSpNavigation.DonGia,
                           Mota = s.MoTa,
                           Loai = s.MaLhNavigation.TenLoai,
                           ncc = s.MaNccNavigation.TenNcc
                       }).ToList();
            var sp = _context.TblSanPhamGiaoDich.ToList();
            return View(Spgd);
        }

   

        private bool TblGiaoDichExists(int id)
        {
            return _context.TblGiaoDich.Any(e => e.MaGd == id);
        }
    }

    public class ListSP
    {
        public string TenSP { get; set; }
        public int? SL { get; set; }
        public int? TT { get; set; }
        public int? Gia { get; set; }
        public string Mota { get; set; }
        public string Loai { get; set; }
        public string ncc { get; set; }
    }
}
