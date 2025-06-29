-- Create the Scalar Function
DELIMITER $$

CREATE FUNCTION fn_CalculateAnnualSalary(empID INT)
RETURNS DECIMAL(10,2)
DETERMINISTIC
BEGIN
    DECLARE annualSalary DECIMAL(10,2);

    SELECT Salary * 12 INTO annualSalary
    FROM Employees
    WHERE EmployeeID = empID;

    RETURN annualSalary;
END$$

DELIMITER ;

-- Execute the Function for EmployeeID = 1
SELECT fn_CalculateAnnualSalary(1) AS AnnualSalary;

-- Verify
SELECT Salary, Salary * 12 AS AnnualSalary
FROM Employees
WHERE EmployeeID = 1;