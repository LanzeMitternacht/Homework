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
        class FruitCollection
        {
            Dictionary<string, int> Fruits = new Dictionary<string, int>();


            void AddFruit(string nameFruit, string price)
            {
                if (!Fruits.ContainsKey(nameFruit))
                {
                    Fruits.Add(nameFruit, Convert.ToInt32(price));
                    Console.WriteLine($"Фрукт {nameFruit} добавлен\n");
                }
                else
                {
                    Console.WriteLine($"Возникла ошибка при добавление фрукта. Фрукт {nameFruit} уже есть в коллецкии\n");
                }
            }
            void DeleteFruit(string nameFruit)
            {
                if (Fruits.ContainsKey(nameFruit))
                {
                    Fruits.Remove(nameFruit);
                    Console.WriteLine($"Фрукт {nameFruit} удален\n");
                }
                else
                {
                    Console.WriteLine($"Возникла ошибка при удаление фрукта. Фрукт {nameFruit} нет в коллекции\n");
                }
            }
            void ShowFruits()
            {
                Console.WriteLine("\t Фрукт\t Цена");
                Console.WriteLine("----------------------------------------");
                foreach (var fruit in Fruits)
                {
                    Console.WriteLine($"\t{fruit.Key}\t| {fruit.Value}");
                }
                Console.WriteLine("----------------------------------------\n");
            }
            public bool MenuFruit()
            {
                Console.WriteLine("\tМеню фруктов:\n 1. Добавить фрукт\n 2. Вывести всю коллекцию фруктов\n 3. Удалить фрукт\n 4. Очистить консоль\n 5. Выход");
                Console.Write("Ожидается выбор действия из списка, предоставленного выше: ");
                string str = Console.ReadLine();
                int number = Convert.ToInt32(str);
                
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Введите название фрукта, а затем цену фрукта");
                        AddFruit(Console.ReadLine(), Console.ReadLine());
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\tВся коллекция фруктов:");
                        ShowFruits();
                        break;
                    case 3:
                        Console.WriteLine("Введите название удаляемого фрукта");
                        DeleteFruit(Console.ReadLine());
                        break;
                    case 4:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Выход из системы");
                        return false;
                }
                return true;
            }
        }

        static void Main()
        {
            try
            {
                FruitCollection fruit = new FruitCollection();
                while (fruit.MenuFruit()) { }
            }catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
