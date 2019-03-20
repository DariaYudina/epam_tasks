using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    class Program
    {
        public static object BinnarySearch(int[] array, int SearchKey)
        {
            int min = 0;
            int max = array.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (SearchKey == array[mid])
                {
                    return mid;
                }
                else if (SearchKey < array[mid])
                {
                    max = mid - 1;
                }
                else
                    min = mid + 1;
            }
            return "Not Found";
        }

        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int key;
            Console.Write("Изначальный массив:\n");
            foreach (int i in numbers)
            {
                Console.Write(i+ " ");
            }
            Console.Write("\nВведите значение для поиска:");
            key = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Индекс искомого значения в массиве:");
            Console.Write(BinnarySearch(numbers, key));
            Console.ReadLine();
        }
    }
}
