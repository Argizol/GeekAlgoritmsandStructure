using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Task2
    {
        //Вычислите асимптотическую сложность функции из примера ниже.
        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0; //O(1)
            for (int i = 0; i < inputArray.Length; i++) //O(n)
            {
                for (int j = 0; j < inputArray.Length; j++) //O(n)
                {
                    for (int k = 0; k < inputArray.Length; k++) //O(n)
                    {
                        int y = 0; //O(1)
                        if (j != 0) //O(1)
                        {
                            y = k / j; //O(1)
                        }
                        sum += inputArray[i] + i + k + j + y; //O(1)
                    }
                }
            }
            return sum; //O(1)
        }
        //Сложность функции O(n³)
    }
}
        

