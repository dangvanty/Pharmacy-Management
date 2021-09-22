create database ctyMinhDan
use ctyMinhDan

-- tạo bảng users
create table users(
id int identity(1,1) primary key,
userRole nvarchar(50) not null,
name nvarchar(250) not null,
dob varchar(250) not null,
mobile varchar(11) not null,
email varchar(250) not null,
username varchar(250) unique not null,
pass varchar(100) not null
)
go
 select *from users
delete from users
 -----------------------

 -- tạo bảng hàng hóa

create table HangHoa(
id int identity(1,1) primary key,
idHangHoa varchar(50) not null,
HHname nvarchar(200) not null,
HHnumber nvarchar(200) not null,
mDate varchar (200) not null,
eDate varchar (200) not null,
quantity bigint not null,
perUnit bigint not null
)
go 
--idHangHoa,HHname,HHnumber,mDate,eDate,quantity,perUnit
select *from HangHoa
select count(HHname) from HangHoa where eDate>= format(getDate(),'dd/MM/yyy')
select count(HHname) from HangHoa where eDate<=getDate()
select HHname from HangHoa where eDate>= format(getDate(),'dd/MM/yyy') and quantity >'0'
---------------
select idHangHoa,eDate,perUnit from HangHoa where HHname=