USE MyGuitarShop
GO

--1.
SELECT FirstName
	, LastName
	, Line1
	, City
	, State
	, ZipCode
FROM Customers c
	INNER JOIN Addresses a
		ON c.ShippingAddressID = a.AddressID
		AND c.CustomerID = a.CustomerID
ORDER BY FirstName

--2.
SELECT DISTINCT 
	LastName
	, FirstName
	, OrderDate
	, ProductName
	, ItemPrice
	, DiscountAmount
	, Quantity
FROM Customers c
	INNER JOIN Orders o
		ON c.CustomerID = o.CustomerID
	INNER JOIN OrderItems oi
		ON o.OrderID = oi.OrderID
	INNER JOIN Products p
		ON p.ProductID = oi.ProductID
ORDER BY LastName, OrderDate, ProductName

--3.
SELECT c.CategoryName
		, COUNT(*) AS CountProducts
		, MAX(ListPrice) AS MostExpensive
FROM Categories AS c
	INNER JOIN Products AS p
		ON p.CategoryID = c.CategoryID
GROUP BY CategoryName
ORDER BY COUNT(*) DESC, CategoryName

--4.
SELECT c.EmailAddress
	, COUNT(oi.ProductID) CountOrder
FROM Customers AS c
	INNER JOIN Orders o
		ON c.CustomerID = o.CustomerID
	INNER JOIN OrderItems oi
		ON o.OrderID = oi.OrderID
GROUP BY c.EmailAddress
HAVING COUNT(oi.ProductID) > 1

--5.
SELECT p.ProductName
	, p.ListPrice
FROM Products AS p
WHERE p.ListPrice > (SELECT AVG(ListPrice) AS AVGPrice
					FROM Products)
ORDER BY ListPrice DESC

--6.
SELECT c.CategoryName
FROM Categories AS c
WHERE c.CategoryID NOT IN (SELECT DISTINCT CategoryID FROM Products)

SELECT c.CategoryName
FROM Categories AS c
WHERE NOT EXISTS	(SELECT p.CategoryID 
					FROM Products p
					WHERE p.CategoryID = c.CategoryID)