﻿using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModel.List_View.DisplayPersonsButtonView.AddPerson;
using MyFirstProject.ViewViewModel.List_View.DisplayPersonsButtonView.EditPerson;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.List_View.DisplayPersonsButtonView
{
    class DisplayPersonsButtonViewModel : BaseViewModel
    {
        public ImageSource EditImageSrc { get; set; }

        public ImageSource DeleteImageSrc { get; set; }

        private ObservableCollection<Movies> _movie;

        private List<Movies> _movieList;

        public DisplayPersonsButtonViewModel()
        {
            Title = Titles.DisplayButtonTitle;
            MovieCollection = new ObservableCollection<Movies>();
            _movieList = Movies.getNames();
            EditImageSrc = ImageSource.FromResource("MyFirstProject.Image.iconsedit.png");
            this.LoadMovies();
            DeleteImageSrc = ImageSource.FromResource("MyFirstProject.Image.iconsdelete.png");
        }

        public ObservableCollection<Movies> MovieCollection
        {
            get
            {
                return _movie;
            }
            set
            {
                _movie = value;
                OnPropertyChanged();
            }
        }

        private void LoadMovies()
        {
            IsBusy = true;

            try
            {
                _movie.Clear();
                foreach (var p in _movieList)
                {
                    _movie.Add(p);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public Command<Movies> DeleteCommand
        {
            get
            {
                return new Command<Movies>((Movies movie) =>
                {
                    MovieCollection.Remove(movie);
                });
            }
        }

        public Command AddCommand
        {
            get
            {
                return new Command(() =>
                {
                    Application.Current.MainPage.Navigation.PushAsync(new AddPersonView());

                    MessagingCenter.Subscribe<Movies>(this, "AddMovies", async (data) =>
                    {
                        MovieCollection.Add(data);

                        MessagingCenter.Unsubscribe<Movies>(this, "AddMovies");
                    });
                });
            }
        }

        public Command UpdateCommand
        {
            get
            {
                return new Command<Movies>((Movies mov) =>
                {
                    Application.Current.MainPage.Navigation.PushAsync(new EditPersonView(mov));

                    MessagingCenter.Subscribe<Movies>(this, "UpdateMovies", async (data) =>
                    {
                        var index = MovieCollection.IndexOf(mov);

                        MovieCollection.RemoveAt(index);

                        MovieCollection.Insert(index, data);

                        MessagingCenter.Unsubscribe<Movies>(this, "UpdateMovies");

                    });
                });
            }
        }
    }
}
