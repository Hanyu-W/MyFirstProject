using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Controls.TwoSwitch
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TwoSwitchView : ContentPage
    {
        public TwoSwitchView()
        {
            InitializeComponent();
            BindingContext = new TwoSwitchViewModel();
        }
    }
}