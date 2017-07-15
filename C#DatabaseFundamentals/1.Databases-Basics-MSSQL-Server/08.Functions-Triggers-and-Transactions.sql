	-- Part I – Queries for SoftUni Database
	-- 1.
-- USE SoftUni
CREATE PROC usp_GetEmployeesSalaryAbove35000
AS
BEGIN
	SELECT e.FirstName, e.LastName
	  FROM Employees AS e
	 WHERE e.Salary > 35000
END
-- EXEC usp_GetEmployeesSalaryAbove35000

	--> 2.
CREATE PROC usp_GetEmployeesSalaryAboveNumber
(@aboveVar MONEY)
AS
BEGIN
	SELECT e.FirstName, e.LastName 
	  FROM Employees AS e
	 WHERE e.Salary >= @aboveVar
END
-- EXEC usp_GetEmployeesSalaryAboveNumber 70000

	--> 3.
CREATE PROC usp_GetTownsStartingWith
(@pattern NVARCHAR(10))
AS
BEGIN
	SELECT t.Name
	  FROM Towns AS t
	 WHERE t.Name LIKE @pattern + '%'
END
-- EXEC dbo.usp_GetTownsStartingWith 'B'

	--> 4.
CREATE PROC usp_GetEmployeesFromTown
(@townName NVARCHAR(20))
AS
BEGIN
	SELECT e.FirstName, e.LastName
	  FROM Employees AS e
	 INNER JOIN Addresses AS a
	    ON a.AddressID = e.AddressID
	 INNER JOIN Towns AS t
	    ON t.TownID = a.TownID
	 WHERE t.Name = @townName
END
-- EXEC dbo.usp_GetEmployeesFromTown'Sofia'

	--> 5.
CREATE FUNCTION ufn_GetSalaryLevel
(@salary MONEY)
RETURNS VARCHAR(7)
AS
BEGIN
	DECLARE @output VARCHAR(7);

	IF(@salary < 30000)
		SET @output = 'Low';
	ELSE IF(@salary <= 50000)
		SET @output = 'Average';
	ELSE
		SET @output = 'High';

	RETURN @output;
END

	--> 6.
CREATE PROC usp_EmployeesBySalaryLevel
(@levelOfSalary VARCHAR(7))
AS
BEGIN
	SELECT e.FirstName, e.LastName
	  FROM Employees AS e
	 WHERE dbo.ufn_GetSalaryLevel(e.Salary) = @levelOfSalary
END
-- EXEC dbo.usp_EmployeesBySalaryLevel 'High'

	--> 7.
CREATE FUNCTION ufn_IsWordComprised
(@setOfLetters VARCHAR(MAX), @word VARCHAR(MAX))
RETURNS BIT
AS
BEGIN
	DECLARE @lengthWord INT = LEN(@word);
	DECLARE @startPosition INT = 1;
	DECLARE @currentChar CHAR;

	WHILE(@startPosition <= @lengthWord)
	BEGIN
		SET @currentChar = SUBSTRING(@word, @startPosition, 1);
		IF(CHARINDEX(@currentChar, @setOfLetters, 1) = 0)
		BEGIN
			RETURN 0;
		END

		SET @startPosition += 1;
	END

	RETURN 1;
END
-- SELECT dbo.ufn_IsWordComprised('oistmiahf', 'Sofia')

	--> 8.
ALTER TABLE Departments
ALTER COLUMN ManagerID INT NULL;

DELETE FROM EmployeesProjects
 WHERE EmployeeID IN (
						SELECT e.EmployeeID
						  FROM Employees AS e
						 INNER JOIN Departments AS d
						    ON d.DepartmentID = e.DepartmentID
						 WHERE d.Name IN ('Production', 'Production Control')
					 );

UPDATE Employees
   SET ManagerID = NULL
 WHERE ManagerID IN (
						SELECT e.EmployeeID
						  FROM Employees AS e
						 INNER JOIN Departments AS d
						    ON d.DepartmentID = e.DepartmentID
						 WHERE d.Name IN ('Production', 'Production Control')
                    );

