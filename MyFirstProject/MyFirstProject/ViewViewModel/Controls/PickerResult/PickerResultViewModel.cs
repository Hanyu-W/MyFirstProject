using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Controls.PickerResult
{
    class PickerResultViewModel : BaseViewModel
    {
        public ImageSource ImageSrc { get; set; }

        private string _pickerSelection;

        public PickerResultViewModel(string name, ImageSource imgsrc)
        {
            Title = Titles.PickerResultTitle;
            ImageSrc = imgsrc;
            _pickerSelection = name;
        }

        public string PickerSelection
        {
            get { return _pickerSelection; }
        }
    }
}
