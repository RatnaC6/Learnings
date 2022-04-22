using System;

namespace Sess2
{
    delegate void AddDelegate(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            AddDelegate a = Add;
            AddDelegate a1 = new AddDelegate(Add);
            //a(10, 20);
            ShowResult(a, 10, 20);

            AddDelegate b = Subtract;
            ShowResult(b, 20, 10);
        }

        static void ShowResult(AddDelegate del, int a, int b)
        {
            del(a, b);
        }

        static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void Add(int a,int b)
        {
            Console.WriteLine(a+b);
        }
    }
}
