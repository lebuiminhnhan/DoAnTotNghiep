
CREATE TABLE [dbo].[tblCoUuDai](
	[MaUD] [int] NOT NULL,
	[MaKH] [int] NOT NULL,
	[MaGD] [int] NOT NULL,
 CONSTRAINT [PK_tblCoUuDai] PRIMARY KEY CLUSTERED 
(
	[MaUD] ASC,
	[MaKH] ASC,
	[MaGD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE [dbo].[tblGiaoDich](
	[MaGD] [int] IDENTITY(20000,1) NOT NULL,
	[NgayGiaoDich] [datetime] NULL,
	[TienThanhToan] [int] NULL,
	[DiemTich] [int] NULL,
	[TienGiam] [int] NULL,
	[DiemTru] [int] NULL,
	[TienThem] [int] NULL,
	[TrangThai] [nvarchar](max) NULL,
	[MaNV] [int] NULL,
	[MaKH] [int] NULL,
 CONSTRAINT [PK_tblGiaoDich] PRIMARY KEY CLUSTERED 
(
	[MaGD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


CREATE TABLE [dbo].[tblKhachHang](
	[MaKH] [int] IDENTITY(10000,1) NOT NULL,
	[HoTen] [nvarchar](max) NULL,
	[NamSinh] [datetime] NULL,
	[GioiTinh] [nvarchar](max) NULL,
	[NgheNghiep] [nvarchar](max) NULL,
	[CMND] [nvarchar](max) NULL,
	[SDT] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[NgayThamGia] [datetime] NULL,
	[DiemTichLuy] [int] NULL,
	[DiemHienCo] [int] NULL,
	[LoaiKhachHang] [nvarchar](50) NULL,
	[TrangThai] [nvarchar](50) NULL,
	[MaTK] [int] NULL,
 CONSTRAINT [PK_Tbl_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


CREATE TABLE [dbo].[tblLichSuGiaoDich](
	[MaLSGD] [int] IDENTITY(6000001,1) NOT NULL,
	[TongTienGD] [int] NULL,
	[MaGD] [int] NULL,
	[MaKH] [int] NULL,
 CONSTRAINT [PK_tblLichSuGiaoDich] PRIMARY KEY CLUSTERED 
(
	[MaLSGD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE [dbo].[tblLoaiSanPham](
	[MaLoai] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblLoaiSanPham] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE [dbo].[tblNhaCungCap](
	[MaNCC] [int] IDENTITY(1,1) NOT NULL,
	[TenNCC] [nvarchar](50) NOT NULL,
	[SDT] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblNhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE [dbo].[tblNhanVien](
	[MaNV] [int] IDENTITY(50001,1) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[NamSinh] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[MaTK] [int] NULL,
 CONSTRAINT [PK_tblNhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE [dbo].[tblQuyen](
	[MaQuyen] [int] NOT NULL,
	[TenQuyen] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblQuyen] PRIMARY KEY CLUSTERED 
(
	[MaQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE [dbo].[tblSanPham](
	[MaSP] [int] IDENTITY(2000001,1) NOT NULL,
	[TenSP] [nvarchar](50) NULL,
	[MucGiamGia] [int] NULL,
	[DonGia] [int] NULL,
	[MaNCC] [int] NULL,
	[MaLH] [int] NULL,
	[MoTa] [nvarchar](max) NULL,
 CONSTRAINT [PK_tblSanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


CREATE TABLE [dbo].[tblSanPhamGiaoDich](
	[MaGD] [int] NOT NULL,
	[MaSP] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_tblSanPhamGiaoDich] PRIMARY KEY CLUSTERED 
(
	[MaGD] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE [dbo].[tblTaiKhoan](
	[MaTK] [int] NOT NULL,
	[TenDangNhap] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NOT NULL,
	[MaQuyen] [int] NOT NULL,
 CONSTRAINT [PK_tblTaiKhoan] PRIMARY KEY CLUSTERED 
(
	[MaTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE [dbo].[tblUuDai](
	[MaUD] [int] IDENTITY(1,1) NOT NULL,
	[TenUD] [nvarchar](max) NULL,
	[ThoiGianBD] [datetime] NULL,
	[ThoiGianKT] [datetime] NULL,
	[MoTa] [nvarchar](max) NULL,
 CONSTRAINT [PK_tblUuDai] PRIMARY KEY CLUSTERED 
(
	[MaUD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[tblCoUuDai]  WITH CHECK ADD  CONSTRAINT [FK_tblCoUuDai_tblGiaoDich] FOREIGN KEY([MaGD])
REFERENCES [dbo].[tblGiaoDich] ([MaGD])
GO
ALTER TABLE [dbo].[tblCoUuDai] CHECK CONSTRAINT [FK_tblCoUuDai_tblGiaoDich]
GO
ALTER TABLE [dbo].[tblCoUuDai]  WITH CHECK ADD  CONSTRAINT [FK_tblCoUuDai_tblKhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[tblKhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[tblCoUuDai] CHECK CONSTRAINT [FK_tblCoUuDai_tblKhachHang]
GO
ALTER TABLE [dbo].[tblCoUuDai]  WITH CHECK ADD  CONSTRAINT [FK_tblCoUuDai_tblUuDai] FOREIGN KEY([MaUD])
REFERENCES [dbo].[tblUuDai] ([MaUD])
GO
ALTER TABLE [dbo].[tblCoUuDai] CHECK CONSTRAINT [FK_tblCoUuDai_tblUuDai]
GO
ALTER TABLE [dbo].[tblGiaoDich]  WITH CHECK ADD  CONSTRAINT [FK_tblGiaoDich_tblKhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[tblKhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[tblGiaoDich] CHECK CONSTRAINT [FK_tblGiaoDich_tblKhachHang]
GO
ALTER TABLE [dbo].[tblGiaoDich]  WITH CHECK ADD  CONSTRAINT [FK_tblGiaoDich_tblNhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[tblGiaoDich] CHECK CONSTRAINT [FK_tblGiaoDich_tblNhanVien]
GO
ALTER TABLE [dbo].[tblKhachHang]  WITH CHECK ADD  CONSTRAINT [FK_tblKhachHang_tblTaiKhoan] FOREIGN KEY([MaTK])
REFERENCES [dbo].[tblTaiKhoan] ([MaTK])
GO
ALTER TABLE [dbo].[tblKhachHang] CHECK CONSTRAINT [FK_tblKhachHang_tblTaiKhoan]
GO
ALTER TABLE [dbo].[tblLichSuGiaoDich]  WITH CHECK ADD  CONSTRAINT [FK_tblLichSuGiaoDich_tblGiaoDich] FOREIGN KEY([MaGD])
REFERENCES [dbo].[tblGiaoDich] ([MaGD])
GO
ALTER TABLE [dbo].[tblLichSuGiaoDich] CHECK CONSTRAINT [FK_tblLichSuGiaoDich_tblGiaoDich]
GO
ALTER TABLE [dbo].[tblLichSuGiaoDich]  WITH CHECK ADD  CONSTRAINT [FK_tblLichSuGiaoDich_tblKhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[tblKhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[tblLichSuGiaoDich] CHECK CONSTRAINT [FK_tblLichSuGiaoDich_tblKhachHang]
GO
ALTER TABLE [dbo].[tblNhanVien]  WITH CHECK ADD  CONSTRAINT [FK_tblNhanVien_tblTaiKhoan] FOREIGN KEY([MaTK])
REFERENCES [dbo].[tblTaiKhoan] ([MaTK])
GO
ALTER TABLE [dbo].[tblNhanVien] CHECK CONSTRAINT [FK_tblNhanVien_tblTaiKhoan]
GO
ALTER TABLE [dbo].[tblSanPham]  WITH CHECK ADD  CONSTRAINT [FK_tblSanPham_tblLoaiSanPham] FOREIGN KEY([MaLH])
REFERENCES [dbo].[tblLoaiSanPham] ([MaLoai])
GO
ALTER TABLE [dbo].[tblSanPham] CHECK CONSTRAINT [FK_tblSanPham_tblLoaiSanPham]
GO
ALTER TABLE [dbo].[tblSanPham]  WITH CHECK ADD  CONSTRAINT [FK_tblSanPham_tblNhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[tblNhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[tblSanPham] CHECK CONSTRAINT [FK_tblSanPham_tblNhaCungCap]
GO
ALTER TABLE [dbo].[tblSanPhamGiaoDich]  WITH CHECK ADD  CONSTRAINT [FK_tblSanPhamGiaoDich_tblGiaoDich] FOREIGN KEY([MaGD])
REFERENCES [dbo].[tblGiaoDich] ([MaGD])
GO
ALTER TABLE [dbo].[tblSanPhamGiaoDich] CHECK CONSTRAINT [FK_tblSanPhamGiaoDich_tblGiaoDich]
GO
ALTER TABLE [dbo].[tblSanPhamGiaoDich]  WITH CHECK ADD  CONSTRAINT [FK_tblSanPhamGiaoDich_tblSanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[tblSanPham] ([MaSP])
GO
ALTER TABLE [dbo].[tblSanPhamGiaoDich] CHECK CONSTRAINT [FK_tblSanPhamGiaoDich_tblSanPham]
GO
ALTER TABLE [dbo].[tblTaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_tblTaiKhoan_tblQuyen] FOREIGN KEY([MaQuyen])
REFERENCES [dbo].[tblQuyen] ([MaQuyen])
GO
ALTER TABLE [dbo].[tblTaiKhoan] CHECK CONSTRAINT [FK_tblTaiKhoan_tblQuyen]
GO
