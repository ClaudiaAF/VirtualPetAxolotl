using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPetAxolotl.Objects1;
using VirtualPetAxolotl.NewFolder1;
using VirtualPetAxolotl;
using System.Timers;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VirtualPetAxolotl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dashboard : ContentPage
    {

        private  Axolotl axolotl = new Axolotl();

        void updateUI()
        {
            int axolotlXp = axolotl.Xp;

            if (axolotlXp < 1)
            {
                levelLabel.Text = "Not being cared for";
                xpLabel.Text = "tap the plant to feed your Axolotl";
            } 
            else
            {
                levelLabel.Text = "Level 1" + Levels.GetLevelFromXp(axolotlXp).ToString();
                xpLabel.Text = axolotlXp.ToString();
            }



            Device.BeginInvokeOnMainThread(async () =>
            {
                axolotlImage.Source = "Axolotl_" + axolotl.CurrentAxolotlState + "_" + (Levels.GetLevelFromXp(axolotlXp) + 1).ToString();

                if (axolotl.CurrentAxolotlState == AxolotlState.sick)
                {
                    AxolotlDead();

                } else if (axolotl.CurrentAxolotlState == AxolotlState.nothealthy) {

                    DisplayAlert("Lovesick", "Your Axolotl is missing you! Double tap on your pets tummy to remind him you're here", "Give Attention");
                }
            });
        }



        
        public Dashboard()
        {
            InitializeComponent();

            updateUI();
            StartTimer();


        }


        void feedAxolotlTapped(System.Object sender, System.EventArgs e)
        {
            RestartTimer();

            axolotl.giveFood();

            updateUI();
        }
        void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            RestartTimer();

            axolotl.giveAttention();

            updateUI();
        }
        void Handle_SlideCompleted(object sender, System.EventArgs e)
        {
            RestartTimer();

            axolotl.cleanTank();

            updateUI();
            MessageLbl.Text = "All Clean";
            MessageLbl.Opacity = 1;
            MessageLbl.FadeTo(0, 1000);

        }


        private async void AxolotlDead()
        {
            await DisplayAlert("Dead", "Your Axolotl has died", "New Axolotl");

            axolotl.Xp = 0;
            axolotl.CurrentAxolotlState = AxolotlState.healthy;
            RestartTimer();

            updateUI();
        }


        private Timekeeper timekeeper = new Timekeeper();

        private static Timer timer;

        private void StartTimer()
        {
            timer = new Timer();

            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Elapsed += UpdateTimedData;
            timer.Start();
        }

        private void RestartTimer()
        {
            timekeeper.StartTime = DateTime.Now;

            StartTimer();
        }

        private void UpdateTimedData(object sender, ElapsedEventArgs e)
        {
            TimeSpan timeElapsed = e.SignalTime - timekeeper.StartTime;

            AxolotlState newAxolotlState = axolotl.CurrentAxolotlState;

            if (timeElapsed.TotalSeconds < 20)
            {
                newAxolotlState = AxolotlState.healthy;
            }
            else if (timeElapsed.TotalSeconds < 30)
            {
                newAxolotlState = AxolotlState.nothealthy;
            }
            else if (timeElapsed.TotalSeconds >= 40)
            {
                newAxolotlState = AxolotlState.sick;
            }

            if (newAxolotlState != axolotl.CurrentAxolotlState)
            {
                axolotl.CurrentAxolotlState = newAxolotlState;
                updateUI();
            }
        }
    }

    //swipe to clean function
    
}