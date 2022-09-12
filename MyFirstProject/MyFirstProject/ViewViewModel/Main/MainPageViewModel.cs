using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ViewViewModel.Main
{
    public class MainPageViewModel : BaseViewModel
    {
        string subtitle = string.Empty;

        public MainPageViewModel()
        {
            Title = Titles.MainPageTitle;
            Subtitle = Titles.MainPageSubtitle;
        }

        public string Subtitle
        {
            get { return subtitle; }
            set { SetProperty(ref subtitle, value); }
        }
    }
}
