
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Image.ActivityImage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivityImageView : ContentPage
    {
        public ActivityImageView()
        {
            InitializeComponent();
            this.BindingContext = new ActivityImageViewModel();
        }
    }
}