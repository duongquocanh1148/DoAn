use master
if exists( select * from sysdatabases where name = 'CNPM')
drop database CNPM
create database CNPM
use CNPM
go
----------------------Tạo bảng------------------------------------
------Bảng nhân viên

if exists( select * from sys.tables where name = 'NHANVIEN')
DROP TABLE NHANVIEN
create table NHANVIEN(
	MaNV char (8) constraint PK_NHANVIEN primary key,--21MS00001---
	HotenNV nvarchar (20),
	Machucvu varchar(5),
	Maphong char(5),
	GioiTinh bit,
	NgaySinh date,
	SoBHXH char(10),	
)

---------------Bảng CT_Nhân viên---------------

if exists( select * from sys.tables where name = 'CTNHANVIEN')
DROP TABLE CTNHANVIEN
create table CTNHANVIEN(
	MaNV char (8) foreign key references NHANVIEN(MaNV),
	NguyenQuan nvarchar (15),
	HKThuongTru nvarchar (50),
	HKTamTru nvarchar (50),
	CCCD char (10) primary key,
	NgayCap Date,
	NoiCap nvarchar(20),
	NoiSinh nvarchar(15),
	Quoctich char(10),
	TonGiao nvarchar(15),
	NgayvaoDoan date,
	NgayvaoDang date,
	HocVan nvarchar(10),
	ChuyenMon nvarchar(10),
	NgoaiNgu nvarchar(10),
	Chucvu nvarchar(20),		
)
if exists( select * from sys.tables where name = 'QUATRINHCONGTAC')
DROP TABLE QUATRINHCONGTAC
create table QUATRINHCONGTAC(
	MaNV char(8) foreign key references NHANVIEN(MaNV),
	ThoigianBD date,
	ThoigianKT date,
	Chucvu nvarchar(20),
	NoiCongTac nvarchar(20),	
	primary key (MaNV,ThoigianBD)
)


----------------------Bảng Thân Nhân---------------
if exists( select * from sys.tables where name = 'THANNHAN')
DROP TABLE THANNHAN
create table THANNHAN(
	TenTN nvarchar (20) primary key,
	QuanHe nvarchar (10),
	NamSinh char(4),
	NgheNghiep nvarchar (10),
	NoiCongTacTN nvarchar(10),
	MaNV char (8) foreign key references NHANVIEN(MaNV)
)

---------------------Bảng nhà chức vụ-------------

if exists( select * from sys.tables where name = 'CHUCVU')
DROP TABLE CHUCVU
create table  CHUCVU(
	Machucvu varchar(5) constraint PK_CHUCVU primary key,
	Tenchucvu nvarchar(15)
	
)

-------------------Bảng Phòng---------
if exists( select * from sys.tables where name = 'PHONG')
DROP TABLE PHONG
create table PHONG(
	Maphong char(5) constraint PK_PHONG primary key,
	Tenphong nvarchar(20),
	MaQL char(8) foreign key references NHANVIEN(MaNV)
)

---------------Bảng hệ số lương---------

if exists( select * from sys.tables where name = 'HESOLUONG')
DROP TABLE HESOLUONG
create table HESOLUONG(
	MaNV char (8) primary key,	
	Nhomngach char(2),--A1---
	Hesoluong float(5),
	Bac int,
	MucluongCB int,
	ThueTNCN float(10),
	HeSoPhuCap float(5),
	Machucvu varchar(5) foreign key references CHUCVU(Machucvu),	
)

---------------------Bảng lương------
if exists( select * from sys.tables where name = 'LUONG')
DROP TABLE LUONG
create table LUONG(
	Thang char(2),	
	MaNV char(8) primary key,
	LuongBD int ,
	LiDo nvarchar(20),
	Tongluong float(10)
)
----khóa ngoại BANG LUONG
		ALTER TABLE LUONG ADD CONSTRAINT FK_LUONG_NHANVIEN FOREIGN KEY (MaNV) REFERENCES NHANVIEN(MaNV)
		
----------------Bảng Thống kê lương------------
if exists( select * from sys.tables where name = 'THONGKELUONG')
DROP TABLE THONGKELUONG
create table THONGKELUONG(
	ThangTK int constraint PK_THONGKELUONG primary key,
	NamTK date ,
	LuongTTT float(10),
	LuongTCTNT float(10),
)
-----------------Bảng Công tác---------------------
if exists( select * from sys.tables where name = 'CONGTAC')
DROP TABLE CONGTAC
create table CONGTAC(
	SQDCT char(10),
	Maphong char(5),
	MaCV char(5),
	MaNV char(8),
	NgayBD date,
	NgayKT date,
	LyDo nvarchar(10)
	constraint PK_CONGTAC primary key (SQDCT)
)
----------KHÓA NGOẠI BẢNG CONGTAC
		alter table CONGTAC add CONSTRAINT FK_CONGTAC_NHANVIEN FOREIGN KEY(MaNV) references NHANVIEN(MaNV),
		CONSTRAINT FK_CONGTAC_PHONG FOREIGN KEY(Maphong) references PHONG(Maphong)
		

