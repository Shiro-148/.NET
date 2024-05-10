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

