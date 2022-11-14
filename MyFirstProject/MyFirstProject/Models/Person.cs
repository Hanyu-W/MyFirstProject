using System.Collections.Generic;
using Xamarin.Forms;

namespace MyFirstProject.Models
{
    public class Person
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public ImageSource Image { get; set; }

        //default constructor
        public Person()
        {

        }

        //person constructor with only name
        public Person(string name)
        {
            Name = name;
        }

        //person contructor with name and image
        public Person(string name, string description, string image)
        {
            Name = name;
            Description = description;
            Image = ImageSource.FromResource(image);
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

        //static method creates a list of names with pictures
        public static List<Person> getNamesWithPicture()
        {
            return new List<Person>
            {
                new Person("Divyesh Kotthakota", "Owns 26 Canadian Geese", "MyFirstProject.Image.Divyesh.jpg"),
                new Person("Kevin Yu", "Gigachad", "MyFirstProject.Image.Kevin.jpg"),
                new Person("Justin Lopato", "Skill Issue", "MyFirstProject.Image.Justin.JPG"),
                new Person("Ilya Myronov", "We use math to make games", "MyFirstProject.Image.Ilya.jpg"),
                new Person("Hanyu Wei", "The creator of this project", "MyFirstProject.Image.Hanyu.jpg")
            };
        }

    }
}
