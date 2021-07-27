using System.Numerics;
using System.Collections.Generic;
namespace MvcMovie.Models
{
    public class StudentsFilterModel
    {
        public List<Student> Students {get;set;}
        public string UniversityString{get;set;}
        public int AgeRangeX{get;set;}
        public int AgeRangeY{get;set;}
    }
}