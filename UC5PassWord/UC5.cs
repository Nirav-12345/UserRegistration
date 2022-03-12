using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace UC5PassWord
{
    public class UC5
    {
        public static string s = "^[A-Za-z0-9]{8}$";
        public bool validateName(string name)
        {
            return Regex.IsMatch(name, s);
        }





    }
}
