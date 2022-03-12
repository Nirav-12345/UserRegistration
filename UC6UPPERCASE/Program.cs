using System;

namespace UC6UPPERCASE;

class Program
{
    public static void Main(string[] args)
    {
        string name = Console.ReadLine();
        UC6 v = new UC6();
        bool m = v.validateName(name);
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

