using System;

namespace UC5PassWord;

class Program
{
    public static void Main(string[] args)
    {


        string name = Console.ReadLine();

        UC5 v = new UC5();
        bool m = v.validateName(name);

        try
        {
            if (m == true)
            {
                Console.WriteLine("true");
            }
        }

        catch (ApplicationException e)
        {
            Console.WriteLine(e.Message);
        }
    }



}

