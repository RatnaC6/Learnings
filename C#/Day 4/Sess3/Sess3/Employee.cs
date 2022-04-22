using System;
using System.Collections.Generic;
using System.Text;

namespace Sess3
{
    delegate void EmployeeTask();
    class Employee
    {
        public event EmployeeTask FirstHalf;
        public event EmployeeTask SecondHalf;
           

        public void StartWork()
        {
            if (FirstHalf != null) //If task1 is given, do it
            {
                FirstHalf();
            }
            if (SecondHalf != null) //If task2 is given, do it
            {
                SecondHalf();
            }
        }
    }
}
