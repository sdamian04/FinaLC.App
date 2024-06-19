using FinalCApp.DAL.Core;
using System.Data.SqlTypes;

namespace FinalCApp.DAL.Entidades
{
    public class Products : BaseEntity
    {
        public int productid { get; set; }
        public string productname { get; set; }
        public int supplierid { get; set; }
        public string categoryid { get; set; }
        public  SqlMoney unitprice { get; set; }
        public bool discontinued { get; set; }


    }
}
