using MyFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.SQLite.Vacations
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SQLiteAddVacationView : ContentPage
    {
        public SQLiteAddVacationView(Vacation vacation)
        {
            InitializeComponent();
            this.BindingContext = new SQLiteAddVacationViewModel(vacation);
        }
    }
}