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
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblGiaoDich = await _context.TblGiaoDich
                .Include(t => t.MaKhNavigation)
                .Include(t => t.MaNvNavigation)
                .FirstOrDefaultAsync(m => m.MaGd == id);
            if (tblGiaoDich == null)
            {
                return NotFound();
            }

            return View(tblGiaoDich);
        }

        // GET: GiaoDich/Create
        public IActionResult Create()
        {
            ViewData["MaKh"] = new SelectList(_context.TblKhachHang, "MaKh", "MaKh");
            ViewData["MaNv"] = new SelectList(_context.TblNhanVien, "MaNv", "MaNv");
            return View();
        }

        // POST: GiaoDich/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaGd,NgayGiaoDich,TienThanhToan,DiemTich,TienGiam,DiemTru,TienThem,TrangThai,MaNv,MaKh")] TblGiaoDich tblGiaoDich)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblGiaoDich);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaKh"] = new SelectList(_context.TblKhachHang, "MaKh", "MaKh", tblGiaoDich.MaKh);
            ViewData["MaNv"] = new SelectList(_context.TblNhanVien, "MaNv", "MaNv", tblGiaoDich.MaNv);
            return View(tblGiaoDich);
        }

        // GET: GiaoDich/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblGiaoDich = await _context.TblGiaoDich.FindAsync(id);
            if (tblGiaoDich == null)
            {
                return NotFound();
            }
            ViewData["MaKh"] = new SelectList(_context.TblKhachHang, "MaKh", "MaKh", tblGiaoDich.MaKh);
            ViewData["MaNv"] = new SelectList(_context.TblNhanVien, "MaNv", "MaNv", tblGiaoDich.MaNv);
            return View(tblGiaoDich);
        }

        // POST: GiaoDich/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaGd,NgayGiaoDich,TienThanhToan,DiemTich,TienGiam,DiemTru,TienThem,TrangThai,MaNv,MaKh")] TblGiaoDich tblGiaoDich)
        {
            if (id != tblGiaoDich.MaGd)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblGiaoDich);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblGiaoDichExists(tblGiaoDich.MaGd))
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
            ViewData["MaKh"] = new SelectList(_context.TblKhachHang, "MaKh", "MaKh", tblGiaoDich.MaKh);
            ViewData["MaNv"] = new SelectList(_context.TblNhanVien, "MaNv", "MaNv", tblGiaoDich.MaNv);
            return View(tblGiaoDich);
        }

        // GET: GiaoDich/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblGiaoDich = await _context.TblGiaoDich
                .Include(t => t.MaKhNavigation)
                .Include(t => t.MaNvNavigation)
                .FirstOrDefaultAsync(m => m.MaGd == id);
            if (tblGiaoDich == null)
            {
                return NotFound();
            }

            return View(tblGiaoDich);
        }

        // POST: GiaoDich/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblGiaoDich = await _context.TblGiaoDich.FindAsync(id);
            _context.TblGiaoDich.Remove(tblGiaoDich);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblGiaoDichExists(int id)
        {
            return _context.TblGiaoDich.Any(e => e.MaGd == id);
        }
    }
}
