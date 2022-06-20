using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class BinarySearch
    {
        // Суммарная сложность O(logn)
        public static int MyBinarySearch(int[] inputArray, int searchValue)
        {
            int min = 0; 
            int max = inputArray.Length - 1; 
            while (min <= max)
            {
                int mid = (min + max) / 2; //O(log_2(n)) каждая итерация отбрасывает половину элементов для сравнения
                if (searchValue == inputArray[mid])
                {
                    return mid;
                }
                else if (searchValue < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }

    }
}
