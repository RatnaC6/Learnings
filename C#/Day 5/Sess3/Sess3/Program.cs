using System;
using System.Threading;

namespace Sess3
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(Work);
            thread.Start();
            //Console.WriteLine("Work started");
            ThreadPool.QueueUserWorkItem(ShowMessage, "Work started");

            Thread thread2 = new Thread(OtherWork);
            thread2.Start();
            //Console.WriteLine("Other Work started");
            ThreadPool.QueueUserWorkItem(ShowMessage, "Other Work started");

            ThreadPool.QueueUserWorkItem(ShowMessage, "Done");
        }

        static void ShowMessage (object message)
        {
            Console.WriteLine((string)message);
        }

        static void Work()
        {
            Console.WriteLine("Working through separate thread");
        }

        static void OtherWork()
        {
            for (int i = 0; i < 1000000; i++)
            {
                if(i % 100000 == 0)
                    Console.Write(i);
            }
        }
    }
}
