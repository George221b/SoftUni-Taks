USE Gringotts

	--> 1.
SELECT COUNT(w.Id)
  FROM [WizzardDeposits] AS w

	--> 2.
SELECT MAX(w.MagicWandSize) AS [LongestMagicWand]
  FROM WizzardDeposits AS w

	--> 3.
SELECT w.DepositGroup, MAX(w.MagicWandSize) AS LongestMagicWand
  FROM WizzardDeposits AS w
GROUP BY w.DepositGroup

	--> 4.
SELECT TOP 1 WITH TIES w.DepositGroup
  FROM WizzardDeposits AS w
GROUP BY DepositGroup
ORDER BY AVG(magicwandsize) ASC

	--> 5.
SELECT w.DepositGroup,
	   SUM(w.DepositAmount)
  FROM [dbo].[WizzardDeposits] AS w
GROUP BY w.DepositGroup

	--> 6.
SELECT w.DepositGroup,
	   SUM(w.DepositAmount) AS TotalSum
  FROM WizzardDeposits AS w
 WHERE w.MagicWandCreator = 'Ollivander family'
GROUP BY w.DepositGroup

	--> 7.
SELECT w.DepositGroup,
	   SUM(w.DepositAmount) AS TotalSum
  FROM WizzardDeposits AS w
 WHERE w.MagicWandCreator = 'Ollivander family'
GROUP BY w.DepositGroup
HAVING SUM(w.DepositAmount) < 150000
ORDER BY TotalSum DESC

	--> 8.
SELECT w.DepositGroup,
       w.MagicWandCreator,
	   MIN(w.DepositCharge) AS MinDepositCharge
  FROM WizzardDeposits AS w
GROUP BY w.DepositGroup, 
         w.MagicWandCreator
ORDER BY w.MagicWandCreator ASC, 
         w.DepositGroup ASC

	--> 9.
SELECT
  CASE 
	 WHEN w.Age BETWEEN 0 AND 10 THEN '[0-10]'
	 WHEN w.Age BETWEEN 11 AND 20 THEN '[11-20]'
	 WHEN w.Age BETWEEN 21 AND 30 THEN '[21-30]'
	 WHEN w.Age BETWEEN 31 AND 40 THEN '[31-40]'
	 WHEN w.Age BETWEEN 41 AND 50 THEN '[41-50]'
	 WHEN w.Age BETWEEN 51 AND 60 THEN '[51-60]'
	 ELSE '[61+]'
  END AS [AgeGroup],
  COUNT(w.Id)
  FROM WizzardDeposits AS w
GROUP BY
  CASE 
	 WHEN w.Age BETWEEN 0 AND 10 THEN '[0-10]'
	 WHEN w.Age BETWEEN 11 AND 20 THEN '[11-20]'
	 WHEN w.Age BETWEEN 21 AND 30 THEN '[21-30]'
	 WHEN w.Age BETWEEN 31 AND 40 THEN '[31-40]'
	 WHEN w.Age BETWEEN 41 AND 50 THEN '[41-50]'
	 WHEN w.Age BETWEEN 51 AND 60 THEN '[51-60]'
	 ELSE '[61+]'
  END

	--> 10.
SELECT SUBSTRING(w.FirstName, 1, 1) AS FirstLetter
  FROM WizzardDeposits AS w
 WHERE w.DepositGroup = 'Troll Chest'
GROUP BY SUBSTRING(w.FirstName, 1, 1)
ORDER BY FirstLetter ASC

	--> 11.
SELECT w.DepositGroup,
       w.IsDepositExpired,
	   AVG(w.DepositInterest) AS AverageInterest
  FROM WizzardDeposits AS  w
 WHERE w.DepositStartDate > '01/01/1985'
GROUP BY w.DepositGroup, w.IsDepositExpired
ORDER BY w. DepositGroup DESC,
         w.IsDepositExpired ASC

	--> 12.
SELECT SUM(wizardDep.Difference) FROM
(
SELECT w.FirstName,
	   w.DepositAmount,
	   LEAD(w.FirstName) OVER (ORDER BY w.Id) AS GuestWizard,
	   LEAD(w.DepositAmount) OVER (ORDER BY w.Id) AS GuestDeposit,
	   w.DepositAmount - LEAD(w.DepositAmount) OVER (ORDER BY w.Id) AS Difference
  FROM WizzardDeposits AS w
) AS wizardDep

	--> 13.
USE SoftUni
SELECT e.DepartmentID,
       SUM(e.Salary) AS TotalSalary
  FROM Employees AS e
GROUP BY e.DepartmentID
ORDER BY e.DepartmentID

	--> 14.
SELECT e.DepartmentID,
       MIN(e.Salary) AS MinimumSalary
  FROM Employees AS e
 WHERE e.HireDate > '01/01/2000'
GROUP BY e.DepartmentID
HAVING e.DepartmentID IN (2, 5, 7)

	--> 15.
SELECT e.ManagerID, e.DepartmentID, e.Salary
  INTO SalaryTable
  FROM Employees AS e
 WHERE e.Salary > 30000

DELETE FROM SalaryTable
 WHERE SalaryTable.ManagerID = 42

UPDATE SalaryTable
   SET Salary = Salary + 5000
 WHERE DepartmentID = 1

SELECT s.DepartmentID, 
       AVG(s.Salary) AS AverageSalary
  FROM SalaryTable AS s
GROUP BY s.DepartmentID

	--> 16.
SELECT e.DepartmentID, 
       MAX(e.Salary) AS MaxSalary
  FROM Employees AS e
GROUP BY e.DepartmentID
HAVING MAX(e.Salary) NOT BETWEEN 30000 AND 70000

	--> 17.
SELECT COUNT(*) - COUNT(e.ManagerID) AS Count
  FROM Employees AS e

	--> 18.
SELECT Salaries.DepartmentID,
       Salaries.Salary
  FROM
(
SELECT e.DepartmentID, 
       MAX(e.Salary) AS Salary,
	   DENSE_RANK() OVER (PARTITION BY e.DepartmentId ORDER BY Salary DESC) AS RANK
  FROM Employees AS e
GROUP BY e.DepartmentID,
         e.Salary
) AS Salaries
 WHERE Salaries.RANK = 3
GROUP BY Salaries.DepartmentID, Salaries.Salary

	--> 19.
SELECT TOP 10 e.FirstName,
       e.LastName,
	   e.DepartmentID
  FROM Employees AS e
 WHERE Salary > (
				 SELECT AVG(emp.Salary) AS AverageSalary
				   FROM Employees AS emp
				  WHERE e.DepartmentID = emp.DepartmentID
				 GROUP BY emp.DepartmentID
                )
ORDER BY e.DepartmentID