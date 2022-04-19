using LocalDatabaseSample.Data;
using LocalDatabaseSample.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LocalDatabaseSample
{
    public partial class App : Application
    {

        private static Database database;

        public static Database Database
        {
            get
            {
                if(database == null)
                {
                    database = new Database(DependencyService.Get<IFileHelper>().GetLocalFilePath("StallDB"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
