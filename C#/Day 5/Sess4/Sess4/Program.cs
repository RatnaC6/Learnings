using System;
using System.Threading;
using System.Collections.Concurrent;

namespace Sess4
{
    class Program
    {
        static ConcurrentBag<int> bag = new ConcurrentBag<int>();
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(StoreData);
            thread1.Start();
            Console.WriteLine("Started Storing Data");

            Thread thread2 = new Thread(ShowData);
            thread2.Start();
            Console.WriteLine("Started Showing Data");
        }

        static void StoreData()
        {
            for (int i = 0; i < 10; i++)
            {
                bag.Add(i + 1);
            }
        }

        static void ShowData()
        {
            foreach (var item in bag)
            {
                Console.WriteLine(item);
            }
        }
    }
}