-----------Bảng theo dõi số ngày nghỉ-------------------------

if exists( select * from sys.tables where name = 'THEODOISONGAYNGHI')
DROP TABLE THEODOISONGAYNGHI
create table THEODOISONGAYNGHI(
	NghiKP int,
	Lydo nvarchar(20),
	NghiBHXH int,
	NghiCP int,
	MaNV char(8),
	constraint PK_THEODOISONGAYNGHI primary key(MaNV)
)
------------------Khóa ngoại THEODOISONGAYNGHI
		alter table THEODOISONGAYNGHI add constraint FK_THEDOISONGAYNGHI_NHANVIEN foreign key(MaNV) references NHANVIEN(MaNV)
		

------------Bảng tính tiền sinh hoạt---------------------------------------

if exists( select * from sys.tables where name = 'TINHTIENSINHHOAT')
DROP TABLE TINHTIENSINHHOAT
create table TINHTIENSINHHOAT (
	Dientich float(5),
	SoCTD float(5),
	SoDHN float(5),
	Chiphikhac int,
	TongCPSH int,
	MaNV char(8)
	constraint PK_TINHTIENSINHHOAT primary key(MaNV)
)
		---------Thêm khóa ngoại bảng TINHTIENSINHHOAT
		alter table TINHTIENSINHHOAT add constraint FK_TINHTIENSINHHOAT_NHANVIEN foreign key(MaNV) references NHANVIEN(MaNV)
		
		----------Thêm khóa ngoại bảng NHANVIEN
		alter table NHANVIEN add constraint FK_NV_CHUCVU foreign key(Machucvu) references CHUCVU(Machucvu),
		constraint FK_NV_PHONG foreign key(Maphong) references PHONG(Maphong)
if exists( select * from sys.tables where name = 'DANGKYNHATT')
DROP TABLE DANGKYNHATT
create table DANGKYNHATT (
	SoDK char (10) primary key,
	MaNV char(8) foreign key references NHANVIEN(MaNV),
	TenPhongNTT char(5),
	DienTichThue float,
	SLNguoiDK int
)
if exists( select * from sys.tables where name = 'NGUOIDUNG')
DROP TABLE NGUOIDUNG
create table NGUOIDUNG (
	TaiKhoan varchar(20) primary key,
	MatKhau varchar(20),
)

-------------------------------------------------------------------------------------------------------------------------------
----Thêm bảng Chức Vụ-----------

INSERT INTO CHUCVU VALUES ('NV', N'Nhân viên')
INSERT INTO CHUCVU VALUES ('TP', N'Trưởng phòng')
INSERT INTO CHUCVU VALUES ('KT', N'Kế toán')
INSERT INTO CHUCVU VALUES ('NS', N'Nhân sự')

----Thêm bảng phòng------

INSERT INTO PHONG VALUES ('PTK01', N'Phòng thiết kế',null)
INSERT INTO PHONG VALUES ('PKT01', N'Phòng kế toán', null)
INSERT INTO PHONG VALUES ('PNS01', N'Phòng nhân sự',null)

-----Thêm bảng Nhân Viên--------

INSERT INTO NHANVIEN VALUES ('21MS0001', N'Nguyễn Thành Đạt','NV', 'PTK01', '0', '2001-03-27', 'N790100123')
INSERT INTO NHANVIEN VALUES ('21MS0002', N'Nguyễn Anh Khoa','TP', 'PTK01', '0', '2001-03-01', 'N790100124')
INSERT INTO NHANVIEN VALUES ('21MS0003', N'Nguyễn Đăng Khoa', 'KT', 'PKT01', '0', '2001-03-23', 'N790100125')
INSERT INTO NHANVIEN VALUES ('21MS0004', N'Dương Quốc Anh', 'NS', 'PNS01','0', '2001-02-02', 'N790100126')
--INSERT INTO NHANVIEN VALUES ('"++"', N'"++"', '"++"', '"++"','"++"', '"++"', '"++"', '"++"')

