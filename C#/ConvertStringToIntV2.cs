using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static int ConvertStringToInt(string str)
        {
            return Convert.ToInt32(str, 10);
        }
        static void Main()
        {
            try
            {
                Console.WriteLine("Введите строку");
                string str = Console.ReadLine();
                Console.WriteLine(ConvertStringToInt(str));

            }
            catch (OverflowException)
            {
                Console.WriteLine("Введенное число выходит за пределы диапазона int");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
