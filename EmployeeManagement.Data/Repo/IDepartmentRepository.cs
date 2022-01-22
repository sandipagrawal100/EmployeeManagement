using EmployeeManagement.Business.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Data.Repo
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetDepartments();
        Department GetDepartment(int departmentId);
    }
}
