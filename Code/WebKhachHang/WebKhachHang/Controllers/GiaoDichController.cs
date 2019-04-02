using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebKhachHang.Models;

namespace WebKhachHang.Controllers
{
    public class GiaoDichController : Controller
    {
        private readonly VinMartv1Context _context;

        public GiaoDichController(VinMartv1Context context)
        {
            _context = context;
        }

        // GET: GiaoDich
        public async Task<IActionResult> Index()
        {
            var vinMartv1Context = _context.TblGiaoDich.Include(t => t.MaKhNavigation).Include(t => t.MaNvNavigation);
            return View(await vinMartv1Context.ToListAsync());
        }

        // GET: GiaoDich/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Spgd = from a in _context.TblSanPhamGiaoDich
                       where a.MaGd == id
                       select new
                       {
                           TenSP = a.MaSpNavigation.TenSp,
                           SL = a.SoLuong,
                           TT = a.TongTien,
                           Mota = a.MaSpNavigation.MoTa,
                           Loai = a.MaSpNavigation.MaLhNavigation.TenLoai,
                           ncc = a.MaSpNavigation.MaNccNavigation.TenNcc
                       };
            var sp = _context.TblSanPhamGiaoDich.ToList();
            return View(sp);
        }

   

        private bool TblGiaoDichExists(int id)
        {
            return _context.TblGiaoDich.Any(e => e.MaGd == id);
        }
    }
}
