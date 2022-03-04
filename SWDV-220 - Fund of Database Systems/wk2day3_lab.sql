USE MyGuitarShop;
DROP INDEX IF EXISTS Addresses.IX_Addresses_Zip;
CREATE NONCLUSTERED INDEX IX_Addresses_Zip
	ON Addresses(Zipcode);
DROP DATABASE IF EXISTS MyWebDB;
GO
CREATE DATABASE MyWebDB;
GO
USE MyWebDB;
CREATE TABLE Users(
	UserID INT NOT NULL PRIMARY KEY
	, EmailAddress VARCHAR(320) NOT NULL UNIQUE
	, FirstName NVARCHAR(100) NOT NULL
	, LastName NVARCHAR(100) NOT NULL
);

CREATE TABLE Products(
	ProductID INT NOT NULL IDENTITY PRIMARY KEY
	, ProductName NVARCHAR(100) NOT NULL
);

CREATE TABLE Downloads(
	DownloadID INT NOT NULL IDENTITY PRIMARY KEY
	, UserID INT NOT NULL REFERENCES Users(UserID)
	, DownloadDate DATETIME2 NOT NULL
	, FileName VARCHAR(255) NOT NULL
	, ProductID INT NOT NULL REFERENCES Products(ProductID)
);

ALTER TABLE Products
	ADD Price DECIMAL(5,2) NOT NULL DEFAULT 9.99
	, DateAdded DATETIME2 NOT NULL DEFAULT GETDATE()

ALTER TABLE Users
	ALTER COLUMN FirstName NVARCHAR(20) NOT NULL;

use master;
go
drop database if exists employee;
go
create database employee;
go

use employee;
go
create table emp (
employeeID int not null primary key,
fname varchar(45) not null,
lname varchar(45) not null,
mname varchar(45) null,
dob date not null,
phonevar char(15) null
)


create table dependent (
dependentID int not null primary key,
fname varchar(45) not null,
lname varchar(45) not null,
mname varchar(45) null,
dob date not null,
employeeID int not null references emp(employeeID)
);

