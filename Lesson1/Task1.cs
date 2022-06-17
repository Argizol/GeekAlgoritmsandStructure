using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Task1
    {
       public static void Task1Method()
        {
            int n;
            int d = 0;
            int i = 2;

                n = getNumTask1();
            if (n == 0)
            {
                
                return;
            }
                if (i < 0)
                {
                    if (n % i == 0)
                    {
                        d++;
                    }
                    else
                    {
                        i++;
                    }
                }
                else if (d == 0)
                {
                    Console.WriteLine($"Число {n} простое");
                }
                else
                {
                    Console.WriteLine($"Число {n} не простое");
                }        
        }

        public static int getNumTask1()
        {
            Console.WriteLine($"Введите целое число");
            string number = Console.ReadLine();
            int n;
            try
            {
                if (int.TryParse(number, out int num))
                {
                    return n = num;
                }
                else
                {
                    throw new Exception("Вводить необходимо целое число");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }
            return 0;
        }        
    }
}
