using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_arr
{
    class Program
    {

        static void sort(int[] x) {
            int tmp = 0, i=1, j;
            for (i = 1; i < x.Length; i++)
            {
                Console.WriteLine("Итерация:" + i);
                for (j = i; j > 0 && x[j - 1] > x[j]; j--)
                {
                    tmp = x[j - 1];
                    x[j - 1] = x[j];
                    x[j] = tmp;
                }
                for (int a = 0; a < x.Length; a++)
                {                   
                    Console.Write(x[a]+ " ");
                }
                Console.Write("\n");
            }
        }
        

        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random r = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = r.Next(0, 30);
            }

            Console.Write("Изначальный массив случайных чисел:\n");
            foreach (int i in numbers)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine("\n");
            sort(numbers);

            Console.Write("\nОтсортированный массив:\n");
            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
