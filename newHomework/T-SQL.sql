/* 1. Create a database with two tables: Persons(Id(PK), FirstName, LastName, SSN) 
and Accounts(Id(PK), PersonId(FK), Balance). Insert few records for testing. 
Write a stored procedure that selects the full names of all persons.*/
CREATE Database Bank;
GO
CREATE TABLE Persons
(
	Id int IDENTITY,
	FirstName nvarchar(50),
	LastName nvarchar(50),
	SSN nvarchar(20),
	PRIMARY KEY(Id)
)
GO

CREATE TABLE Acounts
(
	Id int IDENTITY,
	PersonId int,
	Balance money,
	PRIMARY KEY(Id)
)
GO
ALTER TABLE Accounts
ADD CONSTRAINT FK_Accounts_Persons
FOREIGN KEY (PersonId)
REFERENCES Persons(Id)

USE Bank

INSERT INTO Persons(FirstName, LastName, SSN) VALUES('Ivan', 'Ivanov', 'ed12d2d2')
INSERT INTO Persons(FirstName, LastName, SSN) VALUES('Ivan', 'Todorov', 'ee2d23b')
INSERT INTO Persons(FirstName, LastName, SSN) VALUES('Gosho', 'Ivanov', 'klniu2')
INSERT INTO Persons(FirstName, LastName, SSN) VALUES('Todor', 'Todorov', 'emknio2')
INSERT INTO Persons(FirstName, LastName, SSN) VALUES('Kozar', 'Ovcharov', 'OV4AR')

INSERT INTO Acounts(PersonId, Balance) VALUES (1, 40200)
INSERT INTO Acounts(PersonId, Balance) VALUES (2, 10)
INSERT INTO Acounts(PersonId, Balance) VALUES (3, 9000)
INSERT INTO Acounts(PersonId, Balance) VALUES (4, 9999999999999)

CREATE PROCEDURE dbo.usp_SelectFullName
AS
  SELECT dbo.Persons.FirstName + ' ' + dbo.Persons.LastName AS [FullName] FROM dbo.Persons
GO

/* 2. Create a stored procedure that accepts a number as a parameter and returns all persons who have
 more money in their accounts than the supplied number.*/
 CREATE PROCEDURE usp_getPeopleThatHaveMoreMoney(@money int=1000)
AS
	SELECT a.Balance FROM dbo.Persons p JOIN dbo.Acounts a ON p.Id=a.PersonId WHERE a.Balance>@money
GO

EXEC usp_getPeopleThatHaveMoreMoney 5000

/* 3. Create a function that accepts as parameters – sum, yearly interest rate and number of months.
 It should calculate and return the new sum. Write a SELECT to test whether the function works as expected.*/
 
 CREATE FUNCTION ufn_caluculateInterestRate(@sum money=10, 
											@yearlyInterestRate real=2.0, 
											@numberOfMonths int =12)
RETURNS money
AS
BEGIN
	DECLARE @rate money=@yearlyInterestRate/12*@numberOfMonths
	RETURN @sum+@rate*@sum
END

SELECT dbo.ufn_caluculateInterestRate(100.00, 0.10, 4)

/* 4.Create a stored procedure that uses the function from the previous example to give an interest to a
 person's account for one month. It should take the AccountId and the interest rate as parameters. */

CREATE PROCEDURE usp_interestRateToAccount(@accountId int, @interestRate real)
AS
	UPDATE dbo.Acounts SET Balance=(SELECT dbo.ufn_caluculateInterestRate(Balance, @interestRate, 1))
	WHERE Id=@accountId
GO

EXEC usp_interestRateToAccount 2, 10

/* 5.Add two more stored procedures WithdrawMoney( AccountId, money) and DepositMoney (AccountId, money)
 that operate in transactions. */
 
CREATE PROCEDURE usp_depositMoney(@accountId int, @amount money)
AS
	BEGIN TRAN
	UPDATE Acounts SET Balance=Balance+@amount WHERE Id=@accountId
COMMIT TRAN

GO
CREATE PROCEDURE usp_drawMoney(@accountId int, @amount money)
AS
	BEGIN TRAN
	UPDATE Acounts SET Balance=Balance-@amount WHERE Id=@accountId
COMMIT TRAN

EXEC usp_depositMoney 2, 100
EXEC usp_drawMoney 2, 100

/*6. Create another table – Logs(LogID, AccountID, OldSum, NewSum). 
Add a trigger to the Accounts table that enters a new entry into the Logs table every time the
 sum on an account changes.
 */
CREATE TABLE Logs
(
	LogID int IDENTITY,
	AccountID int,
	OldSum money,
	NewSum money,
	PRIMARY KEY(LogID)
)
CREATE TRIGGER dbo.tr_UpdateAccountLog
ON Acounts AFTER UPDATE
AS
	DECLARE @accountId int, @oldSum money, @newSum money
	SELECT @accountId=d.Id, @oldSum=d.Balance FROM deleted d
	SELECT @newSum=i.Balance FROM inserted i
	INSERT INTO Logs(AccountId, OldSum, NewSum) VALUES (@accountId, @oldSum, @newSum)
GO

/* 7. 











