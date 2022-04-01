USE ap;
GO

-1.
SELECT i.*
FROM AP.dbo.Invoices AS i
	INNER JOIN AP.dbo.Terms AS t 
		ON i.TermID = t.TermID

--2.
SELECT
	i.InvoiceNumber
	, i.InvoiceDate
	, t.TermsDueDays
	, (i.InvoiceTotal - i.PaymentTotal - i.CreditTotal) AS Balance
FROM AP.dbo.Invoices AS i
	INNER JOIN AP.dbo.Terms AS t
		ON t.TermsID = i.TermsID
WHERE (i.InvoiceTotal - i.PaymentTotal - i.CreditTotal) > 0
ORDER BY Balance DESC

--3.
SELECT 
	g.AccountNo
	, g.AccountDescription
FROM GLAccounts AS g
	LEFT JOIN InvoiceLineItems AS i
		ON g.AccountNo = i.AccountNo
WHERE i.AccountNo IS NULL
ORDER BY g.AccountNo

--4.
SELECT
	v.VendorName
	, t.DefaultTermsID
	, t.TermsDescription
FROM AP.dbo.Vendors AS v
JOIN AP.dbo.Terms AS t
	ON v.DefaultTermsID = t.TermsID
ORDER BY t.TermsDescription, v.VendorName

--5.
SELECT DISTINCT
	v1.VendorID
	, v1.VendorName
	--, v1.VendorContactFName
	, (v1.VendorContactFname + ' ' + v1.VendorContactLName) AS Name
FROM AP.dbo.Vendors AS v1
	INNER JOIN AP.dbo.Vendors AS v2
		ON v1.VendorContactFName = v2.VendorContactFName
		AND v1.VendorID <> v2.VendorID
ORDER BY (v1.VendorContactFname + ' ' + v1.VendorContactLName)

































