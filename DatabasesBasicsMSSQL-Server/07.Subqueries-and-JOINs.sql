-- USE SoftUni
	--> 1.
SELECT TOP (5) e.EmployeeID, e.JobTitle, e.AddressID, 
       a.AddressText
  FROM Employees AS e
 INNER JOIN Addresses AS a
    ON a.AddressID = e.AddressID
 ORDER BY a.AddressID ASC

	--> 2.
SELECT TOP (50) e.FirstName, e.LastName, t.Name AS Town, a.AddressText
  FROM Employees AS e
 INNER JOIN Addresses AS a
    ON a.AddressID = e.AddressID
 INNER JOIN Towns AS t
    ON t.TownID = a.TownID
 ORDER BY e.FirstName ASC,
          e.LastName ASC

	--> 3.
SELECT e.EmployeeID, e.FirstName, e.LastName,
       d.Name AS DepartmentName
  FROM Employees AS e
 INNER JOIN Departments AS d
    ON d.DepartmentID = e.DepartmentID
 WHERE d.Name = 'Sales'
 ORDER BY e.EmployeeID

	--> 4.
SELECT TOP(5) e.EmployeeID, e.FirstName, e.Salary, 
       d.Name AS DepartmentName
  FROM Employees AS e
 INNER JOIN Departments AS d
    ON d.DepartmentID = e.DepartmentID
 WHERE e.Salary > 15000
 ORDER BY d.DepartmentID ASC

	--> 5.
SELECT TOP(3) e.EmployeeID, e.FirstName
  FROM Employees AS e
  LEFT JOIN EmployeesProjects AS ep
    ON ep.EmployeeID = e.EmployeeID
  LEFT JOIN Projects AS p
    ON Ep.ProjectID = p.ProjectID
 WHERE ep.ProjectID IS NULL
 ORDER BY e.EmployeeID ASC

	--> 6.
SELECT e.FirstName, e.LastName, e.HireDate,
       d.Name AS DeptName
  FROM Employees AS e
 INNER JOIN Departments AS d
    ON d.DepartmentID = e.DepartmentID
 WHERE e.HireDate > '19990101'
   AND d.Name IN ('Sales', 'Finance')

	--> 7.
SELECT TOP(5) e.EmployeeID, e.FirstName,
	   p.Name AS ProjectName
  FROM Employees AS e
 INNER JOIN EmployeesProjects AS ep
    ON ep.EmployeeID = e.EmployeeID
 INNER JOIN Projects AS p
    ON p.ProjectID = ep.ProjectID
 WHERE p.StartDate > '2002-08-13'
   AND p.EndDate IS NULL
 ORDER BY e.EmployeeID ASC

	--> 8.
SELECT e.EmployeeID, e.FirstName,
	   p.Name AS ProjectName
  FROM Employees AS e
 INNER JOIN EmployeesProjects AS ep
    ON ep.EmployeeID = e.EmployeeID
 LEFT JOIN Projects AS p
    ON p.ProjectID = ep.ProjectID
   AND p.StartDate <= '20050101'
 WHERE e.EmployeeID = 24

	--> 8. Second Solution
SELECT e.EmployeeID, e.FirstName,
	   CASE
	      WHEN p.StartDate >= '20050101' THEN NULL
		  ELSE p.Name
		END AS ProjectName
  FROM Employees AS e
 INNER JOIN EmployeesProjects AS ep
    ON ep.EmployeeID = e.EmployeeID
 INNER JOIN Projects AS p
    ON p.ProjectID = ep.ProjectID
 WHERE e.EmployeeID = 24

	--> 9.
SELECT e2.EmployeeID, e2.FirstName, e2.ManagerID,
       e.FirstName AS ManagerName
  FROM Employees AS e
 INNER JOIN Employees AS e2
    ON e2.ManagerID = e.EmployeeID
 WHERE e2.ManagerID IN (3, 7)
 ORDER BY e2.EmployeeID ASC

	--> 10.
SELECT TOP(50) e2.EmployeeID, CONCAT(e2.FirstName, ' ', e2.LastName) AS EmployeeName,
       CONCAT(e.FirstName, ' ', e.LastName) AS ManagerName,
	   d.Name AS DepartmentName
  FROM Employees AS e
 INNER JOIN Employees AS e2
    ON e.EmployeeID = e2.ManagerID
 INNER JOIN Departments AS d
    ON e2.DepartmentID = d.DepartmentID
 ORDER BY e2.EmployeeID

	--> 11.
SELECT MIN(AverageSalary.AvgS) AS MinAverageSalary
  FROM
(SELECT AVG(e.Salary) AS AvgS, e.DepartmentID
   FROM Employees AS e
  GROUP BY e.DepartmentID) AS AverageSalary

	--> 12.
