using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;

namespace MyFirstProject.ViewViewModel.List_View.DisplayPersonsImage
{
    class DisplayPersonsImageViewModel : BaseViewModel
    {
        public ObservableCollection<Person> PersonsCollection { get; }

        public List<Person> _personList;

        public DisplayPersonsImageViewModel()
        {
            Title = Titles.DisplayImageTitle;
            PersonsCollection = new ObservableCollection<Person>();
            _personList = Person.getNamesWithPicture();
            this.loadPersons();
            foreach(var p in PersonsCollection)
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
    }
}
