create database QuanLyQuanCafe
go

USE QuanLyQuanCafe
GO

CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Bàn không có tên',
	status NVARCHAR(100) NOT NULL DEFAULT N'Trống'
)
GO

CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Shiro',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL DEFAULT 0

)
GO

CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Không có tên'
)
GO

CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Không có tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0

	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	idTable INT NOT NULL,
	status INT NOT NULL DEFAULT 0

	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0

	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
)
GO	

INSERT INTO Dbo.Account
	(UserName ,
	DisplayName ,
	PassWord, 
	Type
	)

VALUES ( N'Shiro',
		N'Shiro',
		N'1',
		1
		)

INSERT INTO Dbo.Account
	(UserName ,
	DisplayName ,
	PassWord, 
	Type
	)

VALUES ( N'staff',
		N'staff',
		N'1',
		0
		)
GO

CREATE PROC USP_GetAccountByUserName
@userName NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName
END
GO

EXEC dbo.USP_GetAccountByUserName @userName = N'Shiro'

GO

CREATE PROC USP_Login
@userName NVARCHAR(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END

GO

--Them  ban
declare @i int = 0

while @i <= 10
begin
	insert dbo.TableFood (name ) values (N'Bàn ' + cast(@i AS NVARCHAR(100)))
	set @i = @i + 1
end

select * from dbo.TableFood
--delete from dbo.TableFood Where id < 200
--DBCC CHECKIDENT('TableFood', RESEED, 0)
GO

CREATE PROC USP_GetTableList
AS SELECT * FROM dbo.TableFood
GO

update dbo.TableFood SET status = N'Có người' where id = 3

EXEC dbo.USP_GetTableList

GO

--them category
insert dbo.FoodCategory 
		(name)
values (N'Hải sản')
insert dbo.FoodCategory 
		(name)
values (N'Nông sản')
insert dbo.FoodCategory 
		(name)
values (N'Nước')

--Them mon an

insert dbo.Food 
		(name, idCategory, price)
values (N'Mực hấp', 1, 120000)

insert dbo.Food 
		(name, idCategory, price)
values (N'Cua rang me', 1, 200000)

insert dbo.Food 
		(name, idCategory, price)
values (N'Rau sống', 3, 30000)

insert dbo.Food 
		(name, idCategory, price)
values (N'Thịt lợn nướng', 2, 100000)

insert dbo.Food 
		(name, idCategory, price)
values (N'7Up', 3, 12000)

insert dbo.Food 
		(name, idCategory, price)
values (N'Sting', 3, 12000)

insert dbo.Food 
		(name, idCategory, price)
values (N'Bia', 3, 10000)

insert dbo.Bill
		(DateCheckIn,
		DateCheckOut,
		idTable,
		status
		)
values (GETDATE() ,
		NULL,
		1,
		0
		)

insert dbo.Bill
		(DateCheckIn,
		DateCheckOut,
		idTable,
		status
		)
values (GETDATE() ,
		NULL,
		2,
		0
		)

insert dbo.Bill
		(DateCheckIn,
		DateCheckOut,
		idTable,
		status
		)
values (GETDATE() ,
		GETDATE() ,
		2,
		1
		)

--Them bill info

insert dbo.BillInfo
		(idBill,
		idFood,
		count
		)
values (1,
		1,
		2
		)

insert dbo.BillInfo
		(idBill,
		idFood,
		count
		)
values (1,
		2,
		3
		)
insert dbo.BillInfo
		(idBill,
		idFood,
		count
		)
values (1,
		3,
		4
		)

insert dbo.BillInfo
		(idBill,
		idFood,
		count
		)
values (1,
		3,
		2
		)

insert dbo.BillInfo
		(idBill,
		idFood,
		count
		)
values (2,
		3,
		4
		)

insert dbo.BillInfo
		(idBill,
		idFood,
		count
		)
values (3,
		2,
		4
		)
insert dbo.BillInfo
		(idBill,
		idFood,
		count
		)
values (1,
		6,
		1
		)

GO

select f.name, bi.count, f.price, f.price*bi.count as totalPrice from dbo.BillInfo as bi, dbo.Bill as b, dbo.Food as f
where bi.idBill = b.id and bi.idFood = f.id and b.idTable = 1

select * from dbo.Bill
select * from dbo.BillInfo
select * from dbo.Food
select * from dbo.FoodCategory
select * from dbo.Food

GO
CREATE PROC USP_InsertBill 
@idTable int 
as
begin
	insert dbo.Bill
		( DateCheckIn,
		  DateCheckOut,
		  idTable,
		  status,
		  discount
		)
	values (GETDATE() ,
			NULL,
			@idTable,
			0,--status
			0
			)
end

GO
create Proc USP_InsertBillInfo 
@idBill int, @idFood int, @count int
as 
begin
	insert dbo.BillInfo
		(idBill,idFood,count)
	values (@idBill,@idFood,@count)
end
go
create Proc USP_InsertBillInfo 
@idBill int, @idFood int, @count int
as 
begin
	declare @isExitsBillInfo INT;
	declare @foodCount int = 1
	select @isExitsBillInfo = id, @foodCount = b.count
	from dbo.BillInfo as b
	where idBill = @idBill and idFood = @idFood
	if (@isExitsBillInfo > 0)
	begin
		declare @newCount int = @foodCount +@count 
		if(@newCount > 0)
			update dbo.BillInfo set count = @foodCount + @count where idFood = @idFood
		else 
			delete dbo.BillInfo where idBill = @idBill AND idFood = @idFood 
	end
	else
	begin
		insert dbo.BillInfo
			(idBill, idFood, count)
		values (@idBill, @idFood, @count)
	end
end
GO

--UPDATE dbo.Bill SET  status = 1 where id = 1
go

	delete dbo.BillInfo
	delete dbo.Bill


create TRIGGER UTG_UpdateBillInfor
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
   DECLARE @idBill INT 
   SELECT @idBill = idBill from Inserted
   DECLARE @idTable INT
   SELECT @idTable = idTable from dbo.Bill where id = @idBill AND status = 0
   update dbo.TableFood set status = N'Có người' where	id = @idTable
END
GO
	
create TRIGGER UTG_UpdateBill
ON dbo.Bill FOR UPDATE 
AS
BEGIN
   DECLARE @idBill INT 
   SELECT @idBill = id  from Inserted
   --DECLARE @count INT
   DECLARE @idTable INT
   SELECT @idTable = idTable from dbo.Bill where id = @idBill
   DECLARE @count INT = 0
   select @count = COUNT(*) from dbo.Bill	where idTable = @idTable AND status = 0
   if (@count = 0)
   update dbo.TableFood set status = N'Trống' where id = @idTable
END
GO

ALTER TABLE dbo.Bill ADD totalPrice Float
delete dbo.BillInfo
GO

CREATE PROC USP_GetListBillBydate
@checkIn date, @checkOut date
AS
BEGIN
	select t.name as [Tên bàn], discount  as [Giảm giá], b.totalPrice AS [Tổng tiền], DateCheckIn[Ngày vào], DateCheckOut AS[Ngày ra]
	from dbo.Bill AS b, dbo.TableFood AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.idTable
END
GO


