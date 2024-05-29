CREATE DATABASE Do_an1
GO
USE Do_an1
-- Tạo bảng NhanVien
CREATE TABLE NhanVien (
    maNV CHAR(10) PRIMARY KEY NOT NULL,
    tenNV NVARCHAR(30) NOT NULL,
    gioiTinh NVARCHAR(10) NOT NULL,
    diaChi NVARCHAR(50) NOT NULL,
    sdtNV CHAR(11) NOT NULL,
    Luong INT NOT NULL
)

-- Tạo bảng KhachHang
CREATE TABLE KhachHang (
    maKH CHAR(10) PRIMARY KEY NOT NULL,
    tenKH NVARCHAR(30) NOT NULL,
    gioiTinh NVARCHAR(10) NOT NULL,
    diaChi NVARCHAR(50) NOT NULL,
    sdtKH CHAR(11) NOT NULL,
    maDHB CHAR(10) NOT NULL,
)


-- Tạo bảng NhaCungCap
CREATE TABLE NhaCungCap (
    maNCC CHAR(10) PRIMARY KEY NOT NULL,
    tenNCC NVARCHAR(50) NOT NULL,
    diaChi NVARCHAR(50) NOT NULL,
    sdtNCC CHAR(11) NOT NULL
)

-- Tạo bảng NhomNhac
CREATE TABLE NhomNhac (
    maNN CHAR(10) PRIMARY KEY NOT NULL,
    tenNN NVARCHAR(50) NOT NULL,
    maNCC CHAR(10) NOT NULL,
    FOREIGN KEY (maNCC) REFERENCES NhaCungCap(maNCC)
)

-- Tạo bảng Lightstick
CREATE TABLE Lightstick (
    maLT CHAR(10) PRIMARY KEY NOT NULL,
    tenLT NVARCHAR(50) NOT NULL,
    maNN CHAR(10) NOT NULL,
    soLuong INT NOT NULL,
    giaTien INT NOT NULL,
    FOREIGN KEY (maNN) REFERENCES NhomNhac(maNN)
)

-- Tạo bảng DonHangNhap
CREATE TABLE DonHangNhap (
    maDHN CHAR(10)  PRIMARY KEY NOT NULL,
    maNCC CHAR(10) NOT NULL,
    maNV CHAR(10) NOT NULL,
    ngayNhap NVARCHAR(10) NOT NULL,
	TongThanhToan FLOAT DEFAULT 0,
    FOREIGN KEY (maNCC) REFERENCES NhaCungCap(maNCC),
    FOREIGN KEY (maNV) REFERENCES NhanVien(maNV),
)

-- Tạo bảng DonHangBan
CREATE TABLE DonHangBan (
    maDHB CHAR(10)  PRIMARY KEY NOT NULL,
    maNV CHAR(10) NOT NULL,
	maKH CHAR(10) NOT NULL,
    ngayBan NVARCHAR(10) NOT NULL,
	TongThanhToan FLOAT DEFAULT 0
    FOREIGN KEY (maNV) REFERENCES NhanVien(maNV),
	FOREIGN KEY (maKH) REFERENCES KhachHang(maKH)
)


-- Tạo bảng ChiTietDonHangNhap
CREATE TABLE ChiTietDonHangNhap (
	ctDHN char(10) PRIMARY KEY  NOT NULL,
    maDHN CHAR(10) NOT NULL,
    maLT CHAR(10) NOT NULL,
    giaTien FLOAT NOT NULL,
    soLuong INT NOT NULL,
	TongTien FLOAT NOT NULL
    FOREIGN KEY (maDHN) REFERENCES DonHangNhap(maDHN),
    FOREIGN KEY (maLT) REFERENCES Lightstick(maLT)
)

