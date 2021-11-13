create table usertable(
id int ,
[name] varchar(30)not null,
lastname varchar(30),
age int not null,
email varchar(50)not null,
primary key (id),

)


select * from usertable

insert into usertable values (1,'test','test',23,'test@email.com')