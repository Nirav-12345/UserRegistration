using System;

namespace UC7Numeric;

class Program
{
    public static void Main(string[] args)
    {
        string name = Console.ReadLine();
        UC7 v = new UC7();
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
