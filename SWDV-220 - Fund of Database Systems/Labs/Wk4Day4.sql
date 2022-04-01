USE MyGuitarShop
GO

DECLARE @newCat VARCHAR(255) = 'Flutes';
BEGIN TRY
	INSERT INTO [dbo].[Categories] ([CategoryName])
	VALUES (@newCat);
	PRINT 'SUCCESS: Record was inserted.';
END TRY
BEGIN CATCH
	PRINT 'Error ' + CONVERT(VARCHAR, ERROR_NUMBER(), 1) + ': ' + ERROR_MESSAGE();
END CATCH
GO

SELECT *
FROM Categories
ORDER BY CategoryID