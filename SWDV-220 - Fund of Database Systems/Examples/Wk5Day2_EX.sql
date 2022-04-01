USE AP;
GO
CREATE PROC sp_InvoiceReport
AS

SELECT VendorName, InvoiceNumber, InvoiceDate, InvoiceTotal
FROM Invoices JOIN Vendors
     ON Invoices.VendorID = Vendors.VendorID
WHERE InvoiceTotal - CreditTotal - PaymentTotal > 0
ORDER BY VendorName;
Go

--To call sp:
EXEC sp_InvoiceReport;

USE AP;
GO
IF OBJECT_ID('sp_CopyInvoices') IS NOT NULL
    DROP PROC sp_CopyInvoices;
GO

CREATE PROC sp_CopyInvoices
AS
    IF OBJECT_ID('InvoiceCopy') IS NOT NULL
        DROP TABLE InvoiceCopy;
    SELECT *
    INTO InvoiceCopy
    FROM Invoices;
Go

--To exec:
Exec sp_CopyInvoices
Go

select * from InvoiceCopy

USE AP;
GO
CREATE PROC sp_InvTotal1
       @DateVar smalldatetime,
       @InvTotal money OUTPUT
AS
SELECT @InvTotal = SUM(InvoiceTotal)
FROM Invoices
WHERE InvoiceDate >= @DateVar;
Go

USE AP;
GO
declare @TheTotal money
exec sp_InvTotal1 '12-24-2011', @TheTotal output
select @TheTotal;


USE AP;
GO
CREATE PROC sp_InvTotal2
       @DateVar smalldatetime = NULL
AS
IF @DateVar IS NULL
    SELECT @DateVar = MIN(InvoiceDate) FROM Invoices;
SELECT SUM(InvoiceTotal)
FROM Invoices
WHERE InvoiceDate >= @DateVar;
Go

USE AP;
GO
exec sp_InvTotal2;
exec sp_InvTotal2 '12-24-2015';

USE AP;
GO
CREATE PROC sp_InvTotal3
       @InvTotal money OUTPUT,
       @DateVar smalldatetime = NULL,
       @VendorVar varchar(40) = '%'
AS

IF @DateVar IS NULL
   SELECT @DateVar = MIN(InvoiceDate) FROM Invoices;

SELECT @InvTotal = SUM(InvoiceTotal)
FROM Invoices JOIN Vendors
    ON Invoices.VendorID = Vendors.VendorID
WHERE (InvoiceDate >= @DateVar) AND
      (VendorName LIKE @VendorVar);
Go

--exec on next slide
--Run individually
DECLARE @MyInvTotal money;
EXEC sp_InvTotal3 @MyInvTotal OUTPUT, '2012-02-01', 'P%';
select @MyInvTotal;
go
--Code that passes the parameters by name
DECLARE @MyInvTotal money;
EXEC sp_InvTotal3 @DateVar = '2012-02-01',
    @VendorVar = 'P%', @InvTotal = @MyInvTotal OUTPUT;
select @MyInvTotal;
go
--Code that omits one optional parameter
DECLARE @MyInvTotal money;
EXEC sp_InvTotal3 @VendorVar = 'M%', 
    @InvTotal = @MyInvTotal OUTPUT;
select @MyInvTotal;
go
--Code that omits both optional parameters
DECLARE @MyInvTotal money;
EXEC sp_InvTotal3 @MyInvTotal OUTPUT;
select @MyInvTotal;
go

CREATE PROC sp_InvCount
       @DateVar smalldatetime = NULL,
       @VendorVar varchar(40) = '%'
AS

IF @DateVar IS NULL
   SELECT @DateVar = MIN(InvoiceDate) FROM Invoices;

DECLARE @InvCount int;
SELECT @InvCount = COUNT(InvoiceID)
FROM Invoices JOIN Vendors
    ON Invoices.VendorID = Vendors.VendorID
WHERE (InvoiceDate >= @DateVar) AND
      (VendorName LIKE @VendorVar);  --exec on next slide

RETURN @InvCount;
go

DECLARE @InvCount int;
EXEC @InvCount = sp_InvCount '2012-02-01', 'P%';
PRINT 'Invoice count: ' + CONVERT(varchar, @InvCount);
go


CREATE PROC sp_InsertInvoice
       @VendorID    int,
       @InvoiceNumber  varchar(50),
       @InvoiceDate smalldatetime,
       @InvoiceTotal   money,
       @TermsID     int,
       @InvoiceDueDate smalldatetime
AS

