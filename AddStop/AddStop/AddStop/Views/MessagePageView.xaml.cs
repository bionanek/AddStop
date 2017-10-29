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
	public partial class MessagePageView : ContentPage
	{
        public ObservableCollection<Message> messages;
        public MessagePageView ()
		{
			InitializeComponent ();
		    messages = new ObservableCollection<Message>()
		    {
		        new Message() {text = "Kamil: Hej!"},
		        new Message() {text = "Ja: Cześć!"},
		        new Message() {text = "Kamil: Co tam?"}
		    };
		    listView.ItemsSource = messages;
		}
	}
}