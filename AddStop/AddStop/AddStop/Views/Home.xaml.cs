using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddStop.ViewModels;
using AddStop.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AddStop
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : TabbedPage
    {
        private INavigation Navigation { get; set; }
        public Home (INavigation nav)
        {
            this.Navigation = nav;
            InitializeComponent();
            BindingContext = new HomeViewModel(Navigation);

            this.Children.Add(new AdvertisementsView(this.Navigation));
            this.Children.Add(new ArichivesView());
            this.Children.Add(new MyAdvertisementsView());
            this.Children.Add(new JournalView());
            this.Children.Add(new MapView());
            this.Children.Add(new BackpackView());
        }
    }
}