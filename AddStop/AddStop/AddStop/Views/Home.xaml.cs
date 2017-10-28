using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddStop.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AddStop
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : TabbedPage
    {
        public Home ()
        {
            InitializeComponent();
            this.Children.Add(new AdvertisementsView());
            this.Children.Add(new ArichivesView());
            this.Children.Add(new MyAdvertisementsView());
            this.Children.Add(new JournalView());
            this.Children.Add(new MapView());
            this.Children.Add(new BackpackView());
        }
    }
}