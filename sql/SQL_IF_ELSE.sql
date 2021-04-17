--SQL If Else Statement Syntax

IF (Test condition or Expression)
BEGIN
  -- If the condition is TRUE then these statements will be executed
  True statements;
END

ELSE
BEGIN
   -- If the condition is FALSE then these statements will be executed
   False statements;
END

==============================================================================

--SQL If Else Example 1

-- SQL If Else Example

--Declaring Number and Total Variables
DECLARE @Marks INT = 72 ;

IF @marks > = 50
BEGIN
   PRINT ' Congratulations ';
   PRINT ' You pass the Examination ';
END
ELSE
BEGIN
   PRINT ' You Failed ';
   PRINT ' Better Luck Next Time ';
END


====================================================================================

-- SQL If Else Statement Example 2

-- SQL If Else Example
--Declaring Number and Total Variables
DECLARE @Sales INT = 2500 ;

IF @Sales > = 2000
BEGIN
  SELECT [FirstName],[LastName]
      ,[Education],[Occupation]
      ,[YearlyIncome],[Sales],[HireDate]
  FROM [SQL Tutorial].[dbo].[Employee]
  WHERE [Sales] >= 2000
  ORDER BY [Sales] ASC
END

ELSE
BEGIN
SELECT [FirstName],[LastName]
      ,[Education],[Occupation]
      ,[YearlyIncome],[Sales],[HireDate]
  FROM [SQL Tutorial].[dbo].[Employee]
  WHERE [Sales] < 2000
  ORDER BY [Sales] ASC
END



