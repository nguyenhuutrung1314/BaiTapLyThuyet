using Baitaptuan4.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Baitaptuan4
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PageInsetLoaihoa();
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
