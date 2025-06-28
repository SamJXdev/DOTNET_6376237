DELIMITER $$

CREATE PROCEDURE sp_GetDeptEmployeeCount (
    IN p_DepartmentID INT
)
BEGIN
    SELECT 
        d.DepartmentID,
        d.DepartmentName,
        COUNT(e.EmployeeID) AS TotalEmployees
    FROM Departments d
    LEFT JOIN Employees e ON d.DepartmentID = e.DepartmentID
    WHERE d.DepartmentID = p_DepartmentID
    GROUP BY d.DepartmentID, d.DepartmentName;
END $$

DELIMITER ;
