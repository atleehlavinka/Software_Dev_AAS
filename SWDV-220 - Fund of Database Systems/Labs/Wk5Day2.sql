USE AP
GO

SELECT
	v.VendorID
	, VendorName
	, COUNT(*) AS NumOfInvoices
FROM Vendors v
	INNER JOIN Invoices i
		ON v.VendorID = i.VendorID
WHERE VendorName = 'United Parcel Service'
	OR VendorName = 'Federal Express Corporation'
	OR VendorName = 'FedUp'
GROUP BY v.VendorID
	, v.VendorName

DECLARE @DeleteVendorID INT
	, @NewVendorID INT;

SELECT @DeleteVendorID = VendorID
FROM Vendors
WHERE VendorName = 'United Parcel Service';

SELECT @NewVendorID = VendorID
FROM Vendors
WHERE VendorName = 'Federal Express Corporation'

BEGIN TRY
	BEGIN TRANSACTION
		UPDATE Invoices
		SET VendorID = @NewVendorID
		WHERE VendorID = @DeleteVendorID

		DELETE Vendors
		WHERE VendorID = @DeleteVendorID
			IF @@ROWCOUNT > 1
			BEGIN
				ROLLBACK TRANSACTION;
				THROW 500001, 'No rows to delete', 1;
			END	
		UPDATE Vendors
		SET VendorName = 'FedUp'
		WHERE VendorID = @NewVendorID
	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	SELECT 'Updates not completed: ' + ERROR_MESSAGE();
END CATCH