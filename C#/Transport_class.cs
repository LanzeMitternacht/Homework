using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        class Transport
        {
            double Speed { get; set; }
            string Model { get; set; }
            string Color { get; set; }


            internal Transport(double speed, string model, string color)
            {
                Speed = speed;
                Model = model;
                Color = color;
            }

            public virtual string GetInfo() 
            {
                return ($"модель {Model}, цвет {Color}, скорость {Speed}");
            }

        }

        class Airplane : Transport
        {
            string Name { get; set; }
            public Airplane(string name, double speed, string model, string color): base(speed, model, color)
            {
                Name = name;
            }

            public override string GetInfo()
            {
                return $"{Name}, " + base.GetInfo();
            }
        }

        class Cart : Transport
        {
            string Material { get; set; }
            public Cart(double speed, string material, string color): base(speed, model:("-"), color)
            {
                Material = material;
    
            }
            public override string GetInfo()
            {
                return $"{Material}, "+base.GetInfo();
            }
        }

        class Car : Transport
        {
            string Name { get; set; }
            public Car(string name, double speed, string model, string color): base(speed, model, color)
            {
                Name = name;
            }
            public override string GetInfo()
            {
                return $"{Name}, " + base.GetInfo();
            }
        }

        static void Main()
        {
            List < Transport > transports = new List<Transport>
            {
                new Car("Lada", 65.3, "Granta", "Blue"),
                new Airplane("AC-130", 120.3, "Army Airplane", "Grey"),
                new Cart(12.2, "Wood", "Black")
            };

            foreach (Transport transport in transports)
            {
                Console.WriteLine(transport.GetInfo());
            }
        }
    }
}
