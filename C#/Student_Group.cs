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
        interface IComparer
        {
            int Compare(Student x, Student y);
        }
        class Student
        {
            private readonly int Id;
            private readonly string Name;
            private readonly int Age;
            private readonly int Course;

            public Student(int id, string name, int age, int course) { 
                Id = id; Name = name; Age = age; Course = course;
            }

            public int GetID() { return Id; }
            public string GetName() { return Name; }
            public int GetAge() { return Age;}
            public int GetCourse() { return Course;}
        }
        
        class Group
        {
            private readonly List<Student> students = new List<Student>();

            public Group(Student[] student) { 
                for(int i = 0; i < student.Length; i++)
                {
                    students.Add(new Student(student[i].GetID(), student[i].GetName(), student[i].GetAge(), student[i].GetCourse()));
                }
            }
           
            public void AddStudent(Student student) {
                students.Add(student);
            }
            public void SortByName()
            {
                students.Sort(new StudentNameComparer());
            }

            public void SortByAge()
            {
                students.Sort(new StudentAgeComparer());
            }

            public void DisplayGroupe()
            {
                foreach(Student student in students)
                {
                    Console.WriteLine($"ID: {student.GetID()}, Age: {student.GetAge()}, Name: {student.GetName()}, Course: {student.GetCourse()}");
                }
            }
        }

        class StudentNameComparer : IComparer<Student>
        {
            public int Compare(Student x, Student y)
            {
                return string.Compare(x.GetName(), y.GetName());
            }
        }

        class StudentAgeComparer : IComparer<Student>
        {
            public int Compare(Student x, Student y)
            {
                return x.GetAge().CompareTo(y.GetAge());
            }
        }

        static void Main()
        {
            Student s1 = new Student(1, "Max", 22, 2);
            Student s2 = new Student(2, "Lea", 22, 2);
            Student s3 = new Student(3, "Faruk", 22, 2);
            Student s4 = new Student(4, "Mark", 23, 3);
            Student s5 = new Student(5, "Emiliya", 21,2);
            Student s6 = new Student(6, "Zak", 20, 1);

            Student[] students = new Student[] { s1, s2, s3, s4, s5, s6 };
            Group group = new Group(students);

            group.AddStudent(new Student(7, "Erika", 23, 3));

            Console.WriteLine("Сортировка по имени:");
            group.SortByName();
            group.DisplayGroupe();

            Console.WriteLine("\nСортировка по возрасту:");
            group.SortByAge();
            group.DisplayGroupe();

        }
    }
}
