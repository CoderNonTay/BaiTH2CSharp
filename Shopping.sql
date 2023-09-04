create database SHOPPING

--Login
create table NGUOIDUNG
(
	TenDangNhap nvarchar(20) COLLATE Latin1_General_CS_AS PRIMARY KEY, 
	MatKhau nvarchar(20) COLLATE Latin1_General_CS_AS,
	TenNguoiDung nvarchar(100)
);

Go
CREATE PROC Login
@username nvarchar(20), @pass varchar(20)
as 
begin
select * from NGUOIDUNG where TenDangNhap=@username and MatKhau=@pass
end

--Sản phẩm
create table LOAISANPHAM
(
	MaLoaiSP int PRIMARY KEY identity(1,1),
	TenLoaiSP varchar(20)
);
create table SANPHAM
(
	MaSP int PRIMARY KEY identity(1000,1),
	TenSP varchar(100),
	MaLoaiSP int FOREIGN KEY (MaLoaiSP) REFERENCES LOAISANPHAM(MaLoaiSP),
	Gia money,
	Ram varchar(100),
	Rom varchar(100),
	Chip varchar(100),
	Camera nvarchar(200), 
	NamSX varchar(100),
	QuocGia nvarchar(100)
);

--Hóa đơn
CREATE TABLE HOADON
(
SoHoaDon int PRIMARY KEY identity(1000000, 1),
ID nvarchar(20) COLLATE Latin1_General_CS_AS FOREIGN KEY (ID) REFERENCES NGUOIDUNG(TenDangNhap),
TongTien MONEY NOT NULL, -- >0
NgayLap date DEFAULT getdate(),
TinhTrang nvarchar(40) DEFAULT(N'Đang xử lí') NOT NULL -- Đang xử lí, đóng gói, đang vận chuyển, đang giao hàng, đã nhận hàng, đã hủy
);

insert into HOADON (ID, TongTien) values(N'phung3521', 100000)
CREATE TABLE CT_HOADON
(
MaCT_HOADON int PRIMARY KEY identity(1,1), 
SoHoaDon int FOREIGN KEY (SoHoaDon) REFERENCES HOADON(SoHoaDon),
MaSP int FOREIGN KEY (MaSP) REFERENCES SANPHAM(MaSP),
SoLuong tinyint NOT NULL, -- >0   
);  
.
Go
CREATE PROC NhapCTHD -- Nhap CT_HoaDon
@MaSp int, @SoLuong int
as
begin
declare @SoHoaDon int; 
set @SoHoaDon = (Select Max(SoHoaDon) from HOADON);
insert into CT_HOADON values (@SoHoaDon, @MaSP, @SoLuong);
end

--Thêm dữ liệu
insert into LOAISANPHAM values ('Iphone')
insert into LOAISANPHAM values ('Ipad')
insert into LOAISANPHAM values ('Macbook')
insert into LOAISANPHAM values ('Airpods')

