using Xamarin.Forms;

namespace Vytas_Project
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "Datas.db";
        public static Datas database;
        public static Datas Database
        {
            get
            {
                if (database == null)
                {
                    database = new Datas(DATABASE_NAME);
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PreMainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
