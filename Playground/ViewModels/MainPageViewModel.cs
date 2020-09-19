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

        private bool _isHelloVisible = true;
        public bool IsHelloVisible
        {
            get
            {
                return _isHelloVisible;
            }
            set
            {
                _isHelloVisible = value;
                OnPropertyChanged();
            }
        }
        private bool _isLabelVisible;
        public bool IsLabelVisible
        {
            get
            {
                return _isLabelVisible;
            }
            set
            {
                _isLabelVisible = value;
                OnPropertyChanged();
            }
        }
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
        public ICommand CheckboxTapped => new Command(async () => await CheckboxTappedAsync());
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
        async Task CheckboxTappedAsync()
        {
            IsLabelVisible = true;
            IsHelloVisible = false;
        }
        async Task SignupButtonClickedAsync()
        {
            //await Navigation.PushAsync(new LoginInfoPage());
        }
        public bool IsEntryFieldsNullOrEmpty(string u, string p)
        {
            if(string.IsNullOrEmpty(u) && string.IsNullOrEmpty(p))
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
    }
}
