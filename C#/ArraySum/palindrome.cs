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
        static bool IsPalindrome(string str)
        {
            str = str.Replace(" ", "").ToLower();

            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if (str[left] != str[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }
        static void Main()
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            Console.WriteLine($"{IsPalindrome(str)}");
        }
    }
}
