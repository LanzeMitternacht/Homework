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
        static void Main()
        {
            int[,] array = new int[5, 5];

            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = random.Next(-100, 101); 
                }
            }

            int minelm = array[0, 0];
            int maxelm = array[0, 0];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (array[i, j] < minelm)
                    {
                        minelm = array[i, j];
                    }
                    else if (array[i, j] > maxelm)
                    {
                        maxelm = array[i, j];
                    }
                }
            }

            int result = 0;
            bool MinMax = false;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (array[i, j] == minelm)
                    {
                        MinMax = !MinMax; 
                    }
                    else if (array[i, j] == maxelm)
                    {
                        MinMax = !MinMax;
                    }
                    else if (MinMax)
                    {
                        result += array[i, j];
                    }     
                }
            }


            Console.WriteLine("Двумерный массив:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Минимальный элемент: " + minelm);
            Console.WriteLine("Максимальный элемент: " + maxelm);
            Console.WriteLine("Сумма элементов между минимальным и максимальным элементами: " + result);
        }
    }
}
