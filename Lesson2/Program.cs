using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            for (int i = 0; i < 10; i++)
            {
                linkedList.Add(i);
            }
            foreach (var item in linkedList.FrontEnumerator())
            {
                Console.WriteLine(item);
            }
            linkedList.Remove(5);
            Console.WriteLine();
            foreach (var item in linkedList.FrontEnumerator())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            linkedList.AddFirst(15);
            linkedList.AddNodeAfter(3, 500);
            linkedList.Add(999);
            linkedList.RemoveNodeByIndex(1);
            foreach (var item in linkedList.FrontEnumerator())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine($"Ищем содерждимое равное 15: {linkedList.FindNode(15).Next.Data}"); //для проверки выводим содержимое следующей ноды
            Console.WriteLine(linkedList.Contains(12).ToString());

            int[] arr = {1, 14, 22, 13, 41, 64};
            Array.Sort(arr);
            Console.WriteLine($"Индекс искомого элемента в массиве {BinarySearch.MyBinarySearch(arr, 70)}");

            Console.ReadKey(true);
        }
    }
}
