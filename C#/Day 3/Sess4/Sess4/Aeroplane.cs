using System;
using System.Collections.Generic;
using System.Text;

namespace Sess4
{
    class Aeroplane : IFlyer
    {
        public void Land()
        {
            Console.WriteLine("Plane Landing");
        }

        public void TakeOff()
        {
            Console.WriteLine("Plane Taking Off");
        }
    }
}
