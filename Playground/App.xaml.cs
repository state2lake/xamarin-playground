using System;
using Playground.Service;
using Playground.Service.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Playground
{
    public partial class App : Application
    {
        public static UserItemManager UserManager { get; private set; }

        public App()
        {
            InitializeComponent();

            UserManager = new UserItemManager(new RestService());
            MainPage = new NavigationPage(new MainPage());
        }
        static TodoItemDatabase database;
        public static TodoItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new TodoItemDatabase();
                }
                return database;
            }
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
