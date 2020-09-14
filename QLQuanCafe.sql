CREATE DATABASE QuanLyQuanCafe
GO

USE QuanLyQuanCafe
GO

--Thực Đơn
CREATE TABLE ThucDon
(
	Id INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	Name NVARCHAR(100)
)
GO
--Món
CREATE TABLE Mon
(
	Id INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	TenMon NVARCHAR(100),
	GiaBan FLOAT,
	IdThucDon INT --khóa ngoại đến bảng ThucDon  
)
GO
--Bàn
CREATE TABLE Ban
(
	Id INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	Name NVARCHAR(100),
	TrangThai NVARCHAR(100) DEFAULT N'Trống'   --Trống || Có người
)
GO
--Tài Khoản
CREATE TABLE TaiKhoan
(
	UserName VARCHAR(100) NOT NULL PRIMARY KEY,
	FullName NVARCHAR(100),
	MatKhau VARCHAR(1000) NOT NULL,
	HoatDong INT DEFAULT 1,  -- 1: Bình Thường , 0: Đã bị khóa
	PhanQuyen INT DEFAULT 0  -- 1: Admin , 0: Nhân viên (mặc định là nhân viên)
)
GO
--Hóa Đơn
CREATE TABLE HoaDon
(
	Id INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	TimeCheckIn DATETIME NOT NULL DEFAULT GETDATE(),
	TimeCheckOut DATETIME,
	TrangThai INT DEFAULT 0,	-- 1: Đã thanh toán , 0: chưa thanh toán (mặc định là chưa tt)
	IdBan INT,					--khóa ngoại đến bảng BÀN
	NguoiLap VARCHAR(100)       --Khóa ngoại đến bảng (TaiKhoan) để biết nhân viên nào đã lập hóa đơn này
)
GO
ALTER TABLE HoaDon
ADD TongTien float

ALTER TABLE HoaDon
ADD GiamGia float
GO
--Chi Tiết Hóa Đơn
CREATE TABLE ChiTietHoaDon
(
	IdHoaDon INT NOT NULL,
	IdMon INT NOT NULL,
	SoLuong INT DEFAULT 0,
	CONSTRAINT PK_CTHD PRIMARY KEY(IdHoaDon,IdMon)
)
GO
ALTER TABLE ChiTietHoaDon
ADD ThanhTien float default null
 
GO
CREATE trigger ThanhTienCTHD on ChiTietHoaDon
    for insert, update
    as
    if update(SoLuong)
    begin
    	update ChiTietHoaDon
    	set 
    		ThanhTien = inserted.SoLuong * Mon.GiaBan
    	from 
    		inserted,
    		Mon, 
    		ChiTietHoaDon,
			HoaDon
    	where 
    		(Mon.Id = inserted.IdMon)
    		and (Mon.Id = ChiTietHoaDon.IdMon) and ChiTietHoaDon.IdHoaDon=HoaDon.Id
    end
go
	--
	
--TẠO KHÓA NGOẠI
ALTER TABLE Mon ADD CONSTRAINT FK_MON_THUCDON FOREIGN KEY (IdThucDon) REFERENCES ThucDon(Id)
GO
ALTER TABLE HoaDon ADD CONSTRAINT FK_HOADON_BAN FOREIGN KEY (IdBan) REFERENCES Ban(Id)
Go
ALTER TABLE HoaDon ADD CONSTRAINT FK_HOADON_NguoiLap FOREIGN KEY (NguoiLap) REFERENCES TaiKhoan(UserName)
GO
ALTER TABLE ChiTietHoaDon ADD CONSTRAINT FK_CTHD_IdHOADON FOREIGN KEY (IdHoaDon) REFERENCES HoaDon(Id)
GO
ALTER TABLE ChiTietHoaDon ADD CONSTRAINT FK_CTHD_IdMON FOREIGN KEY (IdMon) REFERENCES Mon(Id)
GO
--Nhập dữ liệu
SET IDENTITY_INSERT ThucDon ON;
INSERT INTO ThucDon(Id, Name) VALUES 
	(1, N'Freeze'),
	(2, N'Cà phê'),
	(3, N'Trà'),
	(4, N'Bánh mì'),
	(5, N'Khác');
SET IDENTITY_INSERT ThucDon OFF;

