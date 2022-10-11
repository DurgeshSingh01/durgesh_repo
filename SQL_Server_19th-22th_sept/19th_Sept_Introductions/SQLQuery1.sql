--1) create a database Shopping
create database Shopping
use Shopping


--a) create table customer having custid,custname,city,state
create table Customer
(
Custid int primary key,
CustName varchar(20) ,
City varchar(20) , 
StateName varchar(20)
);


--b) create table products having prodid,prodname,unitprice,UnitOfMeasurement,QtyinStock
create table products
(Prodid int primary key,
ProdName varchar(20),
UnitPrice int ,
UnitOfMeasurement varchar(20),
QtyinStock int
);



--c) Create a table sales_header invno,invdate,invamt,disPercent
create table Sales_Header
(
InvoiceNo int primary key,
InvoiceDate date,
InvoiceAmt int,
DiscountPercent int
);


--d) create a table sales_detail invno,custid,prodid,qtysold
create table Sales_Detail
(
InvoiceNo int,
Custid int,
Prodid int,
QtySold int
);


--e)Create foreign key of invno in the sales_detail table.
alter table Sales_Detail
add foreign key(InvoiceNo) references Sales_Header(InvoiceNo)


--3) alter the sales_detail to apply a foreign key to custid and prodid.
alter table Sales_Detail
add foreign key(Custid) references Customer(Custid), foreign key(Prodid) references products(Prodid)


--4) Drop a column qtySold.
alter table Sales_Detail
drop column QtySold


--5) Add a column Qty.
alter table Sales_Detail
add Qty int


--6) rename qty to Quantity(InNos)
exec sp_rename 'Sales_Detail.qty',  'Quality', 'column';


--GitHub's Assignment...	
use master
create database Library
use Library

create table Member
(
Member_ID int primary key,
Member_Name Char(25),
Acc_Open_Date Date,
Max_Books_Allowed int,
Penalty_Amount int
);

create table Book
(
Book_No int primary key,
Book_Name varchar(30),
Author Char(30),
Cost int,
Category Char(10)
);

create table Issue
(
Lib_Issue_Id int primary key,
Book_No int foreign key references Book(Book_No),
Member_Id int foreign key references Member(Member_Id),
Issue_Date Date,
Return_date Date
);