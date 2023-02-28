using MyFirstProject.Patterns.Repositories;
using Xamarin.Forms;

namespace MyFirstProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //SQLite
            DependencyService.Get<ISQLite>().GetConnectionWithCreateDatabase();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
