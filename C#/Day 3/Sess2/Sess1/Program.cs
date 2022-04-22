using System;

namespace Sess1
{
    //Will not work - String is a sealed class
    //class SpecialString : String
    //{

    //}

    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter type of car : ");
            //string carType = Console.ReadLine();
            //Car someCar = null;

            //switch (carType.ToLower())
            //{
            //    case "sedan":
            //        someCar = new Sedan();
            //        someCar.Seats = 5;
            //        break;
            //    case "suv":
            //        someCar = new SUV();
            //        someCar.Seats = 7;
            //        break;
            //    default:
            //        Console.WriteLine("Please choose SUV or Sedan");
            //        break;
            //}

            //Console.WriteLine("{0} seater car",someCar.Seats);
            //someCar.Start();
            //someCar.Stop();

            //Sedan hondaCityPetrolAutomatic = new Sedan();
            //hondaCityPetrolAutomatic.Length = 4.4;
            //hondaCityPetrolAutomatic.Width = 2.2;
            //hondaCityPetrolAutomatic.FuelType = FuelType.Petrol;
            //hondaCityPetrolAutomatic.BrandName = "Honda";

            //hondaCityPetrolAutomatic.Start();
            //hondaCityPetrolAutomatic.Stop();

            SUV suv = new SevenSeaterSUV();
            Console.WriteLine("{0} seats available",suv.Seats);
            suv.Start();
            suv.Stop();
        }
    }
}
