using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int CountWords(string str)
        {
            int count = 1;
            foreach(var i in str)
            {
                if(i == ' ') count++;
            }

            return count;
        }
        static int WordsCount(string str)
        {
            string[] words = str.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);

            return words.Length;
        }

        static void Main()
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            Console.WriteLine($"Количество слов в предложении: {CountWords(str)}");
            Console.WriteLine($"Количество слов в предложении, используя метод: {WordsCount(str)}");
        }
    }
}
