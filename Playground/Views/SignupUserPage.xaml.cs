using System;
using System.Collections.Generic;
using Playground.Models;
using SQLite;
using Xamarin.Forms;
using SQLite;
namespace Playground.Views
{
    public partial class SignupUserPage : ContentPage
    {
        TodoItemDatabase _todoItemDatabase = new TodoItemDatabase();

        //TODO store this somewhere else
        string dbName = "CustomersDb.db3";

        public SignupUserPage()
        {
            InitializeComponent();
        }
       
        private async void Save_Button_Clicked(object sender, EventArgs e)
        {


            //if (string.IsNullOrEmpty(firstnameEntry.Text))
            //{
            //    await DisplayAlert("", "Name", "Cancel");
            //}
            //else
            //{
            //    User user = new User
            //    {
            //        firstName = firstnameEntry.Text,
            //        lastName = lastnameEntry.Text,
            //        email = emailEntry.Text,
            //        username = usernameENtry.Text,
            //        password = passwordEntry.Text
            //    };
            //    UserLogin userLogin = new UserLogin
            //    {
            //        username = usernameENtry.Text,
            //        password = passwordEntry.Text
            //    };

            //await _todoItemDatabase.SaveItemAsync(userLogin);

            var todoItem = (User)BindingContext;
            await App.UserManager.SaveTaskAsync(todoItem);
            await Navigation.PushAsync(new MainPage());
            //}
            //await Navigation.PushAsync(new SignupUserPage());
        }

    }
}
