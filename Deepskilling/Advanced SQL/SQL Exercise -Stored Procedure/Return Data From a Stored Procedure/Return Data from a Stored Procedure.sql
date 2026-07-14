CREATE DATABASE Department;
USE Department;
DELIMITER $$

CREATE PROCEDURE sp_CountEmployeesByDepartment(
    IN p_DepartmentID INT
)
BEGIN
    SELECT COUNT(*) AS TotalEmployees
    FROM Employees
    WHERE DepartmentID = p_DepartmentID;
END $$

DELIMITER ;
CALL sp_CountEmployeesByDepartment(1);

SELECT DATABASE();
SHOW TABLES;
CREATE TABLE Employees (
    EmployeeID INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT,
    Salary DECIMAL(10,2),
    JoinDate DATE
);
INSERT INTO Employees
(FirstName, LastName, DepartmentID, Salary, JoinDate)
VALUES
('John','Smith',1,50000,'2022-01-10'),
('Alice','Johnson',2,60000,'2021-05-15'),
('David','Brown',1,55000,'2023-02-20'),
('Emma','Wilson',3,65000,'2020-08-25');
DELIMITER $$
SELECT DATABASE();
SHOW TABLES;
CALL sp_CountEmployeesByDepartment(1);
CALL sp_CountEmployeesByDepartment(2);
CALL sp_CountEmployeesByDepartment(3);
SELECT * FROM Employees;
