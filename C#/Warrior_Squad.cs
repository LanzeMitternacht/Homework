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
        interface IAttaker
        {
            void Attack();
        }
        interface IDamage
        {
            void TakeDamage();
        }

        class Warrior
        {
           public int damage;
            public void TakeDamage(Warrior war)
            {
                Console.WriteLine($"{this.GetType().Name} получает урон в размере {war.damage}");
            }
            public void TakeDamage(Squad sqd)
            {
                Console.WriteLine($"{this.GetType().Name} получает урон в размере {sqd.GetDamage()}");
            }
            public void Attack<T>(T atk) where T : class
           {
                Console.WriteLine($"{this.GetType().Name} атакует {atk.GetType().Name}");
           }
            public Warrior(int damage) 
            {
                this.damage = damage;
            }
        }
        class Squad
        {
            private Warrior[] warriors;
            public Squad(Warrior[] warrior)
            {
                warriors = new Warrior[warrior.Length];
                for(int i = 0; i < warrior.Length; i++)
                {
                    warriors[i] = new Warrior(warrior[i].damage);
                }
            }

            public int GetDamage()
            {
                int damage = 0;
                for(int i = 0 ; i < warriors.Length ; i++)
                {
                    damage += warriors[i].damage;
                }
                return damage;
            }
            public void Attack<T>(T atk) where T : class
            {
                Console.WriteLine($"{this.GetType().Name} атакует {atk.GetType().Name}");
            }
            public void TakeDamage(Warrior war) {
                Console.WriteLine($"{this.GetType().Name} получает урон в размере {war.damage}");
            }
            public void TakeDamage(Squad sqd)
            {
                Console.WriteLine($"{this.GetType().Name} получает урон в размере {sqd.GetDamage()}");
            }
        }

        static void Main()
        {
            Warrior warrior = new Warrior(3);
            Warrior warrior1 = new Warrior(5);
            Warrior warrior2 = new Warrior(6);
            Warrior warrior3 = new Warrior(7);

            Warrior[] war = new Warrior[] { warrior, warrior1 };
            Warrior[] war1 = new Warrior[] { warrior2, warrior3 };

            Squad squad = new Squad(war);
            Squad squad1 = new Squad(war1);

            squad.Attack(warrior);
            warrior.TakeDamage(squad);
            Console.WriteLine();

            squad1.Attack(squad);
            squad.TakeDamage(squad1);
            Console.WriteLine();

            warrior.Attack(squad);
            squad.TakeDamage(warrior);
            Console.WriteLine();

            warrior.Attack(warrior1);
            warrior1.TakeDamage(warrior1);


        }

    }
}
