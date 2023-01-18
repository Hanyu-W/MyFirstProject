using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModel.Controls.Picker;
using MyFirstProject.ViewViewModel.Controls.PickerVM;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Controls.PickerMenu
{
    class PickerMenuViewModel : BaseViewModel
    {
        public ICommand OnXAMLButtonClicked { get; set; }

        public ImageSource XAMLButton { get; set; }

        public ICommand OnVMButtonClicked { get; set; }

        public ImageSource VMButton { get; set; }

        public PickerMenuViewModel()
        {
            Title = Titles.PickerMenuTitle;
            XAMLButton = ImageSource.FromResource("MyFirstProject.Image.buttonred.png");
            OnXAMLButtonClicked = new Command(OnXAMLButtonClickedAsync);
            VMButton = ImageSource.FromResource("MyFirstProject.Image.buttonblue.png");
            OnVMButtonClicked = new Command(OnVMButtonClickedAsync);
        }

        private async void OnXAMLButtonClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new PickerView());
        }

        private async void OnVMButtonClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new PickerVMView());
        }
    }
}
