using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Image.ActivityImage
{
    class ActivityImageViewModel : BaseViewModel
    {
        public ImageSource ActivityImageSrc { get; set; }

        public ActivityImageViewModel()
        {
            Title = Titles.ActivityImageTitle;
            this.GetActitivtyImageSrc();
        }

        private void GetActitivtyImageSrc()
        {
            ActivityImageSrc = ImageSource.FromResource("MyFirstProject.Image.azusa-nakano.jpg");
        }
    }
}
