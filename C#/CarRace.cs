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
        public abstract class Vehicles
        {
            public string Name { get; set; }
            public float Speed { get; set; }

            public Vehicles(string name)
            {
                Name = name;
                Speed = 0f;
            }

            public abstract void Move();
        }

        public class SportsCar : Vehicles
        {
            public SportsCar(string name) : base(name) { }

            public override void Move()
            {
                Speed += new Random().Next(5, 15);
            }
        }

        public class LightCar : Vehicles
        {
            public LightCar(string name) : base(name) { }

            public override void Move()
            {
                Speed += new Random().Next(4, 10);
            }
        }

        public class Truck : Vehicles
        {
            public Truck(string name) : base(name) { }

            public override void Move()
            {
                Speed += new Random().Next(3, 5);
            }
        }

        public class Bus : Vehicles
        {
            public Bus(string name) : base(name) { }

            public override void Move()
            {
                Speed += new Random().Next(2, 8);
            }
        }


        public delegate void RaceStart();

        public delegate void RaceFinish(Vehicles winner);

        public class Race
        {
            public event RaceStart DelRaceStarted;
            public event RaceFinish DelRaceFinished;

            public void StartRace()
            {
                DelRaceStarted?.Invoke();

                var sportsCar = new SportsCar("Спортивный автомобиль");
                var sedanCar = new LightCar("Легковой автомобиль");
                var truck = new Truck("Грузовик");
                var bus = new Bus("Автобус");

                var vehicles = new Vehicles[] { sportsCar, sedanCar, truck, bus };

                while (true)
                {
                    foreach (var car in vehicles)
                    {
                        car.Move();
                        Console.WriteLine($"{car.Name} движется со скоростью {car.Speed}\n");

                        if (car.Speed >= 35f)
                        {
                            Console.WriteLine($"{car.Name} пришел к финишу первым!");

                            DelRaceFinished?.Invoke(car);
                            return;
                        }
                    }
                }
            }
        }

        class Program
        {
            static void Main()
            {
                var race = new Race();

                race.DelRaceStarted += () => Console.WriteLine("Гонка началась!");

                race.DelRaceFinished += winner => Console.WriteLine($"Победитель: {winner.Name}");

                race.StartRace();
            }
        }
    }
