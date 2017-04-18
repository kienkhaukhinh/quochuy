
create database ToyShopDB


create table LOAISP
(
ID int primary key IDENTITY(1,1),
TENLOAI nvarchar(50) unique
)

create table NHACC
(
ID int primary key IDENTITY(1,1),
TENNCC nvarchar(50) unique,
SDT nvarchar(13) unique,
DIACHI nvarchar(100),
EMAIL nvarchar(50) unique
)

create table KHACHHANGTT
(
ID nvarchar(50) primary key,
TENKH nvarchar(50),
CMND nvarchar(50) unique,
DIACHI nvarchar(100),
SDT nvarchar(12),
DIEMTL int,
NGAYCAP datetime,
NGAYHETHAN datetime
)

create table NGDUNG
(
ID nvarchar(50) primary key,
PASSWD nvarchar(50),
TENNGDUNG nvarchar(50),
NGAYSINH datetime,
SDT nvarchar(12) unique,
PHANQUYEN smallint
)

create table SANPHAM
(
ID int primary key IDENTITY(1,1),
TENSP nvarchar(50) not null,

XUATXU nvarchar(50),
SLTON int,
SLBAYBAN int,
GIATIEN int,
IDLOAISP int,
HINHANH nvarchar(100),
)

create table HOADON
(
ID int primary key IDENTITY(1,1),
NGAYXUAT datetime,
MAKHTT nvarchar(50),
THANHTIEN int,
)

create table CT_HOADON
(
IDHOADON int not null,
IDSANPHAM int not null,
SL int,
TONG int
)



create table DONDATHANG
(
ID int primary key IDENTITY(1,1),
NGAYDAT datetime,
IDNCC int,
IDNGUOIDAT nvarchar(50),
SL int,
TONGCONG int,
)
create table CT_DONDATHANG
(
IDDONDAT int not null,
IDSANPHAM int not null,
SL int,
DONGIA int,
TONG int,
)



SELECT *
FROM KHACHHANGTT
ORDER BY NGAYCAP DESC

insert into NGDUNG (ID,PASSWD,TENNGDUNG,NGAYSINH,SDT,PHANQUYEN) values (N'QL001',N'123456',N'Đào Chí Quyền','1/5/1996',N'091871712',2)
insert into NGDUNG (ID,PASSWD,TENNGDUNG,NGAYSINH,SDT,PHANQUYEN) values (N'QL002',N'1234556',N'Sư Sư','2/1/1997','098716617',2)
insert into NGDUNG (ID,PASSWD,TENNGDUNG,NGAYSINH,SDT,PHANQUYEN) values (N'TK001',N'123456',N'Hồ Ly','1/3/1992','0133257884',1)
insert into NGDUNG (ID,PASSWD,TENNGDUNG,NGAYSINH,SDT,PHANQUYEN) values (N'TK002',N'123456',N'Đào Chí Hào','3/1/1991','09876611114',1)
insert into NGDUNG (ID,PASSWD,TENNGDUNG,NGAYSINH,SDT,PHANQUYEN) values (N'NV001',N'123456',N'Tony Huỳnh','1/5/1973','013357888',0)
insert into NGDUNG (ID,PASSWD,TENNGDUNG,NGAYSINH,SDT,PHANQUYEN) values (N'NV002',N'123456',N'Đào Chí Quyền','1/5/1996','01983188313',0)

