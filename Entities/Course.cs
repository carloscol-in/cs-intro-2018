using System;
using System.Collections.Generic;

namespace CoreSchool.Entities
{
    public class Course : BaseEntity
    {
        public CourseTimeTypes Time { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<Student> Students { get; set; }

        // constructor
        public Course()
        {
            // code
        }

        public override string ToString()
        {
            return $"{Name} - {Time} : {UniqueId}";
        }
    }
}