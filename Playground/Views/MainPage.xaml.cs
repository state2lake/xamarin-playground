using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Playground.Models;
using Playground.Views;
using SQLite;
using Xamarin.Forms;

namespace Playground
{
    
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        MainPageViewModel _mainPageViewModel;
        TodoItemDatabase _todoItemDatabase = new TodoItemDatabase();


        private async void Signup_Button_Clicked(object sender, EventArgs e)
        {
                await Navigation.PushAsync(new SignupUserPage());
        }

        private async void Login_Button_Clicked(object sender, EventArgs e)
        {
                await Navigation.PushAsync(new HomePage());
        }


        //private async void Database_Button_Clicked(object sender, EventArgs e)
        //{
        //    using (SQLiteConnection conn = new SQLiteConnection("TodoSQLite.db3"))
        //    {
        //        conn.CreateTable<UserLogin>();
        //        var rowsAdded = conn.Table<UserLogin>().ToList();
        //        Console.WriteLine(rowsAdded[0].password.ToString());
        //    }
        //}
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModel();


        }
    }
}
