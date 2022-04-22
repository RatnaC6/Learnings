using System;
using System.Collections.Generic;
using System.Text;

namespace Sess1
{
    class SUV : Car
    {
        public sealed override void Start()
        { //Cannot further override in the child class of SUV
            Console.WriteLine("SUV Started");
        }

        public sealed override void Stop()
        { //Cannot further override in the child class of SUV
            Console.WriteLine("SUV Stopped");
        }
    }
}