-----Thêm bảng thân nhân-----------
INSERT INTO THANNHAN VALUES (N'Lê Thị Bơ', N'Vợ chồng', '2001', N'Giáo viên', N'TPHCM', '21MS0001')
INSERT INTO THANNHAN VALUES (N'Lê Thị Liên', N'Vợ chồng', '2000', N'Kế toán', N'TPHCM', '21MS0002')
INSERT INTO THANNHAN VALUES (N'Phạm Thị Hồng', N'Vợ chồng', '1999', N'Thiết kế ', N'TPHCM', '21MS0003')
INSERT INTO THANNHAN VALUES (N'Phương Ly', N'Vợ chồng', '2003', N'Tester', N'TPHCM', '21MS0004')
--INSERT INTO THANNHAN VALUES (N'"++"', N'"++"', '"++"', N'"++"',N'"++"', '"++"')


--TINHTIENSINHHOAT
Insert into TINHTIENSINHHOAT values (20,100,30,0,null,'21MS0001')
Insert into TINHTIENSINHHOAT values (30,120,50,0,null,'21MS0002')
Insert into TINHTIENSINHHOAT values (25,120,50,0,null,'21MS0003')
Insert into TINHTIENSINHHOAT values (25,120,50,0,null,'21MS0004')

--THEODOISONGAYNGHI
Insert into THEODOISONGAYNGHI values (null,null,null,null,'21MS0001')
Insert into THEODOISONGAYNGHI values (null,null,null,null,'21MS0002')
Insert into THEODOISONGAYNGHI values (null,null,null,null,'21MS0003')
Insert into THEODOISONGAYNGHI values (null,null,null,null,'21MS0004')
--CONGTAC
Insert into CONGTAC values ('SQD\0001','PTK01','NV','21MS0001','2021-12-01',null,'NVM')
Insert into CONGTAC values ('SQD\0002','PTK01','TP','21MS0002','2021-12-01',null,'NVM')
Insert into CONGTAC values ('SQD\0003','PKT01','KT','21MS0003','2021-12-01',null,'NVM')
Insert into CONGTAC values ('SQD\0004','PNS01','NS','21MS0004','2021-12-01',null,'NVM')
--THONGKELUONG
insert into THONGKELUONG values(1,null,null,null)
insert into THONGKELUONG values(2,null,null,null)
insert into THONGKELUONG values(3,null,null,null)
insert into THONGKELUONG values(4,null,null,null)
insert into THONGKELUONG values(5,null,null,null)
insert into THONGKELUONG values(6,null,null,null)
insert into THONGKELUONG values(7,null,null,null)
insert into THONGKELUONG values(8,null,null,null)
insert into THONGKELUONG values(9,null,null,null)
insert into THONGKELUONG values(10,null,null,null)
insert into THONGKELUONG values(11,null,null,null)
insert into THONGKELUONG values(12,null,null,null)
--LUONG
Insert into LUONG values ('12','21MS0001',null,null,null)
Insert into LUONG values ('12','21MS0002',null,null,null)
Insert into LUONG values ('12','21MS0003',null,null,null)
Insert into LUONG values ('12','21MS0004',null,null,null)
--CTNHANVIEN
Insert into CTNHANVIEN values('21MS0001',N'Đà Lạt',N'123 Ngô Quyền, phường 3, quận 5, TPHCM',null,'205214123',null,null,'TPHCM','Viet Nam',N'Đạo Chúa',null,null,N'Cử nhân',N'CNPM','TOIEC 450',N'Nhân viên')
Insert into CTNHANVIEN values('21MS0002',N'Hà Nội',N'204 Trần Hưng Đạo, phường 4, quận 5, TPHCM',null,'204123205',null,null,'TPHCM','Viet Nam',N'Đạo Chúa',null,null,N'Thạc sĩ',N'CNPM','TOIEC 800',N'Trưởng phòng')
Insert into CTNHANVIEN values('21MS0003',N'Nha TRang',N'123 Sư Vạn Hạnh, phường 5, quận 10, TPHCM',null,'206201213',null,null,'TPHCM','Viet Nam',N'Đạo Chúa',null,null,N'Thạc sĩ',N'Kế toán','IELTS 8.0',N'Kế toán')
Insert into CTNHANVIEN values('21MS0004',N'Đà Nẵng',N'123 Lý Chính Thắng, phường 6, quận 3, TPHCM',null,'203213234',null,null,'TPHCM','Viet Nam',null,null,null,N'Tiến sĩ',N'Quản lý','IELTS 9.0',N'Nhân sự')
--Insert into CTNHANVIEN values('"++"',N'"++"',N'"++"',null,'"++"',null,null,'"++"','"++"',null,null,null,N'"++"',N'"++"','"++"',N'"++"')
--QUATRINHCONGTAC
insert into QUATRINHCONGTAC values('21MS0001','2021-12-01',null,N'Nhân viên',N'Phòng thiết kế')
insert into QUATRINHCONGTAC values('21MS0002','2021-12-01',null,N'Trưởng phòng',N'Phòng thiết kế')
insert into QUATRINHCONGTAC values('21MS0003','2021-12-01',null,N'Kế toán',N'Phòng kế toán')
insert into QUATRINHCONGTAC values('21MS0004','2021-12-01',null,N'Nhân sự',N'Phòng nhân sự')

