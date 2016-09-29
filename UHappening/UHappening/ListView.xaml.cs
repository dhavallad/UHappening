using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace UHappening
{
    public partial class ListView : ContentPage
    {
        public ListView()
        {
            InitializeComponent();

            MainList.ItemsSource = new List<Event>
            {
                new Event
                {
                    name="abc",
                    type="Dance"

                },
                new Event
                {
                    name="def",
                    type="Dance"

                },
                new Event
                {
                    name="ghi",
                    type="Dance"

                },
                new Event
                {
                    name="jkl",
                    type="Dance"

                },
                new Event
                {
                    name="mno",
                    type="Dance"

                }
            };
        }
    }
}