SET IDENTITY_INSERT Mon ON;
INSERT INTO Mon(Id, IdThucDon, TenMon, GiaBan) VALUES
	(1, 1, N'Phin Sữa Đá', 290000),
	(2, 1, N'Phin Đen Đá', 290000),
	(3, 1, N'Phin Đen Nóng', 290000),
	(4, 1, N'Phin Sữa Nóng', 290000),
	(5, 1, N'Mocha Macchiato', 590000),
	(6, 1, N'Espresso', 440000),
	(7, 1, N'Americano', 440000),
	(8, 1, N'Latte', 540000),
	(9, 2, N'Caramel Phin Freeze', 490000),
	(10, 2, N'Classic Phin Freeze', 490000),
	(11, 2, N'Freeze Trà Xanh', 490000),
	(12, 2, N'Cookies & Cream', 490000),
	(13, 2, N'Freeze Sô-cô-la', 490000),
	(14, 3, N'Trà Sen Vàng', 390000),
	(15, 3, N'Trà Thạch Vải', 39000),
	(16, 3, N'Trà Thạch Đào', 39000),
	(17, 3, N'Trà Thanh Đào', 39000),
	(18, 4, N'Thịt nướng', 19000),
	(19, 4, N'Xíu mại', 19000),
	(20, 4, N'Gà Xé Nước Tương', 19000),
	(21, 4, N'Chả lụa xá xíu', 19000),
	(22, 5, N'Bánh Mousse Cacao', 29000),
	(23, 5, N'Bánh Sô-cô-la Highlands', 29000),
	(24, 5, N'Bánh Caramel Phô Mai', 29000),
	(25, 5, N'Bánh Mousse Đào', 29000);
SET IDENTITY_INSERT Mon OFF;
GO

--Nhap lieu table Ban
DECLARE @i INT = 1
WHILE @i <= 10
BEGIN
	INSERT INTO Ban(Name) VALUES (N'Bàn ' + CAST(@i AS nvarchar(100)))
	SET @i = @i + 1
END
GO

select * from ThucDon
select * from Mon
-----------------------------------------------------------------Ngày 11/11----------------------------------------------------
--Chỉnh sửa: thêm column HoatDong Vao bảng TaiKhoan

INSERT INTO TaiKhoan(UserName,FullName,MatKhau,HoatDong,PhanQuyen) 
	VALUES ('admin',N'Bùi Vũ Trường',123456,1,1),
		('truong',N'Bùi Vũ Trường',123,1,0),
		('hao',N'Anh Hào',123,1,1),
		('thai',N'Quốc Thái',123,1,1),
		('nhanvien',N'Nhân viên 1',123,1,0)
GO
							

CREATE PROC Login
(
	@Username VARCHAR(50),
	@Password VARCHAR(MAX)
)
AS
BEGIN
	IF EXISTS(SELECT * FROM TaiKhoan WHERE UserName = @Username)
	BEGIN
		SELECT * FROM TaiKhoan WHERE UserName = @Username AND MatKhau = @Password;
		RETURN 1;
	END
		RETURN 0;
END
GO

select * from TaiKhoan 
GO

CREATE PROC UpdateThongTinCaNhan
(	
	@Username NVARCHAR(100), 
	@Fullname NVARCHAR(100), 
	@password NVARCHAR(100),
	@newpassword NVARCHAR(100)
)
AS
BEGIN
	DECLARE @isValid INT = 0
	SELECT @isValid = COUNT(*) FROM TaiKhoan WHERE UserName = @Username AND MatKhau = @password
	IF(@isValid = 1)
	BEGIN 
		IF(@newpassword = NULL OR @newpassword = '')
		BEGIN
			UPDATE TaiKhoan SET FullName = @Fullname WHERE UserName = @Username
		END
		ELSE
			UPDATE TaiKhoan SET FullName = @Fullname,MatKhau = @newpassword WHERE UserName = @Username
	END
END	
GO

CREATE PROC GetAccountByUserName
(
	@Username NVARCHAR(100)
)
AS
	SELECT * FROM TaiKhoan WHERE UserName = @Username
GO

update TaiKhoan set HoatDong = 0 where UserName = 'hao' or UserName =  'thai'
-------------------------------------------------Hao-----------------------------------------------------


-----------------------------------------------------------------------------------------------------------
SELECT * FROM MON
GO
--
CREATE PROC AddMon
(
	@TenMon NVARCHAR(100),
	@GiaBan FLOAT,
	@IdThucDon INT
)
AS
	INSERT INTO Mon(TenMon,GiaBan,IdThucDon) VALUES(@TenMon,@GiaBan,@IdThucDon)
GO

