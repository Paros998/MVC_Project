using System.ComponentModel;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Raport
    {
        public int id{get;set;}

        [Required,Range(1,int.MaxValue),DisplayNameAttribute("Numer Raportu")]
        public int NrRaportu {get;set;}

        [Required,DataType(DataType.Date),DisplayNameAttribute("Data Raportu")]
        public DateTime DataRaportu {get;set;}

        [Required,DisplayNameAttribute("Odczyt nr.1")]
        public double Odczyt1 {get;set;}
        [Required,DisplayNameAttribute("Odczyt nr.2")]
        public double Odczyt2 {get;set;}
        [Required,DisplayNameAttribute("Odczyt nr.3")]
        public double Odczyt3 {get;set;}

        [Required,RegularExpression(@"^[A-Z]+[a-zA-z0-9\s]*$"),DisplayNameAttribute("Typ Odczytu")]
        public string TypOdczytu {get;set;}

        [Required,RegularExpression(@"^[A-Z]+[a-zA-z0-9\s]*$")]
        public string Seria {get;set;}

        [Required,RegularExpression(@"^[A-Z]+[a-zA-z0-9\s]*$")]
        public string Norma {get;set;}

        [Required,RegularExpression(@"^[A-Z]+[a-zA-z0-9\s]*$"),DisplayNameAttribute("Nazwa Zakładu")]
        public string NazwaZakladu {get;set;}

        [Required,RegularExpression(@"^[A-Z]+[a-zA-z0-9\s]*$")]
        public string Produkt{get;set;}
    }
}