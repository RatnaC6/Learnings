using System;

namespace Sess1
{
    namespace Internal
    {
        class Manufacturer
        {
            string name;

            public string Name
            {
                get
                {
                    return name;
                }
                //set
                //{
                //    if(value.Length > 2)
                //        name = value;
                //}
            }

            public Manufacturer()
            {
                Console.Write("Enter name of the manufacturer : ");
                name = Console.ReadLine();
            }

            public string GetDetails()
            {
                return name + " makes Televisions";                
            }
        }
    }
}
