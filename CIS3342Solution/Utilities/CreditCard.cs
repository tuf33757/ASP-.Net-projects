using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    class CreditCard
    {
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String Address1 { get; set; }
        public String Address2 { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public int Zip { get; set; }
        
        public int verifNumber { get; set; }
        
        public int expMonth { get; set; }
        public int expYear { get; set; }
        public float maxBal { get; set; }
        public float accBal { get; set; }
    }
}
