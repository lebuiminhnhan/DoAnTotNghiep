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
    public class MatKhauController : Controller
    {
        private readonly VinMartv1Context _context;
        const string SessionID = "_ID";
        const string SessionName = "_Name";
        public MatKhauController(VinMartv1Context context)
        {
            _context = context;
        }

        // GET: MatKhau
        public async Task<IActionResult> Index()
        {
            int? checkid = HttpContext.Session.GetInt32(SessionID);
            int? mtktk = _context.TblKhachHang.Where(y => y.MaKh == checkid).Select(c => c.MaTk).FirstOrDefault();
            var vinMartv1Context = _context.TblTaiKhoan.Where(x=>x.MaTk== mtktk);
            return View(await vinMartv1Context.ToListAsync());
        }

     
       

        // GET: MatKhau/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblTaiKhoan = await _context.TblTaiKhoan.FindAsync(id);
            if (tblTaiKhoan == null)
            {
                return NotFound();
            }
            ViewData["MaQuyen"] = new SelectList(_context.TblQuyen, "MaQuyen", "TenQuyen", tblTaiKhoan.MaQuyen);
            return View(tblTaiKhoan);
        }

        // POST: MatKhau/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaTk,TenDangNhap,MatKhau,MaQuyen")] TblTaiKhoan tblTaiKhoan)
        {
            if (id != tblTaiKhoan.MaTk)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblTaiKhoan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblTaiKhoanExists(tblTaiKhoan.MaTk))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaQuyen"] = new SelectList(_context.TblQuyen, "MaQuyen", "TenQuyen", tblTaiKhoan.MaQuyen);
            return View(tblTaiKhoan);
        }

       

        private bool TblTaiKhoanExists(int id)
        {
         
            return _context.TblTaiKhoan.Any(e => e.MaTk == id);
        }
    }
}
