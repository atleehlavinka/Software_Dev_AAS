USE AP
GO

--1
SELECT ISNULL(LEFT(VendorContactFName, 1) + '. ' + VendorContactLName, 'NO CONTACT NAME')
	, SUBSTRING(VendorPhone, 2, 3) AS 'Area Code'
	, VendorZipCode
FROM Vendors
WHERE SUBSTRING(VendorZipCode, 1, 1) = '9'
	AND VendorPhone IS NOT NULL
ORDER BY 2;

--2
SELECT DATENAME(WEEKDAY, '4/2/2003');

--3
SELECT VendorID
	, VendorName
	, SUBSTRING(VendorName, 1 , CASE WHEN CHARINDEX(' ', VendorName) = 0 THEN LEN(VendorName) 
								ELSE CHARINDEX(' ', VendorName) -1 END) AS LName
	, SUBSTRING(VendorName, CHARINDEX(' ', VendorName) + 1, LEN(VendorName)) AS LName
	, ISNULL(VendorAddress1, 'NO ADDRESS ON FILE') AS VendorAdd
FROM Vendors
ORDER BY VendorAddress1;