UPDATE Departments
   SET ManagerID = NULL
 WHERE ManagerID IN (
						SELECT e.EmployeeID
						 FROM Employees AS e
						INNER JOIN Departments AS d
						   ON d.DepartmentID = e.DepartmentID
						WHERE d.Name IN ('Production', 'Production Control')
					);

DELETE FROM Employees
 WHERE EmployeeID IN (
						SELECT e.EmployeeID
						 FROM Employees AS e
						INNER JOIN Departments AS d
						   ON d.DepartmentID = e.DepartmentID
						WHERE d.Name IN ('Production', 'Production Control')
                     );

DELETE FROM Departments
 WHERE Departments.Name IN('Production', 'Production Control');

	--> 9.
CREATE PROCEDURE usp_AssignProject (@EmployeeID INT, @ProjectID INT)
AS
BEGIN
	DECLARE @maxEmployeeProjectsCount INT = 3;
	DECLARE @employeeProjectsCount INT;
	SET @employeeProjectsCount = (SELECT COUNT(*) 
			        FROM [dbo].[EmployeesProjects] AS ep
			       WHERE ep.EmployeeId = @EmployeeID);
	
	BEGIN TRAN
	INSERT INTO EmployeesProjects(EmployeeID, ProjectID)
	VALUES (@EmployeeID, @ProjectID)
	
	IF(@employeeProjectsCount >= @maxEmployeeProjectsCount)
	  BEGIN
	   RAISERROR('The employee has too many projects!', 16, 1)
	   ROLLBACK
	  END
	ELSE
	   COMMIT
END

	-- PART II – Queries for Bank Database
	--> 10.
-- USE Bank
CREATE PROC usp_GetHoldersFullName
AS
BEGIN
	SELECT CONCAT(ah.FirstName, ' ', ah.LastName) AS [Full Name]
	  FROM AccountHolders AS ah
END

	--> 11.
CREATE PROC usp_GetHoldersWithBalanceHigherThan
(@balance MONEY)
AS
BEGIN
	SELECT ah.FirstName, ah.LastName
	  FROM AccountHolders AS ah
	 INNER JOIN Accounts AS a
	    ON a.AccountHolderId = ah.Id
	 GROUP BY ah.FirstName, ah.LastName
	HAVING SUM(a.Balance) > @balance
END

	--> 12.
CREATE FUNCTION ufn_CalculateFutureValue
(@sum MONEY, @yearlyInterestRate FLOAT, @numberOfYears INT)
RETURNS MONEY
AS
BEGIN
	DECLARE @YIRxYears FLOAT = POWER((1 + @yearlyInterestRate), @numberOfYears);
	DECLARE @result MONEY = @YIRxYears * @sum;
	RETURN @result;
END
-- SELECT dbo.ufn_CalculateFutureValue(1000, 0.1, 5)

	--> 13.
CREATE PROC usp_CalculateFutureValueForAccount
(@AccountId INT, @yearlyInterestRate FLOAT)
AS
BEGIN
	SELECT TOP(1) ah.Id AS [Account Id],
		   ah.FirstName AS [First Name],
		   ah.LastName AS [Last Name],
		   a.Balance AS [Current Balance],
		   dbo.ufn_CalculateFutureValue(a.Balance, @yearlyInterestRate, 5) AS [Balance in 5 years]
	  FROM AccountHolders AS ah
	 INNER JOIN Accounts AS a
	    ON a.AccountHolderId = ah.Id
	 WHERE a.AccountHolderId = @AccountId
END
-- EXEC dbo.usp_CalculateFutureValueForAccount 1, 0.1

	--> 14.
CREATE PROC usp_DepositMoney
(@AccountId INT, @moneyAmount MONEY)
AS
BEGIN
	BEGIN TRANSACTION

	UPDATE Accounts SET Balance = Balance + @moneyAmount
	WHERE Id = @AccountId
	
	COMMIT
