USE AP;
GO

--1.
SELECT 
	InvoiceID
	, SUM(InvoiceLineItemAmount) AS 'Amount Due'
FROM InvoiceLineItems
GROUP BY InvoiceID
ORDER BY InvoiceID;

--2.
SELECT 
	li.InvoiceID
	, SUM(li.InvoiceLineItemAmount) AS 'Amount Due'
	, i.InvoiceTotal
FROM InvoiceLineItems AS li
	INNER JOIN Invoices AS i
		ON i.InvoiceID = li.InvoiceID
GROUP BY li.InvoiceID, InvoiceTotal
ORDER BY li.InvoiceID;

--3.
SELECT AccountDescription, COUNT(*) AS 'Invoice Line Count'
FROM GLAccounts
	INNER JOIN InvoiceLineItems
		ON GLAccounts.AccountNo = InvoiceLineItems.AccountNo
GROUP BY AccountDescription
ORDER BY AccountDescription;

--4.
SELECT 
	AccountDescription
	, COUNT(*) AS 'Invoice Line Count'
	, CAST(AVG(InvoiceLineItemAmount) AS DECIMAL(7,2)) AS 'AVG AMT'
FROM GLAccounts
	INNER JOIN InvoiceLineItems
		ON GLAccounts.AccountNo = InvoiceLineItems.AccountNo
GROUP BY AccountDescription
HAVING COUNT(*) > 1
ORDER BY 3 DESC;

