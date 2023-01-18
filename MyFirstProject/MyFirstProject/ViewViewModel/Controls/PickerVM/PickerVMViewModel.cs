using MyFirstProject.Models;
using MyFirstProject.ViewModels;
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

        public List<String> MovieList { get; set; }

        public PickerVMViewModel()
        {
            Title = Titles.PickerVMTitle;
            SubmitButton = ImageSource.FromResource("MyFirstProject.Image.buttonsubmit.png");
            this.GetMovieList();

        }

        private void GetMovieList()
        {
            var movies = Movies.getNames();

            MovieList = (from m in movies select m.Name).ToList();
        }
        
    }
}
