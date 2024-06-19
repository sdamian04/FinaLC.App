using FinalCApp.DAL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCApp.DAL.Entidades
{
    public class Categories : BaseEntity
    { public int categoryid {  get; set; }
        public string categoryname { get; set; }
        public string description { get; set; }
            
    }
}
