-- SQL Server Rename Column Name query is: 
USE NewNameDB
GO

SP_RENAME 'Customers.YearlyIncome', 'Income', 'COLUMN'


