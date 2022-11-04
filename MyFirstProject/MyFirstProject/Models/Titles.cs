using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Models
{
    public static class Titles
    {
        //Main
        public static string MainPageTitle { get; } = "Main Page";
        public static string MainPageSubtitle { get; } = "My Epic Mobile App";

        //Layout
        public static string LayoutMenuTitle { get; } = "Layout Menu";
        public static string AbsoluteLayoutMenuTitle { get; } = "Absolute Layout Menu";
        public static string AbsoluteLayoutPageTitle { get; } = "Absolute Page";
        public static string RelativeLayoutTitle { get; } = "Relative Page";
        public static string RelativeTitle { get; } = "Relative";
        
        //List View
        public static string ListViewMenuTitle { get; } = "List View Menu";
        public static string DisplayPersonsTitle { get; } = "Display Persons";

        //Controls
        public static string ControlMenuTitle { get; } = "Control Menu";

        //SQLite
        public static string SQLiteMenuTitle { get; } = "SQLite Menu";

        //Image
        public static string ImageMenuTitle { get; } = "Image Menu";
        public static string URIimageTitle { get; } = "URI Image";
        public static string VMIimageTitle { get; } = "VMI Image";
        public static string EmbeddedImageTitle { get; } = "Embedded Image";
        public static string ActivityImageTitle { get; } = "Activity Image";
    }
}
