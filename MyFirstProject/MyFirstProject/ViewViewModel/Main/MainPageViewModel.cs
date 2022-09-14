using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModel.Controls;
using MyFirstProject.ViewViewModel.Image;
using MyFirstProject.ViewViewModel.Layout;
using MyFirstProject.ViewViewModel.List_View;
using MyFirstProject.ViewViewModel.SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Main
{
    public class MainPageViewModel : BaseViewModel
    {
        string subtitle = string.Empty;

        public ICommand OnLayoutClicked { get; set; }
        public ICommand OnImageClicked { get; set; }
        public ICommand OnControlsClicked { get; set; }
        public ICommand OnListViewClicked { get; set; }
        public ICommand OnSQLiteClicked { get; set; }


        public MainPageViewModel()
        {
            Title = Titles.MainPageTitle;
            Subtitle = Titles.MainPageSubtitle;

            OnLayoutClicked = new Command(OnLayoutClickedAsync);
            OnImageClicked = new Command(OnImageClickedAsync);
            OnControlsClicked = new Command(OnControlsClickedAsync);
            OnListViewClicked = new Command(OnListViewClickedAsync);
            OnSQLiteClicked = new Command(OnSQLiteClickedAsync);
        }

        private async void OnSQLiteClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SQLiteMenuView());
        }

        private async void OnListViewClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ListViewMenuView());
        }

        private async void OnControlsClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ControlsMenuView());
        }

        private async void OnImageClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ImageMenuView());
        }

        public string Subtitle
        {
            get { return subtitle; }
            set { SetProperty(ref subtitle, value); }
        }

        private async void OnLayoutClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new LayoutMenuView());
        }
    }
}
