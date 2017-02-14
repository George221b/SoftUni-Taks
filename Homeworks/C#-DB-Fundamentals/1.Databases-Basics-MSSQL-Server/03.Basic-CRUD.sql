	--> 2.
SELECT *
  FROM Departments

	--> 3.
SELECT Departments.Name
  FROM Departments

	--> 4.
SELECT e.FirstName, e.LastName, e.Salary
  FROM Employees AS e

	--> 5.
SELECT e.FirstName, e.MiddleName, e.LastName
  FROM [dbo].[Employees] AS e

	--> 6.
SELECT e.FirstName + '.' + e.LastName + '@softuni.bg' AS [Full Email Adress]
  FROM [dbo].[Employees] AS e

	--> 7.
SELECT distinct e.Salary
  FROM [dbo].[Employees] AS e

	--> 8.
SELECT *
  FROM Employees
 WHERE JobTitle = 'Sales Representative'

	--> 9.
SELECT e.FirstName, e.LastName, e.JobTitle
  FROM Employees AS e
 WHERE e.Salary BETWEEN 20000 AND 30000

	--> 10.
SELECT e.FirstName + ' ' + e.MiddleName + ' ' + e.LastName
	   AS [Full Name]
  FROM Employees AS e
 WHERE Salary IN (25000, 14000, 12500, 23600)

	--> 11.
SELECT e.FirstName
	   ,e.LastName
  FROM Employees AS e
 WHERE ManagerID IS NULL

	--> 12.
SELECT e.FirstName
	   ,e.LastName
	   ,e.Salary
  FROM Employees AS e
 WHERE Salary >= 50000
 ORDER BY Salary DESC

	--> 13.
SELECT TOP 5 e.FirstName
	   ,e.LastName
  FROM Employees AS e
 ORDER BY Salary DESC

	--> 14.
SELECT e.FirstName
	   ,e.LastName
  FROM Employees AS e
 WHERE NOT e.DepartmentID = 4

	--> 15.
SELECT *
  FROM Employees AS e
 ORDER BY e.Salary DESC,
          e.FirstName ASC,
          e.LastName DESC,
          e.MiddleName ASC

	--> 16.
CREATE VIEW V_EmployeesSalaries AS
SELECT e.FirstName,
	   e.LastName,
	   e.Salary
  FROM Employees AS e

	--> 17.
CREATE VIEW V_EmployeeNameJobTitle AS
SELECT FirstName+' '+
    CASE
        WHEN MiddleName IS NULL THEN ' '+LastName
        ELSE MiddleName+' '+LastName
    END
AS [Full Name], JobTitle FROM Employees

	--> 18.
SELECT DISTINCT e.JobTitle 
  FROM Employees AS e

	--> 19.
SELECT TOP 10 p.ProjectID, 
	   p.Name, 
	   p.Description, 
	   p.StartDate, 
	   p.EndDate
  FROM Projects AS p
 ORDER BY p.StartDate ASC,
		  P.Name ASC

	--> 20.
SELECT TOP 7 e.FirstName,
	   e.LastName,
	   e.HireDate
  FROM Employees AS e
 ORDER BY e.HireDate DESC

	--> 21.
UPDATE Employees
SET Employees.Salary *= 1.12
WHERE DepartmentID IN (1, 2, 4, 11)

SELECT e.Salary
FROM Employees AS e

	--> 22.
SELECT [PeakName]
  FROM [Peaks]
  ORDER BY [PeakName] ASC

	--> 23.
SELECT TOP 30 [CountryName],
              [Population]
  FROM [Countries]
 WHERE [ContinentCode] = 'EU'
 ORDER BY [Population] DESC,
		  [CountryName] ASC

	--> 24.
SELECT [CountryName],
       [CountryCode],
	   CASE  
			WHEN [CurrencyCode] = 'EUR' THEN 'Euro' 
			ELSE 'Not Euro' 
	   END as [Currency]
  FROM [Countries]
 ORDER BY [CountryName] ASC

	--> 25.
SELECT [Name]
  FROM [Characters]
 ORDER BY [Name] ASC