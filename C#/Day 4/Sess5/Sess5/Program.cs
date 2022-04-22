using System;

namespace Sess5
{
    class Program
    {
        static void Main(string[] args)
        {
            VoterApplicant applicant = new VoterApplicant();
            try
            {               
                applicant.Input();
                applicant.CheckApplication();

            }catch(VoterApplicationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Done");
                Console.WriteLine("{0} - thanks for your application",
                    applicant.Name);
            }
        }
    }
}
