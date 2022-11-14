using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MyFirstProject.ViewViewModel.List_View.DisplayPersons
{
    class DisplayPersonsViewModel : BaseViewModel
    {
        string subtitle = string.Empty;

        public ObservableCollection<Person> PersonsCollection { get; }

        private List<Person> _personList;

        public DisplayPersonsViewModel()
        {
            Title = Titles.DisplayPersonsTitle;
            Subtitle = Titles.DisplayPersonsSubtitle;
            PersonsCollection = new ObservableCollection<Person>();
            _personList = Person.getNames();
            this.loadPersons();
        }

        private void loadPersons()
        {
            try
            {
                PersonsCollection.Clear();
                foreach (var p in _personList)
                {
                    PersonsCollection.Add(p);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public string Subtitle
        {
            get { return subtitle; }
            set { SetProperty(ref subtitle, value); }
        }
    }
}
