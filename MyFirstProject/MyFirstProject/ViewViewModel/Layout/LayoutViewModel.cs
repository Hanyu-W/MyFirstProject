using MyFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Text;
using MyFirstProject.ViewModels;
using System.Windows.Input;
using Xamarin.Forms;
using MyFirstProject.ViewViewModel.Layout.AbsoluteLayout;

namespace MyFirstProject.ViewViewModel.Layout
{
    class LayoutViewModel : BaseViewModel
    {
        public ICommand OnAbsoluteLayoutClicked { get; set; }
        public LayoutViewModel()
        {
            Title = Titles.LayoutMenuTitle;
            OnAbsoluteLayoutClicked = new Command(OnAbsoluteLayoutClickedAsync);
        }

        private async void OnAbsoluteLayoutClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AbsoluteLayoutMenuView());
        }
    }
}