IF EXISTS(SELECT * FROM Vendors WHERE VendorID = @VendorID)
Begin                                          		--Added to return vendorID
    INSERT Invoices
    VALUES (@VendorID, @InvoiceNumber,
            @InvoiceDate, @InvoiceTotal, 0, 0,
            @TermsID, @InvoiceDueDate, NULL);
	RETURN @@IDENTITY;                       	--Added to return vendorID
 End                                            		--Added to return vendorID
ELSE 
    THROW 50001, 'Not a valid VendorID!', 1;

go

USE AP
GO
BEGIN TRY
    EXEC sp_InsertInvoice 
         799,'ZXK-799','2012-05-01',299.95,1,'2012-06-01';
END TRY
BEGIN CATCH
    PRINT 'An error occurred.';
    PRINT 'Message: ' + CONVERT(varchar, ERROR_MESSAGE());
    IF ERROR_NUMBER() >= 50000
        PRINT 'This is a custom error message.';
END CATCH;


USE AP
GO
BEGIN TRY
    DECLARE @InvoiceID int;
    EXEC @InvoiceID = sp_InsertInvoice
         @VendorID = 799,                    -- Change VendorID to 99
         @InvoiceNumber = 'RZ99381',
         @InvoiceDate = '2018-03-12',  -- Change InvoiceDate YYYY to current
 @TermsID = 1,
 @InvoiceDueDate = '2018-04-25',
         @InvoiceTotal = 1292.45;
    PRINT 'Row was inserted.';
    PRINT 'New InvoiceID: ' + CONVERT(varchar, @InvoiceID);
END TRY
BEGIN CATCH
    PRINT 'An error occurred. Row was not inserted.';
    PRINT 'Error number: ' +
        CONVERT(varchar, ERROR_NUMBER());
    PRINT 'Error message: ' +
        CONVERT(varchar, ERROR_MESSAGE());
END CATCH;

USE AP
GO
CREATE PROC sp_VendorState
       @State varchar(20)
AS
SELECT VendorName
FROM Vendors
WHERE VendorState = @State;
Go

exec sp_VendorState 'AZ'
go
USE AP
GO

ALTER PROC sp_VendorState
      @State varchar(20) = NULL
AS
IF @State IS NULL
   SELECT VendorName
   FROM Vendors;
ELSE
   SELECT VendorName
   FROM Vendors
   WHERE VendorState = @State;
go

exec sp_VendorState
go

DROP PROC sp_VendorState;
go


--USE AP;
CREATE FUNCTION fn_VendorID
    (@VendorName varchar(50))
    RETURNS int
BEGIN
    RETURN (SELECT VendorID FROM Vendors
            WHERE VendorName = @VendorName);
END;
go

USE AP;
SELECT InvoiceDate, InvoiceTotal
FROM Invoices
WHERE VendorID = dbo.fn_VendorID('Blue Cross');

SELECT InvoiceDate, InvoiceTotal
FROM Invoices
WHERE VendorID = dbo.fn_VendorID('IBM');


--USE [AP];
CREATE FUNCTION fn_BalanceDue()
    RETURNS money
BEGIN
    RETURN (SELECT SUM(InvoiceTotal - PaymentTotal -
                       CreditTotal)
            FROM Invoices
            WHERE InvoiceTotal - PaymentTotal -
                  CreditTotal > 0);
END;
Go

--USE [AP];
PRINT 'Balance due: $' +
    CONVERT(varchar, dbo.fn_BalanceDue(), 1);

USE [AP];
GO
IF OBJECT_ID('Vendors_INSERT_UPDATE') IS NOT NULL
   DROP TRIGGER Vendors_INSERT_UPDATE
GO
CREATE TRIGGER Vendors_INSERT_UPDATE
    ON Vendors
    AFTER INSERT,UPDATE
AS
    UPDATE Vendors
    SET VendorState = UPPER(VendorState)
    WHERE VendorID IN (SELECT VendorID FROM Inserted);
go

USE [AP];
GO
INSERT Vendors
VALUES ('Peerless Uniforms, Inc.', '785 S Pixley Rd', 
        NULL, 'Piqua', 'Oh', '45356', '(937) 555-8845',
        NULL, NULL, 4, 550);


Select * from Vendors
order by VendorID desc;


UPDATE Vendors
SET VendorState = 'id'
WHERE VendorID = 128;
USE AP;
GO
ALTER TRIGGER Vendors_INSERT_UPDATE
    ON Vendors
    AFTER INSERT,UPDATE
