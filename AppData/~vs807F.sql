create database QuanLyAccount

use QuanLyAccount

create table Users(
	username char(16) not null primary key,
	pass char(100)
)

create table Accounts(
	taikhoan char(50) not null primary key,
	matkhau char(100),
	cookie char(5000),
	email char(100),
	tel char(20),
	username char(16)
)

alter table Accounts add constraint fk1_username foreign key (username) references Users(username)

alter table Accounts add constraint dfault_Cookie default'none' for cookie
alter table Accounts add constraint dfault_email default'none' for email
alter table Accounts add constraint dfault_tel default'none' for tel

insert into Users values('admin','admin123')
insert into Users values('admin1','admin123')

select * from Users

insert into Accounts values('farmert_7','Conmemaybeo','','','','admin')
insert into Accounts values('farmert_6','Conmemaybeo','','','','admin1')

select *
from Accounts
where username = 'admin1'


CREATE proc Usp1_InsertUsers
-- Khai báo các tham s? c?a stored procedure
@username Nvarchar(16),
@pass Nvarchar(35)
AS
BEGIN
-- Thêm m?t Khoa m?i vào b?ng KHOA
INSERT INTO Users(username, pass) VALUES(@username,@pass)
END

--check user xem co´ tô`n ta`i chua
CREATE PROCEDURE Usp1_CheckUsernameExists
    @username char(16)
AS
BEGIN
    SELECT COUNT(*) FROM Users WHERE username = @username
END