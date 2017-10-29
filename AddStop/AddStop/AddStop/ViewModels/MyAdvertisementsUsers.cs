using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace AddStop.ViewModels
{
    class MyAdvertisementsUsers : INotifyPropertyChanged
    {

        public MyAdvertisementsUsers()
        {
        }


        public Command SendMessageCommand
        {
            get
            {
                return new Command(async () =>
                {
                    try
                    {

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
