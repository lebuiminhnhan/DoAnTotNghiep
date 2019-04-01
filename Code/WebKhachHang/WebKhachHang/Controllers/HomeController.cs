using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebKhachHang.Models;

namespace WebKhachHang.Controllers
{
    public class HomeController : Controller
    {
        private readonly VinMartv1Context _context;

        public HomeController(VinMartv1Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Profile(int id)
        {
            var Chitiet = _context.TblKhachHang.Where(x => x.MaKh == 10000).FirstOrDefault();
            
            return View(Chitiet);
        }
        public IActionResult Contact()
        {

            return View();
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblKhachHang = await _context.TblKhachHang.FindAsync(id);
            if (tblKhachHang == null)
            {
                return NotFound();
            }
            ViewData["MaTk"] = new SelectList(_context.TblTaiKhoan, "MaTk", "MatKhau", tblKhachHang.MaTk);
            return View(tblKhachHang);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaKh,HoTen,NamSinh,GioiTinh,NgheNghiep,Cmnd,Sdt,Email,DiaChi")] TblKhachHang tblKhachHang)
        {
            if (id != tblKhachHang.MaKh)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //_context.Update(tblKhachHang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblKhachHangExists(tblKhachHang.MaKh))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Profile));
            }
            return View(tblKhachHang);
        }

        private bool TblKhachHangExists(int id)
        {
            return _context.TblKhachHang.Any(e => e.MaKh == id);
        }

        public IActionResult History()
        {

            return View();
        }

       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
