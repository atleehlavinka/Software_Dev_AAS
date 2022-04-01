USE AP
GO

SELECT VendorName
	, InvoiceNumber
	, InvoiceDate
	, InvoiceTotal - (PaymentTotal + CreditTotal) AS Balance
FROM Invoices i
	INNER JOIN Vendors v
		ON v.VendorID = i.VendorID
WHERE InvoiceTotal - (PaymentTotal + CreditTotal) <>  0
ORDER BY VendorName;

SELECT VendorName
	, InvoiceNumber
	, InvoiceDate
	, InvoiceTotal - (PaymentTotal + CreditTotal) AS Balance
FROM Invoices i, Vendors v
WHERE 1=1
	AND i.VendorID = v.VendorID
	AND InvoiceTotal - (PaymentTotal + CreditTotal) <> 0
ORDER BY VendorName;

SELECT v.VendorName AS Vendor
	, i.InvoiceDate AS Date
	, i.InvoiceNumber AS Number
	, li.InvoiceSequence AS #
	, li.InvoiceLineItemAmount AS LineItem
FROM Invoices i
	INNER JOIN Vendors v
		ON v.VendorID = i.VendorID
	INNER JOIN InvoiceLineItems li
		ON li.InvoiceID = i.InvoiceID
ORDER BY Vendor, Date, Number, #;

SELECT TOP 10 
	VendorName
	, SUM(PaymentTotal) AS PaymentSum
FROM Vendors v
	INNER JOIN Invoices i 
		ON i.VendorID = v.VendorID
GROUP BY VendorName
ORDER BY PaymentSum DESC

SELECT VendorName
	, COUNT(v.VendorID) AS InvoiceCount
	, SUM(InvoiceTotal) AS InvoiceSum
FROM Vendors AS v
	INNER JOIN Invoices AS i
		ON i.VendorID = v.VendorID
GROUP BY VendorName
ORDER BY InvoiceCount DESC, InvoiceSum DESC

SELECT VendorName, COUNT(DISTINCT AccountNo) AS TotalAccounts
FROM Vendors AS v
	INNER JOIN Invoices AS i
		ON v.VendorID = i.VendorID
	INNER JOIN InvoiceLineItems AS li
		ON i.InvoiceID = li.InvoiceID
GROUP BY VendorName
HAVING COUNT(DISTINCT AccountNo) > 1

SELECT AccountNo
	, AccountDescription
FROM GLAccounts
WHERE AccountNo NOT IN (SELECT AccountNo
						FROM InvoiceLineItems)
SELECT gla.AccountNo
	, gla.AccountDescription
FROM GLAccounts AS gla
WHERE NOT EXISTS (	SELECT li.AccountNo
					FROM InvoiceLineItems AS li
					WHERE li.AccountNo = gla.AccountNo)
ORDER BY gla.AccountNo

SELECT v.VendorName
	, i.InvoiceID
	, li.InvoiceSequence
	, li.InvoiceLineItemAmount
FROM Vendors AS v
	INNER JOIN Invoices AS i
		ON v.VendorID = i.VendorID
	INNER JOIN InvoiceLineItems AS li
		ON li.InvoiceID = i.InvoiceID
WHERE i.InvoiceID IN (SELECT InvoiceID
					FROM InvoiceLineItems
					WHERE InvoiceSequence > 1)
ORDER BY VendorName, i.InvoiceID, li.InvoiceSequence;