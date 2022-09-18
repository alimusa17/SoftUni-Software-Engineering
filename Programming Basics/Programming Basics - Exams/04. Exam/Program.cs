using System;

namespace _04._Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int student = int.Parse(Console.ReadLine());

            int count5 = 0;
            int count4 = 0;
            int count3 = 0;
            int count2 = 0;
            double totalGrade = 0;

            for (int i = 1; i <= student; i++)
            {
                double gradeStudent = double.Parse(Console.ReadLine());

                totalGrade += gradeStudent;

                if (gradeStudent >= 5)
                {
                    count5++;
                }
                else if (gradeStudent >= 4 && gradeStudent <= 4.99)
                {
                    count4++;
                }
                else if (gradeStudent >= 3 && gradeStudent <= 3.99)
                {
                    count3++;
                }
                else if (gradeStudent < 3)
                {
                    count2++;
                }
            }

            double topStudents = (count5 / (student * 1.0)) * 100;
            double betwen4 = (count4 / (student * 1.0)) * 100;
            double betwen3 = (count3 / (student * 1.0)) * 100;
            double betwen2 = (count2 / (student * 1.0)) * 100;
            double sumGrade = totalGrade / student;

            Console.WriteLine($"Top students: {topStudents:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {betwen4:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {betwen3:f2}%");
            Console.WriteLine($"Fail: {betwen2:f2}%");
            Console.WriteLine($"Average: {sumGrade:f2}");
        }
    }
}
