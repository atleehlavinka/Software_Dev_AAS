--1.
SELECT p.ListPrice
		, CAST(p.ListPrice AS DECIMAL(9,1)) AS PriceFormat
		, CONVERT(INT, p.ListPrice) AS PriceConvert
		, CAST(p.ListPrice AS INT) AS PriveConvert_2
FROM MyGuitarShop.dbo.Products AS p;

--2.
SELECT p.DateAdded
		, CAST(DateAdded AS DATE) AS AddedDate
		, CAST(DateAdded AS TIME) AS AddedTime
		, CONVERT(VARCHAR(5), DateAdded, 110) AS AddedConv
FROM MyGuitarShop.dbo.Products AS p;

--3.
SELECT o.OrderDate
		, CONVERT(VARCHAR(10), OrderDate, 101) AS ODconv
		, CONVERT(VARCHAR, OrderDate, 100) AS ODamPM
		, CONVERT(VARCHAR, OrderDate, 8) AS ODtime
FROM MyGuitarShop.dbo.Orders AS o;

--4.
SELECT p.ListPrice
		, TRY_CAST(p.ListPrice AS DECIMAL(9,1)) AS PriceFormat
		, TRY_CONVERT(INT, p.ListPrice) AS PriceConvert
		, TRY_CAST(p.ListPrice AS INT) AS PriveConvert_2
FROM MyGuitarShop.dbo.Products AS p;

--5.
SELECT p.DateAdded
		, TRY_CAST(DateAdded AS DATE) AS AddedDate
		, TRY_CAST(DateAdded AS TIME) AS AddedTime
		, TRY_CONVERT(VARCHAR(5), DateAdded, 110) AS AddedConv
FROM MyGuitarShop.dbo.Products AS p;

--6.
SELECT o.OrderDate
		, TRY_CONVERT(VARCHAR(10), OrderDate, 101) AS ODconv
		, TRY_CONVERT(VARCHAR, OrderDate, 100) AS ODamPM
		, TRY_CONVERT(VARCHAR, OrderDate, 8) AS ODtime
FROM MyGuitarShop.dbo.Orders AS o;
