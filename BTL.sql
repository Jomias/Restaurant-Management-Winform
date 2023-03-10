USE [QLNH]
GO
/****** Object:  Table [dbo].[BANAN]    Script Date: 22/11/2022 8:09:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BANAN](
	[MaBan] [nvarchar](25) NOT NULL,
	[TenBan] [nvarchar](30) NOT NULL,
	[TinhTrang] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIETDATMON]    Script Date: 22/11/2022 8:09:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETDATMON](
	[MaHD] [nvarchar](25) NOT NULL,
	[MaMA] [nvarchar](25) NOT NULL,
	[DonGia] [money] NULL,
	[SoLuong] [int] NOT NULL,
	[ThanhTien] [money] NULL,
 CONSTRAINT [MONAN_PHIEUYEUCAU] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaMA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIETPHIEUNHAP]    Script Date: 22/11/2022 8:09:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUNHAP](
	[MaPN] [nvarchar](25) NOT NULL,
	[MaNL] [nvarchar](25) NOT NULL,
	[DonGia] [money] NULL,
	[SoLuong] [int] NOT NULL,
	[ThanhTien] [money] NULL,
 CONSTRAINT [NGUYENLIEU_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC,
	[MaNL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CONGTHUC]    Script Date: 22/11/2022 8:09:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONGTHUC](
	[MaMA] [nvarchar](25) NOT NULL,
	[MaNL] [nvarchar](25) NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [MONAN_NGUYENLIEU] PRIMARY KEY CLUSTERED 
(
	[MaMA] ASC,
	[MaNL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 22/11/2022 8:09:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHD] [nvarchar](25) NOT NULL,
	[DateCheckIn] [datetime] NOT NULL,
	[DateCheckOut] [datetime] NULL,
	[TinhTrang] [int] NOT NULL,
	[TongTien] [money] NULL,
	[UserName] [nvarchar](30) NOT NULL,
	[MaBan] [nvarchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIMON]    Script Date: 22/11/2022 8:09:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIMON](
	[MaLM] [nvarchar](25) NOT NULL,
	[TenLM] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAINGUYENLIEU]    Script Date: 22/11/2022 8:09:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAINGUYENLIEU](
	[MaLNL] [nvarchar](25) NOT NULL,
	[TenLNL] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLNL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MONAN]    Script Date: 22/11/2022 8:09:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MONAN](
	[MaMA] [nvarchar](25) NOT NULL,
	[TenMonAn] [nvarchar](100) NOT NULL,
	[DonGia] [money] NOT NULL,
	[MaLM] [nvarchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NGUYENLIEU]    Script Date: 22/11/2022 8:09:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGUYENLIEU](
	[MaNL] [nvarchar](25) NOT NULL,
	[TenNL] [nvarchar](50) NOT NULL,
	[DVT] [nvarchar](30) NOT NULL,
	[SoLuong] [int] NULL,
	[MaLNL] [nvarchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 22/11/2022 8:09:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MaNCC] [nvarchar](25) NOT NULL,
	[TenNCC] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[SDT] [nvarchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 22/11/2022 8:09:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [nvarchar](25) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[GioiTinh] [nvarchar](30) NOT NULL,
	[SDT] [nvarchar](15) NOT NULL,
	[ChucVu] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 22/11/2022 8:09:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[MaPN] [nvarchar](25) NOT NULL,
	[NgayLap] [datetime] NULL,
	[TongTien] [money] NULL,
	[MaNCC] [nvarchar](25) NOT NULL,
	[UserName] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 22/11/2022 8:09:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[UserName] [nvarchar](30) NOT NULL,
	[PassWord] [nvarchar](30) NOT NULL,
	[DisplayName] [nvarchar](50) NOT NULL,
	[PhanQuyen] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TinhTrang]) VALUES (N'BA01', N'Bàn 1', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TinhTrang]) VALUES (N'BA02', N'Bàn 2', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TinhTrang]) VALUES (N'BA03', N'Bàn 3', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TinhTrang]) VALUES (N'BA04', N'Bàn 4', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TinhTrang]) VALUES (N'BA05', N'Bàn 5', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TinhTrang]) VALUES (N'BA06', N'Bàn 6', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TinhTrang]) VALUES (N'BA07', N'Bàn 7', N'Có người')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TinhTrang]) VALUES (N'BA08', N'Bàn 8', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TinhTrang]) VALUES (N'BA09', N'Bàn 9', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TinhTrang]) VALUES (N'BA10', N'Bàn 10', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TinhTrang]) VALUES (N'BA11', N'Bàn 11', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TinhTrang]) VALUES (N'BA12', N'Bàn 12', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TinhTrang]) VALUES (N'BA13', N'Bàn 13', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TinhTrang]) VALUES (N'BA14', N'Bàn 14', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TinhTrang]) VALUES (N'BA15', N'Bàn 15', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TinhTrang]) VALUES (N'BA16', N'Bàn 16', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TinhTrang]) VALUES (N'BA17', N'Bàn 17', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TinhTrang]) VALUES (N'BA18', N'Bàn 18', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TinhTrang]) VALUES (N'BA19', N'Bàn 19', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TinhTrang]) VALUES (N'BA20', N'Bàn 20', N'Trống')
GO
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB01', N'MA1', 50000.0000, 3, 150000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB01', N'MA10', 100000.0000, 1, 100000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB01', N'MA2', 120000.0000, 5, 600000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB02', N'MA10', 100000.0000, 1, 100000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB02', N'MA11', 60000.0000, 1, 60000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB03', N'MA7', 120000.0000, 1, 120000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB03', N'MA8', 50000.0000, 1, 50000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB04', N'MA16', 50000.0000, 2, 100000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB04', N'MA2', 120000.0000, 1, 120000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB05', N'MA12', 120000.0000, 3, 360000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB05', N'MA9', 350000.0000, 1, 350000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB06', N'MA2', 120000.0000, 2, 240000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB06', N'MA6', 100000.0000, 1, 100000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB07', N'MA15', 30000.0000, 10, 300000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB07', N'MA2', 120000.0000, 2, 240000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB1911022321Q', N'MA3', 50000.0000, 3, 150000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB1911022321Q', N'MA5', 100000.0000, 1, 100000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB1911024415i', N'MA12', 120000.0000, 1, 120000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB1911024415i', N'MA2', 120000.0000, 1, 120000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB1911024415i', N'MA3', 50000.0000, 3, 150000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB1911024415i', N'MA6', 100000.0000, 1, 100000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB1911025432l', N'MA2', 120000.0000, 1, 120000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB1911025432l', N'MA6', 100000.0000, 2, 200000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB1911085853m', N'MA2', 120000.0000, 2, 240000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB1911090206t', N'MA2', 120000.0000, 1, 120000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB1911090206t', N'MA3', 50000.0000, 1, 50000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB1911090206t', N'MA6', 100000.0000, 1, 100000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB1911090206t', N'MA8', 50000.0000, 1, 50000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB1911090336`', N'MA2', 120000.0000, 1, 120000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB1911090336`', N'MA6', 100000.0000, 1, 100000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB1911090549P', N'MA2', 120000.0000, 1, 120000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB1911090549P', N'MA6', 100000.0000, 1, 100000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB1911091132t', N'MA2', 120000.0000, 1, 120000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB1911091132t', N'MA6', 100000.0000, 1, 100000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB1911092336C', N'MA2', 120000.0000, 1, 120000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB1911092336C', N'MA6', 100000.0000, 1, 100000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB1911092634m', N'MA12', 120000.0000, 1, 120000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB1911092634m', N'MA3', 50000.0000, 1, 50000.0000)
INSERT [dbo].[CHITIETDATMON] ([MaHD], [MaMA], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HDB1911092634m', N'MA5', 100000.0000, 1, 100000.0000)
GO
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPN], [MaNL], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'PN1', N'NL1', 100000.0000, 100, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPN], [MaNL], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'PN1', N'NL2', 10000.0000, 100, 1000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPN], [MaNL], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'PN2', N'NL3', 80000.0000, 100, 8000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPN], [MaNL], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'PN2', N'NL4', 300000.0000, 50, 15000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPN], [MaNL], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'PN3', N'NL1', 100000.0000, 100, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPN], [MaNL], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'PN3', N'NL2', 10000.0000, 100, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPN], [MaNL], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'PN4', N'NL5', 30000.0000, 200, 6000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPN], [MaNL], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'PN4', N'NL6', 250000.0000, 100, 25000000.0000)
GO
INSERT [dbo].[CONGTHUC] ([MaMA], [MaNL], [SoLuong]) VALUES (N'MA1', N'NL3', 1)
INSERT [dbo].[CONGTHUC] ([MaMA], [MaNL], [SoLuong]) VALUES (N'MA1', N'NL7', 10)
INSERT [dbo].[CONGTHUC] ([MaMA], [MaNL], [SoLuong]) VALUES (N'MA10', N'NL7', 2)
INSERT [dbo].[CONGTHUC] ([MaMA], [MaNL], [SoLuong]) VALUES (N'MA11', N'NL1', 2)
INSERT [dbo].[CONGTHUC] ([MaMA], [MaNL], [SoLuong]) VALUES (N'MA12', N'NL1', 2)
INSERT [dbo].[CONGTHUC] ([MaMA], [MaNL], [SoLuong]) VALUES (N'MA13', N'NL2', 2)
INSERT [dbo].[CONGTHUC] ([MaMA], [MaNL], [SoLuong]) VALUES (N'MA14', N'NL9', 1)
INSERT [dbo].[CONGTHUC] ([MaMA], [MaNL], [SoLuong]) VALUES (N'MA15', N'NL10', 1)
INSERT [dbo].[CONGTHUC] ([MaMA], [MaNL], [SoLuong]) VALUES (N'MA16', N'NL11', 1)
INSERT [dbo].[CONGTHUC] ([MaMA], [MaNL], [SoLuong]) VALUES (N'MA2', N'NL1', 2)
INSERT [dbo].[CONGTHUC] ([MaMA], [MaNL], [SoLuong]) VALUES (N'MA3', N'NL2', 3)
INSERT [dbo].[CONGTHUC] ([MaMA], [MaNL], [SoLuong]) VALUES (N'MA4', N'NL4', 2)
INSERT [dbo].[CONGTHUC] ([MaMA], [MaNL], [SoLuong]) VALUES (N'MA5', N'NL6', 2)
INSERT [dbo].[CONGTHUC] ([MaMA], [MaNL], [SoLuong]) VALUES (N'MA6', N'NL3', 2)
INSERT [dbo].[CONGTHUC] ([MaMA], [MaNL], [SoLuong]) VALUES (N'MA7', N'NL1', 2)
INSERT [dbo].[CONGTHUC] ([MaMA], [MaNL], [SoLuong]) VALUES (N'MA8', N'NL2', 2)
INSERT [dbo].[CONGTHUC] ([MaMA], [MaNL], [SoLuong]) VALUES (N'MA9', N'NL7', 2)
GO
INSERT [dbo].[HOADON] ([MaHD], [DateCheckIn], [DateCheckOut], [TinhTrang], [TongTien], [UserName], [MaBan]) VALUES (N'HDB01', CAST(N'2022-08-08T00:19:00.000' AS DateTime), CAST(N'2022-08-08T00:20:00.000' AS DateTime), 1, 850000.0000, N'Admin', N'BA10')
INSERT [dbo].[HOADON] ([MaHD], [DateCheckIn], [DateCheckOut], [TinhTrang], [TongTien], [UserName], [MaBan]) VALUES (N'HDB02', CAST(N'2022-09-08T00:20:00.000' AS DateTime), CAST(N'2022-09-08T00:22:00.000' AS DateTime), 1, 160000.0000, N'Admin', N'BA05')
INSERT [dbo].[HOADON] ([MaHD], [DateCheckIn], [DateCheckOut], [TinhTrang], [TongTien], [UserName], [MaBan]) VALUES (N'HDB03', CAST(N'2022-08-10T00:16:00.000' AS DateTime), CAST(N'2022-08-10T00:17:00.000' AS DateTime), 1, 170000.0000, N'Admin', N'BA02')
INSERT [dbo].[HOADON] ([MaHD], [DateCheckIn], [DateCheckOut], [TinhTrang], [TongTien], [UserName], [MaBan]) VALUES (N'HDB04', CAST(N'2022-04-08T00:10:00.000' AS DateTime), CAST(N'2022-04-08T00:11:00.000' AS DateTime), 1, 220000.0000, N'Admin', N'BA06')
INSERT [dbo].[HOADON] ([MaHD], [DateCheckIn], [DateCheckOut], [TinhTrang], [TongTien], [UserName], [MaBan]) VALUES (N'HDB05', CAST(N'2022-09-08T00:07:00.000' AS DateTime), CAST(N'2022-09-08T00:09:00.000' AS DateTime), 1, 410000.0000, N'Admin', N'BA07')
INSERT [dbo].[HOADON] ([MaHD], [DateCheckIn], [DateCheckOut], [TinhTrang], [TongTien], [UserName], [MaBan]) VALUES (N'HDB06', CAST(N'2022-10-15T00:10:00.000' AS DateTime), CAST(N'2022-10-15T00:11:00.000' AS DateTime), 1, 340000.0000, N'Admin', N'BA09')
INSERT [dbo].[HOADON] ([MaHD], [DateCheckIn], [DateCheckOut], [TinhTrang], [TongTien], [UserName], [MaBan]) VALUES (N'HDB07', CAST(N'2022-11-08T00:09:00.000' AS DateTime), CAST(N'2022-11-08T00:10:00.000' AS DateTime), 1, 540000.0000, N'Admin', N'BA01')
INSERT [dbo].[HOADON] ([MaHD], [DateCheckIn], [DateCheckOut], [TinhTrang], [TongTien], [UserName], [MaBan]) VALUES (N'HDB1911022321Q', CAST(N'2022-11-19T02:23:21.000' AS DateTime), CAST(N'2022-11-19T14:25:37.240' AS DateTime), 1, 250000.0000, N'Admin', N'BA02')
INSERT [dbo].[HOADON] ([MaHD], [DateCheckIn], [DateCheckOut], [TinhTrang], [TongTien], [UserName], [MaBan]) VALUES (N'HDB1911024415i', CAST(N'2022-11-19T02:44:15.000' AS DateTime), CAST(N'2022-11-19T14:44:38.470' AS DateTime), 1, 490000.0000, N'Admin', N'BA12')
INSERT [dbo].[HOADON] ([MaHD], [DateCheckIn], [DateCheckOut], [TinhTrang], [TongTien], [UserName], [MaBan]) VALUES (N'HDB1911025432l', CAST(N'2022-11-19T02:54:32.000' AS DateTime), NULL, 0, 320000.0000, N'Admin', N'BA07')
INSERT [dbo].[HOADON] ([MaHD], [DateCheckIn], [DateCheckOut], [TinhTrang], [TongTien], [UserName], [MaBan]) VALUES (N'HDB1911085853m', CAST(N'2022-11-19T08:58:53.000' AS DateTime), CAST(N'2022-11-19T08:58:57.693' AS DateTime), 1, 240000.0000, N'Admin', N'BA11')
INSERT [dbo].[HOADON] ([MaHD], [DateCheckIn], [DateCheckOut], [TinhTrang], [TongTien], [UserName], [MaBan]) VALUES (N'HDB1911090206t', CAST(N'2022-11-19T09:02:06.000' AS DateTime), CAST(N'2022-11-19T09:02:15.287' AS DateTime), 1, 320000.0000, N'Admin', N'BA13')
INSERT [dbo].[HOADON] ([MaHD], [DateCheckIn], [DateCheckOut], [TinhTrang], [TongTien], [UserName], [MaBan]) VALUES (N'HDB1911090336`', CAST(N'2022-11-19T09:03:36.000' AS DateTime), CAST(N'2022-11-19T09:03:43.573' AS DateTime), 1, 220000.0000, N'Admin', N'BA12')
INSERT [dbo].[HOADON] ([MaHD], [DateCheckIn], [DateCheckOut], [TinhTrang], [TongTien], [UserName], [MaBan]) VALUES (N'HDB1911090549P', CAST(N'2022-11-19T09:05:49.000' AS DateTime), CAST(N'2022-11-19T09:05:51.793' AS DateTime), 1, 220000.0000, N'Admin', N'BA13')
INSERT [dbo].[HOADON] ([MaHD], [DateCheckIn], [DateCheckOut], [TinhTrang], [TongTien], [UserName], [MaBan]) VALUES (N'HDB1911091132t', CAST(N'2022-11-19T09:11:32.000' AS DateTime), CAST(N'2022-11-19T09:11:38.733' AS DateTime), 1, 220000.0000, N'Admin', N'BA08')
INSERT [dbo].[HOADON] ([MaHD], [DateCheckIn], [DateCheckOut], [TinhTrang], [TongTien], [UserName], [MaBan]) VALUES (N'HDB1911092336C', CAST(N'2022-11-19T09:23:36.000' AS DateTime), CAST(N'2022-11-19T09:23:39.973' AS DateTime), 1, 220000.0000, N'Admin', N'BA07')
INSERT [dbo].[HOADON] ([MaHD], [DateCheckIn], [DateCheckOut], [TinhTrang], [TongTien], [UserName], [MaBan]) VALUES (N'HDB1911092634m', CAST(N'2022-11-19T09:26:34.000' AS DateTime), CAST(N'2022-11-19T09:26:41.553' AS DateTime), 1, 270000.0000, N'Admin', N'BA08')
GO
INSERT [dbo].[LOAIMON] ([MaLM], [TenLM]) VALUES (N'LM1', N'Luộc')
INSERT [dbo].[LOAIMON] ([MaLM], [TenLM]) VALUES (N'LM2', N'Xào')
INSERT [dbo].[LOAIMON] ([MaLM], [TenLM]) VALUES (N'LM3', N'Nướng')
INSERT [dbo].[LOAIMON] ([MaLM], [TenLM]) VALUES (N'LM4', N'Kho')
INSERT [dbo].[LOAIMON] ([MaLM], [TenLM]) VALUES (N'LM5', N'Nước')
GO
INSERT [dbo].[LOAINGUYENLIEU] ([MaLNL], [TenLNL]) VALUES (N'LNL1', N'Thịt và gia cầm')
INSERT [dbo].[LOAINGUYENLIEU] ([MaLNL], [TenLNL]) VALUES (N'LNL2', N'Cá và hải sản')
INSERT [dbo].[LOAINGUYENLIEU] ([MaLNL], [TenLNL]) VALUES (N'LNL3', N'Rau củ')
INSERT [dbo].[LOAINGUYENLIEU] ([MaLNL], [TenLNL]) VALUES (N'LNL4', N'Trái cây')
INSERT [dbo].[LOAINGUYENLIEU] ([MaLNL], [TenLNL]) VALUES (N'LNL5', N'Nước')
INSERT [dbo].[LOAINGUYENLIEU] ([MaLNL], [TenLNL]) VALUES (N'LNL6', N'Phụ gia')
GO
INSERT [dbo].[MONAN] ([MaMA], [TenMonAn], [DonGia], [MaLM]) VALUES (N'MA1', N'Thịt kho tàu', 50000.0000, N'LM4')
INSERT [dbo].[MONAN] ([MaMA], [TenMonAn], [DonGia], [MaLM]) VALUES (N'MA10', N'Thịt bò kho', 100000.0000, N'LM4')
INSERT [dbo].[MONAN] ([MaMA], [TenMonAn], [DonGia], [MaLM]) VALUES (N'MA11', N'Gà nướng', 60000.0000, N'LM3')
INSERT [dbo].[MONAN] ([MaMA], [TenMonAn], [DonGia], [MaLM]) VALUES (N'MA12', N'Gà xào', 120000.0000, N'LM2')
INSERT [dbo].[MONAN] ([MaMA], [TenMonAn], [DonGia], [MaLM]) VALUES (N'MA13', N'Rau cải nướng', 50000.0000, N'LM3')
INSERT [dbo].[MONAN] ([MaMA], [TenMonAn], [DonGia], [MaLM]) VALUES (N'MA14', N'Nước ngọt', 20000.0000, N'LM5')
INSERT [dbo].[MONAN] ([MaMA], [TenMonAn], [DonGia], [MaLM]) VALUES (N'MA15', N'Bia', 30000.0000, N'LM5')
INSERT [dbo].[MONAN] ([MaMA], [TenMonAn], [DonGia], [MaLM]) VALUES (N'MA16', N'Rượu', 50000.0000, N'LM5')
INSERT [dbo].[MONAN] ([MaMA], [TenMonAn], [DonGia], [MaLM]) VALUES (N'MA2', N'Gà luộc', 120000.0000, N'LM1')
INSERT [dbo].[MONAN] ([MaMA], [TenMonAn], [DonGia], [MaLM]) VALUES (N'MA3', N'Rau cải xào', 50000.0000, N'LM2')
INSERT [dbo].[MONAN] ([MaMA], [TenMonAn], [DonGia], [MaLM]) VALUES (N'MA4', N'Cá hồi nướng', 350000.0000, N'LM3')
INSERT [dbo].[MONAN] ([MaMA], [TenMonAn], [DonGia], [MaLM]) VALUES (N'MA5', N'Thịt bò xào', 100000.0000, N'LM2')
INSERT [dbo].[MONAN] ([MaMA], [TenMonAn], [DonGia], [MaLM]) VALUES (N'MA6', N'Thịt lợn luộc', 100000.0000, N'LM1')
INSERT [dbo].[MONAN] ([MaMA], [TenMonAn], [DonGia], [MaLM]) VALUES (N'MA7', N'Gà kho', 120000.0000, N'LM4')
INSERT [dbo].[MONAN] ([MaMA], [TenMonAn], [DonGia], [MaLM]) VALUES (N'MA8', N'Rau cải luộc', 50000.0000, N'LM1')
INSERT [dbo].[MONAN] ([MaMA], [TenMonAn], [DonGia], [MaLM]) VALUES (N'MA9', N'Thịt bò nướng', 350000.0000, N'LM3')
GO
INSERT [dbo].[NGUYENLIEU] ([MaNL], [TenNL], [DVT], [SoLuong], [MaLNL]) VALUES (N'NL1', N'Thịt gà', N'kg', 464, N'LNL1')
INSERT [dbo].[NGUYENLIEU] ([MaNL], [TenNL], [DVT], [SoLuong], [MaLNL]) VALUES (N'NL10', N'Bia', N'Chai', 500, N'LNL5')
INSERT [dbo].[NGUYENLIEU] ([MaNL], [TenNL], [DVT], [SoLuong], [MaLNL]) VALUES (N'NL11', N'Rượu', N'Chai', 500, N'LNL5')
INSERT [dbo].[NGUYENLIEU] ([MaNL], [TenNL], [DVT], [SoLuong], [MaLNL]) VALUES (N'NL2', N'Rau cải', N'bó', 462, N'LNL3')
INSERT [dbo].[NGUYENLIEU] ([MaNL], [TenNL], [DVT], [SoLuong], [MaLNL]) VALUES (N'NL3', N'Thịt lợn', N'kg', 447, N'LNL1')
INSERT [dbo].[NGUYENLIEU] ([MaNL], [TenNL], [DVT], [SoLuong], [MaLNL]) VALUES (N'NL4', N'Cá hồi', N'kg', 500, N'LNL2')
INSERT [dbo].[NGUYENLIEU] ([MaNL], [TenNL], [DVT], [SoLuong], [MaLNL]) VALUES (N'NL5', N'Cà chua', N'kg', 500, N'LNL4')
INSERT [dbo].[NGUYENLIEU] ([MaNL], [TenNL], [DVT], [SoLuong], [MaLNL]) VALUES (N'NL6', N'Thịt bò', N'kg', 496, N'LNL1')
INSERT [dbo].[NGUYENLIEU] ([MaNL], [TenNL], [DVT], [SoLuong], [MaLNL]) VALUES (N'NL7', N'Hạt tiêu', N'g', 450, N'LNL6')
INSERT [dbo].[NGUYENLIEU] ([MaNL], [TenNL], [DVT], [SoLuong], [MaLNL]) VALUES (N'NL8', N'Gừng', N'kg', 500, N'LNL3')
INSERT [dbo].[NGUYENLIEU] ([MaNL], [TenNL], [DVT], [SoLuong], [MaLNL]) VALUES (N'NL9', N'Nước ngọt', N'Lon', 500, N'LNL5')
GO
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC1', N'Thực Phẩm Tấn Tài', N'Tp. Hồ Chí Minh', N'0986868686')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC2', N'Công Ty Thiên Linh', N'Bà Rịa-Vũng Tàu', N'0983338686')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC3', N'Thực Phẩm Xanh Đồng Nai', N'Đồng Nai', N'0986868123')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC4', N'Zin Food', N'Hà Nội', N'0986123989')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC5', N'Thực Phẩm An Toàn Tân Việt', N'Bắc Ninh', N'0363868686')
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [DiaChi], [GioiTinh], [SDT], [ChucVu]) VALUES (N'NV1', N'TCT', N'Đống Đa, Hà Nội', N'Nam', N'0123456789', N'Quản lý')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [DiaChi], [GioiTinh], [SDT], [ChucVu]) VALUES (N'NV2', N'Lê Thùy Dương', N'Đội cấn, Hà Nội', N'Nữ', N'0123456789', N'Nhân viên')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [DiaChi], [GioiTinh], [SDT], [ChucVu]) VALUES (N'NV3', N'Lê Văn Long', N'Ba Đình, Hà Nội', N'Nam', N'0123456789', N'Quản lý')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [DiaChi], [GioiTinh], [SDT], [ChucVu]) VALUES (N'NV4', N'Lê Ngọc Chi', N'Đội cấn, Hà Nội', N'Nữ', N'0123456789', N'Nhân viên')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [DiaChi], [GioiTinh], [SDT], [ChucVu]) VALUES (N'NV5', N'Dương Văn Duy', N'Hà Đông, Hà Nội', N'Không xác định', N'0123456789', N'Nhân viên')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [DiaChi], [GioiTinh], [SDT], [ChucVu]) VALUES (N'NV6', N'Hào', N'Đê La Thành, Hà Nội', N'Nữ', N'0123456789', N'Nhân viên')
GO
INSERT [dbo].[PHIEUNHAP] ([MaPN], [NgayLap], [TongTien], [MaNCC], [UserName]) VALUES (N'PN1', CAST(N'2022-04-13T00:00:00.000' AS DateTime), 11000000.0000, N'NCC1', N'Admin')
INSERT [dbo].[PHIEUNHAP] ([MaPN], [NgayLap], [TongTien], [MaNCC], [UserName]) VALUES (N'PN1911061500q', CAST(N'2022-11-19T18:15:00.077' AS DateTime), 0.0000, N'NCC1', N'Admin')
INSERT [dbo].[PHIEUNHAP] ([MaPN], [NgayLap], [TongTien], [MaNCC], [UserName]) VALUES (N'PN2', CAST(N'2022-05-16T00:00:00.000' AS DateTime), 23000000.0000, N'NCC2', N'Admin')
INSERT [dbo].[PHIEUNHAP] ([MaPN], [NgayLap], [TongTien], [MaNCC], [UserName]) VALUES (N'PN3', CAST(N'2022-04-19T00:00:00.000' AS DateTime), 20000000.0000, N'NCC3', N'TCT')
INSERT [dbo].[PHIEUNHAP] ([MaPN], [NgayLap], [TongTien], [MaNCC], [UserName]) VALUES (N'PN4', CAST(N'2022-11-13T00:00:00.000' AS DateTime), 31000000.0000, N'NCC4', N'Admin')
GO
INSERT [dbo].[TAIKHOAN] ([UserName], [PassWord], [DisplayName], [PhanQuyen]) VALUES (N'Admin', N'admin', N'Admin', 1)
INSERT [dbo].[TAIKHOAN] ([UserName], [PassWord], [DisplayName], [PhanQuyen]) VALUES (N'TCT', N'777', N'TCT', 1)
INSERT [dbo].[TAIKHOAN] ([UserName], [PassWord], [DisplayName], [PhanQuyen]) VALUES (N'vuvanhuy', N'777', N'VanHuy', 0)
GO
ALTER TABLE [dbo].[CHITIETDATMON] ADD  DEFAULT ((0)) FOR [DonGia]
GO
ALTER TABLE [dbo].[CHITIETDATMON] ADD  DEFAULT ((0)) FOR [ThanhTien]
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP] ADD  DEFAULT ((0)) FOR [DonGia]
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP] ADD  DEFAULT ((0)) FOR [ThanhTien]
GO
ALTER TABLE [dbo].[HOADON] ADD  DEFAULT (getdate()) FOR [DateCheckIn]
GO
ALTER TABLE [dbo].[HOADON] ADD  DEFAULT ((0)) FOR [TongTien]
GO
ALTER TABLE [dbo].[PHIEUNHAP] ADD  DEFAULT (getdate()) FOR [NgayLap]
GO
ALTER TABLE [dbo].[PHIEUNHAP] ADD  DEFAULT ((0)) FOR [TongTien]
GO
ALTER TABLE [dbo].[TAIKHOAN] ADD  CONSTRAINT [df_pass]  DEFAULT ('123') FOR [PassWord]
GO
ALTER TABLE [dbo].[CHITIETDATMON]  WITH CHECK ADD FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOADON] ([MaHD])
GO
ALTER TABLE [dbo].[CHITIETDATMON]  WITH CHECK ADD FOREIGN KEY([MaMA])
REFERENCES [dbo].[MONAN] ([MaMA])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP]  WITH CHECK ADD FOREIGN KEY([MaNL])
REFERENCES [dbo].[NGUYENLIEU] ([MaNL])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP]  WITH CHECK ADD FOREIGN KEY([MaPN])
REFERENCES [dbo].[PHIEUNHAP] ([MaPN])
GO
ALTER TABLE [dbo].[CONGTHUC]  WITH CHECK ADD FOREIGN KEY([MaMA])
REFERENCES [dbo].[MONAN] ([MaMA])
GO
ALTER TABLE [dbo].[CONGTHUC]  WITH CHECK ADD FOREIGN KEY([MaNL])
REFERENCES [dbo].[NGUYENLIEU] ([MaNL])
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD FOREIGN KEY([MaBan])
REFERENCES [dbo].[BANAN] ([MaBan])
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD FOREIGN KEY([UserName])
REFERENCES [dbo].[TAIKHOAN] ([UserName])
GO
ALTER TABLE [dbo].[MONAN]  WITH CHECK ADD FOREIGN KEY([MaLM])
REFERENCES [dbo].[LOAIMON] ([MaLM])
GO
ALTER TABLE [dbo].[NGUYENLIEU]  WITH CHECK ADD FOREIGN KEY([MaLNL])
REFERENCES [dbo].[LOAINGUYENLIEU] ([MaLNL])
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NHACUNGCAP] ([MaNCC])
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD FOREIGN KEY([UserName])
REFERENCES [dbo].[TAIKHOAN] ([UserName])
GO
/****** Object:  Trigger [dbo].[CapNhatTonKhoVaHD]    Script Date: 22/11/2022 8:09:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   TRIGGER [dbo].[CapNhatTonKhoVaHD] ON [dbo].[CHITIETDATMON]
FOR INSERT, UPDATE, DELETE AS
BEGIN
	DECLARE @MaMAIn nvarchar(25), @MaMADe nvarchar(25), @SLIn int, @SLDe int,
	@MaHDIn nvarchar(25), @MaHDDe nvarchar(25), @DGIn Money, @DGDe Money
	SELECT @SLIn = SoLuong, @MaMAIn = MaMA, @MaHDIn = MaHD, @DGIn = DonGia FROM inserted
	SELECT @SLDe = SoLuong, @MaMADe = MaMA, @MaHDDe = MaHD, @DGDe = DonGia FROM deleted

	UPDATE NGUYENLIEU
	SET SoLuong = SoLuong - ISNULL((SELECT SoLuong * (ISNULL(@SLIn, 0) - ISNULL(@SLDe, 0))
							FROM CONGTHUC
							WHERE CONGTHUC.MaMA = ISNULL(@MaMAIn, @MaMADe) AND CONGTHUC.MaNL = NGUYENLIEU.MaNL), 0)
	UPDATE HoaDon 
	SET TongTien = ISNULL(TongTien, 0) + ISNULL(@DGIn * @SLIn, 0) - ISNULL(@DGDe * @SLDe, 0)
	WHERE MaHD = ISNULL(@MaHDIn, @MaHDDe)
	IF EXISTS(SELECT * FROM NGUYENLIEU WHERE SoLuong < 0)
		ROLLBACK TRAN 
END
GO
ALTER TABLE [dbo].[CHITIETDATMON] ENABLE TRIGGER [CapNhatTonKhoVaHD]
GO
/****** Object:  Trigger [dbo].[ThemMA]    Script Date: 22/11/2022 8:09:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   TRIGGER [dbo].[ThemMA] ON [dbo].[CHITIETDATMON]
INSTEAD OF INSERT AS
BEGIN
	DECLARE @DonGia int, @MaMA nvarchar(25), @SL int, @MaHD nvarchar(25), @SLHT int;
	SELECT @MaHD = MaHD, @MaMA = inserted.MaMA, @DonGia = MONAN.DonGia, @SL = SoLuong FROM inserted JOIN MONAN ON inserted.MaMA = MONAN.MaMA
	SELECT @SLHT = ISNULL((SELECT SoLuong FROM CHITIETDATMON WHERE MaMA = @MaMA AND MaHD = @MaHD), 0)
	IF (@SLHT = 0)
		BEGIN
			IF (@SL > 0)
				INSERT CHITIETDATMON (MaHD, MaMA, DonGia, SoLuong, ThanhTien) VALUES (@MaHD, @MaMA, @DonGia, @SL, @DonGia * @SL)
		END
	ELSE
		BEGIN
			IF (@SL + @SLHT > 0)
				UPDATE CHITIETDATMON SET SoLuong = SoLuong + @SL, DonGia = @DonGia, ThanhTien = @DonGia * (@SL + @SLHT) WHERE MaMA = @MaMA AND MaHD = @MaHD
			ELSE
				DELETE CHITIETDATMON WHERE MaMA = @MaMA AND MaHD = @MaHD
		END
END
GO
ALTER TABLE [dbo].[CHITIETDATMON] ENABLE TRIGGER [ThemMA]
GO
/****** Object:  Trigger [dbo].[CapNhatKhoPN]    Script Date: 22/11/2022 8:09:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[CapNhatKhoPN] ON [dbo].[CHITIETPHIEUNHAP]
FOR INSERT, UPDATE, DELETE AS
BEGIN
	DECLARE @MaNLIn nvarchar(25), @MaNLDe nvarchar(25), @SLIn int, @SLDe int,
	@MaPNIn nvarchar(25), @MaPNDe nvarchar(25), @DGIn Money, @DGDe Money
	SELECT @SLIn = SoLuong, @MaNLIn = MaNL, @MaPNIn = MaPN, @DGIn = DonGia FROM inserted
	SELECT @SLDe = SoLuong, @MaNLDe = MaNL, @MaPNDe = MaPN, @DGDe = DonGia FROM deleted
	UPDATE NGUYENLIEU
	SET SoLuong = SoLuong + (ISNULL(@SLIn, 0) - ISNULL(@SLDe, 0))
	WHERE MaNL = ISNULL(@MaNLIn, @MaNLDe)
	UPDATE PHIEUNHAP 
	SET TongTien = ISNULL((SELECT SUM(THANHTIEN)
						  FROM CHITIETPHIEUNHAP
						  WHERE PHIEUNHAP.MaPN = CHITIETPHIEUNHAP.MaPN), 0)
END
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP] ENABLE TRIGGER [CapNhatKhoPN]
GO
/****** Object:  Trigger [dbo].[ThemNL]    Script Date: 22/11/2022 8:09:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   TRIGGER [dbo].[ThemNL] ON [dbo].[CHITIETPHIEUNHAP]
INSTEAD OF INSERT AS
BEGIN
	DECLARE @DonGia int, @MaNL nvarchar(25), @SL int, @MaPN nvarchar(25), @SLHT int;
	SELECT @MaPN = MaPN, @MaNL = inserted.MaNL, @DonGia = DonGia, @SL = inserted.SoLuong FROM inserted JOIN NGUYENLIEU ON inserted.MaNL = NGUYENLIEU.MaNL
	SELECT @SLHT = ISNULL((SELECT SoLuong FROM CHITIETPHIEUNHAP WHERE MaNL = @MaNL AND MaPN = @MaPN), 0)
	IF (@SLHT = 0)
		BEGIN
			IF (@SL > 0)
				INSERT CHITIETPHIEUNHAP (MaPN, MaNL, DonGia, SoLuong, ThanhTien) VALUES (@MaPN, @MaNL, @DonGia, @SL, @DonGia * @SL)
		END
	ELSE
		BEGIN
			IF (@SL + @SLHT > 0)
				UPDATE CHITIETPHIEUNHAP SET SoLuong = SoLuong + @SL, DonGia = @DonGia, ThanhTien = @DonGia * (@SL + @SLHT) WHERE MaNL = @MaNL AND MaPN = @MaPN
			ELSE
				DELETE CHITIETPHIEUNHAP WHERE MaNL = @MaNL AND MaPN = @MaPN
		END
END
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP] ENABLE TRIGGER [ThemNL]
GO
/****** Object:  Trigger [dbo].[CNTTBan]    Script Date: 22/11/2022 8:09:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   TRIGGER [dbo].[CNTTBan] ON [dbo].[HOADON]
FOR INSERT, UPDATE, DELETE AS
BEGIN
	DECLARE @MaBan1 nvarchar(25), @D1In DATETIME, @D1Out DATETIME, @D2In DATETIME, @D2Out DATETIME,
	@MaBan2 nvarchar(25)
	SELECT @MaBan1 = MaBan, @D1In = DateCheckIn, @D1Out = DateCheckOut FROM inserted
	SELECT @MaBan2 = MaBan, @D2In = DateCheckIn, @D2Out = DateCheckOut FROM deleted
	IF @D1OUT IS NULL
		UPDATE BANAN SET TinhTrang = N'Có người' WHERE MaBan = @MaBan1
	IF @D1OUT IS NOT NULL AND @D2Out IS NULL
		UPDATE BANAN SET TinhTrang = N'Trống' WHERE MaBan = @MaBan2
END
GO
ALTER TABLE [dbo].[HOADON] ENABLE TRIGGER [CNTTBan]
GO
/****** Object:  Trigger [dbo].[XoaHoaDon]    Script Date: 22/11/2022 8:09:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   TRIGGER [dbo].[XoaHoaDon] ON [dbo].[HOADON]
INSTEAD OF DELETE AS
BEGIN
	DECLARE @MaHD nvarchar(25), @MaBan nvarchar(25)
	SELECT @MaHD = MaHD, @MaBan = MaBan FROM deleted
	DELETE CHITIETDATMON WHERE @MaHD = MaHD
	DELETE HoaDon WHERE MaHD = @MaHD
END
GO
ALTER TABLE [dbo].[HOADON] ENABLE TRIGGER [XoaHoaDon]
GO
/****** Object:  Trigger [dbo].[XoaPN]    Script Date: 22/11/2022 8:09:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   TRIGGER [dbo].[XoaPN] ON [dbo].[PHIEUNHAP]
INSTEAD OF DELETE AS
BEGIN
	DECLARE @MaPN nvarchar(25), @MaBan nvarchar(25)
	SELECT @MaPN = MaPN FROM deleted
	DELETE CHITIETPHIEUNHAP WHERE @MaPN = MaPN
	DELETE PHIEUNHAP WHERE MaPN = @MaPN
END
GO
ALTER TABLE [dbo].[PHIEUNHAP] ENABLE TRIGGER [XoaPN]
GO
