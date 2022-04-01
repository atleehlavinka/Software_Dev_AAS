USE MyGuitarShop
GO

--1
INSERT INTO Categories
VALUES ('Brass')

--2.
SELECT * FROM Categories
UPDATE Categories
SET CategoryName = 'Woodwinds'
WHERE CategoryID = 5;

--3.
DELETE Categories
WHERE CategoryID = 5;

--4.
INSERT Products
	(CategoryID, ProductCode, ProductName, Description, ListPrice, DiscountPercent, DateAdded)
VALUES
	(4, 'dgx_640', 'Yamaha DGX 640 88-Key Digital Piano', 'Long description to come.', 799.99, 0, GETDATE());

--5.
UPDATE Products
SET DiscountPercent = 35
WHERE ProductID = 11;

--6.
DELETE Categories
WHERE CategoryID = 4;

--7.
INSERT Customers
	(EmailAddress, Password, FirstName, LastName)
VALUES
	('rick@raven.com', '', 'Rick', 'Raven')

--8.
SELECT * FROM Customers
UPDATE Customers
SET Password = 'secret'
WHERE EmailAddress = 'rick@raven.com';

--9.
UPDATE Customers
SET Password = 'reset'