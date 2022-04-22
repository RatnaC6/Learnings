using System;
using Sess1.Internal;


namespace Sess1
{
    class Program
    {
        static void Main(string[] args)
        {
            Television television = new Television();
            television.On();
            television.Off();

            Internal.Manufacturer manufacturer1 = new Internal.Manufacturer();
            Manufacturer manufacturer2 = new Manufacturer();
        }
    }       
}
