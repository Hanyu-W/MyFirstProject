﻿using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;

namespace MyFirstProject.ViewViewModel.List_View.DisplayPersons
{
    class DisplayPersonsViewModel : BaseViewModel
    {
        public ObservableCollection<Person> PersonsCollection { get; }

        public List<Person> _personList;

        public DisplayPersonsViewModel()
        {
            Title = Titles.DisplayPersonsTitle;
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
            catch(Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
