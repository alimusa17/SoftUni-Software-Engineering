using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students_2._0_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (command != "end")
            {
                string[] tokens = command.Split();
                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string homeTown = tokens[3];

                Student student = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

                if (student == null)
                {
                    students.Add(new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        HomeTown = homeTown
                    });
                }
                else
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;
                }

                command = Console.ReadLine();
            }
            string town = Console.ReadLine();
            List<Student> filteredStudents = students.Where(s => s.HomeTown == town).ToList();

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine(student.ToString());
            }
        }

        class Student
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public int Age { get; set; }

            public string HomeTown { get; set; }

            public override string ToString()
            {
                return $"{FirstName} {LastName} is {Age} years old.";
            }

        }
    }
}

