create database BTL
go
use BTL
go

create table Item
(
	ItemID char(8),
	ItemName varchar(500),
	Size int,
	primary key(ItemID)
)
go

create table Agent
(
	AgentID char(8),
	AgentName varchar(500),
	Address varchar(500),
	primary key(AgentID)
)
go

create table [Order]
(
	OrderID char(8),
	OrderDate datetime,
	AgentID char(8),
	primary key(OrderID),
	foreign key(AgentID) references Agent(AgentID)
)
go

create table OrderDetail
(
	ID char(8),
	OrderID char(8),
	ItemID char(8),
	Quantity int,
	UnitAmount int,
	primary key(ID),
	foreign key(OrderID) references [Order](OrderID),
	foreign key(ItemID) references Item(ItemID)
)
go

create table ProvinceList
(
	ProvinceID int identity,
    Province varchar(500) unique,
	primary key(ProvinceID)
)
go

create table BTLLoginData
(
	UserName char(500),
	UserPassword char(500),
	FullName varchar(500),
	DateOfBirth datetime,
	PhoneNumber char(10),
	Province varchar(500),
	primary key(UserName),
	foreign key(Province) references ProvinceList(Province)
)
go

insert into Item (ItemID, ItemName, Size) values
('ITM001', 'Item 1', 10),
('ITM002', 'Item 2', 20),
('ITM003', 'Item 3', 30),
('ITM004', 'Item 4', 40),
('ITM005', 'Item 5', 50),
('ITM006', 'Item 6', 60),
('ITM007', 'Item 7', 70),
('ITM008', 'Item 8', 80),
('ITM009', 'Item 9', 90),
('ITM010', 'Item 10', 100),
('ITM011', 'Item 11', 110),
('ITM012', 'Item 12', 120),
('ITM013', 'Item 13', 130),
('ITM014', 'Item 14', 140),
('ITM015', 'Item 15', 150),
('ITM016', 'Item 16', 160),
('ITM017', 'Item 17', 170),
('ITM018', 'Item 18', 180),
('ITM019', 'Item 19', 190),
('ITM020', 'Item 20', 200),
('ITM021', 'Item 21', 210),
('ITM022', 'Item 22', 220),
('ITM023', 'Item 23', 230),
('ITM024', 'Item 24', 240),
('ITM025', 'Item 25', 250),
('ITM026', 'Item 26', 260),
('ITM027', 'Item 27', 270),
('ITM028', 'Item 28', 280),
('ITM029', 'Item 29', 290),
('ITM030', 'Item 30', 300)
go

insert into Agent (AgentID, AgentName, Address) values
('AGT001', 'Agent 1', '123 Main St, Anytown USA'),
('AGT002', 'Agent 2', '456 Elm St, Anytown USA'),
('AGT003', 'Agent 3', '789 Oak St, Anytown USA'),
('AGT004', 'Agent 4', '234 Pine St, Anytown USA'),
('AGT005', 'Agent 5', '567 Maple St, Anytown USA'),
('AGT006', 'Agent 6', '890 Cedar St, Anytown USA'),
('AGT007', 'Agent 7', '1234 Walnut St, Anytown USA'),
('AGT008', 'Agent 8', '5678 Birch St, Anytown USA'),
('AGT009', 'Agent 9', '9012 Chestnut St, Anytown USA'),
('AGT010', 'Agent 10', '3456 Spruce St, Anytown USA'),
('AGT011', 'Agent 11', '7890 Hickory St, Anytown USA'),
('AGT012', 'Agent 12', '1234 Cherry St, Anytown USA'),
('AGT013', 'Agent 13', '5678 Poplar St, Anytown USA'),
('AGT014', 'Agent 14', '9012 Pineapple St, Anytown USA'),
('AGT015', 'Agent 15', '3456 Mango St, Anytown USA'),
('AGT016', 'Agent 16', '7890 Grape St, Anytown USA'),
('AGT017', 'Agent 17', '1234 Pear St, Anytown USA'),
('AGT018', 'Agent 18', '5678 Apple St, Anytown USA'),
('AGT019', 'Agent 19', '9012 Orange St, Anytown USA'),
('AGT020', 'Agent 20', '3456 Lemon St, Anytown USA'),
('AGT021', 'Agent 21', '7890 Lime St, Anytown USA'),
('AGT022', 'Agent 22', '1234 Banana St, Anytown USA'),
('AGT023', 'Agent 23', '5678 Papaya St, Anytown USA'),
('AGT024', 'Agent 24', '9012 Kiwi St, Anytown USA'),
('AGT025', 'Agent 25', '3456 Strawberry St, Anytown USA'),
('AGT026', 'Agent 26', '7890 Raspberry St, Anytown USA'),
('AGT027', 'Agent 27', '1234 Blueberry St, Anytown USA'),
('AGT028', 'Agent 28', '5678 Blackberry St, Anytown USA'),
('AGT029', 'Agent 29', '9012 Cranberry St, Anytown USA'),
('AGT030', 'Agent 30', '3456 Watermelon St, Anytown USA')
go

