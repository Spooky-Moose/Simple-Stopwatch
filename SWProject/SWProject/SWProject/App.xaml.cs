using System;
using Xamarin.Forms;
using SWProject.Views;
using System.Diagnostics;

namespace SWProject
{
    public partial class App : Application
    {

       
        public App()
        {
            InitializeComponent();

            MainPage = new SWProjectPage();
            
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
