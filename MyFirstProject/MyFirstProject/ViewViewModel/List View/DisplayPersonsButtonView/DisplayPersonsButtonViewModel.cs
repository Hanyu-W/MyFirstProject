using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModel.List_View.DisplayPersonsButtonView.AddPerson;
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
        private ObservableCollection<Person> _person;

        private List<Person> _personList;

        public DisplayPersonsButtonViewModel()
        {
            Title = Titles.DisplayButtonTitle;
            PersonCollection = new ObservableCollection<Person>();
            _personList = Person.getNames();
            this.LoadPersons();
        }
        
        public ObservableCollection<Person> PersonCollection
        {
            get
            {
                return _person;
            }
            set
            {
                _person = value;
                OnPropertyChanged();
            }
        }

        private void LoadPersons()
        {
            IsBusy = true;

            try
            {
                _person.Clear();
                foreach (var p in _personList)
                {
                    _person.Add(p);
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

        public Command<Person> DeleteCommand
        {
            get
            {
                return new Command<Person>((Person pop) =>
                {
                    PersonCollection.Remove(pop);
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

                    MessagingCenter.Subscribe<Person>(this, "AddPersons", async (data) =>
                    {
                        PersonCollection.Add(data);

                        MessagingCenter.Unsubscribe<Person>(this, "AddPersons");
                    });
                });
            }
        }
    }
}
