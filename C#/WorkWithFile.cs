using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp3
{
    internal class Program
    {
        static void CreateFile(string file)
        {
            if(File.Exists(file))
            {
                Console.WriteLine($"Файл {file} уже создан");
            }
            else
            {
                using (StreamWriter sw = File.CreateText(file))
                {
                    Console.WriteLine($"Файл {file} успешно создан");
                }
            }
        }

        static void ReadFile(string file)
        {
            if (File.Exists(file))
            {
                using (StreamReader sr = File.OpenText(file))
                {
                    string content = sr.ReadToEnd();
                    Console.WriteLine($"Содержимое файла {file}:\n{content}");
                }
            }
            else
            {
                Console.WriteLine($"Файл {file} не существует");
            }
        }

        static void WriteToFile(string file)
        {
            if (File.Exists(file))
            {
                using (StreamWriter sw = File.AppendText(file))
                {
                    sw.WriteLine("Иванов Иван Иванович, 01.01.2001");
                    sw.WriteLine("1 2 3");
                    sw.WriteLine("4 5 6");
                    sw.WriteLine("7 8 9");
                    sw.WriteLine($"{DateTime.Now}");
                    Console.WriteLine("Информация успешно записана в файл.");
                }
            }
            else
            {
                Console.WriteLine($"Файл {file} не существует");
            }
        }
        static void ProcessFile(string file)
        {
            if (File.Exists(file))
            {
                using (StreamReader sr = File.OpenText(file))
                {
                    string personalInfo = sr.ReadLine();
                    string[] numbersRow1 = sr.ReadLine().Split();
                    string[] numbersRow2 = sr.ReadLine().Split();
                    string[] numbersRow3 = sr.ReadLine().Split();
                    string currentDateInfo = sr.ReadLine();

                    Console.WriteLine("Прочитанная информация из файла:");
                    Console.WriteLine($"Персональные данные: {personalInfo}");
                    Console.WriteLine($"Двумерный массив:");
                    Console.WriteLine(string.Join(" ", numbersRow1));
                    Console.WriteLine(string.Join(" ", numbersRow2));
                    Console.WriteLine(string.Join(" ", numbersRow3));
                    Console.WriteLine($"Текущая дата: {currentDateInfo}");
                }
            }
            else
            {
                Console.WriteLine($"Файл {file} не существует");
            }
        }

        static bool MainMenu(int number, string file)
        {
            switch(number)
            {
                 case 0:
                    CreateFile(file);
                    break;
                case 1:
                    ReadFile(file);
                    break;
                case 2:
                    WriteToFile(file); 
                    break;
                case 3:
                    ProcessFile(file);
                    break;
                case 4:
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Вы вышли из системы");
                    break;
            }
            if (number >= 0 && number <= 4) { return true; } else { return false; }
        }

        static void QuestionMenu(string file)
        {
            Console.WriteLine("\tМеню взаимодействия с файлом");
            Console.WriteLine("1. Создать файл");
            Console.WriteLine("2. Прочитать файл");
            Console.WriteLine("3. Записать в файл");
            Console.WriteLine("4. Преобразовать данные файла");
            Console.WriteLine("5. Очистить консоль");
            Console.WriteLine("6. Выход");

            int choose = Convert.ToInt32(Console.ReadLine());

            while (MainMenu(--choose, file)) { QuestionMenu(file); }
        }
        static void Main()
        {
            Console.WriteLine("Напишите имя файла с расширением. Пример: dz.txt");
            string file = Console.ReadLine();
            Console.Clear();
            try
            {
                QuestionMenu(file);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
