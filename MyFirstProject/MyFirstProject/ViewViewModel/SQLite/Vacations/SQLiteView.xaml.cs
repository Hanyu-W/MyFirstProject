﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.SQLite.Vacations
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SQLiteView : ContentPage
    {
        public SQLiteView()
        {
            InitializeComponent();
            this.BindingContext = new SQLiteViewModel();
        }
    }
}