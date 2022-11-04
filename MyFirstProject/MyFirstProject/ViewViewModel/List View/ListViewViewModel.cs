using MyFirstProject.ViewModels;
using MyFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using MyFirstProject.ViewViewModel.List_View.DisplayPersons;

namespace MyFirstProject.ViewViewModel.List_View
{
    class ListViewViewModel : BaseViewModel
    {
        public ICommand OnDisplayPersonsClicked { get; set; }
        public ListViewViewModel()
        {
            Title = Titles.ListViewMenuTitle;
            OnDisplayPersonsClicked = new Command(OnDisplayPersonsClickedAsync);
        }

        private async void OnDisplayPersonsClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DisplayPersonsView());
        }
    }
}
