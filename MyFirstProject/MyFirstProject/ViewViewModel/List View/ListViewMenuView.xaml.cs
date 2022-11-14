
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.List_View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewMenuView : ContentPage
    {
        public ListViewMenuView()
        {
            InitializeComponent();
            this.BindingContext = new ListViewViewModel();
        }
    }
}