insert into [Order] (OrderID, OrderDate, AgentID) values
('ORD001', '2023-04-01 10:00:00', 'AGT001'),
('ORD002', '2023-04-02 11:00:00', 'AGT002'),
('ORD003', '2023-04-03 12:00:00', 'AGT003'),
('ORD004', '2023-04-04 13:00:00', 'AGT004'),
('ORD005', '2023-04-05 14:00:00', 'AGT005'),
('ORD006', '2023-04-06 15:00:00', 'AGT006'),
('ORD007', '2023-04-07 16:00:00', 'AGT007'),
('ORD008', '2023-04-08 17:00:00', 'AGT008'),
('ORD009', '2023-04-09 18:00:00', 'AGT009'),
('ORD010', '2023-04-10 19:00:00', 'AGT010'),
('ORD011', '2023-04-11 20:00:00', 'AGT011'),
('ORD012', '2023-04-12 21:00:00', 'AGT012'),
('ORD013', '2023-04-13 22:00:00', 'AGT013'),
('ORD014', '2023-04-14 23:00:00', 'AGT014'),
('ORD015', '2023-04-15 00:00:00', 'AGT015'),
('ORD016', '2023-04-16 01:00:00', 'AGT016'),
('ORD017', '2023-04-17 02:00:00', 'AGT017'),
('ORD018', '2023-04-18 03:00:00', 'AGT018'),
('ORD019', '2023-04-19 04:00:00', 'AGT019'),
('ORD020', '2023-04-20 05:00:00', 'AGT020'),
('ORD021', '2023-04-21 06:00:00', 'AGT021'),
('ORD022', '2023-04-22 07:00:00', 'AGT022'),
('ORD023', '2023-04-23 08:00:00', 'AGT023'),
('ORD024', '2023-04-24 09:00:00', 'AGT024'),
('ORD025', '2023-04-25 10:00:00', 'AGT025'),
('ORD026', '2023-04-26 11:00:00', 'AGT026'),
('ORD027', '2023-04-27 12:00:00', 'AGT027'),
('ORD028', '2023-04-28 13:00:00', 'AGT028'),
('ORD029', '2023-04-29 14:00:00', 'AGT029'),
('ORD030', '2023-04-30 15:00:00', 'AGT030')
go

insert into OrderDetail (ID, OrderID, ItemID, Quantity, UnitAmount) values
('OD001', 'ORD001', 'ITM001', 2, 100),
('OD002', 'ORD001', 'ITM002', 1, 50),
('OD003', 'ORD001', 'ITM003', 3, 150),
('OD004', 'ORD002', 'ITM002', 2, 50),
('OD005', 'ORD002', 'ITM004', 1, 200),
('OD006', 'ORD002', 'ITM005', 2, 300),
('OD007', 'ORD003', 'ITM003', 2, 150),
('OD008', 'ORD003', 'ITM005', 1, 300),
('OD009', 'ORD003', 'ITM006', 1, 500),
('OD010', 'ORD004', 'ITM001', 2, 100),
('OD011', 'ORD004', 'ITM004', 1, 200),
('OD012', 'ORD004', 'ITM006', 3, 500),
('OD013', 'ORD005', 'ITM002', 1, 50),
('OD014', 'ORD005', 'ITM003', 2, 150),
('OD015', 'ORD005', 'ITM005', 2, 300),
('OD016', 'ORD006', 'ITM001', 1, 100),
('OD017', 'ORD006', 'ITM004', 1, 200),
('OD018', 'ORD006', 'ITM006', 2, 500),
('OD019', 'ORD007', 'ITM002', 3, 50),
('OD020', 'ORD007', 'ITM003', 1, 150),
('OD021', 'ORD007', 'ITM004', 1, 200),
('OD022', 'ORD008', 'ITM001', 1, 100),
('OD023', 'ORD008', 'ITM003', 2, 150),
('OD024', 'ORD008', 'ITM005', 1, 300),
('OD025', 'ORD009', 'ITM002', 1, 50),
('OD026', 'ORD009', 'ITM004', 2, 200),
('OD027', 'ORD009', 'ITM006', 1, 500),
('OD028', 'ORD010', 'ITM001', 2, 100),
('OD029', 'ORD010', 'ITM002', 1, 50),
('OD030', 'ORD010', 'ITM004', 1, 200)
go

insert into ProvinceList(Province) values
('Alberta'),
('British Columbia'),
('Manitoba'),
('New Brunswick'),
('Newfoundland and Labrador'),
('Northwest Territories'),
('Nova Scotia'),
('Nunavut'),
('Ontario'),
('Prince Edward Island'),
('Quebec'),
('Saskatchewan'),
('Yukon'),
('Alabama'),
('Alaska'),
('Arizona'),
('Arkansas'),
('California'),
('Colorado'),
('Connecticut'),
('Delaware'),
('Florida'),
('Georgia'),
('Hawaii'),
('Idaho'),
('Illinois'),
('Indiana'),
('Iowa'),
('Kansas'),
('Kentucky')
go

