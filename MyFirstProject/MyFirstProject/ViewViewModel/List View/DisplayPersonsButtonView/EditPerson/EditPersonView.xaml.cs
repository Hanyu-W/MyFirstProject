using MyFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.List_View.DisplayPersonsButtonView.EditPerson
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditPersonView : ContentPage
    {
        public EditPersonView(Movies mov)
        {
            InitializeComponent();
            this.BindingContext = new EditPersonViewModel();
            MovieName.Text = mov.Name;
        }
    }
}