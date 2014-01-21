/* Datatabase and Table Creation */
CREATE DATABASE MarlaCapstone
GO 
Use MarlaCapstone
Go

create table [dbo].[userlogin](
[ID] [INT] PRIMARY KEY IDENTITY (1,1) Not Null,
[Username] varchar(20) not null,
[Password] varchar(15) not null,
[First_Name] varchar(15) not null,
[Last_Name] varchar(30) not null,
[Email] varchar(100) not null,
[Active] bit not null DEFAULT ((1))
)


create table [dbo].[employee](
[Emp_ID] int not null PRIMARY KEY IDENTITY,
[First_Name] varchar(15) not null,
[Last_Name] varchar(30) not null,
[Street_Address] varchar(50) not null,
[City] varchar(25) not null,
[State_2] char(2) not null,
[Zip_5] char(5) not null,
[SSN] char(9) not null,
[Email] varchar(100) null,
[Birthday] date not null,
[Active] bit not null DEFAULT ((1)),
[UserID] INT not null FOREIGN KEY References userlogin(ID)
)

create table [dbo].[customers](
[Cust_ID] int not null PRIMARY KEY IDENTITY,
[First_Name] varchar(15) not null,
[Last_Name] varchar(30) not null,
[Street_Address] varchar(50) null,
[City] varchar(25)  null,
[State_2] char(2) null,
[Zip_5] char(5) not null,
[Birthday] date null,
[Email] varchar(100) not null
)

create table [dbo].[employment](
[Emp_Rec] int not null PRIMARY KEY IDENTITY,
[Emp_ID] int not null FOREIGN KEY References employee(emp_id),
[Hire_Date] date not null,
[End_Date] date null,
[Reason] varchar(200) null,
[Rehireable] bit null,
[UserID] INT not null FOREIGN KEY References userlogin(ID)
)

create table [dbo].[guestbook](
[Entry] int not null PRIMARY KEY IDENTITY,
[First_Name] varchar(15) not null,
[Last_Name] varchar(30) not null,
[City] varchar(25) not null,
[State_2] char(2) not null,
[Email] varchar(100) null,
[Comment_Area] varchar(500) not null)

/* create table site_admins
(admin_ID int not null PRIMARY KEY IDENTITY,
userID INT not null FOREIGN KEY References userlogin(ID),
active bit not null) */

create table [dbo].[inventory](
[inv_nbr] int primary key identity not null,
in_stock int not null,
qty_limited bit not null,
can_order bit not null,
reorder bit not null
)

create table [dbo].[products]
(item_number int not null PRIMARY KEY identity,
item_name varchar(100) not null,
item_type varchar(100) not null,
item_description varchar(500) not null,
more_info varchar(250) null,
inventory int not null FOREIGN KEY references inventory(in_stock))

/* End of first set of tables */

/*insert values into userlogin from mvc */
Create PROCEDURE [dbo].[CreateUserLogin]
@Username VARCHAR(100),
@Password VARCHAR(25),
@First_Name VARCHAR(15),
@Last_Name VARCHAR(30),
@Email Varchar(100),
@Active BIT
AS
BEGIN
INSERT INTO userlogin
VALUES (@Username, @Password, @First_Name, @Last_Name, @Email, @Active)
END



