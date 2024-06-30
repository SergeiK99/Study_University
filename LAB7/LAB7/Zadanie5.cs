using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LAB7
{
    public class Zadanie5
    {
        public int z5(string numberStr) // Вроде работает, но мне кжется много чего лишнего переделал
        {
            int sum = 0;
            for (int i = 0; i< numberStr.Length; i++)
            {
                if (numberStr[i] < '0' || numberStr[i] > '9')
                { throw new ArgumentException(); }
                sum += numberStr[i]-'0'; // -'0'  дает значение символа.
            }
            return sum;

            /*bool IsDigit = numberStr.Length == numberStr.Where(c => char.IsDigit(c)).Count();
            if (!IsDigit)
                throw new ArgumentException();
            long number = long.Parse(numberStr);
            long sum = 0;
            while (number > 0)
            {

                sum = sum + number % 10;
                number = number / 10;

            }
            return sum;*/
        }
    }
}
