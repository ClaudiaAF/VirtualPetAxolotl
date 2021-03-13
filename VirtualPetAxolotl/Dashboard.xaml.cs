using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPetAxolotl.NewFolder1;
using VirtualPetAxolotl;

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
                xpLabel.Text = "tap the plant to feed your pet";
            } else
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
                }
            });
        }

        public Dashboard()
        {
            InitializeComponent();

            updateUI();

        }

        void feedAxolotlTapped(System.Object sender, System.EventArgs e)
        {
            axolotl.giveFood();

            updateUI();
        }

        private async void AxolotlDead()
        {
            await DisplayAlert("Dead", "Your Axolotl has died", "New Axolotl");

            axolotl.Xp = 0;
            axolotl.CurrentAxolotlState = AxolotlState.healthy;
           

            updateUI();
        }
    }
}