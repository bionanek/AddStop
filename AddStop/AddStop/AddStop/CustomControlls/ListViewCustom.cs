using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AddStop.CustomControlls
{
    public class ListViewCustom : ListView
    {
        protected override void SetupContent(Cell pContent, int pIndex)
        {
            base.SetupContent(pContent, pIndex);
            var currentViewCell = pContent as ViewCell;

            if (currentViewCell != null)
            {
                currentViewCell.View.BackgroundColor = pIndex % 2 == 0 ? Color.White : Color.FromHex("#e5e9ec");
            }
        }


        public ListViewCustom(ListViewCachingStrategy strategy) : base(strategy)
        {

        }

        public ListViewCustom()
        {
        }
    }
}