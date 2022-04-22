using System;

namespace Sess1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            Contact contact1;
            contact1.Name = "abc";
            contact1.Phone = "38292432";

            Contact contact2 = new Contact("pqr", "49020423");
            Console.WriteLine("{0} can be reached on {1}",
                contact2.Name,contact2.Phone);

            Contact contact3 = contact2;
            Console.WriteLine("{0} can be reached on {1}",
                 contact3.Name, contact3.Phone);
        }
    }
}
