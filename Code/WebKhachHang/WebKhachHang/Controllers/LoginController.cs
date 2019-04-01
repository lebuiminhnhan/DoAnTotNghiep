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
    public class LoginController : Controller
    {
        private readonly VinMartv1Context _context;

        public LoginController(VinMartv1Context context)
        {
            _context = context;
        }

        // GET: Login
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Validate(TblTaiKhoan admin)
        {
            
            var _admin = _context.TblTaiKhoan.Where(s => s.TenDangNhap == admin.TenDangNhap && s.MaQuyen == 2);
            if (_admin.Any())
            {
                if (_admin.Where(s => s.MatKhau == admin.MatKhau).Any())
                {

                    return Json(new { status = true, message = "Đăng nhập thành công!" });
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
