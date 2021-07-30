using System.ComponentModel;
namespace MvcMovie.Models
{
    public class Produkt
    {
        public int id{get;set;}

        public string nazwa{get;set;}

        [DisplayNameAttribute("Rodzaj Badania")]
        public string typBadania {get;set;}

        [DisplayNameAttribute("Dolna Granica Normy")]
        public double normaLow {get;set;}

        [DisplayNameAttribute("Górna Granica Normy")]
        public double normaHigh {get;set;}
    }
}