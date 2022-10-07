using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Image.URIimage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class URIimageView : ContentPage
    {
        public URIimageView()
        {
            InitializeComponent();
            this.BindingContext = new URIimageViewModel();
        }
    }
}