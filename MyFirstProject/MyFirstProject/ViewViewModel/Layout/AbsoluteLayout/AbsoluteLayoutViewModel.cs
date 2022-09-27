using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModel.Layout.AbsoluteLayout.AbsoluteLayoutPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Layout.AbsoluteLayout
{
    public class AbsoluteLayoutViewModel : BaseViewModel
    {
        public ICommand OnAbsoluteLayoutPageClicked { get; set; }
        public AbsoluteLayoutViewModel()
        {
            Title = Titles.AbsoluteLayoutMenuTitle;
            OnAbsoluteLayoutPageClicked = new Command(OnAbsoluteLayoutPageClickedAsync);
        }
        private async void OnAbsoluteLayoutPageClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AbsoluteLayoutPageView());
        }
    }
}