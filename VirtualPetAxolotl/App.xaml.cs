using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using VirtualPetAxolotl.NewFolder1;

namespace VirtualPetAxolotl
{
    public partial class App : Application
    { 
        private Timekeeper timeKeeper = new Timekeeper();

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            Console.WriteLine("OnStart");

            Console.WriteLine(timeKeeper.StoredTime);
            Console.WriteLine(timeKeeper.GetTimeElapsed());
        }

        protected override void OnSleep()
        {
            Console.WriteLine("OnSleep");

            timeKeeper.StoredTime = DateTime.Now;
        }

        protected override void OnResume()
        {
            Console.WriteLine("OnResume");

            Console.WriteLine(timeKeeper.StoredTime);
            Console.WriteLine(timeKeeper.GetTimeElapsed());
        }
    }
}
