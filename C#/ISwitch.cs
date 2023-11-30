using System;
using System.CodeDom;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Program
    {
        public interface ISwitch
        {
            void SwithOn();
            void SwithOff();
        }

        public abstract class HouseholdTechnology : ISwitch
        {
            public void SwithOn()
            {
                Console.WriteLine("Включено");
            }

            public void SwithOff()
            {
                Console.WriteLine("Выключено");
            }

            public abstract void Use();
        }

        public abstract class Gadgets : ISwitch
        {
            public void SwithOn()
            {
                Console.WriteLine("Включено");
            }

            public void SwithOff()
            {
                Console.WriteLine("Выключено");
            }
            public abstract void Use();
        }

        class Fridge : HouseholdTechnology
        {
            bool On = false;
            public override void Use()
            {
                if (!On)
                {
                    On = true;
                    SwithOn();
                }
                else
                {
                    On = false;
                    SwithOff();
                }
            }
        }

        class TV : Gadgets
        {
            bool On = false;
            public override void Use()
            {
                if (!On)
                {
                    On = true;
                    SwithOn();
                }
                else
                {
                    On = false;
                    SwithOff();
                }
            }
        }

        static void Main()
        {
            TV tV = new TV();
            Fridge fV = new Fridge();   
            tV.Use();
            fV.Use();
            Console.WriteLine("__________");
            tV.Use();
            fV.Use();
        }
    }
}