END

	--> 15.
CREATE PROC usp_WithdrawMoney
(@AccountId INT, @moneyAmount MONEY)
AS
BEGIN
	BEGIN TRANSACTION
	UPDATE Accounts SET Balance = Balance - @moneyAmount
	WHERE Id = @AccountId
	IF @@ROWCOUNT <> 1 -- Affected rows are different than one.
	BEGIN
	  ROLLBACK
	  RAISERROR('Invalid account!', 16, 1)
	  RETURN
	END

	COMMIT
END

	--> 16.
CREATE PROC usp_TransferMoney
(@senderId INT, @receiverId INT, @amount MONEY)
AS
BEGIN
	BEGIN TRANSACTION
	
	-- take money from sender
	UPDATE Accounts
	   SET Balance-=@amount
	 WHERE  Accounts.Id = @senderId
	IF (@@ROWCOUNT) <> 1
	BEGIN
		ROLLBACK
		RETURN
	END
	 
	-- transfer money from receiver
	UPDATE Accounts
	   SET Balance+=@amount
	 WHERE  Accounts.Id = @receiverId
	IF (@@ROWCOUNT) <> 1
	BEGIN
		ROLLBACK
		RETURN
	END
	 
	 
	COMMIT
END

	--> 17.
CREATE TABLE Logs (
LogId INT PRIMARY KEY IDENTITY(1, 1),
AccountId INT FOREIGN KEY REFERENCES Accounts(Id),
OldSum MONEY NOT NULL,
NewSum MONEY NOT NULL
)

CREATE TRIGGER T_Accounts_After_Update ON Accounts
AFTER UPDATE
AS
BEGIN
	INSERT INTO Logs (AccountId, OldSum, NewSum)
	SELECT i.Id, d.Balance, i.Balance
	  FROM inserted AS i
	 INNER JOIN deleted AS d
	    ON d.Id = i.Id
END

UPDATE Accounts
   SET Balance += 10
 WHERE Id = 3

UPDATE Accounts
   SET Balance -= 10
 WHERE Id = 3

SELECT * FROM Logs

	--> 18.
CREATE TABLE NotificationEmails (
Id INT PRIMARY KEY IDENTITY(1, 1),
Recipient INT NOT NULL,
Subject VARCHAR(250) NOT NULL,
Body VARCHAR(MAX) NOT NULL
);
ALTER TABLE NotificationEmails
ADD FOREIGN KEY (Recipient)
REFERENCES Accounts(Id);

CREATE TRIGGER T_Logs_After_Update ON Logs
AFTER INSERT
AS
BEGIN
	INSERT INTO NotificationEmails(Recipient, Subject, Body)
	SELECT l.AccountId AS [Recipient],
		   CONCAT('Balance change for account: ', l.AccountId) AS [Subject],
		   CONCAT('On ', GETDATE(), ' your balance was changed from ', l.OldSum, ' to ', l.NewSum, '.') AS [Body]
	  FROM Logs AS l
END
-- SELECT *
--   FROM NotificationEmails

	--> PART III – Queries for Diablo Database
	--> 19.
-- USE Diablo
CREATE FUNCTION ufn_CashInUsersGames (@gameName nvarchar(50))
RETURNS TABLE
AS
RETURN
(
	SELECT SUM(ug.Cash) AS [SumCash]
	  FROM UsersGames ug
     INNER JOIN (SELECT
	  	   		  	ug.Id,
		   			ug.Cash,
		   		    ROW_NUMBER() OVER(ORDER BY ug.Cash DESC) as [RowNumber]
		   		  FROM [UsersGames] ug
		   	     WHERE ug.GameId IN (SELECT Id FROM Games WHERE Name = @gameName)
		   	   ) AS t
	    ON ug.Id = t.Id
     WHERE t.RowNumber %2 <> 0
);
-- SELECT *
--   FROM ufn_CashInUsersGames('Bali')

	--> 21.
