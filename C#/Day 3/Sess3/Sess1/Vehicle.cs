using System;
using System.Collections.Generic;
using System.Text;

namespace Sess1
{
    abstract class Vehicle
    {
        public string BrandName { get; set; }
        public int Seats { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }

        public abstract void Start();

        public abstract void Stop();
    }
}
