using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;

namespace MyFirstProject.ViewViewModel.List_View.DisplayPersonsButtonView
{
    class DisplayPersonsButtonViewModel : BaseViewModel
    {
        string subtitle = string.Empty;

        private ObservableCollection<Person> _person;

        private List<Person> _personList;

        public DisplayPersonsButtonViewModel()
        {
            Title = Titles.DisplayButtonTitle;
            Subtitle = Titles.DisplayButtonSubtitle;
            PersonCollection = new ObservableCollection<Person>();
            _personList = Person.getNames();
            this.loadPersons();
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

        private void loadPersons()
        {
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
        }

        public string Subtitle
        {
            get { return subtitle; }
            set { SetProperty(ref subtitle, value); }
        }
    }
}
