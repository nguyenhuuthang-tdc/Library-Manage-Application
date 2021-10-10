CREATE DATABASE QuanLyThuVien
GO
USE QuanLyThuVien
GO
SET DATEFORMAT dmy;
GO
CREATE TABLE BanDoc
(
MaBD char(4) not null,
TenBD nvarchar(30) not null,
NgaySinh date,
GioiTinh nvarchar(3),
DoiTuong nvarchar(20),
DiaChi nvarchar(50),
Sdt char(10),
CONSTRAINT PK_BanDoc PRIMARY KEY (MaBD)
)
GO
CREATE TABLE LoaiSach
(
MaLoai char(4) not null,
TenLoai nvarchar(30) not null,
CONSTRAINT PK_LoaiSach PRIMARY KEY (MaLoai)
)
GO
CREATE TABLE Sach
(
MaSach char(4) not null,
TenSach nvarchar(50) not null,
MaLoai char(4) not null,
KeSach char(4),
DonGia int,
SoLuong int,
MaNXB char(4),
CONSTRAINT PK_Sach PRIMARY KEY (MaSach)
)
GO
CREATE TABLE MuonSach
(
MaMuon char(4),
MaBD char(4) not null,
NgayMuon date,
NgayTra date,
TrangThai nvarchar(50),
CONSTRAINT PK_MuonSach PRIMARY KEY (MaMuon)
)
GO
CREATE TABLE DangNhap
(
TenTK char(10) UNIQUE,
TenThuThu nvarchar(50),
MatKhau char(10),
CONSTRAINT PK_TenTK PRIMARY KEY (TenTK)
)
GO
CREATE TABLE ChiTietMuon
(
MaMuon char(4),
MaSach char(4),
SoLuong int,
CONSTRAINT PK_ChiTietMuon PRIMARY KEY (MaMuon,MaSach)
)
GO
CREATE TABLE ChiTietTra
(
MaMuon char(4),
MaSach char(4),
SoLuong int,
NgayTraThucTe date,
CONSTRAINT PK_ChiTietTra PRIMARY KEY (MaMuon,MaSach)
)
GO
CREATE TABLE NhaXuatBan
(
MaNXB char(4),
TenNXB nvarchar(50),
DiaChi nvarchar(50),
Sdt char(10),
CONSTRAINT PK_NXB PRIMARY KEY (MaNXB)
)
GO
ALTER TABLE MuonSach --drop
ADD CONSTRAINT FK_MS1 FOREIGN KEY (MaBD) REFERENCES BanDoc(MaBD)
--drop
ALTER TABLE MuonSach
drop constraint FK_MS1
--
ALTER TABLE MuonSach
ADD CONSTRAINT FK_MS2 FOREIGN KEY (TenTK) REFERENCES DangNhap(TenTK)
ALTER TABLE ChiTietMuon
ADD CONSTRAINT FK_CTM1 FOREIGN KEY (MaMuon) REFERENCES MuonSach(MaMuon)
--drop
ALTER TABLE ChiTietMuon
drop CONSTRAINT FK_CTM1
--
ALTER TABLE ChiTietMuon
ADD CONSTRAINT FK_CTM2 FOREIGN KEY (MaSach) REFERENCES Sach(MaSach)
ALTER TABLE ChiTietTra
ADD CONSTRAINT FK_CTT1 FOREIGN KEY (MaMuon) REFERENCES MuonSach(MaMuon)
--drop
ALTER TABLE ChiTietTra
drop CONSTRAINT FK_CTT1
--
ALTER TABLE ChiTietTra
ADD CONSTRAINT FK_CTT2 FOREIGN KEY (MaSach) REFERENCES Sach(MaSach)
ALTER TABLE Sach
ADD CONSTRAINT FK_Sach1 FOREIGN KEY (MaLoai) REFERENCES LoaiSach(MaLoai)
ALTER TABLE Sach
ADD CONSTRAINT FK_Sach2 FOREIGN KEY (MaNXB) REFERENCES NhaXuatBan(MaNXB)
GO

INSERT INTO DangNhap
VALUES ('tiennguvc','Nguyen Minh Tien Oc Cho Vc','12345')
GO


