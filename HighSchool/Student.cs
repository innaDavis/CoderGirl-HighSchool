using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace HighSchool
{

    public class Student
    {
        //private int _grade;
        //private double _gpa;
        public static double qualifyingGrade = 3;
        public string FirstName { set; get; }
        public string LastName { get; set; }
     
        public double GPA { set; get; }
      
        public int Grade { set; get; }

        public Student (double GPA, int Grade)
        {
            GPA = Math.Max(0, 4);
            GPA = Math.Min(0, 4);

            Grade = Math.Max(1, 12);
            Grade = Math.Min(1, 12);
        }

      


        public static List<Student> StarStudents(List<Student> students)
        {
            var starStudents = students.Where(student => student.GPA >= qualifyingGrade && (student.Grade >= 9 && student.Grade <= 12))
                                        .OrderByDescending(x => x.Grade)
                                        .ThenByDescending(x => x.GPA)
                                        .ThenBy(x => x.LastName)
                                        .ThenBy(x => x.FirstName)
                                        .ToList();
         
            return starStudents;
        }

        public int GetGradeMax(List<Student> students)
        {
            return students.Select(student => student.Grade).Max();
        }

        public double GetGPAMax(List<Student> students)
        {
            return students.Select(student => student.GPA).Max();
        }

    }
}
