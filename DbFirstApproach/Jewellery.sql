create table Vendor(VendorId int primary key not null,
VendorName varchar(50),VendorAddress varchar(50), VendorNo varchar(50));
go

drop table Vendor;

create table Customer(CustomerId int primary key not null, CustomerName varchar(50),
CustomerAddress varchar(50),PurchaseDate Date);
go

drop table Customer;

create table Product(ProductId int primary key not null,ProductPrice float,ProductQty int,
VendorId int foreign key references Vendor(VendorId));
go

drop table Product;

create table Orders(OrderId int primary key not null,
VendorId int foreign key references Vendor(VendorId),
CustomerId int foreign key references Customer(CustomerId),
ProductId int foreign key references Product(ProductId),
CategoryId int foreign key references Category(CategoryId),
OrderDate Date, Amount float,Quantity int);
go

drop table Orders;

create table Category(CategoryId int primary key,CategoryName varchar(50),CQty int);
go

drop table Category;