AS
    UPDATE Vendors
    SET VendorState = UPPER(VendorState),
        VendorAddress1 = LTRIM(RTRIM(VendorAddress1)),
        VendorAddress2 = LTRIM(RTRIM(VendorAddress2))
    WHERE VendorID IN (SELECT VendorID FROM Inserted);
go

DROP TRIGGER Vendors_INSERT_UPDATE
go

--The same statements coded as a transaction
DECLARE @InvoiceID int;
BEGIN TRY
    BEGIN TRAN;
    INSERT Invoices
      VALUES (1,'ZXA-080','2012-04-30',14092.59,
              0,0,3,'2012-05-30',NULL);
    SET @InvoiceID = @@IDENTITY;
    INSERT InvoiceLineItems
        VALUES (@InvoiceID,1,160,4447.23,'HW upgrade');
    INSERT InvoiceLineItems
        VALUES (@InvoiceID,2,167,9645.36,'OS upgrade');
    COMMIT TRAN;
END TRY
BEGIN CATCH
    ROLLBACK TRAN;
END CATCH;
go

--Setup data for example
select VendorID, count(*)--Make sure there is > 1 row for 37 & only 1 row for 89
from invoices
WHERE VendorID in (37, 89)
group by VendorID;             
go

select Invoices.InvoiceID, VendorID--Find InvoiceIds to delete in next step -- if 0 rows returned, ok.
from InvoiceLineItems 
join invoices on Invoices.InvoiceID = InvoiceLineItems.InvoiceID
WHERE VendorID in (89, 37);             
go

delete InvoiceLineItems 
where InvoiceID in (8, 46, 50, 113);--These should match results from join above
--End of setup

BEGIN TRAN;

DELETE Invoices--VendorID 37 should fail, 89 should work
WHERE VendorID = 89;
IF @@ROWCOUNT > 1
    BEGIN
        ROLLBACK TRAN;
        PRINT 'More invoices than expected. ' +
            'Deletions rolled back.';
    END;
ELSE
    BEGIN
        COMMIT TRAN;
        PRINT 'Deletions committed to the database.';
    END;
Go





--Setup data for example
drop table if exists InvoicesTranEx;
drop table if exists VendorsTranEx;
select *
into InvoicesTranEx
from Invoices;
select *
into VendorsTranEx
from Vendors;
--end of setup

BEGIN TRAN;
PRINT 'First Tran  @@TRANCOUNT: ' +
    CONVERT(varchar,@@TRANCOUNT);
DELETE InvoicesTranEx;
  BEGIN TRAN;
    PRINT 'Second Tran @@TRANCOUNT: ' +
        CONVERT(varchar,@@TRANCOUNT);
    DELETE VendorsTranEx;
  COMMIT TRAN;      -- This COMMIT decrements @@TRANCOUNT.
                    -- It doesn't commit 'DELETE Vendors'.
  PRINT 'COMMIT     @@TRANCOUNT: ' +
      CONVERT(varchar,@@TRANCOUNT);
ROLLBACK TRAN;
PRINT 'ROLLBACK   @@TRANCOUNT: ' +
    CONVERT(varchar,@@TRANCOUNT);

--Continued on next slide
PRINT ' ';
DECLARE @VendorsCount int, @InvoicesCount int;
SELECT @VendorsCount = COUNT (*) FROM VendorsTranEx;
SELECT @InvoicesCount = COUNT (*) FROM InvoicesTranEx;
PRINT 'Vendors Count:  ' +
    CONVERT (varchar , @VendorsCount);
PRINT 'Invoices Count: ' +
    CONVERT (varchar , @InvoicesCount);


IF OBJECT_ID('tempdb..#VendorCopy') IS NOT NULL
    DROP TABLE tempdb.. #VendorCopy;
SELECT VendorID, VendorName
INTO #VendorCopy
FROM Vendors
WHERE VendorID < 5;
BEGIN TRAN;
  DELETE #VendorCopy WHERE VendorID = 1;
  SAVE TRAN Vendor1;
    DELETE #VendorCopy WHERE VendorID = 2;
    SAVE TRAN Vendor2;
      DELETE #VendorCopy WHERE VendorID = 3;
      SELECT * FROM #VendorCopy;
    ROLLBACK TRAN Vendor2;
    SELECT * FROM #VendorCopy;
  ROLLBACK TRAN Vendor1;
  SELECT * FROM #VendorCopy;
COMMIT TRAN;
SELECT * FROM #VendorCopy;

use MyGuitarShop;
go
select * 
from Categories;

