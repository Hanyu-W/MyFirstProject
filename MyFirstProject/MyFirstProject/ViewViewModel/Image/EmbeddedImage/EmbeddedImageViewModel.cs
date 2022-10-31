using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Image.EmbeddedImage
{
    class EmbeddedImageViewModel : BaseViewModel
    {
        public ImageSource EmbeddedImageSrc { get; set; }

        public EmbeddedImageViewModel()
        {
            Title = Titles.EmbeddedImageTitle;
            this.GetEmbeddedImageSrc();
        }

        private void GetEmbeddedImageSrc()
        {
            EmbeddedImageSrc = ImageSource.FromResource("MyFirstProject.Image.azusa-nakano.jpg");
            
        }
    }
}
