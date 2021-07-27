using System.ComponentModel;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models
{
    public class Student
    {   
        public int StudentId {get;set;}

        [DisplayNameAttribute("Student Name"),Required,StringLength(40,MinimumLength = 3),RegularExpression(@"^[A-Z]+[a-zA-Z\s-]*$")]
        public string StudentName {get;set;}

        [DisplayNameAttribute("Student Surname"),Required,StringLength(60,MinimumLength = 5),RegularExpression(@"^[A-Z]+[a-zA-Z\s-]*$")]
        public string StudentSurname {get;set;}

        [Required,Range(1,100)]
        public int Age {get;set;}

        [Required,Range(1,5)]
        public int Year {get;set;}

        [Required,Range(1,2)]
        public int Semester {get;set;}

        [DisplayNameAttribute("Join Time"),Required,DataType(DataType.Date)]
        public string JoinTime {get;set;}

        [Required,StringLength(90,MinimumLength = 10),RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string University {get;set;}
    }
}