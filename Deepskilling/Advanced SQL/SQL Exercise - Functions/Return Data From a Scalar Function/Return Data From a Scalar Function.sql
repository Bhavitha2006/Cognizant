CREATE DATABASE EmployeeDB;
USE EmployeeDB;
CREATE TABLE Employees (
    EmployeeID INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT,
    Salary DECIMAL(10,2),
    JoinDate DATE
);
INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate)
VALUES
('John','Smith',1,50000,'2022-01-10'),
('Alice','Johnson',2,60000,'2021-05-15'),
('David','Brown',1,55000,'2023-02-20'),
('Emma','Wilson',3,65000,'2020-08-25');
SELECT * FROM Employees;
DELIMITER $$

CREATE FUNCTION fn_CalculateAnnualSalary(p_EmployeeID INT)
RETURNS DECIMAL(10,2)
DETERMINISTIC
BEGIN
    DECLARE AnnualSalary DECIMAL(10,2);

    SELECT Salary * 12
    INTO AnnualSalary
    FROM Employees
    WHERE EmployeeID = p_EmployeeID;

    RETURN AnnualSalary;
END $$

DELIMITER ;
SELECT fn_CalculateAnnualSalary(1) AS AnnualSalary;