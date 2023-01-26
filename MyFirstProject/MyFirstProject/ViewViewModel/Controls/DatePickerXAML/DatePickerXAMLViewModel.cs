using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModel.Controls.DatePickerResult;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Controls.DatePickerXAML
{
    class DatePickerXAMLViewModel : BaseViewModel
    {
        public ImageSource SubmitButton { get; set; }

        public DatePickerXAMLViewModel()
        {
            Title = Titles.DatePickerXAMLTitle;
            SubmitButton = ImageSource.FromResource("MyFirstProject.Image.buttonsubmit.png");
        } 
    }
}
