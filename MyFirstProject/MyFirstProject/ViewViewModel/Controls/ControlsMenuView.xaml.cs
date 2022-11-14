
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ControlsMenuView : ContentPage
    {
        public ControlsMenuView()
        {
            InitializeComponent();
            this.BindingContext = new ControlViewModel();
        }
    }
}