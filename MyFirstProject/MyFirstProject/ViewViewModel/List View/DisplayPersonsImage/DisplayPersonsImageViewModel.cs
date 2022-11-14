using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MyFirstProject.ViewViewModel.List_View.DisplayPersonsImage
{
    class DisplayPersonsImageViewModel : BaseViewModel
    {
        string subtitle = string.Empty;

        public ObservableCollection<Person> PersonsCollection { get; }

        private List<Person> _personList;

        public DisplayPersonsImageViewModel()
        {
            Title = Titles.DisplayImageTitle;
            Subtitle = Titles.DisplayImageSubtitle;
            PersonsCollection = new ObservableCollection<Person>();
            _personList = Person.getNamesWithPicture();
            this.loadPersons();
            foreach (var p in PersonsCollection)
            {
                Debug.WriteLine(p);
            }

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
