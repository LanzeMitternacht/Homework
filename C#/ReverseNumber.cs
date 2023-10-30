using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int NumberRead()
        {
            Console.WriteLine("Введите целое положительное число");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0) throw new Exception("Введено отрицательное число");

          return number;
        }

        static int ReverseNumber(int num)
        {
            int result = 0;
            while (num != 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
            }
            return result;
        }

        static void Main()
        {
            try
            {
                int A = NumberRead();
                Console.WriteLine(ReverseNumber(A));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