insert into KHACHHANGTT (ID,TENKH,CMND,DIACHI,SDT,DIEMTL,NGAYCAP,NGAYHETHAN) values (N'KHACH001',N'Đào Chí Vũ',N'888171821',N'Số 2, Nguyễn Văn Cừ, Q5, HCM',N'012331566',0,'2017-03-10 10:34:09','2018-03-10 10:34:09')
insert into KHACHHANGTT (ID,TENKH,CMND,DIACHI,SDT,DIEMTL,NGAYCAP,NGAYHETHAN) values (N'KHACH002',N'Lệ Rơi',N'123699000123',N'Số 50, Phổ Quang, Q Phú Nhuận, HCM',N'01863644',0,'2017-03-11 10:34:09','2018-03-11 10:34:09')
insert into KHACHHANGTT (ID,TENKH,CMND,DIACHI,SDT,DIEMTL,NGAYCAP,NGAYHETHAN) values (N'KHACH003',N'Quân Kun',N'144124556',N'Số 228/3, Nguyễn Văn Công, Q Gò Vấp, HCM',N'012331566',0,'2017-03-12 10:34:09','2018-03-12 10:34:09')
insert into KHACHHANGTT (ID,TENKH,CMND,DIACHI,SDT,DIEMTL,NGAYCAP,NGAYHETHAN) values (N'KHACH004',N'Hy Hữu',N'44616788',N'Số 14, Nguyễn Hữu Huân, Q1, HCM',N'012331566',0,'2017-03-13 10:34:09','2018-03-13 10:34:09')
insert into KHACHHANGTT (ID,TENKH,CMND,DIACHI,SDT,DIEMTL,NGAYCAP,NGAYHETHAN) values (N'KHACH005',N'Nguyễn Trương Việt Hòa',N'8133821',N'Số 2, Âu Cơ, Q11, HCM',N'012331566',0,'2017-03-14 10:34:09','2018-03-14 10:34:09')
insert into KHACHHANGTT (ID,TENKH,CMND,DIACHI,SDT,DIEMTL,NGAYCAP,NGAYHETHAN) values (N'KHACH006',N'Dư Bính Khôn',N'811821',N'Số 1, Lạc Long Quân, Q10, HCM',N'09213566',0,'2017-03-16 10:34:09','2018-03-16 10:34:09')

---xoa di con----

INSERT INTO LOAISP VALUES (N'Đồ chơi LEGO');
INSERT INTO LOAISP VALUES (N'Đồ chơi giáo dục');
INSERT INTO LOAISP VALUES (N'Đồ chơi mô hình');
INSERT INTO LOAISP VALUES (N'Đồ chơi Điều khiển từ xa');
INSERT INTO LOAISP VALUES (N'Đồ chơi lắp ráp');

INSERT INTO SANPHAM VALUES(N'Lego City Xe Cứu Hoả',N'Trung Quốc',10,10,100000,1,N'LegoCity.jpg');
INSERT INTO SANPHAM VALUES(N'Lego Creator Máy Bay Cánh Quạt',N'Trung Quốc',10,10,200000,1,N'MBCanhQuat.jpg');
INSERT INTO SANPHAM VALUES(N'Lego Ninjago Xe Phá Hủy',N'Trung Quốc',10,10,200000,1,N'NinjaGo.jpg');
INSERT INTO SANPHAM VALUES(N'Lego Creator Khủng Long ??',N'Trung Quốc',10,10,100000,1,N'KhungLong.jpg');
INSERT INTO SANPHAM VALUES(N'Lego Creator Xe Ford Mustang',N'Trung Quốc',10,10,100000,1,N'Ford.jpg');


INSERT INTO SANPHAM VALUES(N'Bảng ghép vần Kiwi',N'Việt Nam',10,10,50000,2,N'GhepVanKiwi.jpg');
INSERT INTO SANPHAM VALUES(N'Bảng hình học',N'Việt Nam',10,10,60000,2,N'HinhHoc.jpg');
INSERT INTO SANPHAM VALUES(N'Hộp Chuỗi Số',N'Việt Nam',10,10,50000,2,N'ChuoiSo.jpg');
INSERT INTO SANPHAM VALUES(N'Ngôi Nhà Thả Số',N'Nhật Bản',10,10,100000,2,N'NgoiNhaSo.jpg');
INSERT INTO SANPHAM VALUES(N'Đoàn Tàu Con Số',N'Trung Quốc',10,10,100000,2,N'DoanTauSo.jpg');



---them ti xiu--
ALTER TABLE DONDATHANG ADD TRANGTHAI bit

-- them cai nay--
INSERT INTO NHACC VALUES(N'Phương Nga Toys','3931 9209','Lầu 4 Tòa nhà Ninomax, 84A, Bà Huyện Thanh Quan, P9, Q3, TP.HCM','sales@phuongnga.com');
INSERT INTO NHACC VALUES(N'Tín Phát','3931 0209','1A-1B Bà Lài P8 Q6','tinphat@gmail.com');

--THEM NUA

ALTER TABLE DONDATHANG DROP COLUMN SL
ALTER TABLE CT_DONDATHANG ADD SL_NHAP int

