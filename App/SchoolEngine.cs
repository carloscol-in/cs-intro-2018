using CoreSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreSchool
{
    public class SchoolEngine
    {
        public School School { get; set; }

        public SchoolEngine()
        {}

        public void Initialize()
        {
            School = new School(
                name: "platzi academy",
                foundation_year: 2000,
                school_type: SchoolTypes.Primaria,
                country: "Colombia",
                city: "Bogota"
            );

            LoadCourses();
            LoadStudents();
            LoadSubjects();
            LoadEvaluations();
        }

        private void LoadEvaluations()
        {
            throw new NotImplementedException();
        }

        private void LoadSubjects()
        {
            foreach (var course in School.Courses)
            {
                List<Subject> subject_list = new List<Subject>(){
                    new Subject{Name="Mathematics"},
                    new Subject{Name="History"},
                    new Subject{Name="Geography"},
                    new Subject{Name="Arts"},
                    new Subject{Name="Biology"},
                };
                course.Subjects.AddRange(subject_list);
            }
        }

        private void LoadStudents()
        {
            string[] name1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] name2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };
            string[] surname1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };

            var students_list = from n1 in name1
                                from n2 in name2
                                from s1 in surname1
                                select new Student{ Name = $"{name1} {name2} {surname1}" };
        }

        private void LoadCourses()
        {
            School.Courses = new List<Course>(){
                new Course() {
                    Name = "Software Development 101"
                },
                new Course() {
                    Name = "Software Development 201"
                },
                new Course() {
                    Name = "Software Development 301"
                },
                new Course() {
                    Name = "Frontend Development 101",
                    Time = CourseTimeTypes.Morning
                },
                new Course() {
                    Name = "Frontend Development 201",
                    Time = CourseTimeTypes.Evening
                },
                new Course() {
                    Name = "Frontend Development 301",
                    Time = CourseTimeTypes.Night
                }
            };
        }
    }
}