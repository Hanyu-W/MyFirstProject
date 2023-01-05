using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModel.Controls.Slider;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Controls
{
    class ControlViewModel : BaseViewModel
    {
        public ICommand OnSliderClicked { get; set; }

        public ControlViewModel()
        {
            Title = Titles.ControlMenuTitle;
            OnSliderClicked = new Command(OnSliderClickedAsync);
        }

        private async void OnSliderClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SliderView());
        }
    }
}
