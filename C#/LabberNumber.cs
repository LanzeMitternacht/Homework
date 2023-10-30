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
        static void LadderNumber(int A, int B)
        {
            while (A <= B)
            {
                for (int i = 0; i < A; i++)
                {
                    Console.Write(A+" ");
                }
                Console.WriteLine();
                ++A;
            }
        }

        static void Main()
        {
            try
            {
                int A = NumberRead();
                int B = NumberRead();
                Console.WriteLine();
                LadderNumber(A, B);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
