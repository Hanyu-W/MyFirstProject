using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModel.Image.URIimage;
using MyFirstProject.ViewViewModel.Image.VMIimage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Image
{
    class ImageViewModel : BaseViewModel
    {
        public ICommand OnURIimageClicked { get; set; }
        public ICommand OnVMIimageClicked { get; set; }
        public ImageViewModel()
        {
            Title = Titles.ImageMenuTitle;
            OnURIimageClicked = new Command(OnURIimageClickedAsync);
            OnVMIimageClicked = new Command(OnVMIimageClickedAsync);
        }

        private async void OnURIimageClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new URIimageView());
        }

        private async void OnVMIimageClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new VMIimageView());
        }
    }
}