DECLARE @usersGamesId int = (SELECT ug.Id 
							   FROM UsersGames ug 
							  INNER JOIN Users u 
							     ON u.Id = ug.UserId  
							  INNER JOIN Games g 
							     ON ug.GameId = g.Id
							  WHERE u.Username = 'Stamat' 
									AND g.Name = 'Safflower');

DECLARE @userIngameCash money = (SELECT ug.[Cash] 
								   FROM UsersGames ug 
								  WHERE ug.[Id] = @usersGamesId);

DECLARE @itemsPriceLevel11_12 money = (SELECT SUM([Price])
										 FROM Items
									    WHERE [MinLevel] BETWEEN 11 AND 12)

BEGIN TRAN

	IF(@userIngameCash < @itemsPriceLevel11_12)
	BEGIN
		ROLLBACK;
	END
	ELSE
	BEGIN
		UPDATE UsersGames
		   SET Cash -= @itemsPriceLevel11_12
		 WHERE Id = @usersGamesId;

		DECLARE @itemsCount int = (SELECT COUNT(*) 
								     FROM Items 
									WHERE [MinLevel] BETWEEN 11 AND 12)

		--Insert items:
		INSERT INTO UserGameItems(UserGameId, ItemId)
		SELECT @usersGamesId, [Id] 
		  FROM Items 
		 WHERE [MinLevel] BETWEEN 11 AND 12

		 IF(@@ROWCOUNT != @itemsCount)
		 BEGIN 
			ROLLBACK;
		 END

		 COMMIT;
	END
	
DECLARE @itemsPriceLevel19_21 money = (SELECT SUM([Price])
										 FROM Items 
										WHERE [MinLevel] BETWEEN 19 AND 21)

SET @userIngameCash = (SELECT [Cash]
						 FROM UsersGames
					    WHERE [Id] = @usersGamesId);

SET @itemsCount = (SELECT COUNT(*)
					 FROM Items 
					WHERE [MinLevel] BETWEEN 19 AND 21)

BEGIN TRAN
	IF(@userIngameCash < @itemsPriceLevel19_21)
	BEGIN
		ROLLBACK;
	END
	ELSE
	BEGIN
		UPDATE UsersGames
		   SET Cash -= @itemsPriceLevel19_21
		 WHERE Id = @usersGamesId;
	
		 SET @itemsCount = (SELECT COUNT(*)
							  FROM Items 
							 WHERE [MinLevel] BETWEEN 19 AND 21)
		
		--Insert items:
		INSERT INTO UserGameItems(UserGameId, ItemId)
		SELECT @usersGamesId, [Id]
		  FROM Items
		 WHERE [MinLevel] BETWEEN 19 AND 21
	
		 IF(@@ROWCOUNT <>@itemsCount)
		 BEGIN
			ROLLBACK;
		 END 
	
		 COMMIT;
	END
	
SELECT
	 i.Name AS [Item Name] 
  FROM UserGameItems ugi
 INNER JOIN Items i
    ON ugi.ItemId = i.Id
 WHERE ugi.UserGameId = @usersGamesId
 ORDER BY i.Name

	--> 22.
SELECT SUBSTRING(u.Email, CHARINDEX('@', u.Email, 1) + 1, LEN(u.Email)) AS [Email Provider],
       COUNT(*) AS [Number Of Users]
  FROM Users AS u
 GROUP BY SUBSTRING(u.Email, CHARINDEX('@', u.Email, 1) + 1, LEN(u.Email))
 ORDER BY [Number Of Users] DESC,
          [Email Provider] ASC

	--> 23.
