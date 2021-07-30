using System.Numerics;
using System.Collections.Generic;
using MvcMovie.DynamicDisplays;

namespace MvcMovie.Models
{
    public class SzczegolyRaportu
    {
        public Produkt produkt {get;set;}
        public Raport raport {get;set;}
        public RaportsDetails styl {get;set;}
        
    }
}