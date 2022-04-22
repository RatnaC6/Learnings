using System;
using System.Collections.Generic;
using System.Text;

namespace Sess1
{
    class Car : Vehicle
    {               
        public FuelType FuelType { get; set; }
     
        public int BootSize { get; set; }

        public override void Start()
        { 
            Console.WriteLine("Car Started");
        }

        public override void Stop()
        { 
            Console.WriteLine("Car Stopped");
        }
    }

    enum FuelType
    {
        Diesel = 1,
        Petrol = 2,
        CNG = 3,
        Electric = 4,
        LPG = 5
    }
}
