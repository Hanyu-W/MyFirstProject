using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyFirstProject.Models
{
    public class Person
    {
        public string Name { get; set; }

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
        public Person(string name, string image)
        {
            Name = name;
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
                new Person("Divyesh Kotthakota", "MyFirstProject.Image.Divyesh.jpg"),
                new Person("Kevin Yu", "MyFirstProject.Image.Kevin.jpg"),
                new Person("Justin Lopato", "MyFirstProject.Image.Justin.JPG"),
                new Person("Illia Myronov", "MyFirstProject.Image.Ilya.jpg"),
                new Person("Hanyu Wei", "MyFirstProject.Image.Hanyu.jpg")
            };
        }

    }
}
