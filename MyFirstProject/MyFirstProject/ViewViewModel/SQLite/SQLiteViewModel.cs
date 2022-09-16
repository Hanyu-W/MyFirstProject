using System;
using System.Collections.Generic;
using System.Text;
using MyFirstProject.Models;
using MyFirstProject.ViewModels;

namespace MyFirstProject.ViewViewModel.SQLite
{
    class SQLiteViewModel : BaseViewModel
    {
        public SQLiteViewModel()
        {
            Title = Titles.SQLiteMenuTitle;
        }
    }
}
