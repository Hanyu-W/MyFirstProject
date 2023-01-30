using MyFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Controls.DatePickerVM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatePickerVMView : ContentPage
    {
        public DateTime _startDateSelected { get; set; }

        public DateTime _ostartDateSelected { get; set; }

        public DateTime _endDateSelected { get; set; }

        public DateTime _oendDateSelected { get; set; }


        public DatePickerVMView()
        {
            InitializeComponent();
            this.BindingContext = new DatePickerVMViewModel();
        }

        private void StartDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            var start = (DatePickerVMViewModel)BindingContext;
            start.StartDate = e.NewDate;

            _startDateSelected = e.NewDate;
            _ostartDateSelected = e.OldDate;
        }

        private void EndDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            var end = (DatePickerVMViewModel)BindingContext;
            end.EndDate = e.NewDate;

            _endDateSelected = e.NewDate;
            _oendDateSelected = e.OldDate;
        }
    }
}