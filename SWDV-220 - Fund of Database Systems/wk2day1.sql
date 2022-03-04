--1.
SELECT p.ProductCode
	, p.ProductName
	, p.ListPrice
	, p.DiscountPercent
FROM MyGuitarShop.dbo.Products AS p
ORDER BY p.ListPrice DESC

--2.
SELECT c.LastName + ', ' + c.FirstName AS FullName
FROM MyGuitarShop.dbo.Customers AS c
WHERE c.LastName LIKE '[M-Z]%'
ORDER BY c.LastName; --ASC is default

--3.
SELECT p.ProductName
	, p.ListPrice
	, p.DateAdded
FROM MyGuitarShop.dbo.Products AS p
WHERE p.ListPrice > 500 AND p.ListPrice < 2000
ORDER BY DateAdded DESC;

--4.
SELECT p.ProductName
	, p.ListPrice
	, p.DiscountPercent
	, p.ListPrice * p.DiscountPercent * .01 AS DiscountAmount
	, p.ListPrice - (p.ListPrice * p.DiscountPercent * .01) AS DiscountPrice
FROM MyGuitarShop.dbo.Products AS p

--5.
SELECT oi.ItemID
	, oi.ItemPrice
	, oi.DiscountAmount
	, oi.Quantity
	, (oi.ItemPrice * oi.Quantity) AS PriceTotal
	, (oi.DiscountAmount * oi.Quantity) AS DiscountTotal
	, (oi.ItemPrice - oi.DiscountAmount) * Quantity AS ItemTotal
FROM MyGuitarShop.dbo.OrderItems AS oi
WHERE ((ItemPrice - DiscountAmount) * Quantity) > 500
ORDER BY ItemTotal DESC;

--6.
SELECT o.OrderID
	, o.OrderDate
	, o.ShipDate
FROM MyGuitarShop.dbo.Orders AS o
WHERE o.ShipDate IS NULL;