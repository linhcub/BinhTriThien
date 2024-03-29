-- Loại Tài Khoản
INSERT [dbo].[LoaiTaiKhoan] ([Id], [Ma], [Ten], [CapDo]) VALUES (1, N'TK01', N'Admin', 1)
INSERT [dbo].[LoaiTaiKhoan] ([Id], [Ma], [Ten], [CapDo]) VALUES (2, N'TK02', N'Giám Đốc', 2)
INSERT [dbo].[LoaiTaiKhoan] ([Id], [Ma], [Ten], [CapDo]) VALUES (3, N'TK03', N'Phó Giám Đốc', 3)
INSERT [dbo].[LoaiTaiKhoan] ([Id], [Ma], [Ten], [CapDo]) VALUES (4, N'TK04', N'Trưởng Phòng', 4)
INSERT [dbo].[LoaiTaiKhoan] ([Id], [Ma], [Ten], [CapDo]) VALUES (5, N'TK05', N'Phó Phòng', 5)
INSERT [dbo].[LoaiTaiKhoan] ([Id], [Ma], [Ten], [CapDo]) VALUES (6, N'TK06', N'Cung Trưởng', 4)
INSERT [dbo].[LoaiTaiKhoan] ([Id], [Ma], [Ten], [CapDo]) VALUES (9, N'TK07', N'Cung Phó', 5)
INSERT [dbo].[LoaiTaiKhoan] ([Id], [Ma], [Ten], [CapDo]) VALUES (10, N'TK08', N'Nhân Viên', 6)


-- Bậc Xếp Hạng
INSERT [dbo].[BacXepHang] ([Id], [Ma], [Ten], [HeSoLuong]) VALUES (1, N'BXH01', N'Bậc 1', CAST(1.00 AS Decimal(5, 2)))
INSERT [dbo].[BacXepHang] ([Id], [Ma], [Ten], [HeSoLuong]) VALUES (2, N'BXH02', N'Bậc 2', CAST(1.50 AS Decimal(5, 2)))
INSERT [dbo].[BacXepHang] ([Id], [Ma], [Ten], [HeSoLuong]) VALUES (3, N'BXH03', N'Bậc 3', CAST(2.00 AS Decimal(5, 2)))
INSERT [dbo].[BacXepHang] ([Id], [Ma], [Ten], [HeSoLuong]) VALUES (4, N'BXH04', N'Bậc 4', CAST(2.50 AS Decimal(5, 2)))
INSERT [dbo].[BacXepHang] ([Id], [Ma], [Ten], [HeSoLuong]) VALUES (5, N'BXH05', N'Bậc 5', CAST(3.00 AS Decimal(5, 2)))

-- Phòng
INSERT [dbo].[Phong] ([Id], [Ma], [Ten], [TruongPhong], [PhoPhong]) VALUES (1, N'P001', N'Kỹ Thuật', NULL, NULL)
INSERT [dbo].[Phong] ([Id], [Ma], [Ten], [TruongPhong], [PhoPhong]) VALUES (2, N'P002', N'Kế Toán', NULL, NULL)
INSERT [dbo].[Phong] ([Id], [Ma], [Ten], [TruongPhong], [PhoPhong]) VALUES (3, N'P003', N'Trạm Thông Tin', NULL, NULL)
INSERT [dbo].[Phong] ([Id], [Ma], [Ten], [TruongPhong], [PhoPhong]) VALUES (4, N'P004', N'Tổng Đài', NULL, NULL)

-- Cung
INSERT [dbo].[Cung] ([Id], [Ma], [Ten], [CungTruong], [CungPho], [AnToanVeSinhVien], [CongDoanVien]) VALUES (1, N'C001', N'Huế', NULL, NULL, NULL, NULL)
INSERT [dbo].[Cung] ([Id], [Ma], [Ten], [CungTruong], [CungPho], [AnToanVeSinhVien], [CongDoanVien]) VALUES (2, N'C002', N'Phò Trạch', NULL, NULL, NULL, NULL)
INSERT [dbo].[Cung] ([Id], [Ma], [Ten], [CungTruong], [CungPho], [AnToanVeSinhVien], [CongDoanVien]) VALUES (3, N'C003', N'Quảng Trị', NULL, NULL, NULL, NULL)
INSERT [dbo].[Cung] ([Id], [Ma], [Ten], [CungTruong], [CungPho], [AnToanVeSinhVien], [CongDoanVien]) VALUES (4, N'C004', N'Đông Hà', NULL, NULL, NULL, NULL)
INSERT [dbo].[Cung] ([Id], [Ma], [Ten], [CungTruong], [CungPho], [AnToanVeSinhVien], [CongDoanVien]) VALUES (5, N'C005', N'Sa Lung', NULL, NULL, NULL, NULL)
INSERT [dbo].[Cung] ([Id], [Ma], [Ten], [CungTruong], [CungPho], [AnToanVeSinhVien], [CongDoanVien]) VALUES (6, N'C006', N'Mỹ Đức', NULL, NULL, NULL, NULL)
INSERT [dbo].[Cung] ([Id], [Ma], [Ten], [CungTruong], [CungPho], [AnToanVeSinhVien], [CongDoanVien]) VALUES (7, N'C007', N'Đồng Hới', NULL, NULL, NULL, NULL)

