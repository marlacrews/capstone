BEGIN

CREATE DATABASE ClaxtonConnections

create table employee
(emp_id int not null PRIMARY KEY,
first_name varchar(15) not null,
last_name varchar(30) not null,
street_address varchar(50) not null,
city varchar(25) not null,
state_abbrev char(2) not null,
zip_code char(5) not null,
ssn char(9) not null,
email varchar(100) null,
birthday date not null,
dir_dep bit not null,
active bit not null,
username varchar(20) not null FOREIGN KEY References userlogin(username);

create table customers
(cust_id int not null PRIMARY KEY,
first_name varchar(15) not null,
last_name varchar(30) not null,
street_address varchar(50) null,
city varchar(25) not null,
state_abbrev char(2) not null,
zip_code char(5) not null,
birthday date null,
email varchar(100) not null,
username varchar(20) FOREIGN KEY references login(username));

create table login
(username varchar(20) not null PRIMARY KEY,
user_password varchar(15) not null,
user_firstname varchar(15) not null,
user_last_name varchar(30) not null,
active bit not null);

create table employment
(emp_rec int not null PRIMARY KEY,
emp_id int not null FOREIGN KEY References employee(emp_id),
hire_date date not null,
end_date date null,
reason varchar(200) null,
rehireable bit null,
username varchar(20) FOREIGN KEY references login(username));

create table guestbook
(id_num int not null PRIMARY KEY,
first_name varchar(15) not null,
last_name varchar(30) not null,
city varchar(25) not null,
state_abbrev char(2) not null,
email varchar(100) null,
comment_area varchar(250) not null);

create table tax_rate
(tax_id char(3) not null PRIMARY KEY,
tax_label varchar(25) not null,
rates decimal not null);

create table site_admins
(admin_name varchar not null PRIMARY KEY,
username varchar (20) not null FOREIGN KEY references login(username),
password varchar(15) not null FOREIGN KEY references login(password)
active bit not null);

create table products
(item_number int not null PRIMARY KEY,
item_name varchar(100) not null,
item_type varchar(100) not null,
item_description varchar(250) not null,
more_info varchar(100) not null,
inventory int not null FOREIGN KEY references inventory(in_stock));

create table inventory
(item_number int FOREIGN KEY references product(item_number),
in_stock int,
qty_limited bit not null,
reorder bit not null,);