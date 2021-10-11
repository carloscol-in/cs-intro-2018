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
            LoadSubjects();
            LoadEvaluations();
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

        private void LoadEvaluations()
        {
            Random rnd = new Random();
            float grade;
            foreach (Course course in School.Courses)
            {
                foreach (var student in course.Students)
                {
                    foreach (var subject in course.Subjects)
                    {
                        List<Evaluation> evaluations = new List<Evaluation>();

                        for (int i = 0; i < 5; i++)
                        {
                            grade = (float)rnd.Next(0, 50) / 10;
                            Evaluation eval = new Evaluation {
                                Subject = subject,
                                Student = student,
                                Grade = grade
                            };
                            evaluations.Add(eval);
                        }

                        subject.Evaluations = evaluations;
                    }
                }
            }
        }

        private List<Student> LoadStudents(int quantity)
        {
            string[] name1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] surname1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] name2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var students_list = from n1 in name1
                                from n2 in name2
                                from s1 in surname1
                                select new Student{ Name = $"{n1} {n2} {s1}" };

            return students_list.OrderBy( (st) => st.UniqueId).Take(quantity).ToList();
        }

        private void LoadCourses()
        {
            int random_quantity;
            Random rnd = new Random();

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

            foreach (var course in School.Courses)
            {
                random_quantity = rnd.Next(5, 20);
                List<Student> students = LoadStudents( random_quantity );
                course.Students = students;
            }
        }
    }
}