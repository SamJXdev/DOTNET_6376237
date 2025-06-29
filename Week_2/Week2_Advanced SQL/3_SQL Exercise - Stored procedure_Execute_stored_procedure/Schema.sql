-- 1. Create Schema
CREATE DATABASE IF NOT EXISTS employee_system;

-- 2. Use Schema
USE employee_system;

-- 3. Create Departments Table
CREATE TABLE IF NOT EXISTS Departments (
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);

-- 4. Create Employees Table
CREATE TABLE IF NOT EXISTS Employees (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT,
    Salary DECIMAL(10,2),
    JoinDate DATE,
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);

-- 5. Insert Department Data
INSERT INTO Departments (DepartmentID, DepartmentName) VALUES
(1, 'HR'),
(2, 'Finance'),
(3, 'Engineering'),
(4, 'Marketing');

-- 6. Insert Employee Data
INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate) VALUES
(1, 'John', 'Doe', 1, 5000.00, '2020-01-15'),
(2, 'Jane', 'Smith', 2, 6000.00, '2019-03-22'),
(3, 'Michael', 'Johnson', 3, 7000.00, '2018-07-30'),
(4, 'Emily', 'Davis', 4, 5500.00, '2021-11-05'),
(5, 'Sara', 'Miller', 2, 6400.00, '2024-03-12'),
(6, 'Abinaya', 'Ravi', 3, 6700.00, '2023-06-20'),
(7, 'Arjun', 'Kumar', 2, 6100.00, '2024-01-10'),
(8, 'Nisha', 'Rao', 1, 5300.00, '2023-12-05'),
(9, 'Rahul', 'Singh', 3, 7500.00, '2024-02-20'),
(10, 'Meena', 'Verma', 4, 5000.00, '2022-10-15'),
(11, 'Ravi', 'Iyer', 1, 5200.00, '2023-03-15'),
(12, 'Sneha', 'Kapoor', 2, 6100.00, '2022-11-20'),
(13, 'Amit', 'Sharma', 3, 7200.00, '2021-06-10'),
(14, 'Priya', 'Mehta', 4, 5900.00, '2020-09-01'),
(15, 'Deepak', 'Patel', 1, 5400.00, '2022-04-18'),
(16, 'Kiran', 'Nair', 2, 6800.00, '2023-07-25'),
(17, 'Sonal', 'Joshi', 3, 7500.00, '2021-01-05'),
(18, 'Naveen', 'Reddy', 4, 5600.00, '2020-12-30'),
(19, 'Pooja', 'Bhatt', 2, 6300.00, '2024-03-12'),
(20, 'Tarun', 'Malik', 1, 5100.00, '2023-02-14');
