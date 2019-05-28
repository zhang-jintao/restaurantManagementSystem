use master
if exists(select * from sysdatabases where name = 'Restaurant')
drop database Restaurant
go
create database Restaurant
go
use Restaurant
go
-----------------------
--ʳ�ı�
if exists(select * from sysobjects where name = 'Crib')
drop table Crib
go
create Table Crib(
	CribId int not null identity(1,1) primary key,--ʳ�ı��
	CribName varchar(20) not null ,--ʳ������
	CribMoney money not null check (CribMoney>0),--ʳ�ļ۸�
	CribRepertory float not null check(CribRepertory>=0)--ʳ�Ŀ��
)
go
--��Ʒ��
if exists(select * from sysobjects where name = 'Menu')
drop table Menu
go
create Table Menu(
	DishId int not null identity(1,1) primary key,--��Ʒ���
	DishName varchar(20) not null ,--����
	DishMoney int not null check(DishMoney>0),--�˼۸�
	CribOne int not null foreign key references Crib(CribId),--ʳ��1
	CribTwo int not null foreign key references Crib(CribId),--ʳ��2
	CribOneX float not null check(CribOneX>0),--��Ҫʳ�ġ�1
	CribTwoX float not null check(CribTwoX>0)--��Ҫʳ�ġ�2
)
go
--��ˮ��
if exists(select * from sysobjects where name= 'Caudle')
drop table Caudle
go
create table Caudle(
	 CaudleId int not null identity(1,1) Primary key,--��ˮ���
	 CaudleName varchar(10) not null ,--��ˮ����
	 CaudleMoney money not null ,--��ˮ�۸�
	 CaudleGoldenCalf Money not null ,--��ˮ����
	 CaudleRepertory int not null check(CaudleRepertory>=0)--��ˮ���
)
go

--��ƷӪҵ���
if exists(select * from sysobjects where name='MenuTurnover')
drop table MenuTurnover
go
create table MenuTurnover(
	MenuId int foreign key references Menu(DishId),--��ƷId
	MenuNumber int ,--��Ʒ��������
	AllMoneyMenu money,--������Ʒ�������
	DateTimes Datetime not null--��ǰ��Ʒ����ʱ��
)
go
--��ˮӪҵ���
if exists(select * from sysobjects where name='CaudleTurnover')
drop table CaudleTurnover
go
create table CaudleTurnover(
	CaudleId int foreign key references Caudle(CaudleId),-- ��ˮId
	CaudleNumber int ,--��ˮ��������
	AllMoneyCaudle money ,--������ˮ�������
	DateTimes datetime not null--��ǰ��ˮ����ʱ��
)
go





------------------------------
--�ȼ���
if exists(select * from sysobjects where name='Level')
drop table [Level]
go
create table Level(
	LevelId int identity(1,1) not null primary key,
	LevelName varchar(10) not null
)
go
--Ա����
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
--���ʳ��
insert Crib(CribName,CribMoney,CribRepertory)
values('����',15,15),
	('ţ��',25,10),
	('����',22,5),
	('�Ź�',18,10),
	('�廨��',14,10),
	('�Ｙ',16,10),
	('ţ��',16,10),
	('����',16,10),
	('����',6,5),
	('����',6,5),
	('����',3,50),
	('�ڼ�',10,10),
	('ɽҩ',2,10),
	('�ײ�',2,10),
	('����',1,20),
	('���ܲ�',1,10),
	('ľ��',3,40),
	('����',1,40),
	('����',2,30),
	('����',4,30),
	('���ܲ�',1,10),
	('���',2,20),
	('����',2,20),
	('��ͷ',3,30),
	('�۲�',2,20),
	('�Ϲ�',3,50),
	('��ź',3,30),
	('�ӱ���',4,40),
	('Ģ��',2,10),
	('�Ͳ�',3,10),
	('����',2,10),
	('����',3,20),
	('�²�',2,30),
	('����',2,22),
	('���',3,30),
	('���',2,60),
	('��ź',6,10),
	('����',2,10),
	('��',3,30),
	('�ཷ',2,10),
	('�˻�',2,20),
	('������',1,10),
	('������',1,20),
	('����',1,30),
	('����',4,60),
	('����',1,30),
	('���빽',4,5),
	('����',20,12),
	('��ͷ��',22,5),
	('��ʳ�',15,20),
	('����',2,50),
	('������',2,20),
	('��Ȼ',10,30),
	('ʳ����',4,50),
	('�ɶ���',4,30),
	('���',1,100),
	('������',6,30)
go
--��Ӳ���
insert Menu(DishName,DishMoney,CribOne,CribTwo,CribOneX,CribTwoX)
values('����������',58,1,51,0.5,0.3),
('ţ��������',56,2,18,0.6,0.7),
('�ŹǶ�����',68,4,46,0.8,0.3),
('��Ȼ����',38,3,52,0.5,1),
('��ը�Ｙ',48,6,53,0.8,10.6),
('��������',36,9,21,0.8,0.5),
('������',28,19,18,0.5,0.5),
('�⽷�ɶ���',18,40,54,0.6,0.4),
('������',38,1,55,0.5,0.6),
('�����⽷',26,11,40,0.6,0.4),
('���ʲ���',18,31,56,0.6,0.8),
('ľ������',24,42,11,0.5,0.6)
go
--���Ա���ȼ�
insert Level(LevelName)
values('�ϰ�'),
('�곤')
go
--����û�
insert Admin(PersonnelLevel,LoginId,LoginPwd)
values(1,'1','1'),
(2,'2','2')
go
--��Ӿ�ˮ
insert Caudle (CaudleName,CaudleMoney,CaudleGoldenCalf,CaudleRepertory)
values ('�����',3,2,50),
('��θ',5,4,15),
('���򻨲�',3,2,24),
('����',8,7,10),
('��θ',10,9,10),
('��ơ',3,2,50),
('����',3,2,60),
('��ˬ',3,2,60),
('ѩ��ԭ֭��',3,2,60),
('�ൺԭ֭��',3,2,100),
('��Ȫ��ƿ',30,28,20),
('�ʼ�����',888,200,10)
go
select * from Crib--�鿴ʳ�ı�
select * from Menu--�鿴��Ʒ��
select * from Level--�鿴Ա���ȼ���
select * from Admin--�鿴�˻���
select * from Caudle--�鿴��ˮ��
select * from MenuTurnover--�����Ʒ�����
select * from CaudleTurnover--�����ˮ�����


--���ȼ��޸��˺�����
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
where menu.DishName like '%��%'
select * from Caudle
select * from Crib
where Crib.CribName like '%��%'
go
-----��ѯ��Ʒ����
create proc usp_menu
@one int output,
@two int output
as
select * from Menu