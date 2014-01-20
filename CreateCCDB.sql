/* Datatabase and Table Creation */
CREATE DATABASE MarlaCapstone
GO 
Use MarlaCapstone
Go

create table userlogin
(ID INT PRIMARY KEY IDENTITY Not Null,
username varchar(20) not null,
user_password varchar(15) not null,
user_firstname varchar(15) not null,
user_last_name varchar(30) not null,
active bit not null)


create table employee
(emp_id int not null PRIMARY KEY IDENTITY,
first_name varchar(15) not null,
last_name varchar(30) not null,
street_address varchar(50) not null,
city varchar(25) not null,
state_abbrev char(2) not null,
zip_code char(5) not null,
ssn char(9) not null,
email varchar(100) null,
birthday date not null,
active bit not null,
userID INT not null FOREIGN KEY References userlogin(ID))

create table customers
(cust_id int not null PRIMARY KEY IDENTITY,
first_name varchar(15) not null,
last_name varchar(30) not null,
street_address varchar(50) null,
city varchar(25)  null,
state_abbrev char(2) null,
zip_code char(5) not null,
birthday date null,
email varchar(100) not null)

create table employment
(emp_rec int not null PRIMARY KEY IDENTITY,
emp_id int not null FOREIGN KEY References employee(emp_id),
hire_date date not null,
end_date date null,
reason varchar(200) null,
rehireable bit null,
userID INT not null FOREIGN KEY References userlogin(ID))

create table guestbook
(entry_num int not null PRIMARY KEY IDENTITY,
first_name varchar(15) not null,
last_name varchar(30) not null,
city varchar(25) not null,
state_abbrev char(2) not null,
email varchar(100) null,
comment_area varchar(250) not null)

create table site_admins
(admin_ID int not null PRIMARY KEY IDENTITY,
userID INT not null FOREIGN KEY References userlogin(ID),
active bit not null)

create table inventory
(in_stock int PRIMARY KEY IDENTITY not null,
qty_limited bit not null,
can_order bit not null,
reorder bit not null,)

create table products
(item_number int not null PRIMARY KEY identity,
item_name varchar(100) not null,
item_type varchar(100) not null,
item_description varchar(250) not null,
more_info varchar(250) null,
inventory int not null FOREIGN KEY references inventory(in_stock))

/* End of first set of tables */