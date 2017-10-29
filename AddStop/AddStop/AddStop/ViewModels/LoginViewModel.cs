using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using AddStop.Models;
using Xamarin.Forms;

namespace AddStop.ViewModels
{
    class LoginViewModel : INotifyPropertyChanged
    {
        public INavigation Navigation { get; set; }

        public LoginViewModel(INavigation nav)
        {
            this.Navigation = nav;
            opacity = 0.5;
            login = "";
            password = "";
            canLogin = false;

        }

        private bool _canLogin;

        public bool canLogin
        {
            get { return _canLogin; }
            set
            {
                _canLogin = value;

            }
        }

        private string _login;

        public string login
        {
            get{return _login;}
            set
            {
                _login = value;
                changedText();
            }
        }

        private string _password;

        public string password
        {
            get{return _password;}
            set
            {
                _password = value;
                changedText();
            }
        }

        private void changedText()
        {
            try
            {
                
                if (password.Length > 6 && login.Length > 6)
                {
                    opacity = 1.0;
                    canLogin = true;
                }
                else
                {
                    opacity = 0.5;
                    canLogin = false;
                }
            }
            catch(Exception ex) { }
            
        }

        

        private double _opacity;


        public double opacity
        {
            get { return _opacity; }
            set
            {
                _opacity = value;
                OnPropetyChanged();
            }
        }

        public Command SignIn
        {
            get
            {
                return new Command(async () =>
                {
                    try
                    {
                        if (opacity >= 1.0)
                        {
                            await Navigation.PushModalAsync(new Home());
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropetyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
