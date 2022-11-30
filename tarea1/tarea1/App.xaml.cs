using System;
using System.IO;
using Xamarin.Forms;

namespace tarea1
{
    public partial class App : Application
    {


        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.Page2());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