SELECT g.Name AS [Game], 
       gt.Name AS [Game Type],
	   u.Username,
	   ug.Level,
	   ug.Cash,
	   c.Name AS [Character]
  FROM Users AS u
 INNER JOIN UsersGames AS ug
    ON ug.UserId = u.Id
 INNER JOIN Games AS g
    ON g.Id = ug.GameId
 INNER JOIN GameTypes AS gt
    ON gt.Id = g.GameTypeId
 INNER JOIN Characters AS c
    ON c.Id = ug.CharacterId
 ORDER BY ug.Level DESC,
          u.Username ASC,
		  g.Name ASC

	--> 24.
SELECT u.Username,
       g.Name AS [Game],
	   COUNT(i.Id) AS [Items Count],
	   SUM(i.Price) AS [Items Price]
  FROM Users AS u
 INNER JOIN UsersGames AS ug
    ON ug.UserId = u.Id
 INNER JOIN UserGameItems AS ugi
    ON ugi.UserGameId = ug.Id
 INNER JOIN Items AS i
    ON ugi.ItemId = i.Id
 INNER JOIN Games AS g
    ON g.Id = ug.GameId
 GROUP BY u.Username, g.Name
HAVING COUNT(i.Id) >= 10
 ORDER BY COUNT(i.Id) DESC,
	      SUM(i.Price) DESC,
		  u.Username ASC

	--> 25.
SELECT u.Username, 
	   g.Name AS Game, 
	   MAX(c.Name) AS Character,
       SUM(its.Strength) + MAX(gts.Strength) + MAX(cs.Strength) AS Strength,
       SUM(its.Defence) + MAX(gts.Defence) + MAX(cs.Defence) AS Defence,
       SUM(its.Speed) + MAX(gts.Speed) + MAX(cs.Speed) AS Speed,
       SUM(its.Mind) + MAX(gts.Mind) + MAX(cs.Mind) AS Mind,
       SUM(its.Luck) + MAX(gts.Luck) + MAX(cs.Luck) AS Luck
  FROM Users AS u
 INNER JOIN UsersGames AS ug
    ON u.Id = ug.UserId
 INNER JOIN Games AS g
    ON ug.GameId = g.Id
 INNER JOIN GameTypes AS gt
    ON gt.Id = g.GameTypeId
 INNER JOIN [Statistics] AS gts
    ON gts.Id = gt.BonusStatsId
 INNER JOIN Characters AS c
    ON ug.CharacterId = c.Id
 INNER JOIN [Statistics] AS cs
    ON cs.Id = c.StatisticId
 INNER JOIN UserGameItems AS ugi
    ON ugi.UserGameId = ug.Id
 INNER JOIN Items AS i
    ON i.Id = ugi.ItemId
 INNER JOIN [Statistics] AS its
    ON its.Id = i.StatisticId
 GROUP BY u.Username, g.Name
 ORDER BY Strength DESC, Defence DESC, Speed DESC, Mind DESC, Luck DESC

	--> 26.
SELECT i.Name, i.Price, i.MinLevel, 
	s.Strength, s.Defence, s.Speed, s.Luck, s.Mind
  FROM Items i
 INNER JOIN [Statistics] s
    ON i.StatisticId = s.Id
 WHERE s.Speed > (SELECT AVG(s.Speed)
					FROM Items i
					JOIN [Statistics] s
					ON i.StatisticId = s.Id
					)
AND s.Luck > (SELECT AVG(s.Luck)
					FROM Items i
					JOIN [Statistics] s
					ON i.StatisticId = s.Id
					)
AND s.Mind > (SELECT AVG(s.Mind)
					FROM Items i
					JOIN [Statistics] s
					ON i.StatisticId = s.Id
					)
ORDER BY i.Name

	--> 27.
SELECT i.Name AS Item,
       i.Price, i.MinLevel,
	   gt.Name AS [Forbidden Game Type]
  FROM Items AS i
  FULL JOIN GameTypeForbiddenItems AS gtfi
    ON gtfi.ItemId = i.Id
  FULL JOIN GameTypes AS gt
    ON gt.Id = gtfi.GameTypeId
 ORDER BY gt.Name DESC,
          i.Name ASC

	--> 28.
