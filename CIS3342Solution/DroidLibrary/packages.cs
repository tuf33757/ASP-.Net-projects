using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroidLibrary
{
    class packages
    {
        private string description { get; set; }
        private int price { get; set; }

        public packages(string description, int price)
        {
            this.description = description;
            this.price = price;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }

        public void setPrice(int price)
        {
            this.price = price;
        }
    }
}
