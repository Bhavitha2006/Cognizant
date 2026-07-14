CREATE DATABASE Department1;
USE Department1;
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
SHOW TABLES;
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
CALL sp_GetEmployeesByDepartment(1);
CALL sp_GetEmployeesByDepartment(2);
CALL sp_GetEmployeesByDepartment(3);