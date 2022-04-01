USE AP
GO

--1
DROP VIEW IF EXISTS Top3Invoices
GO
CREATE VIEW Top3Invoices
AS
	SELECT TOP 3 VendorID, InvoiceTotal
	FROM Invoices
	WHERE InvoiceTotal - CreditTotal - PaymentTotal > 0
	ORDER BY InvoiceTotal DESC;
GO

SELECT * FROM Top3Invoices

--2
DROP VIEW IF EXISTS OverDueInvoices
GO
CREATE VIEW OverDueInvoices
AS
SELECT 
	InvoiceID
	, InvoiceDate
	, InvoiceTotal
FROM Invoices
WHERE PaymentDate IS NULL
	AND InvoiceDueDate <= GETDATE();
GO

SELECT * 
FROM OverDueInvoices
ORDER BY InvoiceID

--3
DROP VIEW IF EXISTS ChangeTerms
GO
CREATE VIEW ChangeTerms
AS
SELECT TermsID
	, TermsDescription
	, TermsDueDays
FROM Terms;
GO

SELECT *
FROM ChangeTerms
INSERT ChangeTerms
VALUES ('Net due 220 days', 220);
GO