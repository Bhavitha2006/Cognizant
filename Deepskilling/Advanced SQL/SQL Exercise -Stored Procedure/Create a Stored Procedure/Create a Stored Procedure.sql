CREATE DATABASE Employee;
USE Employee;
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
DELIMITER $$

CREATE PROCEDURE sp_GetEmployeesByDepartment(
    IN p_DepartmentID INT
)
BEGIN
    SELECT *
    FROM Employees
    WHERE DepartmentID = p_DepartmentID;
END $$

DELIMITER ;
CALL sp_GetEmployeesByDepartment(1);
DELIMITER $$

CREATE PROCEDURE sp_InsertEmployee(
    IN p_FirstName VARCHAR(50),
    IN p_LastName VARCHAR(50),
    IN p_DepartmentID INT,
    IN p_Salary DECIMAL(10,2),
    IN p_JoinDate DATE
)
BEGIN
    INSERT INTO Employees
    (FirstName, LastName, DepartmentID, Salary, JoinDate)
    VALUES
    (p_FirstName, p_LastName, p_DepartmentID, p_Salary, p_JoinDate);
END $$

DELIMITER ;
CALL sp_InsertEmployee(
    'Michael',
    'Scott',
    2,
    70000,
    '2024-06-15'
);
SELECT * FROM Employees;