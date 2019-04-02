using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebKhachHang.Models;

namespace WebKhachHang.Controllers
{
    public class HomeController : Controller
    {
        private readonly VinMartv1Context _context;
        const string SessionID = "_ID";
        const string SessionName = "_Name";
        public HomeController(VinMartv1Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            string checkName = HttpContext.Session.GetString(SessionName);
            ViewBag.Name = checkName;
            return View();
        }

        public ActionResult Profile(int? id)
        {
            int? checkid = HttpContext.Session.GetInt32(SessionID);
            string checkName = HttpContext.Session.GetString(SessionName);
            if (checkid != null)
            {
                ViewBag.Name = checkName;
                var Chitiet = _context.TblKhachHang.Where(x => x.MaKh == checkid).FirstOrDefault();
                return View(Chitiet);
            }
            else
            {
                return Content("Bạn cần đăng nhập!");
            }
           
        }
        public IActionResult Contact()
        {
            string checkName = HttpContext.Session.GetString(SessionName);
            ViewBag.Name = checkName;
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
        public async Task<IActionResult> Edit(int id, [Bind("MaKh,HoTen,NamSinh,GioiTinh,NgheNghiep,Cmnd,Sdt,Email,DiaChi,LoaiKH,NgayThamGia,MaTk,DiemTichLuy,DiemHienCo,TrangThai,LoaiKhachHang")] TblKhachHang tblKhachHang)
        {
            if (id != tblKhachHang.MaKh)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblKhachHang);
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

        public IActionResult History(int? id)
        {
            int? checkid = HttpContext.Session.GetInt32(SessionID);
            string checkName = HttpContext.Session.GetString(SessionName);
            ViewBag.Name = checkName;
            var ListGD = _context.TblGiaoDich.Where(x => x.MaKh == checkid).ToList();
            return View(ListGD);
        }

       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
