using MyFirstProject.ViewViewModel.Main;
using Xamarin.Forms;

namespace MyFirstProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModel();
            this.BindingContext = new MainPageViewModel();
        }
    }
}
