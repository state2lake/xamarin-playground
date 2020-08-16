using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Playground.Models;
using Playground.Views;
using Xamarin.Forms;

namespace Playground
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        protected readonly INavigationService NavigationService;
        public IList<Position> Positions { get; set; }

        private string _favoriteDeviceText;
        public string FavoriteDeviceText
        {
            get { return _favoriteDeviceText; }

            set
            {
                _favoriteDeviceText = value;
                OnPropertyChanged();
            }

        }
        private string _usernameEntryText;
        public string UsernameEntryText
        {
            get { return _usernameEntryText; }

            set
            {
                _usernameEntryText = value;
                OnPropertyChanged();
            }

        }
        private string _passwordEntryText;
        public string PasswordEntryText
        {
            get { return _passwordEntryText; }

            set
            {
                _passwordEntryText = value;
                OnPropertyChanged();
            }

        }

        public ICommand SignupButtonClicked => new Command(async () => await SignupButtonClickedAsync());

        public void FavortieDeviceStuff()
        {
            if (_usernameEntryText != null)
            {
                    _favoriteDeviceText = "Your favorite device is " + _usernameEntryText;
            }
            _favoriteDeviceText = "Your favorite device is " + _usernameEntryText;
        }
       

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public MainPageViewModel()
        {
            OnPropertyChanged();
        }

        async Task SignupButtonClickedAsync()
        {
            //await Navigation.PushAsync(new LoginInfoPage());
        }
    }
}
