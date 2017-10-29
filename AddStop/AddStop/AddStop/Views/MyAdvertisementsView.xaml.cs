using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddStop.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AddStop.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyAdvertisementsView : ContentPage
	{
	    public INavigation Navigation { get; set; }

        public MyAdvertisementsView (INavigation nav)
        {
            Navigation = nav;
			InitializeComponent ();
		    BindingContext =new MyAdvertisementsViewModel(Navigation);
		}
	}
}