--Tạo bảng ChiTietDonHangBan
CREATE TABLE ChiTietDonHangBan (
	ctDHB char(10) PRIMARY KEY  NOT NULL,
    maDHB CHAR(10) NOT NULL,
    maLT CHAR(10) NOT NULL,
	giaTien FLOAT NOT NULL,
    soLuong INT NOT NULL,
	TongTien FLOAT NOT NULL
    FOREIGN KEY (maDHB) REFERENCES DonHangBan(maDHB),
    FOREIGN KEY (maLT) REFERENCES Lightstick(maLT)
)

INSERT INTO NhanVien(maNV,tenNV,gioiTinh,diaChi,sdtNV,Luong)
VALUES ('NV01',N'Lê Thị Ánh',N'Nữ',N'Hưng Yên',0388707940,15000000),
       ('NV02',N'Nguyễn Minh Hiền',N'Nữ',N'Hưng Yên',0983909263,25000000),
	   ('NV03',N'Nguyễn Văn Lâm',N'Nam',N'Hà Nội',0356707540,12000000),
	   ('NV05',N'Nguyễn Trọng Minh',N'Nam',N'Hải Phòng',012307940,15000000);

INSERT INTO KhachHang(maKH, tenKH, gioiTinh, diaChi, sdtKH, maDHB) 
VALUES
    ('KH01', N'Ngô Hải Anh', N'Nam', N'Hưng yên', '0388927384', 'DHB01'),
    ('KH02', N'Đào Hải Vân', N'Nữ', N'Hưng yên', '036352384', 'DHB02'),
    ('KH03', N'Nguyễn Ngọc Anh', N'Nam', N'Hải Phòng', '0937327384', 'DHB03');


-- Insert dữ liệu cho bảng NhaCungCap
INSERT INTO NhaCungCap(maNCC,tenNCC,diaChi,sdtNCC)
VALUES
      ('NCC01', N'HYBE entertainment', N'Hà Nội', '01234567890'),
      ('NCC02', N'YG entertainment', N'TP HCM', '09876543210'),
      ('NCC03', N'SM entertainment', N'Đà Nẵng', '01122334455'),
      ('NCC04', N'JYP entertainment', N'Cần Thơ', '02233445566'),
      ('NCC05', N'SKY entertainment', N'Nghệ An', '03344556677');

-- Insert dữ liệu cho bảng NhomNhac
INSERT INTO NhomNhac(maNN,tenNN,maNCC)
VALUES
      ('NN01', N'BTS', 'NCC01'),
      ('NN02', N'BlackPink', 'NCC02'),
      ('NN03', N'AESPA', 'NCC03'),
      ('NN04', N'TWICE', 'NCC04'),
      ('NN05', N'Sơn Tùng', 'NCC05');

-- Insert dữ liệu cho bảng Lightstick
INSERT INTO Lightstick(maLT,tenLT,maNN,soLuong,giaTien )
VALUES
     ('LT01', N'ARMY Bomb', 'NN01', 100, 500000),
     ('LT02', N'Hammer Bong', 'NN02', 150, 600000),
     ('LT03', N'AE Bong', 'NN03', 200, 700000),
     ('LT04', N'Candy Bong', 'NN04', 250, 800000),
     ('LT05', N'SKY', 'NN05', 300, 900000);

-- Insert dữ liệu cho bảng DonHangNhap
INSERT INTO DonHangNhap( maDHN,maNCC,maNV,ngayNhap )
VALUES
     ('DHN01', 'NCC01', 'NV01', '2024-05-14'),
     ('DHN02', 'NCC02', 'NV02', '2024-05-15'),
     ('DHN03', 'NCC03', 'NV03', '2024-05-16'),
     ('DHN05', 'NCC05', 'NV05', '2024-05-18');

-- Insert dữ liệu cho bảng DonHangBan
INSERT INTO DonHangBan( maDHB,maNV,maKH,ngayBan )
VALUES
    ('DHB01', 'NV01','KH01', '2024-05-19'),
	('DHB02', 'NV02','KH02', '2024-05-20'),
    ('DHB03', 'NV03', 'KH03', '2024-05-21')
  


