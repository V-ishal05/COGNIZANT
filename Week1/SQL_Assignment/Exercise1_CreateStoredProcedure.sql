USE CognizantDB;
GO

CREATE PROCEDURE sp_InsertEmployee
    @EmployeeID INT,
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @DepartmentID INT,
    @Salary DECIMAL(10,2),
    @JoinDate DATE
AS
BEGIN
    INSERT INTO Employees
    (
        EmployeeID,
        FirstName,
        LastName,
        DepartmentID,
        Salary,
        JoinDate
    )
    VALUES
    (
        @EmployeeID,
        @FirstName,
        @LastName,
        @DepartmentID,
        @Salary,
        @JoinDate
    );
END;
GO

USE CognizantDB;
GO

EXEC sp_InsertEmployee
    @EmployeeID = 7,
    @FirstName = 'Alice',
    @LastName = 'Thomas',
    @DepartmentID = 1,
    @Salary = 7200,
    @JoinDate = '2024-05-15';
GO

SELECT * FROM Employees;