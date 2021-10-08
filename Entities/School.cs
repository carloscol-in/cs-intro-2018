using System.Collections.Generic;

namespace CoreSchool.Entities
{

    public class School : BaseEntity
    {

        string name;
        new public string Name {
            get {
                return name;
            }
            set {
                name = value.ToUpper();
            }
        }

        public int FoundationYear { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public SchoolTypes SchoolType { get; set; }
        public List<Course> Courses { get; set; }

        // constructor
        public School(string name, int foundation_year) => (Name, FoundationYear) = (name, foundation_year);
        public School(string name, int foundation_year, SchoolTypes school_type, string country = "", string city = "")
        {
            (Name, FoundationYear) = (name, foundation_year);
            Country = country;
            City = city;
            SchoolType = school_type;
        }

        public override string ToString()
        {
            return $"Nombre: \"{Name}\", Tipo: \"{SchoolType}\"{System.Environment.NewLine}Pais: \"{Country}\", Ciudad: \"{City}\"";
        }

    }

}