-- Insert dữ liệu cho bảng ChiTietDonHangNhap
INSERT INTO ChiTietDonHangNhap( maDHN,maLT,giaTien,soLuong)
VALUES
    ('DHN01', 'LT01',  500000, 10),
    ('DHN02', 'LT02', 600000, 20),
    ('DHN03', 'LT03',  700000, 30)

-- Insert dữ liệu cho bảng ChiTietDonHangBan
INSERT INTO ChiTietDonHangBan(maDHB,maLT,soLuong,giaTien)
VALUES
   ('DHB01', 'LT01', 5, 950000),
   ('DHB02', 'LT02', 10, 760000),
   ('DHB03', 'LT03',  15, 870000)

-----------------------------------------------------------------------------------------------------------------------------
-- Thủ tục tính tổng thanh toán đơn hàng bán
CREATE PROCEDURE TongThanhToanHDB
    @maDHB varchar(10)
AS
BEGIN
    -- Tính tổng thành tiền từ bảng ChiTietDonHangBan
    DECLARE @TongThanhToan FLOAT;
    SELECT @TongThanhToan = SUM(TongTien)
    FROM ChiTietDonHangBan
    WHERE maDHB = @maDHB;

    -- Cập nhật tổng tiền vào bảng DonHangBan
    UPDATE DonHangBan
    SET TongThanhToan = @TongThanhToan
    WHERE maDHB = @maDHB;
END
------------------------------------------------------------------------------------------------------------------------------
-- Thủ tục tính tổng thanh toán đơn hàng nhập
CREATE PROCEDURE TongThanhToanHDN
    @maDHN varchar(10)
AS
BEGIN
    -- Tính tổng thành tiền từ bảng ChiTietDonHangNhap
    DECLARE @TongThanhToan FLOAT;
    SELECT @TongThanhToan = SUM(TongTien)
    FROM ChiTietDonHangNhap
    WHERE maDHN = @maDHN;

    -- Cập nhật tổng tiền vào bảng DonHangNhap
    UPDATE DonHangNhap
    SET TongThanhToan = @TongThanhToan
    WHERE maDHN = @maDHN;
END

------------------------------------------------------------------------------------------------------------------------------
--Thủ tục báo cáo doanh thu theo từng ngày trong khoảng thời gian fromdate và todate
CREATE PROCEDURE BaoCaoDoanhThu
    @FromDate DATE,
    @ToDate DATE
AS
BEGIN
    SELECT
	-- alldates : chọn ra tất cả các ngày trong khoảng thời gian nhập vào
        FORMAT(AllDates.Date, 'dd-MM-yyyy') AS 'Từ ngày',-- As là định dạnh tên của cột hiển thị
        @ToDate AS [Đến ngày],       
        SUM(DHB.TongThanhToan) AS N'Tổng bán',
        SUM(DHN.TongThanhToan) AS N'Tổng nhập',
        SUM(DHB.TongThanhToan - DHN.TongThanhToan) AS N'Tổng lãi',-- Tổng tiền ở bán - tổng tiền ở nhập = tổng lãi
		-- count tính số lượng, distinct để dùng cho tính số lượng không bị trùng lặp mã 
        COUNT(DISTINCT DHB.maDHB) AS 'Số lượng hóa đơn bán',
        COUNT(DISTINCT DHN.maDHN) AS 'Số lượng hóa đơn nhập'
    FROM (
        SELECT DATEADD(DAY, number, @FromDate) AS Date
        FROM master.dbo.spt_values
        WHERE type = 'P'-- bỏ tất cả các số nguyên trong datetime
            AND DATEADD(DAY, number, @FromDate) <= @ToDate-- lấy ra số ngày trong datetime và <= ngày kết thúc
    ) AS AllDates
	-- kiểm tra ở 1 bảng xem ngày bán hoặc ngày nhập có trùng với tất cả các hiển thị trong khoảng thời gian nhập vào
    LEFT JOIN DonHangBan DHB ON AllDates.Date = DHB.ngayBan
    LEFT JOIN DonHangNhap DHN ON AllDates.Date = DHN.ngayNhap
    WHERE (DHB.ngayBan IS NOT NULL OR DHN.ngayNhap IS NOT NULL)-- điều kiện là chỉ hiển thị ra những ngày có đơn hàng bán hoặc nhập
    GROUP BY FORMAT(AllDates.Date, 'dd-MM-yyyy')-- gom nhóm các dòng thời gian cùng ngày lại với nhau (không tính thời gian)
    ORDER BY FORMAT(AllDates.Date, 'dd-MM-yyyy');-- sắp xếp kết quả theo ngày
