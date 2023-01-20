using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Controls.PickerResult
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PickerResultView : ContentPage
    {
        public PickerResultView(string name, ImageSource imgsrc)
        {
            InitializeComponent();
            BindingContext = new PickerResultViewModel(name, imgsrc);
        }
    }
}