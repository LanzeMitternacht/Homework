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
            int[] arrayfirst = { 1, 2, 3, 5, 7, 8 };
            int[] arraysecond = { 3, 5, 0, 9, 1, 2 };
            int[] result = arrayfirst.Intersect(arraysecond).ToArray();
            foreach (int i in result)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();    
        }
    }
}
