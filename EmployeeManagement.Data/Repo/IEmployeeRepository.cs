﻿using EmployeeManagement.Business.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Data.Repo
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int employeeId);

        //Task<Employee> AddEmployee(Employee employee);
        //Task<Employee> UpdateEmployee(Employee employee);
        //void DeleteEmployee(int employeeId);
    }
}
