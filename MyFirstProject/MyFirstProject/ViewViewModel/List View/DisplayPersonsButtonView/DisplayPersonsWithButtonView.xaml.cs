using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.List_View.DisplayPersonsButtonView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DisplayPersonsWithButtonView : ContentPage
    {
        public DisplayPersonsWithButtonView()
        {
            InitializeComponent();
            this.BindingContext = new DisplayPersonsButtonViewModel();
        }
    }
}