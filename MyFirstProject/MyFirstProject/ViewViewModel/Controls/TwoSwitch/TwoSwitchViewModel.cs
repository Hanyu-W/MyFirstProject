using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ViewViewModel.Controls.TwoSwitch
{
    class TwoSwitchViewModel : BaseViewModel
    {
        public Boolean Switch1 { get; set; }

        public Boolean Switch2 { get; set; }

        public TwoSwitchViewModel()
        {
            Title = Titles.TwoSwitchTitle;
            Switch1 = true;
            Switch2 = false;
        }     
    }
}