CREATE PROC UpdateMon
(
	@Id INT,
	@TenMon NVARCHAR(100),
	@GiaBan FLOAT,
	@IdThucDon INT
)
AS
	UPDATE Mon SET TenMon = @TenMon, GiaBan = @GiaBan, IdThucDon = @IdThucDon WHERE Id = @Id
GO

CREATE PROC DeleteMon
(
	@Id INT
)
AS
	DELETE FROM MON WHERE Id = @Id
GO
--


select * from HoaDon
go

--
CREATE PROC CapNhatTrangThaiBan
(
	@Id INT,
	@TrangThai Nvarchar(100)
)
AS
	UPDATE BAN SET TrangThai = @TrangThai WHERE Id = @Id
GO

--
CREATE PROC CapNhatHoaDon
(
	@Id int,
	@Time datetime,
	@TrangThai int,
	@NguoiLap varchar(100),
	@TongTien float,
	@GiamGia float
)
AS
	UPDATE HoaDon set TimeCheckOut=@Time,TrangThai=@TrangThai,NguoiLap=@NguoiLap, TongTien=@TongTien, GiamGia=@GiamGia where Id=@Id
GO
CREATE PROC XoaMonKhiOrder
(
	@IdHoaDon INT,
	@IdMon INT
)
AS
	DELETE FROM ChiTietHoaDon WHERE IdHoaDon = @IdHoaDon and IdMon = @IdMon
GO
CREATE PROC XoaHoaDonKhiXoaAllMon
(
	@Id INT
)
AS
	DELETE FROM HoaDon WHERE Id = @Id
GO

CREATE PROC GetMonTheoTen
(
	@Tenmon NVARCHAR(100)
)
AS
	SELECT * FROM Mon WHERE TenMon = @Tenmon
GO


select * from Ban
select * from HoaDon
select * from ChiTietHoaDon
GO
--
CREATE PROC AddThucDon
(
	@Name NVARCHAR(100)
)
AS
	INSERT INTO ThucDon(Name) VALUES(@Name)
GO

CREATE PROC UpdateThucDon
(
	@Id INT,
	@Name NVARCHAR(100)
)
AS
	UPDATE ThucDon SET Name = @Name WHERE Id = @Id
GO

CREATE PROC DeleteThucDon
(
	@Id INT
)
AS
	DELETE FROM ThucDon WHERE Id = @Id
GO
--
CREATE PROC AddBan
(
	@Name NVARCHAR(100)
)
AS
	INSERT INTO Ban(Name) VALUES(@Name)
GO

CREATE PROC UpdateBan
(
	@Id INT,
	@Name NVARCHAR(100)
)
AS
	UPDATE Ban SET Name = @Name WHERE Id = @Id
GO

CREATE PROC DeleteBan
(
	@Id INT
)
AS
	DELETE FROM Ban WHERE Id = @Id
GO
--
CREATE PROC ThongKeDoanhThu
(
	@FromDate DATE,
	@ToDate DATE
)
AS
BEGIN
	SELECT B.Name AS [Tên bàn], HD.TongTien AS [Tổng tiền], TimeCheckIn AS[Giờ vào], TimeCheckOut AS[Giờ ra],NguoiLap AS [Người Lập], GiamGia AS[Giảm Giá]
	FROM HoaDon AS HD, Ban AS B
	WHERE TimeCheckOut >= @FromDate AND TimeCheckOut <= @ToDate AND HD.TrangThai = 1 AND B.Id = HD.IdBan
END
GO
--
CREATE PROC AddTaiKhoan
(
	@UserName VARCHAR(100),
	@FullName NVARCHAR(100),
	@MatKhau VARCHAR(1000),
	@HoatDong INT,
	@PhanQuyen INT 
)
AS
	INSERT INTO TaiKhoan(UserName,FullName,MatKhau,HoatDong,PhanQuyen) VALUES(@UserName,@FullName,@MatKhau,@HoatDong,@PhanQuyen)
GO

CREATE PROC UpdateTaiKhoan
(
	@UserName VARCHAR(100),
	@FullName NVARCHAR(100),
	@HoatDong INT,
	@PhanQuyen INT 
)
AS
	UPDATE TaiKhoan SET FullName =  @FullName, HoatDong = @HoatDong, PhanQuyen = @PhanQuyen WHERE UserName = @UserName
GO
CREATE PROC ResetPassWord
(
	@UserName VARCHAR(100)
)
AS
	UPDATE TaiKhoan SET MatKhau = @UserName WHERE UserName = @UserName
GO
--



