drop table quantity;
create table Quantity(Id int not null primary key , code varchar not null , name varchar not null);
alter table Quantity alter column code nvarchar(100) ;
alter table Quantity alter column name nvarchar(100) ;