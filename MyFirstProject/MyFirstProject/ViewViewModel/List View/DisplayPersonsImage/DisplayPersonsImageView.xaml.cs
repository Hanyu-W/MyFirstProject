
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.List_View.DisplayPersonsImage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DisplayPersonsImageView : ContentPage
    {
        public DisplayPersonsImageView()
        {
            InitializeComponent();
            this.BindingContext = new DisplayPersonsImageViewModel();
        }
    }
}