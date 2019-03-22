using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    class Program
    {
        static string Counter(string str)
        {
            int count = 0;
            string[] words = str.Split(new char[] { ' ', '\n', ',', '.', ';' }, StringSplitOptions.RemoveEmptyEntries);
            string res = "";
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (words[i] == words[j])
                    {
                        count++;
                    }                  
                }
                if (count == 1)
                {
                    res += words[i]+ " ";
                    count = 0;
                }
            }
            if (res == "") { return res = "Not foind";}
            return res;
        }
            static void Main(string[] args)
            {
            /* string str = "uniq1.uniq2,uniq3 строка строка текст текст, test. test1 test1  текст test2";
             Console.WriteLine(Counter(str));

             string str2 = Console.ReadLine();
             Console.WriteLine(Counter(str2));

            */
            string str = "uniq1.uniq2,uniq3 строка строка текст текст, test. test1 test1 текст test2";
            string str2 = "";
            Console.WriteLine("Введите новое значение строки или воспользуйтесь исходным\nИсходное значение строки:\n"+ str+"\n");
            str2 = Console.ReadLine();

            if(str2 == "") { Console.WriteLine("\nУникальные значения выбранной строки:\n"+ Counter(str)); }         
                else { Console.WriteLine("\nУникальные значения выбранной строки:\n" + Counter(str2)); }

            Console.ReadKey();
        }
        
    }
}
