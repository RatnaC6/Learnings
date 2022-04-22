using System;
using System.Collections.Generic;
using System.Text;

namespace Sess1
{
    class Sedan : Car
    {
        public override void Start()
        {
            Console.WriteLine("Sedan Started");
        }

        public override void Stop()
        {
            Console.WriteLine("Sedan Stopped");
        }       
    }
}
