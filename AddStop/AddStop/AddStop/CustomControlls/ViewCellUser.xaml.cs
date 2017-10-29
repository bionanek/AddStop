using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddStop.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AddStop.CustomControlls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ViewCellUser : ViewCell
	{
		public ViewCellUser ()
		{
			InitializeComponent ();
		}

	    private async void Button_OnClicked(object sender, EventArgs e)
	    {
	        await Application.Current.MainPage.Navigation.PushModalAsync(new MessagePageView());
        }
	}
}