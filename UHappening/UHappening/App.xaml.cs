using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace UHappening
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

           // MainPage = new MainPage();
            MainPage = new MainPage();
            //MainPage = new TabbedPage  // can also use "CarouselPage" 
            //{
            //    Children =
            //    {
            //        new MainPage(),
            //        new Welcome()
                    
            //    }
            //};
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