insert into BTLLoginData (UserName, UserPassword, FullName, DateOfBirth, PhoneNumber, Province) values
('user1', 'password1', 'John Smith', '1990-01-01', '1234567890', 'Alberta'),
('user2', 'password2', 'Jane Doe', '1995-05-10', '1234567891', 'British Columbia'),
('user3', 'password3', 'David Johnson', '1985-03-15', '1234567892', 'Manitoba'),
('user4', 'password4', 'Amy Lee', '1992-07-20', '1234567893', 'New Brunswick'),
('user5', 'password5', 'Brian Wilson', '1980-11-25', '1234567894', 'Newfoundland and Labrador'),
('user6', 'password6', 'Catherine Brown', '1998-04-30', '1234567895', 'Northwest Territories'),
('user7', 'password7', 'Edward Davis', '1991-12-05', '1234567896', 'Nova Scotia'),
('user8', 'password8', 'Fiona Kim', '1987-09-01', '1234567897', 'Nunavut'),
('user9', 'password9', 'George Lee', '1993-06-10', '1234567898', 'Ontario'),
('user10', 'password10', 'Helen Chen', '1989-02-15', '1234567899', 'Prince Edward Island'),
('user11', 'password11', 'Isabel Jones', '1994-08-20', '1234567890', 'Quebec'),
('user12', 'password12', 'Jason Lee', '1983-10-25', '1234567891', 'Saskatchewan'),
('user13', 'password13', 'Kelly Wong', '1999-05-01', '1234567892', 'Yukon'),
('user14', 'password14', 'Lucas Garcia', '1992-03-05', '1234567893', 'Alabama'),
('user15', 'password15', 'Maggie Martinez', '1986-01-10', '1234567894', 'Alaska'),
('user16', 'password16', 'Nancy Brown', '1991-07-15', '1234567895', 'Arizona'),
('user17', 'password17', 'Oliver Kim', '1988-11-20', '1234567896', 'Arkansas'),
('user18', 'password18', 'Peter Lee', '1995-04-25', '1234567897', 'California'),
('user19', 'password19', 'Queenie Chen', '1991-06-30', '1264567898', 'Nunavut'),
('user20', 'password20', 'Robert Johnson', '1984-02-01', '1234567898', 'Colorado'),
('user21', 'password21', 'Samantha Davis', '1990-08-05', '1234567899', 'Connecticut'),
('user22', 'password22', 'Tom Lee', '1993-06-10', '1234567800', 'Delaware'),
('user23', 'password23', 'Uma Gupta', '1989-04-15', '1234567801', 'Florida'),
('user24', 'password24', 'Vincent Chen', '1992-12-20', '1234567802', 'Georgia'),
('user25', 'password25', 'Wendy Kim', '1987-10-25', '1234567803', 'Hawaii'),
('user26', 'password26', 'Xander Lee', '1996-05-01', '1234567804', 'Idaho'),
('user27', 'password27', 'Yara Ahmed', '1991-03-05', '1234567805', 'Illinois'),
('user28', 'password28', 'Zoe Kim', '1983-01-10', '1234567806', 'Indiana'),
('user29', 'password29', 'Adam Brown', '1994-07-15', '1234567807', 'Iowa'),
('user30', 'password30', 'Bella Lee', '1988-11-20', '1234567808', 'Kansas')
go

create procedure InsertItem
    @ItemName varchar(500),
    @Size int
as
begin
    declare @NewItemID char(8)
	declare @MaxID varchar(500)
	select @MaxID = cast(max(cast(substring(ItemID, 4, 8) as int)) + 1 as varchar) from Item
	while (len(@MaxID) < 3)
	begin
		set @MaxID = '0' + @MaxID
	end
    select @NewItemID = 'ITM' + @MaxID
    insert into Item (ItemID, ItemName, Size) values (@NewItemID, @ItemName, @Size)
end
go

exec InsertItem 'Item 31', 45
go

create procedure InsertAgent
    @AgentName varchar(500),
    @Address varchar(500)
as
begin
    declare @NewAgentID char(8)
	declare @MaxID varchar(500)
	select @MaxID = cast(max(cast(substring(AgentID, 4, 8) as int)) + 1 as varchar) from Agent
	while (len(@MaxID) < 3)
	begin
		set @MaxID = '0' + @MaxID
	end
    select @NewAgentID = 'AGT' + @MaxID
    insert into Agent (AgentID, AgentName, Address) values (@NewAgentID, @AgentName, @Address)
end
go

exec InsertAgent 'Agent 31', '458 Elm St, Anytown USA'
go

select * from Item
select * from Agent
select * from [Order]
select * from OrderDetail
select * from ProvinceList
select * from BTLLoginData
go