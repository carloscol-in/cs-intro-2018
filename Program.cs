using System;
using CoreSchool.Entities;
using CoreSchool.Util;
using System.Collections.Generic;
using static System.Console; // Allow us to use ony WriteLine(), for example, instead of Console.WriteLine()

namespace CoreSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new SchoolEngine();
            engine.Initialize();

            Printer.WriteTitle("Hello, World!");

            PrintSchoolCourses(engine.School);
        }

        private static void PrintSchoolCourses(School school)
        {
            if (school?.Courses == null) return;

            foreach (var course in school.Courses)
            {
                WriteLine(course);
            }
        }
    }
}
