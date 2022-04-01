USE master;
GO

DROP DATABASE New_AP;
GO
CREATE DATABASE New_AP;
GO
CREATE DATABASE Test_AP
	ON PRIMARY (FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLDEV01\MSSQL\DATA\test_ap.mdf')
	FOR ATTACH;
GO

USE New_AP;
GO

CREATE TABLE Vendors
(	VendorID INT,
	VenderName VARCHAR(50));
CREATE TABLE Invoices
(	InvoiceID INT PRIMARY KEY IDENTITY
	, VenderID INT NOT NULL
	, InvoiceDate SMALLDATETIME NULL
	, InvoiceTotal MONEY NULL DEFAULT 0
	, PaymentDate SMALLDATETIME NULL);

CREATE CLUSTERED INDEX IX_VendorID
	ON Invoices (VendorID);
CREATE INDEX IX_Invoices
	ON Invoices (InvoiceDate DESC, InvoiceTotal);
CREATE INDEX IX_InvoicesPaymentFilter
	ON Invoices (InvoiceDate DESC, InvoiceTotal)
WHERE PaymentDate IS NULL;
CREATE INDEX IX_InvoicesDateFilter
	ON Invoices (InvoiceDate DESC, InvoiceTotal)
WHERE InvoiceDate > '2012-02-01';

CREATE TABLE InvoiceLineItems1
(InvoiceID INT NOT NULL,
InvoiceSequence SMALLINT NOT NULL,
InvoiceLineItemAmount MONEY NOT NULL,
PRIMARY KEY (InvoiceID, InvoiceSequence));

CREATE TABLE Invoices1
(InvoiceID INT NOT NULL IDENTITY PRIMARY KEY,
InvoiceTotal MONEY NULL CHECK (InvoiceTotal >= 0),
PaymentTotal MONEY NOT NULL DEFAULT 0 CHECK (PaymentTotal >=0));

CREATE TABLE Invoices2
(InvoiceID INT NOT NULL IDENTITY PRIMARY KEY,
InvoiceTotal MONEY NOT NULL,
PaymentTotal MONEY NOT NULL DEFAULT 0,
CHECK((InvoiceTotal >= 0) AND (PaymentTotal >= 0)));

CREATE TABLE Invoices3
(InvoiceID INT NOT NULL IDENTITY PRIMARY KEY,
InvoiceTotal MONEY NOT NULL CHECK (InvoiceTotal > 0));

INSERT Invoices3
VALUES (100);

CREATE TABLE Vendors1
(VendorCode CHAR(6) NOT NULL PRIMARY KEY,
VendorName VARCHAR(50) NOT NULL,
CHECK ((VendorCode LIKE '[A-Z][A-z][0-9][0-9][0-9][0-9]')
	AND (LEFT(VendorCode,2) = LEFT(VendorName,2))));

INSERT Vendors1
VALUES ('Mc4559', 'Castle Printers, Inc.');

CREATE TABLE Vendors9
(VendorID        INT NOT NULL PRIMARY KEY,
VendorName       VARCHAR(50) NOT NULL);

CREATE TABLE Invoices9
(InvoiceID       INT NOT NULL PRIMARY KEY,
VendorID         INT NOT NULL REFERENCES Vendors9 (VendorID),
InvoiceTotal     MONEY NULL);

INSERT Invoices9
VALUES (1, 99, 100);

DROP INDEX IX_Invoices ON Invoices;

INSERT Invoices9
VALUES (1, 99, 100);

DROP INDEX IX_Invoices ON Invoices;

ALTER TABLE Invoices
DROP CONSTRAINT PK__Invoices__D796AAD5F741D7BF;

DROP TABLE Vendors1;

DROP TABLE New_AP.dbo.Invoices9;

ALTER TABLE Vendors
ADD LastTranDate SMALLDATETIME NULL;

ALTER TABLE Vendors
DROP COLUMN LastTranDate;

ALTER TABLE Invoices WITH NOCHECK
ADD CHECK (InvoiceTotal >= 1);

Use AP;
Go
ALTER TABLE InvoiceLineItems WITH CHECK
ADD FOREIGN KEY (AccountNo) REFERENCES GLAccounts(AccountNo);

ALTER TABLE InvoiceLineItems
ALTER COLUMN InvoiceLineItemDescription VARCHAR(200);

use AP
go

CREATE SEQUENCE TestSequence1
    START WITH 1;

CREATE SEQUENCE TestSequence2
    START WITH 10
    INCREMENT BY 10;

CREATE SEQUENCE TestSequence3
    AS int
    START WITH 100 INCREMENT BY 10
    MINVALUE 0 MAXVALUE 1000000
    CYCLE CACHE 10;


	use AP
go

CREATE TABLE SequenceTable(
    SequenceNo     INT,
    Description    VARCHAR(50));

INSERT INTO SequenceTable
VALUES (NEXT VALUE FOR TestSequence3, 'First inserted row')
INSERT INTO SequenceTable
VALUES (NEXT VALUE FOR TestSequence3,
       'Second inserted row');

SELECT * from SequenceTable;

SELECT current_value FROM sys.sequences
WHERE name = 'TestSequence3';

use AP
go

DROP SEQUENCE TestSequence2;

ALTER SEQUENCE TestSequence3
    INCREMENT BY 9
    MINVALUE 1 MAXVALUE 999999
    CACHE 9
    CYCLE;

INSERT INTO SequenceTable
VALUES (NEXT VALUE FOR TestSequence3,
       'Third inserted row');

SELECT * from SequenceTable;

DROP DATABASE IF EXISTS AP_Batch_Example;
go
CREATE DATABASE AP_Batch_Example;
GO

USE AP_Batch_Example;

CREATE TABLE Terms
(TermsID               INT           NOT NULL PRIMARY KEY,
TermsDescription       VARCHAR(50)   NOT NULL,
TermsDueDays           SMALLINT      NOT NULL);

CREATE TABLE GLAccounts
(AccountNo             INT           NOT NULL PRIMARY KEY,
AccountDescription     VARCHAR(50)   NOT NULL);

CREATE TABLE Vendors
(VendorID              INT           NOT NULL IDENTITY PRIMARY KEY,
VendorName             VARCHAR(50)   NOT NULL,
VendorAddress1         VARCHAR(50)   NULL,
VendorAddress2         VARCHAR(50)   SPARSE NULL,
VendorCity             VARCHAR(50)   NOT NULL,
VendorState            CHAR(2)       NOT NULL,
VendorZipCode          VARCHAR(20)   NOT NULL,
VendorPhone            VARCHAR(50)   NULL,
VendorContactLName     VARCHAR(50)   NULL,
VendorContactFName     VARCHAR(50)   NULL,
DefaultTermsID         INT           NOT NULL
                       REFERENCES Terms(TermsID),
DefaultAccountNo       INT           NOT NULL
                       REFERENCES GLAccounts(AccountNo));

CREATE TABLE Invoices
(InvoiceID             INT           NOT NULL IDENTITY PRIMARY KEY,
VendorID               INT           NOT NULL 
                       REFERENCES Vendors(VendorID),
InvoiceNumber          VARCHAR(50)   NOT NULL,
InvoiceDate            SMALLDATETIME NOT NULL,
InvoiceTotal           MONEY         NOT NULL,
PaymentTotal           MONEY         NOT NULL DEFAULT 0,
CreditTotal            MONEY         NOT NULL DEFAULT 0,
TermsID                INT           NOT NULL
                       REFERENCES Terms(TermsID),
InvoiceDueDate         SMALLDATETIME NOT NULL,
PaymentDate            SMALLDATETIME NULL);

CREATE TABLE InvoiceLineItems
(InvoiceID             INT           NOT NULL
                       REFERENCES Invoices(InvoiceID),
InvoiceSequence        SMALLINT      NOT NULL,
AccountNo              INT           NOT NULL
                       REFERENCES GLAccounts(AccountNo),
InvoiceLineItemAmount  MONEY         NOT NULL,
InvoiceLineItemDescription VARCHAR(100) NOT NULL,
PRIMARY KEY (InvoiceID, InvoiceSequence));

CREATE INDEX IX_Invoices_VendorID
    ON Invoices (VendorID);
CREATE INDEX IX_Invoices_TermsID
    ON Invoices (TermsID);
CREATE INDEX IX_Vendors_TermsID
    ON Vendors (DefaultTermsID);
CREATE INDEX IX_Vendors_AccountNo
    ON Vendors (DefaultAccountNo);
CREATE INDEX IX_InvoiceLineItems_AccountNo
    ON InvoiceLineItems (AccountNo);
CREATE INDEX IX_VendorName
    ON Vendors (VendorName);
CREATE INDEX IX_InvoiceDate
    ON Invoices (InvoiceDate DESC);
