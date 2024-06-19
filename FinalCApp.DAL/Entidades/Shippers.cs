

using FinalCApp.DAL.Core;

namespace FinalCApp.DAL.Entidades
{
    public class Shippers : BaseEntity
    {
        public int shipperid { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string? address { get; set; }
        public string? city { get; set; }
       
        public string? region { get; set; }
        public string? postalCode { get; set; }
        public string? country { get; set; }
        


    }
}
