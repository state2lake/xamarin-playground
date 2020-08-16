using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Playground.Views;
using Xamarin.Forms;

namespace Playground
{
    
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        private async void Signup_Button_Clicked(object sender, EventArgs e)
        {
           
            await Navigation.PushAsync(new SignupUserPage());
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            if(usernameEntry != null)
            {
                label.Text = "Hello " + usernameEntry.Text + "!";
            }

            await Navigation.PushAsync(new LoginInfoPage());
        }

        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModel();
           
        }
    }
}
