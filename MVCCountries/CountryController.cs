using System;
namespace MVCCountries
{
    public class CountryController
    {
        //properties
        public List<Country> CountryDb = new List<Country>()
         {
             new Country("Nigeria","Africa",new List<string>{"Green","White", "Green"}),
             new Country("Ghana ","Africa", new List<string> { "Red", "Yellow", "Green", "Black"}),
             new Country("Japan","Asia",new List<string>{"Red","White"}),
             new Country("Austrialia ","Australia", new List<string> { "Red","White","Blue"}),
             new Country("South Korea","Asia",new List<string>{"Red","White","Blue","Black"}),
             new Country("France", "Europe", new List<string> {"Blue", "White", "Red"}),
             new Country("United Kingdom","Europe", new List<string> { "Blue", "White", "Red" }),
             new Country("United States of America","North America",new List<string>{"Red","White","Blue"}),
         };
        //constructor
        public CountryController()
        {
        }

        //methods
        public void CountryAction(Country c)
        {
            CountryView cv = new CountryView(c);
            cv.Display();
        }
        public void WelcomeAction()
        {
            bool goAgain = true;
            while (goAgain)
            {
                CountryListView clv = new CountryListView(CountryDb);
                Console.WriteLine("Welcome to the Country App. \nPlease select a country from the following list:\n");
                clv.Display();
                int index = int.Parse(Console.ReadLine());
                CountryAction(CountryDb[index]);
                Console.WriteLine("\nWould you like to learn about another country?(y/n)");
                if (Console.ReadLine().ToLower().Trim() == "y")
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    Console.WriteLine("Thank you. Goodbye!");
                    goAgain = false;
                    break;
                }
            }
        }
    }
}

