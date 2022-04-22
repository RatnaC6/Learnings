using Sess1.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sess1
{
    class Television
    {
        string model;
        int sizeInInches;
        double price;
        Manufacturer manufacturer = null;
        //Manufacturer manufacturer = new Manufacturer();

        public Television()
        {
            manufacturer = new Manufacturer();
            //Console.WriteLine(manufacturer.GetDetails());
            //manufacturer.Name = "abc";
            Console.WriteLine(manufacturer.Name + " TV");
        }

        public void On()
        {
            Console.WriteLine("Television started");
        }
        internal void Off()
        {
            Console.WriteLine("Television off");
        }
    }
}
