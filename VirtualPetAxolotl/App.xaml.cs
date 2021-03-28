using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VirtualPetAxolotl
{
    public partial class App : Application
    { 

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            Console.WriteLine("OnStart");
        }

        protected override void OnSleep()
        {
            Console.WriteLine("OnSleep");

        }

        protected override void OnResume()
        {
            Console.WriteLine("OnResume");

        }
    }
}
