using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CheckParenthesis
{
    public class Program
    {
        public static bool ComplexBracketsBalance(string input)
        {
            Stack<char> symbolStack = new Stack<char>();
            foreach (char symbol in input)
            {
                if (symbol == '{' || symbol == '(' || symbol == '[')
                {
                    symbolStack.Push(symbol);
                }
                if (symbol == '}' || symbol == ')' || symbol == ']')
                {
                    if (symbolStack.Count > 0)
                    {
                        char lastSymbol = symbolStack.Peek(); 
                        if (symbol == '}' && lastSymbol == '{' || symbol == ')' && lastSymbol == '(' || symbol == ']' && lastSymbol == '[')
                        {
                            symbolStack.Pop();
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return symbolStack.Count == 0;
        }

        public static void Main()
        {
            /*тестовые значения
            Console.WriteLine(ComplexBracketsBalance("({(){}()})()"));  // true
            Console.WriteLine(ComplexBracketsBalance("({(}){})"));      // false
            Console.WriteLine(ComplexBracketsBalance(""));              // true
            Console.WriteLine(ComplexBracketsBalance("test"));          // true
            Console.WriteLine(ComplexBracketsBalance("[]()"));          // true
            */
            string str = "";
            Console.WriteLine("Введите скобочную последовательность\n");
            str = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(ComplexBracketsBalance(str));
            Console.ReadLine();
        }
    }
}
