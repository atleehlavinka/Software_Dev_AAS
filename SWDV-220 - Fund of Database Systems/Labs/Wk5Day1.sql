USE disk_inventoryah
GO

IF OBJECT_ID('[dbo].[sp_ins_disk_has_borrower]') IS NOT NULL DROP PROCEDURE [dbo].[sp_ins_disk_has_borrower]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =======================================================================
-- Author: Atlee Hlavinka
-- Create Date: 03/28/2022
-- Description: Create SP for inserting data into disk_has_borrower table

/* Update Log
DATE		DEVELOPER		DESCRIPTION
03/28/2022	Atlee Hlavinka	Initial Implementation
*/
-- =======================================================================
CREATE PROCEDURE [dbo].[sp_ins_disk_has_borrower]
(
	@borrower_id INT
	, @disk_id INT
	, @borrowed_date DATE
	, @returend_date DATE = NULL
)

AS
BEGIN
SET NOCOUNT ON;

BEGIN TRY

	INSERT disk_has_borrower
		(borrower_id, disk_id, borrowed_date, returned_date)
	VALUES
		(@borrower_id, @disk_id, @borrowed_date, @returend_date);

END TRY

BEGIN CATCH

	PRINT 'An error occured.';
	PRINT 'MESSAGE: ' + CONVERT(VARCHAR(200), ERROR_MESSAGE());

END CATCH

SET NOCOUNT OFF
END
GO

GRANT EXEC ON [dbo].[sp_ins_disk_has_borrower] TO diskUserah
GO




--TEST SP
EXEC sp_ins_disk_has_borrower 2, 2, '3-28-2022', '3-28-2022'
GO

EXEC sp_ins_disk_has_borrower 4, 2, '3-28-2022'
GO

--SELECT DATA
SELECT *
FROM disk_has_borrower
WHERE disk_has_borrower_id > 20

--UPDATE ROW
UPDATE disk_has_borrower
SET borrower_id = 8
	, disk_id = 5
	, borrowed_date = '2-23-2022'
	, returned_date = '2-27-2022'
WHERE disk_has_borrower_id = 21

--SELECT DATA
SELECT *
FROM disk_has_borrower
WHERE disk_has_borrower_id > 20

GO

ALTER PROCEDURE [dbo].[sp_ins_disk_has_borrower]
(
	@disk_has_borrower_id INT
	, @borrower_id INT
	, @disk_id INT
	, @borrowed_date DATE
	, @returend_date DATE = NULL
)

AS
BEGIN
SET NOCOUNT ON;

BEGIN TRY

	UPDATE disk_has_borrower
	SET borrower_id = @borrower_id
		, disk_id = @disk_id
		, borrowed_date = @borrowed_date
		, returned_date = @returend_date
	WHERE disk_has_borrower_id = @disk_has_borrower_id;
END TRY

BEGIN CATCH

	PRINT 'An error occured.';
	PRINT 'MESSAGE: ' + CONVERT(VARCHAR(200), ERROR_MESSAGE());

END CATCH

SET NOCOUNT OFF
END
GO

GRANT EXEC ON [dbo].[sp_ins_disk_has_borrower] TO diskUserah
GO


--TEST SP

EXEC sp_ins_disk_has_borrower 21, 1, 1, '1-28-2022', '1-28-2022'
GO

DECLARE @TODAY DATE = GETDATE()
EXEC sp_ins_disk_has_borrower 22, 10, 10, @TODAY
GO

--SELECT DATA
SELECT *
FROM disk_has_borrower
WHERE disk_has_borrower_id > 20

--DELETE new records
DELETE
FROM disk_has_borrower
WHERE disk_has_borrower_id > 20

--RESET disk_has_borrower_id IDENTITY to max value. Without this the identity will continue to increment from the last known id, including the delete rows.
DECLARE @MAX INT
SELECT @MAX = MAX([disk_has_borrower_id]) FROM disk_has_borrower
IF @MAX IS NULL
SET @MAX = 0
DBCC CHECKIDENT ('[disk_has_borrower]', RESEED, @MAX)