--DANGKYNHATT
insert into DANGKYNHATT values('QDDK\001','21MS0001','A01',20,2)
insert into DANGKYNHATT values('QDDK\002','21MS0002','A02',30,2)
insert into DANGKYNHATT values('QDDK\003','21MS0003','B01',25,2)
insert into DANGKYNHATT values('QDDK\004','21MS0004','B02',25,2)
--HESOLUONG
insert into HESOLUONG values('21MS0001','C1',1.65,2,null,null,1.6,'NV')
insert into HESOLUONG values('21MS0002','B1',1.86,3,null,null,1.8,'TP')
insert into HESOLUONG values('21MS0003','A1',2.34,1,null,null,2.2,'KT')
insert into HESOLUONG values('21MS0004','A2',4.00,2,null,null,2.4,'NS')
--insert into HESOLUONG values('"++"','"++"',"++","++","++","++",'"++"')
--NGUOIDUNG
insert into NGUOIDUNG values('khoa31','123456')
--Update
update TINHTIENSINHHOAT
set Chiphikhac=20000
where MaNV = '21MS0001'
update  TINHTIENSINHHOAT
set Chiphikhac=20000
where MaNV = '21MS0002'
update PHONG 
set MaQL = '21MS0002'
where Maphong = 'PKT01'
update TINHTIENSINHHOAT
set TongCPSH = Dientich*200000+SoCTD*3500+SoDHN*10000+Chiphikhac
update THEODOISONGAYNGHI
set NghiKP = 1, NghiBHXH = 1 where MaNV = '21MS0001'
update HESOLUONG
set MucluongCB = 4000000
where Machucvu = 'NV'
update HESOLUONG
set MucluongCB = 6000000
where Machucvu = 'TP'
update HESOLUONG
set MucluongCB = 7000000
where Machucvu = 'KT'
update HESOLUONG
set MucluongCB = 7000000
where Machucvu = 'NS'
update HESOLUONG
set ThueTNCN = case when MucluongCB <= 5000000 then 0.95
					when MucluongCB > 5000000 and MucluongCB <= 10000000 then 0.9
					when MucluongCB > 10000000 and MucluongCB<= 18000000 then 0.85
					when MucluongCB > 18000000 and MucluongCB<= 32000000 then 0.8
					when MucluongCB > 32000000 and MucluongCB<= 52000000 then 0.75
					when MucluongCB > 52000000 and MucluongCB<= 80000000 then 0.7
					when MucluongCB > 80000000 then 0.65
					else 1
					end;
update t1
set Tongluong = HeSoPhuCap*MucluongCB*ThueTNCN - LuongBD - TongCPSH - (HeSoPhuCap*MucluongCB*ThueTNCN)/30*(NghiCP+NghiBHXH+NghiKP)
from LUONG as t1
join HESOLUONG as t2 on t2.MaNV = t1.MaNV
join THEODOISONGAYNGHI as t3 on t3.MaNV = t1.MaNV
join TINHTIENSINHHOAT as t4 on t4.MaNV = t1.MaNV
--Trigger
/*create trigger SoCTD
on TINHTIENSINHHOAT
for insert,update
as
BEGIN
declare @TienDien float
select SoCTD,soDHN from inserted
where SoCTD <0
begin
rollback
raiserror ('So cong to dien phai va so dong ho nuoc phai lon hon 0',16,1);
end
END*/
/*create trigger So_ngay_nghi_BHXH
on THEODOISONGAYNGHI
for insert,update
as
BEGIN
declare @NghiBHXH int
select @NghiBHXH from inserted
if max(@NghiBHXH) >12
begin
rollback
raiserror ('So ngay nghi BHXH toi da la 12',16,1);
end
END
create trigger Tong_CPSH
on TINHTIENSINHHOAT
for insert, update
as
BEGIN
declare @TongCPSH float
select @TongCPSH = Dientich*200000+SoCTD*3500+SoDHN*10000+Chiphikhac from inserted
set @TongCPSH = TongCPSH 
END*/

