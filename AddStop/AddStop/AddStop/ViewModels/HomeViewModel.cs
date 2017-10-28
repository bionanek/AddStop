using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace AddStop.ViewModels
{
    class HomeViewModel : INotifyPropertyChanged
    {

        public HomeViewModel()
        {
        }


        private bool _isVisableLoading;

        public bool IsVisableLoading
        {
            get { return _isVisableLoading; }
            set
            {
                _isVisableLoading = value;
                OnPropetyChanged();
            }
        }


        public Command SendQuestionCommand
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
