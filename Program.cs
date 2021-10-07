using System;
using CoreSchool.Entities;
using System.Collections.Generic;
using static System.Console; // Allow us to use ony WriteLine(), for example, instead of Console.WriteLine()

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var school = new School(
                name: "platzi academy",
                foundation_year: 2000,
                school_type: SchoolTypes.Primaria,
                country: "Colombia",
                city: "Bogota"
            );
            // school.Country = "Colombia";
            // school.City = "Bogota";
            // school.SchoolType = SchoolTypes.Primaria;

            school.Courses = new List<Course>(){
                new Course() {
                    Name = "Software Development 101"
                },
                new Course() {
                    Name = "Software Development 201"
                },
                new Course() {
                    Name = "Software Development 301"
                }
            };

            PrintSchoolCourses(school);
        }

        private static void PrintSchoolCourses(School school)
        {
            if (school?.Courses == null) return;

            foreach (var course in school.Courses)
            {
                WriteLine(course);
            }
        }

        private static void PrintCoursesForEach(Course[] courses_array)
        {
            foreach (var course in courses_array)
            {
                Console.WriteLine(course);
            }
        }

        private static void PrintCoursesFor(Course[] courses_array)
        {
            for (int i = 0; i < courses_array.Length; i++)
            {
                Console.WriteLine(courses_array[i]);
            }
        }

        private static void PrintCoursesWhile(Course[] courses_array)
        {
            int count = 0;
            while (count < courses_array.Length)
            {
                Console.WriteLine(courses_array[count]);
                count++;
            }
        }

        private static void PrintCoursesDoWhile(Course[] courses_array)
        {
            int count = 0;
            do
            {
                Console.WriteLine(courses_array[count]);
                // count++;
            } while (++count < courses_array.Length);
        }
    }
}
