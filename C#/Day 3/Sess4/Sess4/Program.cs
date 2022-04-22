using System;

namespace Sess4
{
    class Program
    {
        static void Main(string[] args)
        {
            IFlyer someFlyer = new Superman();
            someFlyer.TakeOff();
            someFlyer.Land();

            string name = "abc";
            Console.WriteLine(name is IFlyer);

            if(someFlyer is IFlyer)
            {
                Console.WriteLine("Can Fly");
            }
        }
    }
}
