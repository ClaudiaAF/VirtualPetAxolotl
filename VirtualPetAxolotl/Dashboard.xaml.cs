using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPetAxolotl.StateSpace;
using VirtualPetAxolotl.AxolotlSpace;
using VirtualPetAxolotl;
using System.Timers;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VirtualPetAxolotl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dashboard : ContentPage
    {
        public static Dashboard Current;
        private Axolotl axolotl = new Axolotl();
        public Dashboard()
        {
            InitializeComponent();
            Current = this;
            axolotlImage.Source = Axolotl.AxolotlState.CurrentStateType.ToString();
            UpdateXpLevel();

            

            if (axolotlNameLabel.Text != axolotl.AxoltolName)
            {
                axolotlNameLabel.Text = axolotl.AxoltolName;
            }
        }

        

        async void menuClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MenuPage());
        }
        public static void UpdateAxolotlImage()
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                Current.axolotlImage.Source = Axolotl.AxolotlState.CurrentStateType.ToString();
            });

            if (Axolotl.AxolotlState.CurrentStateType == AxolotlStateType.Dead)
            {
                Current.AxolotlDead();
            }
        }
        

        public static void UpdateXpLevel()
        {
            int axolotlXp = Axolotl.Xp;

            if (axolotlXp < 1)
            {
                Current.levelLabel.Text = "Care Needed";
                Current.xpLabel.Text = "tap the plant to feed your Axolotl";
            }
            else
            {
                Current.levelLabel.Text = "Level " + Levels.GetLevelFromXp(axolotlXp).ToString();
                Current.xpLabel.Text = axolotlXp.ToString();
            }
        }

        public static void UpdateAxolotlHpBar()
        {
            Current.xpProgBar.ProgressTo(Axolotl.AxolotlState.HP / 100.0, 1000, Easing.Linear);
        }

        public static void UpdateHungerHpBar()
        {
            Current.xpProgBarHunger.ProgressTo(Axolotl.HungerState.HP / 100.0, 1000, Easing.Linear);
        }

        public static void UpdateTankHpBar()
        {

            Current.xpProgBarClean.ProgressTo(Axolotl.TankState.HP / 100.0, 1000, Easing.Linear);
        }

        public static void UpdateFitlerHpBar()
        {
            Current.xpProgBarFilter.ProgressTo(Axolotl.FilterState.HP / 100.0, 1000, Easing.Linear);
        }

     /*   async void EditNameTapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new EnterNamePage());
        }*/


        void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            Axolotl.GiveAttention();
        }

        void TouchCommand(object sender, EventArgs args)
        {
            Axolotl.WaterCold();
        }

        private void AxolotlDead()
        {
            try

            {
                Axolotl.AxolotlState.HP = 0;
                Axolotl.TankState.HP = 0;
                Axolotl.FilterState.HP = 0;
                Axolotl.HungerState.HP = 0;
                UpdateHungerHpBar();
                UpdateAxolotlHpBar();
                UpdateTankHpBar();
                UpdateFitlerHpBar();
                Axolotl.TimeKeeper.destroyTimer();

                Device.BeginInvokeOnMainThread(async () =>
                {
                    bool answer = await Current.DisplayAlert("Dead", "Your Axolotl has died", "New Axolotl?", "Cancel");

                    if (answer)
                    {
                        
                        axolotlImage.Source = Axolotl.AxolotlState.CurrentStateType.ToString();
                        await Navigation.PushModalAsync(new EnterNamePage());


                    }
                });
                    
            } catch (Exception ex)
            {
                Console.Write(ex.StackTrace);
            }
        }


        void feedAxolotlTapped(System.Object sender, System.EventArgs e)
        {
            Axolotl.Feed();
        }


        public void OnDrop(object sender, DropEventArgs e)
        {
            Axolotl.ReplaceFitler();

        }

        void Handle_SlideCompleted(object sender, System.EventArgs e)
        {
            Axolotl.CleanTank();

            MessageLbl.Text = "All Clean";
            MessageLbl.Opacity = 1;
            MessageLbl.FadeTo(0, 1000);
        }
    }
}