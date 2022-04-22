using System;
using System.Collections.Generic;
using System.Text;

namespace Sess4
{
    class Superman : IFlyer
    {
        public void Land()
        {
            Console.WriteLine("Superman Landing");
        }

        public void TakeOff()
        {
            Console.WriteLine("Superman Taking Off");
        }
    }
}
