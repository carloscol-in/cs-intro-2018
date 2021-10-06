using System;

namespace CoreSchool.Entities
{
    public class Course
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; }
        public CourseTimeTypes Time { get; set; }

        public Course() => UniqueId = Guid.NewGuid().ToString();

        public override string ToString()
        {
            return $"{Name} : {UniqueId}";
        }
    }
}