END
----------------------------------------------------------------------------------------------------------------------------
-- Top 5 mặt hàng bán chạy nhất
CREATE PROCEDURE HangBanChay
    @FromDate DATE,
    @ToDate DATE
AS
BEGIN
-- lấy ra top 5 hàng bán nhiều nhất
	SELECT TOP 5
		LT.maLT,
	    LT.tenLT,
		-- sum truy vấn đến tổng số lượng trong bản
		SUM(CTB.soLuong) AS SoLuongBan
		FROM Lightstick LT
		INNER JOIN ChiTietDonHangBan CTB ON LT.maLT = CTB.maLT
		INNER JOIN DonHangBan DHB ON CTB.maDHB = DHB.maDHB
		-- ngày bán nằm trong khoảng thời gian nhập vào
		WHERE DHB.ngayBan BETWEEN @FromDate AND @ToDate
		GROUP BY LT.maLT, LT.tenLT
		ORDER BY SoLuongBan DESC;-- sắp xếp kết quả theo ngày, desc dùng để sắp xếp thứ tự giảm dần
END
---------------------------------------------------------------------------------------------------------------------------
-- Số lượng tồn kho
CREATE PROCEDURE HangTonKho
    @FromDate DATE,
    @ToDate DATE
AS
BEGIN
	SELECT
		L.maLT,
		L.tenLT,
		-- sum truy vấn đến tổng số lượng trong bảng
		-- is null : nếu tổng số lượng là null thì trả về 0 ở cuối cùng , nếu tổng số lượng khác null thì trả về giá trị tính được
	    L.soLuong - ISNULL(SUM(CTB.soLuong), 0) AS SoLuongTonKho
		FROM Lightstick L
		INNER JOIN ChiTietDonHangBan CTB ON L.maLT = CTB.maLT
		INNER JOIN DonHangBan DHB ON CTB.maDHB = DHB.maDHB
		-- điều kiện chỉ hiển thị ra những mặt hàng tồn kho nhưng có mặt hàng trong bảng đơn hàng bán
		WHERE DHB.ngayBan BETWEEN @FromDate AND @ToDate
		GROUP BY L.maLT, L.tenLT, L.soLuong;
END
-------------------------------------------------------------------------------------------------------------------------
-- Thủ tục tăng số lượng hàng
CREATE PROCEDURE SoLuongTang
    @maLT CHAR(5),
    @SoLuong INT
AS
BEGIN
-- cập nhật vào bảng LT
    UPDATE Lightstick
	-- số lượng trong bảng LT = số lượng trong bảng LT + số lượng từ bảng chi tiết bán hoặc chi tiết nhập
    SET soLuong = soLuong + @SoLuong
    WHERE maLT = @maLT;
END
-----------------------------------------------------------------------------------------------------------------------------
-- giảm
CREATE PROCEDURE SoLuongGiam
     @maLT CHAR(5),
    @SoLuong INT
AS
BEGIN
-- cập nhật vào bảng LT
     UPDATE Lightstick
	 -- số lượng trong bảng LT = số lượng trong bảng LT - số lượng từ bảng chi tiết bán hoặc chi tiết nhập
    SET soLuong = soLuong - @SoLuong
    WHERE maLT = @maLT;
END





