use master
if exists(select * from sysdatabases where name = 'Restaurant')
drop database Restaurant
go
create database Restaurant
go
use Restaurant
go
-----------------------
--食材表
if exists(select * from sysobjects where name = 'Crib')
drop table Crib
go
create Table Crib(
	CribId int not null identity(1,1) primary key,--食材编号
	CribName varchar(20) not null ,--食材名称
	CribMoney money not null check (CribMoney>0),--食材价格
	CribRepertory float not null check(CribRepertory>=0)--食材库存
)
go
--菜品表
if exists(select * from sysobjects where name = 'Menu')
drop table Menu
go
create Table Menu(
	DishId int not null identity(1,1) primary key,--菜品编号
	DishName varchar(20) not null ,--菜名
	DishMoney int not null check(DishMoney>0),--菜价格
	CribOne int not null foreign key references Crib(CribId),--食材1
	CribTwo int not null foreign key references Crib(CribId),--食材2
	CribOneX float not null check(CribOneX>0),--需要食材·1
	CribTwoX float not null check(CribTwoX>0)--需要食材·2
)
go
--酒水表
if exists(select * from sysobjects where name= 'Caudle')
drop table Caudle
go
create table Caudle(
	 CaudleId int not null identity(1,1) Primary key,--酒水编号
	 CaudleName varchar(10) not null ,--酒水名称
	 CaudleMoney money not null ,--酒水价格
	 CaudleGoldenCalf Money not null ,--酒水进价
	 CaudleRepertory int not null check(CaudleRepertory>=0)--酒水库存
)
go

--菜品营业额表
if exists(select * from sysobjects where name='MenuTurnover')
drop table MenuTurnover
go
create table MenuTurnover(
	MenuId int foreign key references Menu(DishId),--菜品Id
	MenuNumber int ,--菜品卖出次数
	AllMoneyMenu money,--卖出菜品获得利润
	DateTimes Datetime not null--当前菜品卖出时间
)
go
--酒水营业额表
if exists(select * from sysobjects where name='CaudleTurnover')
drop table CaudleTurnover
go
create table CaudleTurnover(
	CaudleId int foreign key references Caudle(CaudleId),-- 酒水Id
	CaudleNumber int ,--酒水卖出次数
	AllMoneyCaudle money ,--卖出酒水获得利润
	DateTimes datetime not null--当前酒水卖出时间
)
go





------------------------------
--等级表
if exists(select * from sysobjects where name='Level')
drop table [Level]
go
create table Level(
	LevelId int identity(1,1) not null primary key,
	LevelName varchar(10) not null
)
go
--员工表
if exists(select * from sysobjects where name='Admin')
drop table Admin
go
create table Admin(
	PersonnelLevel int not null foreign key references [Level](LevelId),
	LoginId varchar(20) not null primary key,
	LoginPwd varchar(20) not null
)
go

--------------------------------
--添加食材
insert Crib(CribName,CribMoney,CribRepertory)
values('猪肉',15,15),
	('牛肉',25,10),
	('羊肉',22,5),
	('排骨',18,10),
	('五花肉',14,10),
	('里脊',16,10),
	('牛排',16,10),
	('羊排',16,10),
	('鸡肉',6,5),
	('鸡翅',6,5),
	('鸡蛋',3,50),
	('乌鸡',10,10),
	('山药',2,10),
	('白菜',2,10),
	('豆腐',1,20),
	('白萝卜',1,10),
	('木耳',3,40),
	('土豆',1,40),
	('茄子',2,30),
	('豆角',4,30),
	('胡萝卜',1,10),
	('洋葱',2,20),
	('红薯',2,20),
	('芋头',3,30),
	('芹菜',2,20),
	('南瓜',3,50),
	('莲藕',3,30),
	('杏鲍菇',4,40),
	('蘑菇',2,10),
	('油菜',3,10),
	('菠菜',2,10),
	('蒜苗',3,20),
	('韭菜',2,30),
	('生菜',2,22),
	('香菜',3,30),
	('香葱',2,60),
	('莲藕',6,10),
	('辣根',2,10),
	('洋姜',3,30),
	('青椒',2,10),
	('菜花',2,20),
	('西红柿',1,10),
	('西兰花',1,20),
	('大蒜',1,30),
	('冬瓜',4,60),
	('玉米',1,30),
	('金针菇',4,5),
	('银耳',20,12),
	('猪头肉',22,5),
	('猪肥肠',15,20),
	('粉条',2,50),
	('西兰花',2,20),
	('孜然',10,30),
	('食用油',4,50),
	('干豆腐',4,30),
	('面粉',1,100),
	('花生米',6,30)
