using System;
using System.Threading.Tasks;

namespace TaskDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t1 = new Task(() => Console.WriteLine("Hello"));

            Task<string> t2 = new Task<string>(GetMessage);

            t1.Start();
            t2.Start();
            TaskRun();

            Console.ReadLine();           

            if (t2.IsCompleted)
            {
                var msg = t2.Result;
                Console.WriteLine(msg);
            }
        }

        private static async void TaskRun()
        {
            await Task.Run(() =>
            {
                int x = 90;
                for (int i = 0; i < 10000; i += x)
                {                   
                    Console.WriteLine(i);
                }
            });
        }

        static string GetMessage()
        {
            return "Hi from Viren";
        }
    }
}
