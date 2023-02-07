using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Controls.DatePickerVM
{
    class DatePickerVMViewModel : BaseViewModel
    {
        public ImageSource SubmitButton { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime MaxDate { get; set; }

        public DateTime MinDate { get; set; }

        public ICommand ButtonSelected { get; set; }

        public Boolean isDelta { get; set; }

        public DatePickerVMViewModel()
        {
            Title = Titles.DatePickerVMTitle;
            SubmitButton = ImageSource.FromResource("MyFirstProject.Image.buttonsubmit.png");
            ButtonSelected = new Command(ButtonSelectedAsync);
            MinDate = new DateTime(2023, 1, 1);
            MaxDate = new DateTime(2023, 12, 31);
        }

        private async void ButtonSelectedAsync()
        {
            string msg = "";

            if(StartDate.Subtract(MaxDate) > TimeSpan.Zero || StartDate.Subtract(MinDate) < TimeSpan.Zero)
            {
                msg = "Error! Start Date is out of bounds";
            }

            else if (EndDate.Subtract(MaxDate) > TimeSpan.Zero || EndDate.Subtract(MinDate) < TimeSpan.Zero)
            {
                msg = "Error! End Date is out of bounds";
            }

            else if (EndDate < StartDate)
            {
                //EndDate < StartDate = StartDate > EndDate, so we only need one comparison
                msg = "Error! End Date can't be before Start Date";
            }
            
            else if (isDelta)
            {
                msg = "The start date selected is: " + StartDate.ToShortDateString() + "," +
                       "The end date selected is: " + EndDate.ToShortDateString() + "," + "The difference in days is " + EndDate.Subtract(StartDate).Days;
            }

            else
            {
                msg = "The start date selected is: " + StartDate.ToShortDateString() + "," +
                       "The end date selected is: " + EndDate.ToShortDateString();
            }

            await Application.Current.MainPage.DisplayAlert(Titles.DatePickerVMTitle, msg, "Ok");
        }
    }
}
