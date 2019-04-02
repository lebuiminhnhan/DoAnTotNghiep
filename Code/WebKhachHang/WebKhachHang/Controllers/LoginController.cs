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
    public class LoginController : Controller
    {
        const string SessionID = "_ID";
        const string SessionName = "_Name";
        private readonly VinMartv1Context _context;

        public LoginController(VinMartv1Context context)
        {
            _context = context;
        }

        // GET: Login
        public IActionResult Index()
        {
            HttpContext.Session.Clear();
            return View();
        }
        private bool TblKhachHangExists(int id)
        {
            return _context.TblKhachHang.Any(e => e.MaKh == id);
        }

        public ActionResult Validate(TblTaiKhoan admin)
        {
            
            var _admin = _context.TblTaiKhoan.Where(s => s.TenDangNhap == admin.TenDangNhap && s.MaQuyen == 2);
            if (_admin.Any())
            {
                if (_admin.Where(s => s.MatKhau == admin.MatKhau).Any())
                {
                    var check = _context.TblKhachHang.Where(x => x.MaTk == _admin.Select(y => y.MaTk).FirstOrDefault()).Select(z => z.MaKh).FirstOrDefault();
                    var checkName = _context.TblKhachHang.Where(x => x.MaTk == _admin.Select(y => y.MaTk).FirstOrDefault()).Select(z => z.HoTen).FirstOrDefault();
                    HttpContext.Session.SetString(SessionName, checkName);

                    HttpContext.Session.SetInt32(SessionID, check);
                    return Json(new { status = true, message = checkName });
                }
                else
                {
                    return Json(new { status = false, message = "Sai mật khẩu!" });
                }
            }
            else
            {
                return Json(new { status = false, message = "Sai tài khoản!" });
            }
        }
    }
}
