using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModel.SQLite.Vacations;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.SQLite
{
    class SQLiteViewModel : BaseViewModel
    {
        public ICommand OnVacationsClicked { get; set; }
        public SQLiteViewModel()
        {
            Title = Titles.ListViewMenuTitle;
            OnVacationsClicked = new Command(OnVacationsClickedAsync);
        }

        private async void OnVacationsClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SQLiteView());
        }
    }
}
