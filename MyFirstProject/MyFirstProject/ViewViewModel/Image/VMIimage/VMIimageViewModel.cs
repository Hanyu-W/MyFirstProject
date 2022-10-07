using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ViewViewModel.Image.VMIimage
{
    class VMIimageViewModel : BaseViewModel
    {
        string srcImg = string.Empty;
        public VMIimageViewModel()
        {
            Title = Titles.VMIimageTitle;
            SrcImg = Images.Image1;
        }
        public string SrcImg
        {
            get { return srcImg; }
            set { SetProperty(ref srcImg, value); }
        }
    }
}
