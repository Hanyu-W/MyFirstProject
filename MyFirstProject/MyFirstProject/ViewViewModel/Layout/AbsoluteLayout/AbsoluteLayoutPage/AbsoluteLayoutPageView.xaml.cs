using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Layout.AbsoluteLayout.AbsoluteLayoutPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AbsoluteLayoutPageView : ContentPage
    {
        public AbsoluteLayoutPageView()
        {
            InitializeComponent();
            this.BindingContext = new AbsoluteLayoutPageViewModel();
        }
    }
}