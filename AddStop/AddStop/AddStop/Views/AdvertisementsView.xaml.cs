using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddSpot.Enums;
using AddStop.CustomControlls;
using AddStop.Models;
using AddStop.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AddStop.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AdvertisementsView : ContentPage
	{
	    public ObservableCollection<Advertisement> list { get; set; }
        private INavigation Navigation { get; set; }
		public AdvertisementsView (INavigation nav)
		{
		    Navigation = nav;
            InitializeComponent();
		    BindingContext = new AdvertisementsViewModel(Navigation);
            list = new ObservableCollection<Advertisement>()
            {
                new Advertisement(){ Place = "Kraków", RequiredAge = 21, NumberOfPeople = 2, RequiredSex = Sex.FEMALE, Content = "Trip to Hungary! I have no car -> we do AddStop! Hitchhiking is the only kind of trasport I believe in. I love rock music, talking about StarWars and having fun in new places. Willing to go? Sign in and let’s do this!", When = "21.07.2016 - 25.08.2016",src = "https://us.v-cdn.net/5019960/uploads/userpics/167/nNRIE2WKMOXCZ.jpg"},
                new Advertisement(){ Place = "Katowice", RequiredAge = 18,  NumberOfPeople = 3,RequiredSex = Sex.MALE, Content = "Okay, so this is my first hitchhike trip ever and I want to do this with amazing person. If you feel like you’re the one that’s gonna spend this awesome time together with me just let me know! ", When = "16.05.2016 - 20.05.2016", src = "https://us.v-cdn.net/5019960/uploads/userpics/123/nGMH7CNV8ZTVP.png"},
                new Advertisement(){ Place = "Wrocław", RequiredAge = 18, NumberOfPeople = 2, RequiredSex = Sex.FEMALE, Content = "I love travels and photography, but not only. Let’s get to know each other! Waiting for awesome people", When = "30.09.2016 - 05.10.2016",src = "https://us.v-cdn.net/5019960/uploads/userpics/851/nZN50XKL6T074.jpg"},
                new Advertisement(){ Place = "Warszawa", RequiredAge = 25, NumberOfPeople = 2, RequiredSex = Sex.FEMALE, Content = "Hey everyone! I’m looking for a mate for an awesome trip to see some of Eastern Europe. I have 2 weeks of spare time and I want to spend it as good as possible - hitchhiking as always! Let’s do it together", When = "21.07.2016 - 25.08.2016", src = "https://i.pinimg.com/736x/28/c0/ef/28c0ef82b165f2b2c12e98106d602a37--girl-face-woman-face.jpg"},
                new Advertisement(){ Place = "Londyn", RequiredAge = 30,  NumberOfPeople = 2,RequiredSex = Sex.MALE, Content = "Hey everyone! I’m looking for a mate for an awesome trip to see some of Eastern Europe. I have 2 weeks of spare time and I want to spend it as good as possible - hitchhiking as always! Let’s do it together", When = "28.04.2016 - 21.05.2016", src="https://i.pinimg.com/736x/f3/ab/69/f3ab696a38d266cab6331a38a43fef96--dark-hair-blue-eyes-black-hair-and-freckles.jpg"},
                new Advertisement(){ Place = "Berlin", RequiredAge = 18,  NumberOfPeople = 2,RequiredSex = Sex.FEMALE, Content = "I love travels and photography, but not only. Let’s get to know each other! Waiting for awesome people", When = "21.07.2016 - 25.07.2016", src = "https://store.halloweenmakeup.com/blog/wp-content/uploads/2014/07/MG_6709-682x1024.jpg"},

            };
		    listView.ItemsSource = list;
		}
	}
}