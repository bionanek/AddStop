using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddSpot.Enums;
using AddStop.Models;
using AddStop.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AddStop.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyAdvertisementsView : ContentPage
	{
	    public INavigation Navigation { get; set; }
	    public ObservableCollection<Advertisement> list { get; set; }


        public MyAdvertisementsView (INavigation nav)
        {
            Navigation = nav;
			InitializeComponent ();
		    BindingContext = new MyAdvertisementsViewModel(Navigation);

            list = new ObservableCollection<Advertisement>()
            {
                new Advertisement(){ Place = "Kraków", RequiredAge = 21, NumberOfPeople = 2, RequiredSex = Sex.FEMALE, Content = "Hey everyone! I’m looking for a mate for an awesome trip to see some of Eastern Europe. I have 2 weeks of spare time and I want to spend it as good as possible - hitchhiking as always! Let’s do it together ;)", When = "21.07.2016 - 25.08.2016",src = "https://us.v-cdn.net/5019960/uploads/userpics/167/nNRIE2WKMOXCZ.jpg"}
            };

            listView.ItemsSource = list;

        }
	}
}