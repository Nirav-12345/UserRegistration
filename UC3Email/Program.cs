using System;

namespace UC3Email;

class Program
{
    public static void Main(string[] args)
    {

        string Email = Console.ReadLine();
        UC3 email = new UC3();

        bool m = email.validateEmail(Email);

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
