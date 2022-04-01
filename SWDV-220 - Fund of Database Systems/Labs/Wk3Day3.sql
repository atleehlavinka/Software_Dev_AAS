--1.
--ORIGINAL
SELECT DISTINCT AccountDescription
FROM GLAccounts
join InvoiceLineItems
on GLAccounts.AccountNo = InvoiceLineItems.AccountNo
ORDER BY AccountDescription;

--With Subquery
SELECT DISTINCT AccountDescription
FROM GLAccounts
WHERE AccountNo IN (SELECT AccountNo 
					FROM InvoiceLineItems)
ORDER BY AccountDescription;

--2.
SELECT InvoiceNumber, InvoiceTotal, InvoiceTotal-PaymentTotal-CreditTotal AS BalanceDue
FROM Invoices
WHERE InvoiceTotal-PaymentTotal-CreditTotal > (SELECT AVG(InvoiceTotal) FROM Invoices)
ORDER BY InvoiceTotal DESC;

--3.
--INSERT INTO dbo.Terms (TermsDescription, TermsDueDays) VALUES ('Net due 120 days', 120);
SELECT TermsID, TermsDescription
FROM Terms
WHERE TermsID NOT IN (SELECT TermsID FROM Invoices)
ORDER BY TermsID

--4.
SELECT g.AccountNo, g.AccountDescription
FROM GLAccounts g
WHERE NOT EXISTS (SELECT DISTINCT li.AccountNo 
				FROM InvoiceLineItems li
				WHERE g.AccountNo = li.AccountNo)
ORDER BY AccountNo

SELECT AccountNo, AccountDescription
FROM GLAccounts
WHERE AccountNo NOT IN (SELECT AccountNo FROM InvoiceLineItems)
ORDER BY AccountNo

SELECT g.AccountNo, g.AccountDescription
FROM GLAccounts g
	LEFT JOIN InvoiceLineItems li
		ON g.AccountNo = li.AccountNo
WHERE li.AccountNo IS NULL
ORDER BY AccountNo