go
--添加菜谱
insert Menu(DishName,DishMoney,CribOne,CribTwo,CribOneX,CribTwoX)
values('猪肉炖粉条',58,1,51,0.5,0.3),
('牛肉烧土豆',56,2,18,0.6,0.7),
('排骨顿玉米',68,4,46,0.8,0.3),
('孜然羊肉',38,3,52,0.5,1),
('油炸里脊',48,6,53,0.8,10.6),
('宫保鸡丁',36,9,21,0.8,0.5),
('地三鲜',28,19,18,0.5,0.5),
('尖椒干豆腐',18,40,54,0.6,0.4),
('锅包肉',38,1,55,0.5,0.6),
('锅塌尖椒',26,11,40,0.6,0.4),
('果仁菠菜',18,31,56,0.6,0.8),
('木须柿子',24,42,11,0.5,0.6)
go
--添加员工等级
insert Level(LevelName)
values('老板'),
('店长')
go
--添加用户
insert Admin(PersonnelLevel,LoginId,LoginPwd)
values(1,'1','1'),
(2,'2','2')
go
--添加酒水
insert Caudle (CaudleName,CaudleMoney,CaudleGoldenCalf,CaudleRepertory)
values ('冰红茶',3,2,50),
('开胃',5,4,15),
('茉莉花茶',3,2,24),
('大红茶',8,7,10),
('大开胃',10,9,10),
('哈啤',3,2,50),
('冰纯',3,2,60),
('冰爽',3,2,60),
('雪花原汁麦',3,2,60),
('青岛原汁麦',3,2,100),
('玉泉方瓶',30,28,20),
('皇家礼炮',888,200,10)
go
select * from Crib--查看食材表
select * from Menu--查看菜品表
select * from Level--查看员工等级表
select * from Admin--查看账户表
select * from Caudle--查看酒水表
select * from MenuTurnover--保存菜品利润表
select * from CaudleTurnover--保存酒水利润表


--按等级修改账号密码
update Admin set LoginPwd='1' where LoginId='1'
update Admin set LoginPwd='2' where LoginId='1'
-----------------------
select CaudleName,CaudleNumber,AllMoneyCaudle,DateTimes from CaudleTurnover inner join Caudle on CaudleTurnover.CaudleId=caudle.CaudleId
where '1905-6-15'<DateTimes and DateTimes<'2017-12-22'
select DishName,MenuNumber,AllMoneyMenu,DateTimes from MenuTurnover inner join Menu on MenuTurnover.MenuId=menu.DishId
where '1906/5/11'<DateTimes and DateTimes<'2017/12/22'
insert CaudleTurnover(CaudleId,CaudleNumber,AllMoneyCaudle,DateTimes)
values(1,2,23,2017-09-09)
insert MenuTurnover(MenuId,MenuNumber,AllMoneyMenu,DateTimes)
values(1,3,23,3016-06-10)
----------------------
select * from Menu
select DishId,DishName,DishMoney,CribName,CribName,CribOneX,CribTwoX
from Menu inner join Crib on crib.CribId=menu.CribOne and crib.CribId=menu.CribTwo 
where menu.DishName like '%猪%'
select * from Caudle
select * from Crib
where Crib.CribName like '%猪%'
go
-----查询菜品事物
create proc usp_menu
@one int output,
@two int output
as
select * from Menu