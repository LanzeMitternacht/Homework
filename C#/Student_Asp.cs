using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        class Student
        {
            internal string Name { get; set; }
            int Age { get; set; }
            internal int Course { get; set; }

            public Student(string name, int age, int course)
            {
                Name = name;
                Age = age;
                Course = course;
            }

            public void Study()
            {
                Console.WriteLine($"Студент {Name}, учится на {Course} курсе");
            }
        }
        
        class Aspirant : Student
        {
            string ThesisTopic { get; set; }

            public Aspirant(string name, int age, int course, string thesisTopic): base(name, age, course)
            {
                ThesisTopic = thesisTopic;
            }

            public void PrepareThesis()
            {
                Console.WriteLine($"Студент {Name}, находясь на {Course} курсе, готовит кандидатскую диссертацию на тему: {ThesisTopic}");
            }
        }
        static void Main()
        {
            Student s1 = new Student("Alex", 19, 3);
            Aspirant a1 = new Aspirant("Lea", 22, 5, "War in love");
            s1.Study();
            a1.Study();
            a1.PrepareThesis();
        }
    }
}
