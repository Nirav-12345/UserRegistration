using System;

namespace uC2LASTNAME;

class Program
{

    public static void Main(string[] args)

    {
        string Lastname = Console.ReadLine();
        Last v = new Last();

        bool m = v.validateName(Lastname);

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

    
