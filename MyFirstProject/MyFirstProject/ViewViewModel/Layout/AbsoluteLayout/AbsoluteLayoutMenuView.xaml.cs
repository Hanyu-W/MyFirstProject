
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Layout.AbsoluteLayout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AbsoluteLayoutMenuView : ContentPage
    {
        public AbsoluteLayoutMenuView()
        {
            InitializeComponent();
            this.BindingContext = new AbsoluteLayoutViewModel();
        }
    }
}