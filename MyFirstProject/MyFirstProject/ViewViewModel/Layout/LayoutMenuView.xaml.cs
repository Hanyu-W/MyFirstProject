
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Layout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LayoutMenuView : ContentPage
    {
        public LayoutMenuView()
        {
            InitializeComponent();
            this.BindingContext = new LayoutViewModel();
        }
    }
}