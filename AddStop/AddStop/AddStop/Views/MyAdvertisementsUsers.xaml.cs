using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddStop.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AddStop.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyAdvertisementsUsers : ContentPage
	{
	    public ObservableCollection<User> listUser { get; set; }
        public MyAdvertisementsUsers ()
		{
			InitializeComponent ();
		    listUser = new ObservableCollection<User>()
		    {
		        new User(){login = "Marek32", Name = "Marek", Surname = "Kowalski", Age = 32, src = "https://us.v-cdn.net/5019960/uploads/userpics/123/nGMH7CNV8ZTVP.png"},
		        new User(){login = "Karol73", Name = "Karol", Surname = "Mielski", Age = 27, src = "https://i.pinimg.com/736x/28/c0/ef/28c0ef82b165f2b2c12e98106d602a37--girl-face-woman-face.jpg"}
		    };


		    listViewPeople.ItemsSource = listUser;
        }

	}
}