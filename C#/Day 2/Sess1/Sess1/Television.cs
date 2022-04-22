using System;
using System.Collections.Generic;
using System.Text;

namespace Sess1
{
    class Television
    {
        string manufacturer, model;
        int sizeInInches;
        double price;

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
