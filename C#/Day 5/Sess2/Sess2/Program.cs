using System;
using System.Collections.Generic;

namespace Sess2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add<string>("abc");
            //Add<int>(10);

            //ListDemo1();
            //ListDemo2();

            Dictionary<int, string> contacts = new Dictionary<int, string>();
            contacts.Add(1, "abc");
            contacts.Add(2, "pqr");
            contacts.Add(3, "xyz");

            foreach (var item in contacts)
            {
                Console.WriteLine("{0} : {1}",item.Key,item.Value);
            }

        }

        private static void ListDemo2()
        {
            //Initializer syntax
            List<int> numbers = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }

        private static void ListDemo1()
        {
            List<string> words = new List<string>();
            words.AddRange(new string[] { "abc", "pqr", "xyz", "jkl" });

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }

        //static void Add<T>(T a)
        //{
        //    Console.WriteLine(a);
        //}     
    }
}
