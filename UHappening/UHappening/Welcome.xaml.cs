using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UHappening
{
    public partial class Welcome : MasterDetailPage
    {
        public Welcome()
        {
            InitializeComponent();
        }
        public Welcome(Page p)
        {
            InitializeComponent();
        }
        public Welcome(string text)
        {
            InitializeComponent();
            //use the text that was sent from the previous page
        }
    }
}