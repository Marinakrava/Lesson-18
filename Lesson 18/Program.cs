using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            Console.WriteLine(Check(str));
            Console.ReadKey();
        }
        static bool Check(string str)// метод
        {
            Stack <char> stack = new Stack<char>();
            Dictionary<char, char> sk = new Dictionary<char, char>// словарь заводим для хранения соответствия открытых и закрытых скобок
            {
                {'(',')'},
                {'{','}'},
                {'[',']'},
            };
            foreach (char c in str)// перебираем каждый символ в строке
            {
                if (c =='('|| c == '{' || c == '[')
                    stack.Push(sk[c]);// помещаем соответствующее значение из словаря по ключу
                if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0 || stack.Pop() != c)//проверяем не пустой ли стек или если извлеченный символ не соответствует тому, который должен там находится
                    { 
                    return false;   // значит мы прерываем этот метод и возвращаем false
                    }               
                }                  
            }
            if (stack.Count == 0)// проверяем пустой ли стек
                return true;
            else
                return false;
        }
    }
}
