using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Image.VMIimage
{
    class VMIimageViewModel : BaseViewModel
    {
        public ImageSource ImageSrc { get; set; }

        public VMIimageViewModel()
        {
            Title = Titles.VMIimageTitle;
            ImageSrc = this.SetImageSrc();
        }
        
        private ImageSource SetImageSrc()
        {
            var imgsrc = new UriImageSource { Uri = new Uri(Images.Image1) };
            imgsrc.CachingEnabled = false;
            imgsrc.CacheValidity = TimeSpan.FromHours(1);

            return imgsrc;
        }
    }
}
