using System;

namespace Sess4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Car c = new Car();
                c.Go();
            }
            catch(NotImplementedException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("Program end");
            }
        }
    }
}
