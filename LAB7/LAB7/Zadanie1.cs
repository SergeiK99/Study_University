using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LAB7
{
    public class Zadanie1
    {
        public string z1(int n)
        {
            if (n <= 1 || n >= 26)
                throw new ArgumentException();
            char[] arr = Enumerable.Range(0, n).Select((x, i) => (char)('A' + i)).ToArray();
            return new string(arr);
        }
    }
}
