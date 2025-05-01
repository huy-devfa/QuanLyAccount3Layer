use QuanLyAccount

create table Users(
	username char(16) not null primary key,
	pass char(100)
)


alter table Users add SoDu int

alter table Users add constraint ck1_sodu check (sodu>=0)



alter table Users add vaitro char(50)

alter table Users add constraint default1_sodu default 0 for sodu
alter table Users add constraint default_ default'User' for vaitro

select * from Users

--proceduce Update Users
create proc Usp_UpdateUsers
	@Pusername char(16),
	@Ppass char(100),
	@Psodu int,
	@Pvaitro char(50)
as
begin
	update Users set pass=@Ppass, SoDu=@Psodu, vaitro=@Pvaitro where username=@Pusername
end


create table Accounts(
	idTaiKhoan int not null primary key,
	LoaiAccount int,
	userAccount char(100),
	passAccount char(500),
	GiaBan 	DECIMAL(18,2),
	TrangThai nvarchar(30),
	NguoiDangBan char(16),
	NguoiMua char(16),
	ThoiGianBan DateTime
)

select * from Accounts

alter table accounts add cookieAccount char(7000)
ALTER TABLE Accounts ALTER COLUMN LoaiAccount INT;

ALTER TABLE Accounts ADD CONSTRAINT FK_LoaiAccount FOREIGN KEY (LoaiAccount) REFERENCES LoaiTaiKhoan(IdLoaiTaiKhoan);


ALTER TABLE Accounts ADD CONSTRAINT chk_TrangThai CHECK (TrangThai IN (N'Còn Hàng', N'Đã bán', N'Ẩn'));
ALTER TABLE Accounts ADD CONSTRAINT FK_Account_Seller FOREIGN KEY (NguoiDangBan) REFERENCES Users(username);

ALTER TABLE Accounts ADD CONSTRAINT FK_Account_Buyer FOREIGN KEY (NguoiMua) REFERENCES Users(username);


alter table accounts add BaoHanh char(10)

alter table accounts add NgayHetBaoHanh datetime

set dateformat dmy
insert into Accounts values(1,1,'hello','123',30000,N'Còn Hàng','admin',null,'01/05/2025','10 ngay','11/05/2025','abcdxyz')
insert into Accounts values(2,1,'hello1','1234',30000,N'Còn Hàng','admin',null,null,'10 ngay','11/05/2025','abcdxyz')
insert into Accounts values(3,1,'hello2','1253',30000,N'Còn Hàng','admin',null,null,'10 ngay','11/05/2025','abcdxyz')
insert into Accounts values(4,1,'hello3','1236',30000,N'Còn Hàng','admin',null,null,'10 ngay','11/05/2025','abcdxyz')
insert into Accounts values(5,1,'hello4','1f23',30000,N'Còn Hàng','admin',null,null,'10 ngay','11/05/2025','abcdxyz')
insert into Accounts values(6,1,'hello4','1f23',30000,N'Đã bán','admin',null,null,'10 ngay','11/05/2025','abcdxyz')
insert into Accounts values(7,1,'hello4','1f23',30000,N'Đã bán','admin',null,null,'10 ngay','11/05/2025','abcdxyz')
insert into Accounts values(8,1,'hello4','1f23',30000,N'Đã bán','admin',null,null,'10 ngay','11/05/2025','abcdxyz')
insert into Accounts values(9,1,'hello4','1f23',30000,N'Đã bán','admin',null,null,'10 ngay','11/05/2025','abcdxyz')


CREATE TABLE LoaiTaiKhoan (
    IdLoaiTaiKhoan INT PRIMARY KEY IDENTITY(1,1),  
    TenLoaiTaiKhoan NVARCHAR(100) NOT NULL UNIQUE
);

Insert into LoaiTaiKhoan(TenLoaiTaiKhoan) values('God CDK SG')
select * from LoaiTaiKhoan


create table LichSuNapTien(
	IdNaptien int not null primary key,
	TaiKhoanNapTien char(16),
	SoTienNap Decimal(18,2),
	NoiDungNapTien char(255),
	ThoiGianNap Datetime
)

 alter table LichSuNapTien add CONSTRAINT FK_NapTien_User FOREIGN KEY (TaiKhoanNapTien) REFERENCES Users(username)

ALTER TABLE LichSuNapTien ADD CONSTRAINT chk_SoTienNap CHECK (SoTienNap > 0);


create table DonHang(
	IdDonHang int not null primary key,
	NguoiMuaHang char(16),
	TongTienDon Decimal(18,2),
	ThoiGianTaoDon datetime
)

ALTER TABLE DonHang ADD CONSTRAINT FK_DonHang_User FOREIGN KEY (NguoiMuaHang) REFERENCES Users(username);


ALTER TABLE DonHang ADD CONSTRAINT chk1_TongTienDon CHECK (TongTienDon >= 0);



create table Chitietdonhang(
	IdChitietdonhang int not null primary key, 
	IdDonHang int not null,                    
	IdTaiKhoan int not null,                    
	GiaMua Decimal(18,2),          
	Soluongmua int          
)

alter table Chitietdonhang add CONSTRAINT FK_ChitietDonHang_DonHang FOREIGN KEY (IdDonHang) REFERENCES DonHang(IdDonHang)
alter table chitietdonhang add CONSTRAINT FK_ChitietDonHang_Account FOREIGN KEY (IdTaiKhoan) REFERENCES Accounts(idTaiKhoan)

create table LichSuGiaoDich (
    idGiaoDich int not null primary key,
    UserId char(16) not null,
    LoaiGiaoDich nvarchar(50),
    sotiengiaodich decimal(18,2),
    Motagiaodich nvarchar(255),
    ThoiGianGiaoDich datetime default GETDATE(),
)
ALTER TABLE LichSuGiaoDich ADD CONSTRAINT chk_GiaoDichSoTien CHECK (sotiengiaodich <> 0);

alter table LichSuGiaoDich add CONSTRAINT FK_TransactionUser FOREIGN KEY (UserID) REFERENCES Users(username)



Create table ThongTinThanhToan(
	STK char(100) not null primary key,
	TenCTK nvarchar(100),
	TenNH nvarchar(500)
)


Insert into ThongTinThanhToan values('1009483950','Phan Gia H1uy','Vietcombank')
Insert into ThongTinThanhToan values('1009288941','Phan Gia Hundg','Vietcombank')
Insert into ThongTinThanhToan values('1002783941','Phan Gia HegggHE','agribank')

select * from ThongTinThanhToan

--proceduce insert tttt
create proc Usp_InsertThongTinThanhToan
	@Pstk char(100),
	@PTenCTK nvarchar(100),
	@PTenNH nvarchar(500)
as
begin
	insert into ThongTinThanhToan(stk,TenCTK,TenNH) values(@Pstk,@PTenCTK,@PTenNH)
end

--proceduce delete tttt
create proc Usp_DeleteThongTinThanhToan1
	@Pstk char(100)
as 
begin
	delete from ThongTinThanhToan where STK=@Pstk
end

--proceduce update tttt
create proc Usp_UpdateThongTinThanhToan
	@Pstk char(100),
	@PTenCTK nvarchar(100),
	@PTenNH nvarchar(500)
as
begin
	update ThongTinThanhToan set TenCTK=@PTenCTK, TenNH=@PTenNH where STK=@Pstk
end

