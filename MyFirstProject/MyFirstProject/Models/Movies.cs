using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Models
{
    class Movies
    {
        public string Name { get; set; }

        //movie constructor with only name
        public Movies(string name)
        {
            Name = name;
        }

        //static method creates a list of names
        public static List<Movies> getNames()
        {
            return new List<Movies>
            {
                new Movies("Your Name"),
                new Movies("Grand Budapest Hotel"),
                new Movies("John Wick"),
                new Movies("Star Wars"),
                new Movies("Fast and Furious")
            };
        }
    }
}
