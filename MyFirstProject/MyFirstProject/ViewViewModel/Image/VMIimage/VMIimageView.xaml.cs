
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Image.VMIimage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VMIimageView : ContentPage
    {
        public VMIimageView()
        {
            InitializeComponent();
            this.BindingContext = new VMIimageViewModel();
        }
    }
}