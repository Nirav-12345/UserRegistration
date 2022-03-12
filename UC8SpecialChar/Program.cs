using System;

namespace UC8SpecialChar;

class Program
{
    public static void Main(string[] args)
    {
        string name = Console.ReadLine();
        UC8 v = new UC8();
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
