using System;
using System.Collections.Generic;
using System.Text;

namespace Sess3
{
    class Manager
    {
        Employee emp = new Employee();
        public Manager()
        {
            emp.FirstHalf += Task1;
            emp.SecondHalf += Task2;

            emp.StartWork();
        }
        public void Task1()
        {
            Console.WriteLine("Task 1 for the day");
        }
        public void Task2()
        {
            Console.WriteLine("Task 2 for the day");
        }
    }
}
