using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LAB7
{
    public class Zadanie4
    {
        public bool z4(string input)
        {
            if (input == null)
                throw new ArgumentException();
            Regex r3 = new Regex(@"^[aA-zZ]+([_\-\.]\w+)*@[a-z]\.[a-zA-Z]{2}$");
            //Regex r3 = new Regex(@"^[\w_]+([_\-\.][\w_]+)*@([\w_]+\.)+[a-zA-Z]{2}$"); 
            if (r3.IsMatch(input))
                return true;
            else return false;
        }
    }
}
