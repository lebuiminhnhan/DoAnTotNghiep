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
    public class TblTaiKhoansController : Controller
    {
        private readonly VinMartv1Context _context;

        public TblTaiKhoansController(VinMartv1Context context)
        {
            _context = context;
        }

        // GET: TblTaiKhoans
        public async Task<IActionResult> Index()
        {
            var vinMartv1Context = _context.TblTaiKhoan.Include(t => t.MaQuyenNavigation);
            return View(await vinMartv1Context.ToListAsync());
        }

        // GET: TblTaiKhoans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblTaiKhoan = await _context.TblTaiKhoan
                .Include(t => t.MaQuyenNavigation)
                .FirstOrDefaultAsync(m => m.MaTk == id);
            if (tblTaiKhoan == null)
            {
                return NotFound();
            }

            return View(tblTaiKhoan);
        }

        // GET: TblTaiKhoans/Create
        public IActionResult Create()
        {
            ViewData["MaQuyen"] = new SelectList(_context.TblQuyen, "MaQuyen", "TenQuyen");
            return View();
        }

        // POST: TblTaiKhoans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaTk,TenDangNhap,MatKhau,MaQuyen")] TblTaiKhoan tblTaiKhoan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblTaiKhoan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaQuyen"] = new SelectList(_context.TblQuyen, "MaQuyen", "TenQuyen", tblTaiKhoan.MaQuyen);
            return View(tblTaiKhoan);
        }

        // GET: TblTaiKhoans/Edit/5
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

        // POST: TblTaiKhoans/Edit/5
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

        // GET: TblTaiKhoans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblTaiKhoan = await _context.TblTaiKhoan
                .Include(t => t.MaQuyenNavigation)
                .FirstOrDefaultAsync(m => m.MaTk == id);
            if (tblTaiKhoan == null)
            {
                return NotFound();
            }

            return View(tblTaiKhoan);
        }

        // POST: TblTaiKhoans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblTaiKhoan = await _context.TblTaiKhoan.FindAsync(id);
            _context.TblTaiKhoan.Remove(tblTaiKhoan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblTaiKhoanExists(int id)
        {
            return _context.TblTaiKhoan.Any(e => e.MaTk == id);
        }
    }
}