--Run full database backup of MyGuitarShop in SSMS
BACKUP DATABASE [MyGuitarShop] TO  DISK = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLDEV01\MSSQL\Backup\MyGuitarShopFULL.bak' WITH NOFORMAT, NOINIT,  NAME = N'MyGuitarShop-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10
GO
--Check the BU folder & observe files

--Insert new category for Woodwinds
INSERT INTO [dbo].[Categories]
           ([CategoryName])
     VALUES
           ('Woodwinds')
GO
select * 
from Categories;

--Run differential backup of MyGuitarShop
BACKUP DATABASE [MyGuitarShop] TO  DISK = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLDEV01\MSSQL\Backup\MyGuitarShopDIFFERENTIAL.bak' WITH  DIFFERENTIAL , NOFORMAT, NOINIT,  NAME = N'MyGuitarShop-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10
GO
--Check the BU folder & observe files/sizes

--Delete multiple categories 
DELETE Categories
WHERE CategoryID > 3;
select * 
from Categories;

--Run transaction log backup of MyGuitarShop
BACKUP LOG [MyGuitarShop] TO  DISK = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLDEV01\MSSQL\Backup\MyGuitarShopTL1.bak' WITH NOFORMAT, NOINIT,  NAME = N'MyGuitarShop-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10
GO
--Check the BU folder & observe files/sizes

--Restore MyGuitarShop
--Change current db in this script window
use master;
go

BACKUP LOG [MyGuitarShop] TO  DISK = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLDEV01\MSSQL\Backup\MyGuitarShop_LogBackup_2021-03-23_15-11-15.bak' WITH NOFORMAT, NOINIT,  NAME = N'MyGuitarShop_LogBackup_2021-03-23_15-11-15', NOSKIP, NOREWIND, NOUNLOAD,  NORECOVERY ,  STATS = 5
RESTORE DATABASE [MyGuitarShop] FROM  DISK = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLDEV01\MSSQL\Backup\MyGuitarShopFULL.bak' WITH  FILE = 1,  NOUNLOAD,  STATS = 5

GO

use MyGuitarShop;
go
select * 
from Categories;
--Woodwinds should be missing

--Restore & apply type=differential - must restore the full first
USE [master]
go
BACKUP LOG [MyGuitarShop] TO  DISK = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLDEV01\MSSQL\Backup\MyGuitarShop_LogBackup_2021-10-19_16.bak' WITH NOFORMAT, NOINIT,  NAME = N'MyGuitarShop_LogBackup_2021-10-19_16.bak', NOSKIP, NOREWIND, NOUNLOAD,  NORECOVERY ,  STATS = 5
RESTORE DATABASE [MyGuitarShop] FROM  DISK = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLDEV01\MSSQL\Backup\MyGuitarShopFULL.bak' WITH  FILE = 1,  NORECOVERY,  NOUNLOAD,  STATS = 5
RESTORE DATABASE [MyGuitarShop] FROM  DISK = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLDEV01\MSSQL\Backup\MyGuitarShopDIFFERENTIAL.bak' WITH  FILE = 1,  NOUNLOAD,  STATS = 5
GO

use MyGuitarShop;
go
select * 
from Categories;
--Woodwinds should exist in table

use master;
go
--Restore & apply type=transaction log only (the TL with no date) - must apply the full & any differential

USE [master]
go
BACKUP LOG [MyGuitarShop] TO  DISK = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLDEV01\MSSQL\Backup\MyGuitarShop_LogBackup_2021-10-19_17.bak'  WITH NOFORMAT, NOINIT,  NAME = N'MyGuitarShop_LogBackup_2021-10-19_17.bak', NOSKIP, NOREWIND, NOUNLOAD,  NORECOVERY ,  STATS = 5
RESTORE DATABASE [MyGuitarShop] FROM  DISK = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLDEV01\MSSQL\Backup\MyGuitarShopFULL.bak' WITH  FILE = 1,  NORECOVERY,  NOUNLOAD,  STATS = 5
RESTORE DATABASE [MyGuitarShop] FROM  DISK = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLDEV01\MSSQL\Backup\MyGuitarShopDIFFERENTIAL.bak' WITH  FILE = 1,  NORECOVERY,  NOUNLOAD,  STATS = 5
RESTORE LOG [MyGuitarShop] FROM  DISK = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLDEV01\MSSQL\Backup\MyGuitarShopTL1.bak' WITH  FILE = 1,  NOUNLOAD,  STATS = 5  
GO

use MyGuitarShop;
go
select * 
from Categories;
--Only CategoryIDs 1, 2, & 3 exist
