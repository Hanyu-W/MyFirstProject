using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModel.Controls.DatePickerVM;
using MyFirstProject.ViewViewModel.Controls.DatePickerXAML;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Controls.DatePickerMenu
{
    class DatePickerModelViewModel : BaseViewModel
    {
        public ICommand OnXAMLButtonClicked { get; set; }

        public ICommand OnVMButtonClicked { get; set; }

        public ImageSource XAMLButton { get; set; }

        public ImageSource VMButton { get; set; }

        public DatePickerModelViewModel()
        {
            Title = Titles.DatePickerMenuTitle;
            VMButton = ImageSource.FromResource("MyFirstProject.Image.dpbuttonred.png");
            XAMLButton = ImageSource.FromResource("MyFirstProject.Image.dpbuttonblue.png");
            OnVMButtonClicked = new Command(OnVMButtonClickedAsync);
            OnXAMLButtonClicked = new Command(OnXAMLButtonClickedAsync);
        }

        private async void OnVMButtonClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DatePickerVMView());
        }

        private async void OnXAMLButtonClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DatePickerXAMLView());
        }
    }
}
