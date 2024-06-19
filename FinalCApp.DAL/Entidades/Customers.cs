﻿

using FinalCApp.DAL.Core;

namespace FinalCApp.DAL.Entidades
{
    public class Customers : BaseEntity
    {
        public int custid { get; set; }
        public string companyname { get; set; }

        public string contactname { get; set; }
        public string contacttitle { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string city { get; set; }
        public string? region { get; set; }
        public string? postalCode { get; set; }
        public string country { get; set; }
        public string phone { get; set; }
        public string? fax { get; set; }

    }
}
