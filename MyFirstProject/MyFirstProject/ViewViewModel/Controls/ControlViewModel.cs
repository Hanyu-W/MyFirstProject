using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModel.Controls.Entry;
using MyFirstProject.ViewViewModel.Controls.Slider;
using MyFirstProject.ViewViewModel.Controls.Stepper;
using MyFirstProject.ViewViewModel.Controls.Switch;
using MyFirstProject.ViewViewModel.Controls.TwoSwitch;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Controls
{
    class ControlViewModel : BaseViewModel
    {
        public ICommand OnSliderClicked { get; set; }

        public ICommand OnStepperClicked { get; set; }

        public ICommand OnSwitchClicked { get; set; }

        public ICommand OnTwoSwitchClicked { get; set; }

        public ICommand OnEntryClicked { get; set; }

        public ControlViewModel()
        {
            Title = Titles.ControlMenuTitle;
            OnSliderClicked = new Command(OnSliderClickedAsync);
            OnStepperClicked = new Command(OnStepperClickedAsync);
            OnSwitchClicked = new Command(OnSwitchClickedAsync);
            OnTwoSwitchClicked = new Command(OnTwoSwitchClickedAsync);
            OnEntryClicked = new Command(OnEntryClickedAsync);
        }

        private async void OnSliderClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SliderView());
        }

        private async void OnStepperClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new StepperView());
        }

        private async void OnSwitchClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SwitchView());
        }

        private async void OnTwoSwitchClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new TwoSwitchView());
        }

        private async void OnEntryClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new EntryView());
        }
    }
}
