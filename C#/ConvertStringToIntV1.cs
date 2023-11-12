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
            Convert.ToInt32(str, 2);
            return Convert.ToInt32(str, 10);
        }
        static void Main()
        {
            try
            {
                Console.WriteLine("Введите строку");
                string str = Console.ReadLine();
                Console.WriteLine(ConvertStringToInt(str));

            }catch (FormatException)
            {
                Console.WriteLine("Ошибка формата ввода. Введите только 0 и 1");
            }catch (OverflowException)
            {
                Console.WriteLine("Введенное число выходит за пределы диапазона int");
            }catch(Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