insert into SANPHAM values ('Iphone 11', 1, 10900000, '4GB', '128GB', 'A13 Bionic', N'Trước: 12MP, Sau: Camera kép 12MP', '2019', N'Trung Quốc')
insert into SANPHAM values ('Iphone 11 Pro Max', 1, 14900000, '4GB', '256GB', 'A13 Bionic', N'Trước: 12MP, Sau: 3 Camera 12MP', '2019', N'Trung Quốc')
insert into SANPHAM values ('Iphone 12', 1, 12900000, '4GB', '128GB', 'A14 Bionic', N'Trước: 12MP, Sau: Camera kép 12MP', '2020', N'Trung Quốc')
insert into SANPHAM values ('Iphone 12 Mini', 1, 11900000, '4GB', '128GB', 'A14 Bionic', N'Trước: 12MP, Sau: Camera kép 12MP', '2020', N'Trung Quốc')
insert into SANPHAM values ('Iphone 12 Pro', 1, 14900000, '4GB', '256GB', 'A14 Bionic', N'Trước: 12MP, Sau: 3 Camera 12MP', '2020', N'Trung Quốc')
insert into SANPHAM values ('Iphone 12 Pro Max', 1, 16900000, '4GB', '256GB', 'A14 Bionic', N'Trước: 12MP, Sau: 3 Camera 12MP', '2020', N'Trung Quốc')
insert into SANPHAM values ('Iphone 13', 1, 13900000, '4GB', '256GB', 'A15', N'Trước: 12MP, Sau: Camera kép 12MP', '2021', N'Trung Quốc')
insert into SANPHAM values ('Iphone 13 Mini', 1, 14900000, '4GB', '256GB', 'A15', N'Trước: 12MP, Sau: Camera kép 12MP', '2021', N'Trung Quốc')
insert into SANPHAM values ('Iphone 13 Pro', 1, 16900000, '6GB', '512GB', 'A15', N'Trước: 12MP, Sau: 3 Camera 12MP', '2021', N'Trung Quốc')
insert into SANPHAM values ('Iphone 13 Pro Max', 1, 17900000, '6GB', '512GB', 'A15', N'Trước: 12MP, Sau: 3 Camera 12MP', '2021', N'Trung Quốc')
insert into SANPHAM values ('Iphone 14', 1, 19900000, '6GB', '512GB', 'A15', N'Trước: 12MP, Sau: Camera kép 12MP', '2022', N'Trung Quốc')
insert into SANPHAM values ('Iphone 14 Plus', 1, 20900000, '6GB', '512GB', 'A15', N'Trước: 12MP, Sau: Camera kép 12MP', '2022', N'Trung Quốc')
insert into SANPHAM values ('Iphone 14 Pro', 1, 21900000, '6GB', '1TB', 'A16', N'Trước: 12MP, Sau: Chính 48 MP, 2 Camera 12MP', '2022', N'Trung Quốc')
insert into SANPHAM values ('Iphone 14 Pro Max', 1, 25900000, '6GB', '1TB', 'A16', N'Trước: 12MP, Sau: Chính 48 MP, 2 Camera 12MP', '2022', N'Trung Quốc')
insert into SANPHAM values ('Iphone SE 2020', 1, 10900000, '3GB', '128GB', 'A13 Bionic', N'Trước: 7MP, Sau: Camera góc rộng 12MP', '2020', N'Trung Quốc')
insert into SANPHAM values ('Iphone SE 2022', 1, 15900000, '4GB', '128GB', 'A15', N'Trước: 7MP, Sau: Camera góc rộng 12MP', '2022', N'Trung Quốc')

insert into SANPHAM values ('Ipad Air 4', 2, 13900000, '4GB', '128GB', 'A14 Bionic', N'Trước: 7MP, Sau: 12MP', '2020', N'Trung Quốc')
insert into SANPHAM values ('Ipad Air 5 M1', 2, 18900000, '8GB', '256GB', 'Apple M1', N'Trước: 12MP, Sau: 12MP', '2022', N'Trung Quốc')
insert into SANPHAM values ('Ipad Gen 9', 2, 7900000, '3GB', '128GB', 'A13 Bionic', N'Trước: 12MP, Sau: 8MP', '2021', N'Trung Quốc')
insert into SANPHAM values ('Ipad Gen 10', 2, 9900000, '3GB', '128GB', 'A14 Bionic', N'Trước: 12MP, Sau: 12MP', '2022', N'Trung Quốc')
insert into SANPHAM values ('Ipad Pro 11 inch 2020', 2, 17900000, '6GB', '128GB', 'A12Z Bionic', N'Trước: 12MP, Sau: Chính 12MP, phụ 10 MP', '2020', N'Trung Quốc')
insert into SANPHAM values ('Ipad Pro 11 inch 2021 (M1)', 2, 19900000, '16GB', '256GB', 'Apple M1', N'Trước: 12MP, Sau: Chính 12MP, phụ 10 MP', '2021', N'Trung Quốc')
insert into SANPHAM values ('Ipad Pro 11 inch 2022 (M2)', 2, 23900000, '16GB', '256GB', 'Apple M2', N'Trước: 12MP, Sau: Chính 12MP, phụ 10 MP', '2022', N'Trung Quốc')
insert into SANPHAM values ('Ipad Pro 12.9 inch 2021 (M1)', 2, 26900000, '16GB', '256GB', 'Apple M1', N'Trước: 12MP, Sau: Chính 12MP, phụ 10 MP', '2021', N'Trung Quốc')
insert into SANPHAM values ('Ipad Pro 12.9 inch 2022 (M2)', 2, 29900000, '16GB', '256GB', 'Apple M2', N'Trước: 12MP, Sau: Chính 12MP, phụ 10 MP', '2022', N'Trung Quốc')

