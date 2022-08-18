using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            const double NEEDED_GRADE_TO_PASS = 4.5;

            var students = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students[studentName] = new List<double>();
                }
                students[studentName].Add(studentGrade);
            }

            foreach (var student in students)
            {
                string studentName = student.Key;
                double studentAverageGrade = student.Value.Average();

                if (studentAverageGrade >= NEEDED_GRADE_TO_PASS)            //if (studentAverageGrade >= 4.5)
                {
                    Console.WriteLine($"{student.Key} -> {studentAverageGrade:f2}");
                }
            }
        }
    }
}

