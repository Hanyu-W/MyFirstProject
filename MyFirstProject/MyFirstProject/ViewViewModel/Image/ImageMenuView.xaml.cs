
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Image
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageMenuView : ContentPage
    {
        public ImageMenuView()
        {
            InitializeComponent();
            this.BindingContext = new ImageViewModel();
        }
    }
}