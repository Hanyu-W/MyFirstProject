using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModel.Controls.PickerResult;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Controls.PickerVM
{
    class PickerVMViewModel : BaseViewModel
    {
        public ICommand OnSubmitClicked { get; set; }

        public ImageSource SubmitButton { get; set; }

        public List<string> PersonList { get; set; }

        public string SelectedItem { get; set; }

        public int SelectedIndex { get; set; }

        public List<Person> AllPersons { get; set; }

        public PickerVMViewModel()
        {
            Title = Titles.PickerVMTitle;
            SubmitButton = ImageSource.FromResource("MyFirstProject.Image.buttonsubmit.png");
            this.GetPersonList();
            OnSubmitClicked = new Command(OnSubmitClickedAsync);
        }

        private async void OnSubmitClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new PickerResultView(SelectedItem, AllPersons[SelectedIndex].Image));
        }

        private void GetPersonList()
        {
            AllPersons = Person.getNamesWithPicture();

            var persons = Person.getNames();

            PersonList = (from p in persons select p.Name).ToList();
        }        
    }
}
