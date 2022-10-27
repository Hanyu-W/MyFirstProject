using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Models
{
    public class Person
    {
        public string Name { get; set; }

        //default constructor
        public Person()
        {

        }

        public Person(string name)
        {
            Name = name;
        }

        //static method creates a list of names
        public static List<Person> getNames()
        {
            return new List<Person>
            {
                new Person("Divyesh Kotthakota"),
                new Person("Kevin Yu"),
                new Person("Justin Lopato"),
                new Person("Illia Myronov"),
                new Person("Hanyu Wei")
            };
        }

    }
}
