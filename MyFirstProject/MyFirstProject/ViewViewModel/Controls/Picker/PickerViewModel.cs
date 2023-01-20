using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModel.Controls.PickerResult;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Controls.Picker
{
    class PickerViewModel : BaseViewModel
    {
        public ICommand OnSubmitClicked { get; set; }

        public ImageSource SubmitButton { get; set; }

        public string SelectedItem { get; set; }

        public PickerViewModel()
        {
            SubmitButton = ImageSource.FromResource("MyFirstProject.Image.buttonsubmit.png");
            Title = Titles.PickerXAMLTitle;
            OnSubmitClicked = new Command(OnSubmitClickedAsync);
        }

        private async void OnSubmitClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new PickerResultView(SelectedItem, null));
        }
    }
}
