create table guestbook
(entry_num int not null PRIMARY KEY IDENTITY,
first_name varchar(15) not null,
last_name varchar(30) not null,
city varchar(25) not null,
state_abbrev char(2) not null,
email varchar(100) null,
comment_area varchar(250) not null)