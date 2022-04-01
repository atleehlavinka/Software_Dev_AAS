USE AP
GO

SELECT InvoiceNumber, VendorName, InvoiceDueDate,
InvoiceTotal - PaymentTotal - CreditTotal AS BalanceDue
FROM Vendors AS v JOIN Invoices AS i
ON v.VendorID = i.VendorID
WHERE InvoiceTotal - PaymentTotal - CreditTotal > 0
ORDER BY InvoiceDueDate DESC

USE Examples
GO

SELECT VendorName, CustomerLast, CustomerFirst,
VendorState AS State, VendorCity AS City
FROM DBServer.AP.dbo.Vendors AS Vendors
JOIN DBserver.Examples.dbo.Customers AS Customers
ON Vendors.VendorZipCode = Customers.CustZip
ORDER BY State, City

SELECT DISTINCT Vendors1.VendorName, Vendors1.VendorCity,
Vendors1.VendorState
FROM Vendors AS Vendors1 JOIN Vendors AS Vendors2
ON (Vendors1.VendorCity = Vendors2.VendorCity) AND
(Vendors1.VendorState = Vendors2.VendorState) AND
(Vendors1.VendorID <> Vendors2.VendorID)
ORDER BY Vendors1.VendorState, Vendors1.VendorCity


SELECT DeptName, Departments.DeptNo, LastName
FROM Departments LEFT JOIN Employees
ON Departments.DeptNo = Employees.DeptNo

SELECT DeptName, Employees.DeptNo, LastName
FROM Departments RIGHT JOIN Employees
ON Departments.DeptNo = Employees.DeptNo

SELECT DeptName, Departments.DeptNo,
Employees.DeptNo, LastName
FROM Departments FULL JOIN Employees
ON Departments.DeptNo = Employees.DeptNo

SELECT DeptName, LastName, ProjectNo
FROM Departments
LEFT JOIN Employees
ON Departments.DeptNo = Employees.DeptNo
LEFT JOIN Projects
ON Employees.EmployeeID = Projects.EmployeeID
ORDER BY DeptName, LastName, ProjectNo

SELECT DeptName, LastName, ProjectNo
FROM Departments
FULL JOIN Employees
ON Departments.DeptNo = Employees.DeptNo
FULL JOIN Projects
ON Employees.EmployeeID = Projects.EmployeeID
ORDER BY DeptName

SELECT DeptName, LastName, ProjectNo
FROM Departments
JOIN Employees
ON Departments.DeptNo = Employees.DeptNo
LEFT JOIN Projects
ON Employees.EmployeeID = Projects.EmployeeID
ORDER BY DeptName

SELECT Departments.DeptNo, DeptName,
EmployeeID, LastName
FROM Departments CROSS JOIN Employees
ORDER BY Departments.DeptNo

SELECT Departments.DeptNo, DeptName,
EmployeeID, LastName
FROM Departments, Employees
ORDER BY Departments.DeptNo

SELECT 'Active' AS Source, InvoiceNumber,
InvoiceDate, InvoiceTotal
FROM ActiveInvoices
WHERE InvoiceDate >= '02/01/2012'
UNION
SELECT 'Paid' AS Source, InvoiceNumber,
InvoiceDate, InvoiceTotal
FROM PaidInvoices
WHERE InvoiceDate >= '02/01/2012'
ORDER BY InvoiceTotal DESC;

USE AP
GO

SELECT 'Active' AS Source, InvoiceNumber,
InvoiceDate, InvoiceTotal
FROM Invoices
WHERE InvoiceTotal - PaymentTotal - CreditTotal > 0
UNION
SELECT 'Paid' AS Source, InvoiceNumber,
InvoiceDate, InvoiceTotal
FROM Invoices
WHERE InvoiceTotal - PaymentTotal - CreditTotal <= 0
ORDER BY InvoiceTotal DESC;

USE Examples
GO

SELECT CustomerFirst, CustomerLast
FROM Customers
EXCEPT
SELECT FirstName, LastName
FROM Employees
ORDER BY CustomerLast;

SELECT CustomerFirst, CustomerLast
FROM Customers
INTERSECT
SELECT FirstName, LastName
FROM Employees