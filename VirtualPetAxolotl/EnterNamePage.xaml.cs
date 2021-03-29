using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using VirtualPetAxolotl.AxolotlSpace;

namespace VirtualPetAxolotl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EnterNamePage : ContentPage
    {
        private Axolotl axolotl = new Axolotl();

        public EnterNamePage()
            {
                InitializeComponent();
            }

        async void SaveAxolotlName(object sender, EventArgs e)
        {
            axolotl.AxoltolName = AxolotlNameInput.Text;
            Axolotl.Init();
            await DisplayAlert("Meet Your New Pet!", "To get started, tap on the gear icon > Help to get the low down on how to take care of your axoltol", "OK");
            await Navigation.PushModalAsync(new Dashboard());
        }
    }
}