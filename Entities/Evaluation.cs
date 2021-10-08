using System;

namespace CoreSchool.Entities
{
    public class Evaluation : BaseEntity
    {
        public Student Student { get; set; }
        public Subject Subject { get; set; }
        public float Grade { get; set; }
    }
}