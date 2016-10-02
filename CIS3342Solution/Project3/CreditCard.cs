using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project3
{
    public class CreditCard
    {
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String Address1 { get; set; }
        public String Address2 { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public int Zip { get; set; }
        public int CardNumber { get; set; }
        public int verifNumber { get; set; }
    }
}