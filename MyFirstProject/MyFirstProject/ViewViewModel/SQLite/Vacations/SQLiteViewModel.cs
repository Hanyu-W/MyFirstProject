﻿using MyFirstProject.Models;
using MyFirstProject.Patterns.Repositories;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.SQLite.Vacations
{
    public class SQLiteViewModel : BaseViewModel
    {
        private ObservableCollection<Vacation> _vacationCollection;

        public ObservableCollection<Vacation> VacationCollection
        {
            get { return _vacationCollection;  }
            set
            {
                _vacationCollection = value;
                OnPropertyChanged();
            }
        }

        public SQLiteViewModel()
        {
            Title = Titles.SQLiteTitle;
            VacationCollection = new ObservableCollection<Vacation>();
            Task.Run(async () => await RefreshVacationListData());

            MessagingCenter.Subscribe<object>(this, "RefreshData", async (sender) =>
            {
                await RefreshVacationListData();
            });
        }

        private async Task RefreshVacationListData()
        {
            var vacation = DependencyService.Get<ISQLite>().GetVacation();
            VacationCollection = new ObservableCollection<Vacation>(vacation);
        }

        public Command AddCommand
        {
            get
            {
                return new Command<Vacation>((Vacation vacation) =>
                {
                    Application.Current.MainPage.Navigation.PushAsync(new SQLiteAddVacationView(vacation));

                    MessagingCenter.Subscribe<Vacation>(this, "AddVacation", async (data) =>
                    {
                        await RefreshVacationListData();

                        MessagingCenter.Unsubscribe<Vacation>(this, "AddVacation");
                    });
                });
            }
        }

        public Command<Vacation> DeleteCommand
        {
            get
            {
                return new Command<Vacation>((Vacation vacation) =>
                {
                    DependencyService.Get<ISQLite>().DeleteVacation(vacation.ID);
                    VacationCollection.Remove(vacation);
                });
            }
        }
    }
}
