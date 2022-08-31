﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace MVCCountries
{
    internal class CountryView
    {
        public Country DisplayCountry { get; set; }

        //constructor
        public CountryView(Country DisplayCountry)
        {
            this.DisplayCountry = DisplayCountry;
        }

        //methods
        public void Display()
        {
            Console.WriteLine($"Country Display\nName: {DisplayCountry.Name}\nContinent: {DisplayCountry.Continent}");
            Console.WriteLine("Flag Colors:");
            foreach (string c in DisplayCountry.Colors)
            {
                // TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                string color = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(c);

                Console.ForegroundColor = Enum.Parse<ConsoleColor>(color);
                if (color == "Black")
                {
                    Console.BackgroundColor = ConsoleColor.White;

                }
                Console.WriteLine($"{c}");
                Console.ResetColor();
            }
        }
    }
}