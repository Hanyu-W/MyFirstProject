using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Controls.PickerMenu
{
    class PickerMenuViewModel : BaseViewModel
    {
        public ImageSource XAMLButton { get; set; }

        public PickerMenuViewModel()
        {
            Title = Titles.PickerMenuTitle;
            XAMLButton = ImageSource.FromResource("MyFirstProject.Image.buttonred.png");
        }
    }
}
