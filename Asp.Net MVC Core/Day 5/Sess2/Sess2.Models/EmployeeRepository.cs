using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Sess2.Models
{
    public class EmployeeRepository
    {
        CompanyDbContext context = new CompanyDbContext();
        public IEnumerable<Employee> GetAllEmployees()
        {
            return context.Employees.ToList();
        }

        public void AddEmployee(Employee employee)
        {
            context.Employees.Add(employee);
            //context.SaveChanges();
        }

        public void UpdateEmployee(Employee employee)
        {
            context.Entry<Employee>(employee).State = EntityState.Modified;
        }

        public void RemoveEmployee(Employee employee)
        {
            context.Employees.Remove(employee);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
