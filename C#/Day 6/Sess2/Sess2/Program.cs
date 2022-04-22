using System;
using System.Collections.Generic;
using System.Linq;

namespace Sess2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee
                {
                    Name = "abc", Location = "Mumbai"
                },
                new Employee
                {
                    Name = "pqr", Location = "Delhi"
                },
                new Employee
                {
                    Name = "xyz", Location = "Mumbai"
                },
                new Employee
                {
                    Name = "mno", Location = "Bangalore"
                },
            };

            var allEmployeeNames = from emp in employees
                                   select emp.Name;

            employees.Add(new Employee { Name = "ghi", Location = "Pune" });

            foreach (var name in allEmployeeNames)
            {
                Console.WriteLine(name);
            }

            var mumbaiEmployees = employees.Where(emp => emp.Location == "Mumbai").ToList();
            employees.Add(new Employee { Name = "lmn", Location = "Mumbai" });

            foreach (var item in mumbaiEmployees)
            {
                Console.WriteLine(item.Name);
            }

        }
    }
}
