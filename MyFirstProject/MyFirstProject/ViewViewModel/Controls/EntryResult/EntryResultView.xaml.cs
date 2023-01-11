using MyFirstProject.ViewViewModel.Controls.EntryResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Controls.EntryPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryResultView : ContentPage
    {
        public EntryResultView(string entryresult)
        {
            InitializeComponent();
            this.BindingContext = new EntryResultViewModel();

            ResultText.Text = entryresult;
        }
    }
}