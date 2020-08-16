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
        //TODO store this somewhere else 
        string dbName = "CustomersDb.db3";

        public SignupUserPage()
        {
            InitializeComponent();
        }
       
        private async void Save_Button_Clicked(object sender, EventArgs e)
        {
            
            
            if(string.IsNullOrEmpty(firstnameEntry.Text))
            {
                await DisplayAlert("", "Name", "Cancel");
            }
            User user = new User
            {
                firstName = firstnameEntry.Text,
                lastName = lastnameEntry.Text,
                email = emailEntry.Text,
                zipCode = zipEntry.Text,
                school = schoolEntry.Text
            };

            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.CreateTable<User>();
                int rowsAdded = conn.Insert(user);
            }
            //await Navigation.PushAsync(new SignupUserPage());
        }

    }
}
