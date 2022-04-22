using System;
using System.Collections.Generic;
using System.Text;

namespace Sess1
{
    class Car
    {
        //Auto Implemented Property
        public int Seats { get; set; }
        public string BrandName { get; set; }
        public FuelType FuelType { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }

        public int BootSize { get; set; }

        public virtual void Start()
        { //Can override in the child class
            Console.WriteLine("Car Started");
        }

        public virtual void Stop()
        { //Can override in the child class
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
