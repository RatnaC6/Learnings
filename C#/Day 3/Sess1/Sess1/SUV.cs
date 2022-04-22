using System;
using System.Collections.Generic;
using System.Text;

namespace Sess1
{
    class SUV : Car
    {
        public new void Start()
        {
            Console.WriteLine("SUV Started");
        }

        public new void Stop()
        {
            Console.WriteLine("SUV Stopped");
        }
    }
}
