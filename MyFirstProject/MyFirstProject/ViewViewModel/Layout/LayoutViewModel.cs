using MyFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Text;
using MyFirstProject.ViewModels;
using System.Windows.Input;
using Xamarin.Forms;
using MyFirstProject.ViewViewModel.Layout.AbsoluteLayout;
using MyFirstProject.ViewViewModel.Layout.AbsolutePage;
using MyFirstProject.ViewViewModel.Layout.RelativeLayout;

namespace MyFirstProject.ViewViewModel.Layout
{
    class LayoutViewModel : BaseViewModel
    {
        public ICommand OnAbsoluteLayoutClicked { get; set; }
        public ICommand OnAbsolutePageClicked { get; set; }
        public ICommand OnRelativeLayoutClicked { get; set; }
        public LayoutViewModel()
        {
            Title = Titles.LayoutMenuTitle;
            OnAbsoluteLayoutClicked = new Command(OnAbsoluteLayoutClickedAsync);
            OnAbsolutePageClicked = new Command(OnAbsolutePageClickedAsync);
            OnRelativeLayoutClicked = new Command(OnRelativeLayoutClickedAsync);
        }

        private async void OnRelativeLayoutClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new RelativeLayoutView());
        }

        private async void OnAbsoluteLayoutClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AbsoluteLayoutMenuView());
        }

        private async void OnAbsolutePageClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AbsolutePageView());
        }
    }
}
