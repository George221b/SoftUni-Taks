	--> Part 1 - SoftUni database
	--> 1.
SELECT FirstName, LastName 
  FROM Employees
 WHERE Substring(FirstName, 1, 2) = 'Sa'

	--> 2.
SELECT FirstName, LastName 
  FROM Employees
 WHERE LastName LIKE '%ei%'

	--> 3.
SELECT e.FirstName
  FROM Employees AS e
 WHERE (e.DepartmentID IN (3, 10))
   AND (YEAR(e.HireDate) BETWEEN 1995 AND 2005)

	--> 4.
SELECT e.FirstName, e.LastName
  FROM Employees AS e
 WHERE e.JobTitle NOT LIKE '%engineer%'

	--> 5.
SELECT t.Name
  FROM Towns AS t
 WHERE LEN(t.Name) BETWEEN 5 AND 6
ORDER BY t.Name ASC

	--> 6.
SELECT t.TownID, t.Name
  FROM Towns AS t
 WHERE LEFT(t.Name, 1) = 'M'
    OR SUBSTRING(t.Name, 1, 1) = 'K'
	OR CHARINDEX('B', t.Name) = 1
	OR LEFT(t.Name, 1) = 'E'
ORDER BY t.Name ASC

	--> 7.
SELECT t.TownID, t.Name
  FROM Towns AS t
 WHERE LEFT(t.Name, 1) != 'R'
    AND (SUBSTRING(t.Name, 1, 1) != 'B')
	AND CHARINDEX('D', t.Name) != 1
ORDER BY t.Name ASC

	--> 8.
GO
CREATE VIEW V_EmployeesHiredAfter2000
AS
SELECT e.FirstName, e.LastName
  FROM Employees AS e
 WHERE YEAR(e.HireDate) > 2000
GO

	--> 9.
SELECT e.FirstName, e.LastName
  FROM Employees AS e
 WHERE LEN(e.LastName) = 5

	--> Part 2 - Geography Database
USE Geography
	--> 10.
SELECT c.CountryName, c.IsoCode
  FROM Countries AS c
 WHERE c.CountryName LIKE '%a%%a%%a%'
ORDER BY c.IsoCode ASC

	--> 11.
SELECT p.PeakName, 
	   r.RiverName,
	   LOWER(CONCAT(p.PeakName, RIGHT(r.RiverName, LEN(r.RiverName) - 1))) AS Mix	   
  FROM Peaks AS p, Rivers AS r
 WHERE RIGHT(p.PeakName, 1) = LEFT(r.RiverName, 1)
ORDER BY Mix ASC

	--> Part 3 - Queries for Diablo Database
USE Diablo
	--> 12.
SELECT TOP 50 g.Name, FORMAT(g.Start, 'yyyy-MM-dd') AS Started
  FROM Games AS g
 WHERE YEAR(g.Start) BETWEEN 2011 AND 2012
ORDER BY g.Start ASC, g.Name ASC

	--> 13.
SELECT u.Username,
	   SUBSTRING(u.Email, CHARINDEX('@', u.Email) + 1, LEN(u.Email)) AS [Email Provider]
FROM Users AS u
ORDER BY [Email Provider] ASC, u.Username ASC

	--> 14.
SELECT u.Username, u.IpAddress
  FROM Users AS u
 WHERE u.IpAddress LIKE '___.1%.%.___'
ORDER BY u.Username ASC

	--> 15.
SELECT g.Name AS [Game],
	   CASE
		WHEN DATEPART(hour, g.Start) BETWEEN 0 AND 11 THEN 'Morning'
		WHEN DATEPART(hour, g.Start) BETWEEN 12 AND 17 THEN 'Afternoon'
		WHEN DATEPART(hour, g.Start) BETWEEN 18 AND 23 THEN 'Evening'		
	   END AS [Part of the Day],
	   CASE
		WHEN g.Duration BETWEEN 0 AND 3 THEN 'Extra Short'
		WHEN g.Duration BETWEEN 4 AND 6 THEN 'Short'
		WHEN g.Duration >= 7 THEN 'Long'
		WHEN g.Duration IS NULL THEN 'Extra Long'
	   END AS [Duration]
  FROM Games AS g
ORDER BY [Game] ASC, [Duration] ASC, [Part of the Day] ASC

	--> Part 4 - Date Functions Queries
USE Orders
	--> 16.
SELECT o.ProductName, 
	   o.OrderDate,
	   DATEADD(DAY, 3, o.OrderDate) AS [Pay Due],
	   DATEADD(MONTH, 1, o.OrderDate) AS [Deliver Due]
  FROM Orders AS o