DECLARE @sumCash MONEY = (
	SELECT SUM(Price)
	  FROM Items
	 WHERE Name IN ('Blackguard', 'Bottomless Potion of Amplification',
	'Eye of Etlich (Diablo III)', 'Gem of Efficacious Toxin', 
	'Golden Gorget of Leoric', 'Hellfire Amulet')
)

BEGIN TRAN
IF ((SELECT SUM(Cash) FROM UsersGames 
	WHERE UserId = (SELECT Id FROM Users
					WHERE Username = 'Alex')) < @sumCash)
BEGIN
	ROLLBACK
END

ELSE
	UPDATE UsersGames
	SET Cash = Cash - @sumCash
	WHERE UserId = (SELECT Id FROM Users
					WHERE Username = 'Alex')

	INSERT INTO UserGameItems (ItemId, UserGameId)
	(SELECT i.Id, 235
	FROM Items i
	WHERE Name IN ('Blackguard', 'Bottomless Potion of Amplification',
	'Eye of Etlich (Diablo III)', 'Gem of Efficacious Toxin', 
	'Golden Gorget of Leoric', 'Hellfire Amulet'))
COMMIT

SELECT u.Username, g.Name, ug.Cash, i.Name AS [Item Name]
  FROM UserGameItems ugi
 INNER JOIN Items i
    ON ugi.ItemId = i.Id
 INNER JOIN UsersGames ug
    ON ug.Id = ugi.UserGameId
 INNER JOIN Users u
    ON ug.UserId = u.Id
 INNER JOIN  Games g
    ON ug.GameId = g.Id
 WHERE g.Name = 'Edinburgh'
 ORDER BY i.Name

	-- PART IV – Queries for Geography Database
	--> 29.
-- USE Geography
SELECT p.PeakName,
       m.MountainRange AS Mountain, p.Elevation
  FROM Mountains AS m
 INNER JOIN Peaks AS p
    ON m.Id = p.MountainId
 ORDER BY p.Elevation DESC,
          p.PeakName ASC

	--> 30.
SELECT p.PeakName, m.MountainRange AS [Mountain],
       c.CountryName,
	   co.ContinentName
  FROM Mountains AS m
 INNER JOIN Peaks AS p
    ON m.Id = p.MountainId
 INNER JOIN MountainsCountries AS mc
    ON mc.MountainId = m.Id
 INNER JOIN Countries AS c
    ON mc.CountryCode = c.CountryCode
 INNER JOIN Continents AS co
    ON co.ContinentCode = c.ContinentCode
 ORDER BY p.PeakName ASC,
          c.CountryName ASC

	--> 31.
SELECT *
  FROM
(
SELECT c.CountryName, co.ContinentName,
       COUNT(r.Id) AS RiversCount,
	   SUM(r.Length) AS TotalLength
  FROM Rivers AS r
 INNER JOIN CountriesRivers AS cr
    ON r.Id = cr.RiverId
 INNER JOIN Countries AS c
    ON cr.CountryCode = c.CountryCode
 INNER JOIN Continents AS co
    ON co.ContinentCode = c.ContinentCode
 GROUP BY c.CountryName, co.ContinentName
 UNION ALL
SELECT c.CountryName, co.ContinentName,
       0 AS RiversCount,
	   0 AS TotalLength
  FROM Rivers AS r
 INNER JOIN CountriesRivers AS cr
    ON r.Id = cr.RiverId
 RIGHT JOIN Countries AS c
    ON cr.CountryCode = c.CountryCode
 INNER JOIN Continents AS co
    ON co.ContinentCode = c.ContinentCode
 WHERE cr.RiverId IS NULL
) AS Result
 ORDER BY Result.RiversCount DESC,
          Result.TotalLength DESC,
		  Result.CountryName ASC
		  
	--> 32.