--TABLE BẠN ĐỌC
--Thêm Bạn Đọc
CREATE PROC sp_ThemBanDoc(@MaBD char(4), @TenBD nvarchar(30), @NgaySinh date, @GioiTinh nvarchar(3), @DoiTuong nvarchar(20), @DiaChi nvarchar(50), @Sdt char(10))
AS
INSERT INTO BanDoc
VALUES (@MaBD, @TenBD, @NgaySinh, @GioiTinh, @DoiTuong, @DiaChi, @Sdt)
GO
--Hiển Thị Bạn Đọc
CREATE PROC sp_HienThiBanDoc
AS
SELECT * FROM BanDoc
GO
--tim ban doc theo ma 
CREATE PROC sp_TimBanDocTheoMa(@MaBD char(4))
AS
SELECT * FROM BanDoc
WHERE MaBD = @MaBD
GO
--Xóa Bạn Đọc
CREATE PROC sp_XoaBanDoc(@MaBD char(4))
AS
DELETE FROM BanDoc
WHERE MaBD = @MaBD
GO
--Sửa Bạn Đọc 
CREATE PROC sp_SuaBanDoc(@MaBD char(4), @TenBD nvarchar(30), @NgaySinh date, @GioiTinh nvarchar(3), @DoiTuong nvarchar(20), @DiaChi nvarchar(50), @Sdt char(10))
AS
UPDATE BanDoc
SET TenBD = @TenBD, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, DoiTuong = @DoiTuong, DiaChi = @DiaChi, Sdt = @Sdt
WHERE MaBD = @MaBD
GO

--TABLE LOẠI SÁCH 
--Thêm Loại Sách
CREATE PROC sp_ThemLoaiSach(@MaLoai char(4), @TenLoai nvarchar(30))
AS
INSERT INTO LoaiSach
VALUES (@MaLoai, @TenLoai)
GO
EXEC sp_ThemLoaiSach 'CB', N'Cơ Bản'
EXEC sp_ThemLoaiSach 'CT', N'Chính Trị'
GO
--Hiển Thị Loại Sách
CREATE PROC sp_HienThi
AS
SELECT * FROM LoaiSach
GO
--Xoá Loại Sách
CREATE PROC sp_XoaLoaiSach(@MaLoai char(4))
AS
DELETE FROM LoaiSach
WHERE @MaLoai = MaLoai
GO
--Sửa Loại Sách
CREATE PROC sp_SuaLoaiSach(@MaLoai char(4), @TenLoai nvarchar(30))
AS
UPDATE LoaiSach
SET TenLoai = @TenLoai
WHERE MaLoai = @MaLoai
GO


--TABLE SÁCH
--Thêm Sách
CREATE PROC sp_ThemSach(@MaSach char(4), @TenSach nvarchar(50), @MaLoai char(4), @KeSach char(4), @DonGia int, @SoLuong int, @MaNXB char(4))
AS
INSERT INTO Sach
VALUES (@MaSach, @TenSach, @MaLoai, @KeSach, @DonGia, @SoLuong, @MaNXB)
GO
--Hiển Thị Sách
CREATE PROC sp_HienThiSach
AS
SELECT * FROM Sach
GO
--Xoá Sách
CREATE PROC sp_XoaSach(@MaSach char(4))
AS
DELETE FROM Sach
WHERE MaSach = @MaSach
GO
--Sửa Mượn Sách
CREATE PROC sp_SuaSach(@MaSach char(4), @TenSach nvarchar(50), @MaLoai char(4), @KeSach char(4), @DonGia int, @SoLuong int, @MaNXB char(4))
AS
UPDATE Sach
SET TenSach = @TenSach, MaLoai = @MaLoai, KeSach = @KeSach, DonGia = @DonGia, SoLuong = @SoLuong, MaNXB = @MaNXB
WHERE MaSach = @MaSach
GO


