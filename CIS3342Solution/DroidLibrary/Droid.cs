using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DroidLibrary
{
    class Droid
    {
        private string Make { get; set; }
        private string Model { get; set; }
        private int Year { get; set; }
        private int Price { get; set; }
        private packages package { get; set; }

        public Droid(string make, string model, int year, int price, packages pack)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Price = price;
            this.package = pack;
        }

        public void setMake(string make) {
            this.Make = make;
        }

        public void setModel(string model)
        {
            this.Model = model;
        }

        public void setYear(int year)
        {
            this.Year = year;
        }

        public void setPrice(int price)
        {
            this.Price = price;
        }

        public void setPackage(packages package)
        {
            this.package = package;
        }


    }
}
