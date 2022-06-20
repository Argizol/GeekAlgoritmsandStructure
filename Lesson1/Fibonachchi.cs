using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Fibonachchi
    {
        public static int Fibonachi(int a)
        {
            if (a == 0)
            {
                return 0;
            }
            if (a == 1)
            {
                return 1;
            }
            int firstNum = 0;
            int secondNum = 1;
            int result = 0;
            for (int i = 0; i < a - 1; i++)
            {
                result = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = result;
            }
            return result;
        }

        public static int recFibonachi(int b)
        {
            if (b == 0)
            {
                return 0;
            }
            if (b == 1)
            {
                return 1;
            }

            return recFibonachi(b - 1) +
                   recFibonachi(b - 2);
        }
    }
}

