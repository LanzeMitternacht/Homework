using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ConsoleApp3
{
    class Program
    {
        [Serializable]
        public class PC
        {
            private string Processor;
            private string GraphicsCard;
            private string Motherboard;
            private string PowerSupply;
            private string RAM;

            public PC(string processor, string graphicsCard, string motherboard, string powerSupply, string ram)
            {
                Processor = processor;
                GraphicsCard = graphicsCard;
                Motherboard = motherboard;
                PowerSupply = powerSupply;
                RAM = ram;
            }

            public void ShowInfo()
            {
                Console.WriteLine("\tКомпоненты компьютера:");
                Console.WriteLine($" Процессор: {Processor}");
                Console.WriteLine($" Видеокарта: {GraphicsCard}");
                Console.WriteLine($" Материнская плата: {Motherboard}");
                Console.WriteLine($" Блок питания: {PowerSupply}");
                Console.WriteLine($" Оперативаня памать: {RAM}");
            }
        }
        public static void Main() { 
            List<PC> list = new List<PC> {
                new PC("Ryzen 5 3600X", "GeForce 2060 Super", "B250X", "750W Bronze", "16GB"),
                new PC("Ryzen Threadripper PRO 7995WX", "GeForce RTX 4090", "ASUS PRIME X570-P.", "950W Gold", "32GB"),
                new PC("Xeon w9-3495X", "GeForce RTX 3070", "MSI MEG Z690 UNIFY", "800W Gold", "64GB"),
                new PC("Intel Xeon Gold 5420", "TITAN V CEO Edition", "ASRock X299 STEEL LEGEND", "990W Platinum", "124GB"),
                new PC("AMD EPYC 9254", "AMD Radeon RX 580", "ASUS PRIME Z390-A", "1000W Platinum", "255GB"),
            };
            string path = "PC.dat";
            try
            {
                using (BinaryWriter bw = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
                {
                    foreach (PC pc in list)
                    {
                        bw.Write(pc.ToString());
                    }
                }
                using (BinaryReader br = new BinaryReader(File.OpenRead(path)))
                {
                    foreach (PC pc in list)
                    {  
                        pc.ShowInfo();
                        Console.WriteLine();
                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
