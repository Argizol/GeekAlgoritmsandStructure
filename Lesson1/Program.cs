using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1.Task1Method();
            Console.WriteLine($"Число Фибоначчи равно {Fibonachchi.Fibonachi(Task1.getNumTask1())}");
            Console.WriteLine($"Число Фибоначчи равно {Fibonachchi.recFibonachi(Task1.getNumTask1())}");
            Console.ReadKey(true);
        }

    }
}
