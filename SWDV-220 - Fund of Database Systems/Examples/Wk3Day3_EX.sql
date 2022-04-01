USE AP;
SELECT InvoiceNumber, InvoiceDate, InvoiceTotal
FROM Invoices
WHERE InvoiceTotal >
(SELECT AVG(InvoiceTotal)
FROM Invoices)
ORDER BY InvoiceTotal;

USE AP;
SELECT InvoiceNumber, InvoiceDate, InvoiceTotal
FROM Invoices JOIN Vendors
ON Invoices.VendorID = Vendors.VendorID
WHERE VendorState = 'CA'
ORDER BY InvoiceDate;

USE AP;
SELECT InvoiceNumber, InvoiceDate, InvoiceTotal
FROM Invoices
WHERE VendorID IN
(SELECT VendorID
FROM Vendors
WHERE VendorState = 'CA')
ORDER BY InvoiceDate;

USE AP;
SELECT VendorID, VendorName, VendorState
FROM Vendors
WHERE VendorID NOT IN
(SELECT DISTINCT VendorID
FROM Invoices);

USE AP;
SELECT Vendors.VendorID, VendorName, VendorState
FROM Vendors LEFT JOIN Invoices
ON Vendors.VendorID = Invoices.VendorID
WHERE Invoices.VendorID IS NULL;

USE AP;
SELECT InvoiceNumber, InvoiceDate, InvoiceTotal,
InvoiceTotal - PaymentTotal - CreditTotal AS BalanceDue
FROM Invoices
WHERE InvoiceTotal - PaymentTotal - CreditTotal > 0
AND InvoiceTotal - PaymentTotal - CreditTotal <
(SELECT AVG(InvoiceTotal - PaymentTotal - CreditTotal)
FROM Invoices
WHERE InvoiceTotal - PaymentTotal - CreditTotal > 0)
ORDER BY InvoiceTotal DESC;

USE AP;
SELECT VendorName, InvoiceNumber, InvoiceTotal
FROM Invoices JOIN Vendors
ON Invoices.VendorID = Vendors.VendorID
WHERE InvoiceTotal > ALL
(SELECT InvoiceTotal
FROM Invoices
WHERE VendorID = 34)
ORDER BY VendorName;

USE AP;
SELECT VendorName, InvoiceNumber, InvoiceTotal
FROM Vendors JOIN Invoices ON Vendors.VendorID =
Invoices.VendorID
WHERE InvoiceTotal < ANY
(SELECT InvoiceTotal
FROM Invoices
WHERE VendorID = 115);

--ORIGINAL
USE AP;
SELECT VendorID, InvoiceNumber, InvoiceTotal
FROM Invoices AS Inv_Main
WHERE InvoiceTotal >
(SELECT AVG(InvoiceTotal)
FROM Invoices AS Inv_Sub
WHERE Inv_Sub.VendorID = Inv_Main.VendorID)
ORDER BY VendorID, InvoiceTotal;

--Try 1
WITH cte AS (
SELECT VendorID
	, AVG(InvoiceTotal) AS avg_invoice
FROM Invoices AS Inv_Sub
GROUP BY VendorID)

SELECT DISTINCT
	i.VendorID
	, i.InvoiceNumber
	, i.InvoiceTotal
FROM Invoices AS i
	INNER JOIN cte AS c
		ON i.VendorID = c.VendorID
WHERE i.InvoiceTotal > c.avg_invoice
ORDER BY i.VendorID, i.InvoiceTotal;

--Try 2
SELECT DISTINCT
	i.VendorID
	, i.InvoiceNumber
	, i.InvoiceTotal
FROM Invoices AS i
	INNER JOIN (SELECT VendorID
					, AVG(InvoiceTotal) AS avg_invoice
				FROM Invoices AS Inv_Sub
				GROUP BY VendorID) AS c
		ON i.VendorID = c.VendorID
WHERE i.InvoiceTotal > c.avg_invoice
ORDER BY i.VendorID, i.InvoiceTotal;

USE AP;
SELECT VendorID, VendorName, VendorState
FROM Vendors
WHERE NOT EXISTS
(SELECT *
FROM Invoices
WHERE Invoices.VendorID = Vendors.VendorID);

USE AP;
SELECT Invoices.VendorID, MAX(InvoiceDate) AS LatestInv,
AVG(InvoiceTotal) AS AvgInvoice
FROM Invoices JOIN
(SELECT TOP 5 VendorID, AVG(InvoiceTotal) AS AvgInvoice
FROM Invoices
GROUP BY VendorID
ORDER BY AvgInvoice DESC) AS TopVendor
ON Invoices.VendorID = TopVendor.VendorID
GROUP BY Invoices.VendorID
ORDER BY LatestInv DESC;

USE AP;
SELECT DISTINCT VendorName,
(SELECT MAX(InvoiceDate) FROM Invoices
WHERE Invoices.VendorID = Vendors.VendorID) AS
LatestInv
FROM Vendors
ORDER BY LatestInv DESC;

USE AP;
SELECT VendorName, MAX(InvoiceDate) AS LatestInv
FROM Vendors LEFT JOIN Invoices ON Vendors.VendorID =
Invoices.VendorID
GROUP BY VendorName
ORDER BY LatestInv DESC;

USE AP;
WITH Summary AS
(
SELECT VendorState, VendorName, SUM(InvoiceTotal)
AS SumOfInvoices
FROM Invoices JOIN Vendors
ON Invoices.VendorID = Vendors.VendorID
GROUP BY VendorState, VendorName
),
TopInState AS
(
SELECT VendorState, MAX(SumOfInvoices) AS SumOfInvoices
FROM Summary
GROUP BY VendorState
)
SELECT Summary.VendorState, Summary.VendorName,
TopInState.SumOfInvoices
FROM Summary JOIN TopInState
ON Summary.VendorState = TopInState.VendorState AND
Summary.SumOfInvoices = TopInState.SumOfInvoices
ORDER BY Summary.VendorState;

--1
SELECT VendorName
FROM Vendors
WHERE VendorID IN
	(SELECT DISTINCT VendorID
	FROM Invoices)
ORDER BY VendorName;

SELECT VendorName
FROM Vendors
WHERE VendorID = ANY(SELECT VendorID FROM Invoices)
ORDER BY VendorName;

--2
SELECT InvoiceNumber
	, InvoiceTotal
FROM Invoices
WHERE PaymentTotal >
	(SELECT AVG(PaymentTotal)
	FROM Invoices)

--3
SELECT InvoiceNumber
	, InvoiceTotal
FROM Invoices
WHERE PaymentTotal > ALL (SELECT TOP 50 PERCENT (PaymentTotal)
							FROM Invoices WHERE InvoiceTotal-PaymentTotal-CreditTotal = 0
							ORDER BY PaymentTotal DESC);