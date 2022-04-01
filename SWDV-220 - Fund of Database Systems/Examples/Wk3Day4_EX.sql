

SELECT *
INTO InvoiceCopy2
FROM Invoices;

SELECT *
INTO InvoiceCopy3
FROM Invoices;

SELECT *
INTO OldInvoices2
FROM Invoices
WHERE InvoiceTotal - PaymentTotal - CreditTotal = 0;

SELECT VendorID, SUM(InvoiceTotal) AS SumOfInvoices
INTO VendorBalances
FROM Invoices
WHERE InvoiceTotal - PaymentTotal - CreditTotal <> 0
GROUP BY VendorID;

INSERT INTO InvoiceCopy
VALUES (97, '456789', '2012-04-01', 8344.50, 0, 0, 1,
'2012-04-30', NULL);

INSERT INTO InvoiceCopy
(VendorID, InvoiceNumber, InvoiceTotal,
PaymentTotal, CreditTotal, TermsID, InvoiceDate,
InvoiceDueDate)
VALUES
(97, '456789', 8344.50, 0, 0, 1, '2012-04-01',
'2012-04-30');

INSERT INTO InvoiceCopy
VALUES
(95, '111-10098', '2012-04-01', 219.50, 0, 0, 1,
'2012-04-30', NULL),
(102, '109596', '2012-04-01', 22.97, 0, 0, 1,
'2012-04-30', NULL),
(72, '40319', '2012-04-01', 173.38, 0, 0, 1,
'2012-04-30', NULL);

INSERT INTO ColorSample (ColorNumber)
VALUES (606);
INSERT INTO ColorSample (ColorName)
VALUES ('Yellow');
INSERT INTO ColorSample
VALUES (DEFAULT, 'Orange');
INSERT INTO ColorSample
VALUES (808, NULL);
INSERT INTO ColorSample
VALUES (DEFAULT, NULL);
INSERT INTO ColorSample
DEFAULT VALUES;

INSERT INTO InvoiceArchive
(InvoiceID, VendorID, InvoiceNumber, InvoiceTotal,
CreditTotal, PaymentTotal, TermsID, InvoiceDate,
InvoiceDueDate)
SELECT
InvoiceID, VendorID, InvoiceNumber, InvoiceTotal,
CreditTotal, PaymentTotal, TermsID, InvoiceDate,
InvoiceDueDate
FROM InvoiceCopy
WHERE InvoiceTotal - PaymentTotal - CreditTotal = 0;

UPDATE VendorCopy
SET VendorContactLName = LastName,
VendorContactFName = FirstName
FROM VendorCopy JOIN ContactUpdates
ON VendorCopy.VendorID = ContactUpdates.VendorID;

MERGE InvoiceArchive AS ia
USING InvoiceCopy AS ic
ON ic.InvoiceID = ia.InvoiceID
WHEN MATCHED AND
ic.PaymentDate IS NOT NULL AND
ic.PaymentTotal > ia.PaymentTotal
THEN
UPDATE SET
ia.PaymentTotal = ic.PaymentTotal,
ia.CreditTotal = ic.CreditTotal,
ia.PaymentDate = ic.PaymentDate
WHEN NOT MATCHED THEN
INSERT (InvoiceID, VendorID, InvoiceNumber,
InvoiceTotal, PaymentTotal, CreditTotal,
TermsID, InvoiceDate, InvoiceDueDate)
VALUES (ic.InvoiceID, ic.VendorID, ic.InvoiceNumber,
ic.InvoiceTotal, ic.PaymentTotal, ic.CreditTotal,
ic.TermsID, ic.InvoiceDate, ic.InvoiceDueDate)