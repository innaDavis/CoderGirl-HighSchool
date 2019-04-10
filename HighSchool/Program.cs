using System;
using System.Collections.Generic;

namespace HighSchool
{
    public static class Program
    {
        public static void Main()
        {

            var students = new List<Student>
            {
                new Student { FirstName = "FirstOne", LastName = "LastOne", GPA = 2.0, Grade = 6 },
                new Student { FirstName = "FirstTwo", LastName = "LastTwo", GPA = 3.1, Grade = 9 },
                new Student { FirstName = "FirstThree", LastName = "LastThree", GPA = 3.2, Grade = 5 },
                new Student { FirstName = "FirstFourB", LastName = "LastFourB", GPA = 3.0, Grade = 9 },
                new Student { FirstName = "FirstFourC", LastName = "LastFourA", GPA = 4.3, Grade = 6 },
                new Student { FirstName = "FirstFourA", LastName = "LastFourA", GPA = 1.8, Grade = 9 },
                new Student { FirstName = "FirstFive", LastName = "LastFive", GPA = 2.0, Grade = 8 },
                new Student { FirstName = "FirstSix", LastName = "LastSix", GPA = 3.1, Grade = 12 },
                new Student { FirstName = "FirstSeven", LastName = "LastSeven", GPA = 1.2, Grade = 5 },
                new Student { FirstName = "FirstEight", LastName = "LastEight", GPA = 2.3, Grade = 12 }
            };

            var result = Student.StarStudents(students);

            foreach (var student in result)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} {student.Grade} {student.GPA}");
            }
  

            Console.ReadLine();
        }
    }
}