--TABLE MƯỢN SÁCH
--Thêm Mượn Sách
CREATE PROC sp_ThemMuonSach(@MaMuon char(4),@MaBD char(4), @NgayMuon date, @NgayTra date,@TrangThai nvarchar(50))
AS
INSERT INTO MuonSach
VALUES (@MaMuon, @MaBD, @NgayMuon, @NgayTra,@TrangThai)
GO
--drop proc sp_ThemMuonSach
--Hiển Thị Mượn Sách
CREATE PROC sp_HienThiMuonSach
AS
SELECT * FROM MuonSach
GO
--Xoá Mượn Sách
CREATE PROC sp_XoaMuonSach(@MaMuon char(4))
AS
DELETE FROM MuonSach
WHERE MaMuon = @MaMuon
GO
--Sửa Mượn Sách
CREATE PROC sp_SuaMuonSach(@MaMuon char(4),@MaBD char(4), @NgayMuon date, @NgayTra date, @TrangThai nvarchar(50))
AS
UPDATE MuonSach
SET MaBD = @MaBD, NgayMuon = @NgayMuon, NgayTra = @NgayTra, TrangThai = @TrangThai
WHERE MaMuon = @MaMuon 
GO
--TABLE NHÀ XUẤT BẢN
--Thêm Nhà Xuất Bản
CREATE PROC sp_ThemNXB (@MaNXB char(4), @TenNXB nvarchar(50), @DiaChi nvarchar(50), @Sdt char(10))
AS
INSERT INTO NhaXuatBan
VALUES (@MaNXB, @TenNXB, @DiaChi, @Sdt)
GO
--Hiển Thị Nhà Xuất Bản
CREATE PROC sp_HienThiNXB
AS
SELECT * FROM NhaXuatBan
GO
--Xóa Nhà Xuất Bản
CREATE PROC sp_XoaNXB(@MaNXB char(4))
AS
DELETE FROM NhaXuatBan
WHERE MaNXB = @MaNXB
GO
--Sửa Nhà Xuất Bản
CREATE PROC sp_SuaNXB(@MaNXB char(4), @TenNXB nvarchar(50), @DiaChi nvarchar(50), @Sdt char(10))
AS
UPDATE NhaXuatBan
SET TenNXB= @TenNXB, DiaChi = @DiaChi, Sdt = @Sdt
WHERE MaNXB = @MaNXB 
GO


--TABLE Chi Tiết Mượn
--Hiển Thị Chi Tiết Mượn
CREATE PROC sp_HienThiChiTietMuon
AS
SELECT * FROM ChiTietMuon
GO
--Thêm Chi Tiết Mượn 
CREATE PROC sp_ThemCTMuon(@MaMuon char(4), @MaSach char(4), @SoLuong int)
AS
INSERT INTO ChiTietMuon
VALUES (@MaMuon, @MaSach, @SoLuong)
GO
--Xoá Chi Tiết Mượn
CREATE PROC sp_XoaChiTietMuon(@MaMuon char(4))
AS
DELETE FROM ChiTietMuon
WHERE MaMuon = @MaMuon
GO
--Sửa Chi Tiết Mượn
CREATE PROC sp_SuaCTMuon(@MaMuon char(4), @MaSach char(4), @SoLuong int)
AS
UPDATE ChiTietMuon
SET MaSach = @MaSach, SoLuong = @SoLuong
WHERE MaMuon = @MaMuon
GO


--TABLE Chi Tiết Trả
--Hiển Thị Chi Tiết Tra
CREATE PROC sp_HienThiChiTietTra
AS
SELECT * FROM ChiTietTra
GO
--Thêm Chi Tiết Trả 
CREATE PROC sp_ThemCTTra(@MaMuon char(4), @MaSach char(4), @SoLuong int, @NgayTraThucTe date)
AS
INSERT INTO ChiTietTra
VALUES (@MaMuon, @MaSach, @SoLuong, @NgayTraThucTe)
GO
--Xoá Chi Tiết Trả
CREATE PROC sp_XoaChiTietTra(@MaMuon char(4))
AS
DELETE FROM ChiTietTra
WHERE MaMuon = @MaMuon
GO
--Sửa Chi Tiết Trả
CREATE PROC sp_SuaCTTra(@MaMuon char(4), @MaSach char(4), @SoLuong int, @NgayTraThucTe date)
AS
UPDATE ChiTietTra
SET MaSach = @MaSach, SoLuong = @SoLuong, NgayTraThucTe = @NgayTraThucTe
WHERE MaMuon = @MaMuon
GO

