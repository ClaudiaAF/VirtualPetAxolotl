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
            Axolotl.Init();
            axolotlImage.Source = Axolotl.AxolotlState.CurrentStateType.ToString();
        }

        public static void UpdateAxolotlImage()
        {
            Current.axolotlImage.Source = Axolotl.AxolotlState.CurrentStateType.ToString();

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
                Current.levelLabel.Text = "Not being cared for";
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
            if (Axolotl.HungerState.CurrentStateType == HungerStateType.Hungry)
            {
                Current.needIcon.FadeTo(1, 700, Easing.BounceIn);
            }
        }

        public static void UpdateTankHpBar()
        {
            if (Axolotl.TankState.CurrentStateType == TankStateType.Unclean)
            {
                Current.needIcon.FadeTo(1, 700, Easing.BounceIn);
            }

            Current.xpProgBarClean.ProgressTo(Axolotl.TankState.HP / 100.0, 1000, Easing.Linear);
        }

        public static void UpdateFitlerHpBar()
        {
            if (Axolotl.FilterState.CurrentStateType == FilterStateType.Dirty)
            {
                Current.needIcon.FadeTo(1, 700, Easing.BounceIn);
            }
        }

        async void EditNameTapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new EnterNamePage());
        }

        async void ReplaceFilterPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ReplaceFilter());
        }

        void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            axolotl.GiveAttention();
        }
       
        private void AxolotlDead()
        {
            try
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    bool answer = await Current.DisplayAlert("Dead", "Your Axolotl has died", "New Axolotl?", "Nah");

                    if (answer)
                    {
                        Axolotl.Init();
                    }
                });
                    
            } catch (Exception ex)
            {
                Console.Write(ex.StackTrace);
            }
        }


        void feedAxolotlTapped(System.Object sender, System.EventArgs e)
        {
            axolotl.Feed();
        }

        public void OnDrop(object sender, DropEventArgs e)
        {
            axolotl.ReplaceFitler();

        }

        void Handle_SlideCompleted(object sender, System.EventArgs e)
        {
            axolotl.CleanTank();

            MessageLbl.Text = "All Clean";
            MessageLbl.Opacity = 1;
            MessageLbl.FadeTo(0, 1000);
        }
    }
}