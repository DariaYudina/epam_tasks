using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static long Fact(int n)
        {
            long res = 1;
            for (int i = 1; i <= n; i++)
                res *= i;
            return res;
        }

        static void Main(string[] args)
        {
            string ex = "yes";
            while (ex == "yes")
            {
                Console.WriteLine("Введите N:");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Факториал {0} =  {1}", n, Fact(n));
                Console.WriteLine("Повторить?:(yes/no)", n, Fact(n));
                ex = Console.ReadLine();

            }
        }

    }
}
