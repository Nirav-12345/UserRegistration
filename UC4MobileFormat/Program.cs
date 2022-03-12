using System;

namespace UC4MobileFormat;

class Program
{
    public static void Main(string[] args)
    {

        string mobilenumber = Console.ReadLine();
        UC4 v = new UC4();

        bool m = v.validateMobile(mobilenumber);

        try
        {
            if (m == true)
            {
                Console.WriteLine("true");
            }

            
        }

        catch (AccessViolationException e)
        {
            Console.WriteLine(e.Message);
        }
    }

}
