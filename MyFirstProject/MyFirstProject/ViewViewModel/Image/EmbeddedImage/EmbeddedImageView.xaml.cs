
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Image.EmbeddedImage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmbeddedImageView : ContentPage
    {
        public EmbeddedImageView()
        {
            InitializeComponent();
            this.BindingContext = new EmbeddedImageViewModel();
        }
    }
}