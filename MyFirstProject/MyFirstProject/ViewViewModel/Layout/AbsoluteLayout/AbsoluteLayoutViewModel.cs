using MyFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Layout.AbsoluteLayout
{
    public class AbsoluteLayoutViewModel : ContentPage
    {
        public AbsoluteLayoutViewModel()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to Xamarin.Forms!" }
                }
            };
            Title = Titles.AbsoluteLayoutMenuTitle;
        }
    }
}