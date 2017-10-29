using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace AddStop.ViewModels
{
    class AdvertisementsViewModel : INotifyPropertyChanged
    {
        private INavigation Navigation { get; set; }
        public AdvertisementsViewModel(INavigation nav)
        {
            this.Navigation = nav;
            test = "test";
        }

        private string _test;

        public string test
        {
            get { return _test; }
            set
            {
                _test = value;
                OnPropetyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropetyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
