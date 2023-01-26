using MyFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Controls.DatePickerXAML
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatePickerXAMLView : ContentPage
    {
        public DateTime _startDateSelected { get; set; }

        public DateTime _ostartDateSelected { get; set; }

        public DateTime _endDateSelected { get; set; }

        public DateTime _oendDateSelected { get; set; }

        public DatePickerXAMLView()
        {
            InitializeComponent();
            this.BindingContext = new DatePickerXAMLViewModel();
        }

        private void StartDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            _startDateSelected = e.NewDate;
            _ostartDateSelected = e.OldDate;
        }

        private void EndDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            _endDateSelected = e.NewDate;
            _oendDateSelected = e.OldDate;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string msg = "The start date selected is: " + _startDateSelected.ToShortDateString() + "," +
                         "The end date selected is: " + _endDateSelected.ToShortDateString();

            await Application.Current.MainPage.DisplayAlert(Titles.DatePickerXAMLTitle, msg, "Ok");
        }
    }
}