--Đăng Nhập
CREATE PROC sp_LayThongTinAdmin(@TenTk char(10), @MatKhau char(10))
AS
SELECT * From DangNhap WHERE TenTK = @TenTk AND MatKhau = @MatKhau
GO
CREATE PROC sp_Login(@TenTk char(10), @MatKhau char(10))
AS
UPDATE DangNhap
SET TenTK = @TenTk, MatKhau = @MatKhau
WHERE TenTK = @TenTk AND MatKhau = @MatKhau
GO
--sua mat khau
CREATE PROC sp_SuaMatKhau(@TenTk char(10), @MatKhau char(10)) -- này là mk mới. giống tên tk thì đổi.
AS
UPDATE DangNhap
SET  MatKhau = @MatKhau
WHERE TenTK LIKE @TenTk
GO
CREATE PROC sp_Them(@TenTk char(10),@TenThuThu nvarchar(50), @MatKhau char(10))
AS
INSERT INTO DangNhap 
VALUES(@TenTk,@TenThuThu,@MatKhau)
GO
CREATE PROC sp_TenThuThu(@TenTk char(10),@TenThuThu nvarchar(50), @MatKhau char(10))
AS
SELECT TenThuThu FROM DangNhap
WHERE TenTK = @TenTk AND MatKhau = @MatKhau
--TIM KIEM THONG TIN THEO NAME
--TIM KIEM BAN DOC
GO
CREATE PROC sp_FindBanDoc(@key nvarchar(30))
AS 
SELECT * FROM BanDoc
WHERE TenBD LIKE '%'+ @key +'%'
GO
--TIM KIEM LOAI SACH
GO
CREATE PROC sp_FindLoaiSach(@key nvarchar(30))
AS 
SELECT * FROM LoaiSach
WHERE TenLoai LIKE '%'+ @key +'%'
GO
--TIM KIEM SACH
GO
CREATE PROC sp_FindSach(@key nvarchar(50))
AS 
SELECT * FROM Sach
WHERE TenSach LIKE '%'+ @key +'%'
GO
--TIM KIEM PHIEU MUON
GO
CREATE PROC sp_FindPhieuMuon(@MaMuon char(4))
AS 
--IN PHIEU MUON
GO 
CREATE PROC sp_InPhieuMuonTheoMa(@MaMuon char(4))
AS
SELECT BanDoc.TenBD,BanDoc.GioiTinh,BanDoc.DiaChi,BanDoc.Sdt,Sach.TenSach,ChiTietMuon.SoLuong,MuonSach.NgayMuon,MuonSach.NgayTra
From ChiTietMuon,MuonSach,BanDoc,Sach
WHERE MuonSach.MaMuon = ChiTietMuon.MaMuon AND MuonSach.MaBD = BanDoc.MaBD AND Sach.MaSach = ChiTietMuon.MaSach AND ChiTietMuon.MaMuon = @MaMuon
GO
--IN PHIEU TRA
GO 
CREATE PROC sp_InPhieuTraTheoMa(@MaMuon char(4))
AS
SELECT BanDoc.TenBD,BanDoc.GioiTinh,BanDoc.DiaChi,BanDoc.Sdt,Sach.TenSach,ChiTietTra.SoLuong,ChiTietTra.NgayTraThucTe
From ChiTietTra,MuonSach,BanDoc,Sach
WHERE MuonSach.MaMuon = ChiTietTra.MaMuon AND MuonSach.MaBD = BanDoc.MaBD AND Sach.MaSach = ChiTietTra.MaSach AND ChiTietTra.MaMuon = @MaMuon
GO

--CAP NHAT SO LUONG SACH SAU KHI IN PHIEU MUON
CREATE PROC sp_UpdateTotalOfBook(@MaSach char(4),@SoLuong int)
AS 
UPDATE Sach
SET SoLuong = SoLuong - @SoLuong
WHERE MaSach = @MaSach
GO
--CAP NHAT SO LUONG SACH SAU KHI IN PHIEU TRA
CREATE PROC sp_UpdateTotalOfBookTra(@MaSach char(4),@SoLuong int)
AS 
UPDATE Sach
SET SoLuong = SoLuong + @SoLuong
WHERE MaSach = @MaSach
GO
--In Danh sach tre han tra sach
CREATE PROC sp_TreHan
AS 
SELECT BanDoc.MaBD, BanDoc.TenBD, BanDoc.DiaChi,BanDoc.Sdt,MuonSach.NgayTra
FROM ChiTietMuon,MuonSach,BanDoc
WHERE MuonSach.MaMuon = ChiTietMuon.MaMuon AND BanDoc.MaBD = MuonSach.MaBD AND MuonSach.NgayTra < GETDATE()