SELECT cu.CurrencyCode,
       cu.Description AS Currency,
       COUNT(c.CurrencyCode) AS NumberOfCountries
  FROM Currencies AS cu
  LEFT JOIN Countries AS c
    ON c.CurrencyCode = cu.CurrencyCode
 GROUP BY cu.CurrencyCode, cu.Description
 ORDER BY COUNT(c.CurrencyCode) DESC, cu.Description ASC

	--> 33.
SELECT co.ContinentName,
       SUM(c.AreaInSqKm) AS CountriesArea,
	   SUM(CONVERT(BIGINT, c.Population)) AS CountriesPopulation
  FROM Countries AS c
 INNER JOIN Continents AS co
    ON co.ContinentCode = c.ContinentCode
 GROUP BY co.ContinentName
 ORDER BY SUM(CONVERT(BIGINT, c.Population)) DESC

	--> 34.
CREATE TABLE Monasteries(
Id INT IDENTITY PRIMARY KEY,
Name NVARCHAR(50),
CountryCode CHAR(2) 
FOREIGN KEY (CountryCode) REFERENCES Countries(CountryCode)
)

INSERT INTO Monasteries(Name, CountryCode) VALUES
('Rila Monastery “St. Ivan of Rila”', 'BG'), 
('Bachkovo Monastery “Virgin Mary”', 'BG'),
('Troyan Monastery “Holy Mother''s Assumption”', 'BG'),
('Kopan Monastery', 'NP'),
('Thrangu Tashi Yangtse Monastery', 'NP'),
('Shechen Tennyi Dargyeling Monastery', 'NP'),
('Benchen Monastery', 'NP'),
('Southern Shaolin Monastery', 'CN'),
('Dabei Monastery', 'CN'),
('Wa Sau Toi', 'CN'),
('Lhunshigyia Monastery', 'CN'),
('Rakya Monastery', 'CN'),
('Monasteries of Meteora', 'GR'),
('The Holy Monastery of Stavronikita', 'GR'),
('Taung Kalat Monastery', 'MM'),
('Pa-Auk Forest Monastery', 'MM'),
('Taktsang Palphug Monastery', 'BT'),
('Sümela Monastery', 'TR')

ALTER TABLE Countries 
ADD IsDeleted BIT DEFAULT 0


UPDATE Countries
SET IsDeleted = 1
WHERE CountryCode IN (SELECT r.CountryCode 
						FROM (SELECT c.CountryCode, COUNT(cr.RiverId) AS CountR
								FROM Countries c
								JOIN CountriesRivers cr
								ON c.CountryCode = cr.CountryCode
								GROUP BY c.CountryCode
								HAVING COUNT(cr.RiverId) > 3) r
					)

SELECT m.Name AS Monastery, c.CountryName AS Country
  FROM Monasteries m
 INNER JOIN Countries c
    ON m.CountryCode = c.CountryCode
 WHERE c.IsDeleted != 1 OR c.IsDeleted IS NULL
 ORDER BY Monastery

	--> 35.
UPDATE Countries
SET CountryName = 'Burma'
WHERE CountryName = 'Myanmar'

INSERT INTO Monasteries(Name, CountryCode)
SELECT 'Hanga Abbey', CountryCode 
  FROM Countries
 WHERE CountryName = 'Tanzania'


INSERT INTO Monasteries(Name, CountryCode)
SELECT 'Myin-Tin-Daik', CountryCode 
  FROM Countries
 WHERE CountryName = 'Myanmar'

SELECT cnt.ContinentName, cntr.CountryName, 
COUNT(m.Id) AS MonasteriesCount
FROM Countries cntr
LEFT JOIN Continents cnt
ON cnt.ContinentCode = cntr.ContinentCode
LEFT JOIN Monasteries m
ON cntr.CountryCode = m.CountryCode
WHERE cntr.IsDeleted != 1 OR cntr.IsDeleted IS NULL
GROUP BY cnt.ContinentName, cntr.CountryName
ORDER BY MonasteriesCount DESC, cntr.CountryName