----DANHSACHNHANVIEN
--select * from NHANVIEN
----PHONG	
--select * from PHONG
----CTNHANVIEN
--select Distinct NHANVIEN.MaNV, NgaySinh, HotenNV, GioiTinh, NoiSinh, SoBHXH,Tenchucvu,Tenphong,NguyenQuan, HKThuongTru,HKTamTru,NgayCap,NoiCap,Quoctich,NgayvaoDoan,NgayvaoDang,HocVan,ChuyenMon
--from CTNHANVIEN
--join NHANVIEN on CTNHANVIEN.MaNV = NHANVIEN.MaNV
--join CHUCVU on CHUCVU.Machucvu = NHANVIEN.Machucvu
--join PHONG on PHONG.Maphong = NHANVIEN.Maphong
--where CTNHANVIEN.MaNV like '21MS0001' 
--select distinct NHANVIEN.MaNV,ThoigianBD,ThoigianKT,Tenchucvu,NoiCongTac
--from QUATRINHCONGTAC,CTNHANVIEN
--join NHANVIEN on CTNHANVIEN.MaNV = NHANVIEN.MaNV
--join CHUCVU on CHUCVU.Machucvu = NHANVIEN.Machucvu
--join PHONG on PHONG.Maphong = NHANVIEN.Maphong
--where NHANVIEN.MaNV = '21MS0005' 

----TINHTIENSINHHOAT
--select NHANVIEN.MaNV,NHANVIEN.HotenNV,Dientich*200000 as TienPhong, SoCTD*3500 as TienDien, SoDHN*10000 as TienNuoc,Chiphikhac, TongCPSH
--from TINHTIENSINHHOAT
--join NHANVIEN on TINHTIENSINHHOAT.MaNV=NHANVIEN.MaNV
----THONGKELUONG
--select * from THONGKELUONG
----THEODOISONGAYNGHI
--select distinct NHANVIEN.MaNV, HotenNV, Tenchucvu, NghiCP, Lydo, NghiKP,NghiBHXH
--from THEODOISONGAYNGHI, NHANVIEN
--join CHUCVU on CHUCVU.Machucvu = NHANVIEN.Machucvu
----DANGKYNHATT
--select distinct SoDK, NHANVIEN.MaNV, HotenNV, Tenchucvu, Tenphong as NoiCongTac
--from DANGKYNHATT
--join NHANVIEN on NHANVIEN.MaNV = DANGKYNHATT.MaNV
--join CHUCVU on CHUCVU.Machucvu = NHANVIEN.Machucvu
--join PHONG on PHONG.Maphong = NHANVIEN.Maphong
----THANNHAN
--select * from THANNHAN
----HESOLUONG
--select * from HESOLUONG
----LUONG
--select NHANVIEN.MaNV , HotenNV, Tenchucvu, HeSoPhuCap As PhuCapChucVu, NghiCP, NghiKP, NghiBHXH,MucluongCB, LuongBD, ThueTNCN, TongCPSH, Tongluong as TổngSố
--from LUONG
--join NHANVIEN on NHANVIEN.MaNV = LUONG.MaNV
--join CHUCVU on CHUCVU.Machucvu = NHANVIEN.Machucvu
--join HESOLUONG on HESOLUONG.MaNV = NHANVIEN.MaNV
--join THEODOISONGAYNGHI on THEODOISONGAYNGHI.MaNV = NHANVIEN.MaNV
--join TINHTIENSINHHOAT on TINHTIENSINHHOAT.MaNV = NHANVIEN.MaNV
----CHUCVU
--select * from CHUCVU
----Danh sách nhân viên theo phòng
--select distinct NHANVIEN.MaNV, HotenNV, NHANVIEN.Machucvu, Tenchucvu
--from NHANVIEN
--join PHONG on  PHONG.Maphong= NHANVIEN.Maphong 
--join CHUCVU on CHUCVU.Machucvu = NHANVIEN.Machucvu
--where PHONG.Maphong = 'PTK01'
--select * from DANGKYNHATT
--select MaNV,Dientich,SoCTD,SoDHN,Chiphikhac,TongCPSH from TINHTIENSINHHOAT
--select * from TINHTIENSINHHOAT
--select LUONG.MaNV,ThueTNCN,MucluongCB,LuongBD,LiDo,Tongluong as ChuatruCPSH from LUONG
--join HESOLUONG on HESOLUONG.MaNV = LUONG.MaNV

--select * from LUONG



