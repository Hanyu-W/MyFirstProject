using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.List_View.DisplayPersonsButtonView.EditPerson
{
    class EditPersonViewModel : BaseViewModel
    {
        public ICommand UpdateBtnClicked { get; set; }
        private string _movieName = string.Empty;

        public EditPersonViewModel()
        {
            Title = Titles.EditTitle;
            UpdateBtnClicked = new Command(PerformSave);
        }

        public string MovieName
        {
            get { return _movieName; }

            set
            {
                if (_movieName != value)
                    SetProperty(ref _movieName, value);
            }
        }

        private void PerformSave()
        {
            if (string.IsNullOrEmpty(_movieName.Trim()))
            {
                Application.Current.MainPage.DisplayAlert(Titles.AddTitle, Msgs.NotEmpty, "OK");
                return;
            }

            Movies movie = new Movies();
            movie.Name = _movieName;

            MessagingCenter.Send<Movies>(movie, "UpdateMovies");
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
