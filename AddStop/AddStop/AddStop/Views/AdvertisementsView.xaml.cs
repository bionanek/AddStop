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
                new Advertisement(){ Place = "Kraków", RequiredAge = 21, NumberOfPeople = 2, RequiredSex = Sex.FEMALE, Content = "siema tu Fifi, lubie kluski na parze a do tego ssanko kutaska po obiadku, co powiecie na jakies wspolne kutaszonko w drodze na mazury a potem do krakowa i jaki sextape w namiocku po ciemku z swiczuszka, ale musimy byc ostrozni hihihihi", When = "21.07.2016 - 25.08.2016",src = "https://us.v-cdn.net/5019960/uploads/userpics/167/nNRIE2WKMOXCZ.jpg"},
                new Advertisement(){ Place = "Katowice", RequiredAge = 18,  NumberOfPeople = 3,RequiredSex = Sex.MALE, Content = "TO JEST NASZ PRZYKŁADOWY OPIS", When = "16.05.2016 - 20.05.2016", src = "https://us.v-cdn.net/5019960/uploads/userpics/123/nGMH7CNV8ZTVP.png"},
                new Advertisement(){ Place = "Wrocław", RequiredAge = 18, NumberOfPeople = 2, RequiredSex = Sex.FEMALE, Content = "TO JEST NASZ PRZYKŁADOWY OPIS", When = "30.09.2016 - 05.10.2016",src = "https://us.v-cdn.net/5019960/uploads/userpics/851/nZN50XKL6T074.jpg"},
                new Advertisement(){ Place = "Warszawa", RequiredAge = 25, NumberOfPeople = 2, RequiredSex = Sex.FEMALE, Content = "TO JEST NASZ PRZYKŁADOWY OPIS", When = "21.07.2016 - 25.08.2016", src = "https://i.pinimg.com/736x/28/c0/ef/28c0ef82b165f2b2c12e98106d602a37--girl-face-woman-face.jpg"},
                new Advertisement(){ Place = "Londyn", RequiredAge = 30,  NumberOfPeople = 2,RequiredSex = Sex.MALE, Content = "TO JEST NASZ PRZYKŁADOWY OPIS", When = "28.04.2016 - 21.05.2016", src="https://i.pinimg.com/736x/f3/ab/69/f3ab696a38d266cab6331a38a43fef96--dark-hair-blue-eyes-black-hair-and-freckles.jpg"},
                new Advertisement(){ Place = "Berlin", RequiredAge = 18,  NumberOfPeople = 2,RequiredSex = Sex.FEMALE, Content = "TO JEST NASZ PRZYKŁADOWY OPIS", When = "21.07.2016 - 25.07.2016", src = "https://store.halloweenmakeup.com/blog/wp-content/uploads/2014/07/MG_6709-682x1024.jpg"},

            };
		    listView.ItemsSource = list;
		}
	}
}