namespace MvcMovie.DynamicDisplays
{
    public class RaportsDetails
    {
        public string BgColor1{get;set;}

        public string TxtColor1{get;set;}

        public string BgColor2{get;set;}

        public string TxtColor2{get;set;}

        public string BgColor3{get;set;}

        public string TxtColor3{get;set;}

        public bool NormyPrzekroczone {get;set;} 

        public string StatusNormy {get;set;}

        public RaportsDetails(){
            TxtColor1 = TxtColor2 = TxtColor3 = "color: greenyellow;";
            BgColor1 = BgColor2 = BgColor3 ="background-color: green;";
            NormyPrzekroczone = false;
            StatusNormy = "display: none;";
        }
    }
}