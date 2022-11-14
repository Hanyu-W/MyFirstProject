
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.SQLite
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SQLiteMenuView : ContentPage
    {
        public SQLiteMenuView()
        {
            InitializeComponent();
            this.BindingContext = new SQLiteViewModel();
        }
    }
}