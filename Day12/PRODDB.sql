create database Prodb;
use Prodb;

create table Product
(
    Id int primary key auto_increment,
    Name varchar(50), 
    Description varchar(100) ,
    Image varchar(100),
    Price decimal(9,0)
);

insert into Product values
(1,'Iphone 6','Iphone 6','iphone6.jpg',10000000),
(2,'Iphone 6s','Iphone 6s','iphone6s.jpg',12000000),
(3,'Iphone 7','Iphone 7','iphone7.jpg',15000000),
(4,'Iphone 7s','Iphone 7s','iphone7s.jpg',17000000),
(5,'Iphone 8','Iphone 8','iphone8.jpg',20000000),
(6,'Iphone 8s','Iphone 8s','iphone8s.jpg',22000000),
(7,'Iphone X','Iphone X','iphonex.jpg',25000000),
(8,'Iphone XS','Iphone XS','iphonexs.jpg',27000000),
(9,'Iphone XS Max','Iphone XS Max','iphonexsmax.jpg',30000000),
(10,'Iphone 11','Iphone 11','iphone11.jpg',35000000),
(11,'Iphone 11 Pro','Iphone 11 Pro','iphone11pro.jpg',40000000),
(12,'Iphone 11 Pro Max','Iphone 11 Pro Max','iphone11promax.jpg',45000000),
(13,'Iphone 12','Iphone 12','iphone12.jpg',50000000),
(14,'Iphone 12 Pro','Iphone 12 Pro','iphone12pro.jpg',55000000),
(15,'Iphone 12 Pro Max','Iphone 12 Pro Max','iphone12promax.jpg',60000000),
(16,'Iphone 13','Iphone 13','iphone13.jpg',65000000),
(17,'Iphone 13 Pro','Iphone 13 Pro','iphone13pro.jpg',70000000),
(18,'Iphone 13 Pro Max','Iphone 13 Pro Max','iphone13promax.jpg',75000000),
(19,'Iphone 14','Iphone 14','iphone14.jpg',80000000),
(20,'Iphone 14 Pro','Iphone 14 Pro','iphone14pro.jpg',85000000),
(21,'Iphone 14 Pro Max','Iphone 14 Pro Max','iphone14promax.jpg',90000000);


