using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USERINPUTUC1
{
    public class Class1
    {
        
            public static void Main(string[] args)
            {

            string name = Console.ReadLine();
                UC1 v = new UC1();

            bool m = v.validateName(name);

            try
            {
                if (m==true)
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
}
