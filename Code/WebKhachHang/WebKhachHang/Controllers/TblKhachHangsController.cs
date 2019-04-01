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
    public class TblKhachHangsController : Controller
    {
        private readonly VinMartv1Context _context;

        public TblKhachHangsController(VinMartv1Context context)
        {
            _context = context;
        }

        // GET: TblKhachHangs
        public async Task<IActionResult> Index()
        {
            var vinMartv1Context = _context.TblKhachHang.Include(t => t.MaTkNavigation);
            return View(await vinMartv1Context.ToListAsync());
        }

        // GET: TblKhachHangs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblKhachHang = await _context.TblKhachHang
                .Include(t => t.MaTkNavigation)
                .FirstOrDefaultAsync(m => m.MaKh == id);
            if (tblKhachHang == null)
            {
                return NotFound();
            }

            return View(tblKhachHang);
        }

        // GET: TblKhachHangs/Create
        public IActionResult Create()
        {
            ViewData["MaTk"] = new SelectList(_context.TblTaiKhoan, "MaTk", "MatKhau");
            return View();
        }

        // POST: TblKhachHangs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaKh,HoTen,NamSinh,GioiTinh,NgheNghiep,Cmnd,Sdt,Email,DiaChi,NgayThamGia,DiemTichLuy,DiemHienCo,LoaiKhachHang,TrangThai,MaTk")] TblKhachHang tblKhachHang)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblKhachHang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaTk"] = new SelectList(_context.TblTaiKhoan, "MaTk", "MatKhau", tblKhachHang.MaTk);
            return View(tblKhachHang);
        }

        // GET: TblKhachHangs/Edit/5
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
        public async Task<IActionResult> Edit(int id, [Bind("MaKh,HoTen,NamSinh,GioiTinh,NgheNghiep,Cmnd,Sdt,Email,DiaChi,NgayThamGia,DiemTichLuy,DiemHienCo,LoaiKhachHang,TrangThai,MaTk")] TblKhachHang tblKhachHang)
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
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaTk"] = new SelectList(_context.TblTaiKhoan, "MaTk", "MatKhau", tblKhachHang.MaTk);
            return View(tblKhachHang);
        }

        // GET: TblKhachHangs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblKhachHang = await _context.TblKhachHang
                .Include(t => t.MaTkNavigation)
                .FirstOrDefaultAsync(m => m.MaKh == id);
            if (tblKhachHang == null)
            {
                return NotFound();
            }

            return View(tblKhachHang);
        }

        // POST: TblKhachHangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblKhachHang = await _context.TblKhachHang.FindAsync(id);
            _context.TblKhachHang.Remove(tblKhachHang);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblKhachHangExists(int id)
        {
            return _context.TblKhachHang.Any(e => e.MaKh == id);
        }
    }
}
