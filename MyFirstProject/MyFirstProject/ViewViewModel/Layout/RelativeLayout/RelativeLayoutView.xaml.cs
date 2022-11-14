
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Layout.RelativeLayout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RelativeLayoutView : ContentPage
    {
        public RelativeLayoutView()
        {
            InitializeComponent();
            this.BindingContext = new RelativeLayoutViewModel();
        }
    }
}