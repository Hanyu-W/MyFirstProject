﻿
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Layout.Relative
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RelativeView : ContentPage
    {
        public RelativeView()
        {
            InitializeComponent();
            this.BindingContext = new RelativeViewModel();
        }
    }
}