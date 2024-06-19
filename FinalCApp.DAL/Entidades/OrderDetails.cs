using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCApp.DAL.Entidades
{
    public class OrderDetails
    {
        public int orderid { get; set; }
        public int productid { get; set; }
        public decimal unitprice { get; set; }
        public double  qty { get; set; }
        public double discount { get; set; }
    }
}
