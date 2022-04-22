using System;
using System.Collections.Generic;
using System.Text;

namespace Sess5
{
    class VoterApplicant
    {
        public int Age { get; set; }
        public string Country { get; set; }
        public string Name { get; set; }

        public void Input()
        {
            Console.Write("Name : ");
            Name = Console.ReadLine();

            Console.Write("Age : ");
            Age = int.Parse(Console.ReadLine());

            Console.Write("Country : ");
            Country = Console.ReadLine();
        }

        public void CheckApplication()
        {
            if(this.Name.Length <= 2)
            {
                throw new VoterApplicationException("Name must be at least 3 characters");
            }
            if(this.Country.ToLower() != "india")
            {
                throw new VoterApplicationException("Only Indians can register to vote");
            }
            if(this.Age < 18)
            {
                throw new VoterApplicationException("Voters must be at least 18 years old");
            }

            Console.WriteLine("All OK");
        }
    }
}
