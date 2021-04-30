using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Lab
{
    class Controller
    {
        private List<Country> _countryDb;

        public List<Country> CountryDb
        {
            get { return this._countryDb; }
            set { this._countryDb = value; }
        }

        public void CountryAction(Country c)
        {
            CountryView cView = new CountryView(c);
            cView.Display();
        }

        public void WelcomeAction()
        {
            CountryListView clView = new CountryListView(this._countryDb);
            Console.WriteLine("Hello, welcome to the country app.  Please select a country from the following list");
            clView.Display(this._countryDb);
            int choice = int.Parse(Console.ReadLine());
            for(int i = 0; i <this._countryDb.Count; i++)
            {
                if (choice == i)
                {
                     
                }
            }



            CountryAction();
            Console.WriteLine("Would you like to learn about another country ");
            

        }
           
    }
}
