using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Lab
{
    class CountryView
    {
        private Country _displayCountry;
        public Country DisplayCountry
        {
            get { return this._displayCountry; }
            set { this._displayCountry = value; }
        }
       public CountryView(Country country)
        {
            this._displayCountry = country;
        }



        public void Display()
        {
            Console.WriteLine($"Name {this.DisplayCountry.Name}, Continent {this.DisplayCountry.Conitenent}, Flag Colors {this.DisplayCountry.Colors}");
        }
    }
}
