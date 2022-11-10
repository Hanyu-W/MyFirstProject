using MyFirstProject.ViewModels;
using MyFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using MyFirstProject.ViewViewModel.List_View.DisplayPersons;
using MyFirstProject.ViewViewModel.List_View.DisplayPersonsImage;

namespace MyFirstProject.ViewViewModel.List_View
{
    class ListViewViewModel : BaseViewModel
    {
        public ICommand OnDisplayPersonsClicked { get; set; }
        public ICommand OnDisplayPersonsImageClicked { get; set; }
        public ListViewViewModel()
        {
            Title = Titles.ListViewMenuTitle;
            OnDisplayPersonsClicked = new Command(OnDisplayPersonsClickedAsync);
            OnDisplayPersonsImageClicked = new Command(OnDisplayPersonsImageClickedAsync);
        }

        private async void OnDisplayPersonsClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DisplayPersonsView());
        }

        private async void OnDisplayPersonsImageClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DisplayPersonsImageView());
        }
    }
}
