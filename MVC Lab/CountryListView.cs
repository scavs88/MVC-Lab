using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Lab
{
    class CountryListView
    {
        private List<Country> _countries;
        public List<Country> Countries
        {
            get { return this._countries; }
            set { this._countries = value; }
        }
        public CountryListView()
        {

        }
        public CountryListView(List<Country> countries)
        {
            this._countries = countries;
        }

        public void Display(List<Country> countries)
        {
            foreach (Country country in countries)
            {
                int counter = 1;
                Console.WriteLine($"{counter} {country.Name}");
                counter++;
            }
        }
    }
}
