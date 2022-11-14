
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Layout.AbsolutePage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AbsolutePageView : ContentPage
    {
        public AbsolutePageView()
        {
            InitializeComponent();
            this.BindingContext = new AbsolutePageViewModel();
        }
    }
}