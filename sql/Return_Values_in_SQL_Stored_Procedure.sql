-- Example for SQL Stored Procedure with Output Parameters
USE [SQL Tutorial]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[spGetEmployeeDetails]
		@Occupation = N'Management'

SELECT	'Return Value' = @return_value

GO


==============================================================


-- Example for SQL Stored Procedure with Output Parameters
USE [SQL Tutorial]
GO

CREATE PROCEDURE [dbo].[spCountEmployees]
AS
BEGIN
	RETURN (SELECT COUNT(EmpID)FROM [EmployeeDuplicates])
END

==================================================================

-- Example for SQL Stored Procedure return Values
USE [SQL Tutorial]
GO
-- Declare a Variable of Type Int. Should match with SP's Output parameter
DECLARE	@TotalEmployees INT 

-- Assigning the Output of a Stored Procedure to Declared variable
EXEC @TotalEmployees = [dbo].[spCountEmployees]

-- Printing the Output
PRINT @TotalEmployees


========================================================================


-- Example for SQL Stored Procedure Return Values
USE [SQL Tutorial]
GO

CREATE PROCEDURE [dbo].[spEmployeeName]
AS
BEGIN
 RETURN (SELECT [Occupation] FROM [EmployeeDuplicates]
         WHERE [LastName] = N'Gateway')
END


===========================================================================


-- Example for SQL Stored Procedure Return Values
USE [SQL Tutorial]
GO
DECLARE	@EmpName VARCHAR(50) 
EXEC @EmpName = [dbo].[spEmployeeName]
PRINT @EmpName


=============================================================================