insert into SANPHAM values ('Macbook Air M1', 3, 21900000, '16GB', '512GB', 'Apple M1', N'720p FaceTime HD', '2020', N'Trung Quốc')
insert into SANPHAM values ('Macbook Air M2', 3, 29900000, '16GB', '512GB', 'Apple M2', N'720p FaceTime HD', '2022', N'Trung Quốc')
insert into SANPHAM values ('Macbook Pro 14 inch (M1 Max)', 3, 49900000, '32GB', '512GB', 'Apple M1 Max', N'1080p FaceTime FHD', '2021', N'Trung Quốc')
insert into SANPHAM values ('Macbook Pro 14 inch (M1 Pro)', 3, 39900000, '32GB', '512GB', 'Apple M1 Pro', N'1080p FaceTime FHD', '2021', N'Trung Quốc')
insert into SANPHAM values ('Macbook Pro 16 inch (M1 Pro)', 3, 59900000,'64GB', '512GB', 'Apple M1 Pro', N'1080p FaceTime FHD', '2021', N'Trung Quốc')
insert into SANPHAM values ('Macbook Pro 16 inch (M1 Max)', 3, 79900000, '64GB', '512GB', 'Apple M1 Max', N'1080p FaceTime FHD', '2021', N'Trung Quốc')

insert into SANPHAM values ('Airpods 2', 4, 2900000, 'None', 'None', 'None', N'None', '2018', N'USA')
insert into SANPHAM values ('Airpods 3', 4, 4900000, 'None', 'None', 'None', N'None', '2021', N'USA')
insert into SANPHAM values ('Airpods Max', 4, 10900000, 'None', 'None', 'None', N'None', '2019', N'USA')
insert into SANPHAM values ('Airpods Pro', 4, 4900000, 'None', 'None', 'None', N'None', '2020', N'USA')
insert into SANPHAM values ('Airpods Pro 2', 4, 6900000, 'None', 'None', 'None', N'None', '2022', N'USA')


Go
CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) 
RETURNS NVARCHAR(4000) 
AS 
BEGIN 
IF @strInput IS NULL 
RETURN @strInput 
IF @strInput = '' 
RETURN @strInput 
DECLARE @RT NVARCHAR(4000) 
DECLARE @SIGN_CHARS NCHAR(136) 
DECLARE @UNSIGN_CHARS NCHAR (136) 
SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) 
SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' 
DECLARE @COUNTER int 
DECLARE @COUNTER1 int 
SET @COUNTER = 1 
WHILE (@COUNTER <=LEN(@strInput)) 
BEGIN 
SET @COUNTER1 = 1 
WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) 
BEGIN 
IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) 
BEGIN 
IF @COUNTER=1 
SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) 
ELSE 
SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) 
BREAK 
END 
SET @COUNTER1 = @COUNTER1 +1 
END 
SET @COUNTER = @COUNTER +1 
END 
SET @strInput = replace(@strInput,' ','-') 
RETURN @strInput 
END













