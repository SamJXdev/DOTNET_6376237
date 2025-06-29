DELIMITER $$

CREATE PROCEDURE sp_GetEmployeesByDepartment (
    IN p_DepartmentID INT
)
BEGIN
    SELECT 
        e.EmployeeID,
        e.FirstName,
        e.LastName,
        d.DepartmentName,
        e.Salary,
        e.JoinDate
    FROM Employees e
    INNER JOIN Departments d ON e.DepartmentID = d.DepartmentID
    WHERE e.DepartmentID = p_DepartmentID;
END $$

DELIMITER ;
CALL sp_GetEmployeesByDepartment(2);
