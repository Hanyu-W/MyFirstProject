
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.List_View.DisplayPersons
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DisplayPersonsView : ContentPage
    {
        public DisplayPersonsView()
        {
            InitializeComponent();
            this.BindingContext = new DisplayPersonsViewModel();
        }
    }
}