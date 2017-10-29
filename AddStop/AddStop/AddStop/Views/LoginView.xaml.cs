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
	public partial class LoginView : ContentPage
	{
		public LoginView ()
		{
		    this.BindingContext = new LoginViewModel(Navigation);
            InitializeComponent ();
            
		}
	}
}