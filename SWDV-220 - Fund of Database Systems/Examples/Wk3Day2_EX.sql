--Aggregate w/o GROUP BY
SELECT DISTINCT
	i.VendorID
	, v.VendorName
	, i.TermsID
	, SUM(i.PaymentTotal) OVER(PARTITION BY i.VendorID) AS TotalPayment_by_Vendor
	, SUM(i.InvoiceTotal) OVER(PARTITION BY i.VendorID) AS TotalInvoice_by_Vendor
FROM AP.dbo.Invoices AS i
INNER JOIN AP.dbo.Vendors AS v
	ON v.VendorID = i.VendorID

SELECT DISTINCT
	i.VendorID
	, v.VendorName
	, i.TermsID
	, AVG(i.PaymentTotal) OVER(PARTITION BY i.VendorID) AS TotalPayment_by_Vendor
	, AVG(i.InvoiceTotal) OVER(PARTITION BY i.VendorID) AS TotalInvoice_by_Vendor
FROM AP.dbo.Invoices AS i
INNER JOIN AP.dbo.Vendors AS v
	ON v.VendorID = i.VendorID

--Aggregate w/ GROUP BY
SELECT i.VendorID
	, v.VendorName
	, i.TermsID
	, SUM(i.PaymentTotal) AS TotalPayment_by_Vendor
	, SUM(i.InvoiceTotal) AS TotalInvoice_by_Vendor
FROM AP.dbo.Invoices AS i
INNER JOIN AP.dbo.Vendors AS v
	ON v.VendorID = i.VendorID
GROUP BY i.VendorID, v.VendorName, i.TermsID
ORDER BY i.VendorID

SELECT i.VendorID
	, v.VendorName
	, i.TermsID
	, AVG(i.PaymentTotal) AS TotalPayment_by_Vendor
	, AVG(i.InvoiceTotal) AS TotalInvoice_by_Vendor
FROM AP.dbo.Invoices AS i
INNER JOIN AP.dbo.Vendors AS v
	ON v.VendorID = i.VendorID
GROUP BY i.VendorID, v.VendorName, i.TermsID
ORDER BY i.VendorID

--Shows that COUNT aggregate only counts rows where value is not null
SELECT COUNT(PaymentDate) AS cnt
FROM AP.dbo.Invoices
WHERE PaymentDate IS NULL
--0 rows

--1.
SELECT SUM(PaymentTotal) AS PaymentSum
FROM AP.dbo.Invoices

--2.
SELECT 
	VendorID
	, SUM(PaymentTotal) AS PaymentSum
FROM AP.dbo.Invoices
GROUP BY VendorID

--3.
SELECT 
	i.VendorID
	, v.VendorName
	, SUM(i.PaymentTotal) AS PaymentSum
FROM AP.dbo.Invoices AS i
	INNER JOIN AP.dbo.Vendors AS v
		ON v.VendorID = i.VendorID
GROUP BY i.VendorID, v.VendorName;

--OR--

SELECT DISTINCT
	i.VendorID
	, v.VendorName
	, SUM(i.PaymentTotal) OVER(PARTITION BY i.VendorID) AS PaymentSum
FROM AP.dbo.Invoices AS i
	INNER JOIN AP.dbo.Vendors AS v
		ON v.VendorID = i.VendorID