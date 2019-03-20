using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebKhachHang.Models
{
    public partial class VinMartv1Context : DbContext
    {
        public VinMartv1Context()
        {
        }

        public VinMartv1Context(DbContextOptions<VinMartv1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCoUuDai> TblCoUuDai { get; set; }
        public virtual DbSet<TblGiaoDich> TblGiaoDich { get; set; }
        public virtual DbSet<TblKhachHang> TblKhachHang { get; set; }
        public virtual DbSet<TblLichSuGiaoDich> TblLichSuGiaoDich { get; set; }
        public virtual DbSet<TblLoaiSanPham> TblLoaiSanPham { get; set; }
        public virtual DbSet<TblNhaCungCap> TblNhaCungCap { get; set; }
        public virtual DbSet<TblNhanVien> TblNhanVien { get; set; }
        public virtual DbSet<TblQuyen> TblQuyen { get; set; }
        public virtual DbSet<TblSanPham> TblSanPham { get; set; }
        public virtual DbSet<TblSanPhamGiaoDich> TblSanPhamGiaoDich { get; set; }
        public virtual DbSet<TblTaiKhoan> TblTaiKhoan { get; set; }
        public virtual DbSet<TblUuDai> TblUuDai { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Server=MINHNHAN\\SQLEXPRESS;Database=VinMartv1;Trusted_Connection=True;");
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblCoUuDai>(entity =>
            {
                entity.HasKey(e => new { e.MaUd, e.MaKh, e.MaGd });

                entity.ToTable("tblCoUuDai");

                entity.Property(e => e.MaUd).HasColumnName("MaUD");

                entity.Property(e => e.MaKh).HasColumnName("MaKH");

                entity.Property(e => e.MaGd).HasColumnName("MaGD");

                entity.HasOne(d => d.MaGdNavigation)
                    .WithMany(p => p.TblCoUuDai)
                    .HasForeignKey(d => d.MaGd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCoUuDai_tblGiaoDich");

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.TblCoUuDai)
                    .HasForeignKey(d => d.MaKh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCoUuDai_tblKhachHang");

                entity.HasOne(d => d.MaUdNavigation)
                    .WithMany(p => p.TblCoUuDai)
                    .HasForeignKey(d => d.MaUd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCoUuDai_tblUuDai");
            });

            modelBuilder.Entity<TblGiaoDich>(entity =>
            {
                entity.HasKey(e => e.MaGd);

                entity.ToTable("tblGiaoDich");

                entity.Property(e => e.MaGd).HasColumnName("MaGD");

                entity.Property(e => e.MaKh).HasColumnName("MaKH");

                entity.Property(e => e.MaNv).HasColumnName("MaNV");

                entity.Property(e => e.NgayGiaoDich).HasColumnType("datetime");

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.TblGiaoDich)
                    .HasForeignKey(d => d.MaKh)
                    .HasConstraintName("FK_tblGiaoDich_tblKhachHang");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.TblGiaoDich)
                    .HasForeignKey(d => d.MaNv)
                    .HasConstraintName("FK_tblGiaoDich_tblNhanVien");
            });

            modelBuilder.Entity<TblKhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKh);

                entity.ToTable("tblKhachHang");

                entity.Property(e => e.MaKh).HasColumnName("MaKH");

                entity.Property(e => e.Cmnd).HasColumnName("CMND");

                entity.Property(e => e.LoaiKhachHang).HasMaxLength(50);

                entity.Property(e => e.MaTk).HasColumnName("MaTK");

                entity.Property(e => e.NamSinh).HasColumnType("datetime");

                entity.Property(e => e.NgayThamGia).HasColumnType("datetime");

                entity.Property(e => e.Sdt).HasColumnName("SDT");

                entity.Property(e => e.TrangThai).HasMaxLength(50);

                entity.HasOne(d => d.MaTkNavigation)
                    .WithMany(p => p.TblKhachHang)
                    .HasForeignKey(d => d.MaTk)
                    .HasConstraintName("FK_tblKhachHang_tblTaiKhoan");
            });

            modelBuilder.Entity<TblLichSuGiaoDich>(entity =>
            {
                entity.HasKey(e => e.MaLsgd);

                entity.ToTable("tblLichSuGiaoDich");

                entity.Property(e => e.MaLsgd).HasColumnName("MaLSGD");

                entity.Property(e => e.MaGd).HasColumnName("MaGD");

                entity.Property(e => e.MaKh).HasColumnName("MaKH");

                entity.Property(e => e.TongTienGd).HasColumnName("TongTienGD");

                entity.HasOne(d => d.MaGdNavigation)
                    .WithMany(p => p.TblLichSuGiaoDich)
                    .HasForeignKey(d => d.MaGd)
                    .HasConstraintName("FK_tblLichSuGiaoDich_tblGiaoDich");

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.TblLichSuGiaoDich)
                    .HasForeignKey(d => d.MaKh)
                    .HasConstraintName("FK_tblLichSuGiaoDich_tblKhachHang");
            });

            modelBuilder.Entity<TblLoaiSanPham>(entity =>
            {
                entity.HasKey(e => e.MaLoai);

                entity.ToTable("tblLoaiSanPham");

                entity.Property(e => e.TenLoai)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblNhaCungCap>(entity =>
            {
                entity.HasKey(e => e.MaNcc);

                entity.ToTable("tblNhaCungCap");

                entity.Property(e => e.MaNcc).HasColumnName("MaNCC");

                entity.Property(e => e.DiaChi)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Sdt)
                    .IsRequired()
                    .HasColumnName("SDT")
                    .HasMaxLength(50);

                entity.Property(e => e.TenNcc)
                    .IsRequired()
                    .HasColumnName("TenNCC")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblNhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNv);

                entity.ToTable("tblNhanVien");

                entity.Property(e => e.MaNv).HasColumnName("MaNV");

                entity.Property(e => e.DiaChi).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.GioiTinh).HasMaxLength(50);

                entity.Property(e => e.HoTen).HasMaxLength(50);

                entity.Property(e => e.MaTk).HasColumnName("MaTK");

                entity.Property(e => e.NamSinh).HasMaxLength(50);

                entity.Property(e => e.Sdt)
                    .HasColumnName("SDT")
                    .HasMaxLength(50);

                entity.HasOne(d => d.MaTkNavigation)
                    .WithMany(p => p.TblNhanVien)
                    .HasForeignKey(d => d.MaTk)
                    .HasConstraintName("FK_tblNhanVien_tblTaiKhoan");
            });

            modelBuilder.Entity<TblQuyen>(entity =>
            {
                entity.HasKey(e => e.MaQuyen);

                entity.ToTable("tblQuyen");

                entity.Property(e => e.MaQuyen).ValueGeneratedNever();

                entity.Property(e => e.TenQuyen)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblSanPham>(entity =>
            {
                entity.HasKey(e => e.MaSp);

                entity.ToTable("tblSanPham");

                entity.Property(e => e.MaSp).HasColumnName("MaSP");

                entity.Property(e => e.MaLh).HasColumnName("MaLH");

                entity.Property(e => e.MaNcc).HasColumnName("MaNCC");

                entity.Property(e => e.TenSp)
                    .HasColumnName("TenSP")
                    .HasMaxLength(50);

                entity.HasOne(d => d.MaLhNavigation)
                    .WithMany(p => p.TblSanPham)
                    .HasForeignKey(d => d.MaLh)
                    .HasConstraintName("FK_tblSanPham_tblLoaiSanPham");

                entity.HasOne(d => d.MaNccNavigation)
                    .WithMany(p => p.TblSanPham)
                    .HasForeignKey(d => d.MaNcc)
                    .HasConstraintName("FK_tblSanPham_tblNhaCungCap");
            });

            modelBuilder.Entity<TblSanPhamGiaoDich>(entity =>
            {
                entity.HasKey(e => new { e.MaGd, e.MaSp });

                entity.ToTable("tblSanPhamGiaoDich");

                entity.Property(e => e.MaGd).HasColumnName("MaGD");

                entity.Property(e => e.MaSp).HasColumnName("MaSP");

                entity.HasOne(d => d.MaGdNavigation)
                    .WithMany(p => p.TblSanPhamGiaoDich)
                    .HasForeignKey(d => d.MaGd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSanPhamGiaoDich_tblGiaoDich");

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.TblSanPhamGiaoDich)
                    .HasForeignKey(d => d.MaSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSanPhamGiaoDich_tblSanPham");
            });

            modelBuilder.Entity<TblTaiKhoan>(entity =>
            {
                entity.HasKey(e => e.MaTk);

                entity.ToTable("tblTaiKhoan");

                entity.Property(e => e.MaTk)
                    .HasColumnName("MaTK")
                    .ValueGeneratedNever();

                entity.Property(e => e.MatKhau)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TenDangNhap)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.MaQuyenNavigation)
                    .WithMany(p => p.TblTaiKhoan)
                    .HasForeignKey(d => d.MaQuyen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblTaiKhoan_tblQuyen");
            });

            modelBuilder.Entity<TblUuDai>(entity =>
            {
                entity.HasKey(e => e.MaUd);

                entity.ToTable("tblUuDai");

                entity.Property(e => e.MaUd).HasColumnName("MaUD");

                entity.Property(e => e.TenUd).HasColumnName("TenUD");

                entity.Property(e => e.ThoiGianBd)
                    .HasColumnName("ThoiGianBD")
                    .HasColumnType("datetime");

                entity.Property(e => e.ThoiGianKt)
                    .HasColumnName("ThoiGianKT")
                    .HasColumnType("datetime");
            });
        }
    }
}
