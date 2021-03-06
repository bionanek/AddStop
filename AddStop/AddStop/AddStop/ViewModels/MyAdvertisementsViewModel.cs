﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AddStop.ViewModels
{
    class MyAdvertisementsViewModel : INotifyPropertyChanged
    {
        public INavigation Navigation { get; set; }

        public MyAdvertisementsViewModel(INavigation nav)
        {
            this.Navigation = nav;
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
