using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1
{
    public class Customer
    {
        private string custFirstName { get; set; }
        private string custLastName { get; set; }
        private string custAddress1 { get; set; }
        private string custAddress2 { get; set; }
        private string custCity { get; set; }
        private string custState { get; set; }
        private int custZipCode { get; set; }

        public void setCustFirstName(string firstName)
        {
            this.custFirstName = firstName;
        }

        public void setCustLastName(string lastName)
        {
            this.custLastName = lastName;
        }

        public void setCustAddress1(string address1)
        {
            this.custAddress1 = address1;
        }

        public void setCustAddress2(string address2)
        {
            this.custAddress2 = address2;
        }

        public void setCustCity(string city)
        {
            this.custCity = city;
        }

        public void setState(string state)
        {
            this.custState = state;
        }

        public void setCustZipCode(int zip)
        {
            this.custZipCode = zip;
        }

    }
}