-- USE Geography
SELECT c.CountryCode, 
       m.MountainRange,
	   p.PeakName, p.Elevation
  FROM Mountains AS m
 INNER JOIN MountainsCountries AS mc
    ON mc.MountainId = m.Id
 INNER JOIN Countries AS c
    ON mc.CountryCode = c.CountryCode
 INNER JOIN Peaks AS p
    ON p.MountainId = m.Id
 WHERE c.CountryCode = 'BG'
   AND p.Elevation > 2835
 ORDER BY p.Elevation DESC

	--> 13.
SELECT c.CountryCode, 
       COUNT(m.MountainRange) AS MountainRanges
  FROM Mountains AS m
 INNER JOIN MountainsCountries AS mc
    ON mc.MountainId = m.Id
 INNER JOIN Countries AS c
    ON mc.CountryCode = c.CountryCode
 WHERE c.CountryCode IN ('BG', 'RU', 'US')
 GROUP BY c.CountryCode

	--> 14.
SELECT TOP(5) c.CountryName, r.RiverName
  FROM Countries AS c
  LEFT JOIN CountriesRivers AS cr
    ON cr.CountryCode = c.CountryCode
  LEFT JOIN Rivers AS r
    ON r.Id = cr.RiverId
 WHERE c.ContinentCode = 'AF'
 ORDER BY c.CountryName ASC

	--> 15.
SELECT MaxUsage.ContinentCode, Usage.CurrencyCode, MaxUsage.CurrencyUsage
  FROM
(
SELECT ContinentCurr.ContinentCode, MAX(ContinentCurr.Usage) AS CurrencyUsage
  FROM
      (SELECT c.ContinentCode, c.CurrencyCode, COUNT(c.CurrencyCode) AS Usage
         FROM Countries AS c
        GROUP BY c.ContinentCode, c.CurrencyCode
	   HAVING COUNT(c.CurrencyCode) > 1) AS ContinentCurr
 GROUP BY ContinentCurr.ContinentCode
 ) AS MaxUsage
 INNER JOIN
(     
 SELECT c.ContinentCode, c.CurrencyCode, COUNT(c.CurrencyCode) AS Usage
   FROM Countries AS c
  GROUP BY c.ContinentCode, c.CurrencyCode
) AS Usage
    ON MaxUsage.ContinentCode = Usage.ContinentCode
   AND MaxUsage.CurrencyUsage = Usage.Usage
 ORDER BY ContinentCode

	--> 16.
SELECT COUNT(*) AS CountryCode
  FROM Countries AS c
  LEFT JOIN MountainsCountries AS mc
    ON mc.CountryCode = c.CountryCode
  LEFT JOIN Mountains AS m
    ON m.Id = mc.MountainId
 WHERE m.MountainRange IS NULL

	--> 17.
SELECT TOP(5) c.CountryName, 
       MAX(p.Elevation) AS HighestPeakElevation,
	   MAX(r.Length) AS LongestRiverLength
  FROM Countries AS c
  LEFT JOIN MountainsCountries AS mc
    ON mc.CountryCode = c.CountryCode
  LEFT JOIN Mountains AS m
    ON m.Id = mc.MountainId
  LEFT JOIN Peaks AS p
    ON p.MountainId = m.Id
  LEFT JOIN CountriesRivers AS cr
    ON cr.CountryCode = c.CountryCode
  LEFT JOIN Rivers AS r
    ON cr.RiverId = r.Id
 GROUP BY c.CountryName
 ORDER BY HighestPeakElevation DESC,
          LongestRiverLength DESC,
		  c.CountryName ASC

	--> 18.
SELECT TOP(5) Result.CountryName AS Country,
       Result.PeakName AS HighestPeakName,
	   Result.Elevation AS HighestPeakElevation,
	   Result.MountainRange AS Mountain
  FROM
(
SELECT c.CountryName, p.PeakName, p.Elevation, m.MountainRange
  FROM Countries AS c
 INNER JOIN MountainsCountries AS mc
    ON mc.CountryCode = c.CountryCode
 INNER JOIN Mountains AS m
    ON m.Id = mc.MountainId
 INNER JOIN Peaks AS p
    ON p.MountainId = m.Id
 INNER JOIN
(
SELECT c.CountryName, MAX(p.Elevation) AS MaxElevation
  FROM Countries AS c
 INNER JOIN MountainsCountries AS mc
    ON mc.CountryCode = c.CountryCode
 INNER JOIN Mountains AS m
    ON m.Id = mc.MountainId
 INNER JOIN Peaks AS p
    ON p.MountainId = m.Id
 GROUP BY c.CountryName 
) AS MaxElevationByCountry
    ON MaxElevationByCountry.CountryName = c.CountryName
   AND MaxElevationByCountry.MaxElevation = p.Elevation
 UNION ALL
SELECT c.CountryName, '(no highest peak)' AS PeakName, 0 AS Elevation, '(no mountain)' AS MountainRange
  FROM Countries AS c
  LEFT JOIN MountainsCountries AS mc
    ON mc.CountryCode = c.CountryCode
 WHERE mc.MountainId IS NULL
) AS Result
 ORDER BY Country ASC,
          HighestPeakName ASC
