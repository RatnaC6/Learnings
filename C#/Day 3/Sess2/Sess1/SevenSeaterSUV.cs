using System;
using System.Collections.Generic;
using System.Text;

namespace Sess1
{
    class SevenSeaterSUV : SUV
    {
        public SevenSeaterSUV()
        {
            Seats = 7;            
        }

        //Will not work as Stop() is sealed in the parent class SUV
        //public override void Stop()
        //{
        //    Console.WriteLine("7 seater SUV stopped");  
        //}
    }
}
