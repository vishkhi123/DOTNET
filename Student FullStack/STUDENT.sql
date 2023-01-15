create database IACSD;
use IACSD;

create table student
(
    id int primary key,
    name varchar(50),
    place varchar(50)
);

insert into student values(1,"Vishal","Pune"),
(2,"Rupesh","WArora"),(3,"Prashant","nasik");