-- Ga
INSERT [dbo].[Ga] ([Id], [Ma], [Ten], [DiaChi], [CungId]) VALUES (1, N'G001', N'Huế', NULL, 1)
INSERT [dbo].[Ga] ([Id], [Ma], [Ten], [DiaChi], [CungId]) VALUES (2, N'G002', N'Truồi', NULL, 1)
INSERT [dbo].[Ga] ([Id], [Ma], [Ten], [DiaChi], [CungId]) VALUES (3, N'G003', N'Phò Trạch', NULL, 2)
INSERT [dbo].[Ga] ([Id], [Ma], [Ten], [DiaChi], [CungId]) VALUES (4, N'G004', N'Văn Xá', NULL, 2)
INSERT [dbo].[Ga] ([Id], [Ma], [Ten], [DiaChi], [CungId]) VALUES (5, N'G005', N'Hiền Sỹ', NULL, 2)
INSERT [dbo].[Ga] ([Id], [Ma], [Ten], [DiaChi], [CungId]) VALUES (6, N'G006', N'Quảng Trị', NULL, 3)
INSERT [dbo].[Ga] ([Id], [Ma], [Ten], [DiaChi], [CungId]) VALUES (7, N'G007', N'Diên Sanh', NULL, 3)
INSERT [dbo].[Ga] ([Id], [Ma], [Ten], [DiaChi], [CungId]) VALUES (8, N'G008', N'Mỹ Chánh', NULL, 3)
INSERT [dbo].[Ga] ([Id], [Ma], [Ten], [DiaChi], [CungId]) VALUES (9, N'G009', N'Đông Hà', NULL, 4)
INSERT [dbo].[Ga] ([Id], [Ma], [Ten], [DiaChi], [CungId]) VALUES (10, N'G010', N'Hà Thanh', NULL, 4)
INSERT [dbo].[Ga] ([Id], [Ma], [Ten], [DiaChi], [CungId]) VALUES (11, N'G011', N'Tiên An', NULL, 4)
INSERT [dbo].[Ga] ([Id], [Ma], [Ten], [DiaChi], [CungId]) VALUES (12, N'G012', N'Thượng Lâm', NULL, 5)
INSERT [dbo].[Ga] ([Id], [Ma], [Ten], [DiaChi], [CungId]) VALUES (13, N'G013', N'Sa Lung', NULL, 5)
INSERT [dbo].[Ga] ([Id], [Ma], [Ten], [DiaChi], [CungId]) VALUES (14, N'G014', N'Mỹ Đức', NULL, 6)
INSERT [dbo].[Ga] ([Id], [Ma], [Ten], [DiaChi], [CungId]) VALUES (15, N'G015', N'Đồng Hới', NULL, 7)

-- Nhân Viên
INSERT [dbo].[NhanVien] ([Id], [Ma], [MatKhau], [Ho], [Ten], [DiaChi], [Email], [DienThoaiDiDong], [DienThoaiCoDinh], [LoaiTaiKhoanId], [BacXepHangId], [AnhDaiDien], [CungId], [PhongId]) VALUES (1, N'NV00001', N'123456', N'Le Van', N'Linh', N'Japan, Saitama, Warabi', N'levanlinhcube@gmail.com', N'12345', N'1234123123213', 1, NULL, NULL, 1, 1)
INSERT [dbo].[NhanVien] ([Id], [Ma], [MatKhau], [Ho], [Ten], [DiaChi], [Email], [DienThoaiDiDong], [DienThoaiCoDinh], [LoaiTaiKhoanId], [BacXepHangId], [AnhDaiDien], [CungId], [PhongId]) VALUES (2, N'NV00002', N'123456', N'Le Duy', N'Khanh', N'', N'', N'', N'', 2, NULL, NULL, 2, NULL)